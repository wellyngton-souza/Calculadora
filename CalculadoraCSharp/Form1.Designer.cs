namespace CalculadoraCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_reseta = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_multiplica = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_subtrai = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_soma = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_igual = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button0 = new System.Windows.Forms.Button();
            this.button_virgula = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_reseta
            // 
            this.button_reseta.BackColor = System.Drawing.Color.LightCoral;
            this.button_reseta.Location = new System.Drawing.Point(32, 155);
            this.button_reseta.Name = "button_reseta";
            this.button_reseta.Size = new System.Drawing.Size(186, 90);
            this.button_reseta.TabIndex = 0;
            this.button_reseta.Text = "C";
            this.button_reseta.UseVisualStyleBackColor = false;
            this.button_reseta.Click += new System.EventHandler(this.button_reseta_Click);
            // 
            // button_divide
            // 
            this.button_divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button_divide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_divide.Location = new System.Drawing.Point(224, 155);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(90, 90);
            this.button_divide.TabIndex = 1;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = false;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_multiplica
            // 
            this.button_multiplica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button_multiplica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_multiplica.Location = new System.Drawing.Point(320, 155);
            this.button_multiplica.Name = "button_multiplica";
            this.button_multiplica.Size = new System.Drawing.Size(90, 90);
            this.button_multiplica.TabIndex = 2;
            this.button_multiplica.Text = "*";
            this.button_multiplica.UseVisualStyleBackColor = false;
            this.button_multiplica.Click += new System.EventHandler(this.button_multiplica_Click);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button_7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_7.Location = new System.Drawing.Point(32, 251);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(90, 90);
            this.button_7.TabIndex = 3;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button_8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_8.Location = new System.Drawing.Point(128, 251);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(90, 90);
            this.button_8.TabIndex = 4;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button_9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_9.Location = new System.Drawing.Point(224, 251);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(90, 90);
            this.button_9.TabIndex = 5;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_subtrai
            // 
            this.button_subtrai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button_subtrai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_subtrai.Location = new System.Drawing.Point(320, 251);
            this.button_subtrai.Name = "button_subtrai";
            this.button_subtrai.Size = new System.Drawing.Size(90, 90);
            this.button_subtrai.TabIndex = 6;
            this.button_subtrai.Text = "-";
            this.button_subtrai.UseVisualStyleBackColor = false;
            this.button_subtrai.Click += new System.EventHandler(this.button_subtrai_Click);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button_4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_4.Location = new System.Drawing.Point(32, 347);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(90, 90);
            this.button_4.TabIndex = 7;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button_5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_5.Location = new System.Drawing.Point(128, 347);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(90, 90);
            this.button_5.TabIndex = 8;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button_6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_6.Location = new System.Drawing.Point(224, 347);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(90, 90);
            this.button_6.TabIndex = 9;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_soma
            // 
            this.button_soma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button_soma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_soma.Location = new System.Drawing.Point(320, 347);
            this.button_soma.Name = "button_soma";
            this.button_soma.Size = new System.Drawing.Size(90, 90);
            this.button_soma.TabIndex = 10;
            this.button_soma.Text = "+";
            this.button_soma.UseVisualStyleBackColor = false;
            this.button_soma.Click += new System.EventHandler(this.button_soma_Click);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_3.Location = new System.Drawing.Point(224, 443);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(90, 90);
            this.button_3.TabIndex = 11;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_2.Location = new System.Drawing.Point(128, 443);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(90, 90);
            this.button_2.TabIndex = 12;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_1.Location = new System.Drawing.Point(32, 443);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(90, 90);
            this.button_1.TabIndex = 13;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_igual
            // 
            this.button_igual.BackColor = System.Drawing.Color.LawnGreen;
            this.button_igual.Location = new System.Drawing.Point(320, 443);
            this.button_igual.Name = "button_igual";
            this.button_igual.Size = new System.Drawing.Size(90, 186);
            this.button_igual.TabIndex = 14;
            this.button_igual.Text = "=";
            this.button_igual.UseVisualStyleBackColor = false;
            this.button_igual.Click += new System.EventHandler(this.button_igual_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 137);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button0.Location = new System.Drawing.Point(32, 539);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(186, 90);
            this.button0.TabIndex = 16;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button_virgula
            // 
            this.button_virgula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button_virgula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_virgula.Location = new System.Drawing.Point(224, 539);
            this.button_virgula.Name = "button_virgula";
            this.button_virgula.Size = new System.Drawing.Size(90, 90);
            this.button_virgula.TabIndex = 17;
            this.button_virgula.Text = ",";
            this.button_virgula.UseVisualStyleBackColor = false;
            this.button_virgula.Click += new System.EventHandler(this.button_virgula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(447, 645);
            this.Controls.Add(this.button_virgula);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_igual);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_soma);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_subtrai);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_multiplica);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_reseta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(463, 684);
            this.MinimumSize = new System.Drawing.Size(463, 684);
            this.Name = "Form1";
            this.Text = "Form 1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_reseta;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_multiplica;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_subtrai;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_soma;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_igual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_virgula;
    }
}

