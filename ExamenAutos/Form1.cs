using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenAutos
{
    public partial class Form1 : Form
    {
        public int id = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarProducto();
            ActualizarProductos();
        }

        private void ActualizarProductos()
        {
            using (var context = new ApplicationDbContext())
            {
                var carros = context.Carros.ToList();
                dgvCarros.DataSource = carros;

            }

        }

        private void RegistrarProducto()
        {
            using (var context = new ApplicationDbContext())
            {
                var carro1 = new Carros();
                //propiedades
                carro1.Nombre = tbNombre.Text;
                carro1.Matricula = tbMatricula.Text;
                carro1.Modelo = tbModelo.Text;
                carro1.Color = tbColor.Text;
                carro1.Fecha = DateTime.Parse(dtpFecha.Text);

                context.Carros.Add(carro1);
                context.SaveChanges();
            }

        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    var carro1 = context.Carros.First(x => x.Id == id);
                    if (carro1 != null)
                    {
                        carro1.Nombre = tbNombre.Text;
                        carro1.Matricula = tbMatricula.Text;
                        carro1.Modelo = tbModelo.Text;
                        carro1.Color = tbColor.Text;
                        carro1.Fecha = DateTime.Parse(dtpFecha.Text);

                        var videojuegos = context.Carros.ToList();
                        dgvCarros.DataSource = videojuegos;

                        context.SaveChanges();
                    }
                }

            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
            ActualizarProductos();
        }

        private void EliminarProducto()
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    var videojuego1 = context.Carros.First(x => x.Id == id);
                    if (videojuego1 != null)
                    {
                        context.Remove(videojuego1);
                        context.SaveChanges();
                    }

                }
            }

        }

        private void dgvCarros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvCarros.CurrentRow.Cells[0].Value.ToString());
            tbNombre.Text = dgvCarros.CurrentRow.Cells[1].Value.ToString();
            tbMatricula.Text = dgvCarros.CurrentRow.Cells[2].Value.ToString();
            tbModelo.Text = dgvCarros.CurrentRow.Cells[3].Value.ToString();
            tbColor.Text = dgvCarros.CurrentRow.Cells[4].Value.ToString();
            dtpFecha.Value = Convert.ToDateTime(dgvCarros.CurrentRow.Cells[5].Value.ToString());

        }

        private void tbBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            if (tbBuscarNombre.Text.Length > 0)
            {
                using (var context = new ApplicationDbContext())
                {
                    var videojuego1 = context.Carros.Where(x => x.Nombre.Contains(tbBuscarNombre.Text)).ToList();
                    dgvCarros.DataSource = videojuego1;
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarProductos();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
