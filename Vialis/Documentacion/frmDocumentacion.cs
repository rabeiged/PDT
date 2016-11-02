using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vialis.Documentacion
{
    public partial class frmDocumentacion : Form
    {
        public frmDocumentacion()
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

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Proyecto.UCagregar uc = new UC.Proyecto.UCagregar();
            nuevaPestana(uc, "Ingresar proyecto");
        }


        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Cotizacion.UCagregar uc = new UC.Cotizacion.UCagregar();
            nuevaPestana(uc, "Agregar cotización");
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UC.EDT.UCagregar uc = new UC.EDT.UCagregar();
            nuevaPestana(uc, "Agregar EDT");
        }
    }
}
