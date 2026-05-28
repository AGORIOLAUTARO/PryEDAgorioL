namespace PryEDAgorioL
{
    partial class frmConsultaBaseDeDatos
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
            this.lblConsulta = new System.Windows.Forms.Label();
            this.btnListarSQL = new System.Windows.Forms.Button();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCtaSql = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaSql)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(-8, -23);
            this.lblConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(216, 29);
            this.lblConsulta.TabIndex = 19;
            this.lblConsulta.Text = "Consulta en SQL:";
            // 
            // btnListarSQL
            // 
            this.btnListarSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarSQL.Location = new System.Drawing.Point(769, 224);
            this.btnListarSQL.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarSQL.Name = "btnListarSQL";
            this.btnListarSQL.Size = new System.Drawing.Size(105, 34);
            this.btnListarSQL.TabIndex = 23;
            this.btnListarSQL.Text = "Listar";
            this.btnListarSQL.UseVisualStyleBackColor = true;
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(58, 41);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(816, 168);
            this.txtSQL.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Consulta en SQL:";
            // 
            // dgvCtaSql
            // 
            this.dgvCtaSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtaSql.Location = new System.Drawing.Point(58, 266);
            this.dgvCtaSql.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCtaSql.Name = "dgvCtaSql";
            this.dgvCtaSql.RowHeadersVisible = false;
            this.dgvCtaSql.RowHeadersWidth = 51;
            this.dgvCtaSql.Size = new System.Drawing.Size(816, 239);
            this.dgvCtaSql.TabIndex = 20;
            // 
            // frmConsultaBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 530);
            this.Controls.Add(this.btnListarSQL);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCtaSql);
            this.Controls.Add(this.lblConsulta);
            this.Name = "frmConsultaBaseDeDatos";
            this.Text = "frmConsultaBaseDeDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaSql)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Button btnListarSQL;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCtaSql;
    }
}