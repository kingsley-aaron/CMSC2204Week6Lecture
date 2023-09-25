namespace Resturant
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBreakfast = new System.Windows.Forms.Button();
            this.BtnDinner = new System.Windows.Forms.Button();
            this.BtnLunch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "World Cuisine\r\nFamily Restaurant\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Resturant.Properties.Resources.exterior;
            this.pictureBox1.Location = new System.Drawing.Point(31, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnBreakfast
            // 
            this.BtnBreakfast.BackColor = System.Drawing.Color.Salmon;
            this.BtnBreakfast.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBreakfast.Location = new System.Drawing.Point(511, 131);
            this.BtnBreakfast.Name = "BtnBreakfast";
            this.BtnBreakfast.Size = new System.Drawing.Size(262, 61);
            this.BtnBreakfast.TabIndex = 2;
            this.BtnBreakfast.Text = "&Breakfast";
            this.BtnBreakfast.UseVisualStyleBackColor = false;
            this.BtnBreakfast.Click += new System.EventHandler(this.BtnBreakfast_Click);
            // 
            // BtnDinner
            // 
            this.BtnDinner.BackColor = System.Drawing.Color.Salmon;
            this.BtnDinner.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDinner.Location = new System.Drawing.Point(511, 361);
            this.BtnDinner.Name = "BtnDinner";
            this.BtnDinner.Size = new System.Drawing.Size(262, 61);
            this.BtnDinner.TabIndex = 3;
            this.BtnDinner.Text = "Dinner";
            this.BtnDinner.UseVisualStyleBackColor = false;
            this.BtnDinner.Click += new System.EventHandler(this.BtnDinner_Click);
            // 
            // BtnLunch
            // 
            this.BtnLunch.BackColor = System.Drawing.Color.Salmon;
            this.BtnLunch.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLunch.Location = new System.Drawing.Point(511, 246);
            this.BtnLunch.Name = "BtnLunch";
            this.BtnLunch.Size = new System.Drawing.Size(262, 61);
            this.BtnLunch.TabIndex = 4;
            this.BtnLunch.Text = "&Lunch";
            this.BtnLunch.UseVisualStyleBackColor = false;
            this.BtnLunch.Click += new System.EventHandler(this.BtnLunch_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(815, 471);
            this.Controls.Add(this.BtnLunch);
            this.Controls.Add(this.BtnDinner);
            this.Controls.Add(this.BtnBreakfast);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnBreakfast;
        private System.Windows.Forms.Button BtnDinner;
        private System.Windows.Forms.Button BtnLunch;
    }
}

