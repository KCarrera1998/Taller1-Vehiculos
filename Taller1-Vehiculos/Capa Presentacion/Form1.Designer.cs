namespace Taller1_Vehiculos
{
    partial class frm_Vehiculos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvVehiculos = new DataGridView();
            lb_VehiculoID = new Label();
            lb_VehiculoMarca = new Label();
            lb_VehiculoModelo = new Label();
            lb_VehiculoAño = new Label();
            lb_VehiculoPrecio = new Label();
            cbx_VehiculoEstado = new ComboBox();
            lb_VehiculoEstado = new Label();
            txt_VehiculoID = new TextBox();
            txt_VehiculoMarca = new TextBox();
            txt_VehiculoModelo = new TextBox();
            txt_VehiculoAño = new TextBox();
            txt_VehiculoPrecio = new TextBox();
            btn_VehiculosCrear = new Button();
            btn_VehiculosActualizar = new Button();
            btn_VehiculosEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            SuspendLayout();
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(12, 355);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.ReadOnly = true;
            dgvVehiculos.RowHeadersWidth = 51;
            dgvVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculos.Size = new Size(1053, 351);
            dgvVehiculos.TabIndex = 0;
            dgvVehiculos.CellClick += dgvVehiculos_CellClick;
            // 
            // lb_VehiculoID
            // 
            lb_VehiculoID.AutoSize = true;
            lb_VehiculoID.Location = new Point(35, 31);
            lb_VehiculoID.Name = "lb_VehiculoID";
            lb_VehiculoID.Size = new Size(87, 20);
            lb_VehiculoID.TabIndex = 1;
            lb_VehiculoID.Text = "Vehiculo ID:";
            // 
            // lb_VehiculoMarca
            // 
            lb_VehiculoMarca.AutoSize = true;
            lb_VehiculoMarca.Location = new Point(35, 81);
            lb_VehiculoMarca.Name = "lb_VehiculoMarca";
            lb_VehiculoMarca.Size = new Size(53, 20);
            lb_VehiculoMarca.TabIndex = 2;
            lb_VehiculoMarca.Text = "Marca:";
            // 
            // lb_VehiculoModelo
            // 
            lb_VehiculoModelo.AutoSize = true;
            lb_VehiculoModelo.Location = new Point(35, 130);
            lb_VehiculoModelo.Name = "lb_VehiculoModelo";
            lb_VehiculoModelo.Size = new Size(64, 20);
            lb_VehiculoModelo.TabIndex = 3;
            lb_VehiculoModelo.Text = "Modelo:";
            // 
            // lb_VehiculoAño
            // 
            lb_VehiculoAño.AutoSize = true;
            lb_VehiculoAño.Location = new Point(35, 181);
            lb_VehiculoAño.Name = "lb_VehiculoAño";
            lb_VehiculoAño.Size = new Size(39, 20);
            lb_VehiculoAño.TabIndex = 4;
            lb_VehiculoAño.Text = "Año:";
            // 
            // lb_VehiculoPrecio
            // 
            lb_VehiculoPrecio.AutoSize = true;
            lb_VehiculoPrecio.Location = new Point(35, 234);
            lb_VehiculoPrecio.Name = "lb_VehiculoPrecio";
            lb_VehiculoPrecio.Size = new Size(50, 20);
            lb_VehiculoPrecio.TabIndex = 5;
            lb_VehiculoPrecio.Text = "Precio";
            // 
            // cbx_VehiculoEstado
            // 
            cbx_VehiculoEstado.FormattingEnabled = true;
            cbx_VehiculoEstado.Items.AddRange(new object[] { "Disponible", "Vendido" });
            cbx_VehiculoEstado.Location = new Point(163, 280);
            cbx_VehiculoEstado.Name = "cbx_VehiculoEstado";
            cbx_VehiculoEstado.Size = new Size(267, 28);
            cbx_VehiculoEstado.TabIndex = 6;
            // 
            // lb_VehiculoEstado
            // 
            lb_VehiculoEstado.AutoSize = true;
            lb_VehiculoEstado.Location = new Point(35, 283);
            lb_VehiculoEstado.Name = "lb_VehiculoEstado";
            lb_VehiculoEstado.Size = new Size(54, 20);
            lb_VehiculoEstado.TabIndex = 7;
            lb_VehiculoEstado.Text = "Estado";
            // 
            // txt_VehiculoID
            // 
            txt_VehiculoID.Location = new Point(163, 28);
            txt_VehiculoID.Name = "txt_VehiculoID";
            txt_VehiculoID.Size = new Size(267, 27);
            txt_VehiculoID.TabIndex = 8;
            // 
            // txt_VehiculoMarca
            // 
            txt_VehiculoMarca.Location = new Point(163, 78);
            txt_VehiculoMarca.Name = "txt_VehiculoMarca";
            txt_VehiculoMarca.Size = new Size(267, 27);
            txt_VehiculoMarca.TabIndex = 9;
            // 
            // txt_VehiculoModelo
            // 
            txt_VehiculoModelo.Location = new Point(163, 127);
            txt_VehiculoModelo.Name = "txt_VehiculoModelo";
            txt_VehiculoModelo.Size = new Size(267, 27);
            txt_VehiculoModelo.TabIndex = 10;
            // 
            // txt_VehiculoAño
            // 
            txt_VehiculoAño.Location = new Point(163, 178);
            txt_VehiculoAño.Name = "txt_VehiculoAño";
            txt_VehiculoAño.Size = new Size(267, 27);
            txt_VehiculoAño.TabIndex = 11;
            // 
            // txt_VehiculoPrecio
            // 
            txt_VehiculoPrecio.Location = new Point(163, 231);
            txt_VehiculoPrecio.Name = "txt_VehiculoPrecio";
            txt_VehiculoPrecio.Size = new Size(267, 27);
            txt_VehiculoPrecio.TabIndex = 12;
            // 
            // btn_VehiculosCrear
            // 
            btn_VehiculosCrear.Location = new Point(901, 57);
            btn_VehiculosCrear.Name = "btn_VehiculosCrear";
            btn_VehiculosCrear.Size = new Size(128, 54);
            btn_VehiculosCrear.TabIndex = 13;
            btn_VehiculosCrear.Text = "Crear";
            btn_VehiculosCrear.UseVisualStyleBackColor = true;
            btn_VehiculosCrear.Click += btn_VehiculosCrear_Click;
            // 
            // btn_VehiculosActualizar
            // 
            btn_VehiculosActualizar.Location = new Point(901, 147);
            btn_VehiculosActualizar.Name = "btn_VehiculosActualizar";
            btn_VehiculosActualizar.Size = new Size(128, 54);
            btn_VehiculosActualizar.TabIndex = 14;
            btn_VehiculosActualizar.Text = "Actualizar";
            btn_VehiculosActualizar.UseVisualStyleBackColor = true;
            // 
            // btn_VehiculosEliminar
            // 
            btn_VehiculosEliminar.Location = new Point(901, 234);
            btn_VehiculosEliminar.Name = "btn_VehiculosEliminar";
            btn_VehiculosEliminar.Size = new Size(128, 54);
            btn_VehiculosEliminar.TabIndex = 15;
            btn_VehiculosEliminar.Text = "Eliminar";
            btn_VehiculosEliminar.UseVisualStyleBackColor = true;
            // 
            // frm_Vehiculos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 718);
            Controls.Add(btn_VehiculosEliminar);
            Controls.Add(btn_VehiculosActualizar);
            Controls.Add(btn_VehiculosCrear);
            Controls.Add(txt_VehiculoPrecio);
            Controls.Add(txt_VehiculoAño);
            Controls.Add(txt_VehiculoModelo);
            Controls.Add(txt_VehiculoMarca);
            Controls.Add(txt_VehiculoID);
            Controls.Add(lb_VehiculoEstado);
            Controls.Add(cbx_VehiculoEstado);
            Controls.Add(lb_VehiculoPrecio);
            Controls.Add(lb_VehiculoAño);
            Controls.Add(lb_VehiculoModelo);
            Controls.Add(lb_VehiculoMarca);
            Controls.Add(lb_VehiculoID);
            Controls.Add(dgvVehiculos);
            Name = "frm_Vehiculos";
            Text = "Vehiculos";
            Load += frm_Vehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVehiculos;
        private Label lb_VehiculoID;
        private Label lb_VehiculoMarca;
        private Label lb_VehiculoModelo;
        private Label lb_VehiculoAño;
        private Label lb_VehiculoPrecio;
        private ComboBox cbx_VehiculoEstado;
        private Label lb_VehiculoEstado;
        private TextBox txt_VehiculoID;
        private TextBox txt_VehiculoMarca;
        private TextBox txt_VehiculoModelo;
        private TextBox txt_VehiculoAño;
        private TextBox txt_VehiculoPrecio;
        private Button btn_VehiculosCrear;
        private Button btn_VehiculosActualizar;
        private Button btn_VehiculosEliminar;
    }
}
