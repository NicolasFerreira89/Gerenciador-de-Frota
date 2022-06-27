
namespace FrotaEmpresa
{
    partial class ExcluirVeiculo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.botaoConsultar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Excluir = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excluir Cadastro do Veículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(35, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(35, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(35, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(35, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cor : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(35, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Combustível : ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(117, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.maskedTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.maskedTextBox1.Location = new System.Drawing.Point(103, 151);
            this.maskedTextBox1.Mask = ">LLL<9>&<99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(71, 23);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox2.Location = new System.Drawing.Point(119, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 23);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox3.Location = new System.Drawing.Point(88, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 23);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // botaoConsultar
            // 
            this.botaoConsultar.BackColor = System.Drawing.SystemColors.Control;
            this.botaoConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.botaoConsultar.FlatAppearance.BorderSize = 2;
            this.botaoConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoConsultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.botaoConsultar.Location = new System.Drawing.Point(200, 98);
            this.botaoConsultar.Name = "botaoConsultar";
            this.botaoConsultar.Size = new System.Drawing.Size(84, 32);
            this.botaoConsultar.TabIndex = 11;
            this.botaoConsultar.Text = "Consultar";
            this.botaoConsultar.UseVisualStyleBackColor = false;
            this.botaoConsultar.Click += new System.EventHandler(this.botaoConsultar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gasolina",
            "Etanol",
            "Diesel",
            "GNV",
            "Flex"});
            this.comboBox1.Location = new System.Drawing.Point(152, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.SystemColors.Control;
            this.Excluir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Excluir.FlatAppearance.BorderSize = 2;
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excluir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Excluir.Location = new System.Drawing.Point(103, 351);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(124, 46);
            this.Excluir.TabIndex = 13;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Limpar
            // 
            this.Limpar.BackColor = System.Drawing.SystemColors.Control;
            this.Limpar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Limpar.FlatAppearance.BorderSize = 2;
            this.Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Limpar.Location = new System.Drawing.Point(297, 351);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(124, 46);
            this.Limpar.TabIndex = 14;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = false;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // ExcluirVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(519, 409);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.botaoConsultar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExcluirVeiculo";
            this.Text = "Excluir Veículo";
            this.Load += new System.EventHandler(this.ExcluirVeiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button botaoConsultar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Limpar;
    }
}