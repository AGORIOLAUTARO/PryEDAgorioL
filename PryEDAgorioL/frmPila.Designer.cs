namespace PryEDAgorioL
{
    partial class frmPila
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
            this.gpbGrilla = new System.Windows.Forms.GroupBox();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblTramit = new System.Windows.Forms.Label();
            this.lblNombr = new System.Windows.Forms.Label();
            this.lblCodig = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramiteEliminado = new System.Windows.Forms.Label();
            this.lblNombreEliminado = new System.Windows.Forms.Label();
            this.lblCodigoEliminado = new System.Windows.Forms.Label();
            this.gpbPila = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pbPila = new System.Windows.Forms.PictureBox();
            this.gpbGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            this.gpbElementoEliminado.SuspendLayout();
            this.gpbPila.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPila)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbGrilla
            // 
            this.gpbGrilla.Controls.Add(this.lstPila);
            this.gpbGrilla.Controls.Add(this.dgvPila);
            this.gpbGrilla.Location = new System.Drawing.Point(28, 218);
            this.gpbGrilla.Name = "gpbGrilla";
            this.gpbGrilla.Size = new System.Drawing.Size(745, 202);
            this.gpbGrilla.TabIndex = 6;
            this.gpbGrilla.TabStop = false;
            this.gpbGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(35, 29);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(160, 160);
            this.lstPila.TabIndex = 9;
            // 
            // dgvPila
            // 
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPila.Location = new System.Drawing.Point(290, 19);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.RowHeadersVisible = false;
            this.dgvPila.RowHeadersWidth = 51;
            this.dgvPila.Size = new System.Drawing.Size(380, 170);
            this.dgvPila.TabIndex = 8;
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
            // gpbElementoEliminado
            // 
            this.gpbElementoEliminado.Controls.Add(this.lblTramit);
            this.gpbElementoEliminado.Controls.Add(this.lblNombr);
            this.gpbElementoEliminado.Controls.Add(this.lblCodig);
            this.gpbElementoEliminado.Controls.Add(this.btnEliminar);
            this.gpbElementoEliminado.Controls.Add(this.lblTramiteEliminado);
            this.gpbElementoEliminado.Controls.Add(this.lblNombreEliminado);
            this.gpbElementoEliminado.Controls.Add(this.lblCodigoEliminado);
            this.gpbElementoEliminado.Location = new System.Drawing.Point(564, 30);
            this.gpbElementoEliminado.Name = "gpbElementoEliminado";
            this.gpbElementoEliminado.Size = new System.Drawing.Size(200, 176);
            this.gpbElementoEliminado.TabIndex = 5;
            this.gpbElementoEliminado.TabStop = false;
            this.gpbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // lblTramit
            // 
            this.lblTramit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramit.Location = new System.Drawing.Point(94, 102);
            this.lblTramit.Name = "lblTramit";
            this.lblTramit.Size = new System.Drawing.Size(100, 30);
            this.lblTramit.TabIndex = 10;
            // 
            // lblNombr
            // 
            this.lblNombr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombr.Location = new System.Drawing.Point(94, 66);
            this.lblNombr.Name = "lblNombr";
            this.lblNombr.Size = new System.Drawing.Size(100, 27);
            this.lblNombr.TabIndex = 9;
            // 
            // lblCodig
            // 
            this.lblCodig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodig.Location = new System.Drawing.Point(94, 33);
            this.lblCodig.Name = "lblCodig";
            this.lblCodig.Size = new System.Drawing.Size(100, 23);
            this.lblCodig.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(73, 140);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblTramiteEliminado
            // 
            this.lblTramiteEliminado.AutoSize = true;
            this.lblTramiteEliminado.Location = new System.Drawing.Point(32, 104);
            this.lblTramiteEliminado.Name = "lblTramiteEliminado";
            this.lblTramiteEliminado.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteEliminado.TabIndex = 3;
            this.lblTramiteEliminado.Text = "Trámite:";
            // 
            // lblNombreEliminado
            // 
            this.lblNombreEliminado.AutoSize = true;
            this.lblNombreEliminado.Location = new System.Drawing.Point(32, 66);
            this.lblNombreEliminado.Name = "lblNombreEliminado";
            this.lblNombreEliminado.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEliminado.TabIndex = 2;
            this.lblNombreEliminado.Text = "Nombre:";
            // 
            // lblCodigoEliminado
            // 
            this.lblCodigoEliminado.AutoSize = true;
            this.lblCodigoEliminado.Location = new System.Drawing.Point(32, 37);
            this.lblCodigoEliminado.Name = "lblCodigoEliminado";
            this.lblCodigoEliminado.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEliminado.TabIndex = 1;
            this.lblCodigoEliminado.Text = "Código:";
            // 
            // gpbPila
            // 
            this.gpbPila.Controls.Add(this.txtTramite);
            this.gpbPila.Controls.Add(this.txtNombre);
            this.gpbPila.Controls.Add(this.txtCodigo);
            this.gpbPila.Controls.Add(this.btnAgregar);
            this.gpbPila.Controls.Add(this.lblTramite);
            this.gpbPila.Controls.Add(this.lblNombre);
            this.gpbPila.Controls.Add(this.lblCodigo);
            this.gpbPila.Location = new System.Drawing.Point(318, 30);
            this.gpbPila.Name = "gpbPila";
            this.gpbPila.Size = new System.Drawing.Size(203, 176);
            this.gpbPila.TabIndex = 4;
            this.gpbPila.TabStop = false;
            this.gpbPila.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(79, 100);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(79, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(79, 140);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(17, 100);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(17, 34);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // pbPila
            // 
            this.pbPila.Image = global::PryEDAgorioL.Properties.Resources.pila;
            this.pbPila.Location = new System.Drawing.Point(28, 30);
            this.pbPila.Name = "pbPila";
            this.pbPila.Size = new System.Drawing.Size(249, 157);
            this.pbPila.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPila.TabIndex = 7;
            this.pbPila.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPila);
            this.Controls.Add(this.gpbGrilla);
            this.Controls.Add(this.gpbElementoEliminado);
            this.Controls.Add(this.gpbPila);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPila";
            this.gpbGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            this.gpbElementoEliminado.ResumeLayout(false);
            this.gpbElementoEliminado.PerformLayout();
            this.gpbPila.ResumeLayout(false);
            this.gpbPila.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPila)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPila;
        private System.Windows.Forms.GroupBox gpbGrilla;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox gpbElementoEliminado;
        private System.Windows.Forms.Label lblTramit;
        private System.Windows.Forms.Label lblNombr;
        private System.Windows.Forms.Label lblCodig;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramiteEliminado;
        private System.Windows.Forms.Label lblNombreEliminado;
        private System.Windows.Forms.Label lblCodigoEliminado;
        private System.Windows.Forms.GroupBox gpbPila;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
    }
}