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
        public abstract void StepOnce();
        public abstract void Draw(int i);

        // none of this should be here but its better to me
        public void DrawOnceSorted(int[] values, int maxValue, int scale, Graphics g) {
            SolidBrush brush = new SolidBrush(Color.Green);
            try {
                for (int i = 0; i < values.Length; i++) {
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

        // this is now broken even though the gdnt should be much better than the old solution
        public Color GradientColor(int[] values, int maxVal, Color foregroundCol, int i) {
            int Gradient(int c) => (-1 * (values[i] / maxVal) * (c * values[i] / maxVal)) - (values[i] / (values.Length * maxVal)) + c + 60;
            int rg = Gradient(foregroundCol.R);
            int gg = Gradient(foregroundCol.G);
            int bg = Gradient(foregroundCol.B);
            int rc = rg > 255 ? 255 : rg <= 0 ? 1 : rg;
            int gc = gg > 255 ? 255 : gg <= 0 ? 1 : gg;
            int bc = bg > 255 ? 255 : bg <= 0 ? 1 : bg;
            //Console.Write($"({Gradient(foregroundCol.R)}, {Gradient(foregroundCol.G)}, {Gradient(foregroundCol.B)}), ({rc}, {gc}, {bc}), {values[i]}\n");
            return Color.FromArgb(rc, gc, bc);
        }
    }
}
