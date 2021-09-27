
namespace calculodefrete
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtfrete = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtestado = new System.Windows.Forms.Label();
            this.ptmcalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(236, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cáculo de Frete por Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(67, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(61, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(61, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Frete:";
      
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(144, 112);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(546, 23);
            this.txtnome.TabIndex = 4;
            // 
            // txtfrete
            // 
            this.txtfrete.Location = new System.Drawing.Point(141, 234);
            this.txtfrete.Name = "txtfrete";
            this.txtfrete.Size = new System.Drawing.Size(199, 23);
            this.txtfrete.TabIndex = 5;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(144, 172);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(313, 23);
            this.txtvalor.TabIndex = 6;
            // 
            // txtestado
            // 
            this.txtestado.AutoSize = true;
            this.txtestado.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtestado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtestado.Location = new System.Drawing.Point(473, 168);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(90, 23);
            this.txtestado.TabIndex = 7;
            this.txtestado.Text = "Estado:";
            // 
            // ptmcalcular
            // 
            this.ptmcalcular.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ptmcalcular.Location = new System.Drawing.Point(569, 264);
            this.ptmcalcular.Name = "ptmcalcular";
            this.ptmcalcular.Size = new System.Drawing.Size(121, 42);
            this.ptmcalcular.TabIndex = 8;
            this.ptmcalcular.Text = "Calcular";
            this.ptmcalcular.UseVisualStyleBackColor = true;
            this.ptmcalcular.Click += new System.EventHandler(this.ptmcalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(89, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor Final";
            // 
            // cbestado
            // 
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "AM",
            "MG",
            "RJ",
            "SP"});
            this.cbestado.Location = new System.Drawing.Point(569, 168);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(121, 23);
            this.cbestado.TabIndex = 10;
            // 
            // lblresultado
            // 
            this.lblresultado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblresultado.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblresultado.Location = new System.Drawing.Point(89, 387);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(601, 132);
            this.lblresultado.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ptmcalcular);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtfrete);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtfrete;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label txtestado;
        private System.Windows.Forms.Button ptmcalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.Label lblresultado;
    }
}

