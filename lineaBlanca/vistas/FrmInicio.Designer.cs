
namespace lineaBlanca.vistas
{
    partial class FrmInicio
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
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Chip2 = new Guna.UI2.WinForms.Guna2Chip();
            this.SuspendLayout();
            // 
            // guna2Chip1
            // 
            this.guna2Chip1.AutoRoundedCorners = true;
            this.guna2Chip1.BorderRadius = 19;
            this.guna2Chip1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.guna2Chip1.ForeColor = System.Drawing.Color.White;
            this.guna2Chip1.Location = new System.Drawing.Point(2, 12);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(130, 40);
            this.guna2Chip1.TabIndex = 0;
            this.guna2Chip1.Text = "guna2Chip1";
            // 
            // guna2Chip2
            // 
            this.guna2Chip2.AutoRoundedCorners = true;
            this.guna2Chip2.BorderRadius = 19;
            this.guna2Chip2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.guna2Chip2.ForeColor = System.Drawing.Color.White;
            this.guna2Chip2.Location = new System.Drawing.Point(2, 506);
            this.guna2Chip2.Name = "guna2Chip2";
            this.guna2Chip2.ShadowDecoration.Parent = this.guna2Chip2;
            this.guna2Chip2.Size = new System.Drawing.Size(130, 40);
            this.guna2Chip2.TabIndex = 1;
            this.guna2Chip2.Text = "guna2Chip2";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 573);
            this.Controls.Add(this.guna2Chip2);
            this.Controls.Add(this.guna2Chip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip2;
    }
}