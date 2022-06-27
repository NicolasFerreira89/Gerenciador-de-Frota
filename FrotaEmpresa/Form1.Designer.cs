
namespace FrotaEmpresa
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
            this.label1 = new System.Windows.Forms.Label();
            this.CadastrarVeiculo = new System.Windows.Forms.Button();
            this.CadastrarMotorista = new System.Windows.Forms.Button();
            this.atuCadastroVeiculo = new System.Windows.Forms.Button();
            this.atuCadastroMotorista = new System.Windows.Forms.Button();
            this.registrarGasto = new System.Windows.Forms.Button();
            this.consultarGasto = new System.Windows.Forms.Button();
            this.excluirCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(146, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frota Empresa \"########\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CadastrarVeiculo
            // 
            this.CadastrarVeiculo.BackColor = System.Drawing.SystemColors.Control;
            this.CadastrarVeiculo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CadastrarVeiculo.FlatAppearance.BorderSize = 2;
            this.CadastrarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastrarVeiculo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarVeiculo.Location = new System.Drawing.Point(99, 128);
            this.CadastrarVeiculo.Name = "CadastrarVeiculo";
            this.CadastrarVeiculo.Size = new System.Drawing.Size(200, 60);
            this.CadastrarVeiculo.TabIndex = 1;
            this.CadastrarVeiculo.Text = "Cadastrar Veículo";
            this.CadastrarVeiculo.UseVisualStyleBackColor = false;
            this.CadastrarVeiculo.Click += new System.EventHandler(this.CadastrarVeiculo_Click);
            // 
            // CadastrarMotorista
            // 
            this.CadastrarMotorista.BackColor = System.Drawing.SystemColors.Control;
            this.CadastrarMotorista.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CadastrarMotorista.FlatAppearance.BorderSize = 2;
            this.CadastrarMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastrarMotorista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarMotorista.Location = new System.Drawing.Point(350, 128);
            this.CadastrarMotorista.Name = "CadastrarMotorista";
            this.CadastrarMotorista.Size = new System.Drawing.Size(200, 60);
            this.CadastrarMotorista.TabIndex = 2;
            this.CadastrarMotorista.Text = "Cadastrar Motorista";
            this.CadastrarMotorista.UseVisualStyleBackColor = false;
            this.CadastrarMotorista.Click += new System.EventHandler(this.CadastrarMotorista_Click);
            // 
            // atuCadastroVeiculo
            // 
            this.atuCadastroVeiculo.BackColor = System.Drawing.SystemColors.Control;
            this.atuCadastroVeiculo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.atuCadastroVeiculo.FlatAppearance.BorderSize = 2;
            this.atuCadastroVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atuCadastroVeiculo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atuCadastroVeiculo.Location = new System.Drawing.Point(99, 227);
            this.atuCadastroVeiculo.Name = "atuCadastroVeiculo";
            this.atuCadastroVeiculo.Size = new System.Drawing.Size(200, 60);
            this.atuCadastroVeiculo.TabIndex = 3;
            this.atuCadastroVeiculo.Text = "Consultar / Atualizar Cadastro Veículo";
            this.atuCadastroVeiculo.UseVisualStyleBackColor = false;
            this.atuCadastroVeiculo.Click += new System.EventHandler(this.atuCadastroVeiculo_Click);
            // 
            // atuCadastroMotorista
            // 
            this.atuCadastroMotorista.BackColor = System.Drawing.SystemColors.Control;
            this.atuCadastroMotorista.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.atuCadastroMotorista.FlatAppearance.BorderSize = 2;
            this.atuCadastroMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atuCadastroMotorista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atuCadastroMotorista.Location = new System.Drawing.Point(350, 227);
            this.atuCadastroMotorista.Name = "atuCadastroMotorista";
            this.atuCadastroMotorista.Size = new System.Drawing.Size(200, 60);
            this.atuCadastroMotorista.TabIndex = 4;
            this.atuCadastroMotorista.Text = "Consultar / Atualizar Cadastro Motorista";
            this.atuCadastroMotorista.UseVisualStyleBackColor = false;
            this.atuCadastroMotorista.Click += new System.EventHandler(this.atuCadastroMotorista_Click);
            // 
            // registrarGasto
            // 
            this.registrarGasto.BackColor = System.Drawing.SystemColors.Control;
            this.registrarGasto.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.registrarGasto.FlatAppearance.BorderSize = 2;
            this.registrarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarGasto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarGasto.Location = new System.Drawing.Point(99, 329);
            this.registrarGasto.Name = "registrarGasto";
            this.registrarGasto.Size = new System.Drawing.Size(200, 60);
            this.registrarGasto.TabIndex = 5;
            this.registrarGasto.Text = "Registrar Gasto";
            this.registrarGasto.UseVisualStyleBackColor = false;
            this.registrarGasto.Click += new System.EventHandler(this.registrarGasto_Click);
            // 
            // consultarGasto
            // 
            this.consultarGasto.BackColor = System.Drawing.SystemColors.Control;
            this.consultarGasto.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.consultarGasto.FlatAppearance.BorderSize = 2;
            this.consultarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarGasto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarGasto.Location = new System.Drawing.Point(350, 329);
            this.consultarGasto.Name = "consultarGasto";
            this.consultarGasto.Size = new System.Drawing.Size(200, 60);
            this.consultarGasto.TabIndex = 6;
            this.consultarGasto.Text = "Consultar Gasto";
            this.consultarGasto.UseVisualStyleBackColor = false;
            this.consultarGasto.Click += new System.EventHandler(this.consultarGasto_Click);
            // 
            // excluirCadastro
            // 
            this.excluirCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.excluirCadastro.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.excluirCadastro.FlatAppearance.BorderSize = 2;
            this.excluirCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirCadastro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirCadastro.ForeColor = System.Drawing.Color.Black;
            this.excluirCadastro.Location = new System.Drawing.Point(226, 419);
            this.excluirCadastro.Name = "excluirCadastro";
            this.excluirCadastro.Size = new System.Drawing.Size(200, 60);
            this.excluirCadastro.TabIndex = 7;
            this.excluirCadastro.Text = "Excluir cadastro";
            this.excluirCadastro.UseVisualStyleBackColor = false;
            this.excluirCadastro.Click += new System.EventHandler(this.excluirCadastro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(636, 499);
            this.Controls.Add(this.excluirCadastro);
            this.Controls.Add(this.consultarGasto);
            this.Controls.Add(this.registrarGasto);
            this.Controls.Add(this.atuCadastroMotorista);
            this.Controls.Add(this.atuCadastroVeiculo);
            this.Controls.Add(this.CadastrarMotorista);
            this.Controls.Add(this.CadastrarVeiculo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Controle de Frota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CadastrarVeiculo;
        private System.Windows.Forms.Button CadastrarMotorista;
        private System.Windows.Forms.Button atuCadastroVeiculo;
        private System.Windows.Forms.Button atuCadastroMotorista;
        private System.Windows.Forms.Button registrarGasto;
        private System.Windows.Forms.Button consultarGasto;
        private System.Windows.Forms.Button excluirCadastro;
    }
}

