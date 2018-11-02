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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxObjectTexture = new System.Windows.Forms.PictureBox();
            this.buttonObjectColor = new System.Windows.Forms.Button();
            this.radioButtonObjectTexture = new System.Windows.Forms.RadioButton();
            this.radioButtonObjectColor = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLightSourceColor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonVectorConstant = new System.Windows.Forms.RadioButton();
            this.radioButtonVectorTexture = new System.Windows.Forms.RadioButton();
            this.pictureBoxVectorTexture = new System.Windows.Forms.PictureBox();
            this.radioButtonVectorLightSourceConstant = new System.Windows.Forms.RadioButton();
            this.radioButtonAnimatedLightSource = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.radioButtonDistortionNone = new System.Windows.Forms.RadioButton();
            this.radioButtonDistortionTexture = new System.Windows.Forms.RadioButton();
            this.pictureBoxDistortionTexture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObjectTexture)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVectorTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDistortionTexture)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 761);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBoxVectorTexture);
            this.groupBox4.Controls.Add(this.radioButtonVectorTexture);
            this.groupBox4.Controls.Add(this.radioButtonVectorConstant);
            this.groupBox4.Location = new System.Drawing.Point(13, 375);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(192, 190);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vector ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.radioButtonAnimatedLightSource);
            this.groupBox3.Controls.Add(this.radioButtonVectorLightSourceConstant);
            this.groupBox3.Location = new System.Drawing.Point(13, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vector to light source";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxObjectTexture);
            this.groupBox2.Controls.Add(this.buttonObjectColor);
            this.groupBox2.Controls.Add(this.radioButtonObjectTexture);
            this.groupBox2.Controls.Add(this.radioButtonObjectColor);
            this.groupBox2.Location = new System.Drawing.Point(13, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color of the objects";
            // 
            // pictureBoxObjectTexture
            // 
            this.pictureBoxObjectTexture.Image = global::Filling_Polygons.Properties.Resources.heightmap;
            this.pictureBoxObjectTexture.InitialImage = null;
            this.pictureBoxObjectTexture.Location = new System.Drawing.Point(7, 89);
            this.pictureBoxObjectTexture.Name = "pictureBoxObjectTexture";
            this.pictureBoxObjectTexture.Size = new System.Drawing.Size(185, 64);
            this.pictureBoxObjectTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxObjectTexture.TabIndex = 2;
            this.pictureBoxObjectTexture.TabStop = false;
            this.pictureBoxObjectTexture.Click += new System.EventHandler(this.pictureBoxObjectTexture_Click);
            // 
            // buttonObjectColor
            // 
            this.buttonObjectColor.BackColor = System.Drawing.Color.White;
            this.buttonObjectColor.Location = new System.Drawing.Point(98, 19);
            this.buttonObjectColor.Name = "buttonObjectColor";
            this.buttonObjectColor.Size = new System.Drawing.Size(73, 36);
            this.buttonObjectColor.TabIndex = 1;
            this.buttonObjectColor.UseVisualStyleBackColor = false;
            this.buttonObjectColor.Click += new System.EventHandler(this.buttonObjectColor_Click);
            // 
            // radioButtonObjectTexture
            // 
            this.radioButtonObjectTexture.AutoSize = true;
            this.radioButtonObjectTexture.Location = new System.Drawing.Point(7, 66);
            this.radioButtonObjectTexture.Name = "radioButtonObjectTexture";
            this.radioButtonObjectTexture.Size = new System.Drawing.Size(61, 17);
            this.radioButtonObjectTexture.TabIndex = 1;
            this.radioButtonObjectTexture.Text = "Texture";
            this.radioButtonObjectTexture.UseVisualStyleBackColor = true;
            // 
            // radioButtonObjectColor
            // 
            this.radioButtonObjectColor.AutoSize = true;
            this.radioButtonObjectColor.Checked = true;
            this.radioButtonObjectColor.Location = new System.Drawing.Point(7, 29);
            this.radioButtonObjectColor.Name = "radioButtonObjectColor";
            this.radioButtonObjectColor.Size = new System.Drawing.Size(49, 17);
            this.radioButtonObjectColor.TabIndex = 0;
            this.radioButtonObjectColor.TabStop = true;
            this.radioButtonObjectColor.Text = "Color";
            this.radioButtonObjectColor.UseVisualStyleBackColor = true;
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
            this.pictureBox1.Size = new System.Drawing.Size(947, 757);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBoxDistortionTexture);
            this.groupBox5.Controls.Add(this.radioButtonDistortionTexture);
            this.groupBox5.Controls.Add(this.radioButtonDistortionNone);
            this.groupBox5.Location = new System.Drawing.Point(13, 571);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 178);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Distortion";
            // 
            // radioButtonVectorConstant
            // 
            this.radioButtonVectorConstant.AutoSize = true;
            this.radioButtonVectorConstant.Checked = true;
            this.radioButtonVectorConstant.Location = new System.Drawing.Point(7, 30);
            this.radioButtonVectorConstant.Name = "radioButtonVectorConstant";
            this.radioButtonVectorConstant.Size = new System.Drawing.Size(100, 17);
            this.radioButtonVectorConstant.TabIndex = 3;
            this.radioButtonVectorConstant.Text = "Constant [0,0,1]";
            this.radioButtonVectorConstant.UseVisualStyleBackColor = true;
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
            // pictureBoxVectorTexture
            // 
            this.pictureBoxVectorTexture.Image = global::Filling_Polygons.Properties.Resources.normalmap;
            this.pictureBoxVectorTexture.InitialImage = null;
            this.pictureBoxVectorTexture.Location = new System.Drawing.Point(6, 89);
            this.pictureBoxVectorTexture.Name = "pictureBoxVectorTexture";
            this.pictureBoxVectorTexture.Size = new System.Drawing.Size(180, 95);
            this.pictureBoxVectorTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVectorTexture.TabIndex = 3;
            this.pictureBoxVectorTexture.TabStop = false;
            this.pictureBoxVectorTexture.Click += new System.EventHandler(this.pictureBoxVectorTexture_Click);
            // 
            // radioButtonVectorLightSourceConstant
            // 
            this.radioButtonVectorLightSourceConstant.AutoSize = true;
            this.radioButtonVectorLightSourceConstant.Checked = true;
            this.radioButtonVectorLightSourceConstant.Location = new System.Drawing.Point(6, 29);
            this.radioButtonVectorLightSourceConstant.Name = "radioButtonVectorLightSourceConstant";
            this.radioButtonVectorLightSourceConstant.Size = new System.Drawing.Size(100, 17);
            this.radioButtonVectorLightSourceConstant.TabIndex = 5;
            this.radioButtonVectorLightSourceConstant.Text = "Constant [0,0,1]";
            this.radioButtonVectorLightSourceConstant.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sphere R = ";
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
            // 
            // radioButtonDistortionNone
            // 
            this.radioButtonDistortionNone.AutoSize = true;
            this.radioButtonDistortionNone.Checked = true;
            this.radioButtonDistortionNone.Location = new System.Drawing.Point(7, 28);
            this.radioButtonDistortionNone.Name = "radioButtonDistortionNone";
            this.radioButtonDistortionNone.Size = new System.Drawing.Size(84, 17);
            this.radioButtonDistortionNone.TabIndex = 0;
            this.radioButtonDistortionNone.TabStop = true;
            this.radioButtonDistortionNone.Text = "None [0,0,0]";
            this.radioButtonDistortionNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonDistortionTexture
            // 
            this.radioButtonDistortionTexture.AutoSize = true;
            this.radioButtonDistortionTexture.Location = new System.Drawing.Point(6, 61);
            this.radioButtonDistortionTexture.Name = "radioButtonDistortionTexture";
            this.radioButtonDistortionTexture.Size = new System.Drawing.Size(122, 17);
            this.radioButtonDistortionTexture.TabIndex = 1;
            this.radioButtonDistortionTexture.Text = "Texture (HeightMap)";
            this.radioButtonDistortionTexture.UseVisualStyleBackColor = true;
            // 
            // pictureBoxDistortionTexture
            // 
            this.pictureBoxDistortionTexture.Image = global::Filling_Polygons.Properties.Resources.heightmap;
            this.pictureBoxDistortionTexture.InitialImage = null;
            this.pictureBoxDistortionTexture.Location = new System.Drawing.Point(7, 84);
            this.pictureBoxDistortionTexture.Name = "pictureBoxDistortionTexture";
            this.pictureBoxDistortionTexture.Size = new System.Drawing.Size(187, 84);
            this.pictureBoxDistortionTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDistortionTexture.TabIndex = 5;
            this.pictureBoxDistortionTexture.TabStop = false;
            this.pictureBoxDistortionTexture.Click += new System.EventHandler(this.pictureBoxDistortionTexture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObjectTexture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVectorTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDistortionTexture)).EndInit();
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
        private System.Windows.Forms.RadioButton radioButtonObjectTexture;
        private System.Windows.Forms.RadioButton radioButtonObjectColor;
        private System.Windows.Forms.Button buttonObjectColor;
        private System.Windows.Forms.PictureBox pictureBoxObjectTexture;
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
    }
}

