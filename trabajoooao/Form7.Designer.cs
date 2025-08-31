namespace trabajoooao
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTCEDULA = new System.Windows.Forms.TextBox();
            this.TXTAPELLIDOS = new System.Windows.Forms.TextBox();
            this.TXTNOMBRES = new System.Windows.Forms.TextBox();
            this.TXTPRESTAMO = new System.Windows.Forms.TextBox();
            this.TXTSALDO = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.textGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTVALOR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTCUOTA = new System.Windows.Forms.TextBox();
            this.TXTDEBE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEDULA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "NUMERO PRESTAMO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "APELLIDOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "NOMBRES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(287, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "REGISTRO DE PAGO";
            // 
            // TXTCEDULA
            // 
            this.TXTCEDULA.Location = new System.Drawing.Point(159, 112);
            this.TXTCEDULA.Name = "TXTCEDULA";
            this.TXTCEDULA.Size = new System.Drawing.Size(185, 22);
            this.TXTCEDULA.TabIndex = 0;
            this.TXTCEDULA.TextChanged += new System.EventHandler(this.TXTCEDULA_TextChanged);
            this.TXTCEDULA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCEDULA_KeyPress);
            // 
            // TXTAPELLIDOS
            // 
            this.TXTAPELLIDOS.Enabled = false;
            this.TXTAPELLIDOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTAPELLIDOS.Location = new System.Drawing.Point(159, 246);
            this.TXTAPELLIDOS.Name = "TXTAPELLIDOS";
            this.TXTAPELLIDOS.Size = new System.Drawing.Size(185, 22);
            this.TXTAPELLIDOS.TabIndex = 2;
            this.TXTAPELLIDOS.TextChanged += new System.EventHandler(this.TXTAPELLIDOS_TextChanged);
            this.TXTAPELLIDOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTAPELLIDOS_KeyPress);
            // 
            // TXTNOMBRES
            // 
            this.TXTNOMBRES.Enabled = false;
            this.TXTNOMBRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNOMBRES.Location = new System.Drawing.Point(159, 179);
            this.TXTNOMBRES.Name = "TXTNOMBRES";
            this.TXTNOMBRES.Size = new System.Drawing.Size(185, 22);
            this.TXTNOMBRES.TabIndex = 1;
            this.TXTNOMBRES.TextChanged += new System.EventHandler(this.TXTNOMBRES_TextChanged);
            this.TXTNOMBRES.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTAPELLIDOS_KeyPress);
            // 
            // TXTPRESTAMO
            // 
            this.TXTPRESTAMO.Enabled = false;
            this.TXTPRESTAMO.Location = new System.Drawing.Point(607, 115);
            this.TXTPRESTAMO.Name = "TXTPRESTAMO";
            this.TXTPRESTAMO.Size = new System.Drawing.Size(181, 22);
            this.TXTPRESTAMO.TabIndex = 3;
            this.TXTPRESTAMO.TextChanged += new System.EventHandler(this.TXTPRESTAMO_TextChanged);
            this.TXTPRESTAMO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTTOTAL_KeyPress);
            // 
            // TXTSALDO
            // 
            this.TXTSALDO.Location = new System.Drawing.Point(607, 183);
            this.TXTSALDO.Name = "TXTSALDO";
            this.TXTSALDO.Size = new System.Drawing.Size(181, 22);
            this.TXTSALDO.TabIndex = 1;
            this.TXTSALDO.TextChanged += new System.EventHandler(this.TXTSALDO_TextChanged);
            this.TXTSALDO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTTOTAL_KeyPress);
            this.TXTSALDO.Validated += new System.EventHandler(this.TXTSALDO_Validated);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.DarkGray;
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(12, 12);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(88, 43);
            this.cancelar.TabIndex = 26;
            this.cancelar.Text = "ATRAS";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // textGuardar
            // 
            this.textGuardar.BackColor = System.Drawing.Color.DimGray;
            this.textGuardar.BackgroundImage = global::trabajoooao.Properties.Resources.guardar;
            this.textGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textGuardar.Location = new System.Drawing.Point(898, 112);
            this.textGuardar.Name = "textGuardar";
            this.textGuardar.Size = new System.Drawing.Size(88, 82);
            this.textGuardar.TabIndex = 27;
            this.textGuardar.UseVisualStyleBackColor = false;
            this.textGuardar.Click += new System.EventHandler(this.textGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ABONO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(378, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "VALOR PRESTAMO";
            // 
            // TXTVALOR
            // 
            this.TXTVALOR.Enabled = false;
            this.TXTVALOR.Location = new System.Drawing.Point(607, 248);
            this.TXTVALOR.Name = "TXTVALOR";
            this.TXTVALOR.Size = new System.Drawing.Size(181, 22);
            this.TXTVALOR.TabIndex = 5;
            this.TXTVALOR.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "FECHA";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 312);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 22);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(383, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "VALOR CUOTA";
            // 
            // TXTCUOTA
            // 
            this.TXTCUOTA.Enabled = false;
            this.TXTCUOTA.Location = new System.Drawing.Point(607, 314);
            this.TXTCUOTA.Name = "TXTCUOTA";
            this.TXTCUOTA.Size = new System.Drawing.Size(181, 22);
            this.TXTCUOTA.TabIndex = 6;
            this.TXTCUOTA.TextChanged += new System.EventHandler(this.TXTCUOTA_TextChanged);
            // 
            // TXTDEBE
            // 
            this.TXTDEBE.Location = new System.Drawing.Point(607, 380);
            this.TXTDEBE.Name = "TXTDEBE";
            this.TXTDEBE.Size = new System.Drawing.Size(181, 22);
            this.TXTDEBE.TabIndex = 2;
            this.TXTDEBE.TextChanged += new System.EventHandler(this.TXTDEBE_TextChanged_1);
            this.TXTDEBE.Validated += new System.EventHandler(this.TXTDEBE_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(383, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = "TOTAL QUE DEBE";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1103, 490);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TXTDEBE);
            this.Controls.Add(this.TXTCUOTA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXTVALOR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textGuardar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.TXTSALDO);
            this.Controls.Add(this.TXTPRESTAMO);
            this.Controls.Add(this.TXTNOMBRES);
            this.Controls.Add(this.TXTAPELLIDOS);
            this.Controls.Add(this.TXTCEDULA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "CREDITOS APP";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTCEDULA;
        private System.Windows.Forms.TextBox TXTAPELLIDOS;
        private System.Windows.Forms.TextBox TXTNOMBRES;
        private System.Windows.Forms.TextBox TXTPRESTAMO;
        private System.Windows.Forms.TextBox TXTSALDO;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button textGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTVALOR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTCUOTA;
        private System.Windows.Forms.TextBox TXTDEBE;
        private System.Windows.Forms.Label label10;
    }
}