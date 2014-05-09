namespace Reportes_A_Medida
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.btnExisPrecio = new System.Windows.Forms.Button();
            this.btnVentasVendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExisPrecio
            // 
            this.btnExisPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExisPrecio.Image = global::Reportes_A_Medida.Properties.Resources.report_icon;
            this.btnExisPrecio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExisPrecio.Location = new System.Drawing.Point(281, 231);
            this.btnExisPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExisPrecio.Name = "btnExisPrecio";
            this.btnExisPrecio.Size = new System.Drawing.Size(100, 100);
            this.btnExisPrecio.TabIndex = 0;
            this.btnExisPrecio.Text = "Existencias y precios de artículos";
            this.btnExisPrecio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExisPrecio.UseVisualStyleBackColor = true;
            this.btnExisPrecio.Click += new System.EventHandler(this.btnExisPrecio_Click);
            // 
            // btnVentasVendedor
            // 
            this.btnVentasVendedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVentasVendedor.Image = global::Reportes_A_Medida.Properties.Resources.report_icon;
            this.btnVentasVendedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVentasVendedor.Location = new System.Drawing.Point(403, 231);
            this.btnVentasVendedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVentasVendedor.Name = "btnVentasVendedor";
            this.btnVentasVendedor.Size = new System.Drawing.Size(100, 100);
            this.btnVentasVendedor.TabIndex = 1;
            this.btnVentasVendedor.Text = "Ventas por vendedor";
            this.btnVentasVendedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentasVendedor.UseVisualStyleBackColor = true;
            this.btnVentasVendedor.Click += new System.EventHandler(this.btnVentasVendedor_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnVentasVendedor);
            this.Controls.Add(this.btnExisPrecio);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Principal";
            this.Text = "Grupo Corrales - Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExisPrecio;
        private System.Windows.Forms.Button btnVentasVendedor;
    }
}

