namespace pryDelivida
{
    partial class frmClientes
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDetalles = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.flpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnListarTodo = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxFiltrar = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbxDetalles.SuspendLayout();
            this.flpBotones.SuspendLayout();
            this.gbxFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colDNI,
            this.colEdad,
            this.colEstatura,
            this.colPeso,
            this.colImc});
            this.dgvLista.Location = new System.Drawing.Point(12, 76);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(524, 399);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.SelectionChanged += new System.EventHandler(this.dgvLista_SelectionChanged);
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colDNI
            // 
            this.colDNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDNI.HeaderText = "DNI";
            this.colDNI.Name = "colDNI";
            this.colDNI.ReadOnly = true;
            this.colDNI.Width = 51;
            // 
            // colEdad
            // 
            this.colEdad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEdad.HeaderText = "Edad";
            this.colEdad.Name = "colEdad";
            this.colEdad.ReadOnly = true;
            this.colEdad.Width = 57;
            // 
            // colEstatura
            // 
            this.colEstatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEstatura.HeaderText = "Estatura";
            this.colEstatura.Name = "colEstatura";
            this.colEstatura.ReadOnly = true;
            this.colEstatura.Width = 71;
            // 
            // colPeso
            // 
            this.colPeso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPeso.HeaderText = "Peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.ReadOnly = true;
            this.colPeso.Width = 56;
            // 
            // colImc
            // 
            this.colImc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colImc.FillWeight = 50F;
            this.colImc.HeaderText = "IMC";
            this.colImc.Name = "colImc";
            this.colImc.ReadOnly = true;
            // 
            // gbxDetalles
            // 
            this.gbxDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDetalles.Controls.Add(this.btnGuardar);
            this.gbxDetalles.Controls.Add(this.btnCancelar);
            this.gbxDetalles.Controls.Add(this.txtIMC);
            this.gbxDetalles.Controls.Add(this.txtPeso);
            this.gbxDetalles.Controls.Add(this.txtEstatura);
            this.gbxDetalles.Controls.Add(this.txtEdad);
            this.gbxDetalles.Controls.Add(this.txtDNI);
            this.gbxDetalles.Controls.Add(this.lblIMC);
            this.gbxDetalles.Controls.Add(this.txtNombre);
            this.gbxDetalles.Controls.Add(this.lblPeso);
            this.gbxDetalles.Controls.Add(this.lblEstatura);
            this.gbxDetalles.Controls.Add(this.lblEdad);
            this.gbxDetalles.Controls.Add(this.lblDNI);
            this.gbxDetalles.Controls.Add(this.lblNombre);
            this.gbxDetalles.Location = new System.Drawing.Point(542, 76);
            this.gbxDetalles.Name = "gbxDetalles";
            this.gbxDetalles.Size = new System.Drawing.Size(230, 261);
            this.gbxDetalles.TabIndex = 1;
            this.gbxDetalles.TabStop = false;
            this.gbxDetalles.Text = "Detalles";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(149, 208);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 45);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(6, 208);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 45);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(78, 158);
            this.txtIMC.MaxLength = 3;
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.ReadOnly = true;
            this.txtIMC.Size = new System.Drawing.Size(146, 20);
            this.txtIMC.TabIndex = 9;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(78, 129);
            this.txtPeso.MaxLength = 3;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(146, 20);
            this.txtPeso.TabIndex = 9;
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(78, 103);
            this.txtEstatura.MaxLength = 4;
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(146, 20);
            this.txtEstatura.TabIndex = 8;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(78, 77);
            this.txtEdad.MaxLength = 2;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(146, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(78, 51);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(146, 20);
            this.txtDNI.TabIndex = 6;
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Location = new System.Drawing.Point(21, 161);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(26, 13);
            this.lblIMC.TabIndex = 4;
            this.lblIMC.Text = "IMC";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(21, 132);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso";
            // 
            // lblEstatura
            // 
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.Location = new System.Drawing.Point(21, 106);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(46, 13);
            this.lblEstatura.TabIndex = 3;
            this.lblEstatura.Text = "Estatura";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(21, 80);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(21, 54);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // flpBotones
            // 
            this.flpBotones.AutoSize = true;
            this.flpBotones.Controls.Add(this.btnListarTodo);
            this.flpBotones.Controls.Add(this.btnNuevo);
            this.flpBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpBotones.Location = new System.Drawing.Point(0, 0);
            this.flpBotones.Name = "flpBotones";
            this.flpBotones.Size = new System.Drawing.Size(784, 70);
            this.flpBotones.TabIndex = 2;
            // 
            // btnListarTodo
            // 
            this.btnListarTodo.Location = new System.Drawing.Point(3, 3);
            this.btnListarTodo.Name = "btnListarTodo";
            this.btnListarTodo.Size = new System.Drawing.Size(96, 64);
            this.btnListarTodo.TabIndex = 0;
            this.btnListarTodo.Text = "Listar Todo";
            this.btnListarTodo.UseVisualStyleBackColor = true;
            this.btnListarTodo.Click += new System.EventHandler(this.btnListarTodo_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(105, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(96, 64);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbxFiltrar
            // 
            this.gbxFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxFiltrar.Controls.Add(this.btnFiltrar);
            this.gbxFiltrar.Controls.Add(this.txtValor);
            this.gbxFiltrar.Controls.Add(this.cmbCampo);
            this.gbxFiltrar.Location = new System.Drawing.Point(542, 343);
            this.gbxFiltrar.Name = "gbxFiltrar";
            this.gbxFiltrar.Size = new System.Drawing.Size(230, 132);
            this.gbxFiltrar.TabIndex = 3;
            this.gbxFiltrar.TabStop = false;
            this.gbxFiltrar.Text = "Filtrar";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(6, 72);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(218, 54);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(6, 46);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(218, 20);
            this.txtValor.TabIndex = 1;
            // 
            // cmbCampo
            // 
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "Nombre",
            "DNI",
            "Edad",
            "Estatura",
            "Peso"});
            this.cmbCampo.Location = new System.Drawing.Point(6, 19);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(218, 21);
            this.cmbCampo.TabIndex = 0;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 487);
            this.Controls.Add(this.gbxFiltrar);
            this.Controls.Add(this.flpBotones);
            this.Controls.Add(this.gbxDetalles);
            this.Controls.Add(this.dgvLista);
            this.MinimumSize = new System.Drawing.Size(600, 525);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gbxDetalles.ResumeLayout(false);
            this.gbxDetalles.PerformLayout();
            this.flpBotones.ResumeLayout(false);
            this.gbxFiltrar.ResumeLayout(false);
            this.gbxFiltrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox gbxDetalles;
        private System.Windows.Forms.FlowLayoutPanel flpBotones;
        private System.Windows.Forms.Button btnListarTodo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImc;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.GroupBox gbxFiltrar;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtValor;
    }
}