namespace Filling_Polygons
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBoxSecondObjectTexture = new System.Windows.Forms.PictureBox();
            this.buttonSecondObjectColor = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButtonSecondObjectColor = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxDistortionTexture = new System.Windows.Forms.PictureBox();
            this.radioButtonDistortionTexture = new System.Windows.Forms.RadioButton();
            this.radioButtonDistortionNone = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBoxVectorTexture = new System.Windows.Forms.PictureBox();
            this.radioButtonVectorTexture = new System.Windows.Forms.RadioButton();
            this.radioButtonVectorConstant = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonAnimatedLightSource = new System.Windows.Forms.RadioButton();
            this.radioButtonVectorLightSourceConstant = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxFirstObjectTexture = new System.Windows.Forms.PictureBox();
            this.buttonFirstObjectColor = new System.Windows.Forms.Button();
            this.radioButtonFirstObjectTexture = new System.Windows.Forms.RadioButton();
            this.radioButtonFirstObjectColor = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLightSourceColor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecondObjectTexture)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDistortionTexture)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVectorTexture)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstObjectTexture)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1356, 945);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBoxSecondObjectTexture);
            this.groupBox6.Controls.Add(this.buttonSecondObjectColor);
            this.groupBox6.Controls.Add(this.radioButton1);
            this.groupBox6.Controls.Add(this.radioButtonSecondObjectColor);
            this.groupBox6.Location = new System.Drawing.Point(12, 269);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 159);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Color of the second object";
            // 
            // pictureBoxSecondObjectTexture
            // 
            this.pictureBoxSecondObjectTexture.Image = global::Filling_Polygons.Properties.Resources.heightmap;
            this.pictureBoxSecondObjectTexture.InitialImage = null;
            this.pictureBoxSecondObjectTexture.Location = new System.Drawing.Point(46, 83);
            this.pictureBoxSecondObjectTexture.Name = "pictureBoxSecondObjectTexture";
            this.pictureBoxSecondObjectTexture.Size = new System.Drawing.Size(98, 70);
            this.pictureBoxSecondObjectTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSecondObjectTexture.TabIndex = 2;
            this.pictureBoxSecondObjectTexture.TabStop = false;
            this.pictureBoxSecondObjectTexture.Click += new System.EventHandler(this.pictureBoxSecondObjectTexture_Click);
            // 
            // buttonSecondObjectColor
            // 
            this.buttonSecondObjectColor.BackColor = System.Drawing.Color.Green;
            this.buttonSecondObjectColor.Location = new System.Drawing.Point(105, 19);
            this.buttonSecondObjectColor.Name = "buttonSecondObjectColor";
            this.buttonSecondObjectColor.Size = new System.Drawing.Size(73, 36);
            this.buttonSecondObjectColor.TabIndex = 1;
            this.buttonSecondObjectColor.UseVisualStyleBackColor = false;
            this.buttonSecondObjectColor.Click += new System.EventHandler(this.buttonSecondObjectColor_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Texture";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButtonSecondObjectColor
            // 
            this.radioButtonSecondObjectColor.AutoSize = true;
            this.radioButtonSecondObjectColor.Checked = true;
            this.radioButtonSecondObjectColor.Location = new System.Drawing.Point(7, 29);
            this.radioButtonSecondObjectColor.Name = "radioButtonSecondObjectColor";
            this.radioButtonSecondObjectColor.Size = new System.Drawing.Size(49, 17);
            this.radioButtonSecondObjectColor.TabIndex = 0;
            this.radioButtonSecondObjectColor.TabStop = true;
            this.radioButtonSecondObjectColor.Text = "Color";
            this.radioButtonSecondObjectColor.UseVisualStyleBackColor = true;
            this.radioButtonSecondObjectColor.CheckedChanged += new System.EventHandler(this.radioButtonSecondObject_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBoxDistortionTexture);
            this.groupBox5.Controls.Add(this.radioButtonDistortionTexture);
            this.groupBox5.Controls.Add(this.radioButtonDistortionNone);
            this.groupBox5.Location = new System.Drawing.Point(13, 736);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 178);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Distortion";
            // 
            // pictureBoxDistortionTexture
            // 
            this.pictureBoxDistortionTexture.Image = global::Filling_Polygons.Properties.Resources.heightmap;
            this.pictureBoxDistortionTexture.InitialImage = null;
            this.pictureBoxDistortionTexture.Location = new System.Drawing.Point(46, 84);
            this.pictureBoxDistortionTexture.Name = "pictureBoxDistortionTexture";
            this.pictureBoxDistortionTexture.Size = new System.Drawing.Size(98, 84);
            this.pictureBoxDistortionTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDistortionTexture.TabIndex = 5;
            this.pictureBoxDistortionTexture.TabStop = false;
            this.pictureBoxDistortionTexture.Click += new System.EventHandler(this.pictureBoxDistortionTexture_Click);
            // 
            // radioButtonDistortionTexture
            // 
            this.radioButtonDistortionTexture.AutoSize = true;
            this.radioButtonDistortionTexture.Checked = true;
            this.radioButtonDistortionTexture.Location = new System.Drawing.Point(6, 61);
            this.radioButtonDistortionTexture.Name = "radioButtonDistortionTexture";
            this.radioButtonDistortionTexture.Size = new System.Drawing.Size(122, 17);
            this.radioButtonDistortionTexture.TabIndex = 1;
            this.radioButtonDistortionTexture.TabStop = true;
            this.radioButtonDistortionTexture.Text = "Texture (HeightMap)";
            this.radioButtonDistortionTexture.UseVisualStyleBackColor = true;
            // 
            // radioButtonDistortionNone
            // 
            this.radioButtonDistortionNone.AutoSize = true;
            this.radioButtonDistortionNone.Location = new System.Drawing.Point(7, 28);
            this.radioButtonDistortionNone.Name = "radioButtonDistortionNone";
            this.radioButtonDistortionNone.Size = new System.Drawing.Size(84, 17);
            this.radioButtonDistortionNone.TabIndex = 0;
            this.radioButtonDistortionNone.Text = "None [0,0,0]";
            this.radioButtonDistortionNone.UseVisualStyleBackColor = true;
            this.radioButtonDistortionNone.CheckedChanged += new System.EventHandler(this.radioButtonDistortion_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBoxVectorTexture);
            this.groupBox4.Controls.Add(this.radioButtonVectorTexture);
            this.groupBox4.Controls.Add(this.radioButtonVectorConstant);
            this.groupBox4.Location = new System.Drawing.Point(13, 540);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 190);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vector ";
            // 
            // pictureBoxVectorTexture
            // 
            this.pictureBoxVectorTexture.Image = global::Filling_Polygons.Properties.Resources.normalmap;
            this.pictureBoxVectorTexture.InitialImage = null;
            this.pictureBoxVectorTexture.Location = new System.Drawing.Point(46, 89);
            this.pictureBoxVectorTexture.Name = "pictureBoxVectorTexture";
            this.pictureBoxVectorTexture.Size = new System.Drawing.Size(98, 95);
            this.pictureBoxVectorTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVectorTexture.TabIndex = 3;
            this.pictureBoxVectorTexture.TabStop = false;
            this.pictureBoxVectorTexture.Click += new System.EventHandler(this.pictureBoxVectorTexture_Click);
            // 
            // radioButtonVectorTexture
            // 
            this.radioButtonVectorTexture.AutoSize = true;
            this.radioButtonVectorTexture.Location = new System.Drawing.Point(6, 66);
            this.radioButtonVectorTexture.Name = "radioButtonVectorTexture";
            this.radioButtonVectorTexture.Size = new System.Drawing.Size(124, 17);
            this.radioButtonVectorTexture.TabIndex = 4;
            this.radioButtonVectorTexture.Text = "Texture (NormalMap)";
            this.radioButtonVectorTexture.UseVisualStyleBackColor = true;
            // 
            // radioButtonVectorConstant
            // 
            this.radioButtonVectorConstant.AutoSize = true;
            this.radioButtonVectorConstant.Checked = true;
            this.radioButtonVectorConstant.Location = new System.Drawing.Point(7, 30);
            this.radioButtonVectorConstant.Name = "radioButtonVectorConstant";
            this.radioButtonVectorConstant.Size = new System.Drawing.Size(100, 17);
            this.radioButtonVectorConstant.TabIndex = 3;
            this.radioButtonVectorConstant.TabStop = true;
            this.radioButtonVectorConstant.Text = "Constant [0,0,1]";
            this.radioButtonVectorConstant.UseVisualStyleBackColor = true;
            this.radioButtonVectorConstant.CheckedChanged += new System.EventHandler(this.radioButtonVector_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.radioButtonAnimatedLightSource);
            this.groupBox3.Controls.Add(this.radioButtonVectorLightSourceConstant);
            this.groupBox3.Location = new System.Drawing.Point(13, 434);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vector to light source";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(93, 75);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown.TabIndex = 7;
            this.numericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sphere R = ";
            // 
            // radioButtonAnimatedLightSource
            // 
            this.radioButtonAnimatedLightSource.AutoSize = true;
            this.radioButtonAnimatedLightSource.Location = new System.Drawing.Point(6, 52);
            this.radioButtonAnimatedLightSource.Name = "radioButtonAnimatedLightSource";
            this.radioButtonAnimatedLightSource.Size = new System.Drawing.Size(172, 17);
            this.radioButtonAnimatedLightSource.TabIndex = 5;
            this.radioButtonAnimatedLightSource.Text = "Animated source on the sphere";
            this.radioButtonAnimatedLightSource.UseVisualStyleBackColor = true;
            // 
            // radioButtonVectorLightSourceConstant
            // 
            this.radioButtonVectorLightSourceConstant.AutoSize = true;
            this.radioButtonVectorLightSourceConstant.Checked = true;
            this.radioButtonVectorLightSourceConstant.Location = new System.Drawing.Point(6, 29);
            this.radioButtonVectorLightSourceConstant.Name = "radioButtonVectorLightSourceConstant";
            this.radioButtonVectorLightSourceConstant.Size = new System.Drawing.Size(100, 17);
            this.radioButtonVectorLightSourceConstant.TabIndex = 5;
            this.radioButtonVectorLightSourceConstant.TabStop = true;
            this.radioButtonVectorLightSourceConstant.Text = "Constant [0,0,1]";
            this.radioButtonVectorLightSourceConstant.UseVisualStyleBackColor = true;
            this.radioButtonVectorLightSourceConstant.CheckedChanged += new System.EventHandler(this.radioButtonVectorLightSource_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxFirstObjectTexture);
            this.groupBox2.Controls.Add(this.buttonFirstObjectColor);
            this.groupBox2.Controls.Add(this.radioButtonFirstObjectTexture);
            this.groupBox2.Controls.Add(this.radioButtonFirstObjectColor);
            this.groupBox2.Location = new System.Drawing.Point(13, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color of the first object ";
            // 
            // pictureBoxFirstObjectTexture
            // 
            this.pictureBoxFirstObjectTexture.Image = global::Filling_Polygons.Properties.Resources.heightmap;
            this.pictureBoxFirstObjectTexture.InitialImage = null;
            this.pictureBoxFirstObjectTexture.Location = new System.Drawing.Point(46, 83);
            this.pictureBoxFirstObjectTexture.Name = "pictureBoxFirstObjectTexture";
            this.pictureBoxFirstObjectTexture.Size = new System.Drawing.Size(98, 70);
            this.pictureBoxFirstObjectTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFirstObjectTexture.TabIndex = 2;
            this.pictureBoxFirstObjectTexture.TabStop = false;
            this.pictureBoxFirstObjectTexture.Click += new System.EventHandler(this.pictureBoxFirstObjectTexture_Click);
            // 
            // buttonFirstObjectColor
            // 
            this.buttonFirstObjectColor.BackColor = System.Drawing.Color.Green;
            this.buttonFirstObjectColor.Location = new System.Drawing.Point(105, 19);
            this.buttonFirstObjectColor.Name = "buttonFirstObjectColor";
            this.buttonFirstObjectColor.Size = new System.Drawing.Size(73, 36);
            this.buttonFirstObjectColor.TabIndex = 1;
            this.buttonFirstObjectColor.UseVisualStyleBackColor = false;
            this.buttonFirstObjectColor.Click += new System.EventHandler(this.buttonFirstObjectColor_Click);
            // 
            // radioButtonFirstObjectTexture
            // 
            this.radioButtonFirstObjectTexture.AutoSize = true;
            this.radioButtonFirstObjectTexture.Location = new System.Drawing.Point(7, 60);
            this.radioButtonFirstObjectTexture.Name = "radioButtonFirstObjectTexture";
            this.radioButtonFirstObjectTexture.Size = new System.Drawing.Size(61, 17);
            this.radioButtonFirstObjectTexture.TabIndex = 1;
            this.radioButtonFirstObjectTexture.Text = "Texture";
            this.radioButtonFirstObjectTexture.UseVisualStyleBackColor = true;
            // 
            // radioButtonFirstObjectColor
            // 
            this.radioButtonFirstObjectColor.AutoSize = true;
            this.radioButtonFirstObjectColor.Checked = true;
            this.radioButtonFirstObjectColor.Location = new System.Drawing.Point(7, 29);
            this.radioButtonFirstObjectColor.Name = "radioButtonFirstObjectColor";
            this.radioButtonFirstObjectColor.Size = new System.Drawing.Size(49, 17);
            this.radioButtonFirstObjectColor.TabIndex = 0;
            this.radioButtonFirstObjectColor.TabStop = true;
            this.radioButtonFirstObjectColor.Text = "Color";
            this.radioButtonFirstObjectColor.UseVisualStyleBackColor = true;
            this.radioButtonFirstObjectColor.CheckedChanged += new System.EventHandler(this.radioButtonFirstObject_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLightSourceColor);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Color of light source";
            // 
            // buttonLightSourceColor
            // 
            this.buttonLightSourceColor.BackColor = System.Drawing.Color.White;
            this.buttonLightSourceColor.Location = new System.Drawing.Point(6, 19);
            this.buttonLightSourceColor.Name = "buttonLightSourceColor";
            this.buttonLightSourceColor.Size = new System.Drawing.Size(186, 59);
            this.buttonLightSourceColor.TabIndex = 0;
            this.buttonLightSourceColor.UseVisualStyleBackColor = false;
            this.buttonLightSourceColor.Click += new System.EventHandler(this.buttonLightSourceColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1083, 929);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 945);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecondObjectTexture)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDistortionTexture)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVectorTexture)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstObjectTexture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLightSourceColor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonFirstObjectTexture;
        private System.Windows.Forms.RadioButton radioButtonFirstObjectColor;
        private System.Windows.Forms.Button buttonFirstObjectColor;
        private System.Windows.Forms.PictureBox pictureBoxFirstObjectTexture;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButtonDistortionTexture;
        private System.Windows.Forms.RadioButton radioButtonDistortionNone;
        private System.Windows.Forms.PictureBox pictureBoxVectorTexture;
        private System.Windows.Forms.RadioButton radioButtonVectorTexture;
        private System.Windows.Forms.RadioButton radioButtonVectorConstant;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonAnimatedLightSource;
        private System.Windows.Forms.RadioButton radioButtonVectorLightSourceConstant;
        private System.Windows.Forms.PictureBox pictureBoxDistortionTexture;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBoxSecondObjectTexture;
        private System.Windows.Forms.Button buttonSecondObjectColor;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButtonSecondObjectColor;
    }
}

