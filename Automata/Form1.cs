using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automata
{
    public partial class Form1 : Form
    {
        int contador;
        char[] charsRead;
        bool aprobado;
        char[] letrasMinnusculas = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ',
                                    'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] letrasMayusculas = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ',
                                    'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            charsRead = new char[textBox1.Text.Length];
            charsRead = textBox1.Text.ToCharArray();

            EstadoInicial();
            label1.Text = "El estado es: " + aprobado.ToString();
        }

        public void EstadoInicial()
        {
            contador = 0;
            Estado1();
        }

        public void Estado1()
        {
            if (contador < textBox1.Text.Length)
            {
                if (charsRead[contador] == 'a')
                {
                    contador++;
                    Estado1();
                } else if (charsRead[contador] == 'b')
                {
                    contador++;
                    Estado2();
                }
            }
        }

        public void Estado2()
        {
            if (contador < textBox1.Text.Length)
            {
                if (charsRead[contador] == 'a')
                {
                    contador++;
                    Estado2();
                }
                else if (charsRead[contador] == 'b')
                {
                    contador++;
                    Estado3();
                }
            }
        }

        public void Estado3()
        {
            if (contador < textBox1.Text.Length)
            {
                if (charsRead[contador] == 'a')
                {
                    contador++;
                    Estado3();
                }
                else if (charsRead[contador] == 'b')
                {
                    contador++;
                    Estado4();
                }
            }
        }

        public void Estado4()
        {
            aprobado = true;

            if (contador < textBox1.Text.Length)
            {
                if (charsRead[contador] == 'a')
                {
                    contador++;
                    Estado4();
                }
                else if (charsRead[contador] == 'b')
                {
                    contador++;
                    EstadoError();
                }
            }
        }

        public void EstadoError()
        {
            aprobado = false;
            return;
        }
    }
}
