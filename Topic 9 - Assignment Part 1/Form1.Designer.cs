namespace Topic_9___Assignment_Part_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGood = new System.Windows.Forms.Button();
            this.btnBad = new System.Windows.Forms.Button();
            this.imgBad = new System.Windows.Forms.PictureBox();
            this.imgGood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGood)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGood
            // 
            this.btnGood.BackColor = System.Drawing.Color.White;
            this.btnGood.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGood.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnGood.Location = new System.Drawing.Point(117, 192);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(270, 55);
            this.btnGood.TabIndex = 0;
            this.btnGood.Text = "Click for Good";
            this.btnGood.UseVisualStyleBackColor = false;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnBad
            // 
            this.btnBad.BackColor = System.Drawing.Color.Black;
            this.btnBad.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBad.ForeColor = System.Drawing.Color.Red;
            this.btnBad.Location = new System.Drawing.Point(427, 192);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(270, 54);
            this.btnBad.TabIndex = 1;
            this.btnBad.Text = "Click for Bad";
            this.btnBad.UseVisualStyleBackColor = false;
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // imgBad
            // 
            this.imgBad.Image = ((System.Drawing.Image)(resources.GetObject("imgBad.Image")));
            this.imgBad.Location = new System.Drawing.Point(-8, -4);
            this.imgBad.Name = "imgBad";
            this.imgBad.Size = new System.Drawing.Size(817, 464);
            this.imgBad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBad.TabIndex = 2;
            this.imgBad.TabStop = false;
            this.imgBad.Visible = false;
            // 
            // imgGood
            // 
            this.imgGood.Image = ((System.Drawing.Image)(resources.GetObject("imgGood.Image")));
            this.imgGood.Location = new System.Drawing.Point(-8, -4);
            this.imgGood.Name = "imgGood";
            this.imgGood.Size = new System.Drawing.Size(817, 464);
            this.imgGood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGood.TabIndex = 3;
            this.imgGood.TabStop = false;
            this.imgGood.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBad);
            this.Controls.Add(this.btnGood);
            this.Controls.Add(this.imgGood);
            this.Controls.Add(this.imgBad);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgBad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnBad;
        private System.Windows.Forms.PictureBox imgBad;
        private System.Windows.Forms.PictureBox imgGood;
    }
}

