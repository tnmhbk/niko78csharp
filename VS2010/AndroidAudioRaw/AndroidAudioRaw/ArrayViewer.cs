using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace AndroidAudioRaw
{
    public partial class ArrayViewer : UserControl
    {
        private float[] _wave;

        private float _xMin = +0.0F;

        private float _xMax = +200.0F;

        private float _yMin = -32768.0F;

        private float _yMax = +32767.0F;

        private int _width;

        private int _heigth;

        private float[, ] _worldToScreen;

        private Pen _pen = new Pen(Color.Blue);

        public ArrayViewer()
        {
            InitializeComponent();
            _worldToScreen = Matrix3X3.CreateIdentity();
            SizeChanged();
        }

        public void DrawWave(short[] wave)
        {
            _wave = wave.Select(w => (float) w).ToArray();
            _xMax = wave.Length;
            float max = _wave.Max();
            float min = _wave.Min();

            RecelculateTransform();

            Invalidate();
        }

        public void DrawWave(double[] wave)
        {
            _wave = wave.Select(w => (float)w).ToArray();
            _xMax = wave.Length;
            _yMax = _wave.Max();
            _yMin = _wave.Min();

            RecelculateTransform();

            Invalidate();
        }

        public void RecelculateTransform()
        {
            // Recalculate coordinates conversion
            _worldToScreen[0, 0] = ((float)_width) / (_xMax - _xMin);
            _worldToScreen[0, 1] = 0.0F;
            _worldToScreen[0, 2] = -(_worldToScreen[0, 0] * _xMin);

            _worldToScreen[1, 0] = 0.0F;
            _worldToScreen[1, 1] = -((float)_heigth) / (_yMax - _yMin);
            _worldToScreen[1, 2] = -(_worldToScreen[1, 1] * _yMax);

            _worldToScreen[2, 0] = 0.0F;
            _worldToScreen[2, 1] = 0.0F;
            _worldToScreen[2, 2] = 1.0F;
        }

        private void Draw(Graphics graphics)
        {
            graphics.Clear(Color.White);

            if (_wave == null)
            {
                return;
            }

            for (int i = 0; i < _wave.Length - 1; i++)
            {
                PointF pointA = Matrix3X3.Transform(_worldToScreen, i, _wave[i]);
                PointF pointB = Matrix3X3.Transform(_worldToScreen, i + 1, _wave[i + 1]);
                graphics.DrawLine(_pen, pointA, pointB);
            }
        }

        private void ArrayViewerPaint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        private void SizeChanged()
        {
            _width = Width;
            _heigth = Height;

            RecelculateTransform();
        }

        private void ArrayViewer_Resize(object sender, System.EventArgs e)
        {
            SizeChanged();
        }
    }
}
