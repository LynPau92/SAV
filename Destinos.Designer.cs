namespace Sistema_Agencia_de_Viajes
{
    partial class Destinos
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
            this.txtIDDestinos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDReservas = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.ID_Destinos = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgDestinos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDestinos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIDDestinos
            // 
            this.txtIDDestinos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDDestinos.Location = new System.Drawing.Point(295, 53);
            this.txtIDDestinos.Name = "txtIDDestinos";
            this.txtIDDestinos.ReadOnly = true;
            this.txtIDDestinos.Size = new System.Drawing.Size(43, 20);
            this.txtIDDestinos.TabIndex = 126;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(364, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 125;
            this.label3.Text = "ID Reservas";
            // 
            // txtIDReservas
            // 
            this.txtIDReservas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDReservas.Location = new System.Drawing.Point(476, 53);
            this.txtIDReservas.Name = "txtIDReservas";
            this.txtIDReservas.Size = new System.Drawing.Size(43, 20);
            this.txtIDReservas.TabIndex = 124;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.Teal;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAgregar.Location = new System.Drawing.Point(109, 193);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 28);
            this.btnAgregar.TabIndex = 121;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.Teal;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCancelar.Location = new System.Drawing.Point(299, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 28);
            this.btnCancelar.TabIndex = 120;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEliminar.Location = new System.Drawing.Point(516, 193);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 28);
            this.btnEliminar.TabIndex = 119;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.Teal;
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnModificar.Location = new System.Drawing.Point(324, 193);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(95, 28);
            this.btnModificar.TabIndex = 118;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ID_Destinos
            // 
            this.ID_Destinos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID_Destinos.AutoSize = true;
            this.ID_Destinos.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Destinos.ForeColor = System.Drawing.Color.Teal;
            this.ID_Destinos.Location = new System.Drawing.Point(206, 54);
            this.ID_Destinos.Name = "ID_Destinos";
            this.ID_Destinos.Size = new System.Drawing.Size(83, 16);
            this.ID_Destinos.TabIndex = 117;
            this.ID_Destinos.Text = "ID Destino";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Items.AddRange(new object[] {
            "Colombia (Medellín-Bogotá)  ",
            "Ecuador (Quito-Quilotoa-Baños de Agua Santa)  ",
            "Perú (Lima-Cusco)  ",
            "Guatemala  ",
            "El Salvador  ",
            "Disney  ",
            "Turquía  ",
            "Dubai"});
            this.cmbDestino.Location = new System.Drawing.Point(274, 89);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(287, 21);
            this.cmbDestino.TabIndex = 12;
            this.cmbDestino.Text = "Seleccione su destino";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(324, 134);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(119, 20);
            this.txtPrecio.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(229, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(192, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destino";
            // 
            // dtgDestinos
            // 
            this.dtgDestinos.BackgroundColor = System.Drawing.Color.White;
            this.dtgDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDestinos.Location = new System.Drawing.Point(37, 353);
            this.dtgDestinos.Name = "dtgDestinos";
            this.dtgDestinos.ReadOnly = true;
            this.dtgDestinos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDestinos.Size = new System.Drawing.Size(726, 147);
            this.dtgDestinos.TabIndex = 124;
            this.dtgDestinos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDestinos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtIDDestinos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIDReservas);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.ID_Destinos);
            this.groupBox1.Controls.Add(this.cmbDestino);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 316);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destinos";
            // 
            // Destinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(816, 522);
            this.Controls.Add(this.dtgDestinos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Destinos";
            this.Text = "Destinos";
            this.Load += new System.EventHandler(this.Destinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDestinos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDDestinos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDReservas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label ID_Destinos;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgDestinos;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}