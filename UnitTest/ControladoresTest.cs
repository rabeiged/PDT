using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vialis.Negocio;

namespace UnitTest
{
    /// <summary>
    /// test de todos los controladores incluidos en las clases del proyecto
    /// </summary>
    [TestClass]
    public class ControladoresTest
    {
        [TestMethod]
        //01 prueba contructor clase Acta Reunion, verifica el llenado consultando si no esta vacio
        public void Acta_reunionNotNull()
        {
            Acta_reunion act = null;

            try
            {
                act = new Acta_reunion("id","detalle",DateTime.Now,"participantes");
            }
            catch { }

            Assert.IsNotNull(act);
        }
        /*
        [TestMethod]
        public void Acta_reunionNull()
        {
            Acta_reunion acta = null;

            try
            {
                acta = new Acta_reunion("","",DateTime.Now,"");
            }
            catch { }

            Assert.IsNull(acta);
        }
        */
        [TestMethod]
        //02 prueba contructor clase Afp, verifica el llenado consultando si no esta vacio
        public void AfpNotNull()
        {
            Afp af = null;

            try
            {
                af = new Afp(01,"nombre afp"  );
            }
            catch { }

            Assert.IsNotNull(af);
        }
        [TestMethod]
        //03 prueba contructor clase Asistencia, verifica el llenado consultando si no esta vacio
        public void AsistenciaNotNull()
        {
            Asistencia asi = null;

            try
            {
                asi = new Asistencia(1,DateTime.Now);
            }
            catch { }

            Assert.IsNotNull(asi);
        }

        [TestMethod]
        //04 prueba contructor clase Boleta, verifica el llenado consultando si no esta vacio
        public void BoletaNotNull()
        {
            Boleta bol = null;

            try
            {
                bol = new Boleta(01,DateTime.Now);
            }
            catch { }

            Assert.IsNotNull(bol);
        }

        [TestMethod]
        //05 prueba contructor clase Categoria, verifica el llenado consultando si no esta vacio
        public void CategoriaNotNull()
        {
            Categoria cat = null;

            try
            {
                cat = new Categoria(1,"nombre categoria","descripcion");
            }
            catch { }

            Assert.IsNotNull(cat);
        }

        [TestMethod]
        //06 prueba contructor clase Comuna, verifica el llenado consultando si no esta vacio
        public void ComunaNotNull()
        {
            Comuna com = null;

            try
            {
                com = new Comuna(1,"nombre comuna");
            }
            catch { }

            Assert.IsNotNull(com);
        }

        [TestMethod]
        //07 prueba contructor clase Contrato, verifica el llenado consultando si no esta vacio
        public void ContratoNotNull()
        {
            Contrato con = null;

            try
            {
                con = new Contrato("id","nombre contrato","descripcion",DateTime.Now,DateTime.Now,1,30,2000);
            }
            catch { }

            Assert.IsNotNull(con);
        }
        [TestMethod]
        //08 prueba contructor clase Cotizacion, verifica el llenado consultando si no esta vacio
        public void CotizacionNotNull()
        {
            Cotizacion cot = null;

            try
            {
                cot = new Cotizacion("id",DateTime.Now);
            }
            catch { }

            Assert.IsNotNull(cot);
        }

        [TestMethod]
        //09 prueba contructor clase Descuento, verifica el llenado consultando si no esta vacio
        public void DescuentoNotNull()
        {
            Descuento desc = null;
            Persona per = new Persona("run", "nombre", "apellido pat", "apellido mat", "direccion", "ecivil", "Masculino", DateTime.Now, 1);
            Trabajador_empresa trab = new Trabajador_empresa("oficio", "ro",per);

            try
            {
                desc = new Descuento(1.2, 1.4, 01, 01,trab);
            }
            catch { }

            Assert.IsNotNull(desc);
        }
        [TestMethod]
        //10 prueba contructor clase DetalleBoleta, verifica el llenado consultando si no esta vacio
        public void DetalleBoletaNotNull()
        {
            Detalle_boleta deta = null;

            try
            {
                deta = new Detalle_boleta(01,20,50);
            }
            catch { }

            Assert.IsNotNull(deta);
        }

        [TestMethod]
        //11 prueba contructor clase DetalleBoleta, verifica el llenado consultando si no esta vacio
        public void DetalleCotizacionNotNull()
        {
            Detalle_cotizacion detcot = null;

            try
            {
                detcot = new Detalle_cotizacion("id",1,20);
            }
            catch { }

            Assert.IsNotNull(detcot);
        }

        [TestMethod]
        //12 prueba contructor clase Empresa, verifica el llenado consultando si no esta vacio
        public void EmpresaNotNull()
        {
            Empresa emp = null;

            try
            {
                emp = new Empresa("rol","nombre");
            }
            catch { }

            Assert.IsNotNull(emp);
        }
        [TestMethod]
        //13 prueba contructor clase Etapa, verifica el llenado consultando si no esta vacio
        public void EtapaNotNull()
        {
            Etapa eta = null;

            try
            {
                eta = new Etapa(1,"nombre","decripcion","avance",DateTime.Now,DateTime.Now);
            }
            catch { }

            Assert.IsNotNull(eta);
        }

        [TestMethod]
        //14 prueba contructor clase DetalleBoleta, verifica el llenado consultando si no esta vacio
        public void FacturaNotNull()
        {
            Factura fac = null;

            try
            {
                fac = new Factura(1,2,"detalle",DateTime.Now);
            }
            catch { }

            Assert.IsNotNull(fac);
        }

