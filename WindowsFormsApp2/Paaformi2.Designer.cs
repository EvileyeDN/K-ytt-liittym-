namespace WindowsFormsApp2
{
    partial class Paaformi2
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
            this.koordinaatin = new System.Windows.Forms.Button();
            this.KoordinatiX = new System.Windows.Forms.TextBox();
            this.koordinatiY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OnOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // koordinaatin
            // 
            this.koordinaatin.Location = new System.Drawing.Point(635, 46);
            this.koordinaatin.Name = "koordinaatin";
            this.koordinaatin.Size = new System.Drawing.Size(113, 23);
            this.koordinaatin.TabIndex = 0;
            this.koordinaatin.Text = "Syota Koordinati";
            this.koordinaatin.UseVisualStyleBackColor = true;
            this.koordinaatin.Click += new System.EventHandler(this.koordinaatin_Click);
            // 
            // KoordinatiX
            // 
            this.KoordinatiX.Location = new System.Drawing.Point(529, 49);
            this.KoordinatiX.Name = "KoordinatiX";
            this.KoordinatiX.Size = new System.Drawing.Size(100, 20);
            this.KoordinatiX.TabIndex = 1;
            // 
            // koordinatiY
            // 
            this.koordinatiY.Location = new System.Drawing.Point(529, 86);
            this.koordinatiY.Name = "koordinatiY";
            this.koordinatiY.Size = new System.Drawing.Size(100, 20);
            this.koordinatiY.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // OnOff
            // 
            this.OnOff.Location = new System.Drawing.Point(635, 82);
            this.OnOff.Name = "OnOff";
            this.OnOff.Size = new System.Drawing.Size(113, 23);
            this.OnOff.TabIndex = 5;
            this.OnOff.Text = "OffKaikki";
            this.OnOff.UseVisualStyleBackColor = true;
            this.OnOff.Click += new System.EventHandler(this.OnOff_Click);
            // 
            // Paaformi2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OnOff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.koordinatiY);
            this.Controls.Add(this.KoordinatiX);
            this.Controls.Add(this.koordinaatin);
            this.Name = "Paaformi2";
            this.Text = "Paaformi2";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Paaformi2_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Paaformi2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Paaformi2_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button koordinaatin;
        private System.Windows.Forms.TextBox KoordinatiX;
        private System.Windows.Forms.TextBox koordinatiY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OnOff;
    }
}