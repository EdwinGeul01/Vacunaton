
namespace P1_Vacunaton_21811039
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainBar = new System.Windows.Forms.Panel();
            this.panel_user = new System.Windows.Forms.Panel();
            this.lbltipodeuser = new System.Windows.Forms.Label();
            this.btngohome = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.panel_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Location = new System.Drawing.Point(190, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // MainBar
            // 
            this.MainBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainBar.BackColor = System.Drawing.Color.Gainsboro;
            this.MainBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainBar.ForeColor = System.Drawing.Color.Transparent;
            this.MainBar.Location = new System.Drawing.Point(190, 0);
            this.MainBar.Margin = new System.Windows.Forms.Padding(0);
            this.MainBar.Name = "MainBar";
            this.MainBar.Size = new System.Drawing.Size(760, 20);
            this.MainBar.TabIndex = 4;
            this.MainBar.Paint += new System.Windows.Forms.PaintEventHandler(this.MainBar_Paint);
            this.MainBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainBar_MouseDown);
            this.MainBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainBar_MouseMove);
            this.MainBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainBar_MouseUp);
            // 
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel_user.BackgroundImage = global::P1_Vacunaton_21811039.Properties.Resources.user_panel;
            this.panel_user.Controls.Add(this.lbltipodeuser);
            this.panel_user.Controls.Add(this.btngohome);
            this.panel_user.Controls.Add(this.btnsalir);
            this.panel_user.Controls.Add(this.button6);
            this.panel_user.Controls.Add(this.label3);
            this.panel_user.Controls.Add(this.lblnombre);
            this.panel_user.Controls.Add(this.label1);
            this.panel_user.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_user.Location = new System.Drawing.Point(0, 0);
            this.panel_user.Margin = new System.Windows.Forms.Padding(0);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(190, 596);
            this.panel_user.TabIndex = 6;
            // 
            // lbltipodeuser
            // 
            this.lbltipodeuser.BackColor = System.Drawing.Color.Transparent;
            this.lbltipodeuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipodeuser.ForeColor = System.Drawing.Color.Crimson;
            this.lbltipodeuser.Location = new System.Drawing.Point(12, 192);
            this.lbltipodeuser.Name = "lbltipodeuser";
            this.lbltipodeuser.Size = new System.Drawing.Size(170, 34);
            this.lbltipodeuser.TabIndex = 8;
            this.lbltipodeuser.Text = "rer";
            this.lbltipodeuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btngohome
            // 
            this.btngohome.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btngohome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngohome.FlatAppearance.BorderSize = 0;
            this.btngohome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btngohome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngohome.ForeColor = System.Drawing.Color.Honeydew;
            this.btngohome.Location = new System.Drawing.Point(0, 274);
            this.btngohome.Name = "btngohome";
            this.btngohome.Size = new System.Drawing.Size(190, 37);
            this.btngohome.TabIndex = 7;
            this.btngohome.Text = "MENU";
            this.btngohome.UseVisualStyleBackColor = false;
            this.btngohome.Click += new System.EventHandler(this.btngohome_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Crimson;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(-1, 513);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(131, 42);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "CERRAR SESION";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TIPO DE USUARIO : ";
            // 
            // lblnombre
            // 
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(12, 144);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(170, 16);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "NOMBRE DE USUARIO";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::P1_Vacunaton_21811039.Properties.Resources.ruser;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 104);
            this.label1.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button6.Location = new System.Drawing.Point(-1, 327);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(191, 36);
            this.button6.TabIndex = 4;
            this.button6.Text = "OPCIONES PERFIL";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(950, 596);
            this.Controls.Add(this.MainBar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_user);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load_1);
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btngohome;
        private System.Windows.Forms.Label lbltipodeuser;
        private System.Windows.Forms.Label lblnombre;
        public System.Windows.Forms.Panel MainBar;
        private System.Windows.Forms.Button button6;
    }
}