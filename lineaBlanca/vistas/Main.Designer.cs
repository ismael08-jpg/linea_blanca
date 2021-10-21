
namespace lineaBlanca.vistas
{
    partial class Main
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
            this.principalPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.sidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnProductos = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreditos = new Guna.UI2.WinForms.Guna2Button();
            this.btnPagos = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.dashboardView1 = new lineaBlanca.vistas.DashboardView();
            this.productoView1 = new lineaBlanca.vistas.ProductoView();
            this.creditoView1 = new lineaBlanca.vistas.CreditoView();
            this.principalPanel.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // principalPanel
            // 
            this.principalPanel.Controls.Add(this.dashboardView1);
            this.principalPanel.Controls.Add(this.creditoView1);
            this.principalPanel.Controls.Add(this.productoView1);
            this.principalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.principalPanel.Location = new System.Drawing.Point(179, 0);
            this.principalPanel.Name = "principalPanel";
            this.principalPanel.ShadowDecoration.Parent = this.principalPanel;
            this.principalPanel.Size = new System.Drawing.Size(757, 534);
            this.principalPanel.TabIndex = 3;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.sidebar.Controls.Add(this.btnProductos);
            this.sidebar.Controls.Add(this.btnCreditos);
            this.sidebar.Controls.Add(this.btnPagos);
            this.sidebar.Controls.Add(this.btnDashboard);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.ShadowDecoration.Parent = this.sidebar;
            this.sidebar.Size = new System.Drawing.Size(179, 534);
            this.sidebar.TabIndex = 2;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Snow;
            this.btnProductos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProductos.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnProductos.CheckedState.Parent = this.btnProductos;
            this.btnProductos.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProductos.CustomImages.Parent = this.btnProductos;
            this.btnProductos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductos.DisabledState.Parent = this.btnProductos;
            this.btnProductos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btnProductos.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.HoverState.Parent = this.btnProductos;
            this.btnProductos.Location = new System.Drawing.Point(0, 125);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnProductos.PressedDepth = 0;
            this.btnProductos.ShadowDecoration.Parent = this.btnProductos;
            this.btnProductos.Size = new System.Drawing.Size(180, 45);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProductos.CheckedChanged += new System.EventHandler(this.btnProductos_CheckedChanged);
            // 
            // btnCreditos
            // 
            this.btnCreditos.BackColor = System.Drawing.Color.Snow;
            this.btnCreditos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCreditos.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnCreditos.CheckedState.Parent = this.btnCreditos;
            this.btnCreditos.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCreditos.CustomImages.Parent = this.btnCreditos;
            this.btnCreditos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreditos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreditos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreditos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreditos.DisabledState.Parent = this.btnCreditos;
            this.btnCreditos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btnCreditos.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.ForeColor = System.Drawing.Color.White;
            this.btnCreditos.HoverState.Parent = this.btnCreditos;
            this.btnCreditos.Location = new System.Drawing.Point(0, 84);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnCreditos.PressedDepth = 0;
            this.btnCreditos.ShadowDecoration.Parent = this.btnCreditos;
            this.btnCreditos.Size = new System.Drawing.Size(180, 45);
            this.btnCreditos.TabIndex = 2;
            this.btnCreditos.Text = "Créditos";
            this.btnCreditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCreditos.CheckedChanged += new System.EventHandler(this.btnCreditos_CheckedChanged);
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.Snow;
            this.btnPagos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPagos.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnPagos.CheckedState.Parent = this.btnPagos;
            this.btnPagos.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPagos.CustomImages.Parent = this.btnPagos;
            this.btnPagos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPagos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPagos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPagos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPagos.DisabledState.Parent = this.btnPagos;
            this.btnPagos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btnPagos.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.White;
            this.btnPagos.HoverState.Parent = this.btnPagos;
            this.btnPagos.Location = new System.Drawing.Point(0, 42);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnPagos.PressedDepth = 0;
            this.btnPagos.ShadowDecoration.Parent = this.btnPagos;
            this.btnPagos.Size = new System.Drawing.Size(180, 45);
            this.btnPagos.TabIndex = 1;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPagos.CheckedChanged += new System.EventHandler(this.BtnPagos_CheckedChanged);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Snow;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.Checked = true;
            this.btnDashboard.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.DisabledState.Parent = this.btnDashboard;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btnDashboard.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnDashboard.PressedDepth = 0;
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(179, 45);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.CheckedChanged += new System.EventHandler(this.btnDashboard_CheckedChanged);
            // 
            // dashboardView1
            // 
            this.dashboardView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardView1.Location = new System.Drawing.Point(0, 0);
            this.dashboardView1.Name = "dashboardView1";
            this.dashboardView1.Size = new System.Drawing.Size(757, 534);
            this.dashboardView1.TabIndex = 0;
            this.dashboardView1.Load += new System.EventHandler(this.dashboardView1_Load);
            // 
            // productoView1
            // 
            this.productoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productoView1.Location = new System.Drawing.Point(0, 0);
            this.productoView1.Name = "productoView1";
            this.productoView1.Size = new System.Drawing.Size(757, 534);
            this.productoView1.TabIndex = 1;
            this.productoView1.Load += new System.EventHandler(this.productoView1_Load);
            // 
            // creditoView1
            // 
            this.creditoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creditoView1.Location = new System.Drawing.Point(0, 0);
            this.creditoView1.Name = "creditoView1";
            this.creditoView1.Size = new System.Drawing.Size(757, 534);
            this.creditoView1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 534);
            this.Controls.Add(this.principalPanel);
            this.Controls.Add(this.sidebar);
            this.Name = "Main";
            this.Text = "Main";
            this.principalPanel.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel principalPanel;
        private Guna.UI2.WinForms.Guna2Panel sidebar;
        private Guna.UI2.WinForms.Guna2Button btnProductos;
        private Guna.UI2.WinForms.Guna2Button btnCreditos;
        private Guna.UI2.WinForms.Guna2Button btnPagos;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private CreditoView creditoView1;
        private ProductoView productoView1;
        private DashboardView dashboardView1;
    }
}