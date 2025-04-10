namespace PROYECTO_FINAL
{
    partial class Reservas_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservas_1));
            panelContenedor = new System.Windows.Forms.Panel();
            Reservas = new System.Windows.Forms.GroupBox();
            cmbtipoViaje = new System.Windows.Forms.ComboBox();
            txtcantidadPersonas = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtcorreo = new System.Windows.Forms.TextBox();
            btnagregar = new System.Windows.Forms.Button();
            label12 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label11 = new System.Windows.Forms.Label();
            txttelefono = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtpais = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            cmbDestino = new System.Windows.Forms.ComboBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label7 = new System.Windows.Forms.Label();
            txtnombre = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            panelContenedor.SuspendLayout();
            Reservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = System.Drawing.Color.White;
            panelContenedor.BackgroundImage = (System.Drawing.Image)resources.GetObject("panelContenedor.BackgroundImage");
            panelContenedor.Controls.Add(Reservas);
            panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContenedor.Location = new System.Drawing.Point(0, 0);
            panelContenedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new System.Drawing.Size(933, 519);
            panelContenedor.TabIndex = 73;
            // 
            // Reservas
            // 
            Reservas.Controls.Add(cmbtipoViaje);
            Reservas.Controls.Add(txtcantidadPersonas);
            Reservas.Controls.Add(label2);
            Reservas.Controls.Add(label1);
            Reservas.Controls.Add(txtcorreo);
            Reservas.Controls.Add(btnagregar);
            Reservas.Controls.Add(label12);
            Reservas.Controls.Add(dateTimePicker1);
            Reservas.Controls.Add(label11);
            Reservas.Controls.Add(txttelefono);
            Reservas.Controls.Add(label5);
            Reservas.Controls.Add(txtpais);
            Reservas.Controls.Add(button1);
            Reservas.Controls.Add(cmbDestino);
            Reservas.Controls.Add(dataGridView1);
            Reservas.Controls.Add(label7);
            Reservas.Controls.Add(txtnombre);
            Reservas.Controls.Add(label8);
            Reservas.Controls.Add(label9);
            Reservas.Location = new System.Drawing.Point(46, 21);
            Reservas.Name = "Reservas";
            Reservas.Size = new System.Drawing.Size(670, 472);
            Reservas.TabIndex = 0;
            Reservas.TabStop = false;
            Reservas.Text = "Reservas";
            // 
            // cmbtipoViaje
            // 
            cmbtipoViaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            cmbtipoViaje.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            cmbtipoViaje.FormattingEnabled = true;
            cmbtipoViaje.Items.AddRange(new object[] { "Grupo", "Privado (+3 personas)" });
            cmbtipoViaje.Location = new System.Drawing.Point(103, 140);
            cmbtipoViaje.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbtipoViaje.Name = "cmbtipoViaje";
            cmbtipoViaje.Size = new System.Drawing.Size(228, 23);
            cmbtipoViaje.TabIndex = 110;
            cmbtipoViaje.Text = "Seleccione el tipo de viaje";
            // 
            // txtcantidadPersonas
            // 
            txtcantidadPersonas.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtcantidadPersonas.Location = new System.Drawing.Point(537, 142);
            txtcantidadPersonas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtcantidadPersonas.Name = "txtcantidadPersonas";
            txtcantidadPersonas.Size = new System.Drawing.Size(123, 23);
            txtcantidadPersonas.TabIndex = 109;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Teal;
            label2.Location = new System.Drawing.Point(23, 142);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 16);
            label2.TabIndex = 104;
            label2.Text = "Tipo";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Teal;
            label1.Location = new System.Drawing.Point(339, 106);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 16);
            label1.TabIndex = 103;
            label1.Text = "E-mail";
            // 
            // txtcorreo
            // 
            txtcorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtcorreo.Location = new System.Drawing.Point(405, 104);
            txtcorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new System.Drawing.Size(255, 23);
            txtcorreo.TabIndex = 102;
            // 
            // btnagregar
            // 
            btnagregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnagregar.BackColor = System.Drawing.Color.Teal;
            btnagregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            btnagregar.Location = new System.Drawing.Point(303, 300);
            btnagregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new System.Drawing.Size(71, 32);
            btnagregar.TabIndex = 101;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // label12
            // 
            label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.Teal;
            label12.Location = new System.Drawing.Point(18, 276);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(145, 16);
            label12.TabIndex = 100;
            label12.Text = "Seleccione la fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            dateTimePicker1.Location = new System.Drawing.Point(194, 271);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(229, 23);
            dateTimePicker1.TabIndex = 99;
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.Teal;
            label11.Location = new System.Drawing.Point(15, 104);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(69, 16);
            label11.TabIndex = 98;
            label11.Text = "Teléfono";
            // 
            // txttelefono
            // 
            txttelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            txttelefono.Location = new System.Drawing.Point(103, 103);
            txttelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new System.Drawing.Size(228, 23);
            txttelefono.TabIndex = 97;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.Teal;
            label5.Location = new System.Drawing.Point(15, 70);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(43, 16);
            label5.TabIndex = 96;
            label5.Text = "País:";
            // 
            // txtpais
            // 
            txtpais.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtpais.Location = new System.Drawing.Point(73, 69);
            txtpais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtpais.Name = "txtpais";
            txtpais.Size = new System.Drawing.Size(587, 23);
            txtpais.TabIndex = 95;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            button1.BackColor = System.Drawing.Color.Teal;
            button1.Location = new System.Drawing.Point(170, 423);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(239, 33);
            button1.TabIndex = 90;
            button1.Text = "Reservar";
            button1.UseVisualStyleBackColor = false;
            // 
            // cmbDestino
            // 
            cmbDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            cmbDestino.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Items.AddRange(new object[] { "Colombia (Medellín-Bogotá)", "Ecuador (Quito-Quilotoa-Baños de Agua Santa) ", "Perú (Lima-Cusco) ", "Guatemala ", "El Salvador ", "Disney ", "Turquía", "Dubai" });
            cmbDestino.Location = new System.Drawing.Point(103, 173);
            cmbDestino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new System.Drawing.Size(419, 23);
            cmbDestino.TabIndex = 94;
            cmbDestino.Text = "Seleccione su destino ";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(19, 338);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(641, 78);
            dataGridView1.TabIndex = 91;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.Teal;
            label7.Location = new System.Drawing.Point(14, 40);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(138, 16);
            label7.TabIndex = 93;
            label7.Text = "Nombre completo:";
            // 
            // txtnombre
            // 
            txtnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtnombre.Location = new System.Drawing.Point(172, 39);
            txtnombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new System.Drawing.Size(488, 23);
            txtnombre.TabIndex = 87;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.Teal;
            label8.Location = new System.Drawing.Point(347, 147);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(167, 16);
            label8.TabIndex = 88;
            label8.Text = "Cantidad de personas";
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.Teal;
            label9.Location = new System.Drawing.Point(23, 173);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(62, 16);
            label9.TabIndex = 92;
            label9.Text = "Destino";
            // 
            // Reservas_1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(panelContenedor);
            Name = "Reservas_1";
            Text = "Reservas_1";
            panelContenedor.ResumeLayout(false);
            Reservas.ResumeLayout(false);
            Reservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.GroupBox Reservas;
        private System.Windows.Forms.Button btnCargarPriv;
        private System.Windows.Forms.Button btnCargarGrp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDestinoGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcantidadPersonas;
        private System.Windows.Forms.ComboBox cmbtipoViaje;
    }
}