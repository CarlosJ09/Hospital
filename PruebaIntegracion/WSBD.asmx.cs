using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PruebaIntegracion
{
    /// <summary>
    /// Summary description for WSBD
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSBD : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void crearFactura(string nombre, string cedula, int id_seguro, string poliza, string telefono)
        {
            CajaBDEntities cajaBDEntities = new CajaBDEntities();
            cajaBDEntities.ppInsertarCliente( nombre, cedula,  id_seguro, poliza,telefono);
        }

        [WebMethod]
        public string[] buscarCodigo(int id)
        {
            string[] ServicioD = new string[2];
            CajaBDEntities cajaBDEntities = new CajaBDEntities();
            var servicio = cajaBDEntities.SERVICIOS.Find(id);
            ServicioD[0] = servicio.Nombre_Servicio.ToString();
            ServicioD[1] = servicio.Precio.ToString();
            string nombre = servicio.Nombre_Servicio;


            return ServicioD;
        }
    }
}
