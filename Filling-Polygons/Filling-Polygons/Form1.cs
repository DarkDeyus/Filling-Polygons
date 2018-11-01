using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filling_Polygons
{
    public partial class Form1 : Form
    {
        List<Triangle> triangles;
        Color lightSourceColor = Color.White;
        public Form1()
        {
            InitializeComponent();
            triangles = new List<Triangle>() { new Triangle(new Point(10, 10), new Point(100, 100), new Point(100, 400)) };
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Triangle triangle in triangles)
            {
                triangle.Paint(e);
            }
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lightSourceColor = colorDialog1.Color;
                button1.BackColor = colorDialog1.Color;
            }
        }
    }
}
