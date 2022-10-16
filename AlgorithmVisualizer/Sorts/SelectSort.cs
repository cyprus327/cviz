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
    class SelectSort : Sort {
        public SelectSort(int[] values, int[] ints, bool[] bools, Graphics graphics, Color foregroundColor) {
            _values = values;
            _maxValue = ints[0];
            _scale = ints[1];
            _slowdown = ints[2];
            _gradient = bools[0];
            _showEveryStep = bools[1];
            _g = graphics;
            _foregroundCol = foregroundColor;
        }

        private readonly int[] _values;
        private readonly int _maxValue;
        private readonly int _scale;
        private readonly int _slowdown;
        private readonly bool _gradient;
        private readonly bool _showEveryStep;
        private readonly Graphics _g;
        private readonly Color _foregroundCol;

        private readonly SolidBrush _brushForeground = new SolidBrush(Color.White);
        private readonly SolidBrush _brushBlack = new SolidBrush(Color.Black);

        int i = 0;
        public override void StepOnce() {
            try {
                for (int j = i + 1; j < _values.Length; j++) {
                    if (_values[i] > _values[j]) {
                        int t = _values[i];
                        _values[i] = _values[j];
                        _values[j] = t;
                        if (!_showEveryStep) {
                            Draw(j);
                            Draw(i);
                        }
                        if (_showEveryStep) {
                            for (int i = 0; i < _values.Length - 1; i++) {
                                Draw(i);
                                Draw(j);
                            }
                        }
                    }
                }
                i++;
            }
            catch (Exception ex) {
                MessageBox.Show($"Error during SelectSort: {ex.Message}");
            }
        }

        public override void Draw(int i) {
            try {
                Thread.Sleep(_slowdown);

                _g.FillRectangle(_brushBlack, i * _scale, 0, 2 * _scale, _maxValue); // KEEP THE 2

                if (_gradient) {
                    _brushForeground.Color = GradientColor(_values, _maxValue, _foregroundCol, i);
                    _g.FillRectangle(_brushForeground, i * _scale, _maxValue - _values[i], 1 * _scale, _maxValue);
                }
                else {
                    _brushForeground.Color = _foregroundCol;
                    _g.FillRectangle(_brushForeground, i * _scale, _maxValue - _values[i], 1 * _scale, _maxValue);
                }

                if (Paused) return;
            }
            catch (Exception ex) {
                MessageBox.Show($"Error drawing: {ex.Message}");
            }
        }
    }
}
