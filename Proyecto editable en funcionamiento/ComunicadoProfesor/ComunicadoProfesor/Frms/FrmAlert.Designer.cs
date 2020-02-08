namespace ComunicadoProfesor
{
    partial class FrmAlert
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.BttnClosePanel = new System.Windows.Forms.Button();
            this.LblAlertaComentario = new System.Windows.Forms.Label();
            this.BttnAlertaSi = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.BttnClosePanel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 43);
            this.panel2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ALERTA";
            // 
            // BttnClosePanel
            // 
            this.BttnClosePanel.FlatAppearance.BorderSize = 0;
            this.BttnClosePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnClosePanel.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnClosePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(27)))));
            this.BttnClosePanel.Location = new System.Drawing.Point(206, 1);
            this.BttnClosePanel.Name = "BttnClosePanel";
            this.BttnClosePanel.Size = new System.Drawing.Size(51, 43);
            this.BttnClosePanel.TabIndex = 0;
            this.BttnClosePanel.Text = "X";
            this.BttnClosePanel.UseVisualStyleBackColor = true;
            this.BttnClosePanel.Click += new System.EventHandler(this.BttnClosePanel_Click);
            // 
            // LblAlertaComentario
            // 
            this.LblAlertaComentario.AutoSize = true;
            this.LblAlertaComentario.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlertaComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.LblAlertaComentario.Location = new System.Drawing.Point(33, 67);
            this.LblAlertaComentario.MaximumSize = new System.Drawing.Size(208, 70);
            this.LblAlertaComentario.Name = "LblAlertaComentario";
            this.LblAlertaComentario.Size = new System.Drawing.Size(195, 38);
            this.LblAlertaComentario.TabIndex = 42;
            this.LblAlertaComentario.Text = "No se ha encontrado la base de datos";
            this.LblAlertaComentario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BttnAlertaSi
            // 
            this.BttnAlertaSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.BttnAlertaSi.FlatAppearance.BorderSize = 0;
            this.BttnAlertaSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnAlertaSi.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnAlertaSi.ForeColor = System.Drawing.Color.White;
            this.BttnAlertaSi.Location = new System.Drawing.Point(71, 119);
            this.BttnAlertaSi.Name = "BttnAlertaSi";
            this.BttnAlertaSi.Size = new System.Drawing.Size(117, 43);
            this.BttnAlertaSi.TabIndex = 42;
            this.BttnAlertaSi.Text = "ACEPTAR";
            this.BttnAlertaSi.UseVisualStyleBackColor = false;
            this.BttnAlertaSi.Click += new System.EventHandler(this.BttnAlertaSi_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FrmAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(259, 174);
            this.Controls.Add(this.BttnAlertaSi);
            this.Controls.Add(this.LblAlertaComentario);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlert";
            this.Load += new System.EventHandler(this.FrmAlert_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BttnClosePanel;
        private System.Windows.Forms.Label LblAlertaComentario;
        private System.Windows.Forms.Button BttnAlertaSi;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}