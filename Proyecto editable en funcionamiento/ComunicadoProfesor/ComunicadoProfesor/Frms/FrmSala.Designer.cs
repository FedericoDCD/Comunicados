namespace ComunicadoProfesor
{
    partial class FrmSala
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Bar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BttnClose = new System.Windows.Forms.Button();
            this.DestGVDest = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.LblD = new System.Windows.Forms.Label();
            this.PnlMensaje = new System.Windows.Forms.Panel();
            this.BttnEntendido = new System.Windows.Forms.Button();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblContenido = new System.Windows.Forms.Label();
            this.LblComunicado = new System.Windows.Forms.Label();
            this.LblCreditos = new System.Windows.Forms.Label();
            this.Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DestGVDest)).BeginInit();
            this.PnlMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bar
            // 
            this.Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.Bar.Controls.Add(this.label2);
            this.Bar.Controls.Add(this.BttnClose);
            this.Bar.Location = new System.Drawing.Point(0, 0);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(802, 43);
            this.Bar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SALA DE AVISOS";
            // 
            // BttnClose
            // 
            this.BttnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BttnClose.FlatAppearance.BorderSize = 0;
            this.BttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnClose.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(27)))));
            this.BttnClose.Location = new System.Drawing.Point(751, 0);
            this.BttnClose.Name = "BttnClose";
            this.BttnClose.Size = new System.Drawing.Size(51, 43);
            this.BttnClose.TabIndex = 0;
            this.BttnClose.Text = "X";
            this.BttnClose.UseVisualStyleBackColor = true;
            this.BttnClose.Click += new System.EventHandler(this.BttnClose_Click);
            // 
            // DestGVDest
            // 
            this.DestGVDest.AllowUserToAddRows = false;
            this.DestGVDest.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            this.DestGVDest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DestGVDest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DestGVDest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DestGVDest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.DestGVDest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DestGVDest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DestGVDest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DestGVDest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DestGVDest.DefaultCellStyle = dataGridViewCellStyle12;
            this.DestGVDest.DoubleBuffered = true;
            this.DestGVDest.Enabled = false;
            this.DestGVDest.EnableHeadersVisualStyles = false;
            this.DestGVDest.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.DestGVDest.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.DestGVDest.Location = new System.Drawing.Point(15, 138);
            this.DestGVDest.Name = "DestGVDest";
            this.DestGVDest.ReadOnly = true;
            this.DestGVDest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DestGVDest.Size = new System.Drawing.Size(763, 228);
            this.DestGVDest.TabIndex = 16;
            this.DestGVDest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DestGVDest_CellContentClick);
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.LblD.Location = new System.Drawing.Point(271, 71);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(278, 39);
            this.LblD.TabIndex = 17;
            this.LblD.Text = "FALTAS CON AVISO";
            this.LblD.Click += new System.EventHandler(this.LblD_Click);
            // 
            // PnlMensaje
            // 
            this.PnlMensaje.Controls.Add(this.BttnEntendido);
            this.PnlMensaje.Controls.Add(this.LblAutor);
            this.PnlMensaje.Controls.Add(this.LblFecha);
            this.PnlMensaje.Controls.Add(this.LblContenido);
            this.PnlMensaje.Controls.Add(this.LblComunicado);
            this.PnlMensaje.Location = new System.Drawing.Point(0, 49);
            this.PnlMensaje.Name = "PnlMensaje";
            this.PnlMensaje.Size = new System.Drawing.Size(799, 401);
            this.PnlMensaje.TabIndex = 18;
            this.PnlMensaje.Visible = false;
            this.PnlMensaje.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMensaje_Paint);
            // 
            // BttnEntendido
            // 
            this.BttnEntendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.BttnEntendido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BttnEntendido.FlatAppearance.BorderSize = 0;
            this.BttnEntendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnEntendido.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnEntendido.ForeColor = System.Drawing.Color.White;
            this.BttnEntendido.Location = new System.Drawing.Point(0, 338);
            this.BttnEntendido.Name = "BttnEntendido";
            this.BttnEntendido.Size = new System.Drawing.Size(799, 63);
            this.BttnEntendido.TabIndex = 4;
            this.BttnEntendido.Text = "ENTENDIDO";
            this.BttnEntendido.UseVisualStyleBackColor = false;
            this.BttnEntendido.Click += new System.EventHandler(this.BttnEntendido_Click);
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Font = new System.Drawing.Font("Corbel", 15.25F);
            this.LblAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.LblAutor.Location = new System.Drawing.Point(31, 89);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(87, 26);
            this.LblAutor.TabIndex = 22;
            this.LblAutor.Text = "AUTOR: ";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Corbel", 15.25F);
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.LblFecha.Location = new System.Drawing.Point(682, 89);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(90, 26);
            this.LblFecha.TabIndex = 21;
            this.LblFecha.Text = "2/2/2020";
            // 
            // LblContenido
            // 
            this.LblContenido.AutoSize = true;
            this.LblContenido.Font = new System.Drawing.Font("Corbel", 17.25F);
            this.LblContenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.LblContenido.Location = new System.Drawing.Point(98, 130);
            this.LblContenido.Name = "LblContenido";
            this.LblContenido.Size = new System.Drawing.Size(75, 28);
            this.LblContenido.TabIndex = 20;
            this.LblContenido.Text = "Gaskbl";
            // 
            // LblComunicado
            // 
            this.LblComunicado.AutoSize = true;
            this.LblComunicado.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComunicado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.LblComunicado.Location = new System.Drawing.Point(330, 47);
            this.LblComunicado.Name = "LblComunicado";
            this.LblComunicado.Size = new System.Drawing.Size(219, 39);
            this.LblComunicado.TabIndex = 19;
            this.LblComunicado.Text = "COMUNICADO";
            // 
            // LblCreditos
            // 
            this.LblCreditos.AutoSize = true;
            this.LblCreditos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblCreditos.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreditos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.LblCreditos.Location = new System.Drawing.Point(0, 437);
            this.LblCreditos.Name = "LblCreditos";
            this.LblCreditos.Size = new System.Drawing.Size(216, 13);
            this.LblCreditos.TabIndex = 20;
            this.LblCreditos.Text = "DESARROLLADO POR FEDERICO DE ARMAS";
            // 
            // FrmSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblCreditos);
            this.Controls.Add(this.PnlMensaje);
            this.Controls.Add(this.LblD);
            this.Controls.Add(this.DestGVDest);
            this.Controls.Add(this.Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSala";
            this.Text = "FrmSala";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSala_Load);
            this.Bar.ResumeLayout(false);
            this.Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DestGVDest)).EndInit();
            this.PnlMensaje.ResumeLayout(false);
            this.PnlMensaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Bar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BttnClose;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DestGVDest;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.Panel PnlMensaje;
        private System.Windows.Forms.Label LblContenido;
        private System.Windows.Forms.Label LblComunicado;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Button BttnEntendido;
        private System.Windows.Forms.Label LblCreditos;
    }
}