namespace tehtava_16
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Vasstaus1 = new System.Windows.Forms.Button();
            this.VastausBox1 = new System.Windows.Forms.TextBox();
            this.SignButton = new System.Windows.Forms.Button();
            this.Ulos = new System.Windows.Forms.Button();
            this.PlayerTextBox = new System.Windows.Forms.TextBox();
            this.TotalPlayers = new System.Windows.Forms.TextBox();
            this.LabelVastaus1 = new System.Windows.Forms.Label();
            this.setting = new System.Windows.Forms.Button();
            this.VastausBox2 = new System.Windows.Forms.TextBox();
            this.Vasstaus2 = new System.Windows.Forms.Button();
            this.LabelVastaus2 = new System.Windows.Forms.Label();
            this.Palkinto = new System.Windows.Forms.Button();
            this.PalkintoTextBox = new System.Windows.Forms.RichTextBox();
            this.VastausBox3 = new System.Windows.Forms.TextBox();
            this.Vasstaus3 = new System.Windows.Forms.Button();
            this.LabelVastaus3 = new System.Windows.Forms.Label();
            this.Uudestan = new System.Windows.Forms.Button();
            this.AloittaPeli = new System.Windows.Forms.Button();
            this.PeliInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Vasstaus1
            // 
            this.Vasstaus1.Enabled = false;
            this.Vasstaus1.Location = new System.Drawing.Point(138, 34);
            this.Vasstaus1.Name = "Vasstaus1";
            this.Vasstaus1.Size = new System.Drawing.Size(75, 23);
            this.Vasstaus1.TabIndex = 0;
            this.Vasstaus1.Text = "Vastaus";
            this.Vasstaus1.UseVisualStyleBackColor = true;
            this.Vasstaus1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VastausBox1
            // 
            this.VastausBox1.Location = new System.Drawing.Point(23, 37);
            this.VastausBox1.Name = "VastausBox1";
            this.VastausBox1.ReadOnly = true;
            this.VastausBox1.Size = new System.Drawing.Size(100, 20);
            this.VastausBox1.TabIndex = 8;
            // 
            // SignButton
            // 
            this.SignButton.Enabled = false;
            this.SignButton.Location = new System.Drawing.Point(509, 59);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(58, 23);
            this.SignButton.TabIndex = 9;
            this.SignButton.Text = "Sign";
            this.SignButton.UseVisualStyleBackColor = true;
            this.SignButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // Ulos
            // 
            this.Ulos.Enabled = false;
            this.Ulos.Location = new System.Drawing.Point(573, 59);
            this.Ulos.Name = "Ulos";
            this.Ulos.Size = new System.Drawing.Size(58, 23);
            this.Ulos.TabIndex = 10;
            this.Ulos.Text = "Ulos";
            this.Ulos.UseVisualStyleBackColor = true;
            this.Ulos.Click += new System.EventHandler(this.Ulos_Click);
            // 
            // PlayerTextBox
            // 
            this.PlayerTextBox.Location = new System.Drawing.Point(-1, 1);
            this.PlayerTextBox.Name = "PlayerTextBox";
            this.PlayerTextBox.ReadOnly = true;
            this.PlayerTextBox.Size = new System.Drawing.Size(214, 20);
            this.PlayerTextBox.TabIndex = 13;
            this.PlayerTextBox.Text = "Player:";
            // 
            // TotalPlayers
            // 
            this.TotalPlayers.Location = new System.Drawing.Point(700, 1);
            this.TotalPlayers.Name = "TotalPlayers";
            this.TotalPlayers.ReadOnly = true;
            this.TotalPlayers.Size = new System.Drawing.Size(100, 20);
            this.TotalPlayers.TabIndex = 14;
            this.TotalPlayers.Text = "Total Players:";
            // 
            // LabelVastaus1
            // 
            this.LabelVastaus1.AutoSize = true;
            this.LabelVastaus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelVastaus1.Location = new System.Drawing.Point(220, 37);
            this.LabelVastaus1.Name = "LabelVastaus1";
            this.LabelVastaus1.Size = new System.Drawing.Size(94, 16);
            this.LabelVastaus1.TabIndex = 15;
            this.LabelVastaus1.Text = "Ei ole Vastaus";
            // 
            // setting
            // 
            this.setting.Location = new System.Drawing.Point(509, 12);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(122, 41);
            this.setting.TabIndex = 16;
            this.setting.Text = "Setting!";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // VastausBox2
            // 
            this.VastausBox2.Location = new System.Drawing.Point(23, 88);
            this.VastausBox2.Name = "VastausBox2";
            this.VastausBox2.ReadOnly = true;
            this.VastausBox2.Size = new System.Drawing.Size(100, 20);
            this.VastausBox2.TabIndex = 17;
            // 
            // Vasstaus2
            // 
            this.Vasstaus2.Enabled = false;
            this.Vasstaus2.Location = new System.Drawing.Point(138, 88);
            this.Vasstaus2.Name = "Vasstaus2";
            this.Vasstaus2.Size = new System.Drawing.Size(75, 23);
            this.Vasstaus2.TabIndex = 18;
            this.Vasstaus2.Text = "Vastaus";
            this.Vasstaus2.UseVisualStyleBackColor = true;
            this.Vasstaus2.Click += new System.EventHandler(this.Vasstaus2_Click);
            // 
            // LabelVastaus2
            // 
            this.LabelVastaus2.AutoSize = true;
            this.LabelVastaus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelVastaus2.Location = new System.Drawing.Point(220, 92);
            this.LabelVastaus2.Name = "LabelVastaus2";
            this.LabelVastaus2.Size = new System.Drawing.Size(94, 16);
            this.LabelVastaus2.TabIndex = 19;
            this.LabelVastaus2.Text = "Ei ole Vastaus";
            // 
            // Palkinto
            // 
            this.Palkinto.Enabled = false;
            this.Palkinto.Location = new System.Drawing.Point(509, 121);
            this.Palkinto.Name = "Palkinto";
            this.Palkinto.Size = new System.Drawing.Size(75, 23);
            this.Palkinto.TabIndex = 20;
            this.Palkinto.Text = "PALKINTO!";
            this.Palkinto.UseVisualStyleBackColor = true;
            this.Palkinto.Click += new System.EventHandler(this.Palkinto_Click);
            // 
            // PalkintoTextBox
            // 
            this.PalkintoTextBox.Location = new System.Drawing.Point(509, 157);
            this.PalkintoTextBox.Name = "PalkintoTextBox";
            this.PalkintoTextBox.ReadOnly = true;
            this.PalkintoTextBox.Size = new System.Drawing.Size(155, 121);
            this.PalkintoTextBox.TabIndex = 21;
            this.PalkintoTextBox.Text = "";
            // 
            // VastausBox3
            // 
            this.VastausBox3.Location = new System.Drawing.Point(23, 137);
            this.VastausBox3.Name = "VastausBox3";
            this.VastausBox3.ReadOnly = true;
            this.VastausBox3.Size = new System.Drawing.Size(100, 20);
            this.VastausBox3.TabIndex = 22;
            // 
            // Vasstaus3
            // 
            this.Vasstaus3.Enabled = false;
            this.Vasstaus3.Location = new System.Drawing.Point(138, 137);
            this.Vasstaus3.Name = "Vasstaus3";
            this.Vasstaus3.Size = new System.Drawing.Size(75, 23);
            this.Vasstaus3.TabIndex = 23;
            this.Vasstaus3.Text = "Vastaus";
            this.Vasstaus3.UseVisualStyleBackColor = true;
            this.Vasstaus3.Click += new System.EventHandler(this.Vasstaus3_Click);
            // 
            // LabelVastaus3
            // 
            this.LabelVastaus3.AutoSize = true;
            this.LabelVastaus3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelVastaus3.Location = new System.Drawing.Point(220, 141);
            this.LabelVastaus3.Name = "LabelVastaus3";
            this.LabelVastaus3.Size = new System.Drawing.Size(94, 16);
            this.LabelVastaus3.TabIndex = 24;
            this.LabelVastaus3.Text = "Ei ole Vastaus";
            // 
            // Uudestan
            // 
            this.Uudestan.Enabled = false;
            this.Uudestan.Location = new System.Drawing.Point(509, 88);
            this.Uudestan.Name = "Uudestan";
            this.Uudestan.Size = new System.Drawing.Size(122, 23);
            this.Uudestan.TabIndex = 25;
            this.Uudestan.Text = "Pella uudestan!";
            this.Uudestan.UseVisualStyleBackColor = true;
            this.Uudestan.Click += new System.EventHandler(this.Uudestan_Click);
            // 
            // AloittaPeli
            // 
            this.AloittaPeli.Enabled = false;
            this.AloittaPeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AloittaPeli.Location = new System.Drawing.Point(344, 12);
            this.AloittaPeli.Name = "AloittaPeli";
            this.AloittaPeli.Size = new System.Drawing.Size(150, 70);
            this.AloittaPeli.TabIndex = 26;
            this.AloittaPeli.Text = "Aloitta Peli!";
            this.AloittaPeli.UseVisualStyleBackColor = true;
            this.AloittaPeli.Click += new System.EventHandler(this.AloittaPeli_Click);
            // 
            // PeliInfo
            // 
            this.PeliInfo.Location = new System.Drawing.Point(344, 92);
            this.PeliInfo.Name = "PeliInfo";
            this.PeliInfo.ReadOnly = true;
            this.PeliInfo.Size = new System.Drawing.Size(150, 89);
            this.PeliInfo.TabIndex = 27;
            this.PeliInfo.Text = "Tämä on Peliinfo. Napsauta asetuspainiketta!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PeliInfo);
            this.Controls.Add(this.AloittaPeli);
            this.Controls.Add(this.Uudestan);
            this.Controls.Add(this.LabelVastaus3);
            this.Controls.Add(this.Vasstaus3);
            this.Controls.Add(this.VastausBox3);
            this.Controls.Add(this.PalkintoTextBox);
            this.Controls.Add(this.Palkinto);
            this.Controls.Add(this.LabelVastaus2);
            this.Controls.Add(this.Vasstaus2);
            this.Controls.Add(this.VastausBox2);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.LabelVastaus1);
            this.Controls.Add(this.TotalPlayers);
            this.Controls.Add(this.PlayerTextBox);
            this.Controls.Add(this.Ulos);
            this.Controls.Add(this.SignButton);
            this.Controls.Add(this.VastausBox1);
            this.Controls.Add(this.Vasstaus1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox VastausBox1;
        public System.Windows.Forms.Button Vasstaus1;
        public System.Windows.Forms.Label LabelVastaus1;
        public System.Windows.Forms.Button SignButton;
        public System.Windows.Forms.Button setting;
        public System.Windows.Forms.TextBox VastausBox2;
        public System.Windows.Forms.Button Vasstaus2;
        public System.Windows.Forms.Label LabelVastaus2;
        private System.Windows.Forms.RichTextBox PalkintoTextBox;
        public System.Windows.Forms.TextBox VastausBox3;
        public System.Windows.Forms.Button Vasstaus3;
        public System.Windows.Forms.Label LabelVastaus3;
        public System.Windows.Forms.Button Ulos;
        public System.Windows.Forms.TextBox PlayerTextBox;
        public System.Windows.Forms.TextBox TotalPlayers;
        public System.Windows.Forms.Button Palkinto;
        public System.Windows.Forms.Button Uudestan;
        public System.Windows.Forms.Button AloittaPeli;
        public System.Windows.Forms.RichTextBox PeliInfo;
    }
}

