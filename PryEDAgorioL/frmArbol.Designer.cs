namespace PryEDAgorioL
{
    partial class frmArbol
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
            this.trvArbol = new System.Windows.Forms.TreeView();
            this.gpbListadoArbol = new System.Windows.Forms.GroupBox();
            this.dgvArbol = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbPostOrden = new System.Windows.Forms.RadioButton();
            this.rbPreOrden = new System.Windows.Forms.RadioButton();
            this.rbInOrden = new System.Windows.Forms.RadioButton();
            this.gpbListaSimple = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gpbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbArbol = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigoEliminado = new System.Windows.Forms.Label();
            this.btnEqulibrar = new System.Windows.Forms.Button();
            this.gpbListadoArbol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).BeginInit();
            this.gpbListaSimple.SuspendLayout();
            this.gpbElementoEliminado.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvArbol
            // 
            this.trvArbol.Location = new System.Drawing.Point(31, 15);
            this.trvArbol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trvArbol.Name = "trvArbol";
            this.trvArbol.Size = new System.Drawing.Size(221, 232);
            this.trvArbol.TabIndex = 0;
            this.trvArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // gpbListadoArbol
            // 
            this.gpbListadoArbol.Controls.Add(this.dgvArbol);
            this.gpbListadoArbol.Controls.Add(this.rbPostOrden);
            this.gpbListadoArbol.Controls.Add(this.rbPreOrden);
            this.gpbListadoArbol.Controls.Add(this.rbInOrden);
            this.gpbListadoArbol.Location = new System.Drawing.Point(16, 284);
            this.gpbListadoArbol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbListadoArbol.Name = "gpbListadoArbol";
            this.gpbListadoArbol.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbListadoArbol.Size = new System.Drawing.Size(893, 255);
            this.gpbListadoArbol.TabIndex = 18;
            this.gpbListadoArbol.TabStop = false;
            this.gpbListadoArbol.Text = "Listado del árbol";
            this.gpbListadoArbol.Enter += new System.EventHandler(this.gpbListarDatos_Enter);
            // 
            // dgvArbol
            // 
            this.dgvArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvArbol.Location = new System.Drawing.Point(366, 23);
            this.dgvArbol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArbol.Name = "dgvArbol";
            this.dgvArbol.RowHeadersVisible = false;
            this.dgvArbol.RowHeadersWidth = 51;
            this.dgvArbol.Size = new System.Drawing.Size(380, 209);
            this.dgvArbol.TabIndex = 21;
            this.dgvArbol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaDoble_CellContentClick);
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
            // rbPostOrden
            // 
            this.rbPostOrden.AutoSize = true;
            this.rbPostOrden.Location = new System.Drawing.Point(49, 162);
            this.rbPostOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPostOrden.Name = "rbPostOrden";
            this.rbPostOrden.Size = new System.Drawing.Size(96, 20);
            this.rbPostOrden.TabIndex = 2;
            this.rbPostOrden.TabStop = true;
            this.rbPostOrden.Text = "Post-Orden";
            this.rbPostOrden.UseVisualStyleBackColor = true;
            this.rbPostOrden.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbPreOrden
            // 
            this.rbPreOrden.AutoSize = true;
            this.rbPreOrden.Location = new System.Drawing.Point(49, 114);
            this.rbPreOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPreOrden.Name = "rbPreOrden";
            this.rbPreOrden.Size = new System.Drawing.Size(90, 20);
            this.rbPreOrden.TabIndex = 1;
            this.rbPreOrden.TabStop = true;
            this.rbPreOrden.Text = "Pre-Orden";
            this.rbPreOrden.UseVisualStyleBackColor = true;
            this.rbPreOrden.CheckedChanged += new System.EventHandler(this.rbDescendente_CheckedChanged);
            // 
            // rbInOrden
            // 
            this.rbInOrden.AutoSize = true;
            this.rbInOrden.Location = new System.Drawing.Point(49, 64);
            this.rbInOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbInOrden.Name = "rbInOrden";
            this.rbInOrden.Size = new System.Drawing.Size(79, 20);
            this.rbInOrden.TabIndex = 0;
            this.rbInOrden.TabStop = true;
            this.rbInOrden.Text = "In-Orden";
            this.rbInOrden.UseVisualStyleBackColor = true;
            this.rbInOrden.CheckedChanged += new System.EventHandler(this.rbAscendente_CheckedChanged);
            // 
            // gpbListaSimple
            // 
            this.gpbListaSimple.Controls.Add(this.txtTramite);
            this.gpbListaSimple.Controls.Add(this.txtNombre);
            this.gpbListaSimple.Controls.Add(this.txtCodigo);
            this.gpbListaSimple.Controls.Add(this.btnAgregar);
            this.gpbListaSimple.Controls.Add(this.lblTramite);
            this.gpbListaSimple.Controls.Add(this.lblNombre);
            this.gpbListaSimple.Controls.Add(this.lblCodigo);
            this.gpbListaSimple.Location = new System.Drawing.Point(315, 31);
            this.gpbListaSimple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbListaSimple.Name = "gpbListaSimple";
            this.gpbListaSimple.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbListaSimple.Size = new System.Drawing.Size(271, 217);
            this.gpbListaSimple.TabIndex = 17;
            this.gpbListaSimple.TabStop = false;
            this.gpbListaSimple.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(105, 123);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(132, 22);
            this.txtTramite.TabIndex = 9;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
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
            this.btnAgregar.Location = new System.Drawing.Point(67, 172);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 28);
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
            this.lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // gpbElementoEliminado
            // 
            this.gpbElementoEliminado.Controls.Add(this.cmbArbol);
            this.gpbElementoEliminado.Controls.Add(this.btnEliminar);
            this.gpbElementoEliminado.Controls.Add(this.lblCodigoEliminado);
            this.gpbElementoEliminado.Location = new System.Drawing.Point(625, 31);
            this.gpbElementoEliminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbElementoEliminado.Name = "gpbElementoEliminado";
            this.gpbElementoEliminado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbElementoEliminado.Size = new System.Drawing.Size(267, 148);
            this.gpbElementoEliminado.TabIndex = 19;
            this.gpbElementoEliminado.TabStop = false;
            this.gpbElementoEliminado.Text = "Elemento a eliminar";
            this.gpbElementoEliminado.Enter += new System.EventHandler(this.gpbElementoEliminado_Enter);
            // 
            // cmbArbol
            // 
            this.cmbArbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArbol.FormattingEnabled = true;
            this.cmbArbol.Location = new System.Drawing.Point(91, 37);
            this.cmbArbol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbArbol.Name = "cmbArbol";
            this.cmbArbol.Size = new System.Drawing.Size(160, 24);
            this.cmbArbol.TabIndex = 8;
            this.cmbArbol.SelectedIndexChanged += new System.EventHandler(this.cmbListaDoble_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(45, 78);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodigoEliminado
            // 
            this.lblCodigoEliminado.AutoSize = true;
            this.lblCodigoEliminado.Location = new System.Drawing.Point(25, 42);
            this.lblCodigoEliminado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoEliminado.Name = "lblCodigoEliminado";
            this.lblCodigoEliminado.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoEliminado.TabIndex = 1;
            this.lblCodigoEliminado.Text = "Código:";
            this.lblCodigoEliminado.Click += new System.EventHandler(this.lblCodigoEliminado_Click);
            // 
            // btnEqulibrar
            // 
            this.btnEqulibrar.Location = new System.Drawing.Point(671, 199);
            this.btnEqulibrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEqulibrar.Name = "btnEqulibrar";
            this.btnEqulibrar.Size = new System.Drawing.Size(160, 48);
            this.btnEqulibrar.TabIndex = 20;
            this.btnEqulibrar.Text = "Equilibrar";
            this.btnEqulibrar.UseVisualStyleBackColor = true;
            this.btnEqulibrar.Click += new System.EventHandler(this.btnEqulibrar_Click);
            // 
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 554);
            this.Controls.Add(this.btnEqulibrar);
            this.Controls.Add(this.gpbElementoEliminado);
            this.Controls.Add(this.gpbListadoArbol);
            this.Controls.Add(this.gpbListaSimple);
            this.Controls.Add(this.trvArbol);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmArbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArbol";
            this.Load += new System.EventHandler(this.frmArbol_Load);
            this.gpbListadoArbol.ResumeLayout(false);
            this.gpbListadoArbol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).EndInit();
            this.gpbListaSimple.ResumeLayout(false);
            this.gpbListaSimple.PerformLayout();
            this.gpbElementoEliminado.ResumeLayout(false);
            this.gpbElementoEliminado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvArbol;
        private System.Windows.Forms.GroupBox gpbListadoArbol;
        private System.Windows.Forms.RadioButton rbPreOrden;
        private System.Windows.Forms.RadioButton rbInOrden;
        private System.Windows.Forms.GroupBox gpbListaSimple;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.RadioButton rbPostOrden;
        private System.Windows.Forms.GroupBox gpbElementoEliminado;
        private System.Windows.Forms.ComboBox cmbArbol;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoEliminado;
        private System.Windows.Forms.Button btnEqulibrar;
        private System.Windows.Forms.DataGridView dgvArbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}