using Filling_Polygons.Properties;
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
        Color objectColor = Color.White;
        Image vectorTexture = Resources.normalmap;
        Image distortionTexture = Resources.heightmap;
        Image objectTexture = Resources.heightmap;

        bool VectorConstant() => radioButtonVectorConstant.Enabled;
        bool VectorLightSourceConstant() => radioButtonVectorLightSourceConstant.Enabled;
        bool DistortionNone() => radioButtonDistortionNone.Enabled;
        bool ObjectColor() => radioButtonObjectColor.Enabled;
        public Form1()
        {
            InitializeComponent();
            triangles = new List<Triangle>()
            {
                new Triangle(new Point(450, 100), new Point(100, 100), new Point(100, 400)),
                new Triangle(new Point(600, 200), new Point(750, 100), new Point(750, 300))
            };

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Triangle triangle in triangles)
            {
                triangle.Paint(e);
            }
        }      


        private void pictureBoxObjectTexture_Click(object sender, EventArgs e)
        {

        }

        private void buttonLightSourceColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lightSourceColor = colorDialog1.Color;
                buttonLightSourceColor.BackColor = colorDialog1.Color;
            }
        }

        private void buttonObjectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                objectColor = colorDialog1.Color;
                buttonObjectColor.BackColor = colorDialog1.Color;
            }
        }

        private void pictureBoxVectorTexture_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxDistortionTexture_Click(object sender, EventArgs e)
        {

        }
    }
}
