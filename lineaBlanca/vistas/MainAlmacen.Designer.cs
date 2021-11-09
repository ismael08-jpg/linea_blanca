
namespace lineaBlanca.vistas
{
    partial class MainAlmacen
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
            this.btnTipos = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategorias = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductos = new Guna.UI2.WinForms.Guna2Button();
            this.btnInicio = new Guna.UI2.WinForms.Guna2Button();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.sidebar.Controls.Add(this.btnTipos);
            this.sidebar.Controls.Add(this.btnCategorias);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Controls.Add(this.btnProductos);
            this.sidebar.Controls.Add(this.btnInicio);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.ShadowDecoration.Parent = this.sidebar;
            this.sidebar.Size = new System.Drawing.Size(179, 577);
            this.sidebar.TabIndex = 2;
            // 
            // btnTipos
            // 
            this.btnTipos.BackColor = System.Drawing.Color.Snow;
            this.btnTipos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTipos.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnTipos.CheckedState.Image = global::lineaBlanca.Properties.Resources.products;
            this.btnTipos.CheckedState.Parent = this.btnTipos;
            this.btnTipos.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTipos.CustomImages.Parent = this.btnTipos;
            this.btnTipos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTipos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTipos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTipos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTipos.DisabledState.Parent = this.btnTipos;
            this.btnTipos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btnTipos.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipos.ForeColor = System.Drawing.Color.White;
            this.btnTipos.HoverState.Parent = this.btnTipos;
            this.btnTipos.Image = global::lineaBlanca.Properties.Resources.products__1_;
            this.btnTipos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTipos.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTipos.Location = new System.Drawing.Point(0, 92);
            this.btnTipos.Name = "btnTipos";
            this.btnTipos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnTipos.PressedDepth = 0;
            this.btnTipos.ShadowDecoration.Parent = this.btnTipos;
            this.btnTipos.Size = new System.Drawing.Size(180, 45);
            this.btnTipos.TabIndex = 9;
            this.btnTipos.Text = "Tipos ";
            this.btnTipos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTipos.Click += new System.EventHandler(this.btnTipos_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.Snow;
            this.btnCategorias.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCategorias.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnCategorias.CheckedState.Image = global::lineaBlanca.Properties.Resources.product__1_;
            this.btnCategorias.CheckedState.Parent = this.btnCategorias;
            this.btnCategorias.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCategorias.CustomImages.Parent = this.btnCategorias;
            this.btnCategorias.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategorias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategorias.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategorias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategorias.DisabledState.Parent = this.btnCategorias;
            this.btnCategorias.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.HoverState.Parent = this.btnCategorias;
            this.btnCategorias.Image = global::lineaBlanca.Properties.Resources.product;
            this.btnCategorias.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategorias.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCategorias.Location = new System.Drawing.Point(0, 137);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnCategorias.PressedDepth = 0;
            this.btnCategorias.ShadowDecoration.Parent = this.btnCategorias;
            this.btnCategorias.Size = new System.Drawing.Size(180, 45);
            this.btnCategorias.TabIndex = 8;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Snow;
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnLogout.CheckedState.Image = global::lineaBlanca.Properties.Resources.logout__2_;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.DisabledState.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = global::lineaBlanca.Properties.Resources.logout__3_;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogout.Location = new System.Drawing.Point(0, 532);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnLogout.PressedDepth = 0;
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(180, 45);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Snow;
            this.btnProductos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProductos.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnProductos.CheckedState.Image = global::lineaBlanca.Properties.Resources.packaging;
            this.btnProductos.CheckedState.Parent = this.btnProductos;
            this.btnProductos.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProductos.CustomImages.Parent = this.btnProductos;
            this.btnProductos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductos.DisabledState.Parent = this.btnProductos;
            this.btnProductos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.HoverState.Parent = this.btnProductos;
            this.btnProductos.Image = global::lineaBlanca.Properties.Resources.packaging__1_;
            this.btnProductos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProductos.ImageSize = new System.Drawing.Size(25, 25);
            this.btnProductos.Location = new System.Drawing.Point(0, 47);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnProductos.PressedDepth = 0;
            this.btnProductos.ShadowDecoration.Parent = this.btnProductos;
            this.btnProductos.Size = new System.Drawing.Size(180, 45);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
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
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.HoverState.Parent = this.btnInicio;
            this.btnInicio.Image = global::lineaBlanca.Properties.Resources.casa__1_;
            this.btnInicio.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInicio.ImageSize = new System.Drawing.Size(25, 25);
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
            // MainAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 577);
            this.Controls.Add(this.sidebar);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel sidebar;
        private Guna.UI2.WinForms.Guna2Button btnProductos;
        private Guna.UI2.WinForms.Guna2Button btnInicio;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnTipos;
        private Guna.UI2.WinForms.Guna2Button btnCategorias;
    }
}