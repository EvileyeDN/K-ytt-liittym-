namespace tehtava_16
{
    partial class Setting
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
            this.Jo = new System.Windows.Forms.Button();
            this.Ei = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(208, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "voiko vastaus olla negatiivinen?";
            // 
            // Jo
            // 
            this.Jo.Location = new System.Drawing.Point(245, 128);
            this.Jo.Name = "Jo";
            this.Jo.Size = new System.Drawing.Size(75, 23);
            this.Jo.TabIndex = 1;
            this.Jo.Text = "Jo";
            this.Jo.UseVisualStyleBackColor = true;
            this.Jo.Click += new System.EventHandler(this.Jo_Click);
            // 
            // Ei
            // 
            this.Ei.Location = new System.Drawing.Point(373, 128);
            this.Ei.Name = "Ei";
            this.Ei.Size = new System.Drawing.Size(75, 23);
            this.Ei.TabIndex = 2;
            this.Ei.Text = "Ei";
            this.Ei.UseVisualStyleBackColor = true;
            this.Ei.Click += new System.EventHandler(this.Jo_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ei);
            this.Controls.Add(this.Jo);
            this.Controls.Add(this.label1);
            this.Name = "Setting";
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Jo;
        private System.Windows.Forms.Button Ei;
    }
}