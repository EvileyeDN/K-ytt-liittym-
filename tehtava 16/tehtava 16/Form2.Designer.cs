namespace tehtava_16
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Kysymys = new System.Windows.Forms.Button();
            this.KysymysBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vastaus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // Kysymys
            // 
            this.Kysymys.Location = new System.Drawing.Point(322, 67);
            this.Kysymys.Name = "Kysymys";
            this.Kysymys.Size = new System.Drawing.Size(124, 23);
            this.Kysymys.TabIndex = 3;
            this.Kysymys.Text = "Naytta Kysymys!";
            this.Kysymys.UseVisualStyleBackColor = true;
            this.Kysymys.Click += new System.EventHandler(this.Kysymys_Click);
            // 
            // KysymysBox
            // 
            this.KysymysBox.Location = new System.Drawing.Point(266, 106);
            this.KysymysBox.Name = "KysymysBox";
            this.KysymysBox.Size = new System.Drawing.Size(230, 210);
            this.KysymysBox.TabIndex = 4;
            this.KysymysBox.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KysymysBox);
            this.Controls.Add(this.Kysymys);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Kysymys;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox KysymysBox;
    }
}