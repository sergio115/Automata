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
        int fila;
        string lexema;
        string granema;
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
            dataGridView1.Rows.Clear();

            EstadoInicial();
            label1.Text = "El estado es: " + aprobado.ToString();
        }

        public void EstadoInicial() {
            contador = 0;
            while (contador < textBox1.Text.Length) {
                for (int i = 0; i < letrasMinnusculas.Length; i++) {
                    if (charsRead[contador] == letrasMinnusculas[i] || charsRead[contador] == letrasMayusculas[i]) {
                        lexema += charsRead[contador].ToString();
                        contador++;
                        Estado1();
                        lexema = null;  // Permite mostrar la palabra bien
                        break;
                    }
                }
                if (contador < textBox1.Text.Length) {
                    for (int i = 0; i < numeros.Length; i++) {
                        if (charsRead[contador] == numeros[i]) {
                            lexema += charsRead[contador].ToString();
                            contador++;
                            Estado3();
                            lexema = null;
                            break;
                        }
                    }
                }
                if ((contador < textBox1.Text.Length) && (charsRead[contador] == '"')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado6();
                    lexema = null;
                }
                if ((contador < textBox1.Text.Length) && (charsRead[contador] == ' ')) {
                    contador++;
                    Estado110();
                    lexema = null;  // Permite mostrar la palabra bien
                } else {
                    // Hay que modificarlo para que funcione y detecte por ejemplo identificadores despues de numeros
                    contador++;
                }
            }
        }

        #region Estados de Transición
        #region Identificadores
        public void Estado1() {
            if (contador < textBox1.Text.Length) {
                for (int i = 0; i < numeros.Length; i++) {
                    if (charsRead[contador] == numeros[i]) {
                        lexema += charsRead[contador].ToString();
                        contador++;
                        Estado1();
                        return;
                    }
                }
                for (int i = 0; i < letrasMinnusculas.Length; i++) {
                    if (charsRead[contador] == letrasMinnusculas[i] || charsRead[contador] == letrasMayusculas[i]) {
                        lexema += charsRead[contador].ToString();
                        contador++;
                        Estado1();
                        return;
                    }
                }
                if (charsRead[contador] == '_') {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado2();
                } else {
                    lexema += charsRead[contador].ToString();
                    //contador++;
                    Estado100();
                }
            }
        }

        public void Estado2() {
            for (int i = 0; i < numeros.Length; i++) {
                if ((contador < textBox1.Text.Length) && (charsRead[contador] == numeros[i])) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado1();
                    return;
                }
            }
            for (int i = 0; i < letrasMinnusculas.Length; i++) {
                if (contador < textBox1.Text.Length) {
                    if (charsRead[contador] == letrasMinnusculas[i] || charsRead[contador] == letrasMayusculas[i]) {
                        lexema += charsRead[contador].ToString();
                        contador++;
                        Estado1();
                        return;
                    }
                }
            }
            if (contador < textBox1.Text.Length) {
                lexema += charsRead[contador].ToString();
                //contador++;
                Estado501();
            }
        }
        #endregion

        #region Números
        public void Estado3() {
            if (contador < textBox1.Text.Length) {
                for (int i = 0; i < numeros.Length; i++) {
                    if (charsRead[contador] == numeros[i]) {
                        lexema += charsRead[contador].ToString();
                        contador++;
                        Estado3();
                        return;
                    }
                }
                if (charsRead[contador] == '.') {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado4();
                } else {
                    lexema += charsRead[contador].ToString();
                    Estado101();
                }
            }
        }

        public void Estado4() {
            if (contador < textBox1.Text.Length) {
                for (int i = 0; i < numeros.Length; i++) {
                    if (charsRead[contador] == numeros[i]) {
                        lexema += charsRead[contador].ToString();
                        contador++;
                        Estado5();
                        return;
                    }
                }

                lexema += charsRead[contador].ToString();
                Estado500();
            }
        }

        public void Estado5() {
            for (int i = 0; i < numeros.Length; i++) {
                if ((contador < textBox1.Text.Length) && (charsRead[contador] == numeros[i])) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado5();
                    return;
                }
            }
            if (contador < textBox1.Text.Length) {
                lexema += charsRead[contador].ToString();
                //contador++;
                Estado102();
            }
        }
        #endregion

        #region Letreros
        public void Estado6() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '"')) {
                lexema += charsRead[contador].ToString();
                contador++;
                Estado7();
            } else if (contador < textBox1.Text.Length) {
                lexema += charsRead[contador].ToString();
                contador++;
                Estado6();
            }
        }

        public void Estado7() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '"')) {
                lexema += charsRead[contador].ToString();
                contador++;
                Estado6();
                return;
            } else if (contador < textBox1.Text.Length) {
                lexema += charsRead[contador].ToString();
                Estado103();
            }
        }
        #endregion

        #region Estados que aún no funcionan
        public void Estado8()
        {
            
        }

        public void Estado9()
        {
            
        }

        public void Estado10()
        {
            
        }

        public void Estado11()
        {
            
        }

        public void Estado12()
        {
            
        }

        public void Estado13()
        {
            
        }

        public void Estado14()
        {

        }

        public void Estado15()
        {
            
        }

        public void Estado16()
        {
         
        }

        public void Estado17()
        {
            
        }
        #endregion
        #endregion

        #region Estados de Aceptación
        public void Estado100() {
            fila = dataGridView1.Rows.Add();
            aprobado = true;
            granema = "IDENTIFICADOR";
            dataGridView1.Rows[fila].Cells[2].Value = lexema.Substring(0, lexema.Length-1);
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;  // Limpia el buffer
            //return;
        }

        public void Estado101() {
            fila = dataGridView1.Rows.Add();
            aprobado = true;
            granema = "NÚMERO ENTERO";
            dataGridView1.Rows[fila].Cells[2].Value = lexema.Substring(0, lexema.Length - 1);
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado102() {
            fila = dataGridView1.Rows.Add();
            granema = "NÚMERO REAL";
            dataGridView1.Rows[fila].Cells[2].Value = lexema.Substring(0, lexema.Length - 1);
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado103() {
            fila = dataGridView1.Rows.Add();
            granema = "LETRERO";
            dataGridView1.Rows[fila].Cells[2].Value = lexema.Substring(0, lexema.Length - 1);
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado110() {
            fila = dataGridView1.Rows.Add();
            aprobado = true;
            lexema = "' '";
            granema = "ESPACIO";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            //return;
        }
        #endregion

        #region Estados de Error
        public void Estado500() {
            fila = dataGridView1.Rows.Add();
            granema = "ERROR 500";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado501() {
            fila = dataGridView1.Rows.Add();
            aprobado = false;
            granema = "ERROR 501";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
            //return;
        }
        #endregion
    }
}
