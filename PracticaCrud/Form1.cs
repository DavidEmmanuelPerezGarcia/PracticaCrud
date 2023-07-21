using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Negocio;

namespace PracticaCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region
        private void getPersona(string cTexto) 
        {
            dgv_datos.DataSource = N_personas.getPersonas(cTexto);
        }

        private void reset()
        {
            var textboxes = grp_personas.Controls.OfType<TextBox>();
            foreach (var textbox in textboxes)
            {
                textbox.Clear();
            }

            dtp_fecha_nac.Value = DateTime.Now;

            EstadoGuardar = 0;
            id = 0;
        }

        private void estado(bool estado)
        {
            grp_personas.Enabled = estado;

            grp_opciones.Enabled = !estado;
            dgv_datos.Enabled = !estado;
            btn_buscar.Enabled = !estado;
            txt_buscar.Enabled = !estado;
        }
        #endregion
        #region mis variables
        int id = 0;
        int EstadoGuardar = 0;
        #endregion
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            EstadoGuardar = 1;
            estado(true);
            txt_nombre.Focus();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            estado(false);   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.getPersona("%");
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            if (txt_nombre.Text != string.Empty && txt_apPaterno.Text!=string.Empty && txt_apMaterno.Text!=string.Empty && dtp_fecha_nac .Value.ToString()!= string.Empty)
            {
                M_persona oca = new M_persona();

                string rspta = string.Empty;
                oca.nombre = txt_nombre.Text;
                oca.apPaterno = txt_apPaterno.Text;
                oca.apMaterno = txt_apMaterno.Text;
                oca.Edad = Convert.ToInt32( txt_edad.Text);
                oca.Fecha_nac = dtp_fecha_nac.Value.ToString();
                oca.id = id;

                rspta = N_personas.insertXupdate(EstadoGuardar, oca);

                if (rspta.Equals("OK"))
                {
                    MessageBox.Show("Datos guardados", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.getPersona("%");
                    this.reset();
                    this.estado(false);
                }
                else
                {
                    MessageBox.Show(rspta, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("llene los campos restantes", "Aviso del sistema", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            EstadoGuardar = 2;
            estado(true);
            txt_nombre.Focus();
        }

        private void dgv_datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32( dgv_datos.CurrentRow.Cells["id_persona"].Value.ToString());
            txt_nombre.Text = dgv_datos.CurrentRow.Cells["Nombre"].Value.ToString();
            txt_apPaterno.Text = dgv_datos.CurrentRow.Cells["ApPaterno"].Value.ToString();
            txt_apMaterno.Text = dgv_datos.CurrentRow.Cells["ApMaterno"].Value.ToString();
            txt_edad.Text = dgv_datos.CurrentRow.Cells["Edad"].Value.ToString();
            dtp_fecha_nac.Text = dgv_datos.CurrentRow.Cells["Fecha_nac"].Value.ToString();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.getPersona(txt_buscar.Text);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string rspta = string.Empty;
            id = Convert.ToInt32(dgv_datos.CurrentRow.Cells["id_persona"].Value);

            rspta= N_personas.DeletePersona(id);

            if (rspta.Equals("OK"))
            {
                MessageBox.Show("Datos eliminados", "Aviso del sistema");
                this.getPersona("%");
            }
            else
            {
                MessageBox.Show(rspta, "Aviso del sistema");
            }
        }
    }
}
