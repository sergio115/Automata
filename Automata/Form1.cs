﻿using System;
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
            //fila = dataGridView1.Rows.Add();
            for (int i = 0; i < letrasMinnusculas.Length; i++) {
                if ((contador < textBox1.Text.Length) && 
                        (charsRead[contador] == letrasMinnusculas[i] || charsRead[contador] == letrasMayusculas[i])) {
                    Estado1();
                } else if ((contador < textBox1.Text.Length) && (charsRead[contador] == ' ')) {
                    Estado110();
                }

                //lexema = null;
            }
        }

        #region Estados de Transición
        #region Identificadores
        public void Estado1() {
            for (int i = 0; i < numeros.Length; i++) {
                if ((contador < textBox1.Text.Length) && (charsRead[contador] == numeros[i])) {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado1();
                }
            }
            //for (int i = 0; i < letrasMinnusculas.Length; i++) {
            //    if (contador < textBox1.Text.Length) {
            //        if (charsRead[contador] == letrasMinnusculas[i] || charsRead[contador] == letrasMayusculas[i]) {
            //            lexema += charsRead[contador].ToString();
            //            contador++;
            //            Estado1();
            //        } else if (charsRead[contador] == '_') {
            //            lexema += charsRead[contador].ToString();
            //            contador++;
            //            Estado2();
            //        } else {
            //            lexema += charsRead[contador].ToString();
            //            contador++;
            //            Estado100();
            //        }
            //    }
            //}
            for (int i = 0; i < letrasMinnusculas.Length; i++) {
                if (contador < textBox1.Text.Length) { 
                    if (charsRead[contador] == letrasMinnusculas[i] || charsRead[contador] == letrasMayusculas[i]) {
                        lexema += charsRead[contador].ToString();
                        contador++;
                        Estado1();
                    }
                }
            }
            if (contador < textBox1.Text.Length) { 
                if (charsRead[contador] == '_') {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado2();
                } else {
                    lexema += charsRead[contador].ToString();
                    contador++;
                    Estado100();
                }
            }

        }
        #endregion

        public void Estado2() {
            for (int i = 0; i < numeros.Length; i++) {
                    if ((contador < textBox1.Text.Length) && (charsRead[contador] == numeros[i])) {
                        lexema += charsRead[contador].ToString();
                        contador++;
                        Estado1();
                    }
                }
            for (int i = 0; i < letrasMinnusculas.Length; i++) {
                if (contador < textBox1.Text.Length) {
                    if ((contador < textBox1.Text.Length) &&
                            (charsRead[contador] == letrasMinnusculas[i] || charsRead[contador] == letrasMayusculas[i])) {
                        lexema += charsRead[contador].ToString();
                        contador++;
                        Estado1();
                    } else {
                        lexema += charsRead[contador].ToString();
                        contador++;
                        Estado501();
                    }
                }     
            }
        }

        #region Estados no funcionales
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

        public void Estado5()
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

        public void Estado6()
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

        public void Estado7()
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

        public void Estado8()
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

        public void Estado9()
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

        public void Estado10()
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

        public void Estado11()
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

        public void Estado12()
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

        public void Estado13()
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

        public void Estado14()
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

        public void Estado15()
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

        public void Estado16()
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

        public void Estado17()
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
        #endregion
        #endregion

        #region Estados de Aceptación
        public void Estado100() {
            fila = dataGridView1.Rows.Add();
            aprobado = true;
            granema = "IDENTIFICADOR";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            return;
        }
        public void Estado110() {
            contador++;
            fila = dataGridView1.Rows.Add();
            aprobado = true;
            lexema = "' '";
            granema = "ESPACIO";
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            dataGridView1.Rows[fila].Cells[3].Value = granema;
            return;
        }
        #endregion

        #region Estados de Error
        public void EstadoError()
        {
            aprobado = false;
            return;
        }

        public void Estado501() {
            aprobado = false;
            dataGridView1.Rows[fila].Cells[2].Value = lexema;
            return;
        }
        #endregion
    }
}