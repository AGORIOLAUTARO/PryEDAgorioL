namespace PryEDAgorioL
{
    partial class frmMeses
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
            this.lblNombreMeses = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.btnListarMeses = new System.Windows.Forms.Button();
            this.btnGrabarMeses = new System.Windows.Forms.Button();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNombreMeses
            // 
            this.lblNombreMeses.AutoSize = true;
            this.lblNombreMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMeses.Location = new System.Drawing.Point(62, 46);
            this.lblNombreMeses.Name = "lblNombreMeses";
            this.lblNombreMeses.Size = new System.Drawing.Size(69, 20);
            this.lblNombreMeses.TabIndex = 0;
            this.lblNombreMeses.Text = "Nombre:";
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(160, 46);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(100, 20);
            this.txtMeses.TabIndex = 1;
            // 
            // btnListarMeses
            // 
            this.btnListarMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarMeses.Location = new System.Drawing.Point(38, 120);
            this.btnListarMeses.Name = "btnListarMeses";
            this.btnListarMeses.Size = new System.Drawing.Size(93, 44);
            this.btnListarMeses.TabIndex = 2;
            this.btnListarMeses.Text = "Limpiar";
            this.btnListarMeses.UseVisualStyleBackColor = true;
            this.btnListarMeses.Click += new System.EventHandler(this.btnListarMeses_Click);
            // 
            // btnGrabarMeses
            // 
            this.btnGrabarMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabarMeses.Location = new System.Drawing.Point(170, 120);
            this.btnGrabarMeses.Name = "btnGrabarMeses";
            this.btnGrabarMeses.Size = new System.Drawing.Size(99, 44);
            this.btnGrabarMeses.TabIndex = 3;
            this.btnGrabarMeses.Text = "Grabar";
            this.btnGrabarMeses.UseVisualStyleBackColor = true;
            this.btnGrabarMeses.Click += new System.EventHandler(this.btnGrabarMeses_Click);
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.Location = new System.Drawing.Point(79, 201);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(147, 95);
            this.lstMeses.TabIndex = 4;
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 347);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.btnGrabarMeses);
            this.Controls.Add(this.btnListarMeses);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.lblNombreMeses);
            this.Name = "frmMeses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreMeses;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Button btnListarMeses;
        private System.Windows.Forms.Button btnGrabarMeses;
        private System.Windows.Forms.ListBox lstMeses;
    }
}