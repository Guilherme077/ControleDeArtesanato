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
            int localizacao = txtPedidos.Text.IndexOf(prodId);
            if (localizacao != -1)
            {
                string[] textofiltrado = txtPedidos.Text.Substring(localizacao).Split("     ");
                string id = textofiltrado[0];
                string nomeCli = textofiltrado[1];
                string nomeProd = textofiltrado[2];
                string desc = textofiltrado[3];
                double val = double.Parse(textofiltrado[4]);
                DateTime dtEnc = DateTime.Parse(textofiltrado[5]);
                DateTime dtPrev = DateTime.Parse(textofiltrado[6]);
                DateTime dtEntrega = DateTime.Now;
                DialogResult resp = MessageBox.Show("Deseja mesmo concluir o pedido: \n Cliente: " + nomeCli + "\n Produto: " + nomeProd + "\n Descrição: " + desc + "\n Valor: R$" + val.ToString() + "\n E envia-lo para a lista de entregas?", "Conformação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    try
                    {
                        entregas.AddLinha(new Pedido(id, nomeCli, nomeProd, desc, val, dtEnc, dtPrev, dtEntrega).ToString());
                        pedidos.RemoveLinha(id + "     " + nomeCli + "     " + nomeProd + "    " + desc + "    " + val.ToString() + "    " + dtEnc.ToString("dd/MM/yyyy") + "    " + dtPrev.ToString("dd/MM/yyyy"));
                        MessageBox.Show("O pedido foi concluído e enviado a lista de entregues", "Concluido com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch { MessageBox.Show("Um erro interno ocorreu (entregas.AddLinha)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }


                }
            }
            else
            {
                MessageBox.Show("ID não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                RegistraPedido();
                atualizarPropiedades();
                MessageBox.Show("O Pedido foi registrado com sucesso e adicionado a lista de pedidos.", "Registrado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Houve um erro na execução (RegistraPedido).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtPedidos.Text = pedidos.GetLinha();
                txtEntregas.Text = entregas.GetLinha();
            }
            catch
            {
                MessageBox.Show("Houve um erro na execução (AtualizarPropiedade). \n\n ATENÇÃO: A ação foi executada, mas não aparece no programa \n\n Reinicie o programa, se o problema persistir, chame o suporte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MessageBox.Show(label11.Text + "\n \n ©2024 Guilherme P. Moreira. \n Feito para: Rosangela. \n\n guilhermepmoreira.com\ngui@guilhermepmoreira.com", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
