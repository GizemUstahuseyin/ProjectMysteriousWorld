using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MACERA_DÜNYASI
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            uint CurrVol = 0;
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            trackBar1.Value = CalcVol / (ushort.MaxValue / 10);
        }
        //ses kontrolü
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume
        (IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume
        (IntPtr hwo, uint dwVolume);

        private void GİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 giriş = new Form1();
            this.Hide();
            giriş.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //ses değerinin arttığını labelda gösteriyor
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            trackBar1.TickStyle = TickStyle.BottomRight;
            trackBar1.TickFrequency = 10;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int NewVolume = ((ushort.MaxValue / 100) * trackBar1.Value);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
            label2.Text = trackBar1.Value.ToString();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();
        }
        
       
    }
}
