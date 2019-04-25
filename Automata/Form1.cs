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
        int fila;
        string lexema;
        string granema;
        char[] letrasMinnusculas = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ',
                                    'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'á', 'é', 'í', 'ó', 'ú'};
        char[] letrasMayusculas = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ',
                                    'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Á', 'É', 'Í', 'Ó', 'Ú' };
        char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            charsRead = textBox1.Text.ToCharArray();
            dataGridView1.Rows.Clear();

            EstadoInicial();
        }

        public void EstadoInicial() {
            contador = 0;

        Estado0:
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
                            //break;
                            goto Estado0;
                        }
                    }
                }
                if ((contador < textBox1.Text.Length) && (charsRead[contador] == '"')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado6();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == '/')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado8();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == '{')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado11();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == '=')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado12();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == '<')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado13();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == '>')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado14();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == '+')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado112();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == '-')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado113();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == '*')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado15();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == '(')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado117();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == ')')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado118();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == '[')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado119();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == ']')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado120();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == ',')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado121();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == '.')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado16();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == ';')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado124();
                    lexema = null;
                    goto Estado0;
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == ':')) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado17();
                    lexema = null;
                    goto Estado0;
                }

                else if ((contador < textBox1.Text.Length) && (charsRead[contador] == ' ')) {
                    contador++;
                    Estado127();
                    lexema = null;
                    goto Estado0;
                } else if (contador < textBox1.Text.Length) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado506();
                    Lexema = null;
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

        #region Comentarios
        public void Estado8() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '*')) {
                lexema += charsRead[contador].ToString();
                contador++;
                Estado9();
                return;
            } else if (contador < textBox1.Text.Length) {
                Estado116();
            }
        }

        public void Estado9() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '*')) {
                lexema += charsRead[contador].ToString();
                contador++;
                Estado10();
            } else if (contador < textBox1.Text.Length) {
                lexema += charsRead[contador].ToString();
                contador++;
                Estado9();
            }
        }

        public void Estado10() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '/')) {
                lexema += charsRead[contador].ToString();
                Estado104();
                contador++;
                return;
            } else if (contador < textBox1.Text.Length) {
                lexema += charsRead[contador].ToString();
                Estado502();
            }
        }

        public void Estado11() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '}')) {
                lexema += charsRead[contador].ToString();
                contador++;
                Estado105();
            } else if (contador < textBox1.Text.Length) {
                lexema += charsRead[contador].ToString();
                contador++;
                Estado11();
            }
        }
        #endregion

        #region Operadores
        public void Estado12() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '=')) {
                lexema += charsRead[contador].ToString();
                Estado106();
                contador++;
                return;
            } else if (contador < textBox1.Text.Length) {
                lexema += charsRead[contador].ToString();
                Estado503();
            }
        }

        public void Estado13() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '>')) {
                lexema += charsRead[contador].ToString();
                Estado108();
                contador++;
                return;
            } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == '=')) {
                lexema += charsRead[contador].ToString();
                Estado109();
                contador++;
                return;
            } else if (contador < textBox1.Text.Length) {
                Estado107();
            }
        }

        public void Estado14() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '=')) {
                lexema += charsRead[contador].ToString();
                Estado111();
                contador++;
                return;
            } else if (contador < textBox1.Text.Length) {
                Estado110();
            }
        }

        public void Estado15() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '*')) {
                lexema += charsRead[contador].ToString();
                Estado115();
                contador++;
                return;
            } else if (contador < textBox1.Text.Length) {
                Estado114();
            }
        }
        #endregion

        #region Delimitadores
        public void Estado16() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '.')) {
                lexema += charsRead[contador].ToString();
                Estado123();
                contador++;
                return;
            } else if (contador < textBox1.Text.Length) {
                Estado122();
            }
        }

        public void Estado17() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '=')) {
                lexema += charsRead[contador].ToString();
                Estado126();
                contador++;
                return;
            }else if (contador < textBox1.Text.Length) {
                Estado125();
            }
        }
        #endregion
        #endregion

        #region Estados de Aceptación
        public void Estado100() {
            fila = dataGridView1.Rows.Add();
            granema = "IDENTIFICADOR";
            dataGridView1.Rows[fila].Cells[2].Value = lexema.Substring(0, lexema.Length-1);
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;  // Limpia el buffer
            //return;
        }

        public void Estado101() {
            fila = dataGridView1.Rows.Add();
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

        public void Estado104() {
            fila = dataGridView1.Rows.Add();
            granema = "COMENTARIO";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado105() {
            fila = dataGridView1.Rows.Add();
            granema = "COMENTARIO";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado106() {
            fila = dataGridView1.Rows.Add();
            granema = "IGUALDAD";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado107() {
            fila = dataGridView1.Rows.Add();
            granema = "MENOR";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado108() {
            fila = dataGridView1.Rows.Add();
            granema = "DIFERENTE";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado109() {
            fila = dataGridView1.Rows.Add();
            granema = "MENOR IGUAL";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado110() {
            fila = dataGridView1.Rows.Add();
            granema = "MAYOR";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado111() {
            fila = dataGridView1.Rows.Add();
            granema = "MAYOR IGUAL";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado112() {
            fila = dataGridView1.Rows.Add();
            granema = "SUMA";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
        }

        public void Estado113() {
            fila = dataGridView1.Rows.Add();
            granema = "RESTA";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
        }

        public void Estado114() {
            fila = dataGridView1.Rows.Add();
            granema = "MULTIPLICACIÓN";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado115() {
            fila = dataGridView1.Rows.Add();
            granema = "POR POR";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado116() {
            fila = dataGridView1.Rows.Add();
            granema = "DIVISIÓN";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado117() {
            fila = dataGridView1.Rows.Add();
            granema = "PARENTÉSIS QUE ABRE";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
        }

        public void Estado118() {
            fila = dataGridView1.Rows.Add();
            granema = "PARENTÉSIS QUE CIERRA";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
        }

        public void Estado119() {
            fila = dataGridView1.Rows.Add();
            granema = "CORCHETE QUE ABRE";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
        }

        public void Estado120() {
            fila = dataGridView1.Rows.Add();
            granema = "CORCHETE QUE CIERRA";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
        }

        public void Estado121() {
            fila = dataGridView1.Rows.Add();
            granema = "COMA";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
        }

        public void Estado122() {
            fila = dataGridView1.Rows.Add();
            granema = "PUNTO";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado123() {
            fila = dataGridView1.Rows.Add();
            granema = "PUNTO PUNTO";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado124() {
            fila = dataGridView1.Rows.Add();
            granema = "PUNTO Y COMA";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
        }

        public void Estado125() {
            fila = dataGridView1.Rows.Add();
            granema = "DOS PUNTOS";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado126() {
            fila = dataGridView1.Rows.Add();
            granema = "ASIGNACIÓN";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado127() {
            fila = dataGridView1.Rows.Add();
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
            granema = "ERROR 501";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
            //return;
        }

        public void Estado502() {
            fila = dataGridView1.Rows.Add();
            granema = "ERROR 502";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado503() {
            fila = dataGridView1.Rows.Add();
            granema = "ERROR 503";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }

        public void Estado506() {
            fila = dataGridView1.Rows.Add();
            granema = "506: ERROR LÉXICO";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            lexema = null;
        }
        #endregion
    }
}
