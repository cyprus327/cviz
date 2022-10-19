using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace AlgorithmVisualizer.Sorts {
    class BubbleSort : Sort {
        public BubbleSort(int[] values, int[] ints, bool[] bools, Graphics graphics, Color foregroundColor) {
            _values = values;
            _maxValue = ints[0];
            _scale = ints[1];
            _slowdown = ints[2];
            _gradient = bools[0];
            _g = graphics;
            _foregroundCol = foregroundColor;
        }

        private readonly int[] _values;
        private readonly int _maxValue;
        private readonly int _scale;
        private readonly int _slowdown;
        private readonly bool _gradient;
        private readonly Graphics _g;
        private readonly Color _foregroundCol;

        private readonly SolidBrush _brushForeground = new SolidBrush(Color.White);
        private readonly SolidBrush _brushBlack = new SolidBrush(Color.Black);

        public override void StepOnce() {
            try {
                for (int i = 0; i < _values.Length - 1; i++) {
                    if (_values[i] > _values[i + 1]) {
                        int t = _values[i];
                        _values[i] = _values[i + 1];
                        _values[i + 1] = t;
                        Draw(i);
                        Draw(i + 1);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Error during BubbleSort: {ex.Message}");
            }
        }

        public override void Draw(int i) {
            try {
                Thread.Sleep(_slowdown);

                _g.FillRectangle(_brushBlack, i * _scale, 0, 1 * _scale, _maxValue);

                if (_gradient) {
                    _brushForeground.Color = GradientColor(_values, _maxValue, _foregroundCol, i);
                    _g.FillRectangle(_brushForeground, i * _scale, _maxValue - _values[i], 1 * _scale, _maxValue);
                }
                else {
                    _brushForeground.Color = _foregroundCol;
                    _g.FillRectangle(_brushForeground, i * _scale, _maxValue - _values[i], 1 * _scale, _maxValue);
                }

                //if (Paused) return;
            }
            catch (Exception ex) {
                MessageBox.Show($"Error drawing: {ex.Message}");
            }
        }
    }
}
