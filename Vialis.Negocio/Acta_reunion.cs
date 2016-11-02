using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vialis.Negocio
{
    public class Acta_reunion
    {
        #region Campos
        // deberia ser identity el ID no ir como string.

        private string _id_reunion, _detalle_minuta, _participante, _empresa, _proyecto, _etapa;
        private DateTime _fecha_reunion;
        

        #endregion

        #region Propiedades

        public string Id_reunion
        {
            get
            {
                return _id_reunion;
            }

            set
            {
                _id_reunion = value;
            }
        }

        public string Detalle_minuta
        {
            get
            {
                return _detalle_minuta;
            }

            set
            {
                _detalle_minuta = value;
            }
        }

        public string Participante
        {
            get
            {
                return _participante;
            }

            set
            {
                _participante = value;
            }
        }

        public string Empresa
        {
            get
            {
                return _empresa;
            }

            set
            {
                _empresa = value;
            }
        }

        public string Proyecto
        {
            get
            {
                return _proyecto;
            }

            set
            {
                _proyecto = value;
            }
        }

        public string Etapa
        {
            get
            {
                return _etapa;
            }

            set
            {
                _etapa = value;
            }
        }

        public DateTime Fecha_reunion
        {
            get
            {
                return _fecha_reunion;
            }

            set
            {
                _fecha_reunion = value;
            }
        }


        #endregion

        #region Constructores
        public Acta_reunion()
        {
            init();

        }

        public Acta_reunion(string id_reun, string detalle_minu, DateTime fec_reu, string partc)
        {
            init();

            this.Id_reunion = id_reun;
            this.Detalle_minuta = detalle_minu;
            this.Fecha_reunion = fec_reu;
            this.Participante = partc;

        }


        #endregion

        #region Metodos
        private void init()
        {
            this.Id_reunion = string.Empty;
            this.Detalle_minuta = string.Empty;
            this.Fecha_reunion = DateTime.Now;
            this.Participante = string.Empty;
        }

   
        public bool Crear()
        {
            try
            {
                Vialis.DALC.Acta_reunion acta = new Vialis.DALC.Acta_reunion();

                acta.id_reunion = this.Id_reunion;
                //acta.Detalle_participacion = this.Participante;
                acta.detalle_minuta = this.Detalle_minuta;
                acta.Empresa.rol = this.Empresa;
                acta.Proyecto.id_proyecto = this.Proyecto;
                acta.fecha_reunion = this.Fecha_reunion;

                ConectorDALC.ModeloVialis.Acta_reunion.Add(acta);
                ConectorDALC.ModeloVialis.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    


        #endregion

    }
}
