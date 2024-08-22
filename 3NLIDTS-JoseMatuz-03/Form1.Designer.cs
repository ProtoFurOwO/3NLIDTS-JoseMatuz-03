namespace _3NLIDTS_JoseMatuz_03
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ftitle = new System.Windows.Forms.Label();
            this.ctitle = new System.Windows.Forms.Label();
            this.ftc = new System.Windows.Forms.Button();
            this.ctf = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.farendato = new System.Windows.Forms.TextBox();
            this.celdato = new System.Windows.Forms.TextBox();
            this.welcom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ftitle
            // 
            this.ftitle.AutoSize = true;
            this.ftitle.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftitle.Location = new System.Drawing.Point(453, 106);
            this.ftitle.Name = "ftitle";
            this.ftitle.Size = new System.Drawing.Size(162, 20);
            this.ftitle.TabIndex = 0;
            this.ftitle.Text = "Grados Fahrenheit";
            // 
            // ctitle
            // 
            this.ctitle.AutoSize = true;
            this.ctitle.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctitle.Location = new System.Drawing.Point(227, 106);
            this.ctitle.Name = "ctitle";
            this.ctitle.Size = new System.Drawing.Size(135, 20);
            this.ctitle.TabIndex = 1;
            this.ctitle.Text = "Grados Celsius";
            this.ctitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // ftc
            // 
            this.ftc.Location = new System.Drawing.Point(467, 186);
            this.ftc.Name = "ftc";
            this.ftc.Size = new System.Drawing.Size(134, 23);
            this.ftc.TabIndex = 2;
            this.ftc.Text = "Convertir F° a C°";
            this.ftc.UseVisualStyleBackColor = true;
            this.ftc.Click += new System.EventHandler(this.ftc_Click);
            // 
            // ctf
            // 
            this.ctf.Location = new System.Drawing.Point(231, 186);
            this.ctf.Name = "ctf";
            this.ctf.Size = new System.Drawing.Size(120, 23);
            this.ctf.TabIndex = 3;
            this.ctf.Text = "Convertir C° a F°";
            this.ctf.UseVisualStyleBackColor = true;
            this.ctf.Click += new System.EventHandler(this.ctf_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.Location = new System.Drawing.Point(381, 248);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(75, 23);
            this.clrbtn.TabIndex = 4;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = true;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // farendato
            // 
            this.farendato.Location = new System.Drawing.Point(479, 140);
            this.farendato.Name = "farendato";
            this.farendato.Size = new System.Drawing.Size(100, 22);
            this.farendato.TabIndex = 5;
            // 
            // celdato
            // 
            this.celdato.Location = new System.Drawing.Point(242, 152);
            this.celdato.Name = "celdato";
            this.celdato.Size = new System.Drawing.Size(100, 22);
            this.celdato.TabIndex = 6;
            this.celdato.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // welcom
            // 
            this.welcom.AutoSize = true;
            this.welcom.Location = new System.Drawing.Point(315, 44);
            this.welcom.Name = "welcom";
            this.welcom.Size = new System.Drawing.Size(212, 16);
            this.welcom.TabIndex = 7;
            this.welcom.Text = "Conversor de temperatura (C° y F°)";
            this.welcom.Click += new System.EventHandler(this.welcom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(887, 423);
            this.Controls.Add(this.welcom);
            this.Controls.Add(this.celdato);
            this.Controls.Add(this.farendato);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.ctf);
            this.Controls.Add(this.ftc);
            this.Controls.Add(this.ctitle);
            this.Controls.Add(this.ftitle);
            this.Name = "Form1";
            this.Text = "Conversor de Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ftitle;
        private System.Windows.Forms.Label ctitle;
        private System.Windows.Forms.Button ftc;
        private System.Windows.Forms.Button ctf;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.TextBox farendato;
        private System.Windows.Forms.TextBox celdato;
        private System.Windows.Forms.Label welcom;
    }
}

