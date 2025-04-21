using System;
using System.Windows.Forms;

namespace Sistema_Agencia_de_Viajes
{
    partial class Reservas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDCLIENTE = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtCDP = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.ID_Reservas = new System.Windows.Forms.Label();
            this.dtFDR = new System.Windows.Forms.DateTimePicker();
            this.dtFDS = new System.Windows.Forms.DateTimePicker();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgReservas = new System.Windows.Forms.DataGridView();
            this.txtIDRESERVA = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtIDRESERVA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIDCLIENTE);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.txtCDP);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.ID_Reservas);
            this.groupBox1.Controls.Add(this.dtFDR);
            this.groupBox1.Controls.Add(this.dtFDS);
            this.groupBox1.Controls.Add(this.cmbDestino);
            this.groupBox1.Controls.Add(this.txtCostoTotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(123, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 125;
            this.label3.Text = "ID Cliente";
            // 
            // txtIDCLIENTE
            // 
            this.txtIDCLIENTE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDCLIENTE.Location = new System.Drawing.Point(219, 57);
            this.txtIDCLIENTE.Name = "txtIDCLIENTE";
            this.txtIDCLIENTE.Size = new System.Drawing.Size(43, 20);
            this.txtIDCLIENTE.TabIndex = 124;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "PENDIENTE",
            "COMPLETADO"});
            this.cmbEstado.Location = new System.Drawing.Point(268, 178);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 123;
            // 
            // txtCDP
            // 
            this.txtCDP.Location = new System.Drawing.Point(376, 147);
            this.txtCDP.Name = "txtCDP";
            this.txtCDP.Size = new System.Drawing.Size(236, 20);
            this.txtCDP.TabIndex = 122;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.Teal;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAgregar.Location = new System.Drawing.Point(94, 242);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 28);
            this.btnAgregar.TabIndex = 121;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.Teal;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCancelar.Location = new System.Drawing.Point(283, 276);
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
            this.btnEliminar.Location = new System.Drawing.Point(501, 242);
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
            this.btnModificar.Location = new System.Drawing.Point(309, 242);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(95, 28);
            this.btnModificar.TabIndex = 118;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ID_Reservas
            // 
            this.ID_Reservas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID_Reservas.AutoSize = true;
            this.ID_Reservas.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Reservas.ForeColor = System.Drawing.Color.Teal;
            this.ID_Reservas.Location = new System.Drawing.Point(123, 32);
            this.ID_Reservas.Name = "ID_Reservas";
            this.ID_Reservas.Size = new System.Drawing.Size(86, 16);
            this.ID_Reservas.TabIndex = 117;
            this.ID_Reservas.Text = "ID Reserva";
            this.ID_Reservas.Click += new System.EventHandler(this.ID_Click);
            // 
            // dtFDR
            // 
            this.dtFDR.Location = new System.Drawing.Point(352, 115);
            this.dtFDR.Name = "dtFDR";
            this.dtFDR.Size = new System.Drawing.Size(200, 20);
            this.dtFDR.TabIndex = 15;
            // 
            // dtFDS
            // 
            this.dtFDS.Location = new System.Drawing.Point(352, 83);
            this.dtFDS.Name = "dtFDS";
            this.dtFDS.Size = new System.Drawing.Size(200, 20);
            this.dtFDS.TabIndex = 14;
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
            this.cmbDestino.Location = new System.Drawing.Point(352, 53);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(287, 21);
            this.cmbDestino.TabIndex = 12;
            this.cmbDestino.Text = "Seleccione su destino";
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Location = new System.Drawing.Point(301, 209);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Size = new System.Drawing.Size(119, 20);
            this.txtCostoTotal.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(205, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Costo Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(205, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(202, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad De Personas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(202, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha De Regreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(224, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha De Salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(284, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destino";
            // 
            // dtgReservas
            // 
            this.dtgReservas.BackgroundColor = System.Drawing.Color.White;
            this.dtgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReservas.Location = new System.Drawing.Point(52, 363);
            this.dtgReservas.Name = "dtgReservas";
            this.dtgReservas.ReadOnly = true;
            this.dtgReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgReservas.Size = new System.Drawing.Size(726, 147);
            this.dtgReservas.TabIndex = 122;
            this.dtgReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgReservas_CellClick);
            // 
            // txtIDRESERVA
            // 
            this.txtIDRESERVA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDRESERVA.Location = new System.Drawing.Point(219, 32);
            this.txtIDRESERVA.Name = "txtIDRESERVA";
            this.txtIDRESERVA.ReadOnly = true;
            this.txtIDRESERVA.Size = new System.Drawing.Size(43, 20);
            this.txtIDRESERVA.TabIndex = 126;
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(816, 522);
            this.Controls.Add(this.dtgReservas);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Reservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.Reservas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservas)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDRESERVA.Text);

            DialogResult confirmar = MessageBox.Show("¿Desea eliminar?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirmar == DialogResult.OK)
            {
                Reservas1 reservas = new Reservas1(id);
                int fila = reservas.EliminarReserva();

                if (fila == 1)
                {
                    ResetearFormulario();
                    ListarReservas();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la reserva");
                }
            }
            else
            {
                ResetearFormulario();
            }
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFDR;
        private System.Windows.Forms.DateTimePicker dtFDS;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID_Reservas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtgReservas;
        private System.Windows.Forms.TextBox txtCDP;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDCLIENTE;
        private System.Windows.Forms.TextBox txtIDRESERVA;
    }
}