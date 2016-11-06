using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vialis.Negocio;


namespace UnitTest
{
    /// <summary>
    /// test de metodos contenidos en las distintas clases del proyecto
    /// </summary>
    [TestClass]
    public class metodosTest
    {
            /* se ingresa un rut valido para probar el metodo,debe retornar un boolean
               true, lo cual indica que esta validando de manera adecuada
             */    
            [TestMethod]
            public void RutValidoTest()
            {
                //Arrange o planteamiento
                string run = "11.111.111-1";
                Validaciones val = new Validaciones();
                //act o prueba
                bool res = val.ValidarRun(run);
                //assert o afirmacion
                Assert.AreEqual(true, res);
            
            }
            /* se ingresa un rut invalido para probar el metodo,debe retornar un boolean
            false, lo cual indica que esta validando de manera adecuada
            */
            [TestMethod]
            public void RutInvalidoTest()
            {
                //Arrange o planteamiento
                string run = "12345678-9";
                Validaciones val = new Validaciones();
                //act o prueba
                bool res = val.ValidarRun(run);
                //assert o afirmacion
                Assert.AreEqual(false, res);
            }
        }
    }
