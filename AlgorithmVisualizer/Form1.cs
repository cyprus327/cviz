using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgorithmVisualizer.Sorts;

namespace AlgorithmVisualizer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private int[] _values;

        private int _sortTimeMillis = 0;
        private int _currentSelectedSort = 0;
        private int _maxValue = 0;
        private int _scale = 5;
        private int _slowdown = 0;
        private bool _gradient = true;
        private bool _showEveryStep = false;
        private bool _playing = false;

        private readonly Random _r = new Random();
        private Graphics _g = null;
        private BackgroundWorker _bw = null;
        private Color _foregroundColor = Color.White;

        private Sort _sort;

        private void Form1_Load(object sender, EventArgs e) {
            _bw = new BackgroundWorker { WorkerSupportsCancellation = true };
            _bw.DoWork += new DoWorkEventHandler(Bw_DoWork);
            _bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Bw_DoWhenSorted);
        }

        private Sort GetCurrentlySelectedSort() { // also sets current sort to a new sort not just gets
            int[] ints = new int[] { _maxValue, _scale, _slowdown };
            bool[] bools = new bool[] { _gradient, _showEveryStep };

            switch (_currentSelectedSort) {
                case 0:
                    return new BubbleSort(_values, ints, bools, _g, _foregroundColor);
                case 1:
                    return new SelectSort(_values, ints, bools, _g, _foregroundColor);
                case 2:
                    return new RadixSortLSD(_values, ints, bools, _g, _foregroundColor);
                default:
                    return null;
            }
        }

        private void RandomizeValues() {
            _bw.CancelAsync();
            if (_playing) PauseSort();

            int numberOfValues = panel1.Width / _scale;
            _maxValue = panel1.Height;
            _values = new int[numberOfValues];

            for (int i = 0; i < numberOfValues; i++) {
                _values[i] = (_maxValue*i)/numberOfValues;
            }
            _values = _values.OrderBy(x => _r.Next()).ToArray();

            _g = panel1.CreateGraphics();
            _g.Clear(Color.Black);

            _sort = GetCurrentlySelectedSort();
            _sort.Redraw(_values, _maxValue, _scale, _g, _foregroundColor, _gradient);
        }

        private void PauseSort() {
            if (_bw.CancellationPending) _bw.CancelAsync();
            _sort.Paused = true;

            _playing = false;
            playPauseButton.Text = "Play";

            SortLengthTimer.Stop();
        }
        private void PlaySort() {
            if (_bw == null || _g == null) return;

            _sort.Paused = false;
            if (!_bw.IsBusy) _bw.RunWorkerAsync();
            else return;

            _sort = GetCurrentlySelectedSort();
            _playing = true;
            playPauseButton.Text = "Pause";

            SortLengthTimer.Start();
        }

        private void OnSortFinished() {
            PauseSort();
            TimeLabel.Text = $"{_sortTimeMillis}ms sorting time ({_sortTimeMillis/1000}s) to sort {_values.Length} element array.";
            _sortTimeMillis = 0;
        }

        private void SortLengthTimer_Tick(object sender, EventArgs e) {
            _sortTimeMillis++;
        }

        #region bg worker
        private void Bw_DoWork(object sender, DoWorkEventArgs args) {
            try {
                do {
                    _sort.StepOnce();
                } while (!_sort.IsSorted(_values) && !_bw.CancellationPending && _playing);
            }
            catch (Exception ex) {
                MessageBox.Show($"Error when sorting: {ex.Message}");
            }
        }

        private void Bw_DoWhenSorted(object sender, RunWorkerCompletedEventArgs args) {
            try {
                if (_sort.IsSorted(_values)) {
                    _sort.DrawOnceSorted(_values, _maxValue, _scale, _g);
                    OnSortFinished();
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Error finishing sort: {ex.Message}");
            }
        }
        #endregion bg worker

        #region on click
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            if (_g != null) _g.Dispose();
            Application.Exit();
        }

        private void playPauseButton_Click(object sender, EventArgs e) {
            if (_playing) {
                PauseSort();
            }
            else {
                PlaySort();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            RandomizeValues();
            RandomizeValues();
            TimeLabel.Text = String.Empty;
            // keep the second call for now
        }

        private void GradientSelectToolStripMenuItem_Click(object sender, EventArgs e) {
            _gradient = ! _gradient;
            ShowScanlineToolStripMenuItem.BackColor = _gradient ? Color.Green : Color.Red;
        }

        private void ShowEveryStepToolStripMenuItem_Click(object sender, EventArgs e) {
            _showEveryStep = !_showEveryStep;
            ShowEveryStepToolStripMenuItem.BackColor = _showEveryStep ? Color.Green : Color.Red;
        }

        private void bubbleSortToolStripMenuItem_Click(object sender, EventArgs e) {
            _currentSelectedSort = 0;
            _sort = GetCurrentlySelectedSort();
            currentAlgorithmLabel.Text = bubbleSortToolStripMenuItem.Text;
        }

        private void selectSortToolStripMenuItem_Click(object sender, EventArgs e) {
            _currentSelectedSort = 1;
            _sort = GetCurrentlySelectedSort();
            currentAlgorithmLabel.Text = selectSortToolStripMenuItem.Text;
        }

        private void radixLSDSortToolStripMenuItem_Click(object sender, EventArgs e) {
            _currentSelectedSort = 2;
            _sort = GetCurrentlySelectedSort();
            currentAlgorithmLabel.Text = countingSortToolStripMenuItem.Text;
        }
        #endregion on click

        #region on value changed
        private void ScaleSelector_ValueChanged(object sender, EventArgs e) {
            _scale = (int)ScaleSelector.Value;
        }

        private void SlowdownSelector_ValueChanged(object sender, EventArgs e) {
            _slowdown = (int)SlowdownSelector.Value;
        }
        #endregion on value changed

        #region color selection
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e) {
            _foregroundColor = whiteToolStripMenuItem.BackColor;
            colorToolStripMenuItem.BackColor = _foregroundColor;
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e) {
            _foregroundColor = cyanToolStripMenuItem.BackColor;
            colorToolStripMenuItem.BackColor = _foregroundColor;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e) {
            _foregroundColor = redToolStripMenuItem.BackColor;
            colorToolStripMenuItem.BackColor = _foregroundColor;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e) {
            _foregroundColor = blueToolStripMenuItem.BackColor;
            colorToolStripMenuItem.BackColor = _foregroundColor;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e) {
            _foregroundColor = greenToolStripMenuItem.BackColor;
            colorToolStripMenuItem.BackColor = _foregroundColor;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e) {
            _foregroundColor = yellowToolStripMenuItem.BackColor;
            colorToolStripMenuItem.BackColor = _foregroundColor;
        }

        private void greyToolStripMenuItem_Click(object sender, EventArgs e) {
            _foregroundColor = greyToolStripMenuItem.BackColor;
            colorToolStripMenuItem.BackColor = _foregroundColor;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e) {
            _foregroundColor = purpleToolStripMenuItem.BackColor;
            colorToolStripMenuItem.BackColor = _foregroundColor;
        }
        #endregion color selection
    }
}
