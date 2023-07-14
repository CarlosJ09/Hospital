using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos_CORE_user;
using CapaEntidad_CORE_USER;
using System.Data;

namespace CapaNegocio_CoreUSER
{
    public class ClassNegocio
    {
        ClassDatos objd = new ClassDatos();
        ClassDatos objdpac = new ClassDatos();
        ClassDatos objdEnfer = new ClassDatos();
        ClassDatos objdDoc = new ClassDatos();
        ClassDatos objdHist = new ClassDatos();
        ClassDatos objdAnali = new ClassDatos();
        ClassDatos objdProcMed = new ClassDatos();
        ClassDatos objdIngresos = new ClassDatos();
        ClassDatos objdAlta = new ClassDatos();
        ClassDatos objdAutor = new ClassDatos();
        ClassDatos objdCuentas = new ClassDatos();


        #region usuario
        public DataTable N_Listar_Usuarios()
        {
            return objd.D_Listar_Usuarios();
        }

        public DataTable N_Buscar_Usuario(ClassEntidad obje)
        {
            return objd.D_Buscar_Usuario(obje);
        }

        public DataTable N_Insertar_Usuario(ClassEntidad obje)
        { return objd.D_Insertar_Usuario(obje); }

        public DataTable N_Actualizar_Usuario(ClassEntidad obje)
        {
            return objd.D_Acutualizar_Usuario(obje);
        }

        public DataTable N_Eliminar_Usuario(ClassEntidad obje)
        {
            return objd.D_Eliminar_Usuario(obje);
        }

        #endregion

        #region paciente
        //Paciente
        public DataTable N_Listar_Paciente()
        {
            return objdpac.D_Listar_Paciente();
        }

        public DataTable N_Buscar_Paciente(ClassEntidad objepac)
        {
            return objd.D_Buscar_Paciente(objepac);
        }

        public DataTable N_Insertar_Paciente(ClassEntidad objepac)
        { return objdpac.D_Insertart_Paciente(objepac); }

        public DataTable N_Actualizar_Paciente(ClassEntidad objepac)
        {
            return objdpac.D_Acutualizar_Paciente(objepac);
        }

        public DataTable N_Eliminar_Paciente(ClassEntidad objepac)
        {
            return objdpac.D_Eliminar_Paciente(objepac);
        }
        #endregion

        #region Enfermera 

        public DataTable N_Listar_Enfermera()
        {
            return objdEnfer.D_Listar_Enfermera();
        }

        public DataTable N_Buscar_Enfermera(ClassEntidad objeEnfer)
        {
            return objdEnfer.D_Buscar_Enfermera(objeEnfer);
        }

        public DataTable N_Insertar_Enfermera(ClassEntidad objeEnfer)
        { return objdEnfer.D_Insertar_Enfermera(objeEnfer); }

        public DataTable N_Actualizar_Enfermera(ClassEntidad objeEnfer)
        {
            return objdEnfer.D_Acutualizar_Enfermera(objeEnfer);
        }

        public DataTable N_Eliminar_Enfermera(ClassEntidad objeEnfer)
        {
            return objdEnfer.D_Eliminar_Enfermera(objeEnfer);
        }
        #endregion


        #region Doctor
        public DataTable N_Listar_Doctor()
        {
            return objdDoc.D_Listar_Doctor();
        }

        public DataTable N_Buscar_Doctor(ClassEntidad objeDr)
        {
            return objdDoc.D_Buscar_Doctor(objeDr);
        }

        public DataTable N_Insertar_Doctor(ClassEntidad objeDr)
        { return objdDoc.D_Insertar_Doctor(objeDr); }

        public DataTable N_Actualizar_Doctor(ClassEntidad objeDr)
        {
            return objdDoc.D_Acutualizar_Doctor(objeDr);
        }

        public DataTable N_Eliminar_Doctor(ClassEntidad objeDr)
        {
            return objdDoc.D_Eliminar_Doctor(objeDr);

        }

        #endregion

        #region Historial Medico
        public DataTable N_Listar_HistorialMedico()
        {
            return objdHist.D_Listar_HistorialMedico();
        }

        public DataTable N_Buscar_HistorialMedico(ClassEntidad objeHist)
        {
            return objdHist.D_Buscar_Historialmedico(objeHist);
        }

        public DataTable N_Insertar_HistorialMedico(ClassEntidad objeHist)
        { return objdHist.D_Insertar_HistorialMed(objeHist); }

