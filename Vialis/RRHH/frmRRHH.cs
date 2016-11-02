﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vialis.RRHH
{
    public partial class frmRRHH : Form
    {
        public frmRRHH()
        {
            InitializeComponent();
            
        }

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

        #region CRUD trabajador
        private void agregarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RRHH.UC.Trabajador ruta completa de referencia
            UC.Trabajador.UCagregar uc = new UC.Trabajador.UCagregar();
            nuevaPestana(uc, "Agregar trabajador");

        }

        private void buscarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Trabajador.UCbuscar uc = new UC.Trabajador.UCbuscar();
            nuevaPestana(uc, "Buscar trabajador");
        }

        private void actualizarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Trabajador.UCactualizar uc = new UC.Trabajador.UCactualizar();
            nuevaPestana(uc, "Actualizar trabajador");
        }

        private void eliminarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Trabajador.UCeliminar uc = new UC.Trabajador.UCeliminar();
            nuevaPestana(uc, "Eliminar trabajador");
        }
        #endregion

        #region CRUD liquidacion


        private void buscarLiquidacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC.Liquidacion.UCbuscar uc = new UC.Liquidacion.UCbuscar();
            nuevaPestana(uc, "Buscar liquidación");
        }
        
        #endregion

    }
}
