namespace Calculadora
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
            this.b_sumar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_resp = new System.Windows.Forms.Label();
            this.b_restar = new System.Windows.Forms.Button();
            this.b_multiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_sumar
            // 
            this.b_sumar.Location = new System.Drawing.Point(41, 164);
            this.b_sumar.Name = "b_sumar";
            this.b_sumar.Size = new System.Drawing.Size(47, 23);
            this.b_sumar.TabIndex = 0;
            this.b_sumar.Text = "Sumar";
            this.b_sumar.UseVisualStyleBackColor = true;
            this.b_sumar.Click += new System.EventHandler(this.b_sumar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Primer numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese Segundo numero:";
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(189, 56);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(47, 20);
            this.txt_1.TabIndex = 3;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(189, 86);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(46, 20);
            this.txt_2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Respuesta:";
            // 
            // lbl_resp
            // 
            this.lbl_resp.AutoSize = true;
            this.lbl_resp.Location = new System.Drawing.Point(186, 118);
            this.lbl_resp.Name = "lbl_resp";
            this.lbl_resp.Size = new System.Drawing.Size(22, 13);
            this.lbl_resp.TabIndex = 6;
            this.lbl_resp.Text = "-----";
            // 
            // b_restar
            // 
            this.b_restar.Location = new System.Drawing.Point(106, 164);
            this.b_restar.Name = "b_restar";
            this.b_restar.Size = new System.Drawing.Size(47, 23);
            this.b_restar.TabIndex = 7;
            this.b_restar.Text = "Restar";
            this.b_restar.UseVisualStyleBackColor = true;
            this.b_restar.Click += new System.EventHandler(this.b_restar_Click);
            // 
            // b_multiplicar
            // 
            this.b_multiplicar.Location = new System.Drawing.Point(168, 164);
            this.b_multiplicar.Name = "b_multiplicar";
            this.b_multiplicar.Size = new System.Drawing.Size(68, 23);
            this.b_multiplicar.TabIndex = 8;
            this.b_multiplicar.Text = "Multiplicar";
            this.b_multiplicar.UseVisualStyleBackColor = true;
            this.b_multiplicar.Click += new System.EventHandler(this.b_multiplicar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.b_multiplicar);
            this.Controls.Add(this.b_restar);
            this.Controls.Add(this.lbl_resp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_sumar);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_sumar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_resp;
        private System.Windows.Forms.Button b_restar;
        private System.Windows.Forms.Button b_multiplicar;
    }
}

