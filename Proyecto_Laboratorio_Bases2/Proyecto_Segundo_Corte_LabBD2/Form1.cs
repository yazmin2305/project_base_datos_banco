using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Segundo_Corte_LabBD2.logica;

namespace Proyecto_Segundo_Corte_LabBD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Banco objB = new Banco();
        Sucursal objS = new Sucursal();
        private void btnGuardarBanco_Click(object sender, EventArgs e)
        {
            int nit;
            string nombre;
            string fecha;
            int resultado;
            try
            {
                nit = int.Parse(txtNitBan.Text);
                nombre = txtNomBan.Text;
                fecha = dtpFechaCreacion.Value.Date.ToShortDateString();

                resultado = objB.RegistrarBanco(nit, nombre, fecha);
                if (resultado > 0)
                {
                    MessageBox.Show("Banco registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Banco no registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un numero valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Campo sin llenar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            txtNitBan.ResetText();
            txtNomBan.ResetText();
        }

        private void btnGuardarSucursal_Click(object sender, EventArgs e)
        {
            int codigo;
            string nomSuc;
            string ubicacion;
            int numEmpleados;
            int AntiguedadAnios;
            int nitBanco;
            int resultado = 0;

            try
            {
                codigo = int.Parse(txtCodSuc.Text);
                nomSuc = txtNomSuc.Text;
                ubicacion = cmbUbiSuc.SelectedItem.ToString();
                numEmpleados = int.Parse(txtNumEmpSuc.Text);
                AntiguedadAnios = int.Parse(txtAnioSuc.Text);
                nitBanco = int.Parse(txtNitBanSuc.Text);
                resultado = objS.RegistrarSucursal(codigo, nomSuc, ubicacion, numEmpleados, AntiguedadAnios, nitBanco);
                if (resultado > 0)
                {
                    MessageBox.Show("Sucursal registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sucursal no registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }catch(FormatException)
            {
                MessageBox.Show("Ingrese un numero valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("El nit digitado no existe, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtCodSuc.ResetText();
            txtNomSuc.ResetText();
            txtNumEmpSuc.ResetText();
            txtAnioSuc.ResetText();
            txtNitBanSuc.ResetText();
        }

        private void btnConsultarSucursales_Click(object sender, EventArgs e)
        {
            string nomBanc;
            string ubicacionSuc;
            nomBanc = txtNomBanConsult.Text;
            ubicacionSuc = cmbUbiSucConsult.SelectedItem.ToString();
            
            DataSet dt = new DataSet();
            dt = objS.ConsultarSucursales(nomBanc, ubicacionSuc);
            dgvConsultSuc.DataSource = dt;
            dgvConsultSuc.DataMember = "Sucursales";

            txtNomBanConsult.ResetText();
        }
    }
}
