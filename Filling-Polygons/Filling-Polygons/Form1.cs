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
        #region Variables

        List<Triangle> triangles;
        Color lightSourceColor = Color.White;
        Color objectColor = Color.White;
        Bitmap vectorTexture = Resources.normalmap;
        Bitmap distortionTexture = Resources.heightmap;
        Bitmap objectTexture = Resources.heightmap;
        Vertex selectedVertex;
        Triangle selectedTriangle;
        bool moving;
        bool movingTriangle;
        Point startingPosition;

        #endregion

        bool VectorConstant() => radioButtonVectorConstant.Enabled;

        bool VectorLightSourceConstant() => radioButtonVectorLightSourceConstant.Enabled;

        bool DistortionNone() => radioButtonDistortionNone.Enabled;

        bool ObjectColor() => radioButtonObjectColor.Enabled;
      
        Triangle FindTriangle(Point location)
        {
            double Sign(Vertex p1, Vertex p2, Vertex p3)
            {
                return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
            }

            bool PointInTriangle(Vertex pt, Triangle triangle)
            {
                double d1, d2, d3;
                bool has_neg, has_pos;
                Vertex v1 = triangle.vertices[0];
                Vertex v2 = triangle.vertices[1];
                Vertex v3 = triangle.vertices[2];

                d1 = Sign(pt, v1, v2);
                d2 = Sign(pt, v2, v3);
                d3 = Sign(pt, v3, v1);

                has_neg = (d1 < 0) || (d2 < 0) || (d3 < 0);
                has_pos = (d1 > 0) || (d2 > 0) || (d3 > 0);

                return !(has_neg && has_pos);
            }

            Vertex vertex = new Vertex(location.X, location.Y);
            foreach (Triangle triangle in triangles)
                if (PointInTriangle(vertex, triangle))
                    return triangle;

            return null;
        }

        Vertex FindVertex(Point location)
        {
            foreach (Triangle triangle in triangles)
                foreach (Vertex vertex in triangle.vertices)
                    if (Math.Pow((vertex.X - location.X), 2) +
                        Math.Pow((vertex.Y - location.Y), 2) <= Math.Pow(triangle.leeway, 2))
                        return vertex;

            return null;
        }

        public Form1()
        {
            InitializeComponent();
            triangles = new List<Triangle>()
            {
                new Triangle(new Vertex(450, 100), new Vertex(100, 100), new Vertex(100, 400)),
                new Triangle(new Vertex(600, 200), new Vertex(750, 100), new Vertex(750, 300))
            };

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Triangle triangle in triangles)
                triangle.Paint(e);           
        }      

        Bitmap OpenImage()
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "Image files (*.jpg, *.jpeg, *.png)| *.jpg; *.jpeg; *.png";
            openImage.Title = "Please select an image file";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                return new Bitmap(openImage.FileName);
            }
            else return null;
        }

        private void pictureBoxObjectTexture_Click(object sender, EventArgs e)
        {
            Bitmap image = OpenImage();
            if(image != null)
            {
                objectTexture = image;
                pictureBoxObjectTexture.Image = image;
                pictureBox1.Refresh();
            }
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
            Bitmap image = OpenImage();
            if (image != null)
            {
                vectorTexture = image;
                pictureBoxVectorTexture.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void pictureBoxDistortionTexture_Click(object sender, EventArgs e)
        {
            Bitmap image = OpenImage();
            if (image != null)
            {
                distortionTexture = image;
                pictureBoxDistortionTexture.Image = image;
                pictureBox1.Refresh();
            }
        }         

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (moving)
                return;
            switch (e.Button)
            {
                case (MouseButtons.Left):
                    selectedVertex = FindVertex(e.Location);
                    movingTriangle = false;
                    break;
                case (MouseButtons.Middle):
                    selectedTriangle = FindTriangle(e.Location);
                    movingTriangle = true;
                    break;
            }

            if ((selectedVertex != null || selectedTriangle != null) && e.Button != MouseButtons.Right)
            {
                moving = true;
                startingPosition = pictureBox1.PointToClient(Cursor.Position);
            }                       
            else moving = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!moving)
                return;
            int difX = pictureBox1.PointToClient(Cursor.Position).X - startingPosition.X;
            int difY = pictureBox1.PointToClient(Cursor.Position).Y - startingPosition.Y;
         
            if(movingTriangle)
            {
                for (int i = 0; i < selectedTriangle.vertices.Count; i++)
                {
                    selectedTriangle.vertices[i].X += difX;
                    selectedTriangle.vertices[i].Y += difY;
                }
            }
            //moving vertex
            else
            {
                selectedVertex.X += difX;
                selectedVertex.Y += difY;
                
            }

            startingPosition = new Point(e.X, e.Y);           
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {          
            moving = false;
            selectedTriangle = null;
            selectedVertex = null;
        }

        //TODO: should it be like this?
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}
