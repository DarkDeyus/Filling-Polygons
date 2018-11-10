using Filling_Polygons.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filling_Polygons
{
    public partial class Form1 : Form
    {
        #region Variables

        List<Polygon> polygons;
        Color lightSourceColor = Color.White;
        Bitmap vectorTexture;
        Bitmap distortionTexture;

        Vector3[,] savedDistortion;
        Vector3[,] savedVectors;
        IVector distortion;
        IVector vector;

        Vertex selectedVertex;
        Polygon selectedPolygon;
        bool moving;
        bool movingPolygon;
        Point startingPosition;

        #endregion

        bool VectorConstant() => radioButtonVectorConstant.Checked;
        bool VectorLightSourceConstant() => radioButtonVectorLightSourceConstant.Checked;
        bool DistortionNone() => radioButtonDistortionNone.Checked;
        bool FirstObjectColor() => radioButtonFirstObjectColor.Checked;
        bool SecondObjectColor() => radioButtonSecondObjectColor.Checked;
        //TODO: rewrite for any polygon
        Polygon FindTriangle(Point location)
        {                
            Vertex vertex = new Vertex(location.X, location.Y);
            foreach (Polygon triangle in polygons)
                if (triangle.PointInTriangle(vertex))
                    return triangle;

            return null;
        }
        Vertex FindVertex(Point location)
        {
            foreach(Polygon polygon in polygons)
            {
                (bool found, Vertex vertex) = polygon.GetVertex(location);
                if (found) return vertex;
            }
            return null;
        }
        Bitmap OpenImage()
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "Image files (*.jpg, *.jpeg, *.png)| *.jpg; *.jpeg; *.png";
            openImage.Title = "Please select an image file";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                return new Bitmap(new Bitmap(openImage.FileName), pictureBox1.Right - pictureBox1.Left, pictureBox1.Bottom - pictureBox1.Top);
            }
            else return null;
        }
        void UpdateVector(Vector3[,] vectors) => vector = new VectorArray(vectors);
        void UpdateDistortion(Vector3[,] vectors) => distortion = new VectorArray(vectors);
        //ADD CHANGE OF LIGHT VECTOR
        Vector3[,] VectorArrayFromBitmap(PixelMapSharp.PixelMap bitmap)
        {
            Vector3[,] vectors = new Vector3[bitmap.Width, bitmap.Height];
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    vectors[x, y] = Vector.GetVector(bitmap[x, y]);
                }
            }
            return vectors;
        }

        //TODO:FINISH
        Vector3[,] VectorDistortionyFromBitmap(PixelMapSharp.PixelMap bitmap)
        {
            Vector3[,] vectors = new Vector3[bitmap.Width, bitmap.Height];
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Vector3 color = Vector.GetVector(bitmap[x, y]);

                    Vector3 T = new Vector3(1, 0, color.X);
                    Vector3 B = new Vector3(0, 1, color.Y);
                    //Vector3 D = T * dhx + B*dhy;


                    //dhx = H[x+1,y]-H[x,y] dhy = H[x,y+1]-H[x,y] (zmiany wysokości w HeightMap odpowiednio w kierunku x i y)
                }
            }
            return vectors;
        }
        public Form1()
        {
            InitializeComponent();
            vectorTexture = new Bitmap(Resources.normalmap, pictureBox1.Right - pictureBox1.Left, pictureBox1.Bottom - pictureBox1.Top);
            distortionTexture = new Bitmap(Resources.heightmap, pictureBox1.Right - pictureBox1.Left, pictureBox1.Bottom - pictureBox1.Top);
            Bitmap texture = new Bitmap(Resources.normalmap, pictureBox1.Right - pictureBox1.Left, pictureBox1.Bottom - pictureBox1.Top);
            polygons = new List<Polygon>()
            {
                new Polygon(new List<Vertex>() {new Vertex(450, 101), new Vertex(100, 100), new Vertex(102, 400) } ),
                new Polygon(new List<Vertex>() {new Vertex(600, 200), new Vertex(753, 100), new Vertex(754, 300) } ),
            };

            foreach (Polygon polygon in polygons)
                polygon.UpdateTexture(texture);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Polygon polygon in polygons)
                polygon.Paint(e);           
        }           
        

        private void buttonLightSourceColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lightSourceColor = colorDialog1.Color;
                buttonLightSourceColor.BackColor = colorDialog1.Color;
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
        //TODO: should it be like this?

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (moving)
                return;
            switch (e.Button)
            {
                case (MouseButtons.Left):
                    selectedVertex = FindVertex(e.Location);
                    movingPolygon = false;
                    break;
                case (MouseButtons.Middle):
                    selectedPolygon = FindTriangle(e.Location);
                    movingPolygon = true;
                    break;
            }

            if ((selectedVertex != null || selectedPolygon != null) && e.Button != MouseButtons.Right)
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
         
            if(movingPolygon)
            {
                selectedPolygon.movePolygon(difX, difY);
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
            selectedPolygon = null;
            selectedVertex = null;
        }      

        private void buttonFirstObjectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                polygons[0].objectColor = colorDialog1.Color;
                buttonFirstObjectColor.BackColor = colorDialog1.Color;
                pictureBox1.Refresh();
            }
        }

        private void buttonSecondObjectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                polygons[1].objectColor = colorDialog1.Color;
                buttonSecondObjectColor.BackColor = colorDialog1.Color;
                pictureBox1.Refresh();
            }
        }

        private void pictureBoxFirstObjectTexture_Click(object sender, EventArgs e)
        {
            Bitmap image = OpenImage();
            if (image != null)
            {
                polygons[0].objectTexture = new PixelMapSharp.PixelMap(image);
                pictureBoxFirstObjectTexture.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void pictureBoxSecondObjectTexture_Click(object sender, EventArgs e)
        {
            Bitmap image = OpenImage();
            if (image != null)
            {
                polygons[1].objectTexture = new PixelMapSharp.PixelMap(image);
                pictureBoxSecondObjectTexture.Image = image;
                pictureBox1.Refresh();
            }
        }
        private void radioButtonSecondObject_CheckedChanged(object sender, EventArgs e)
        {
            polygons[0].color = SecondObjectColor();
            pictureBox1.Refresh();
        }
        private void radioButtonFirstObject_CheckedChanged(object sender, EventArgs e)
        {
            polygons[1].color = FirstObjectColor();
            pictureBox1.Refresh();
        }
        private void radioButtonVector_CheckedChanged(object sender, EventArgs e)
        {
            if(VectorConstant())
            {
                vector = new ConstantVector(new Vector3(0, 0, 1));
            }
            else
            {
                UpdateVector(savedVectors);
            }
        }
        private void radioButtonDistortion_CheckedChanged(object sender, EventArgs e)
        {
            if (DistortionNone())
            {
                vector = new ConstantVector(new Vector3(0, 0, 0));
            }
            else
            {
                UpdateDistortion(savedDistortion);
            }
        }

        
    }
}
