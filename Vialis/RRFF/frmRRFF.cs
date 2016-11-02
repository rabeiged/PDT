using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vialis.RRFF
{
    public partial class frmRRFF : Form
    {
        public frmRRFF()
        {
            InitializeComponent();

        }

        //Buscar como eliminar esta redudancia
        #region Metodos de manejo de pestañas.
        private void nuevaPestana(UserControl uc, String titulo)
        {
            int indice = indicePestanaAbierta(titulo);
            if (indice < 0)
            {
                TabPage tab = new TabPage();
                tab.Text = titulo;
                tab.Controls.Add(uc);
                tabMain.TabPages.Add(tab);
                tabMain.SelectedTab = tab;
            }
            else
            {
                //si ya existe vamos a limpiar el usercontrol y volverlo a cargar en la misma pestaña
                tabMain.TabPages[indice].Controls.Clear();
                tabMain.TabPages[indice].Controls.Add(uc);
                tabMain.SelectedTab = tabMain.TabPages[indice];
            }

        }

        private int indicePestanaAbierta(String titulo)
        {
            Boolean enc = false;
            int i = 0;

            while ((i < tabMain.TabPages.Count) && (enc == false))
            {
                if (tabMain.TabPages[i].Text == titulo)
                    enc = true;
                else
                    i++;
            }
            if (enc)
                return i;
            else
                return -1;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            int indice = tabMain.SelectedIndex;
            if (indice > 0) //no queremos cerrar nunca la inicial.
            {
                tabMain.TabPages.Remove(tabMain.SelectedTab);
                tabMain.SelectedIndex = indice - 1;
                GC.Collect();
            }
        }
        #endregion

        #region CRUD material
        private void agregarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Material.UCagregar uc = new UC.Material.UCagregar();
            nuevaPestana(uc, "Agregar material");
        }

        private void buscarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Material.UCbuscar uc = new UC.Material.UCbuscar();
            nuevaPestana(uc, "Buscar Material");
        }

        private void actualizarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Material.UCactualizar uc = new UC.Material.UCactualizar();
            nuevaPestana(uc, "Actualizar material");
        }

        private void eliminarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Material.UCeliminar uc = new UC.Material.UCeliminar();
            nuevaPestana(uc, "Eliminar material");
        }

        #endregion

        #region CRUD Herramienta
        private void agregarHerramientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Herramienta.UCagregar uc = new UC.Herramienta.UCagregar();
            nuevaPestana(uc, "Agregar herramienta");
        }

        private void buscarHerramientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Herramienta.UCbuscar uc = new UC.Herramienta.UCbuscar();
            nuevaPestana(uc, "Buscar herramienta");
        }

        private void actualizarHerramientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Herramienta.UCactualizar uc = new UC.Herramienta.UCactualizar();
            nuevaPestana(uc, "Actualizar herramienta");
        }

        private void eliminarHerramientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Herramienta.UCeliminar uc = new UC.Herramienta.UCeliminar();
            nuevaPestana(uc, "Eliminar herramienta");
        }

        #endregion

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Maquinaria.UCagregar uc = new UC.Maquinaria.UCagregar();
            nuevaPestana(uc, "Agregar Maquinaria");
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Maquinaria.UCbuscar uc = new UC.Maquinaria.UCbuscar();
            nuevaPestana(uc, "Buscar Maquinaria");
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Maquinaria.UCactualizar uc = new UC.Maquinaria.UCactualizar();
            nuevaPestana(uc, "Actualizar Maquinaria");
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Maquinaria.UCeliminar uc = new UC.Maquinaria.UCeliminar();
            nuevaPestana(uc, "Eliminar Maquinaria");
        }
    }
}
