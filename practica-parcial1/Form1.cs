using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_parcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Rotiseria nuevaR = new Rotiseria();
        Pedido nuevoP;
        int numPedido = 0;
        private void btnTomarPedido_Click(object sender, EventArgs e)
        {
            FPedido pedidoNuevo = new FPedido();
            if(pedidoNuevo.ShowDialog()== DialogResult.OK)
            {
                numPedido++;
                string cliente = pedidoNuevo.tBnombreCliente.Text;
                bool envio = pedidoNuevo.cBxenvio.Checked;

                if (!envio)
                {
                    nuevoP = new Pedido(numPedido, cliente);
                }
                else
                {
                    double distancia = Convert.ToDouble(pedidoNuevo.tBdistancia.Text);
                    nuevoP = new Delivery(numPedido, cliente, distancia);

                }
                nuevaR.AgregarPedido(nuevoP);
            }

        }

        private void btnAgregarMenu_Click(object sender, EventArgs e)
        {
            string pedido = cBxPedido.SelectedItem.ToString();
            int indiceP = cBxPedido.SelectedIndex;
            int cantidad = Convert.ToInt32(tBcantidad.Text);
            ItemMenu nuevoM = new ItemMenu(pedido);
            if (indiceP == 0)
            {
                nuevoP.PrecioProd = 2000;
            }
            else
            {
                nuevoP.PrecioProd = 850;
            }
            nuevoP.AgregarItem(nuevoM, cantidad);
            lBpedido.Items.Add("Informacion del pedido: " + nuevoM.Descripcion());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Precio Final del pedido: " + nuevoP.Precio().ToString("00.0"));
            lBpedido.Items.Clear();
            lBlistaPedidos.Items.Add(" " + numPedido + " " + nuevoP.Cliente);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
