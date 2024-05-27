namespace pryMuñozLab3TP2
{
    partial class frmMain
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnContraseña = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreIS = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.noTieneUnaCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encontrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContraseña
            // 
            this.btnContraseña.Location = new System.Drawing.Point(92, 152);
            this.btnContraseña.Name = "btnContraseña";
            this.btnContraseña.Size = new System.Drawing.Size(116, 41);
            this.btnContraseña.TabIndex = 0;
            this.btnContraseña.Text = "Crear";
            this.btnContraseña.UseVisualStyleBackColor = true;
            this.btnContraseña.Click += new System.EventHandler(this.btnContraseña_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtNombreIS
            // 
            this.txtNombreIS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreIS.Location = new System.Drawing.Point(141, 62);
            this.txtNombreIS.Name = "txtNombreIS";
            this.txtNombreIS.Size = new System.Drawing.Size(130, 27);
            this.txtNombreIS.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noTieneUnaCuentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // noTieneUnaCuentaToolStripMenuItem
            // 
            this.noTieneUnaCuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCuentaToolStripMenuItem,
            this.encontrarUsuarioToolStripMenuItem});
            this.noTieneUnaCuentaToolStripMenuItem.Name = "noTieneUnaCuentaToolStripMenuItem";
            this.noTieneUnaCuentaToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.noTieneUnaCuentaToolStripMenuItem.Text = "¿Tiene una cuenta?";
            this.noTieneUnaCuentaToolStripMenuItem.Click += new System.EventHandler(this.noTieneUnaCuentaToolStripMenuItem_Click);
            // 
            // crearCuentaToolStripMenuItem
            // 
            this.crearCuentaToolStripMenuItem.Name = "crearCuentaToolStripMenuItem";
            this.crearCuentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearCuentaToolStripMenuItem.Text = "Iniciar sesión";
            // 
            // encontrarUsuarioToolStripMenuItem
            // 
            this.encontrarUsuarioToolStripMenuItem.Name = "encontrarUsuarioToolStripMenuItem";
            this.encontrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.encontrarUsuarioToolStripMenuItem.Text = "Registro de LOG";
            this.encontrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.encontrarUsuarioToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(141, 95);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(130, 27);
            this.txtContraseña.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 224);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreIS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContraseña);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear cuenta";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreIS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem noTieneUnaCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCuentaToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem encontrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.TextBox txtContraseña;
    }
}

