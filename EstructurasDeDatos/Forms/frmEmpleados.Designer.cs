namespace EstructurasDeDatos
{
    partial class frmEmpleados
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.EmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bsEmpleados = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmpleados = new Controllers.DataSets.dsEmpleados();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbFiltar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpleadosTableAdapter = new Controllers.DataSets.dsEmpleadosTableAdapters.EmpleadosTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.iDEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._editar = new System.Windows.Forms.DataGridViewImageColumn();
            this._eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleados)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Listado de Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Buscar";
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.AutoGenerateColumns = false;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEmpleadoDataGridViewTextBoxColumn,
            this.nombreEmpleadoDataGridViewTextBoxColumn,
            this.cargoEmpleadoDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this._editar,
            this._eliminar});
            this.dgUsuarios.DataSource = this.EmpleadosBindingSource;
            this.dgUsuarios.Location = new System.Drawing.Point(12, 304);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.Size = new System.Drawing.Size(445, 183);
            this.dgUsuarios.TabIndex = 63;
            this.dgUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellContentDoubleClick);
            // 
            // EmpleadosBindingSource
            // 
            this.EmpleadosBindingSource.DataMember = "Empleados";
            this.EmpleadosBindingSource.DataSource = this.bsEmpleados;
            // 
            // bsEmpleados
            // 
            this.bsEmpleados.DataSource = this.dsEmpleados;
            this.bsEmpleados.Position = 0;
            // 
            // dsEmpleados
            // 
            this.dsEmpleados.DataSetName = "dsEmpleados";
            this.dsEmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(304, 253);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(177, 20);
            this.txtBuscar.TabIndex = 61;
            // 
            // cbFiltar
            // 
            this.cbFiltar.FormattingEnabled = true;
            this.cbFiltar.Location = new System.Drawing.Point(90, 253);
            this.cbFiltar.Name = "cbFiltar";
            this.cbFiltar.Size = new System.Drawing.Size(166, 21);
            this.cbFiltar.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(111, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 58;
            this.label11.Text = "Filtar por:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(433, 175);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 30);
            this.btnSalir.TabIndex = 57;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizar.Location = new System.Drawing.Point(433, 139);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 30);
            this.btnActualizar.TabIndex = 56;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(433, 103);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 30);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(433, 67);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 30);
            this.btnGuardar.TabIndex = 54;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.SlateBlue;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.Location = new System.Drawing.Point(433, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(96, 30);
            this.btnNuevo.TabIndex = 53;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Thistle;
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.cbRol);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.txtContraseña);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 198);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Usuario";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(189, 165);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(59, 24);
            this.txtID.TabIndex = 51;
            this.txtID.Visible = false;
            // 
            // cbRol
            // 
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Cajero",
            "Administrador"});
            this.cbRol.Location = new System.Drawing.Point(45, 63);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(299, 26);
            this.cbRol.TabIndex = 50;
            this.cbRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbRol_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(71, 101);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(273, 24);
            this.txtUsuario.TabIndex = 19;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(93, 135);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(251, 24);
            this.txtContraseña.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Rol";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(134, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 24);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre Completo";
            // 
            // EmpleadosTableAdapter
            // 
            this.EmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::EstructurasDeDatos.Properties.Resources.Icon_Edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::EstructurasDeDatos.Properties.Resources.Icon_Delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = global::EstructurasDeDatos.Properties.Resources.Icon_Search;
            this.pbBuscar.Location = new System.Drawing.Point(476, 243);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(36, 41);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBuscar.TabIndex = 62;
            this.pbBuscar.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EstructurasDeDatos.Properties.Resources.Icon_Filtre;
            this.pictureBox2.Location = new System.Drawing.Point(90, 233);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.BackColor = System.Drawing.Color.SlateBlue;
            this.btnDeshacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshacer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeshacer.Location = new System.Drawing.Point(536, 31);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(96, 30);
            this.btnDeshacer.TabIndex = 66;
            this.btnDeshacer.Text = "Deshacer";
            this.btnDeshacer.UseVisualStyleBackColor = false;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // iDEmpleadoDataGridViewTextBoxColumn
            // 
            this.iDEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IDEmpleado";
            this.iDEmpleadoDataGridViewTextBoxColumn.HeaderText = "IDEmpleado";
            this.iDEmpleadoDataGridViewTextBoxColumn.Name = "iDEmpleadoDataGridViewTextBoxColumn";
            this.iDEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDEmpleadoDataGridViewTextBoxColumn.Visible = false;
            this.iDEmpleadoDataGridViewTextBoxColumn.Width = 75;
            // 
            // nombreEmpleadoDataGridViewTextBoxColumn
            // 
            this.nombreEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn.HeaderText = "NombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn.Name = "nombreEmpleadoDataGridViewTextBoxColumn";
            this.nombreEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoEmpleadoDataGridViewTextBoxColumn
            // 
            this.cargoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "CargoEmpleado";
            this.cargoEmpleadoDataGridViewTextBoxColumn.HeaderText = "CargoEmpleado";
            this.cargoEmpleadoDataGridViewTextBoxColumn.Name = "cargoEmpleadoDataGridViewTextBoxColumn";
            this.cargoEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            this.contraseñaDataGridViewTextBoxColumn.ReadOnly = true;
            this.contraseñaDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _editar
            // 
            this._editar.HeaderText = "Editar";
            this._editar.Image = global::EstructurasDeDatos.Properties.Resources.Icon_Edit;
            this._editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._editar.Name = "_editar";
            this._editar.ReadOnly = true;
            this._editar.Width = 50;
            // 
            // _eliminar
            // 
            this._eliminar.HeaderText = "Eliminar";
            this._eliminar.Image = global::EstructurasDeDatos.Properties.Resources.Icon_Delete;
            this._eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._eliminar.Name = "_eliminar";
            this._eliminar.ReadOnly = true;
            this._eliminar.Width = 50;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(648, 503);
            this.Controls.Add(this.btnDeshacer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbFiltar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmEmpleados";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbFiltar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsEmpleados;
        private Controllers.DataSets.dsEmpleados dsEmpleados;
        private Controllers.DataSets.dsEmpleadosTableAdapters.EmpleadosTableAdapter EmpleadosTableAdapter;
        private System.Windows.Forms.BindingSource EmpleadosBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn _editar;
        private System.Windows.Forms.DataGridViewImageColumn _eliminar;
    }
}

