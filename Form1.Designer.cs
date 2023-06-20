
namespace Sophie
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GreenNorth = new System.Windows.Forms.PictureBox();
            this.RedNorth = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RedSouth = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GreenSouth = new System.Windows.Forms.PictureBox();
            this.GreenWest = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.RedWest = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.RedEast = new System.Windows.Forms.PictureBox();
            this.GreenEast = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GreenNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenWest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedWest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedEast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenEast)).BeginInit();
            this.SuspendLayout();
            // 
            // GreenNorth
            // 
            this.GreenNorth.Image = ((System.Drawing.Image)(resources.GetObject("GreenNorth.Image")));
            this.GreenNorth.Location = new System.Drawing.Point(28, 41);
            this.GreenNorth.Name = "GreenNorth";
            this.GreenNorth.Size = new System.Drawing.Size(264, 437);
            this.GreenNorth.TabIndex = 0;
            this.GreenNorth.TabStop = false;
            // 
            // RedNorth
            // 
            this.RedNorth.Image = ((System.Drawing.Image)(resources.GetObject("RedNorth.Image")));
            this.RedNorth.Location = new System.Drawing.Point(28, 42);
            this.RedNorth.Name = "RedNorth";
            this.RedNorth.Size = new System.Drawing.Size(264, 436);
            this.RedNorth.TabIndex = 1;
            this.RedNorth.TabStop = false;
            this.RedNorth.Click += new System.EventHandler(this.RedNorth_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 504);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "North";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RedSouth
            // 
            this.RedSouth.Image = ((System.Drawing.Image)(resources.GetObject("RedSouth.Image")));
            this.RedSouth.Location = new System.Drawing.Point(317, 40);
            this.RedSouth.Name = "RedSouth";
            this.RedSouth.Size = new System.Drawing.Size(264, 436);
            this.RedSouth.TabIndex = 3;
            this.RedSouth.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(393, 502);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "South";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // GreenSouth
            // 
            this.GreenSouth.Image = ((System.Drawing.Image)(resources.GetObject("GreenSouth.Image")));
            this.GreenSouth.Location = new System.Drawing.Point(317, 40);
            this.GreenSouth.Name = "GreenSouth";
            this.GreenSouth.Size = new System.Drawing.Size(264, 437);
            this.GreenSouth.TabIndex = 5;
            this.GreenSouth.TabStop = false;
            // 
            // GreenWest
            // 
            this.GreenWest.Image = ((System.Drawing.Image)(resources.GetObject("GreenWest.Image")));
            this.GreenWest.Location = new System.Drawing.Point(900, 44);
            this.GreenWest.Name = "GreenWest";
            this.GreenWest.Size = new System.Drawing.Size(264, 437);
            this.GreenWest.TabIndex = 11;
            this.GreenWest.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(980, 501);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "West";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RedWest
            // 
            this.RedWest.Image = ((System.Drawing.Image)(resources.GetObject("RedWest.Image")));
            this.RedWest.Location = new System.Drawing.Point(900, 44);
            this.RedWest.Name = "RedWest";
            this.RedWest.Size = new System.Drawing.Size(264, 436);
            this.RedWest.TabIndex = 9;
            this.RedWest.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(691, 504);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "East";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RedEast
            // 
            this.RedEast.Image = ((System.Drawing.Image)(resources.GetObject("RedEast.Image")));
            this.RedEast.Location = new System.Drawing.Point(609, 42);
            this.RedEast.Name = "RedEast";
            this.RedEast.Size = new System.Drawing.Size(264, 436);
            this.RedEast.TabIndex = 7;
            this.RedEast.TabStop = false;
            this.RedEast.Visible = false;
            this.RedEast.Click += new System.EventHandler(this.RedEast_Click);
            // 
            // GreenEast
            // 
            this.GreenEast.Image = ((System.Drawing.Image)(resources.GetObject("GreenEast.Image")));
            this.GreenEast.Location = new System.Drawing.Point(609, 41);
            this.GreenEast.Name = "GreenEast";
            this.GreenEast.Size = new System.Drawing.Size(264, 437);
            this.GreenEast.TabIndex = 6;
            this.GreenEast.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(993, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 56);
            this.button1.TabIndex = 12;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 756);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GreenWest);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.RedWest);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.RedEast);
            this.Controls.Add(this.GreenEast);
            this.Controls.Add(this.GreenSouth);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.RedSouth);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RedNorth);
            this.Controls.Add(this.GreenNorth);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GreenNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenWest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedWest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedEast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenEast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GreenNorth;
        private System.Windows.Forms.PictureBox RedNorth;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox RedSouth;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox GreenSouth;
        private System.Windows.Forms.PictureBox GreenWest;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox RedWest;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox RedEast;
        private System.Windows.Forms.PictureBox GreenEast;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Timer timer1;
    }
}

