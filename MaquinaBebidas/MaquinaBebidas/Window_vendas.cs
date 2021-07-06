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
    public partial class Window_vendas : Form
    {
        
        public Window_vendas()
        {
           

            // Create a new ListView control.
            ListView lv_vendas = new ListView();
            lv_vendas.Bounds = new Rectangle(new Point(10, 10), new Size(200, 225));

            // Set the view to show details.
            lv_vendas.View = View.Details;
            // Allow the user to edit item text.
            lv_vendas.LabelEdit = false;
            // Allow the user to rearrange columns.
            lv_vendas.AllowColumnReorder = true;
            // Display check boxes.
            lv_vendas.CheckBoxes = false;
            // Select the item and subitems when selection is made.
            lv_vendas.FullRowSelect = true;
            // Display grid lines.
            lv_vendas.GridLines = true;
            // Sort the items in the list in ascending order.
            lv_vendas.Sorting = SortOrder.Ascending;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 0);
            // Place a check mark next to the item.
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            lv_vendas.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lv_vendas.Columns.Add("Bebida", -2, HorizontalAlignment.Left);
            lv_vendas.Columns.Add("Valor", -2, HorizontalAlignment.Left);


            //Add the items to the ListView.
            lv_vendas.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            // Add the ListView to the control collection.
            this.Controls.Add(lv_vendas);

        }

        private void lv_vendas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
