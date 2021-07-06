using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaBebidas
{
    public partial class Window_maquina_bebidas : Form
    {
        static List<Bebida> bebidas;
        static List<Venda> vendas;
        static int VendaId = 0;
        static double Dinheiro;
        static double Troco;
       
        public Window_maquina_bebidas()
        {
            
            vendas = new List<Venda>();
            bebidas = new List<Bebida>();

            //Criando as bebidas
            bebidas.Add(new Bebida("Água", 1.50, 0));
            bebidas.Add(new Bebida("Coca-Cola", 3.50, 0));
            bebidas.Add(new Bebida("Guaraná", 2.75, 0));
            bebidas.Add(new Bebida("Pepsi", 3.00, 0));
            bebidas.Add(new Bebida("Soda", 2.25, 0));

            InitializeComponent();
        }

        public void RealizarVenda(string bebida,Label labelEstoque) 
        {
            //Função para realizar Venda
            bool ComEstoque = false;
            bool ComDinheiro = false;
            foreach (Bebida b in bebidas)
            {
                if (b.Descricao == bebida && b.Estoque > 0)
                {
                    ComEstoque = true;
                }
                if (b.Descricao == bebida && Dinheiro >= b.Valor)
                {
                    ComDinheiro = true;
                }
                if (b.Descricao == bebida && ComDinheiro && ComEstoque)
                {
                    b.Estoque = b.Estoque - 1;
                    Troco = Dinheiro - b.Valor;
                    Dinheiro = Dinheiro - b.Valor;
                    labelEstoque.Text = b.Estoque.ToString();
                    lb_Troco.Text = Troco.ToString("C");
                    VendaId += 1;
                    vendas.Add(new Venda(VendaId, b.Descricao, b.Valor));
                    Variaveis_Globais.Instance.ListaVendas = vendas;
                }
                if (!ComDinheiro && b.Descricao == bebida)
                {
                    double Faltante = b.Valor - Dinheiro;
                    lb_Dinheiro.Text = Dinheiro.ToString("C");
                    lb_Troco.Text = "R$ 0,00";
                    MessageBox.Show("Saldo Insuficiente! Insira:" + Faltante.ToString("C"), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (!ComEstoque)
            {
                MessageBox.Show("Estoque indisponivel!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_Zerar_Estoque_Click(object sender, EventArgs e)
        {
            //Zera Estoque
            foreach (Bebida b in bebidas)
            {
                b.Estoque = 0;
                if (b.Descricao == "Água") lb_Estoque_Agua.Text = (b.Estoque).ToString();
                if (b.Descricao == "Coca-Cola") lb_Estoque_CocaCola.Text = (b.Estoque).ToString();
                if (b.Descricao == "Guaraná") lb_Estoque_Guarana.Text = (b.Estoque).ToString();
                if (b.Descricao == "Pepsi") lb_Estoque_Pepsi.Text = (b.Estoque).ToString();
                if (b.Descricao == "Soda") lb_Estoque_Soda.Text = (b.Estoque).ToString();
            }
        }

        private void btb_Abastecer_Estoque_Click(object sender, EventArgs e)
        {
            //Abastecer Estoque
            foreach (Bebida b in bebidas)
            {
                b.Estoque = b.Estoque + 10;
                if (b.Descricao == "Água") lb_Estoque_Agua.Text = (b.Estoque).ToString();
                if (b.Descricao == "Coca-Cola") lb_Estoque_CocaCola.Text = (b.Estoque).ToString();
                if (b.Descricao == "Guaraná") lb_Estoque_Guarana.Text = (b.Estoque).ToString();
                if (b.Descricao == "Pepsi") lb_Estoque_Pepsi.Text = (b.Estoque).ToString();
                if (b.Descricao == "Soda") lb_Estoque_Soda.Text = (b.Estoque).ToString();
            }

        }

        private void btn_Zerar_Click(object sender, EventArgs e)
        {
            //OU btn Nova Venda
            Dinheiro = 0;
            Troco = 0;
            lb_Dinheiro.Text = "R$ 0,00";
            lb_Troco.Text = "R$ 0,00";
        }

        private void btn_VinteCincoCentavos_Click(object sender, EventArgs e)
        {
            Dinheiro += 0.25;
            lb_Dinheiro.Text = (Dinheiro).ToString("C");
        }

        private void btn_CinquentaCentavos_Click(object sender, EventArgs e)
        {
            Dinheiro += 0.50;
            lb_Dinheiro.Text = (Dinheiro).ToString("C");
        }

        private void btn_UmReal_Click(object sender, EventArgs e)
        {
            Dinheiro += 1.00;
            lb_Dinheiro.Text = (Dinheiro).ToString("C");
        }

        private void btn_Comprar_Agua_Click(object sender, EventArgs e)
        {
            RealizarVenda("Água",lb_Estoque_Agua);
        }

        private void btn_Comprar_Guarana_Click(object sender, EventArgs e)
        {
           RealizarVenda("Guaraná",lb_Estoque_Guarana);
        }
        private void btn_Comprar_Pepsi_Click(object sender, EventArgs e)
        {
            RealizarVenda("Pepsi",lb_Estoque_Pepsi);
        }

        private void btn_Comprar_Soda_Click(object sender, EventArgs e)
        {
            RealizarVenda("Soda",lb_Estoque_Soda);
        }

        private void btn_Comprar_CocaCola_Click(object sender, EventArgs e)
        {
            RealizarVenda("Coca-Cola",lb_Estoque_CocaCola);
        }

        private void btn_Vendas_Realizadas_Click(object sender, EventArgs e)
        {
            if (vendas.Count > 0){
                Window_Vendas Wvenda = new Window_Vendas();
                Wvenda.Show();
            }
            else{
                MessageBox.Show("Nenhma Venda Realizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }
}
