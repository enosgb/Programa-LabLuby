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

            bebidas.Add(new Bebida("Água", 1.50, 0));
            bebidas.Add(new Bebida("Coca-Cola", 3.50, 0));
            bebidas.Add(new Bebida("Guaraná", 2.75, 0));
            bebidas.Add(new Bebida("Pepsi", 3.00, 0));
            bebidas.Add(new Bebida("Soda", 2.25, 0));

            InitializeComponent();
        }

        private void btn_Zerar_Estoque_Click(object sender, EventArgs e)
        {
            foreach (Bebida b in bebidas)
            {
                b.estoque = 0;
                if (b.descricao == "Água") lb_Estoque_Agua.Text = (b.estoque).ToString();
                if (b.descricao == "Coca-Cola") lb_Estoque_CocaCola.Text = (b.estoque).ToString();
                if (b.descricao == "Guaraná") lb_Estoque_Guarana.Text = (b.estoque).ToString();
                if (b.descricao == "Pepsi") lb_Estoque_Pepsi.Text = (b.estoque).ToString();
                if (b.descricao == "Soda") lb_Estoque_Soda.Text = (b.estoque).ToString();
            }
        }

        private void btb_Abastecer_Estoque_Click(object sender, EventArgs e)
        {

            foreach (Bebida b in bebidas)
            {
                b.estoque = b.estoque + 10;
                if (b.descricao == "Água") lb_Estoque_Agua.Text = (b.estoque).ToString();
                if (b.descricao == "Coca-Cola") lb_Estoque_CocaCola.Text = (b.estoque).ToString();
                if (b.descricao == "Guaraná") lb_Estoque_Guarana.Text = (b.estoque).ToString();
                if (b.descricao == "Pepsi") lb_Estoque_Pepsi.Text = (b.estoque).ToString();
                if (b.descricao == "Soda") lb_Estoque_Soda.Text = (b.estoque).ToString();
            }

        }

        private void btn_Zerar_Click(object sender, EventArgs e)
        {
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
            bool ComEstoque = false;
            bool ComDinheiro = false;
            foreach (Bebida b in bebidas)
            {
                if (b.descricao == "Água" && b.estoque > 0){
                    ComEstoque = true;
                }
                if (b.descricao == "Água" && Dinheiro >= b.valor){
                    ComDinheiro = true;
                }
                if (b.descricao == "Água" && ComDinheiro && ComEstoque){
                    b.estoque = b.estoque - 1;
                    Troco = Dinheiro - b.valor;
                    Dinheiro = Dinheiro - b.valor;
                    lb_Estoque_Agua.Text = b.estoque.ToString();
                    lb_Troco.Text = Troco.ToString("C");
                    VendaId += 1;
                    vendas.Add(new Venda(VendaId, b.descricao, b.valor));
                }
            }
            if (!ComEstoque) {
                    MessageBox.Show("Estoque indisponivel!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!ComDinheiro) {
                    MessageBox.Show("Saldo Insuficiente!","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_Comprar_Guarana_Click(object sender, EventArgs e)
        {

        }

        private void btn_Comprar_Pepsi_Click(object sender, EventArgs e)
        {

        }

        private void btn_Comprar_Soda_Click(object sender, EventArgs e)
        {

        }

        private void btn_Comprar_CocaCola_Click(object sender, EventArgs e)
        {

        }

        private void btn_Vendas_Realizadas_Click(object sender, EventArgs e)
        {
            Window_vendas Wvenda = new Window_vendas();
            Wvenda.Show();
        }
        
    }
}
