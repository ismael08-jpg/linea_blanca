
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabCostoVsGanacia = new System.Windows.Forms.TabPage();
            this.tabProductosVendidos = new System.Windows.Forms.TabPage();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboHistorialCredito = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboHistorialCliente = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgbHistorialPago = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guna2TabControl1.SuspendLayout();
            this.tabProductosVendidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbHistorialPago)).BeginInit();
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
            this.tabProductosVendidos.Controls.Add(this.guna2HtmlLabel8);
            this.tabProductosVendidos.Controls.Add(this.comboHistorialCredito);
            this.tabProductosVendidos.Controls.Add(this.guna2HtmlLabel7);
            this.tabProductosVendidos.Controls.Add(this.comboHistorialCliente);
            this.tabProductosVendidos.Controls.Add(this.dgbHistorialPago);
            this.tabProductosVendidos.Location = new System.Drawing.Point(4, 44);
            this.tabProductosVendidos.Name = "tabProductosVendidos";
            this.tabProductosVendidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductosVendidos.Size = new System.Drawing.Size(1014, 525);
            this.tabProductosVendidos.TabIndex = 1;
            this.tabProductosVendidos.Text = "Productos vendidos";
            this.tabProductosVendidos.UseVisualStyleBackColor = true;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(536, 35);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(133, 21);
            this.guna2HtmlLabel8.TabIndex = 69;
            this.guna2HtmlLabel8.Text = "Créditos según fecha";
            // 
            // comboHistorialCredito
            // 
            this.comboHistorialCredito.BackColor = System.Drawing.Color.Transparent;
            this.comboHistorialCredito.BorderRadius = 5;
            this.comboHistorialCredito.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboHistorialCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHistorialCredito.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboHistorialCredito.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboHistorialCredito.FocusedState.Parent = this.comboHistorialCredito;
            this.comboHistorialCredito.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.comboHistorialCredito.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboHistorialCredito.HoverState.Parent = this.comboHistorialCredito;
            this.comboHistorialCredito.ItemHeight = 20;
            this.comboHistorialCredito.ItemsAppearance.Parent = this.comboHistorialCredito;
            this.comboHistorialCredito.Location = new System.Drawing.Point(536, 62);
            this.comboHistorialCredito.Name = "comboHistorialCredito";
            this.comboHistorialCredito.ShadowDecoration.Parent = this.comboHistorialCredito;
            this.comboHistorialCredito.Size = new System.Drawing.Size(373, 26);
            this.comboHistorialCredito.TabIndex = 68;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(50, 35);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(45, 21);
            this.guna2HtmlLabel7.TabIndex = 67;
            this.guna2HtmlLabel7.Text = "Cliente";
            // 
            // comboHistorialCliente
            // 
            this.comboHistorialCliente.BackColor = System.Drawing.Color.Transparent;
            this.comboHistorialCliente.BorderRadius = 5;
            this.comboHistorialCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboHistorialCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHistorialCliente.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboHistorialCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboHistorialCliente.FocusedState.Parent = this.comboHistorialCliente;
            this.comboHistorialCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.comboHistorialCliente.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboHistorialCliente.HoverState.Parent = this.comboHistorialCliente;
            this.comboHistorialCliente.ItemHeight = 20;
            this.comboHistorialCliente.ItemsAppearance.Parent = this.comboHistorialCliente;
            this.comboHistorialCliente.Location = new System.Drawing.Point(50, 62);
            this.comboHistorialCliente.Name = "comboHistorialCliente";
            this.comboHistorialCliente.ShadowDecoration.Parent = this.comboHistorialCliente;
            this.comboHistorialCliente.Size = new System.Drawing.Size(373, 26);
            this.comboHistorialCliente.TabIndex = 66;
            // 
            // dgbHistorialPago
            // 
            this.dgbHistorialPago.AllowUserToAddRows = false;
            this.dgbHistorialPago.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgbHistorialPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgbHistorialPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbHistorialPago.BackgroundColor = System.Drawing.Color.White;
            this.dgbHistorialPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbHistorialPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgbHistorialPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbHistorialPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgbHistorialPago.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgbHistorialPago.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1014, 525);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Productos disponibles";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabProductosVendidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbHistorialPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabCostoVsGanacia;
        private System.Windows.Forms.TabPage tabProductosVendidos;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2ComboBox comboHistorialCredito;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2ComboBox comboHistorialCliente;
        private Guna.UI2.WinForms.Guna2DataGridView dgbHistorialPago;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}