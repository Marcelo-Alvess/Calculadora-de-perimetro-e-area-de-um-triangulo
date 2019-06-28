namespace Tria
{
    partial class frmTriangulos
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
            this.rdbEqui = new System.Windows.Forms.RadioButton();
            this.rdbIso = new System.Windows.Forms.RadioButton();
            this.rdbEsca = new System.Windows.Forms.RadioButton();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.txtperim = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbEqui
            // 
            this.rdbEqui.AutoSize = true;
            this.rdbEqui.Location = new System.Drawing.Point(4, 10);
            this.rdbEqui.Name = "rdbEqui";
            this.rdbEqui.Size = new System.Drawing.Size(72, 17);
            this.rdbEqui.TabIndex = 0;
            this.rdbEqui.TabStop = true;
            this.rdbEqui.Text = "Equilátero";
            this.rdbEqui.UseVisualStyleBackColor = true;
            this.rdbEqui.CheckedChanged += new System.EventHandler(this.rdbEqui_CheckedChanged);
            // 
            // rdbIso
            // 
            this.rdbIso.AutoSize = true;
            this.rdbIso.Location = new System.Drawing.Point(4, 38);
            this.rdbIso.Name = "rdbIso";
            this.rdbIso.Size = new System.Drawing.Size(64, 17);
            this.rdbIso.TabIndex = 1;
            this.rdbIso.TabStop = true;
            this.rdbIso.Text = "Isóceles";
            this.rdbIso.UseVisualStyleBackColor = true;
            this.rdbIso.CheckedChanged += new System.EventHandler(this.rdbIso_CheckedChanged);
            // 
            // rdbEsca
            // 
            this.rdbEsca.AutoSize = true;
            this.rdbEsca.Location = new System.Drawing.Point(4, 62);
            this.rdbEsca.Name = "rdbEsca";
            this.rdbEsca.Size = new System.Drawing.Size(69, 17);
            this.rdbEsca.TabIndex = 2;
            this.rdbEsca.TabStop = true;
            this.rdbEsca.Text = "Escaleno";
            this.rdbEsca.UseVisualStyleBackColor = true;
            this.rdbEsca.CheckedChanged += new System.EventHandler(this.rdbEsca_CheckedChanged);
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(118, 7);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 20);
            this.txtLado1.TabIndex = 3;
            this.txtLado1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(118, 33);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 4;
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(118, 59);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 20);
            this.txtLado3.TabIndex = 5;
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(77, 14);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(40, 13);
            this.lblLado1.TabIndex = 6;
            this.lblLado1.Text = "Lado 1";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(77, 40);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(40, 13);
            this.lblLado2.TabIndex = 7;
            this.lblLado2.Text = "Lado 2";
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Location = new System.Drawing.Point(77, 63);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(40, 13);
            this.lblLado3.TabIndex = 8;
            this.lblLado3.Text = "Lado 3";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(247, 58);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(159, 23);
            this.btnCalcula.TabIndex = 9;
            this.btnCalcula.Text = "Calcular!";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // txtarea
            // 
            this.txtarea.Enabled = false;
            this.txtarea.Location = new System.Drawing.Point(279, 9);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(127, 20);
            this.txtarea.TabIndex = 10;
            this.txtarea.TextChanged += new System.EventHandler(this.txtarea_TextChanged);
            // 
            // txtperim
            // 
            this.txtperim.Enabled = false;
            this.txtperim.Location = new System.Drawing.Point(306, 33);
            this.txtperim.Name = "txtperim";
            this.txtperim.Size = new System.Drawing.Size(100, 20);
            this.txtperim.TabIndex = 11;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(244, 12);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 12;
            this.lblArea.Text = "Área";
            // 
            // lblPerim
            // 
            this.lblPerim.AutoSize = true;
            this.lblPerim.Location = new System.Drawing.Point(244, 38);
            this.lblPerim.Name = "lblPerim";
            this.lblPerim.Size = new System.Drawing.Size(53, 13);
            this.lblPerim.TabIndex = 13;
            this.lblPerim.Text = "Perímetro";
            // 
            // frmTriangulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 99);
            this.Controls.Add(this.lblPerim);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtperim);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.rdbEsca);
            this.Controls.Add(this.rdbIso);
            this.Controls.Add(this.rdbEqui);
            this.Name = "frmTriangulos";
            this.Text = "Triângulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbEqui;
        private System.Windows.Forms.RadioButton rdbIso;
        private System.Windows.Forms.RadioButton rdbEsca;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.TextBox txtperim;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerim;
    }
}

