namespace WindowsFormsApplication2
{
    partial class FormBuscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lista = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarLista = new System.Windows.Forms.Button();
            this.bPalabra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Location = new System.Drawing.Point(12, 47);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(350, 150);
            this.lista.TabIndex = 0;
            this.lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo del Estudiante";
            // 
            // buscarLista
            // 
            this.buscarLista.Location = new System.Drawing.Point(244, 18);
            this.buscarLista.Name = "buscarLista";
            this.buscarLista.Size = new System.Drawing.Size(75, 23);
            this.buscarLista.TabIndex = 2;
            this.buscarLista.Text = "Buscar";
            this.buscarLista.UseVisualStyleBackColor = true;
            this.buscarLista.Click += new System.EventHandler(this.buscarLista_Click);
            // 
            // bPalabra
            // 
            this.bPalabra.Location = new System.Drawing.Point(129, 20);
            this.bPalabra.Name = "bPalabra";
            this.bPalabra.Size = new System.Drawing.Size(100, 20);
            this.bPalabra.TabIndex = 3;
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 208);
            this.Controls.Add(this.bPalabra);
            this.Controls.Add(this.buscarLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista);
            this.Name = "FormBuscar";
            this.Text = "FormBuscar";
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscarLista;
        private System.Windows.Forms.TextBox bPalabra;
    }
}