namespace PryEDAgorioL
{
    partial class frmCola
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
            this.gpbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gpbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblTramit = new System.Windows.Forms.Label();
            this.lblNombr = new System.Windows.Forms.Label();
            this.lblCodig = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramiteEliminado = new System.Windows.Forms.Label();
            this.lblNombreEliminado = new System.Windows.Forms.Label();
            this.lblCodigoEliminado = new System.Windows.Forms.Label();
            this.gpbGrilla = new System.Windows.Forms.GroupBox();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbNuevoElemento.SuspendLayout();
            this.gpbElementoEliminado.SuspendLayout();
            this.gpbGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbNuevoElemento
            // 
            this.gpbNuevoElemento.Controls.Add(this.txtTramite);
            this.gpbNuevoElemento.Controls.Add(this.txtNombre);
            this.gpbNuevoElemento.Controls.Add(this.txtCodigo);
            this.gpbNuevoElemento.Controls.Add(this.btnAgregar);
            this.gpbNuevoElemento.Controls.Add(this.lblTramite);
            this.gpbNuevoElemento.Controls.Add(this.lblNombre);
            this.gpbNuevoElemento.Controls.Add(this.lblCodigo);
            this.gpbNuevoElemento.Location = new System.Drawing.Point(444, 59);
            this.gpbNuevoElemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbNuevoElemento.Name = "gpbNuevoElemento";
            this.gpbNuevoElemento.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbNuevoElemento.Size = new System.Drawing.Size(271, 217);
            this.gpbNuevoElemento.TabIndex = 0;
            this.gpbNuevoElemento.TabStop = false;
            this.gpbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(105, 123);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(132, 22);
            this.txtTramite.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 78);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(105, 38);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(105, 172);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(23, 123);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 16);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 81);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(23, 42);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // gpbElementoEliminado
            // 
            this.gpbElementoEliminado.Controls.Add(this.lblTramit);
            this.gpbElementoEliminado.Controls.Add(this.lblNombr);
            this.gpbElementoEliminado.Controls.Add(this.lblCodig);
            this.gpbElementoEliminado.Controls.Add(this.btnEliminar);
            this.gpbElementoEliminado.Controls.Add(this.lblTramiteEliminado);
            this.gpbElementoEliminado.Controls.Add(this.lblNombreEliminado);
            this.gpbElementoEliminado.Controls.Add(this.lblCodigoEliminado);
            this.gpbElementoEliminado.Location = new System.Drawing.Point(772, 59);
            this.gpbElementoEliminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbElementoEliminado.Name = "gpbElementoEliminado";
            this.gpbElementoEliminado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbElementoEliminado.Size = new System.Drawing.Size(267, 217);
            this.gpbElementoEliminado.TabIndex = 1;
            this.gpbElementoEliminado.TabStop = false;
            this.gpbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // lblTramit
            // 
            this.lblTramit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramit.Location = new System.Drawing.Point(125, 126);
            this.lblTramit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramit.Name = "lblTramit";
            this.lblTramit.Size = new System.Drawing.Size(133, 37);
            this.lblTramit.TabIndex = 10;
            // 
            // lblNombr
            // 
            this.lblNombr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombr.Location = new System.Drawing.Point(125, 81);
            this.lblNombr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombr.Name = "lblNombr";
            this.lblNombr.Size = new System.Drawing.Size(133, 33);
            this.lblNombr.TabIndex = 9;
            // 
            // lblCodig
            // 
            this.lblCodig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodig.Location = new System.Drawing.Point(125, 41);
            this.lblCodig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodig.Name = "lblCodig";
            this.lblCodig.Size = new System.Drawing.Size(133, 28);
            this.lblCodig.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(97, 172);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblTramiteEliminado
            // 
            this.lblTramiteEliminado.AutoSize = true;
            this.lblTramiteEliminado.Location = new System.Drawing.Point(43, 128);
            this.lblTramiteEliminado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramiteEliminado.Name = "lblTramiteEliminado";
            this.lblTramiteEliminado.Size = new System.Drawing.Size(56, 16);
            this.lblTramiteEliminado.TabIndex = 3;
            this.lblTramiteEliminado.Text = "Trámite:";
            // 
            // lblNombreEliminado
            // 
            this.lblNombreEliminado.AutoSize = true;
            this.lblNombreEliminado.Location = new System.Drawing.Point(43, 81);
            this.lblNombreEliminado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEliminado.Name = "lblNombreEliminado";
            this.lblNombreEliminado.Size = new System.Drawing.Size(59, 16);
            this.lblNombreEliminado.TabIndex = 2;
            this.lblNombreEliminado.Text = "Nombre:";
            // 
            // lblCodigoEliminado
            // 
            this.lblCodigoEliminado.AutoSize = true;
            this.lblCodigoEliminado.Location = new System.Drawing.Point(43, 46);
            this.lblCodigoEliminado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoEliminado.Name = "lblCodigoEliminado";
            this.lblCodigoEliminado.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoEliminado.TabIndex = 1;
            this.lblCodigoEliminado.Text = "Código:";
            // 
            // gpbGrilla
            // 
            this.gpbGrilla.Controls.Add(this.lstCola);
            this.gpbGrilla.Controls.Add(this.dgvAlumnos);
            this.gpbGrilla.Location = new System.Drawing.Point(57, 290);
            this.gpbGrilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbGrilla.Name = "gpbGrilla";
            this.gpbGrilla.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbGrilla.Size = new System.Drawing.Size(993, 249);
            this.gpbGrilla.TabIndex = 2;
            this.gpbGrilla.TabStop = false;
            this.gpbGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 16;
            this.lstCola.Location = new System.Drawing.Point(47, 36);
            this.lstCola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(212, 196);
            this.lstCola.TabIndex = 9;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvAlumnos.Location = new System.Drawing.Point(387, 23);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersVisible = false;
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.Size = new System.Drawing.Size(404, 209);
            this.dgvAlumnos.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trámite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryEDAgorioL.Properties.Resources.la_concha_de_tu_madre;
            this.pictureBox1.Location = new System.Drawing.Point(57, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbGrilla);
            this.Controls.Add(this.gpbElementoEliminado);
            this.Controls.Add(this.gpbNuevoElemento);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.gpbNuevoElemento.ResumeLayout(false);
            this.gpbNuevoElemento.PerformLayout();
            this.gpbElementoEliminado.ResumeLayout(false);
            this.gpbElementoEliminado.PerformLayout();
            this.gpbGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNuevoElemento;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gpbElementoEliminado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramiteEliminado;
        private System.Windows.Forms.Label lblNombreEliminado;
        private System.Windows.Forms.Label lblCodigoEliminado;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramit;
        private System.Windows.Forms.Label lblNombr;
        private System.Windows.Forms.Label lblCodig;
        private System.Windows.Forms.GroupBox gpbGrilla;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}