namespace trabajoooao
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtingresar = new System.Windows.Forms.Button();
            this.txtcancelar = new System.Windows.Forms.Button();
            this.txtregistrarse = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mostrar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 43);
            this.label4.TabIndex = 10;
            this.label4.Text = "INGRESE SU USUARIO";
            // 
            // txtingresar
            // 
            this.txtingresar.BackgroundImage = global::trabajoooao.Properties.Resources.ingresar;
            this.txtingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtingresar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtingresar.Image = global::trabajoooao.Properties.Resources.pito__1;
            this.txtingresar.Location = new System.Drawing.Point(163, 455);
            this.txtingresar.Name = "txtingresar";
            this.txtingresar.Size = new System.Drawing.Size(159, 47);
            this.txtingresar.TabIndex = 2;
            this.txtingresar.Text = "INGRESAR";
            this.txtingresar.UseVisualStyleBackColor = true;
            this.txtingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcancelar
            // 
            this.txtcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtcancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcancelar.Image = global::trabajoooao.Properties.Resources.pito__1;
            this.txtcancelar.Location = new System.Drawing.Point(622, 455);
            this.txtcancelar.Name = "txtcancelar";
            this.txtcancelar.Size = new System.Drawing.Size(154, 47);
            this.txtcancelar.TabIndex = 7;
            this.txtcancelar.Text = "CANCELAR";
            this.txtcancelar.UseVisualStyleBackColor = true;
            this.txtcancelar.Click += new System.EventHandler(this.cancel_Click);
            // 
            // txtregistrarse
            // 
            this.txtregistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtregistrarse.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtregistrarse.Image = global::trabajoooao.Properties.Resources.pito__1;
            this.txtregistrarse.Location = new System.Drawing.Point(379, 455);
            this.txtregistrarse.Name = "txtregistrarse";
            this.txtregistrarse.Size = new System.Drawing.Size(174, 47);
            this.txtregistrarse.TabIndex = 6;
            this.txtregistrarse.Text = "REGISTRARSE";
            this.txtregistrarse.UseVisualStyleBackColor = true;
            this.txtregistrarse.Click += new System.EventHandler(this.resgis_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(379, 352);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(293, 27);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(379, 293);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(293, 27);
            this.TxtUsuario.TabIndex = 0;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 352);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox3.Image = global::trabajoooao.Properties.Resources.uuu;
            this.pictureBox3.Location = new System.Drawing.Point(406, 81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 165);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // mostrar
            // 
            this.mostrar.AutoSize = true;
            this.mostrar.BackColor = System.Drawing.Color.Transparent;
            this.mostrar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrar.Location = new System.Drawing.Point(379, 394);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(150, 20);
            this.mostrar.TabIndex = 11;
            this.mostrar.Text = "Mostrar contraseña";
            this.mostrar.UseVisualStyleBackColor = false;
            this.mostrar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trabajoooao.Properties.Resources.pito__1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 574);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.txtcancelar);
            this.Controls.Add(this.txtingresar);
            this.Controls.Add(this.txtregistrarse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "CREDITOS APP";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txtcancelar;
        private System.Windows.Forms.Button txtregistrarse;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Button txtingresar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox mostrar;
    }
}