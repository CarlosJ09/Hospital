
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad_CORE_USER;

namespace CapaDatos_CORE_user
{
    public class ClassDatos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        #region Usuario
        public DataTable D_Listar_Usuarios()
        {
            SqlCommand cmd = new SqlCommand("pp_Listar_Usuario", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Buscar_Usuario(ClassEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("pp_BuscarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre_Usuario", obje.Nombre_Usuario);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

       public DataTable D_Insertar_Usuario(ClassEntidad obje) 
        {
            SqlCommand cmd = new SqlCommand("pp_InsertarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre_Usuario", obje.Nombre_Usuario);
            cmd.Parameters.AddWithValue("@Contraseña", obje.Contraseña);
            cmd.Parameters.AddWithValue("@Nombre_Rol", obje.Nombre_Rol);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
       }

        public DataTable D_Acutualizar_Usuario(ClassEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("pp_ActualizarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Usuario", obje.ID_Usuario);
            cmd.Parameters.AddWithValue("@Nombre_Usuario", obje.Nombre_Usuario);
            cmd.Parameters.AddWithValue("@Contraseña", obje.Contraseña);
            cmd.Parameters.AddWithValue("@Nombre_Rol", obje.Nombre_Rol);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Eliminar_Usuario(ClassEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("pp_EliminarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Usuario", obje.ID_Usuario);
   
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        #region Paciente 
        public DataTable D_Listar_Paciente ()
        {
            SqlCommand cmd = new SqlCommand("pp_Listar_Paciente", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable D_Buscar_Paciente (ClassEntidad objepac)
        {

            SqlCommand cmd = new SqlCommand("pp_Buscar_Paciente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Paciente", objepac.ID_Paciente);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        } 

        public DataTable D_Insertart_Paciente (ClassEntidad objepac)
        {
            SqlCommand cmd = new SqlCommand("pp_Insertar_Paciente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DNI", objepac.DNI);
            cmd.Parameters.AddWithValue("@sexo", objepac.sexo);
            cmd.Parameters.AddWithValue("@direccion", objepac.direccion);
            cmd.Parameters.AddWithValue("@telefono", objepac.telefono);
            cmd.Parameters.AddWithValue("@edad", objepac.edad);
            cmd.Parameters.AddWithValue("@grupo_sanguineo", objepac.grupo_sanguineo);
            cmd.Parameters.AddWithValue("@Nombre_Paciente", objepac.Nombre_Paciente);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Acutualizar_Paciente(ClassEntidad objepac)
        {
            SqlCommand cmd = new SqlCommand("pp_Actualizar_Paciente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@DNI", objepac.DNI);
            cmd.Parameters.AddWithValue("@sexo", objepac.sexo);
            cmd.Parameters.AddWithValue("@direccion", objepac.direccion);
            cmd.Parameters.AddWithValue("@telefono", objepac.telefono);
            cmd.Parameters.AddWithValue("@edad", objepac.edad);
            cmd.Parameters.AddWithValue("@grupo_sanguineo", objepac.grupo_sanguineo);
            cmd.Parameters.AddWithValue("@Nombre_Paciente", objepac.Nombre_Paciente);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Eliminar_Paciente(ClassEntidad objepac)
        {
            SqlCommand cmd = new SqlCommand("pp_EliminarPaciente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Paciente", objepac.ID_Paciente);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        #region Enfermera 
        public DataTable D_Listar_Enfermera()
        {
            SqlCommand cmd = new SqlCommand("pp_Listar_Enfermera", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable D_Buscar_Enfermera(ClassEntidad objeEnfer)
        {

            SqlCommand cmd = new SqlCommand("pp_Buscar_Enfermera", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre_Enfer", objeEnfer.Nombre_Enfer);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Insertar_Enfermera(ClassEntidad objeEnfer)
        {
            SqlCommand cmd = new SqlCommand("pp_Insertar_Enfermera", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre_Enfer", objeEnfer.ID_Enfermera);
            cmd.Parameters.AddWithValue("@Apellido_Enfer", objeEnfer.Apellido_Enfer);
            cmd.Parameters.AddWithValue("@Direccion_Enfer", objeEnfer.Direccion_Enfer);
            cmd.Parameters.AddWithValue("@Telefono_Enfer", objeEnfer.Telefono_Enfer);
            cmd.Parameters.AddWithValue("@Fecha_Naci_Enfer", objeEnfer.Fecha_Naci_Enfer);
            cmd.Parameters.AddWithValue("@Especialidad_Enfer", objeEnfer.Especialidad_Enfer);
          
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Acutualizar_Enfermera(ClassEntidad objeEnfer)
        {
            SqlCommand cmd = new SqlCommand("pp_Actualizar_Enfermera", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre_Enfer", objeEnfer.ID_Enfermera);
            cmd.Parameters.AddWithValue("@Apellido_Enfer", objeEnfer.Apellido_Enfer);
            cmd.Parameters.AddWithValue("@Direccion_Enfer", objeEnfer.Direccion_Enfer);
            cmd.Parameters.AddWithValue("@Telefono_Enfer", objeEnfer.Telefono_Enfer);
            cmd.Parameters.AddWithValue("@Fecha_Naci_Enfer", objeEnfer.Fecha_Naci_Enfer);
            cmd.Parameters.AddWithValue("@Especialidad_Enfer", objeEnfer.Especialidad_Enfer);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Eliminar_Enfermera(ClassEntidad objeEnfer)
        {
            SqlCommand cmd = new SqlCommand("pp_Eliminar_Enfermera", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Enfermera", objeEnfer.ID_Enfermera);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        #region Doctor 
        public DataTable D_Listar_Doctor()
        {
            SqlCommand cmd = new SqlCommand("pp_Listar_Medico", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable D_Buscar_Doctor(ClassEntidad objeDr)
        {

            SqlCommand cmd = new SqlCommand("pp_Buscar_Medico", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Doctor ", objeDr.ID_Doctor);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Insertar_Doctor(ClassEntidad objeDr)
        {
            SqlCommand cmd = new SqlCommand("pp_Insertar_Medico", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre_Doc", objeDr.nombre_Doc);
            cmd.Parameters.AddWithValue("@Fecha_Naci_DOC ", objeDr.Fecha_Naci_DOC);
            cmd.Parameters.AddWithValue("@Direccion_Med", objeDr.Direccion_Med);
            cmd.Parameters.AddWithValue("@Telefono_Med", objeDr.telefono_Med);
            cmd.Parameters.AddWithValue("@especialidad", objeDr.especialidad);
            cmd.Parameters.AddWithValue("@ID_Usuario ", objeDr.ID_Usuario);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Acutualizar_Doctor(ClassEntidad objeDr)
        {
            SqlCommand cmd = new SqlCommand("pp_Actualizar_Medico", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre_Doc", objeDr.nombre_Doc);
            cmd.Parameters.AddWithValue("@Fecha_Naci_DOC ", objeDr.Fecha_Naci_DOC);
            cmd.Parameters.AddWithValue("@Direccion_Med", objeDr.Direccion_Med);
            cmd.Parameters.AddWithValue("@Telefono_Med", objeDr.telefono_Med);
            cmd.Parameters.AddWithValue("@especialidad", objeDr.especialidad);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Eliminar_Doctor(ClassEntidad objeDr)
        {
            SqlCommand cmd = new SqlCommand("pp_Eliminar_Medico", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Doctor ", objeDr.ID_Doctor);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        #region Historial Medico 
        public DataTable D_Listar_HistorialMedico()
        {
            SqlCommand cmd = new SqlCommand("pp_Listar_Historial_Medico", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable D_Buscar_Historialmedico(ClassEntidad objeHist)
        {

            SqlCommand cmd = new SqlCommand("pp_Buscar_Historial_Medico", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Historial ", objeHist.ID_Doctor);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Insertar_HistorialMed(ClassEntidad objeHist)
        {
            SqlCommand cmd = new SqlCommand("pp_Insertar_Historial_Medico", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@@ID_Paciente", objeHist.ID_Paciente);
            cmd.Parameters.AddWithValue("@Antecedentes_Medicos ", objeHist.Antecedentes_Medicos);
            cmd.Parameters.AddWithValue("@Tratamiento_Actual", objeHist.Tratamiento_Actual);
            cmd.Parameters.AddWithValue("@Historial_Enfermedades", objeHist.Historial_Enfermedades);
            cmd.Parameters.AddWithValue("@Resultado_PruebaMedica", objeHist.Resultado_PruebaMedica);
            cmd.Parameters.AddWithValue("@Enfermedades_Hereditarias", objeHist.Enfermedades_Hereditarias);
            cmd.Parameters.AddWithValue("@Estado ", objeHist.Estado);
            cmd.Parameters.AddWithValue("@ID_Enfermera ", objeHist.ID_Enfermera);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Acutualizar_HistorialMed(ClassEntidad objeHist)
        {
            SqlCommand cmd = new SqlCommand("pp_Actualizar_Historial_Medico", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@@ID_Paciente", objeHist.ID_Paciente);
            cmd.Parameters.AddWithValue("@Antecedentes_Medicos ", objeHist.Antecedentes_Medicos);
            cmd.Parameters.AddWithValue("@Tratamiento_Actual", objeHist.Tratamiento_Actual);
            cmd.Parameters.AddWithValue("@Historial_Enfermedades", objeHist.Historial_Enfermedades);
            cmd.Parameters.AddWithValue("@Resultado_PruebaMedica", objeHist.Resultado_PruebaMedica);
            cmd.Parameters.AddWithValue("@Enfermedades_Hereditarias", objeHist.Enfermedades_Hereditarias);
            cmd.Parameters.AddWithValue("@Estado ", objeHist.Estado);
            cmd.Parameters.AddWithValue("@ID_Enfermera ", objeHist.ID_Enfermera);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Eliminar_HistMed(ClassEntidad objeHist)
        {
            SqlCommand cmd = new SqlCommand("pp_Eliminar_Historial_Medico", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Historial ", objeHist.ID_Historial);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Analisis
        public DataTable D_Listar_Analsis()
        {
            SqlCommand cmd = new SqlCommand("pp_Listar_Analisis", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable D_Buscar_Analisis(ClassEntidad objeAnali)
        {

            SqlCommand cmd = new SqlCommand("pp_Buscar_Analisis", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Analisis ", objeAnali.ID_Analisis);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Insertar_Analisis(ClassEntidad objeAnali)
        {
            SqlCommand cmd = new SqlCommand("pp_Insertar_Analisis", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Paciente", objeAnali.ID_Paciente);
            cmd.Parameters.AddWithValue("@Tipo_Analisis ", objeAnali.Tipo_Analisis);
            cmd.Parameters.AddWithValue("@Fecha_Analisis", objeAnali.Fecha_Analisis);
            cmd.Parameters.AddWithValue("@Resultado_Analisis", objeAnali.Resultado_Analisis);
            cmd.Parameters.AddWithValue("@Observaciones_Analisis", objeAnali.Observaciones_Analisis);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable D_Acutualizar_Analisis(ClassEntidad objeAnali)
        {
            SqlCommand cmd = new SqlCommand("pp_Actualizar_Analisis", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Paciente", objeAnali.ID_Paciente);
            cmd.Parameters.AddWithValue("@Tipo_Analisis ", objeAnali.Tipo_Analisis);
            cmd.Parameters.AddWithValue("@Fecha_Analisis", objeAnali.Fecha_Analisis);
            cmd.Parameters.AddWithValue("@Resultado_Analisis", objeAnali.Resultado_Analisis);
            cmd.Parameters.AddWithValue("@Observaciones_Analisis", objeAnali.Observaciones_Analisis);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Eliminar_Analisis(ClassEntidad objeAnali)
        {
            SqlCommand cmd = new SqlCommand("pp_Eliminar_Analisis", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Analisis", objeAnali.ID_Analisis);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region ProcMedicos

        public DataTable D_Listar_ProcedMedicos()
        {
            SqlCommand cmd = new SqlCommand("pp_Listar_Procedimiento_Medico", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable D_Buscar_ProcedMed(ClassEntidad objeProced)
        {

            SqlCommand cmd = new SqlCommand("pp_Buscar_Procedimiento_Medico", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Procedimiento", objeProced.ID_Procedimiento);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Insertar_ProcedMed(ClassEntidad objeProced)
        {
            SqlCommand cmd = new SqlCommand("pp_Insertar_Procedimiento_Medico", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre_Proced", objeProced.Nombre_Proced);
            cmd.Parameters.AddWithValue("@Descripcion_Proced", objeProced.Descripcion_Proced);
            cmd.Parameters.AddWithValue("@Categoria_Proced", objeProced.Categoria_Proced);
            cmd.Parameters.AddWithValue("@Costo_Proced", objeProced.Costo_Proced);
            cmd.Parameters.AddWithValue("@ID_Doctor", objeProced.ID_Doctor);
            cmd.Parameters.AddWithValue("@ID_Paciente", objeProced.ID_Paciente);
            cmd.Parameters.AddWithValue("@Fecha_Proced", objeProced.Fecha_Proced);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable D_Acutualizar_ProcedMed(ClassEntidad objeProced)
        {
            SqlCommand cmd = new SqlCommand("pp_Actualizar_Procedimiento_Medico", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Procedimiento", objeProced.ID_Procedimiento);
            cmd.Parameters.AddWithValue("@Nombre_Proced", objeProced.Nombre_Proced);
            cmd.Parameters.AddWithValue("@Descripcion_Proced", objeProced.Descripcion_Proced);
            cmd.Parameters.AddWithValue("@Categoria_Proced", objeProced.Categoria_Proced);
            cmd.Parameters.AddWithValue("@Costo_Proced", objeProced.Costo_Proced);
            cmd.Parameters.AddWithValue("@ID_Doctor", objeProced.ID_Doctor);
            cmd.Parameters.AddWithValue("@ID_Paciente", objeProced.ID_Paciente);
            cmd.Parameters.AddWithValue("@Fecha_Proced", objeProced.Fecha_Proced);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Eliminar_ProcedMed(ClassEntidad objeProced)
        {
            SqlCommand cmd = new SqlCommand("pp_Eliminar_Procedimiento_Medico", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Procedimiento", objeProced.ID_Procedimiento);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        #region Ingresos
        public DataTable D_Listar_Ingreso()
        {
            SqlCommand cmd = new SqlCommand("pp_Listar_Ingreso", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable D_Insertar_Ingreso(ClassEntidad objeingr)
        {
            SqlCommand cmd = new SqlCommand("pp_Insertar_Ingreso ", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Paciente", objeingr.ID_Paciente);
            cmd.Parameters.AddWithValue("@ID_Doctor", objeingr.ID_Doctor);
            cmd.Parameters.AddWithValue("@Fecha_Hora_Ingreso", objeingr.Fecha_Hora_Ingreso);
            cmd.Parameters.AddWithValue("@Motivo_Ingres", objeingr.Motivo_Ingres);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Actualizar_Ingreso(ClassEntidad objeingr)
        {
            SqlCommand cmd = new SqlCommand("pp_Actualizar_Ingreso", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_ingreso", objeingr.ID_ingreso);
            cmd.Parameters.AddWithValue("@ID_Paciente", objeingr.ID_Paciente);
            cmd.Parameters.AddWithValue("@ID_Doctor", objeingr.ID_Doctor);
            cmd.Parameters.AddWithValue("@Fecha_Hora_Ingreso", objeingr.Fecha_Hora_Ingreso);
            cmd.Parameters.AddWithValue("@Motivo_Ingres", objeingr.Motivo_Ingres);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Eliminar_Ingreso(ClassEntidad objeingr)
        {
            SqlCommand cmd = new SqlCommand("pp_Eliminar_Ingreso", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_ingreso", objeingr.ID_ingreso);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        #region DeAlta 
        public DataTable D_Listar_DeAlta()
        {
            SqlCommand cmd = new SqlCommand("pp_Listar_Alta", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable D_Insertar_DeAlta(ClassEntidad objeAlta)
        {
            SqlCommand cmd = new SqlCommand("pp_Insertar_Alta", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_ingreso", objeAlta.ID_ingreso);
            cmd.Parameters.AddWithValue("@Fecha_Hora_Alta", objeAlta.Fecha_Hora_Alta);
            cmd.Parameters.AddWithValue("@Diagnostico", objeAlta.Diagnostico);
            cmd.Parameters.AddWithValue("@Tratamiento", objeAlta.Tratamiento);
            cmd.Parameters.AddWithValue("@Observaciones", objeAlta.Observaciones);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Actualizar_DeAlta(ClassEntidad objeAlta)
        {
            SqlCommand cmd = new SqlCommand("pp_Actualizar_Alta", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Alta", objeAlta.ID_Alta);
            cmd.Parameters.AddWithValue("@ID_ingreso", objeAlta.ID_ingreso);
            cmd.Parameters.AddWithValue("@Fecha_Hora_Alta", objeAlta.Fecha_Hora_Alta);
            cmd.Parameters.AddWithValue("@Diagnostico", objeAlta.Diagnostico);
            cmd.Parameters.AddWithValue("@Tratamiento", objeAlta.Tratamiento);
            cmd.Parameters.AddWithValue("@Observaciones", objeAlta.Observaciones);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Eliminar_DeAlta(ClassEntidad objeAlta)
        {
            SqlCommand cmd = new SqlCommand("pp_Eliminar_Alta", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Alta", objeAlta.ID_Alta);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        #region Autorizacion

        public DataTable D_Listar_Autorizacion()
        {
            SqlCommand cmd = new SqlCommand("pp_Listar_Autorizacion", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Insertar_Autorizacion(ClassEntidad objeAutor)
        {
            SqlCommand cmd = new SqlCommand("pp_Insertar_Autorizacion", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Paciente", objeAutor.ID_Paciente);
            cmd.Parameters.AddWithValue("@ID_Procedimiento", objeAutor.ID_Procedimiento);
            cmd.Parameters.AddWithValue("@ID_Doctor", objeAutor.ID_Doctor);
            cmd.Parameters.AddWithValue("@Fecha_Autorizacion", objeAutor.Fecha_Autorizacion);
            cmd.Parameters.AddWithValue("@Descripcion_Autorizacion", objeAutor.Descripcion_Autorizacion);
            cmd.Parameters.AddWithValue("@Estado_Autorizacion", objeAutor.Estado_Autorizacion);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Actualizar_Autorizacion(ClassEntidad objeAutor)
        {
            SqlCommand cmd = new SqlCommand("pp_Actualizar_Autorizacion", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Autorizacion", objeAutor.ID_Autorizacion);
            cmd.Parameters.AddWithValue("@ID_Paciente", objeAutor.ID_Paciente);
            cmd.Parameters.AddWithValue("@ID_Procedimiento", objeAutor.ID_Procedimiento);
            cmd.Parameters.AddWithValue("@ID_Doctor", objeAutor.ID_Doctor);
            cmd.Parameters.AddWithValue("@Fecha_Autorizacion", objeAutor.Fecha_Autorizacion);
            cmd.Parameters.AddWithValue("@Descripcion_Autorizacion", objeAutor.Descripcion_Autorizacion);
            cmd.Parameters.AddWithValue("@Estado_Autorizacion", objeAutor.Estado_Autorizacion);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Eliminar_Autorizacion(ClassEntidad objeAutor)
        {
            SqlCommand cmd = new SqlCommand("pp_Eliminar_Autorizacion", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Autorizacion", objeAutor.ID_Autorizacion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        //Cuentas 

        public DataTable D_Listar_Cuentas()
        {
            SqlCommand cmd = new SqlCommand("pp_Listar_Cuentas", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Buscar_Cuentas(ClassEntidad objecuent)
        {
            SqlCommand cmd = new SqlCommand("pp_Buscar_Cuenta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Cuenta", objecuent.ID_Cuenta);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}


