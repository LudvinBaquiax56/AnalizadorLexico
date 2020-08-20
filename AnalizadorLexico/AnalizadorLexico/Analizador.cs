using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    class Analizador
    {
        Regex textoRx;
        Regex numero;
        Regex noDecimal;
        Regex dinero;
        public Analizador()
        {
            textoRx = new Regex("^[a-zA-Z]+$");
            numero = new Regex("^[0-9]+$");
            noDecimal = new Regex("^[0-9]+(.[0-9]+)$");
            dinero = new Regex("^Q[0-9]+.[0-9]*$");
        }

        /**
         * Analiza una oraccion, recibe una DataGridView y carga el tipo de cada palara en el Data Grid
         */
        public void analizar(String textoCompleto, DataGridView data )
        {
            String[] separador = {" "};
            String[] palabrasSeparadas = textoCompleto.Split(separador,StringSplitOptions.RemoveEmptyEntries);
            for ( int i = 0 ; i < palabrasSeparadas.Length ;i++)
            {
                int n = data.Rows.Add();
                data.Rows[n].Cells[0].Value = palabrasSeparadas[i];
                data.Rows[n].Cells[1].Value = this.analizarPalabra(palabrasSeparadas[i]);
            }
        }
        
        /**
         * Analiza una palabra y retorna un String con su tipo
         */
        public String analizarPalabra(String texto)
        {
            if (textoRx.IsMatch(texto))
            {
                return "Texto";
            }
            else if (numero.IsMatch(texto))
            {
                return "Numero";
            }
            else if (noDecimal.IsMatch(texto))
            {
                return "Decimal";
            }
            else if (dinero.IsMatch(texto))
            {
                return "Moneda  ";
            }
            else
            {
                return "Invalido";
            }
        }
    }
}
