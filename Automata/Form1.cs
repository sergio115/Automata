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
        int contador, fila;
        char[] charsRead;
        string lexema, granema;
        char[] letrasMinnusculas = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ',
                                    'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'á', 'é', 'í', 'ó', 'ú'};
        char[] letrasMayusculas = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ',
                                    'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Á', 'É', 'Í', 'Ó', 'Ú' };
        char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        String[] palabrasReservadas = { "Array", "Begin", "Case", "Const", "Do", "Else", "Writeln", "Readln", "ElseIf", "End",
                                        "For", "If", "Loop", "Module", "Function", "Exit", "Not", "Of", "Mod", "Record",
                                        "Repeat", "Return", "Pocedure", "By", "Then", "To", "Until", "Var", "While", "With",
                                        "True", "False", "Div", "Integer", "Real", "Char", "String", "Byte", "Boolean", "String" };

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnalizar_Click(object sender, EventArgs e)
        {
            charsRead = textBox1.Text.ToCharArray();
            dataGridView1.Rows.Clear();

            EstadoInicial();
        }

        public void EstadoInicial() {
            contador = 0;

        Estado0:
            while (contador < textBox1.Text.Length) {
                lexema = charsRead[contador].ToString();
                
                for (int i = 0; i < letrasMinnusculas.Length; i++) {
                    if (charsRead[contador] == letrasMinnusculas[i] || charsRead[contador] == letrasMayusculas[i]) {
                        contador++;
                        Estado1();
                        lexema = null;  // Limpia la variable para nuevas entradas
                        goto Estado0;
                    }
                }
                for (int i = 0; i < numeros.Length; i++) {
                    if (charsRead[contador] == numeros[i]) {
                        contador++;
                        Estado3();
                        lexema = null;
                        goto Estado0;
                    }
                }
                if (charsRead[contador] == '"') {
                    contador++;
                    Estado6();
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == '/') {
                    contador++;
                    Estado8();
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == '{') {
                    contador++;
                    Estado11();
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == '=') {
                    contador++;
                    Estado12();
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == '<') {
                    contador++;
                    Estado13();
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == '>') {
                    contador++;
                    Estado14();
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == '+') {
                    contador++;
                    EstadosAceptacion(112);
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == '-') {
                    contador++;
                    EstadosAceptacion(113);
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == '*') {
                    contador++;
                    Estado15();
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == '(') {
                    contador++;
                    EstadosAceptacion(117);
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == ')') {
                    contador++;
                    EstadosAceptacion(118);
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == '[') {
                    contador++;
                    EstadosAceptacion(119);
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == ']') {
                    contador++;
                    EstadosAceptacion(120);
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == ',') {
                    contador++;
                    EstadosAceptacion(121);
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == '.') {
                    contador++;
                    Estado16();
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == ';') {
                    contador++;
                    EstadosAceptacion(124);
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == ':') {
                    contador++;
                    Estado17();
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == '\t') {
                    contador++;
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == '\n') {
                    contador++;
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == '\r') {
                    contador++;
                    lexema = null;
                    goto Estado0;
                } else if (charsRead[contador] == ' ') {
                    contador++;
                    lexema = null;
                    goto Estado0;
                } else  {
                    contador++;
                    EstadosError(506);
                    lexema = null;
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
                    EstadosAceptacion(100);
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
                EstadosError(501);
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
                    EstadosAceptacion(101);
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
                EstadosError(500);
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
                EstadosAceptacion(102);
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
                EstadosAceptacion(103);
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
                EstadosAceptacion(116);
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
                EstadosAceptacion(104);
                contador++;
                return;
            } else if (contador < textBox1.Text.Length) {
                lexema += charsRead[contador].ToString();
                EstadosError(502);
            }
        }

        public void Estado11() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '}')) {
                lexema += charsRead[contador].ToString();
                contador++;
                EstadosAceptacion(105);
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
                EstadosAceptacion(106);
                contador++;
                return;
            } else if (contador < textBox1.Text.Length) {
                lexema += charsRead[contador].ToString();
                EstadosError(503);
            }
        }

        public void Estado13() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '>')) {
                lexema += charsRead[contador].ToString();
                EstadosAceptacion(108);
                contador++;
                return;
            } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == '=')) {
                lexema += charsRead[contador].ToString();
                EstadosAceptacion(109);
                contador++;
                return;
            } else if (contador < textBox1.Text.Length) {
                EstadosAceptacion(107);
            }
        }

        public void Estado14() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '=')) {
                lexema += charsRead[contador].ToString();
                EstadosAceptacion(111);
                contador++;
                return;
            } else if (contador < textBox1.Text.Length) {
                EstadosAceptacion(110);
            }
        }

        public void Estado15() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '*')) {
                lexema += charsRead[contador].ToString();
                EstadosAceptacion(115);
                contador++;
                return;
            } else if (contador < textBox1.Text.Length) {
                EstadosAceptacion(114);
            }
        }
        #endregion

        #region Delimitadores
        public void Estado16() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '.')) {
                lexema += charsRead[contador].ToString();
                EstadosAceptacion(123);
                contador++;
                return;
            } else if (contador < textBox1.Text.Length) {
                EstadosAceptacion(122);
            }
        }

        public void Estado17() {
            if ((contador < textBox1.Text.Length) && (charsRead[contador] == '=')) {
                lexema += charsRead[contador].ToString();
                EstadosAceptacion(126);
                contador++;
                return;
            }else if (contador < textBox1.Text.Length) {
                EstadosAceptacion(125);
            }
        }
        #endregion
        #endregion

        public int EstadosAceptacion(int estado) {
            fila = dataGridView1.Rows.Add();
            dataGridView1.Rows[fila].Cells[0].Value = lexema;

            switch (estado) {
                case 100:
                    granema = "100: IDENTIFICADOR";

                    for (int i = 0; i < palabrasReservadas.Length; i++) {
                        if (string.Equals(lexema.Substring(0, lexema.Length - 1),
                                            palabrasReservadas[i], StringComparison.OrdinalIgnoreCase)) {
                            granema = "100: PALABRA RESERVADA";
                        }
                    }

                    dataGridView1.Rows[fila].Cells[0].Value = lexema.Substring(0, lexema.Length - 1);
                    break;
                case 101:
                    granema = "101: NÚMERO ENTERO";
                    dataGridView1.Rows[fila].Cells[0].Value = lexema.Substring(0, lexema.Length - 1);
                    break;
                case 102:
                    granema = "102: NÚMERO REAL";
                    dataGridView1.Rows[fila].Cells[0].Value = lexema.Substring(0, lexema.Length - 1);
                    break;
                case 103:
                    granema = "103: LETRERO";
                    dataGridView1.Rows[fila].Cells[0].Value = lexema.Substring(0, lexema.Length - 1);
                    break;
                case 104:
                    granema = "104: COMENTARIO";
                    break;
                case 105:
                    granema = "105: COMENTARIO";
                    break;
                case 106:
                    granema = "106: IGUALDAD";
                    break;
                case 107:
                    granema = "107: MENOR";
                    break;
                case 108:
                    granema = "108: DIFERENTE";
                    break;
                case 109:
                    granema = "109: MENOR IGUAL";
                    break;
                case 110:
                    granema = "110: MAYOR";
                    break;
                case 111:
                    granema = "111: MAYOR IGUAL";
                    break;
                case 112:
                    granema = "112: SUMA";
                    break;
                case 113:
                    granema = "113: RESTA";
                    break;
                case 114:
                    granema = "114: MULTIPLICACIÓN";
                    break;
                case 115:
                    granema = "115: POR POR";
                    break;
                case 116:
                    granema = "116: DIVISIÓN";
                    break;
                case 117:
                    granema = "117: PARENTÉSIS QUE ABRE";
                    break;
                case 118:
                    granema = "118: PARENTÉSIS QUE CIERRA";
                    break;
                case 119:
                    granema = "119: CORCHETE QUE ABRE";
                    break;
                case 120:
                    granema = "120: CORCHETE QUE CIERRA";
                    break;
                case 121:
                    granema = "121: COMA";
                    break;
                case 122:
                    granema = "122: PUNTO";
                    break;
                case 123:
                    granema = "123: PUNTO PUNTO";
                    break;
                case 124:
                    granema = "124: PUNTO Y COMA";
                    break;
                case 125:
                    granema = "125: DOS PUNTOS";
                    break;
                case 126:
                    granema = "126: ASIGNACIÓN";
                    break;
            }

            dataGridView1.Rows[fila].Cells[1].Value = granema;

            return 0;
        }

        public int EstadosError(int estado) {
            fila = dataGridView1.Rows.Add();

            switch (estado) {
                case 500:
                    granema = "ERROR 500: REAL MAL FORMADO";
                    break;
                case 501:
                    granema = "ERROR 501: IDENTIFICADOR MAL FORMADO";
                    break;
                case 502:
                    granema = "ERROR 502: COMENTARIO MAL FORMADO";
                    break;
                case 503:
                    granema = "ERROR 503: OPERADOR MAL FORMADO";
                    break;
                case 506:
                    granema = "ERROR 506: ERROR LÉXICO";
                    break;
            }

            dataGridView1.Rows[fila].Cells[0].Value = lexema;
            dataGridView1.Rows[fila].Cells[1].Value = granema;

            return 0;
        }
    }
}
