
namespace FrotaEmpresa
{
    partial class ConsultarGasto
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botaoConsultar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(147, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de Gastos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código do Veículo : ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(205, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // botaoConsultar
            // 
            this.botaoConsultar.BackColor = System.Drawing.SystemColors.Control;
            this.botaoConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.botaoConsultar.FlatAppearance.BorderSize = 2;
            this.botaoConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoConsultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.botaoConsultar.Location = new System.Drawing.Point(333, 93);
            this.botaoConsultar.Name = "botaoConsultar";
            this.botaoConsultar.Size = new System.Drawing.Size(84, 32);
            this.botaoConsultar.TabIndex = 3;
            this.botaoConsultar.Text = "Consultar";
            this.botaoConsultar.UseVisualStyleBackColor = false;
            this.botaoConsultar.Click += new System.EventHandler(this.botaoConsultar_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 147);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(563, 301);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.botaoLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.botaoLimpar.FlatAppearance.BorderSize = 2;
            this.botaoLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoLimpar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.botaoLimpar.Location = new System.Drawing.Point(460, 93);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(84, 32);
            this.botaoLimpar.TabIndex = 5;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = false;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // ConsultarGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(586, 460);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.botaoConsultar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarGasto";
            this.Text = "Consultar Gasto";
            this.Load += new System.EventHandler(this.ConsultarGasto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botaoConsultar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button botaoLimpar;
    }
}