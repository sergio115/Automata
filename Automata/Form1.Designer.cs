﻿namespace Automata
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Granema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.txBxSintactico = new System.Windows.Forms.TextBox();
            this.LexemaOrdenado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoGranema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(545, 190);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lexema,
            this.Granema,
            this.LexemaOrdenado,
            this.CodigoGranema});
            this.dataGridView1.Location = new System.Drawing.Point(563, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 388);
            this.dataGridView1.TabIndex = 3;
            // 
            // Lexema
            // 
            this.Lexema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.MinimumWidth = 200;
            this.Lexema.Name = "Lexema";
            this.Lexema.ReadOnly = true;
            this.Lexema.Width = 200;
            // 
            // Granema
            // 
            this.Granema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Granema.HeaderText = "Granema";
            this.Granema.MinimumWidth = 200;
            this.Granema.Name = "Granema";
            this.Granema.ReadOnly = true;
            this.Granema.Width = 200;
            // 
            // Fila
            // 
            this.Fila.Name = "Fila";
            // 
            // Columna
            // 
            this.Columna.Name = "Columna";
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizar.Location = new System.Drawing.Point(732, 12);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(106, 32);
            this.btnAnalizar.TabIndex = 4;
            this.btnAnalizar.Text = "ANALIZAR";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.BtnAnalizar_Click);
            // 
            // txBxSintactico
            // 
            this.txBxSintactico.AcceptsTab = true;
            this.txBxSintactico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxSintactico.Location = new System.Drawing.Point(12, 248);
            this.txBxSintactico.Multiline = true;
            this.txBxSintactico.Name = "txBxSintactico";
            this.txBxSintactico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txBxSintactico.Size = new System.Drawing.Size(545, 190);
            this.txBxSintactico.TabIndex = 5;
            // 
            // LexemaOrdenado
            // 
            this.LexemaOrdenado.HeaderText = "LexemaOrdenado";
            this.LexemaOrdenado.Name = "LexemaOrdenado";
            this.LexemaOrdenado.ReadOnly = true;
            this.LexemaOrdenado.Visible = false;
            // 
            // CodigoGranema
            // 
            this.CodigoGranema.HeaderText = "CodigoGranema";
            this.CodigoGranema.Name = "CodigoGranema";
            this.CodigoGranema.ReadOnly = true;
            this.CodigoGranema.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resultado Sintáctico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txBxSintactico);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Analizador Léxico y Sintáctico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Granema;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.TextBox txBxSintactico;
        private System.Windows.Forms.DataGridViewTextBoxColumn LexemaOrdenado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoGranema;
        private System.Windows.Forms.Label label1;
    }
}