        [TestMethod]
        //15 prueba contructor clase DetalleBoleta, verifica el llenado consultando si no esta vacio
        public void HitoNotNull()
        {
            Hito hit = null;

            try
            {
                hit = new Hito(1,"nombre","descripcion","avance",DateTime.Now,DateTime.Now);
            }
            catch { }

            Assert.IsNotNull(hit);
        }

        [TestMethod]
        //16 prueba contructor clase Inspeccion tecnica, verifica el llenado consultando si no esta vacio
        public void InspeccionTecnicaNotNull()
        {
            Inspeccion_tecnica ins = null;

            try
            {
                ins = new Inspeccion_tecnica(1,"detalle","avance");
            }
            catch { }

            Assert.IsNotNull(ins);
        }

        [TestMethod]
        //17 prueba contructor clase Pago, verifica el llenado consultando si no esta vacio
        public void PagoNotNull()
        {
            Pago pag = null;

            try
            {
                pag = new Pago(01,"estado",DateTime.Now);
            }
            catch { }

            Assert.IsNotNull(pag);
        }
        [TestMethod]
        //18 prueba contructor clase Persona, verifica el llenado consultando si no esta vacio
        public void PersonaNotNull()
        {
            Persona per = null;

            try
            {
                per = new Persona("run", "nombre", "apellido pat", "apellido mat", "direccion", "ecivil", "Masculino", DateTime.Now, 1);
            }
            catch { }

            Assert.IsNotNull(per);
        }

        //19 prueba contructor clase Producto, verifica el llenado consultando si no esta vacio
        public void ProductoNotNull()
        {
            Producto pro = null;

            try
            {
                pro = new Producto(1,"nombre","descripcion","marca");
            }
            catch { }

            Assert.IsNotNull(pro);
        }

        //20 prueba contructor clase Proveedor, verifica el llenado consultando si no esta vacio
        public void ProveedorNotNull()
        {
            Proveedor prov = null;

            try
            {
                prov = new Proveedor(1,"nombre");
            }
            catch { }

            Assert.IsNotNull(prov);
        }

        //21 prueba contructor clase Provincia, verifica el llenado consultando si no esta vacio
        public void ProvinciaNull()
        {
            Provincia provi = null;

            try
            {
                provi = new Provincia(01,"nombre");
            }
            catch { }

            Assert.IsNotNull(provi);
        }

        //22 prueba contructor clase Proyecto, verifica el llenado consultando si no esta vacio
        public void ProyectoNotNull()
        {
            Proyecto proy = null;

            try
            {
                proy = new Proyecto("PRO01","nombre");
            }
            catch { }

            Assert.IsNotNull(proy);
        }
        //23 prueba contructor clase Region, verifica el llenado consultando si no esta vacio
        public void RegionNotNull()
        {
            Region reg = null;

            try
            {
                reg = new Region(01,"nombre");
            }
            catch { }

            Assert.IsNotNull(reg);
        }

        //24 prueba contructor clase Registro_Avance, verifica el llenado consultando si no esta vacio
        public void RegistroAvanceNotNull()
        {
            Registro_avance regi = null;

            try
            {
                regi = new Registro_avance(01,"nivel","detalle",DateTime.Now);
            }
            catch { }

            Assert.IsNotNull(regi);
        }


        //25prueba contructor clase SeguroSalud, verifica el llenado consultando si no esta vacio
        public void SeguroSaludNotNull()
        {
            Seguro_salud seg = null;

            try
            {
                seg = new Seguro_salud(01,"nombre");
            }
            catch { }

            Assert.IsNotNull(seg);
        }

        //26 prueba contructor clase stock_rrff_empresa, verifica el llenado consultando si no esta vacio
        public void StockrrffEmpresaNotNull()
        {
            Stock_rrff_empresa stem = null;

            try
            {
                stem = new Stock_rrff_empresa(01,01,"marca","nombre producto");
            }
            catch { }

            Assert.IsNotNull(stem);
        }


        //27 prueba contructor clase Stock_rrff_Proyecto, verifica el llenado consultando si no esta vacio
        public void StockrrffProyectoNotNull()
        {
            Stock_rrff_proyecto stpro = null;

            try
            {
                stpro = new Stock_rrff_proyecto(01,20,"marca","nombre producto");
            }
            catch { }

            Assert.IsNotNull(stpro);
        }


        //28 prueba contructor clase Subcategoria, verifica el llenado consultando si no esta vacio
        public void SubcategoriaNotNull()
        {
            Subcategoria sub = null;

            try
            {
                sub = new Subcategoria(01,"nombre","descripcion");
            }
            catch { }

            Assert.IsNotNull(sub);
        }


        //29 prueba contructor clase Sueldo, verifica el llenado consultando si no esta vacio
        public void SueldoNotNull()
        {
            Sueldo sue = null;

            try
            {
                sue = new Sueldo(01,20,30,50);
            }
            catch { }

            Assert.IsNotNull(sue);
        }

        //30 prueba contructor clase Tarea, verifica el llenado consultando si no esta vacio
        public void TareaNotNull()
        {
            Tarea tar = null;

            try
            {
                tar = new Tarea(01, 25, "nombre", "descripcion","nivel",DateTime.Now,DateTime.Now);
            }
            catch { }

            Assert.IsNotNull(tar);
        }




    }
}
