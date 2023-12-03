
namespace practica_parcial1
{
    partial class FPedido
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
            this.tBnombreCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBxenvio = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBdistancia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Cliente:";
            // 
            // tBnombreCliente
            // 
            this.tBnombreCliente.Location = new System.Drawing.Point(32, 67);
            this.tBnombreCliente.Name = "tBnombreCliente";
            this.tBnombreCliente.Size = new System.Drawing.Size(201, 22);
            this.tBnombreCliente.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBxenvio);
            this.groupBox1.Location = new System.Drawing.Point(32, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Con Envio?";
            // 
            // cBxenvio
            // 
            this.cBxenvio.AutoSize = true;
            this.cBxenvio.Location = new System.Drawing.Point(3, 18);
            this.cBxenvio.Name = "cBxenvio";
            this.cBxenvio.Size = new System.Drawing.Size(18, 17);
            this.cBxenvio.TabIndex = 0;
            this.cBxenvio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBdistancia);
            this.groupBox2.Location = new System.Drawing.Point(261, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Distancia En Km:";
            // 
            // tBdistancia
            // 
            this.tBdistancia.Location = new System.Drawing.Point(3, 18);
            this.tBdistancia.Name = "tBdistancia";
            this.tBdistancia.Size = new System.Drawing.Size(100, 22);
            this.tBdistancia.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(158, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(261, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 354);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tBnombreCliente);
            this.Controls.Add(this.label1);
            this.Name = "FPedido";
            this.Text = "FPedido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tBnombreCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox cBxenvio;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox tBdistancia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}