namespace WindowsFormsApp2
{
    partial class picture
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
            this.SuspendLayout();
            // 
            // picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.GetImage;
            this.ClientSize = new System.Drawing.Size(914, 566);
            this.DoubleBuffered = true;
            this.Name = "picture";
            this.Text = "picture";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}