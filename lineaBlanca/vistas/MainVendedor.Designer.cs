
namespace lineaBlanca.vistas
{
    partial class MainVendedor
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
            this.sidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClientes = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreditos = new Guna.UI2.WinForms.Guna2Button();
            this.btnPagos = new Guna.UI2.WinForms.Guna2Button();
            this.btnInicio = new Guna.UI2.WinForms.Guna2Button();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.sidebar.Controls.Add(this.btnClientes);
            this.sidebar.Controls.Add(this.btnCreditos);
            this.sidebar.Controls.Add(this.btnPagos);
            this.sidebar.Controls.Add(this.btnInicio);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.ShadowDecoration.Parent = this.sidebar;
            this.sidebar.Size = new System.Drawing.Size(179, 577);
            this.sidebar.TabIndex = 2;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Snow;
            this.btnClientes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnClientes.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnClientes.CheckedState.Image = global::lineaBlanca.Properties.Resources.customer;
            this.btnClientes.CheckedState.Parent = this.btnClientes;
            this.btnClientes.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClientes.CustomImages.Parent = this.btnClientes;
            this.btnClientes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClientes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClientes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClientes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClientes.DisabledState.Parent = this.btnClientes;
            this.btnClientes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btnClientes.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.HoverState.Parent = this.btnClientes;
            this.btnClientes.Image = global::lineaBlanca.Properties.Resources.customer__1_;
            this.btnClientes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClientes.Location = new System.Drawing.Point(0, 135);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnClientes.PressedDepth = 0;
            this.btnClientes.ShadowDecoration.Parent = this.btnClientes;
            this.btnClientes.Size = new System.Drawing.Size(180, 45);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.BackColor = System.Drawing.Color.Snow;
            this.btnCreditos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCreditos.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnCreditos.CheckedState.Image = global::lineaBlanca.Properties.Resources.credit_card;
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
            this.btnCreditos.Image = global::lineaBlanca.Properties.Resources.credit_card__1_;
            this.btnCreditos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCreditos.Location = new System.Drawing.Point(0, 90);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnCreditos.PressedDepth = 0;
            this.btnCreditos.ShadowDecoration.Parent = this.btnCreditos;
            this.btnCreditos.Size = new System.Drawing.Size(180, 45);
            this.btnCreditos.TabIndex = 2;
            this.btnCreditos.Text = "Créditos";
            this.btnCreditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.Snow;
            this.btnPagos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPagos.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnPagos.CheckedState.Image = global::lineaBlanca.Properties.Resources.money;
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
            this.btnPagos.Image = global::lineaBlanca.Properties.Resources.money__1_;
            this.btnPagos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPagos.Location = new System.Drawing.Point(0, 45);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnPagos.PressedDepth = 0;
            this.btnPagos.ShadowDecoration.Parent = this.btnPagos;
            this.btnPagos.Size = new System.Drawing.Size(180, 45);
            this.btnPagos.TabIndex = 1;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Snow;
            this.btnInicio.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInicio.Checked = true;
            this.btnInicio.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnInicio.CheckedState.Image = global::lineaBlanca.Properties.Resources.casa;
            this.btnInicio.CheckedState.Parent = this.btnInicio;
            this.btnInicio.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInicio.CustomImages.Parent = this.btnInicio;
            this.btnInicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInicio.DisabledState.Parent = this.btnInicio;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btnInicio.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.HoverState.Parent = this.btnInicio;
            this.btnInicio.Image = global::lineaBlanca.Properties.Resources.casa__1_;
            this.btnInicio.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnInicio.PressedDepth = 0;
            this.btnInicio.ShadowDecoration.Parent = this.btnInicio;
            this.btnInicio.Size = new System.Drawing.Size(179, 45);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // MainVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 577);
            this.Controls.Add(this.sidebar);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel sidebar;
        private Guna.UI2.WinForms.Guna2Button btnCreditos;
        private Guna.UI2.WinForms.Guna2Button btnPagos;
        private Guna.UI2.WinForms.Guna2Button btnInicio;
        private Guna.UI2.WinForms.Guna2Button btnClientes;
    }
}