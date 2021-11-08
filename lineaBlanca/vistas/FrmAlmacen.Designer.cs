
namespace lineaBlanca.vistas
{
    partial class FrmAlmacen
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
            this.btnCategorias = new Guna.UI2.WinForms.Guna2Button();
            this.btnTipos = new Guna.UI2.WinForms.Guna2Button();
            this.btnPro = new Guna.UI2.WinForms.Guna2Button();
            this.btnInicio = new Guna.UI2.WinForms.Guna2Button();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.sidebar.Controls.Add(this.btnCategorias);
            this.sidebar.Controls.Add(this.btnTipos);
            this.sidebar.Controls.Add(this.btnPro);
            this.sidebar.Controls.Add(this.btnInicio);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.ShadowDecoration.Parent = this.sidebar;
            this.sidebar.Size = new System.Drawing.Size(179, 577);
            this.sidebar.TabIndex = 3;
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.Snow;
            this.btnCategorias.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCategorias.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnCategorias.CheckedState.Parent = this.btnCategorias;
            this.btnCategorias.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCategorias.CustomImages.Parent = this.btnCategorias;
            this.btnCategorias.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategorias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategorias.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategorias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategorias.DisabledState.Parent = this.btnCategorias;
            this.btnCategorias.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btnCategorias.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.HoverState.Parent = this.btnCategorias;
            this.btnCategorias.Location = new System.Drawing.Point(0, 125);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnCategorias.PressedDepth = 0;
            this.btnCategorias.ShadowDecoration.Parent = this.btnCategorias;
            this.btnCategorias.Size = new System.Drawing.Size(180, 45);
            this.btnCategorias.TabIndex = 3;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnTipos
            // 
            this.btnTipos.BackColor = System.Drawing.Color.Snow;
            this.btnTipos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTipos.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnTipos.CheckedState.Parent = this.btnTipos;
            this.btnTipos.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTipos.CustomImages.Parent = this.btnTipos;
            this.btnTipos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTipos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTipos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTipos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTipos.DisabledState.Parent = this.btnTipos;
            this.btnTipos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btnTipos.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipos.ForeColor = System.Drawing.Color.White;
            this.btnTipos.HoverState.Parent = this.btnTipos;
            this.btnTipos.Location = new System.Drawing.Point(0, 84);
            this.btnTipos.Name = "btnTipos";
            this.btnTipos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnTipos.PressedDepth = 0;
            this.btnTipos.ShadowDecoration.Parent = this.btnTipos;
            this.btnTipos.Size = new System.Drawing.Size(180, 45);
            this.btnTipos.TabIndex = 2;
            this.btnTipos.Text = "Tipos";
            this.btnTipos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTipos.Click += new System.EventHandler(this.btnTipos_Click);
            // 
            // btnPro
            // 
            this.btnPro.BackColor = System.Drawing.Color.Snow;
            this.btnPro.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPro.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnPro.CheckedState.Parent = this.btnPro;
            this.btnPro.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPro.CustomImages.Parent = this.btnPro;
            this.btnPro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPro.DisabledState.Parent = this.btnPro;
            this.btnPro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.btnPro.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPro.ForeColor = System.Drawing.Color.White;
            this.btnPro.HoverState.Parent = this.btnPro;
            this.btnPro.Location = new System.Drawing.Point(0, 42);
            this.btnPro.Name = "btnPro";
            this.btnPro.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnPro.PressedDepth = 0;
            this.btnPro.ShadowDecoration.Parent = this.btnPro;
            this.btnPro.Size = new System.Drawing.Size(180, 45);
            this.btnPro.TabIndex = 1;
            this.btnPro.Text = "Productos";
            this.btnPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Snow;
            this.btnInicio.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInicio.Checked = true;
            this.btnInicio.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
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
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(35)))));
            this.btnInicio.PressedDepth = 0;
            this.btnInicio.ShadowDecoration.Parent = this.btnInicio;
            this.btnInicio.Size = new System.Drawing.Size(179, 45);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FrmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 577);
            this.Controls.Add(this.sidebar);
            this.IsMdiContainer = true;
            this.Name = "FrmAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacen";
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel sidebar;
        private Guna.UI2.WinForms.Guna2Button btnCategorias;
        private Guna.UI2.WinForms.Guna2Button btnTipos;
        private Guna.UI2.WinForms.Guna2Button btnPro;
        private Guna.UI2.WinForms.Guna2Button btnInicio;
    }
}