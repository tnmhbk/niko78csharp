using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AndroidAudioRaw
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void LoadPointsClick(object sender, EventArgs e)
        {
            LoadFile(@"c:\Mana Mana Nico.raw", avWave, avFFT);
        }

        private void LoadFile(string path, ArrayViewer waveViewer, ArrayViewer fftViewer)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open);

            BinaryReader binaryReader = new BinaryReader(fileStream);

            short[] wave = new short[binaryReader.BaseStream.Length / 2];
            int i = 0;
            while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
            {
                uint a = binaryReader.ReadByte();
                uint b = binaryReader.ReadByte();
                wave[i] = (short)((a << 8) | b);
                i++;
            }

            fileStream.Close();
            fileStream.Dispose();

            waveViewer.DrawWave(wave);

            Application.DoEvents();

            FFT2 fft2 = new FFT2();
            fft2.init((uint)Math.Log((double)wave.Length, 2.0));

            double[] re = new double[wave.Length];
            double[] img = new double[wave.Length];
            for (int j = 0; j < wave.Length; j++)
            {
                re[j] = wave[j];
                img[j] = 0.0F;
            }

            fft2.run(re, img);

            double[] modulo = new double[re.Length / 2];

            for (int j = 0; j < modulo.Length; j++)
            {
                modulo[j] = Math.Sqrt((re[j] * re[j]) + (img[j] * img[j]));
            }

            int number = (int)(2048.0F*(float) modulo.Length/8000.0F);

            fftViewer.DrawWave(modulo.Take(number).ToArray());
        }

        private void btnLoadPoints2_Click(object sender, EventArgs e)
        {
            LoadFile(@"c:\Pepe.raw", avWave2, avFFt2);
        }
    }
}
