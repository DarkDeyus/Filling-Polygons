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
        public IVector light;
        List<Reflector> reflectors;
        Vertex selectedVertex;
        Polygon selectedPolygon;
        bool moving;
        bool movingPolygon;
        Point startingPosition;
        DirectBitmap bitmap;
        Timer timer;
        #endregion

        bool VectorConstant() => radioButtonVectorConstant.Checked;
        bool VectorLightSourceConstant() => radioButtonVectorLightSourceConstant.Checked;
        bool DistortionNone() => radioButtonDistortionNone.Checked;
        bool FirstObjectColor() => radioButtonFirstObjectColor.Checked;
        bool SecondObjectColor() => radioButtonSecondObjectColor.Checked;

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
            foreach (Polygon polygon in polygons)
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
        void UpdatePolygon(Polygon polygon)
        {
            polygon.Calculate(lightSourceColor, vector, distortion, light, reflectors, pictureBox1.Right - pictureBox1.Left, pictureBox1.Bottom - pictureBox1.Top);
        }
        void UpdatePolygons()
        {
            foreach (var polygon in polygons)
                UpdatePolygon(polygon);
        }

        public Form1()
        {
            
            void UpdateLight(object sender, EventArgs e)
            {
                light.Update();
                UpdatePolygons();
                pictureBox1.Refresh();
            }

            InitializeComponent();
            int width = pictureBox1.Right - pictureBox1.Left;
            int height = pictureBox1.Bottom - pictureBox1.Top;
            vectorTexture = new Bitmap(Resources.normalmap, width, height);
            distortionTexture = new Bitmap(Resources.heightmap, width, height);
            savedVectors = Helpers.GetNormalVectorArray(new PixelMapSharp.PixelMap(vectorTexture));
            vector = new ConstantVector(new Vector3(0, 0, 1));
            savedDistortion = Helpers.GetDistortionVectorArray(new PixelMapSharp.PixelMap(distortionTexture), vector);           
            distortion = new VectorArray(savedDistortion);
            Bitmap texture = new Bitmap(Resources.heightmap, width, height);
            bitmap = new DirectBitmap(width, height);
            light = new ConstantVector(new Vector3(0, 0, 1));

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += UpdateLight;

            


            polygons = new List<Polygon>()
            {
                new Polygon(new List<Vertex>() {new Vertex(450, 101), new Vertex(100, 100), new Vertex(102, 400) } ),
                new Polygon(new List<Vertex>() {new Vertex(600, 200), new Vertex(753, 100), new Vertex(754, 300) } ),
            };

            reflectors = new List<Reflector>()
            {
                new Reflector(width / 2, height / 2,  1, 1 , Color.Red),
                new Reflector(width / 2, height / 2,  1000, 1 , Color.Green),
                new Reflector(width / 2, height / 2,  540, 920 , Color.Blue)
            };

            foreach (Polygon polygon in polygons)
            {
                polygon.UpdateTexture(texture);
                UpdatePolygon(polygon);
            }           

        }
        

            private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            bitmap.Reset(Color.White);
            foreach (Polygon polygon in polygons)
                polygon.Paint(e, bitmap);

            e.Graphics.DrawImage(bitmap.Bitmap, new Point(0, 0));
            foreach (Polygon polygon in polygons)
                polygon.PaintVertices(e);
        }
        
        private void buttonLightSourceColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lightSourceColor = colorDialog1.Color;
                buttonLightSourceColor.BackColor = colorDialog1.Color;
                UpdatePolygons();
                pictureBox1.Refresh();
            }
        }

        private void pictureBoxVectorTexture_Click(object sender, EventArgs e)
        {
            Bitmap image = OpenImage();
            if (image != null)
            {
                vectorTexture = image;
                savedVectors = Helpers.GetNormalVectorArray(new PixelMapSharp.PixelMap(vectorTexture));
                if (!VectorConstant()) UpdateVector(savedVectors);
                savedDistortion = Helpers.GetDistortionVectorArray(new PixelMapSharp.PixelMap(distortionTexture), vector);
                if (!DistortionNone()) UpdateDistortion(savedDistortion);
                pictureBoxVectorTexture.Image = image;
                UpdatePolygons();
                pictureBox1.Refresh();
            }
        }

        private void pictureBoxDistortionTexture_Click(object sender, EventArgs e)
        {
            Bitmap image = OpenImage();
            if (image != null)
            {
                               
                distortionTexture = image;
                savedDistortion = Helpers.GetDistortionVectorArray(new PixelMapSharp.PixelMap(distortionTexture), vector);
                if (!DistortionNone()) UpdateDistortion(savedDistortion);
                pictureBoxDistortionTexture.Image = image;
                UpdatePolygons();
                pictureBox1.Refresh();
            }
        }
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!VectorLightSourceConstant())
            {
                light = new MovingLight((pictureBox1.Right - pictureBox1.Left) / 2, (pictureBox1.Bottom - pictureBox1.Top) / 2, (int)numericUpDown.Value);
                UpdatePolygons();
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
                polygons[0].UpdateColor(colorDialog1.Color);
                buttonFirstObjectColor.BackColor = colorDialog1.Color;
                UpdatePolygon(polygons[0]);
                pictureBox1.Refresh();
            }
        }

        private void buttonSecondObjectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                polygons[1].UpdateColor(colorDialog1.Color);
                buttonSecondObjectColor.BackColor = colorDialog1.Color;
                UpdatePolygon(polygons[1]);
                pictureBox1.Refresh();
            }
        }

        private void pictureBoxFirstObjectTexture_Click(object sender, EventArgs e)
        {
            Bitmap image = OpenImage();
            if (image != null)
            {
                polygons[0].UpdateTexture(image);
                pictureBoxFirstObjectTexture.Image = image;
                UpdatePolygon(polygons[0]);
                pictureBox1.Refresh();
            }
        }

        private void pictureBoxSecondObjectTexture_Click(object sender, EventArgs e)
        {
            Bitmap image = OpenImage();
            if (image != null)
            {
                polygons[1].UpdateTexture(image);
                pictureBoxSecondObjectTexture.Image = image;
                UpdatePolygon(polygons[1]);
                pictureBox1.Refresh();
            }
        }
        private void radioButtonSecondObject_CheckedChanged(object sender, EventArgs e)
        {
            polygons[1].color = SecondObjectColor();
            UpdatePolygon(polygons[1]);
            pictureBox1.Refresh();
        }
        private void radioButtonFirstObject_CheckedChanged(object sender, EventArgs e)
        {
            polygons[0].color = FirstObjectColor();
            UpdatePolygon(polygons[0]);
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
            savedDistortion = Helpers.GetDistortionVectorArray(new PixelMapSharp.PixelMap(distortionTexture), vector);
            if (!DistortionNone()) UpdateDistortion(savedDistortion);
            UpdatePolygons();
            pictureBox1.Refresh();
        }
        private void radioButtonDistortion_CheckedChanged(object sender, EventArgs e)
        {
            if (DistortionNone())
            {
                distortion = new ConstantVector(new Vector3(0, 0, 0));
            }
            else
            {
                UpdateDistortion(savedDistortion);
            }
            UpdatePolygons();
            pictureBox1.Refresh();
        }
        private void radioButtonVectorLightSource_CheckedChanged(object sender, EventArgs e)
        {
            if (!VectorLightSourceConstant())
                timer.Start();
            else
                timer.Stop();

            if (VectorLightSourceConstant())
                light = new ConstantVector(new Vector3(0, 0, 1));
            else
            {
                light = new MovingLight((pictureBox1.Right - pictureBox1.Left) / 2, (pictureBox1.Bottom - pictureBox1.Top) / 2, (int)numericUpDown.Value);                
            }
            
            UpdatePolygons();
            pictureBox1.Refresh();
        }
    }
}
