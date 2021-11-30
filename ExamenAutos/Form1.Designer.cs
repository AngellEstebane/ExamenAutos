
namespace ExamenAutos
{
    partial class Form1
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbBuscarNombre = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.bRegistrar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(52, 50);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(106, 23);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(52, 83);
            this.tbMatricula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(106, 23);
            this.tbMatricula.TabIndex = 1;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(52, 117);
            this.tbModelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(106, 23);
            this.tbModelo.TabIndex = 2;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(52, 151);
            this.tbColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(106, 23);
            this.tbColor.TabIndex = 3;
            // 
            // tbBuscarNombre
            // 
            this.tbBuscarNombre.Location = new System.Drawing.Point(328, 50);
            this.tbBuscarNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBuscarNombre.Name = "tbBuscarNombre";
            this.tbBuscarNombre.Size = new System.Drawing.Size(106, 23);
            this.tbBuscarNombre.TabIndex = 4;
            this.tbBuscarNombre.TextChanged += new System.EventHandler(this.tbBuscarNombre_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(52, 184);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(211, 23);
            this.dtpFecha.TabIndex = 5;
            // 
            // bRegistrar
            // 
            this.bRegistrar.Location = new System.Drawing.Point(52, 223);
            this.bRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bRegistrar.Name = "bRegistrar";
            this.bRegistrar.Size = new System.Drawing.Size(78, 20);
            this.bRegistrar.TabIndex = 6;
            this.bRegistrar.Text = "Registrar";
            this.bRegistrar.UseVisualStyleBackColor = true;
            this.bRegistrar.Click += new System.EventHandler(this.bRegistrar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(52, 253);
            this.bModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(78, 20);
            this.bModificar.TabIndex = 7;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(52, 277);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(78, 20);
            this.bEliminar.TabIndex = 8;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // dgvCarros
            // 
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(436, 166);
            this.dgvCarros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.RowHeadersWidth = 62;
            this.dgvCarros.RowTemplate.Height = 33;
            this.dgvCarros.Size = new System.Drawing.Size(252, 135);
            this.dgvCarros.TabIndex = 9;
            this.dgvCarros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarros_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 321);
            this.Controls.Add(this.dgvCarros);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bRegistrar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.tbBuscarNombre);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.tbNombre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "MENU DE AUTOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbBuscarNombre;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button bRegistrar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.DataGridView dgvCarros;
    }
}

