﻿namespace WindowsFormsApp2
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Toiminolisuus = new System.Windows.Forms.Label();
            this.UssiTietueButton = new System.Windows.Forms.Button();
            this.TallenaButton = new System.Windows.Forms.Button();
            this.PoistaButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NimiTextBox = new System.Windows.Forms.TextBox();
            this.VuosiTextBox = new System.Windows.Forms.TextBox();
            this.KestoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ArvioRichtexBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.tietojaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(682, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poistuToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.poistuToolStripMenuItem.Text = "Poistu";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.poistuToolStripMenuItem_Click);
            // 
            // tietojaToolStripMenuItem
            // 
            this.tietojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            this.tietojaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tietojaToolStripMenuItem.Text = "Tietoja";
            // 
            // testaaToolStripMenuItem
            // 
            this.testaaToolStripMenuItem.Name = "testaaToolStripMenuItem";
            this.testaaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.testaaToolStripMenuItem.Text = "Testaa Tietokantayhteytä";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.infoToolStripMenuItem.Text = "info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // Toiminolisuus
            // 
            this.Toiminolisuus.AutoSize = true;
            this.Toiminolisuus.Location = new System.Drawing.Point(71, 24);
            this.Toiminolisuus.Name = "Toiminolisuus";
            this.Toiminolisuus.Size = new System.Drawing.Size(70, 13);
            this.Toiminolisuus.TabIndex = 2;
            this.Toiminolisuus.Text = "Toiminolisuus";
            // 
            // UssiTietueButton
            // 
            this.UssiTietueButton.Location = new System.Drawing.Point(74, 79);
            this.UssiTietueButton.Name = "UssiTietueButton";
            this.UssiTietueButton.Size = new System.Drawing.Size(200, 50);
            this.UssiTietueButton.TabIndex = 3;
            this.UssiTietueButton.Text = "Uusi tietue";
            this.UssiTietueButton.UseVisualStyleBackColor = true;
            this.UssiTietueButton.Click += new System.EventHandler(this.UssiTietue_Button_Click);
            // 
            // TallenaButton
            // 
            this.TallenaButton.BackColor = System.Drawing.Color.Chartreuse;
            this.TallenaButton.ForeColor = System.Drawing.Color.Black;
            this.TallenaButton.Location = new System.Drawing.Point(74, 157);
            this.TallenaButton.Name = "TallenaButton";
            this.TallenaButton.Size = new System.Drawing.Size(200, 50);
            this.TallenaButton.TabIndex = 4;
            this.TallenaButton.Text = "Tallenna";
            this.TallenaButton.UseVisualStyleBackColor = false;
            this.TallenaButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // PoistaButton
            // 
            this.PoistaButton.BackColor = System.Drawing.Color.Red;
            this.PoistaButton.ForeColor = System.Drawing.Color.Black;
            this.PoistaButton.Location = new System.Drawing.Point(74, 228);
            this.PoistaButton.Name = "PoistaButton";
            this.PoistaButton.Size = new System.Drawing.Size(200, 50);
            this.PoistaButton.TabIndex = 5;
            this.PoistaButton.Text = "Poista";
            this.PoistaButton.UseVisualStyleBackColor = false;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(86, 71);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(114, 20);
            this.IdTextBox.TabIndex = 6;
            // 
            // NimiTextBox
            // 
            this.NimiTextBox.Location = new System.Drawing.Point(86, 129);
            this.NimiTextBox.Name = "NimiTextBox";
            this.NimiTextBox.Size = new System.Drawing.Size(194, 20);
            this.NimiTextBox.TabIndex = 7;
            this.NimiTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // VuosiTextBox
            // 
            this.VuosiTextBox.Location = new System.Drawing.Point(86, 187);
            this.VuosiTextBox.Name = "VuosiTextBox";
            this.VuosiTextBox.Size = new System.Drawing.Size(114, 20);
            this.VuosiTextBox.TabIndex = 8;
            // 
            // KestoTextBox
            // 
            this.KestoTextBox.Location = new System.Drawing.Point(86, 240);
            this.KestoTextBox.Name = "KestoTextBox";
            this.KestoTextBox.Size = new System.Drawing.Size(114, 20);
            this.KestoTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Elokuvat tiedot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Julkaisvuosi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kesto(min)";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.NimiTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IdTextBox);
            this.panel1.Controls.Add(this.VuosiTextBox);
            this.panel1.Controls.Add(this.KestoTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 353);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Toiminolisuus);
            this.panel2.Controls.Add(this.UssiTietueButton);
            this.panel2.Controls.Add(this.PoistaButton);
            this.panel2.Controls.Add(this.TallenaButton);
            this.panel2.Location = new System.Drawing.Point(353, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 353);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.numericUpDown2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.ArvioRichtexBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(12, 407);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 177);
            this.panel3.TabIndex = 17;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(128, 139);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(30, 20);
            this.numericUpDown2.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = ".";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(76, 139);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(30, 20);
            this.numericUpDown1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Arvosana";
            // 
            // ArvioRichtexBox
            // 
            this.ArvioRichtexBox.Location = new System.Drawing.Point(21, 31);
            this.ArvioRichtexBox.Name = "ArvioRichtexBox";
            this.ArvioRichtexBox.Size = new System.Drawing.Size(259, 96);
            this.ArvioRichtexBox.TabIndex = 18;
            this.ArvioRichtexBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Arvio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 586);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label Toiminolisuus;
        private System.Windows.Forms.Button UssiTietueButton;
        private System.Windows.Forms.Button TallenaButton;
        private System.Windows.Forms.Button PoistaButton;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NimiTextBox;
        private System.Windows.Forms.TextBox VuosiTextBox;
        private System.Windows.Forms.TextBox KestoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox ArvioRichtexBox;
        private System.Windows.Forms.Label label6;
    }
}

