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
    public partial class window_maquina_bebidas : Form
    {
        static List<Bebida> bebidas;

        public window_maquina_bebidas()
        {
            InitializeComponent();
        }

        private void btn_Zerar_Estoque_Click(object sender, EventArgs e)
        {
            
            lb_Estoque_Agua.Text = "0";
            lb_Estoque_CocaCola.Text = "0";
            lb_Estoque_Guarana.Text = "0";
            lb_Estoque_Pepsi.Text = "0";
            lb_Estoque_Soda.Text = "0";
        }

        private void btb_Abastecer_Estoque_Click(object sender, EventArgs e)
        {

            List<Bebida> bebidas = new List<Bebida>();
            bebidas.Add(new Bebida("Água",3.50, Int32.Parse(lb_Estoque_Agua.Text) + 10));

            //lb_Estoque_Agua.Text = ().ToString();

            

            MessageBox.Show(string.Format("{0} {1} {2}",b.descricao,b.valor,b.estoque));

            lb_Estoque_CocaCola.Text = (Int32.Parse(lb_Estoque_CocaCola.Text) + 10).ToString();
            lb_Estoque_Guarana.Text = (Int32.Parse(lb_Estoque_Guarana.Text) + 10).ToString();
            lb_Estoque_Pepsi.Text = (Int32.Parse(lb_Estoque_Pepsi.Text) + 10).ToString();
            lb_Estoque_Soda.Text = (Int32.Parse(lb_Estoque_Soda.Text) + 10).ToString();

        }

        private void btn_Zerar_Click(object sender, EventArgs e)
        {
            lb_Dinheiro.Text = "R$ 0,00";
            lb_Troco.Text = "R$ 0,00";
        }

        private void btn_VinteCincoCentavos_Click(object sender, EventArgs e)
        {
            lb_Dinheiro.Text = (double.Parse(lb_Dinheiro.Text.Remove(0,3))+0.25).ToString("C");
        }

        private void btn_SetentaCincoCentavos_Click(object sender, EventArgs e)
        {
            lb_Dinheiro.Text = (double.Parse(lb_Dinheiro.Text.Remove(0, 3)) + 0.50).ToString("C");
        }

        private void btn_UmReal_Click(object sender, EventArgs e)
        {
            lb_Dinheiro.Text = (double.Parse(lb_Dinheiro.Text.Remove(0, 3)) + 1).ToString("C");
        }

        private void btn_Comprar_Agua_Click(object sender, EventArgs e)
        {

        }
    }
}
