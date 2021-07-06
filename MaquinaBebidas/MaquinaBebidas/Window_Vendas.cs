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
    public partial class Window_Vendas : Form
    {

        public Window_Vendas()
        {
            InitializeComponent();

            double TotalVendas = 0;
            int NumeroVendas = 0;

            //Criando e Personalizando ListView
            ListView lv_vendas = new ListView();
            lv_vendas.Bounds = new Rectangle(new Point(10, 10), new Size(265, 250));
            lv_vendas.View = View.Details;
            lv_vendas.LabelEdit = false;
            lv_vendas.AllowColumnReorder = true;
            lv_vendas.CheckBoxes = false;
            lv_vendas.GridLines = true;
            //Colunas ListView
            lv_vendas.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lv_vendas.Columns.Add("Bebida", -2, HorizontalAlignment.Left);
            lv_vendas.Columns.Add("Valor", -2, HorizontalAlignment.Left);

            //Adicionando Itens ao ListView
            foreach (Venda v in Variaveis_Globais.Instance.ListaVendas)
            {
                ListViewItem item1 = new ListViewItem(v.VendaId.ToString(), 0);
                item1.SubItems.Add(v.VendaItem);
                item1.SubItems.Add(v.VendaValor.ToString("C"));
                lv_vendas.Items.AddRange(new ListViewItem[] { item1 });
                TotalVendas += v.VendaValor;
                NumeroVendas += 1;
                lb_Total_Vendas.Text = TotalVendas.ToString("C");
                lb_Numero_Vendas.Text = (NumeroVendas).ToString();
            }

            this.Controls.Add(lv_vendas);

        }

        private void btn_Fechar_Lista_Vendas_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
