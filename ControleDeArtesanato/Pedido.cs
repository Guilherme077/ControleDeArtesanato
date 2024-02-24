using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeArtesanato
{
    internal class Pedido
    {
        string ID;
        string NomeCliente, NomeProduto, Descricao;
        double Valor;
        DateTime DataEncomenda, DataEntregaPrevisao;
        DateTime DataEntrega = new DateTime(2023,1,1);
        public Pedido(string nomeCliente, string nomeProduto, string descricao, double valor, DateTime dataEncomenda, DateTime dataEntregaPrevisao) {
            ID = (DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Day.ToString() + (int.Parse(DateTime.Now.Year.ToString()) - 2000).ToString());
            NomeCliente = nomeCliente;
            NomeProduto = nomeProduto;
            Descricao = descricao;
            Valor = valor;
            DataEncomenda = dataEncomenda;
            DataEntregaPrevisao = dataEntregaPrevisao;
            
        }
        public Pedido(string id, string nomeCliente, string nomeProduto, string descricao, double valor, DateTime dataEncomenda, DateTime dataEntregaPrevisao, DateTime dataEntrega)
        {
            ID = id;
            NomeCliente = nomeCliente;
            NomeProduto = nomeProduto;
            Descricao = descricao;
            Valor = valor;
            DataEncomenda = dataEncomenda;
            DataEntregaPrevisao = dataEntregaPrevisao;
            DataEntrega = dataEntrega;

        }
        public override string ToString()
        {
            if(DataEntrega != new DateTime(2023, 1, 1))
            {
                return ID + "     " + NomeCliente + "     " + NomeProduto + "     " + Descricao + "     " + Valor + "     " + DataEncomenda.ToString("dd/MM/yyyy") + "     " + DataEntregaPrevisao.ToString("dd/MM/yyyy") + "     " + DataEntrega.ToString("dd/MM/yyyy");

            }
            else
            {
                return ID + "     " + NomeCliente + "     " + NomeProduto + "     " + Descricao + "     " + Valor + "     " + DataEncomenda.ToString("dd/MM/yyyy") + "     " + DataEntregaPrevisao.ToString("dd/MM/yyyy");

            }
        }

    }
}
