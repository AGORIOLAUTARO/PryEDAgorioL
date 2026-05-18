namespace PryEDAgorioL
{
    partial class frmGrafo
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
            this.gpbConsultaDatos = new System.Windows.Forms.GroupBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecioDatos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDestinoDatos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBorrarDatos = new System.Windows.Forms.Button();
            this.cmbOrigenDatos = new System.Windows.Forms.ComboBox();
            this.btnConsultarDatos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbListarViajes = new System.Windows.Forms.GroupBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.btnVerViajes = new System.Windows.Forms.Button();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbListarViajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbConsultaDatos
            // 
            this.gpbConsultaDatos.Controls.Add(this.txtPrecio);
            this.gpbConsultaDatos.Controls.Add(this.lblPrecio);
            this.gpbConsultaDatos.Controls.Add(this.cmbDestino);
            this.gpbConsultaDatos.Controls.Add(this.lblDestino);
            this.gpbConsultaDatos.Controls.Add(this.btnBorrar);
            this.gpbConsultaDatos.Controls.Add(this.cmbOrigen);
            this.gpbConsultaDatos.Controls.Add(this.btnConsultar);
            this.gpbConsultaDatos.Controls.Add(this.lblOrigen);
            this.gpbConsultaDatos.Location = new System.Drawing.Point(712, 33);
            this.gpbConsultaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gpbConsultaDatos.Name = "gpbConsultaDatos";
            this.gpbConsultaDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gpbConsultaDatos.Size = new System.Drawing.Size(310, 217);
            this.gpbConsultaDatos.TabIndex = 21;
            this.gpbConsultaDatos.TabStop = false;
            this.gpbConsultaDatos.Text = "Consulta de datos";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(91, 37);
            this.cmbOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(160, 24);
            this.cmbOrigen.TabIndex = 8;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(17, 167);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(131, 33);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(25, 42);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(47, 16);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryEDAgorioL.Properties.Resources.Captura_de_pantalla_2026_05_17_225214;
            this.pictureBox1.Location = new System.Drawing.Point(38, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(167, 167);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(135, 33);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(91, 79);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(160, 24);
            this.cmbDestino.TabIndex = 11;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(25, 84);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(53, 16);
            this.lblDestino.TabIndex = 10;
            this.lblDestino.Text = "Destino";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(28, 128);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(91, 128);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecioDatos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbDestinoDatos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBorrarDatos);
            this.groupBox1.Controls.Add(this.cmbOrigenDatos);
            this.groupBox1.Controls.Add(this.btnConsultarDatos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(381, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(310, 217);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de datos";
            // 
            // txtPrecioDatos
            // 
            this.txtPrecioDatos.Location = new System.Drawing.Point(91, 128);
            this.txtPrecioDatos.Name = "txtPrecioDatos";
            this.txtPrecioDatos.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioDatos.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Precio";
            // 
            // cmbDestinoDatos
            // 
            this.cmbDestinoDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinoDatos.FormattingEnabled = true;
            this.cmbDestinoDatos.Location = new System.Drawing.Point(91, 79);
            this.cmbDestinoDatos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDestinoDatos.Name = "cmbDestinoDatos";
            this.cmbDestinoDatos.Size = new System.Drawing.Size(160, 24);
            this.cmbDestinoDatos.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Destino";
            // 
            // btnBorrarDatos
            // 
            this.btnBorrarDatos.Location = new System.Drawing.Point(167, 167);
            this.btnBorrarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarDatos.Name = "btnBorrarDatos";
            this.btnBorrarDatos.Size = new System.Drawing.Size(135, 33);
            this.btnBorrarDatos.TabIndex = 9;
            this.btnBorrarDatos.Text = "Borrar";
            this.btnBorrarDatos.UseVisualStyleBackColor = true;
            // 
            // cmbOrigenDatos
            // 
            this.cmbOrigenDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenDatos.FormattingEnabled = true;
            this.cmbOrigenDatos.Location = new System.Drawing.Point(91, 37);
            this.cmbOrigenDatos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOrigenDatos.Name = "cmbOrigenDatos";
            this.cmbOrigenDatos.Size = new System.Drawing.Size(160, 24);
            this.cmbOrigenDatos.TabIndex = 8;
            // 
            // btnConsultarDatos
            // 
            this.btnConsultarDatos.Location = new System.Drawing.Point(17, 167);
            this.btnConsultarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarDatos.Name = "btnConsultarDatos";
            this.btnConsultarDatos.Size = new System.Drawing.Size(131, 33);
            this.btnConsultarDatos.TabIndex = 7;
            this.btnConsultarDatos.Text = "Consultar";
            this.btnConsultarDatos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Origen";
            // 
            // gpbListarViajes
            // 
            this.gpbListarViajes.Controls.Add(this.dgvViajes);
            this.gpbListarViajes.Controls.Add(this.btnVerViajes);
            this.gpbListarViajes.Controls.Add(this.btnListarOrigenes);
            this.gpbListarViajes.Controls.Add(this.cmbHasta);
            this.gpbListarViajes.Controls.Add(this.lblHasta);
            this.gpbListarViajes.Controls.Add(this.btnListarDestinos);
            this.gpbListarViajes.Controls.Add(this.cmbDesde);
            this.gpbListarViajes.Controls.Add(this.lblDesde);
            this.gpbListarViajes.Location = new System.Drawing.Point(38, 256);
            this.gpbListarViajes.Name = "gpbListarViajes";
            this.gpbListarViajes.Size = new System.Drawing.Size(976, 296);
            this.gpbListarViajes.TabIndex = 24;
            this.gpbListarViajes.TabStop = false;
            this.gpbListarViajes.Text = "Listar Viajes";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(18, 31);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 16);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde";
            // 
            // cmbDesde
            // 
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(72, 28);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(121, 24);
            this.cmbDesde.TabIndex = 1;
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(199, 24);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(109, 31);
            this.btnListarDestinos.TabIndex = 2;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(330, 33);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(43, 16);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta";
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(510, 21);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(109, 34);
            this.btnListarOrigenes.TabIndex = 5;
            this.btnListarOrigenes.Text = "Listar Origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(379, 28);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(121, 24);
            this.cmbHasta.TabIndex = 4;
            // 
            // btnVerViajes
            // 
            this.btnVerViajes.Location = new System.Drawing.Point(665, 26);
            this.btnVerViajes.Name = "btnVerViajes";
            this.btnVerViajes.Size = new System.Drawing.Size(157, 29);
            this.btnVerViajes.TabIndex = 6;
            this.btnVerViajes.Text = "Ver todos los viajes";
            this.btnVerViajes.UseVisualStyleBackColor = true;
            // 
            // dgvViajes
            // 
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvViajes.Location = new System.Drawing.Point(51, 73);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.RowHeadersVisible = false;
            this.dgvViajes.RowHeadersWidth = 51;
            this.dgvViajes.RowTemplate.Height = 24;
            this.dgvViajes.Size = new System.Drawing.Size(757, 213);
            this.dgvViajes.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Origen";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Córdoba";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mendoza";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Santa Fe";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Buenos Aires";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Salta";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gpbListarViajes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbConsultaDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrafo";
            this.gpbConsultaDatos.ResumeLayout(false);
            this.gpbConsultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbListarViajes.ResumeLayout(false);
            this.gpbListarViajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConsultaDatos;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrecioDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDestinoDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrarDatos;
        private System.Windows.Forms.ComboBox cmbOrigenDatos;
        private System.Windows.Forms.Button btnConsultarDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbListarViajes;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnVerViajes;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}