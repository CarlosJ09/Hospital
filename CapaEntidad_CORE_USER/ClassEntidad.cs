using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad_CORE_USER
{
    public class ClassEntidad
    {
        #region Usuario
        public int ID_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre_Rol { get; set; }
        #endregion

        #region paciente
        public int ID_Paciente { get; set; }
        public int DNI { get; set; }

        public string sexo { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public int edad { get; set; }

        public string grupo_sanguineo { get; set; }

        public string Nombre_Paciente { get; set; }
        #endregion

        #region Enfermera 
        public int ID_Enfermera { get; set; }
        public string Nombre_Enfer { get; set; }

        public string Apellido_Enfer { get; set; }

        public string Direccion_Enfer { get; set; }
        
        public int Telefono_Enfer { get; set; }
        public DateTime Fecha_Naci_Enfer { get; set; }
        public string Especialidad_Enfer { get; set; }
        #endregion

        #region Doctor
        public int ID_Doctor { get; set; }
        public string nombre_Doc { get; set; }
        public DateTime Fecha_Naci_DOC { get; set; }
        public string Direccion_Med { get; set; }
        public string telefono_Med { get; set; }
        public string especialidad { get; set; }
        #endregion

        #region Historial Medico 

        public int ID_Historial { get; set; }
        public string Antecedentes_Medicos { get; set; }
        public string Tratamiento_Actual { get; set; }
        public string Historial_Enfermedades { get; set; }
        public string Resultado_PruebaMedica { get; set; }
        public string Enfermedades_Hereditarias { get; set; }
        public string Estado { get; set; }

        #endregion

        #region Analisis 
        public int ID_Analisis { get; set; }
        public string Tipo_Analisis { get; set; }
        public DateTime Fecha_Analisis { get; set; }
        public string Resultado_Analisis  { get; set; }
        public string Observaciones_Analisis { get; set; }
        #endregion


        #region ProcedimientoMed
       public int ID_Procedimiento { get; set; }
       public string Nombre_Proced { get; set; }
       public string Descripcion_Proced { get; set; }
        public string Categoria_Proced { get; set; }
        public float Costo_Proced { get; set; }
        public DateTime Fecha_Proced { get; set; }

        #endregion 

        //Ingreso
        public int ID_ingreso { get; set; }
        public DateTime Fecha_Hora_Ingreso { get; set; }
        public string Motivo_Ingres { get; set; }

        //De alta
       public int ID_Alta { get; set; }
       public DateTime Fecha_Hora_Alta { get; set; }
       public string Diagnostico { get; set; }
       public string Tratamiento { get; set; }
       public string Observaciones { get; set; }

        //Autorizacion
        public int ID_Autorizacion { get; set; }
        public DateTime Fecha_Autorizacion { get; set; }
        public string Descripcion_Autorizacion { get; set; }
        public string Estado_Autorizacion { get; set; }


        //Cuentas 

        public int ID_Cuenta { get; set; }
        public int NumeroSeguroSocial { get; set; }
        public string Nombre_Paciente_Cuenta { get; set; }
        public int Telefono_Paciente_Cuenta { get; set; }
        public string MedicoAsignado { get; set; }
        public string CondicionMedica { get; set; }
        public string PlanTratamiento { get; set; }

    }
}
