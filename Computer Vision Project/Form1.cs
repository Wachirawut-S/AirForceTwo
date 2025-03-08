using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Emgu.CV.Util;

namespace Computer_Vision_Project
{
    public partial class Form1 : Form
    {
        private VideoCapture capture;
        private bool isVideoCapture = false;
        private Mat frame;
        private Image<Bgr, Byte> image;

        // HSV Thresholds
        private int upperHue = 127, lowerHue = 0;
        private int upperSat = 255, lowerSat = 0;
        private int upperVal = 255, lowerVal = 0;

        private List<Point>[] points;
        private int colorIndex = 0;

        private readonly Color[] colors = { Color.Blue, Color.Green, Color.Red, Color.Yellow };
        public Form1()
        {
            InitializeComponent();
            try
            {
                capture = new VideoCapture(0);
                capture.ImageGrabbed += ProcessFrame;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            frame = new Mat();

            // Initialize point lists
            points = new List<Point>[4];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new List<Point>();
            }

            // Trackbars for HSV adjustment
            trackBar1.ValueChanged += (s, e) =>
            {
                upperHue = trackBar1.Value;
                label1.Text = $"Hue: {lowerHue}-{upperHue}";
            };
            trackBar2.ValueChanged += (s, e) =>
            {
                lowerHue = trackBar2.Value;
                label1.Text = $"Hue: {lowerHue}-{upperHue}";
            };
            trackBar3.ValueChanged += (s, e) =>
            {
                upperSat = trackBar3.Value;
                label3.Text = $"Saturation: {lowerSat}-{upperSat}";
            };
            trackBar4.ValueChanged += (s, e) =>
            {
                lowerSat = trackBar4.Value;
                label3.Text = $"Saturation: {lowerSat}-{upperSat}";
            };
            trackBar5.ValueChanged += (s, e) =>
            {
                upperVal = trackBar5.Value;
                label6.Text = $"Value: {lowerVal}-{upperVal}";
            };
            trackBar6.ValueChanged += (s, e) =>
            {
                lowerVal = trackBar6.Value;
                label6.Text = $"Value: {lowerVal}-{upperVal}";
            };
        }

        // Helper method to reset HSV thresholds and update UI
        private void ResetHSVPreset(int lH, int uH, int lS, int uS, int lV, int uV)
        {
            lowerHue = lH;
            upperHue = uH;
            lowerSat = lS;
            upperSat = uS;
            lowerVal = lV;
            upperVal = uV;
            // Update trackbar values
            trackBar1.Value = upperHue;
            trackBar2.Value = lowerHue;
            trackBar3.Value = upperSat;
            trackBar4.Value = lowerSat;
            trackBar5.Value = upperVal;
            trackBar6.Value = lowerVal;
            // Update label texts
            label1.Text = $"Hue: {lowerHue}-{upperHue}";
            label3.Text = $"Saturation: {lowerSat}-{upperSat}";
            label6.Text = $"Value: {lowerVal}-{upperVal}";
        }

