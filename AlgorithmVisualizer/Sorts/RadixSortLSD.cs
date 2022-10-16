using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AlgorithmVisualizer.Sorts {
    class RadixSortLSD : Sort {
        public RadixSortLSD(int[] values, int[] ints, bool[] bools, Graphics graphics, Color foregroundColor) {
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

        int ind = 1;
        public override void StepOnce() {
            CountSort(_values, _values.Length, ind);
            for (int i = 0; i < _values.Length - 1; i++) {
                Draw(i);
            }
        }

        private void CountSort(int[] array, int size, int place) {
            try {
                ind *= 10;

                int[] output = new int[size + 1];
                int max = array[0];
                for (int i = 1; i < size; i++) {
                    if (array[i] > max) max = array[i];
                }

                int[] count = new int[max + 1];

                for (int i = 0; i < max; i++) {
                    count[i] = 0;
                }

                for (int i = 0; i < size; i++) {
                    count[(array[i] / place) % 10]++;
                }

                for (int i = 1; i < 10; i++) {
                    count[i] += count[i - 1];
                }

                for (int i = size - 1; i >= 0; i--) {
                    output[count[(array[i] / place) % 10] - 1] = array[i];
                    count[(array[i] / place) % 10]--;
                }

                for (int i = 0; i < size; i++) {
                    array[i] = output[i];
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Error during CountingSort (in RadixSortLSD): {ex.Message}");
            }
        }

        public override void Draw(int i) {
            if (i % 3 == 0) Thread.Sleep(1); // make it slow enough to render at 0 slowdown

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

                if (Paused) return;
            }
            catch (Exception ex) {
                MessageBox.Show($"Error drawing: {ex.Message}");
            }
        }
    }
}
