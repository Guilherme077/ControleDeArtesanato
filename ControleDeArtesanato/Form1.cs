namespace ControleDeArtesanato
{
    public partial class Form1 : Form
    {
        Arquivo pedidos = new Arquivo("Pedidos");
        Arquivo entregas = new Arquivo("Entregas");
        public Form1()
        {
            InitializeComponent();

        }

        private void txtPedidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarPropiedades();
        }


        public void RegistraPedido()
        {

            string[] data = txtPrazo.Text.Split('/');
            int dia = int.Parse(data[0]);
            int mes = int.Parse(data[1]);
            int ano = int.Parse(data[2]);

            pedidos.AddLinha(new Pedido(txtNomeCliente.Text, txtNomeProduto.Text, txtDescricao.Text, double.Parse(txtValor.Text), DateTime.Now.Date, new DateTime(ano, mes, dia)).ToString());


        }

        public void ConcluiPedido()
        {
            string prodId = txtID.Text;
            int localizacao = pedidos.GetLinha().IndexOf(prodId);
            if (localizacao != -1)
            {
                string[] textofiltrado = pedidos.GetLinha().Substring(localizacao).Split("     ");
                string id = textofiltrado[0];
                string nomeCli = textofiltrado[1];
                string nomeProd = textofiltrado[2];
                string desc = textofiltrado[3];
                double val = double.Parse(textofiltrado[4]);
                DateTime dtEnc = DateTime.Parse(textofiltrado[5]);
                DateTime dtPrev = DateTime.Parse(textofiltrado[6]);
                DateTime dtEntrega = DateTime.Now;
                DialogResult resp = MessageBox.Show("Deseja mesmo concluir o pedido: \n Cliente: " + nomeCli + "\n Produto: " + nomeProd + "\n Descri��o: " + desc + "\n Valor: R$" + val.ToString() + "\n E envia-lo para a lista de entregas?", "Conforma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    try
                    {
                        entregas.AddLinha(new Pedido(id, nomeCli, nomeProd, desc, val, dtEnc, dtPrev, dtEntrega).ToString());
                        pedidos.RemoveLinha("     " + id + "     " + nomeCli + "     " + nomeProd + "     " + desc + "     " + val.ToString() + "     " + dtEnc.ToString("dd/MM/yyyy") + "     " + dtPrev.ToString("dd/MM/yyyy"));
                        MessageBox.Show("O pedido foi conclu�do e enviado a lista de entregues", "Concluido com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch { MessageBox.Show("Um erro interno ocorreu (entregas.AddLinha)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }


                }
            }
            else
            {
                MessageBox.Show("ID n�o encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegEnc_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text.Length <= 30 && txtNomeProduto.Text.Length <= 30 && txtDescricao.Text.Length <= 50 && txtValor.Text.Length <= 9 && txtPrazo.Text.Length <= 12)
            {
                try
                {
                    RegistraPedido();
                    atualizarPropiedades();
                    MessageBox.Show("O Pedido foi registrado com sucesso e adicionado a lista de pedidos.", "Registrado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Houve um erro na execu��o (RegistraPedido).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Numero m�ximo de caracteres n�o respeitado em alguma propiedade!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegCon_Click(object sender, EventArgs e)
        {
            ConcluiPedido();
            atualizarPropiedades();

        }

        private void btnCancelEnc_Click(object sender, EventArgs e)
        {

        }
        private void atualizarPropiedades()
        {
            try
            {
                string texto = pedidos.GetLinha().Trim();
                string texto2 = entregas.GetLinha().Trim();
                string[] textped = texto.Split("     ");
                string[] textEnt = texto2.Split("     ");
                string novoPed = "";
                string novoEnt = "";
                int item = 0; // 0 at� 6
                foreach (string ped in textped)
                {

                    int nesp = 0;
                    novoPed += ped;
                    switch (item)
                    {
                        case 0: nesp = 12; break; //ID
                        case 1: nesp = 30; break; //Cliente
                        case 2: nesp = 30; break; // Produto
                        case 3: nesp = 50; break; // Desc
                        case 4: nesp = 9; break; // Valor
                        case 5: nesp = 12; break; // Data
                        case 6: nesp = 12; break; // Data
                        default: nesp = 12; break;
                    }
                    for (int i = 0; i < (nesp - ped.Length); i++)
                    {
                        novoPed += " ";
                    }

                    if (item >= 6)
                    {

                        item = 0;
                    }
                    else
                    {
                        item++;
                    }


                }

                int itemEnt = 0; // 0 at� 7
                foreach (string ent in textEnt)
                {

                    int nesp = 0;
                    novoEnt += ent;
                    switch (itemEnt)
                    {
                        case 0: nesp = 12; break; //ID
                        case 1: nesp = 30; break; //Cliente
                        case 2: nesp = 30; break; // Produto
                        case 3: nesp = 50; break; // Desc
                        case 4: nesp = 9; break; // Valor
                        case 5: nesp = 12; break; // Data
                        case 6: nesp = 12; break; // Data
                        case 7: nesp = 12; break; // Data
                        default: nesp = 12; break;
                    }
                    for (int i = 0; i < (nesp - ent.Length); i++)
                    {
                        novoEnt += " ";
                    }

                    if (itemEnt >= 7)
                    {

                        itemEnt = 0;
                    }
                    else
                    {
                        itemEnt++;
                    }


                }
                txtPedidos.Text = novoPed;
                txtEntregas.Text = novoEnt;
            }
            catch
            {
                MessageBox.Show("Houve um erro na execu��o (AtualizarPropiedade). \n\n ATEN��O: A a��o foi executada, mas n�o aparece no programa \n\n Reinicie o programa, se o problema persistir, chame o suporte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label11.Text + "\n \n �2024 Guilherme P. Moreira. \n Feito para: Rosangela. \n\n guilhermepmoreira.com\ngui@guilhermepmoreira.com", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
