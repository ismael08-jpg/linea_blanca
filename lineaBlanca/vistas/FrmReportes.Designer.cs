
namespace lineaBlanca.vistas
{
    partial class FrmReportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabCostoVsGanacia = new System.Windows.Forms.TabPage();
            this.tabProductosVendidos = new System.Windows.Forms.TabPage();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.Crvw_Rango = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.Dtp_fin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Dtp_inicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_rangos = new Guna.UI2.WinForms.Guna2Button();
            this.dgbHistorialPago = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Crvw_Disponibles = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_disponibles = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Report_Disponibilidad1 = new lineaBlanca.Reportes.Report_Disponibilidad();
            this.Report_Disponibilidad2 = new lineaBlanca.Reportes.Report_Disponibilidad();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.guna2TabControl1.SuspendLayout();
            this.tabProductosVendidos.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbHistorialPago)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tabCostoVsGanacia);
            this.guna2TabControl1.Controls.Add(this.tabProductosVendidos);
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1022, 573);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 76;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabCostoVsGanacia
            // 
            this.tabCostoVsGanacia.Location = new System.Drawing.Point(4, 44);
            this.tabCostoVsGanacia.Name = "tabCostoVsGanacia";
            this.tabCostoVsGanacia.Padding = new System.Windows.Forms.Padding(3);
            this.tabCostoVsGanacia.Size = new System.Drawing.Size(1014, 525);
            this.tabCostoVsGanacia.TabIndex = 0;
            this.tabCostoVsGanacia.Text = "Costos vs Ganancia";
            this.tabCostoVsGanacia.UseVisualStyleBackColor = true;
            // 
            // tabProductosVendidos
            // 
            this.tabProductosVendidos.Controls.Add(this.guna2Panel4);
            this.tabProductosVendidos.Controls.Add(this.guna2Panel3);
            this.tabProductosVendidos.Controls.Add(this.dgbHistorialPago);
            this.tabProductosVendidos.Location = new System.Drawing.Point(4, 44);
            this.tabProductosVendidos.Name = "tabProductosVendidos";
            this.tabProductosVendidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductosVendidos.Size = new System.Drawing.Size(1014, 525);
            this.tabProductosVendidos.TabIndex = 1;
            this.tabProductosVendidos.Text = "Productos vendidos";
            this.tabProductosVendidos.UseVisualStyleBackColor = true;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.Crvw_Rango);
            this.guna2Panel4.Location = new System.Drawing.Point(247, 6);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(759, 511);
            this.guna2Panel4.TabIndex = 71;
            // 
            // Crvw_Rango
            // 
            this.Crvw_Rango.ActiveViewIndex = -1;
            this.Crvw_Rango.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crvw_Rango.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crvw_Rango.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crvw_Rango.Location = new System.Drawing.Point(0, 0);
            this.Crvw_Rango.Name = "Crvw_Rango";
            this.Crvw_Rango.Size = new System.Drawing.Size(759, 511);
            this.Crvw_Rango.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.maskedTextBox2);
            this.guna2Panel3.Controls.Add(this.maskedTextBox1);
            this.guna2Panel3.Controls.Add(this.Dtp_fin);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.Dtp_inicio);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.btn_rangos);
            this.guna2Panel3.Location = new System.Drawing.Point(8, 6);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(219, 511);
            this.guna2Panel3.TabIndex = 70;
            // 
            // Dtp_fin
            // 
            this.Dtp_fin.CheckedState.Parent = this.Dtp_fin;
            this.Dtp_fin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dtp_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_fin.HoverState.Parent = this.Dtp_fin;
            this.Dtp_fin.Location = new System.Drawing.Point(6, 207);
            this.Dtp_fin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Dtp_fin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Dtp_fin.Name = "Dtp_fin";
            this.Dtp_fin.ShadowDecoration.Parent = this.Dtp_fin;
            this.Dtp_fin.Size = new System.Drawing.Size(200, 36);
            this.Dtp_fin.TabIndex = 4;
            this.Dtp_fin.Value = new System.DateTime(2021, 11, 6, 23, 22, 24, 101);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Fin";
            // 
            // Dtp_inicio
            // 
            this.Dtp_inicio.CheckedState.Parent = this.Dtp_inicio;
            this.Dtp_inicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_inicio.HoverState.Parent = this.Dtp_inicio;
            this.Dtp_inicio.Location = new System.Drawing.Point(6, 109);
            this.Dtp_inicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Dtp_inicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Dtp_inicio.Name = "Dtp_inicio";
            this.Dtp_inicio.ShadowDecoration.Parent = this.Dtp_inicio;
            this.Dtp_inicio.Size = new System.Drawing.Size(196, 36);
            this.Dtp_inicio.TabIndex = 2;
            this.Dtp_inicio.Value = new System.DateTime(2021, 11, 6, 23, 21, 53, 499);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Inicio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_rangos
            // 
            this.btn_rangos.CheckedState.Parent = this.btn_rangos;
            this.btn_rangos.CustomImages.Parent = this.btn_rangos;
            this.btn_rangos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_rangos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_rangos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_rangos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_rangos.DisabledState.Parent = this.btn_rangos;
            this.btn_rangos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btn_rangos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_rangos.ForeColor = System.Drawing.Color.White;
            this.btn_rangos.HoverState.Parent = this.btn_rangos;
            this.btn_rangos.Location = new System.Drawing.Point(3, 12);
            this.btn_rangos.Name = "btn_rangos";
            this.btn_rangos.ShadowDecoration.Parent = this.btn_rangos;
            this.btn_rangos.Size = new System.Drawing.Size(194, 45);
            this.btn_rangos.TabIndex = 0;
            this.btn_rangos.Text = "Ver Reporte";
            this.btn_rangos.Click += new System.EventHandler(this.btn_rangos_Click);
            // 
            // dgbHistorialPago
            // 
            this.dgbHistorialPago.AllowUserToAddRows = false;
            this.dgbHistorialPago.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgbHistorialPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgbHistorialPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbHistorialPago.BackgroundColor = System.Drawing.Color.White;
            this.dgbHistorialPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbHistorialPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgbHistorialPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbHistorialPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgbHistorialPago.ColumnHeadersHeight = 25;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgbHistorialPago.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgbHistorialPago.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgbHistorialPago.EnableHeadersVisualStyles = false;
            this.dgbHistorialPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgbHistorialPago.Location = new System.Drawing.Point(50, 115);
            this.dgbHistorialPago.Name = "dgbHistorialPago";
            this.dgbHistorialPago.ReadOnly = true;
            this.dgbHistorialPago.RowHeadersVisible = false;
            this.dgbHistorialPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbHistorialPago.Size = new System.Drawing.Size(859, 365);
            this.dgbHistorialPago.TabIndex = 65;
            this.dgbHistorialPago.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgbHistorialPago.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgbHistorialPago.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgbHistorialPago.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgbHistorialPago.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgbHistorialPago.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgbHistorialPago.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgbHistorialPago.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgbHistorialPago.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgbHistorialPago.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgbHistorialPago.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgbHistorialPago.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgbHistorialPago.ThemeStyle.HeaderStyle.Height = 25;
            this.dgbHistorialPago.ThemeStyle.ReadOnly = true;
            this.dgbHistorialPago.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgbHistorialPago.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgbHistorialPago.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgbHistorialPago.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgbHistorialPago.ThemeStyle.RowsStyle.Height = 22;
            this.dgbHistorialPago.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgbHistorialPago.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.guna2Panel2);
            this.tabPage1.Controls.Add(this.guna2Panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1014, 525);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Productos disponibles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.Crvw_Disponibles);
            this.guna2Panel2.Location = new System.Drawing.Point(214, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(792, 514);
            this.guna2Panel2.TabIndex = 1;
            // 
            // Crvw_Disponibles
            // 
            this.Crvw_Disponibles.ActiveViewIndex = -1;
            this.Crvw_Disponibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crvw_Disponibles.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crvw_Disponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crvw_Disponibles.Location = new System.Drawing.Point(0, 0);
            this.Crvw_Disponibles.Name = "Crvw_Disponibles";
            this.Crvw_Disponibles.Size = new System.Drawing.Size(792, 514);
            this.Crvw_Disponibles.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btn_disponibles);
            this.guna2Panel1.Location = new System.Drawing.Point(8, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(200, 514);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ver Reporte";
            // 
            // btn_disponibles
            // 
            this.btn_disponibles.CheckedState.Parent = this.btn_disponibles;
            this.btn_disponibles.CustomImages.Parent = this.btn_disponibles;
            this.btn_disponibles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_disponibles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_disponibles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_disponibles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_disponibles.DisabledState.Parent = this.btn_disponibles;
            this.btn_disponibles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btn_disponibles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_disponibles.ForeColor = System.Drawing.Color.White;
            this.btn_disponibles.HoverState.Parent = this.btn_disponibles;
            this.btn_disponibles.Location = new System.Drawing.Point(3, 75);
            this.btn_disponibles.Name = "btn_disponibles";
            this.btn_disponibles.ShadowDecoration.Parent = this.btn_disponibles;
            this.btn_disponibles.Size = new System.Drawing.Size(194, 45);
            this.btn_disponibles.TabIndex = 0;
            this.btn_disponibles.Text = "Ver Reporte";
            this.btn_disponibles.Click += new System.EventHandler(this.btn_disponibles_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1014, 525);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Pagos pendientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(18, 263);
            this.maskedTextBox1.Mask = "0000/00/00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(18, 308);
            this.maskedTextBox2.Mask = "0000/00/00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 6;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 573);
            this.Controls.Add(this.guna2TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportes";
            this.guna2TabControl1.ResumeLayout(false);
            this.tabProductosVendidos.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbHistorialPago)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabCostoVsGanacia;
        private System.Windows.Forms.TabPage tabProductosVendidos;
        private Guna.UI2.WinForms.Guna2DataGridView dgbHistorialPago;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crvw_Disponibles;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_disponibles;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_rangos;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crvw_Rango;
        private Guna.UI2.WinForms.Guna2DateTimePicker Dtp_fin;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker Dtp_inicio;
        private Reportes.Report_Disponibilidad Report_Disponibilidad1;
        private Reportes.Report_Disponibilidad Report_Disponibilidad2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}