
namespace practica_parcial1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTomarPedido = new System.Windows.Forms.Button();
            this.cBxPedido = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarMenu = new System.Windows.Forms.Button();
            this.tBcantidad = new System.Windows.Forms.TextBox();
            this.lBpedido = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lBlistaPedidos = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTomarPedido
            // 
            this.btnTomarPedido.Location = new System.Drawing.Point(15, 12);
            this.btnTomarPedido.Name = "btnTomarPedido";
            this.btnTomarPedido.Size = new System.Drawing.Size(729, 46);
            this.btnTomarPedido.TabIndex = 0;
            this.btnTomarPedido.Text = "Tomar Pedido";
            this.btnTomarPedido.UseVisualStyleBackColor = true;
            this.btnTomarPedido.Click += new System.EventHandler(this.btnTomarPedido_Click);
            // 
            // cBxPedido
            // 
            this.cBxPedido.FormattingEnabled = true;
            this.cBxPedido.Items.AddRange(new object[] {
            "Pizza Napolitana Especial",
            "Gaseosa de Litro"});
            this.cBxPedido.Location = new System.Drawing.Point(36, 92);
            this.cBxPedido.Name = "cBxPedido";
            this.cBxPedido.Size = new System.Drawing.Size(216, 24);
            this.cBxPedido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad:";
            // 
            // btnAgregarMenu
            // 
            this.btnAgregarMenu.Location = new System.Drawing.Point(347, 78);
            this.btnAgregarMenu.Name = "btnAgregarMenu";
            this.btnAgregarMenu.Size = new System.Drawing.Size(75, 50);
            this.btnAgregarMenu.TabIndex = 3;
            this.btnAgregarMenu.Text = "Agregar Menu";
            this.btnAgregarMenu.UseVisualStyleBackColor = true;
            this.btnAgregarMenu.Click += new System.EventHandler(this.btnAgregarMenu_Click);
            // 
            // tBcantidad
            // 
            this.tBcantidad.Location = new System.Drawing.Point(152, 136);
            this.tBcantidad.Name = "tBcantidad";
            this.tBcantidad.Size = new System.Drawing.Size(100, 22);
            this.tBcantidad.TabIndex = 4;
            // 
            // lBpedido
            // 
            this.lBpedido.FormattingEnabled = true;
            this.lBpedido.ItemHeight = 16;
            this.lBpedido.Location = new System.Drawing.Point(8, 191);
            this.lBpedido.Name = "lBpedido";
            this.lBpedido.Size = new System.Drawing.Size(776, 132);
            this.lBpedido.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(15, 355);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(729, 46);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar Pedido";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lBlistaPedidos
            // 
            this.lBlistaPedidos.FormattingEnabled = true;
            this.lBlistaPedidos.ItemHeight = 16;
            this.lBlistaPedidos.Location = new System.Drawing.Point(15, 416);
            this.lBlistaPedidos.Name = "lBlistaPedidos";
            this.lBlistaPedidos.Size = new System.Drawing.Size(769, 116);
            this.lBlistaPedidos.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(303, 564);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 32);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lBlistaPedidos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lBpedido);
            this.Controls.Add(this.tBcantidad);
            this.Controls.Add(this.btnAgregarMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBxPedido);
            this.Controls.Add(this.btnTomarPedido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTomarPedido;
        private System.Windows.Forms.ComboBox cBxPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarMenu;
        private System.Windows.Forms.TextBox tBcantidad;
        private System.Windows.Forms.ListBox lBpedido;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ListBox lBlistaPedidos;
        private System.Windows.Forms.Button btnSalir;
    }
}

