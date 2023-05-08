namespace AppsDevProjectVisualCsharp
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.genzBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genzBTN
            // 
            this.genzBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.genzBTN.BackColor = System.Drawing.Color.Transparent;
            this.genzBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genzBTN.ForeColor = System.Drawing.Color.OrangeRed;
            this.genzBTN.Location = new System.Drawing.Point(252, 354);
            this.genzBTN.Name = "genzBTN";
            this.genzBTN.Size = new System.Drawing.Size(110, 40);
            this.genzBTN.TabIndex = 0;
            this.genzBTN.Text = "TRY GEN-Z BUBBLE TEA";
            this.genzBTN.UseVisualStyleBackColor = false;
            this.genzBTN.Click += new System.EventHandler(this.genzBTN_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 428);
            this.Controls.Add(this.genzBTN);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "Homepage";
            this.Text = "Gen-Z Home page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button genzBTN;
    }
}