        public DataTable N_Actualizar_HistorialMedico(ClassEntidad objeHist)
        {
            return objdHist.D_Acutualizar_HistorialMed(objeHist);
        }

        public DataTable N_Eliminar_HistorialMedico(ClassEntidad objeHist)
        {
            return objdHist.D_Eliminar_HistMed(objeHist);

        }

        #endregion

        #region Analisis
        public DataTable N_Listar_Analisis()
        {
            return objdAnali.D_Listar_Analsis();
        }

        public DataTable N_Buscar_Analisis(ClassEntidad objeAnali)
        {
            return objdAnali.D_Buscar_Analisis(objeAnali);
        }

        public DataTable N_Insertar_Analisis(ClassEntidad objeAnali)
        { return objdAnali.D_Insertar_Analisis(objeAnali); }

        public DataTable N_Actualizar_Analisis(ClassEntidad objeAnali)
        {
            return objdAnali.D_Acutualizar_Analisis(objeAnali);
        }

        public DataTable N_Eliminar_Analisis(ClassEntidad objeAnali)
        {
            return objdAnali.D_Eliminar_Analisis(objeAnali);

        }
        #endregion

        #region Procedimiento Medico 
        public DataTable N_Listar_ProcedMedicos()
        {
            return objdAnali.D_Listar_ProcedMedicos();
        }

        public DataTable N_Buscar_ProcedMed(ClassEntidad objeproc)
        {
            return objdAnali.D_Buscar_ProcedMed(objeproc);
        }

        public DataTable N_Insertar_ProcedMed(ClassEntidad objeproc)
        { return objdAnali.D_Insertar_ProcedMed(objeproc); }

        public DataTable N_Acutualizar_ProcedMed(ClassEntidad objeproc)
        {
            return objdAnali.D_Acutualizar_ProcedMed(objeproc);
        }

        public DataTable N_Eliminar_ProcedMed(ClassEntidad objeproc)
        {
            return objdAnali.D_Eliminar_ProcedMed(objeproc);

        }

        #endregion

        #region Ingresos
        public DataTable N_Listar_Ingreso()
        {
            return objdIngresos.D_Listar_Ingreso();
        }

        public DataTable N_Insertar_Ingreso(ClassEntidad objeingreso)
        {
            return objdIngresos.D_Insertar_Ingreso(objeingreso);
        }

        public DataTable N_Actualizar_Ingreso(ClassEntidad objeingreso)
        { return objdIngresos.D_Actualizar_Ingreso(objeingreso); }

        public DataTable N_Eliminar_Ingreso(ClassEntidad objeingreso)
        {
            return objdIngresos.D_Eliminar_Ingreso(objeingreso);
        }



        #endregion

        #region DeAlta
        public DataTable N_Listar_DeAlta()
        {
            return objdAlta.D_Listar_DeAlta();
        }

        public DataTable N_Insertar_DeAlta(ClassEntidad objeDeAlta)
        {
            return objdAlta.D_Insertar_DeAlta(objeDeAlta);
        }

        public DataTable N_Actualizar_DeAlta(ClassEntidad objeDeAlta)
        {
            return objdAlta.D_Actualizar_DeAlta(objeDeAlta);
        }

        public DataTable N_Eliminar_DeAlta(ClassEntidad objeDeAlta)
        {
            return objdAlta.D_Eliminar_DeAlta(objeDeAlta);
        }

        #endregion

        #region Autorizacion

        public DataTable N_Listar_Autorizaciones()
        {
            return objdAutor.D_Listar_Autorizacion();
        }

        public DataTable N_Insertar_Autorizacion(ClassEntidad objeAutor)
        {
            return objdAutor.D_Insertar_Autorizacion(objeAutor);
        }

        public DataTable N_Actualizar_Autorizacion(ClassEntidad objeAutor)
        {
            return objdAutor.D_Actualizar_Autorizacion(objeAutor);
        }

        public DataTable N_Eliminar_Autorizacion(ClassEntidad objeAutor)
        {
            return objdAutor.D_Eliminar_Autorizacion(objeAutor);
        }

        #endregion
        //Cuentas
        public DataTable N_Listar_Cuentas()
        {
            return objdCuentas.D_Listar_Cuentas();
        }

        public DataTable N_Buscar_Cuenta(ClassEntidad objecuent)
        {
            return objdCuentas.D_Buscar_Usuario(objecuent);
        }

    }
}
