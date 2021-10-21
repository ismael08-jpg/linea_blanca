
namespace lineaBlanca.vistas
{
    partial class DashboardView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.SuspendLayout();
            // 
            // guna2Chip1
            // 
            this.guna2Chip1.AutoRoundedCorners = true;
            this.guna2Chip1.BorderRadius = 19;
            this.guna2Chip1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.guna2Chip1.ForeColor = System.Drawing.Color.White;
            this.guna2Chip1.Location = new System.Drawing.Point(291, 191);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(130, 40);
            this.guna2Chip1.TabIndex = 0;
            this.guna2Chip1.Text = "guna2Chip1";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Chip1);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(815, 498);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
    }
}
