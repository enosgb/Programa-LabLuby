
namespace MaquinaBebidas
{
    partial class Window_vendas
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
            this.lv_vendas = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bebida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_vendas
            // 
            this.lv_vendas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Bebida,
            this.Valor});
            this.lv_vendas.HideSelection = false;
            this.lv_vendas.Location = new System.Drawing.Point(35, 12);
            this.lv_vendas.Name = "lv_vendas";
            this.lv_vendas.Size = new System.Drawing.Size(148, 153);
            this.lv_vendas.TabIndex = 1;
            this.lv_vendas.UseCompatibleStateImageBehavior = false;
            this.lv_vendas.SelectedIndexChanged += new System.EventHandler(this.lv_vendas_SelectedIndexChanged);
            // 
            // window_vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 364);
            this.Controls.Add(this.lv_vendas);
            this.Name = "window_vendas";
            this.Text = "Vendas";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lv_vendas;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Bebida;
        private System.Windows.Forms.ColumnHeader Valor;
    }
}