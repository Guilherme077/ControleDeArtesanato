namespace ControleDeArtesanato
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
            groupBox1 = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label9 = new Label();
            txtPedidos = new TextBox();
            groupBox3 = new GroupBox();
            label22 = new Label();
            label10 = new Label();
            txtEntregas = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label21 = new Label();
            label19 = new Label();
            label20 = new Label();
            btnRegEnc = new Button();
            btnRegCon = new Button();
            txtNomeCliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNomeProduto = new TextBox();
            label3 = new Label();
            txtDescricao = new TextBox();
            label4 = new Label();
            txtValor = new TextBox();
            label5 = new Label();
            txtPrazo = new TextBox();
            label6 = new Label();
            txtID = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label11 = new Label();
            label23 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPedidos);
            groupBox1.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Italic);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1758, 375);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pedidos Recebidos";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(1063, 34);
            label16.Name = "label16";
            label16.Size = new Size(113, 25);
            label16.TabIndex = 6;
            label16.Text = "Data de Prazo";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(879, 34);
            label15.Name = "label15";
            label15.Size = new Size(159, 25);
            label15.TabIndex = 5;
            label15.Text = "Data da Encomenda";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(408, 28);
            label14.Name = "label14";
            label14.Size = new Size(83, 25);
            label14.TabIndex = 4;
            label14.Text = "Descrição";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(259, 28);
            label13.Name = "label13";
            label13.Size = new Size(69, 25);
            label13.TabIndex = 3;
            label13.Text = "Produto";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(117, 28);
            label12.Name = "label12";
            label12.Size = new Size(63, 25);
            label12.TabIndex = 2;
            label12.Text = "Cliente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 28);
            label9.Name = "label9";
            label9.Size = new Size(28, 25);
            label9.TabIndex = 1;
            label9.Text = "ID";
            // 
            // txtPedidos
            // 
            txtPedidos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPedidos.Location = new Point(6, 62);
            txtPedidos.MaxLength = 400000;
            txtPedidos.Multiline = true;
            txtPedidos.Name = "txtPedidos";
            txtPedidos.ReadOnly = true;
            txtPedidos.ScrollBars = ScrollBars.Both;
            txtPedidos.Size = new Size(1746, 307);
            txtPedidos.TabIndex = 0;
            txtPedidos.WordWrap = false;
            txtPedidos.TextChanged += txtPedidos_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtEntregas);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label20);
            groupBox3.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 393);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1758, 338);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Entrega";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(1182, 26);
            label22.Name = "label22";
            label22.Size = new Size(128, 25);
            label22.TabIndex = 13;
            label22.Text = "Data de Entrega";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(1063, 28);
            label10.Name = "label10";
            label10.Size = new Size(113, 25);
            label10.TabIndex = 12;
            label10.Text = "Data de Prazo";
            // 
            // txtEntregas
            // 
            txtEntregas.Font = new Font("Segoe UI", 10F);
            txtEntregas.Location = new Point(6, 56);
            txtEntregas.MaxLength = 400000;
            txtEntregas.Multiline = true;
            txtEntregas.Name = "txtEntregas";
            txtEntregas.ReadOnly = true;
            txtEntregas.ScrollBars = ScrollBars.Both;
            txtEntregas.Size = new Size(1746, 276);
            txtEntregas.TabIndex = 1;
            txtEntregas.WordWrap = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(879, 28);
            label17.Name = "label17";
            label17.Size = new Size(159, 25);
            label17.TabIndex = 11;
            label17.Text = "Data da Encomenda";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(408, 26);
            label18.Name = "label18";
            label18.Size = new Size(83, 25);
            label18.TabIndex = 10;
            label18.Text = "Descrição";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(13, 28);
            label21.Name = "label21";
            label21.Size = new Size(28, 25);
            label21.TabIndex = 7;
            label21.Text = "ID";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(259, 28);
            label19.Name = "label19";
            label19.Size = new Size(69, 25);
            label19.TabIndex = 9;
            label19.Text = "Produto";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(117, 28);
            label20.Name = "label20";
            label20.Size = new Size(63, 25);
            label20.TabIndex = 8;
            label20.Text = "Cliente";
            // 
            // btnRegEnc
            // 
            btnRegEnc.BackColor = Color.SpringGreen;
            btnRegEnc.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegEnc.Location = new Point(18, 859);
            btnRegEnc.Name = "btnRegEnc";
            btnRegEnc.Size = new Size(1051, 57);
            btnRegEnc.TabIndex = 3;
            btnRegEnc.Text = "Registrar encomenda";
            btnRegEnc.UseVisualStyleBackColor = false;
            btnRegEnc.Click += btnRegEnc_Click;
            // 
            // btnRegCon
            // 
            btnRegCon.BackColor = Color.Yellow;
            btnRegCon.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegCon.Location = new Point(1448, 859);
            btnRegCon.Name = "btnRegCon";
            btnRegCon.Size = new Size(322, 57);
            btnRegCon.TabIndex = 4;
            btnRegCon.Text = "Registrar conclusão";
            btnRegCon.UseVisualStyleBackColor = false;
            btnRegCon.Click += btnRegCon_Click;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeCliente.Location = new Point(18, 757);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(312, 30);
            txtNomeCliente.TabIndex = 7;
            txtNomeCliente.TextChanged += txtNomeCliente_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 734);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 8;
            label1.Text = "Nome do(a) cliente";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 734);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 10;
            label2.Text = "Nome do produto";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeProduto.Location = new Point(344, 757);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(312, 30);
            txtNomeProduto.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 800);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 12;
            label3.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.Location = new Point(18, 823);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(1051, 30);
            txtDescricao.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(719, 734);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 14;
            label4.Text = "Valor (Ex: 19,12)";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValor.Location = new Point(719, 757);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(141, 30);
            txtValor.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(876, 734);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 16;
            label5.Text = "Prazo (Ex: 25/12/2024)";
            label5.Click += label5_Click;
            // 
            // txtPrazo
            // 
            txtPrazo.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrazo.Location = new Point(876, 757);
            txtPrazo.Name = "txtPrazo";
            txtPrazo.Size = new Size(193, 30);
            txtPrazo.TabIndex = 15;
            txtPrazo.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1448, 793);
            label6.Name = "label6";
            label6.Size = new Size(245, 20);
            label6.TabIndex = 18;
            label6.Text = "ID (Primeiro Numero de cada linha)";
            label6.Click += label6_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(1448, 814);
            txtID.Name = "txtID";
            txtID.Size = new Size(322, 30);
            txtID.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 924);
            label7.Name = "label7";
            label7.Size = new Size(605, 20);
            label7.TabIndex = 19;
            label7.Text = "©2024 Guilherme P. Moreira. Licença Padrão do MIT (Visualizar código aberto no GitHub).";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(689, 757);
            label8.Name = "label8";
            label8.Size = new Size(35, 28);
            label8.TabIndex = 20;
            label8.Text = "R$";
            label8.Click += label8_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1601, 924);
            label11.Name = "label11";
            label11.Size = new Size(169, 20);
            label11.TabIndex = 21;
            label11.Text = "Versão: 0.8 (24/02/2024)";
            label11.Click += label11_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(1075, 859);
            label23.Name = "label23";
            label23.Size = new Size(191, 40);
            label23.TabIndex = 22;
            label23.Text = "AVISO:\r\nID criado automaticamente\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(1782, 953);
            Controls.Add(label23);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(txtPrazo);
            Controls.Add(label4);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(txtNomeProduto);
            Controls.Add(label1);
            Controls.Add(txtNomeCliente);
            Controls.Add(btnRegCon);
            Controls.Add(btnRegEnc);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Artesanato - ROSAMORA";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private TextBox txtPedidos;
        private Button btnRegEnc;
        private Button btnRegCon;
        private TextBox txtEntregas;
        private TextBox txtNomeCliente;
        private Label label1;
        private Label label2;
        private TextBox txtNomeProduto;
        private Label label3;
        private TextBox txtDescricao;
        private Label label4;
        private TextBox txtValor;
        private Label label5;
        private TextBox txtPrazo;
        private Label label6;
        private TextBox txtID;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label16;
        private Label label22;
        private Label label10;
        private Label label17;
        private Label label18;
        private Label label21;
        private Label label19;
        private Label label20;
        private Label label23;
    }
}
