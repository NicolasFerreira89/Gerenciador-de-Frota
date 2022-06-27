
namespace FrotaEmpresa
{
    partial class ExcluirCadastro
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
            this.ExcluirMotorista = new System.Windows.Forms.Button();
            this.ExcluirVeiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(181, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excluir Cadastro";
            // 
            // ExcluirMotorista
            // 
            this.ExcluirMotorista.BackColor = System.Drawing.SystemColors.Control;
            this.ExcluirMotorista.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ExcluirMotorista.FlatAppearance.BorderSize = 2;
            this.ExcluirMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirMotorista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcluirMotorista.Location = new System.Drawing.Point(344, 143);
            this.ExcluirMotorista.Name = "ExcluirMotorista";
            this.ExcluirMotorista.Size = new System.Drawing.Size(215, 100);
            this.ExcluirMotorista.TabIndex = 2;
            this.ExcluirMotorista.Text = "Excluir Cadastro de Motorista";
            this.ExcluirMotorista.UseVisualStyleBackColor = false;
            this.ExcluirMotorista.Click += new System.EventHandler(this.ExcluirMotorista_Click);
            // 
            // ExcluirVeiculo
            // 
            this.ExcluirVeiculo.BackColor = System.Drawing.SystemColors.Control;
            this.ExcluirVeiculo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ExcluirVeiculo.FlatAppearance.BorderSize = 2;
            this.ExcluirVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirVeiculo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcluirVeiculo.Location = new System.Drawing.Point(39, 144);
            this.ExcluirVeiculo.Name = "ExcluirVeiculo";
            this.ExcluirVeiculo.Size = new System.Drawing.Size(215, 100);
            this.ExcluirVeiculo.TabIndex = 3;
            this.ExcluirVeiculo.Text = "Excluir Cadastro do Veículo";
            this.ExcluirVeiculo.UseVisualStyleBackColor = false;
            this.ExcluirVeiculo.Click += new System.EventHandler(this.ExcluirVeiculo_Click);
            // 
            // ExcluirCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(593, 328);
            this.Controls.Add(this.ExcluirVeiculo);
            this.Controls.Add(this.ExcluirMotorista);
            this.Controls.Add(this.label1);
            this.Name = "ExcluirCadastro";
            this.Text = "Excluir Cadastro";
            this.Load += new System.EventHandler(this.ExcluirCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExcluirMotorista;
        private System.Windows.Forms.Button ExcluirVeiculo;
    }
}