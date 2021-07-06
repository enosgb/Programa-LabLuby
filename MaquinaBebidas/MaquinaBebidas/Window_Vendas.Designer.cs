
namespace MaquinaBebidas
{
    partial class Window_Vendas
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Total_Vendas = new System.Windows.Forms.Label();
            this.btn_Fechar_Lista_Vendas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Numero_Vendas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Total:";
            // 
            // lb_Total_Vendas
            // 
            this.lb_Total_Vendas.AutoSize = true;
            this.lb_Total_Vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total_Vendas.ForeColor = System.Drawing.Color.Olive;
            this.lb_Total_Vendas.Location = new System.Drawing.Point(185, 283);
            this.lb_Total_Vendas.Name = "lb_Total_Vendas";
            this.lb_Total_Vendas.Size = new System.Drawing.Size(85, 25);
            this.lb_Total_Vendas.TabIndex = 1;
            this.lb_Total_Vendas.Text = "R$: 0,00";
            // 
            // btn_Fechar_Lista_Vendas
            // 
            this.btn_Fechar_Lista_Vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar_Lista_Vendas.Location = new System.Drawing.Point(17, 311);
            this.btn_Fechar_Lista_Vendas.Name = "btn_Fechar_Lista_Vendas";
            this.btn_Fechar_Lista_Vendas.Size = new System.Drawing.Size(253, 30);
            this.btn_Fechar_Lista_Vendas.TabIndex = 2;
            this.btn_Fechar_Lista_Vendas.Text = "Fechar";
            this.btn_Fechar_Lista_Vendas.UseVisualStyleBackColor = true;
            this.btn_Fechar_Lista_Vendas.Click += new System.EventHandler(this.btn_Fechar_Lista_Vendas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "N° de Vendas:";
            // 
            // lb_Numero_Vendas
            // 
            this.lb_Numero_Vendas.AutoSize = true;
            this.lb_Numero_Vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Numero_Vendas.Location = new System.Drawing.Point(223, 261);
            this.lb_Numero_Vendas.Name = "lb_Numero_Vendas";
            this.lb_Numero_Vendas.Size = new System.Drawing.Size(20, 22);
            this.lb_Numero_Vendas.TabIndex = 4;
            this.lb_Numero_Vendas.Text = "0";
            // 
            // Window_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.lb_Numero_Vendas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Fechar_Lista_Vendas);
            this.Controls.Add(this.lb_Total_Vendas);
            this.Controls.Add(this.label1);
            this.Name = "Window_Vendas";
            this.Text = "Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Total_Vendas;
        private System.Windows.Forms.Button btn_Fechar_Lista_Vendas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Numero_Vendas;
    }
}