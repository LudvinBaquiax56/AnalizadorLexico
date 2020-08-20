using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
       public partial class Ventana : System.Windows.Forms.Form
        {

        Analizador analizador = new Analizador();
        public Ventana()
        {
            InitializeComponent();
        }

        public void textoIngresado()
        {
            
        }
        
        //Envia el texto y lo analiza
        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            dtgvResultado.Rows.Clear();
            if (txtTexto.Text != "")
            {
                String textoIngresado = txtTexto.Text;
                analizador.analizar(textoIngresado,dtgvResultado);
            }
            else
            {
                MessageBox.Show("Error no se ha ingresado ningun texto");
            }
            txtTexto.Text = "";   
        }

    }
}
