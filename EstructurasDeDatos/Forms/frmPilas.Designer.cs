namespace EstructurasDeDatos.Forms
{
    partial class frmPilas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesapilarEmpleado = new System.Windows.Forms.Button();
            this.btnApilarEmpleado = new System.Windows.Forms.Button();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.lblEstadoEmpleado = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Datos de Empleado";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtRol);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 183);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rol:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(62, 130);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(181, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(62, 81);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(181, 20);
            this.txtRol.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnDesapilarEmpleado
            // 
            this.btnDesapilarEmpleado.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDesapilarEmpleado.Location = new System.Drawing.Point(389, 137);
            this.btnDesapilarEmpleado.Name = "btnDesapilarEmpleado";
            this.btnDesapilarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnDesapilarEmpleado.TabIndex = 13;
            this.btnDesapilarEmpleado.Text = "Eliminar";
            this.btnDesapilarEmpleado.UseVisualStyleBackColor = false;
            this.btnDesapilarEmpleado.Click += new System.EventHandler(this.btnDesapilarEmpleado_Click);
            // 
            // btnApilarEmpleado
            // 
            this.btnApilarEmpleado.BackColor = System.Drawing.Color.MediumPurple;
            this.btnApilarEmpleado.Location = new System.Drawing.Point(389, 87);
            this.btnApilarEmpleado.Name = "btnApilarEmpleado";
            this.btnApilarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnApilarEmpleado.TabIndex = 12;
            this.btnApilarEmpleado.Text = "Agregar";
            this.btnApilarEmpleado.UseVisualStyleBackColor = false;
            this.btnApilarEmpleado.Click += new System.EventHandler(this.btnApilarEmpleado_Click);
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.Location = new System.Drawing.Point(41, 286);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(255, 186);
            this.lstEmpleados.TabIndex = 15;
            // 
            // lblEstadoEmpleado
            // 
            this.lblEstadoEmpleado.AutoSize = true;
            this.lblEstadoEmpleado.Location = new System.Drawing.Point(296, 297);
            this.lblEstadoEmpleado.Name = "lblEstadoEmpleado";
            this.lblEstadoEmpleado.Size = new System.Drawing.Size(0, 13);
            this.lblEstadoEmpleado.TabIndex = 16;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnRegresar.Location = new System.Drawing.Point(396, 450);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 36);
            this.btnRegresar.TabIndex = 25;
            this.btnRegresar.Text = "Regresar a Menu";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 498);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblEstadoEmpleado);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.btnDesapilarEmpleado);
            this.Controls.Add(this.btnApilarEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPilas";
            this.Text = "frmPilas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesapilarEmpleado;
        private System.Windows.Forms.Button btnApilarEmpleado;
        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.Label lblEstadoEmpleado;
        private System.Windows.Forms.Button btnRegresar;
    }
}