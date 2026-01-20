namespace CSharpVisionAlgoPrac
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbOriginImage = new PictureBox();
            pbResult = new PictureBox();
            btnImgLoad = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnAlgo = new Button();
            ((System.ComponentModel.ISupportInitialize)pbOriginImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbResult).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pbOriginImage
            // 
            pbOriginImage.Location = new Point(3, 19);
            pbOriginImage.Name = "pbOriginImage";
            pbOriginImage.Size = new Size(335, 260);
            pbOriginImage.TabIndex = 0;
            pbOriginImage.TabStop = false;
            // 
            // pbResult
            // 
            pbResult.Location = new Point(3, 19);
            pbResult.Name = "pbResult";
            pbResult.Size = new Size(343, 260);
            pbResult.TabIndex = 1;
            pbResult.TabStop = false;
            // 
            // btnImgLoad
            // 
            btnImgLoad.Location = new Point(720, 27);
            btnImgLoad.Name = "btnImgLoad";
            btnImgLoad.Size = new Size(272, 52);
            btnImgLoad.TabIndex = 4;
            btnImgLoad.Text = "Load";
            btnImgLoad.UseVisualStyleBackColor = true;
            btnImgLoad.Click += btnImgLoad_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbOriginImage);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 282);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Origin Img";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pbResult);
            groupBox2.Location = new Point(362, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(352, 282);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Result Img";
            // 
            // btnAlgo
            // 
            btnAlgo.Location = new Point(720, 85);
            btnAlgo.Name = "btnAlgo";
            btnAlgo.Size = new Size(272, 58);
            btnAlgo.TabIndex = 7;
            btnAlgo.Text = "Algo 1";
            btnAlgo.UseVisualStyleBackColor = true;
            btnAlgo.Click += btnAlgo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 450);
            Controls.Add(btnAlgo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnImgLoad);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbOriginImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbResult).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbOriginImage;
        private PictureBox pbResult;
        private Button btnImgLoad;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnAlgo;
    }
}
