namespace AnalizadorLexico
{
    partial class Ventana
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
            this.panelTexto = new System.Windows.Forms.Panel();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvResultado = new System.Windows.Forms.DataGridView();
            this.Palabra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTexto.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTexto
            // 
            this.panelTexto.Controls.Add(this.btnAnalizar);
            this.panelTexto.Controls.Add(this.txtTexto);
            this.panelTexto.Controls.Add(this.lblTitulo);
            this.panelTexto.Location = new System.Drawing.Point(12, 3);
            this.panelTexto.Name = "panelTexto";
            this.panelTexto.Size = new System.Drawing.Size(499, 86);
            this.panelTexto.TabIndex = 0;
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(28, 60);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(446, 23);
            this.btnAnalizar.TabIndex = 2;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(28, 34);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(446, 20);
            this.txtTexto.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(23, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(247, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ingresa el  texto a Analizar:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvResultado);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 240);
            this.panel1.TabIndex = 1;
            // 
            // dtgvResultado
            // 
            this.dtgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Palabra,
            this.Resultado});
            this.dtgvResultado.Location = new System.Drawing.Point(28, 3);
            this.dtgvResultado.Name = "dtgvResultado";
            this.dtgvResultado.Size = new System.Drawing.Size(446, 229);
            this.dtgvResultado.TabIndex = 0;
            // 
            // Palabra
            // 
            this.Palabra.HeaderText = "Palabra";
            this.Palabra.Name = "Palabra";
            this.Palabra.Width = 200;
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "Tipo Texto";
            this.Resultado.Name = "Resultado";
            this.Resultado.Width = 200;
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTexto);
            this.Name = "Ventana";
            this.Text = "Analizador Lexico";
            this.panelTexto.ResumeLayout(false);
            this.panelTexto.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTexto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.DataGridView dtgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Palabra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
    }
}

