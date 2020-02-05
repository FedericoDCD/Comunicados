namespace ComunicadoProfesor
{
    partial class FrmFuncionario
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
            this.Bar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BttnClose = new System.Windows.Forms.Button();
            this.LblVCurso = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.TxtFaltaCurso = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BttnAFalta = new System.Windows.Forms.Button();
            this.LblVProfesor = new System.Windows.Forms.Label();
            this.TxtFaltaProfesor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblVMensaje = new System.Windows.Forms.Label();
            this.TxtMensaje = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BttnAComunicado = new System.Windows.Forms.Button();
            this.LblVAutor = new System.Windows.Forms.Label();
            this.TxtAutor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblNom = new System.Windows.Forms.Label();
            this.BttnCFalta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DTPFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PnlAlert = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.BttnClosePanel = new System.Windows.Forms.Button();
            this.LblAlertaComentario = new System.Windows.Forms.Label();
            this.BttnAlertaNo = new System.Windows.Forms.Button();
            this.BttnAlertaSi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Bar.SuspendLayout();
            this.PnlAlert.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bar
            // 
            this.Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.Bar.Controls.Add(this.label2);
            this.Bar.Controls.Add(this.BttnClose);
            this.Bar.Location = new System.Drawing.Point(0, 0);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(657, 43);
            this.Bar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SALA DE CONTROL";
            // 
            // BttnClose
            // 
            this.BttnClose.FlatAppearance.BorderSize = 0;
            this.BttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnClose.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(27)))));
            this.BttnClose.Location = new System.Drawing.Point(594, 0);
            this.BttnClose.Name = "BttnClose";
            this.BttnClose.Size = new System.Drawing.Size(51, 43);
            this.BttnClose.TabIndex = 0;
            this.BttnClose.Text = "X";
            this.BttnClose.UseVisualStyleBackColor = true;
            this.BttnClose.Click += new System.EventHandler(this.BttnClose_Click);
            // 
            // LblVCurso
            // 
            this.LblVCurso.AutoSize = true;
            this.LblVCurso.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.LblVCurso.Location = new System.Drawing.Point(280, 235);
            this.LblVCurso.Name = "LblVCurso";
            this.LblVCurso.Size = new System.Drawing.Size(18, 19);
            this.LblVCurso.TabIndex = 27;
            this.LblVCurso.Text = "*";
            this.LblVCurso.Visible = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.bunifuSeparator2.LineThickness = 4;
            this.bunifuSeparator2.Location = new System.Drawing.Point(313, 73);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(18, 356);
            this.bunifuSeparator2.TabIndex = 26;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // TxtFaltaCurso
            // 
            this.TxtFaltaCurso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFaltaCurso.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFaltaCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtFaltaCurso.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtFaltaCurso.HintText = "Curso ";
            this.TxtFaltaCurso.isPassword = false;
            this.TxtFaltaCurso.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtFaltaCurso.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtFaltaCurso.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtFaltaCurso.LineThickness = 2;
            this.TxtFaltaCurso.Location = new System.Drawing.Point(28, 218);
            this.TxtFaltaCurso.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFaltaCurso.Name = "TxtFaltaCurso";
            this.TxtFaltaCurso.Size = new System.Drawing.Size(244, 36);
            this.TxtFaltaCurso.TabIndex = 3;
            this.TxtFaltaCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtFaltaCurso.Enter += new System.EventHandler(this.TxtFaltaCurso_Enter);
            this.TxtFaltaCurso.Leave += new System.EventHandler(this.TxtFaltaCurso_Leave);
            // 
            // BttnAFalta
            // 
            this.BttnAFalta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.BttnAFalta.FlatAppearance.BorderSize = 0;
            this.BttnAFalta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnAFalta.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnAFalta.ForeColor = System.Drawing.Color.White;
            this.BttnAFalta.Location = new System.Drawing.Point(28, 282);
            this.BttnAFalta.Name = "BttnAFalta";
            this.BttnAFalta.Size = new System.Drawing.Size(244, 47);
            this.BttnAFalta.TabIndex = 0;
            this.BttnAFalta.Text = "AGREGAR FALTA";
            this.BttnAFalta.UseVisualStyleBackColor = false;
            this.BttnAFalta.Click += new System.EventHandler(this.BttnAFalta_Click);
            // 
            // LblVProfesor
            // 
            this.LblVProfesor.AutoSize = true;
            this.LblVProfesor.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVProfesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.LblVProfesor.Location = new System.Drawing.Point(280, 175);
            this.LblVProfesor.Name = "LblVProfesor";
            this.LblVProfesor.Size = new System.Drawing.Size(18, 19);
            this.LblVProfesor.TabIndex = 30;
            this.LblVProfesor.Text = "*";
            this.LblVProfesor.Visible = false;
            // 
            // TxtFaltaProfesor
            // 
            this.TxtFaltaProfesor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFaltaProfesor.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFaltaProfesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtFaltaProfesor.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtFaltaProfesor.HintText = "Profesor";
            this.TxtFaltaProfesor.isPassword = false;
            this.TxtFaltaProfesor.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtFaltaProfesor.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtFaltaProfesor.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtFaltaProfesor.LineThickness = 2;
            this.TxtFaltaProfesor.Location = new System.Drawing.Point(28, 158);
            this.TxtFaltaProfesor.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFaltaProfesor.Name = "TxtFaltaProfesor";
            this.TxtFaltaProfesor.Size = new System.Drawing.Size(244, 36);
            this.TxtFaltaProfesor.TabIndex = 2;
            this.TxtFaltaProfesor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtFaltaProfesor.OnValueChanged += new System.EventHandler(this.TxtFaltaProfesor_OnValueChanged);
            this.TxtFaltaProfesor.Enter += new System.EventHandler(this.TxtFaltaProfesor_Enter);
            this.TxtFaltaProfesor.Leave += new System.EventHandler(this.TxtFaltaProfesor_Leave);
            // 
            // LblVMensaje
            // 
            this.LblVMensaje.AutoSize = true;
            this.LblVMensaje.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.LblVMensaje.Location = new System.Drawing.Point(607, 235);
            this.LblVMensaje.Name = "LblVMensaje";
            this.LblVMensaje.Size = new System.Drawing.Size(18, 19);
            this.LblVMensaje.TabIndex = 33;
            this.LblVMensaje.Text = "*";
            this.LblVMensaje.Visible = false;
            // 
            // TxtMensaje
            // 
            this.TxtMensaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMensaje.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtMensaje.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtMensaje.HintText = "Mensaje ";
            this.TxtMensaje.isPassword = false;
            this.TxtMensaje.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtMensaje.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtMensaje.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtMensaje.LineThickness = 2;
            this.TxtMensaje.Location = new System.Drawing.Point(356, 218);
            this.TxtMensaje.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMensaje.Name = "TxtMensaje";
            this.TxtMensaje.Size = new System.Drawing.Size(244, 36);
            this.TxtMensaje.TabIndex = 8;
            this.TxtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtMensaje.Enter += new System.EventHandler(this.TxtMensaje_Enter);
            this.TxtMensaje.Leave += new System.EventHandler(this.TxtMensaje_Leave);
            // 
            // BttnAComunicado
            // 
            this.BttnAComunicado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.BttnAComunicado.FlatAppearance.BorderSize = 0;
            this.BttnAComunicado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnAComunicado.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnAComunicado.ForeColor = System.Drawing.Color.White;
            this.BttnAComunicado.Location = new System.Drawing.Point(356, 346);
            this.BttnAComunicado.Name = "BttnAComunicado";
            this.BttnAComunicado.Size = new System.Drawing.Size(244, 47);
            this.BttnAComunicado.TabIndex = 31;
            this.BttnAComunicado.Text = "COMUNICAR";
            this.BttnAComunicado.UseVisualStyleBackColor = false;
            this.BttnAComunicado.Click += new System.EventHandler(this.BttnAComunicado_Click);
            // 
            // LblVAutor
            // 
            this.LblVAutor.AutoSize = true;
            this.LblVAutor.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.LblVAutor.Location = new System.Drawing.Point(607, 175);
            this.LblVAutor.Name = "LblVAutor";
            this.LblVAutor.Size = new System.Drawing.Size(18, 19);
            this.LblVAutor.TabIndex = 35;
            this.LblVAutor.Text = "*";
            this.LblVAutor.Visible = false;
            // 
            // TxtAutor
            // 
            this.TxtAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAutor.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtAutor.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtAutor.HintText = "Autor";
            this.TxtAutor.isPassword = false;
            this.TxtAutor.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtAutor.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtAutor.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtAutor.LineThickness = 2;
            this.TxtAutor.Location = new System.Drawing.Point(356, 158);
            this.TxtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(244, 36);
            this.TxtAutor.TabIndex = 7;
            this.TxtAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtAutor.Enter += new System.EventHandler(this.TxtAutor_Enter);
            this.TxtAutor.Leave += new System.EventHandler(this.TxtAutor_Leave);
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.LblNom.Location = new System.Drawing.Point(125, 87);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(59, 19);
            this.LblNom.TabIndex = 36;
            this.LblNom.Text = "FALTAS";
            // 
            // BttnCFalta
            // 
            this.BttnCFalta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.BttnCFalta.FlatAppearance.BorderSize = 0;
            this.BttnCFalta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnCFalta.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnCFalta.ForeColor = System.Drawing.Color.White;
            this.BttnCFalta.Location = new System.Drawing.Point(28, 346);
            this.BttnCFalta.Name = "BttnCFalta";
            this.BttnCFalta.Size = new System.Drawing.Size(244, 47);
            this.BttnCFalta.TabIndex = 37;
            this.BttnCFalta.Text = "LIMPIAR FALTAS";
            this.BttnCFalta.UseVisualStyleBackColor = false;
            this.BttnCFalta.Click += new System.EventHandler(this.BttnCFalta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.label4.Location = new System.Drawing.Point(417, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "COMUNICADOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.label6.Location = new System.Drawing.Point(350, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "Fecha:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // DTPFecha
            // 
            this.DTPFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.DTPFecha.BorderRadius = 0;
            this.DTPFecha.ForeColor = System.Drawing.Color.White;
            this.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTPFecha.FormatCustom = null;
            this.DTPFecha.Location = new System.Drawing.Point(413, 276);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(187, 53);
            this.DTPFecha.TabIndex = 39;
            this.DTPFecha.Value = new System.DateTime(2020, 2, 1, 0, 0, 0, 0);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Bar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PnlAlert
            // 
            this.PnlAlert.Controls.Add(this.panel2);
            this.PnlAlert.Controls.Add(this.LblAlertaComentario);
            this.PnlAlert.Controls.Add(this.BttnAlertaNo);
            this.PnlAlert.Controls.Add(this.BttnAlertaSi);
            this.PnlAlert.Location = new System.Drawing.Point(194, 158);
            this.PnlAlert.Name = "PnlAlert";
            this.PnlAlert.Size = new System.Drawing.Size(258, 171);
            this.PnlAlert.TabIndex = 41;
            this.PnlAlert.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.BttnClosePanel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 43);
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
            this.LblAlertaComentario.Location = new System.Drawing.Point(25, 58);
            this.LblAlertaComentario.MaximumSize = new System.Drawing.Size(208, 70);
            this.LblAlertaComentario.Name = "LblAlertaComentario";
            this.LblAlertaComentario.Size = new System.Drawing.Size(203, 38);
            this.LblAlertaComentario.TabIndex = 42;
            this.LblAlertaComentario.Text = "¿Seguro que desea agregar la falta?";
            this.LblAlertaComentario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblAlertaComentario.Click += new System.EventHandler(this.label5_Click);
            // 
            // BttnAlertaNo
            // 
            this.BttnAlertaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.BttnAlertaNo.FlatAppearance.BorderSize = 0;
            this.BttnAlertaNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnAlertaNo.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnAlertaNo.ForeColor = System.Drawing.Color.White;
            this.BttnAlertaNo.Location = new System.Drawing.Point(144, 118);
            this.BttnAlertaNo.Name = "BttnAlertaNo";
            this.BttnAlertaNo.Size = new System.Drawing.Size(85, 43);
            this.BttnAlertaNo.TabIndex = 43;
            this.BttnAlertaNo.Text = "NO";
            this.BttnAlertaNo.UseVisualStyleBackColor = false;
            this.BttnAlertaNo.Click += new System.EventHandler(this.button4_Click);
            // 
            // BttnAlertaSi
            // 
            this.BttnAlertaSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.BttnAlertaSi.FlatAppearance.BorderSize = 0;
            this.BttnAlertaSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnAlertaSi.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnAlertaSi.ForeColor = System.Drawing.Color.White;
            this.BttnAlertaSi.Location = new System.Drawing.Point(29, 118);
            this.BttnAlertaSi.Name = "BttnAlertaSi";
            this.BttnAlertaSi.Size = new System.Drawing.Size(85, 43);
            this.BttnAlertaSi.TabIndex = 42;
            this.BttnAlertaSi.Text = "SÍ";
            this.BttnAlertaSi.UseVisualStyleBackColor = false;
            this.BttnAlertaSi.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(220, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "DESARROLLADO POR FEDERICO DE ARMAS";
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(645, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlAlert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BttnCFalta);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.LblVAutor);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.LblVMensaje);
            this.Controls.Add(this.TxtMensaje);
            this.Controls.Add(this.BttnAComunicado);
            this.Controls.Add(this.LblVProfesor);
            this.Controls.Add(this.TxtFaltaProfesor);
            this.Controls.Add(this.BttnAFalta);
            this.Controls.Add(this.LblVCurso);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.TxtFaltaCurso);
            this.Controls.Add(this.Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFuncionario";
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            this.Bar.ResumeLayout(false);
            this.Bar.PerformLayout();
            this.PnlAlert.ResumeLayout(false);
            this.PnlAlert.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Bar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BttnClose;
        private System.Windows.Forms.Label LblVCurso;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtFaltaCurso;
        private System.Windows.Forms.Button BttnAFalta;
        private System.Windows.Forms.Label LblVProfesor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtFaltaProfesor;
        private System.Windows.Forms.Label LblVMensaje;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtMensaje;
        private System.Windows.Forms.Button BttnAComunicado;
        private System.Windows.Forms.Label LblVAutor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtAutor;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Button BttnCFalta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDatepicker DTPFecha;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel PnlAlert;
        private System.Windows.Forms.Label LblAlertaComentario;
        private System.Windows.Forms.Button BttnAlertaNo;
        private System.Windows.Forms.Button BttnAlertaSi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BttnClosePanel;
        private System.Windows.Forms.Label label1;
    }
}