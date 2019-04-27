namespace Automata
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
            this.Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Granema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(545, 426);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fila,
            this.Columna,
            this.Lexema,
            this.Granema});
            this.dataGridView1.Location = new System.Drawing.Point(563, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 388);
            this.dataGridView1.TabIndex = 3;
            // 
            // Fila
            // 
            this.Fila.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fila.HeaderText = "Fila";
            this.Fila.MinimumWidth = 50;
            this.Fila.Name = "Fila";
            this.Fila.ReadOnly = true;
            this.Fila.Visible = false;
            // 
            // Columna
            // 
            this.Columna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Columna.HeaderText = "Columna";
            this.Columna.MinimumWidth = 50;
            this.Columna.Name = "Columna";
            this.Columna.ReadOnly = true;
            this.Columna.Visible = false;
            // 
            // Lexema
            // 
            this.Lexema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.MinimumWidth = 150;
            this.Lexema.Name = "Lexema";
            this.Lexema.ReadOnly = true;
            this.Lexema.Width = 150;
            // 
            // Granema
            // 
            this.Granema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Granema.HeaderText = "Granema";
            this.Granema.MinimumWidth = 150;
            this.Granema.Name = "Granema";
            this.Granema.ReadOnly = true;
            this.Granema.Width = 150;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

