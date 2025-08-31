namespace trabajoooao
{
    partial class registroo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.textNombres = new System.Windows.Forms.TextBox();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.txtguardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textCiudad = new System.Windows.Forms.TextBox();
            this.txtnuevo = new System.Windows.Forms.Button();
            this.registro = new System.Windows.Forms.Label();
            this.txtactualizar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "IDENTIFICACION";
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(208, 88);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(231, 22);
            this.textIdentificacion.TabIndex = 0;
            this.textIdentificacion.TextChanged += new System.EventHandler(this.textIdentificacion_TextChanged);
            this.textIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIdentificacion_KeyPress);
            // 
            // textNombres
            // 
            this.textNombres.Location = new System.Drawing.Point(208, 140);
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(231, 22);
            this.textNombres.TabIndex = 1;
            this.textNombres.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombres_KeyPress);
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(208, 195);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(231, 22);
            this.textApellidos.TabIndex = 2;
            this.textApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textApellidos_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "TELEFONO";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(208, 250);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(231, 22);
            this.textTelefono.TabIndex = 3;
            this.textTelefono.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelefono_KeyPress);
            // 
            // txtguardar
            // 
            this.txtguardar.BackgroundImage = global::trabajoooao.Properties.Resources.pito__1;
            this.txtguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtguardar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtguardar.Location = new System.Drawing.Point(296, 411);
            this.txtguardar.Name = "txtguardar";
            this.txtguardar.Size = new System.Drawing.Size(114, 52);
            this.txtguardar.TabIndex = 13;
            this.txtguardar.Text = "GUARDAR";
            this.txtguardar.UseVisualStyleBackColor = true;
            this.txtguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "CIUDAD";
            // 
            // textCiudad
            // 
            this.textCiudad.Location = new System.Drawing.Point(208, 302);
            this.textCiudad.Name = "textCiudad";
            this.textCiudad.Size = new System.Drawing.Size(231, 22);
            this.textCiudad.TabIndex = 4;
            this.textCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCiudad_KeyPress);
            // 
            // txtnuevo
            // 
            this.txtnuevo.BackColor = System.Drawing.Color.DarkGray;
            this.txtnuevo.BackgroundImage = global::trabajoooao.Properties.Resources.pito__1;
            this.txtnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txtnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtnuevo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnuevo.Location = new System.Drawing.Point(654, 411);
            this.txtnuevo.Name = "txtnuevo";
            this.txtnuevo.Size = new System.Drawing.Size(110, 52);
            this.txtnuevo.TabIndex = 17;
            this.txtnuevo.Text = "NUEVO";
            this.txtnuevo.UseVisualStyleBackColor = false;
            this.txtnuevo.Click += new System.EventHandler(this.txtnuevo_Click);
            // 
            // registro
            // 
            this.registro.AutoSize = true;
            this.registro.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.Image = global::trabajoooao.Properties.Resources.pito__1;
            this.registro.Location = new System.Drawing.Point(374, 12);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(279, 40);
            this.registro.TabIndex = 18;
            this.registro.Text = "NUEVO USUARIO";
            // 
            // txtactualizar
            // 
            this.txtactualizar.BackgroundImage = global::trabajoooao.Properties.Resources.pito__1;
            this.txtactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txtactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtactualizar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtactualizar.Location = new System.Drawing.Point(458, 411);
            this.txtactualizar.Name = "txtactualizar";
            this.txtactualizar.Size = new System.Drawing.Size(152, 52);
            this.txtactualizar.TabIndex = 19;
            this.txtactualizar.Text = "ACTUALIZAR";
            this.txtactualizar.UseVisualStyleBackColor = true;
            this.txtactualizar.Click += new System.EventHandler(this.txtactualizar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::trabajoooao.Properties.Resources.pito__1;
            this.button2.Location = new System.Drawing.Point(18, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 34);
            this.button2.TabIndex = 21;
            this.button2.Text = "ATRAS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "USUARIO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(539, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "CONTRASEÑA";
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(713, 140);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(231, 22);
            this.textContraseña.TabIndex = 6;
            this.textContraseña.TextChanged += new System.EventHandler(this.textContraseña_TextChanged);
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(713, 86);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(231, 22);
            this.textUsuario.TabIndex = 5;
            // 
            // registroo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trabajoooao.Properties.Resources.pito__1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 557);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtactualizar);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.txtnuevo);
            this.Controls.Add(this.textCiudad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtguardar);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.textNombres);
            this.Controls.Add(this.textIdentificacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "registroo";
            this.Text = "CREDITOS APP";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.TextBox textNombres;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Button txtguardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCiudad;
        private System.Windows.Forms.Button txtnuevo;
        private System.Windows.Forms.Label registro;
        private System.Windows.Forms.Button txtactualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.TextBox textUsuario;
    }
}