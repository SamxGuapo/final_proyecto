namespace trabajoooao
{
    partial class registro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cedulatxt = new System.Windows.Forms.TextBox();
            this.Cuotatxt = new System.Windows.Forms.TextBox();
            this.Prestamotxt = new System.Windows.Forms.TextBox();
            this.Apellidostxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Interestxt = new System.Windows.Forms.TextBox();
            this.Nombrestxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.datosalmacenados = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textGuardar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Cancelartxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datosalmacenados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEDULA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "VALOR PRESTAMO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "NOMBRES";
            // 
            // Cedulatxt
            // 
            this.Cedulatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cedulatxt.Location = new System.Drawing.Point(253, 69);
            this.Cedulatxt.Name = "Cedulatxt";
            this.Cedulatxt.Size = new System.Drawing.Size(249, 22);
            this.Cedulatxt.TabIndex = 0;
            this.Cedulatxt.TextChanged += new System.EventHandler(this.Cedulatxt_TextChanged);
            this.Cedulatxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cedulatxt_KeyPress);
            // 
            // Cuotatxt
            // 
            this.Cuotatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cuotatxt.Location = new System.Drawing.Point(944, 171);
            this.Cuotatxt.Name = "Cuotatxt";
            this.Cuotatxt.Size = new System.Drawing.Size(249, 22);
            this.Cuotatxt.TabIndex = 6;
            this.Cuotatxt.TextChanged += new System.EventHandler(this.Cuotatxt_TextChanged);
            this.Cuotatxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cuotatxt_KeyPress);
            this.Cuotatxt.Validated += new System.EventHandler(this.Cuotatxt_Validated);
            // 
            // Prestamotxt
            // 
            this.Prestamotxt.Location = new System.Drawing.Point(253, 232);
            this.Prestamotxt.Name = "Prestamotxt";
            this.Prestamotxt.Size = new System.Drawing.Size(249, 22);
            this.Prestamotxt.TabIndex = 3;
            this.Prestamotxt.TextChanged += new System.EventHandler(this.Prestamotxt_TextChanged);
            this.Prestamotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cuotatxt_KeyPress);
            // 
            // Apellidostxt
            // 
            this.Apellidostxt.Enabled = false;
            this.Apellidostxt.Location = new System.Drawing.Point(253, 171);
            this.Apellidostxt.Name = "Apellidostxt";
            this.Apellidostxt.Size = new System.Drawing.Size(249, 22);
            this.Apellidostxt.TabIndex = 2;
            this.Apellidostxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apellidostxt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(607, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "CUOTA POR DIA";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(607, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "INTERES DEL PRESTAMO";
            // 
            // Interestxt
            // 
            this.Interestxt.Location = new System.Drawing.Point(944, 69);
            this.Interestxt.Name = "Interestxt";
            this.Interestxt.Size = new System.Drawing.Size(249, 22);
            this.Interestxt.TabIndex = 4;
            this.Interestxt.TextChanged += new System.EventHandler(this.Interestxt_TextChanged);
            this.Interestxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cuotatxt_KeyPress);
            this.Interestxt.Validated += new System.EventHandler(this.Interestxt_Validated);
            // 
            // Nombrestxt
            // 
            this.Nombrestxt.Enabled = false;
            this.Nombrestxt.Location = new System.Drawing.Point(253, 116);
            this.Nombrestxt.Name = "Nombrestxt";
            this.Nombrestxt.Size = new System.Drawing.Size(249, 22);
            this.Nombrestxt.TabIndex = 1;
            this.Nombrestxt.TextChanged += new System.EventHandler(this.Nombrestxt_TextChanged);
            this.Nombrestxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apellidostxt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(525, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(374, 33);
            this.label7.TabIndex = 19;
            this.label7.Text = "REGISTRO DE PRESTAMO";
            // 
            // datosalmacenados
            // 
            this.datosalmacenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosalmacenados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.registrados,
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column4,
            this.Column3});
            this.datosalmacenados.Location = new System.Drawing.Point(43, 312);
            this.datosalmacenados.Name = "datosalmacenados";
            this.datosalmacenados.RowHeadersWidth = 51;
            this.datosalmacenados.RowTemplate.Height = 24;
            this.datosalmacenados.Size = new System.Drawing.Size(933, 157);
            this.datosalmacenados.TabIndex = 24;
            this.datosalmacenados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datosalmacenados_CellContentClick);
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            this.Cedula.Width = 125;
            // 
            // registrados
            // 
            this.registrados.HeaderText = "Nombres";
            this.registrados.MinimumWidth = 6;
            this.registrados.Name = "registrados";
            this.registrados.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Apellidos";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Vr.Prestamo";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Interes del prestamo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Meses en cancelar";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cuota por dia";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // textGuardar
            // 
            this.textGuardar.BackColor = System.Drawing.Color.DimGray;
            this.textGuardar.BackgroundImage = global::trabajoooao.Properties.Resources.guardar;
            this.textGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textGuardar.Location = new System.Drawing.Point(1064, 290);
            this.textGuardar.Name = "textGuardar";
            this.textGuardar.Size = new System.Drawing.Size(88, 82);
            this.textGuardar.TabIndex = 21;
            this.textGuardar.UseVisualStyleBackColor = false;
            this.textGuardar.Click += new System.EventHandler(this.textGuardar_Click);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.DarkGray;
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(28, 8);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(88, 43);
            this.cancelar.TabIndex = 25;
            this.cancelar.Text = "ATRAS";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1064, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 43);
            this.button1.TabIndex = 26;
            this.button1.Text = "NUEVO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(607, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "MESES EN CANCELAR";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Cancelartxt
            // 
            this.Cancelartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelartxt.Location = new System.Drawing.Point(944, 116);
            this.Cancelartxt.Name = "Cancelartxt";
            this.Cancelartxt.Size = new System.Drawing.Size(249, 22);
            this.Cancelartxt.TabIndex = 5;
            this.Cancelartxt.TextChanged += new System.EventHandler(this.Cancelartxt_TextChanged);
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1270, 499);
            this.Controls.Add(this.Cancelartxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.datosalmacenados);
            this.Controls.Add(this.textGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Nombrestxt);
            this.Controls.Add(this.Interestxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Apellidostxt);
            this.Controls.Add(this.Prestamotxt);
            this.Controls.Add(this.Cuotatxt);
            this.Controls.Add(this.Cedulatxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "registro";
            this.Text = "CREDITOS APP";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosalmacenados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Cedulatxt;
        private System.Windows.Forms.TextBox Cuotatxt;
        private System.Windows.Forms.TextBox Prestamotxt;
        private System.Windows.Forms.TextBox Apellidostxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Interestxt;
        private System.Windows.Forms.TextBox Nombrestxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button textGuardar;
        private System.Windows.Forms.DataGridView datosalmacenados;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Cancelartxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}