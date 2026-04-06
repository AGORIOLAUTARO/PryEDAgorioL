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
            this.lblNombreMeses.Location = new System.Drawing.Point(81, 31);
            this.lblNombreMeses.Name = "lblNombreMeses";
            this.lblNombreMeses.Size = new System.Drawing.Size(44, 13);
            this.lblNombreMeses.TabIndex = 0;
            this.lblNombreMeses.Text = "Nombre";
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(160, 31);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(100, 20);
            this.txtMeses.TabIndex = 1;
            // 
            // btnListarMeses
            // 
            this.btnListarMeses.Location = new System.Drawing.Point(84, 120);
            this.btnListarMeses.Name = "btnListarMeses";
            this.btnListarMeses.Size = new System.Drawing.Size(75, 23);
            this.btnListarMeses.TabIndex = 2;
            this.btnListarMeses.Text = "Listar";
            this.btnListarMeses.UseVisualStyleBackColor = true;
            // 
            // btnGrabarMeses
            // 
            this.btnGrabarMeses.Location = new System.Drawing.Point(213, 120);
            this.btnGrabarMeses.Name = "btnGrabarMeses";
            this.btnGrabarMeses.Size = new System.Drawing.Size(75, 23);
            this.btnGrabarMeses.TabIndex = 3;
            this.btnGrabarMeses.Text = "Grabar";
            this.btnGrabarMeses.UseVisualStyleBackColor = true;
            this.btnGrabarMeses.Click += new System.EventHandler(this.btnGrabarMeses_Click);
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.Location = new System.Drawing.Point(113, 202);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(147, 95);
            this.lstMeses.TabIndex = 4;
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 391);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.btnGrabarMeses);
            this.Controls.Add(this.btnListarMeses);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.lblNombreMeses);
            this.Name = "frmMeses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMeses";
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