        private void ProcessFrame(object? sender, EventArgs e)
        {
            if (capture != null && capture.Ptr != IntPtr.Zero)
            {
                capture.Retrieve(frame, 0);
                image = frame.ToImage<Bgr, Byte>();
                CvInvoke.Flip(image, image, FlipType.Horizontal);

                if (checkBox1.Checked)
                {
                    // Convert to HSV
                    var hsvImage = image.Convert<Hsv, Byte>();

                    // Create mask based on HSV range
                    var lowerBound = new Hsv(lowerHue, lowerSat, lowerVal);
                    var upperBound = new Hsv(upperHue, upperSat, upperVal);
                    var mask = hsvImage.InRange(lowerBound, upperBound);

                    // Preprocessing mask
                    CvInvoke.Erode(mask, mask, null, new Point(-1, -1), 1, BorderType.Default, new MCvScalar());
                    CvInvoke.Dilate(mask, mask, null, new Point(-1, -1), 1, BorderType.Default, new MCvScalar());

                    // Find contours
                    var contours = new VectorOfVectorOfPoint();
                    CvInvoke.FindContours(mask, contours, null, RetrType.External, ChainApproxMethod.ChainApproxSimple);

                    if (contours.Size > 0)
                    {
                        // Get largest contour
                        var largestContour = contours[0];
                        double maxArea = CvInvoke.ContourArea(largestContour);

                        for (int i = 1; i < contours.Size; i++)
                        {
                            double area = CvInvoke.ContourArea(contours[i]);
                            if (area > maxArea)
                            {
                                largestContour = contours[i];
                                maxArea = area;
                            }
                        }

                        var moments = CvInvoke.Moments(largestContour);
                        int centerX = (int)(moments.M10 / moments.M00);
                        int centerY = (int)(moments.M01 / moments.M00);
                        var center = new Point(centerX, centerY);

                        // Check for button interactions
                        if (center.Y <= 65) // Top bar for color selection
                        {
                            if (center.X >= 40 && center.X <= 140)
                            {
                                // Clear button clicked
                                for (int i = 0; i < points.Length; i++)
                                    points[i].Clear();
                            }
                            else if (center.X >= 160 && center.X <= 255) colorIndex = 0;
                            else if (center.X >= 275 && center.X <= 370) colorIndex = 1;
                            else if (center.X >= 390 && center.X <= 485) colorIndex = 2;
                            else if (center.X >= 505 && center.X <= 600) colorIndex = 3;
                        }
                        else
                        {
                            points[colorIndex].Add(center);
                        }

                        CvInvoke.Circle(image, center, 5, new MCvScalar(0, 255, 255), -1);
                    }

                    // Draw stored lines
                    for (int i = 0; i < points.Length; i++)
                    {
                        for (int j = 1; j < points[i].Count; j++)
                        {
                            if (points[i][j - 1] != Point.Empty && points[i][j] != Point.Empty)
                            {
                                CvInvoke.Line(image, points[i][j - 1], points[i][j], new MCvScalar(colors[i].B, colors[i].G, colors[i].R), 2);
                            }
                        }
                    }

                    // Draw UI buttons
                    DrawButtons(image);
                    imageBox1.Image = image;
                }
                else
                {
                    // Show image without processing
                    imageBox1.Image = image;
                }
            }
        }

        private void DrawButtons(Image<Bgr, byte> image)
        {
            CvInvoke.Rectangle(image, new Rectangle(40, 1, 100, 65), new MCvScalar(122, 122, 122), -1);
            CvInvoke.PutText(image, "CLEAR", new Point(60, 40), FontFace.HersheySimplex, 0.5, new MCvScalar(255, 255, 255), 2);

            for (int i = 0; i < colors.Length; i++)
            {
                int x = 160 + (i * 115);
                CvInvoke.Rectangle(image, new Rectangle(x, 1, 95, 65), new MCvScalar(colors[i].B, colors[i].G, colors[i].R), -1);
                CvInvoke.PutText(image, colors[i].Name.ToUpper(), new Point(x + 20, 40), FontFace.HersheySimplex, 0.5, new MCvScalar(255, 255, 255), 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                if (!isVideoCapture)
                {
                    button1.Text = "Stop Cam";
                    button1.BackColor = Color.Red;
                    capture.Start();
                }
                else
                {
                    button1.Text = "Start Cam";
                    button1.BackColor = Color.Black;
                    capture.Stop();
                }
                isVideoCapture = !isVideoCapture;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Optionally add other functionality for button2
        }

        // ---------------- Preset Menu Event Handlers ----------------

        private void trackRedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Red preset: Note that red can span the low and high ends of the hue range.
            // Here we set one range (e.g., lower red). Adjust as needed.
            ResetHSVPreset(0, 10, 100, 255, 100, 255);
        }

        private void trackGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetHSVPreset(35, 85, 100, 255, 100, 255);
        }

        private void trackBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetHSVPreset(85, 125, 100, 255, 100, 255);
        }

        private void trackYellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetHSVPreset(20, 30, 100, 255, 100, 255);
        }

        private void trackOrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetHSVPreset(10, 20, 100, 255, 100, 255);
        }

        private void trackPurpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetHSVPreset(125, 150, 100, 255, 100, 255);
        }

        private void trackPinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetHSVPreset(150, 170, 100, 255, 100, 255);
        }

        private void trackCyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetHSVPreset(85, 100, 100, 255, 100, 255);
        }

        private void trackBlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetHSVPreset(0, 180, 0, 255, 0, 50);
        }

        private void trackWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetHSVPreset(0, 180, 0, 30, 200, 255);
        }

        // ---------------- Other Event Handlers (if needed) ----------------

        private void trackBar1_ValueChanged(object sender, EventArgs e) { }
        private void trackBar2_ValueChanged(object sender, EventArgs e) { }
        private void trackBar4_ValueChanged(object sender, EventArgs e) { }
        private void trackBar3_ValueChanged(object sender, EventArgs e) { }
        private void trackBar3_Scroll(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPEG FILE |*.jpg|All files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image.Save(saveFileDialog1.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            ResetHSVPreset(0, 255, 0, 255, 0, 255);
        }

        private void cameraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void canvasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maskToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
