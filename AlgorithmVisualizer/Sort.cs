using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmVisualizer {
    public abstract class Sort {
        public bool Paused { get; set; }
        public abstract void StepOnce();
        public abstract void Draw(int i);

        // none of this should be here but its better to me
        public void DrawOnceSorted(int[] values, int maxValue, int scale, Graphics g) {
            SolidBrush brush = new SolidBrush(Color.Green);
            try {
                for (int i = 0; i < values.Length - 1; i++) {
                    if (i % 10 == 0) Thread.Sleep(1); // slowdown
                    g.FillRectangle(brush, i * scale, maxValue - values[i], 1 * scale, maxValue);
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Error drawing green once sorted: {ex.Message}");
            }
            finally {
                brush.Dispose();
            }
        }

        public bool IsSorted(int[] values) {
            for (int i = 0; i < values.Length - 1; i++) {
                if (values[i] > values[i + 1]) return false;
            }
            return true;
        }

        public void Redraw(int[] values, int maxVal, int scale, Graphics g, Color foregroundCol, bool gradient) {
            SolidBrush brush = new SolidBrush(Color.White);
            try {
                g.Clear(Color.Black);
                for (int i = 0; i < values.Length - 1; i++) {
                    if (gradient) {
                        brush.Color = GradientColor(values, maxVal, foregroundCol, i);
                        g.FillRectangle(brush, i * scale, maxVal - values[i], 1 * scale, maxVal);
                    }
                    else {
                        brush.Color = foregroundCol;
                        g.FillRectangle(brush, i * scale, maxVal - values[i], 1 * scale, maxVal);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Error redrawing, if not paused then pause sorting. ERROR: {ex.Message}");
            }
            finally {
                brush.Dispose();
            }
        }

        public Color GradientColor(int[] values, int maxVal, Color foregroundCol, int index) {
            int c = maxVal * values[index] / values.Length;
            int d = (int)(values.Length / (maxVal / (0.077 * values.Length)));
            int rc = foregroundCol.R - c / d <= 0 ? 1 : foregroundCol.R - c / d;
            int gc = foregroundCol.G - c / d <= 0 ? 1 : foregroundCol.G - c / d;
            int bc = foregroundCol.B - c / d <= 0 ? 1 : foregroundCol.B - c / d;
            return Color.FromArgb(rc, gc, bc);
        }
    }
}
