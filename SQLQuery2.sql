-- Agregar una nueva columna
ALTER TABLE Enfermera
ADD Telefono_Enfer varchar(20);

-- Copiar los datos de la columna original a la nueva columna
UPDATE Enfermera
SET Telefono_Enfer = Telefono;

-- Eliminar la columna original
ALTER TABLE Enfermera
DROP COLUMN Telefono;


ALTER TABLE Medico
ADD Direccion_Med varchar(35);

-- Copiar los datos de la columna original a la nueva columna
UPDATE Medico
SET Direccion_Med = direccion;

-- Eliminar la columna original
ALTER TABLE Medico
DROP COLUMN direccion;




------------------------PROCEDURE ENFERMERA---------------------------


---- Procedimiento almacenado para listar enfermera

CREATE PROCEDURE pp_Listar_Enfermera
as
select * from Enfermera order by ID_Enfermera
go



------------ proc para buscar enfermera

CREATE PROCEDURE pp_Buscar_Enfermera
    @Nombre_Enfer VARCHAR(30)
AS
BEGIN
    SELECT Nombre_Enfer, Apellido_Enfer, Especialidad_Enfer
    FROM Enfermera
    WHERE Nombre_Enfer LIKE @Nombre_Enfer + '%';
END

------ Proc para insertar 

CREATE PROCEDURE pp_Insertar_Enfermera
    @Nombre_Enfer VARCHAR(30),
    @Apellido_Enfer VARCHAR(30),
    @Direccion_Enfer VARCHAR(50),
    @Telefono_Enfer INT,
    @Fecha_Naci_Enfer DATE,
    @Especialidad_Enfer VARCHAR(50),
    @ID_Usuario INT
AS
BEGIN
    INSERT INTO Enfermera (Nombre_Enfer, Apellido_Enfer, Direccion_Enfer, Telefono_Enfer, Fecha_Naci_Enfer, Especialidad_Enfer, ID_Usuario)
    VALUES (@Nombre_Enfer, @Apellido_Enfer, @Direccion_Enfer, @Telefono_Enfer, @Fecha_Naci_Enfer, @Especialidad_Enfer, @ID_Usuario);
END


------ Proc para actualizar 

CREATE PROCEDURE pp_Actualizar_Enfermera
    @ID_Enfermera INT,
    @Nombre_Enfer VARCHAR(30),
    @Direccion_Enfer VARCHAR(50),
    @Telefono_Enfer INT,
    @Especialidad_Enfer VARCHAR(50)
AS
BEGIN
    UPDATE Enfermera
    SET Nombre_Enfer = @Nombre_Enfer,
        Direccion_Enfer = @Direccion_Enfer,
        Telefono_Enfer = @Telefono_Enfer,
        Especialidad_Enfer = @Especialidad_Enfer
    WHERE ID_Enfermera = @ID_Enfermera;
END


----- proc para eliminar Enfermera 
CREATE PROCEDURE pp_Eliminar_Enfermera
    @ID_Enfermera INT
AS
BEGIN
    DELETE FROM Enfermera
    WHERE ID_Enfermera = @ID_Enfermera
END

-------------MEDICO 

---- Procedimiento almacenado para listar

CREATE PROCEDURE pp_Listar_Medico
AS
BEGIN
    SELECT * FROM Medico ORDER BY ID_Doctor;
END


------------ proc para buscar

CREATE PROCEDURE pp_Buscar_Medico
    @ID_Doctor INT
AS
BEGIN
    SELECT nombre_Doc, Fecha_Naci_DOC, Direccion_Med, Telefono_Med, especialidad
	FROM Medico WHERE ID_Doctor = @ID_Doctor;
END


------ Proc para insertar 
CREATE PROCEDURE pp_Insertar_Medico
    @nombre_Doc VARCHAR(60),
    @Fecha_Naci_DOC DATE,
    @Direccion_Med VARCHAR(35),
    @Telefono_Med VARCHAR (20),
    @especialidad VARCHAR(50),
    @ID_Usuario INT
AS
BEGIN
    INSERT INTO Medico (nombre_Doc, Fecha_Naci_DOC, Direccion_Med, Telefono_Med, especialidad, ID_Usuario)
    VALUES (@nombre_Doc, @Fecha_Naci_DOC, @Direccion_Med, @Telefono_Med, @especialidad, @ID_Usuario);
END



------ Proc para actualizar 
CREATE PROCEDURE pp_Actualizar_Medico
    @ID_Doctor INT,
    @nombre_Doc VARCHAR(60),
    @Direccion_Med VARCHAR(35),
    @Telefono_Med Varchar(20),
    @especialidad VARCHAR(50)
AS
BEGIN
    UPDATE Medico
    SET nombre_Doc = @nombre_Doc,
        Direccion_Med = @Direccion_Med,
        Telefono_Med = @Telefono_Med,
        especialidad = @especialidad
    WHERE ID_Doctor = @ID_Doctor;
END


----- proc para eliminar usuario 
CREATE PROCEDURE pp_Eliminar_Medico
    @ID_Doctor INT
AS
BEGIN
    DELETE FROM Medico
    WHERE ID_Doctor = @ID_Doctor;
END

--------------- HISTORIAL 

---- Procedimiento almacenado para listar

CREATE PROCEDURE pp_Listar_Historial_Medico
as
select * from Historial_Medico order by ID_Historial
go
------------ proc para buscar

CREATE PROCEDURE pp_Buscar_Historial_Medico
    @ID_Historial INT
AS
BEGIN
    SELECT Antecedentes_Medicos, Tratamiento_Actual, Historial_Enfermedades, Enfermedades_Hereditarias, Estado
	FROM Historial_Medico WHERE ID_Historial = @ID_Historial;
END



------ Proc para insertar 
CREATE PROCEDURE pp_Insertar_Historial_Medico
    @ID_Paciente INT,
    @Antecedentes_Medicos VARCHAR(50),
    @Tratamiento_Actual VARCHAR(50),
    @Historial_Enfermedades VARCHAR(50),
    @Resultado_PruebaMedica VARCHAR(50),
    @Enfermedades_Hereditarias VARCHAR(100),
    @Estado VARCHAR(30),
    @ID_Enfermera INT
AS
BEGIN
    INSERT INTO Historial_Medico (ID_Paciente, Antecedentes_Medicos, Tratamiento_Actual, Historial_Enfermedades, Resultado_PruebaMedica, Enfermedades_Hereditarias, Estado, ID_Enfermera)
    VALUES (@ID_Paciente, @Antecedentes_Medicos, @Tratamiento_Actual, @Historial_Enfermedades, @Resultado_PruebaMedica, @Enfermedades_Hereditarias, @Estado, @ID_Enfermera);
END

------ Proc para actualizar 
CREATE PROCEDURE pp_Actualizar_Historial_Medico
    @ID_Historial INT,
    @Antecedentes_Medicos VARCHAR(50),
    @Tratamiento_Actual VARCHAR(50),
    @Historial_Enfermedades VARCHAR(50),
    @Resultado_PruebaMedica VARCHAR(50),
    @Enfermedades_Hereditarias VARCHAR(100),
    @Estado VARCHAR(30),
    @ID_Enfermera INT
AS
BEGIN
    UPDATE Historial_Medico
    SET Antecedentes_Medicos = @Antecedentes_Medicos,
        Tratamiento_Actual = @Tratamiento_Actual,
        Historial_Enfermedades = @Historial_Enfermedades,
        Resultado_PruebaMedica = @Resultado_PruebaMedica,
        Enfermedades_Hereditarias = @Enfermedades_Hereditarias,
        Estado = @Estado,
        ID_Enfermera = @ID_Enfermera
    WHERE ID_Historial = @ID_Historial;
END


----- proc para eliminar 
CREATE PROCEDURE pp_Eliminar_Historial_Medico
    @ID_Historial INT
AS
BEGIN
    DELETE FROM Historial_Medico
    WHERE ID_Historial = @ID_Historial
END

-----------------ANALISIS 
---- Procedimiento almacenado para listar
CREATE PROCEDURE pp_Listar_Analisis
AS
BEGIN
    SELECT * FROM Analisis ORDER BY ID_Analisis;
END


---- Proc para buscar
CREATE PROCEDURE pp_Buscar_Analisis
    @ID_Analisis INT
AS
BEGIN
    SELECT ID_Paciente, Tipo_Analisis, Fecha_Analisis, Resultado_Analisis, ID_Doctor, Observaciones_Analisis
	FROM Analisis WHERE ID_Analisis = @ID_Analisis;
END


------ Proc para insertar 
CREATE PROCEDURE pp_Insertar_Analisis
    @ID_Paciente INT,
    @Tipo_Analisis VARCHAR(50),
    @Fecha_Analisis DATETIME,
    @Resultado_Analisis VARCHAR(100),
    @Observaciones_Analisis VARCHAR(50)
AS
BEGIN
    INSERT INTO Analisis (ID_Paciente, Tipo_Analisis, Fecha_Analisis, Resultado_Analisis, Observaciones_Analisis)
    VALUES (@ID_Paciente, @Tipo_Analisis, @Fecha_Analisis, @Resultado_Analisis, @Observaciones_Analisis);
END

DROP procedure  pp_Insertar_Analisis;
------ Proc para actualizar 
CREATE PROCEDURE pp_Actualizar_Analisis
    @ID_Analisis INT,
    @ID_Paciente INT,
    @Tipo_Analisis VARCHAR(50),
    @Fecha_Analisis DATETIME,
    @Resultado_Analisis VARCHAR(100),
    @Observaciones_Analisis VARCHAR(50)
AS
BEGIN
    UPDATE Analisis
    SET ID_Paciente = @ID_Paciente,
        Tipo_Analisis = @Tipo_Analisis,
        Fecha_Analisis = @Fecha_Analisis,
        Resultado_Analisis = @Resultado_Analisis,
        Observaciones_Analisis = @Observaciones_Analisis
    WHERE ID_Analisis = @ID_Analisis;
END


----- Proc para eliminar
CREATE PROCEDURE pp_Eliminar_Analisis
    @ID_Analisis INT
AS
BEGIN
    DELETE FROM Analisis
    WHERE ID_Analisis = @ID_Analisis;
END

------------------------PROCEDURE PROCEDIMIENTO MEDICO---------------------------


---- Procedimiento almacenado para listar

CREATE PROCEDURE pp_Listar_Procedimiento_Medico
AS
BEGIN
    SELECT * FROM Procedimiento_Medico ORDER BY ID_Procedimiento;
END

------------ proc para buscar

CREATE PROCEDURE pp_Buscar_Procedimiento_Medico
    @ID_Procedimiento INT
AS
BEGIN
    SELECT Nombre_Proced, Descripcion_Proced, Categoria_Proced, Costo_Proced
	FROM Procedimiento_Medico WHERE ID_Procedimiento = @ID_Procedimiento;
END



------ Proc para insertar 
CREATE PROCEDURE pp_Insertar_Procedimiento_Medico
    @Nombre_Proced VARCHAR(25),
    @Descripcion_Proced VARCHAR(50),
    @Categoria_Proced VARCHAR(25),
    @Costo_Proced FLOAT,
    @ID_Doctor INT,
    @ID_Paciente INT,
    @Fecha_Proced DATE
AS
BEGIN
    INSERT INTO Procedimiento_Medico (Nombre_Proced, Descripcion_Proced, Categoria_Proced, Costo_Proced, ID_Doctor, ID_Paciente, Fecha_Proced)
    VALUES (@Nombre_Proced, @Descripcion_Proced, @Categoria_Proced, @Costo_Proced, @ID_Doctor, @ID_Paciente, @Fecha_Proced);
END



------ Proc para actualizar 
CREATE PROCEDURE pp_Actualizar_Procedimiento_Medico
    @ID_Procedimiento INT,
    @Nombre_Proced VARCHAR(25),
    @Descripcion_Proced VARCHAR(50),
    @Categoria_Proced VARCHAR(25),
    @Costo_Proced FLOAT,
    @ID_Doctor INT,
    @ID_Paciente INT,
    @Fecha_Proced DATE
AS
BEGIN
    UPDATE Procedimiento_Medico
    SET Nombre_Proced = @Nombre_Proced,
        Descripcion_Proced = @Descripcion_Proced,
        Categoria_Proced = @Categoria_Proced,
        Costo_Proced = @Costo_Proced,
        ID_Doctor = @ID_Doctor,
        ID_Paciente = @ID_Paciente,
        Fecha_Proced = @Fecha_Proced
    WHERE ID_Procedimiento = @ID_Procedimiento;
END

----- proc para eliminar usuario 
CREATE PROCEDURE pp_Eliminar_Procedimiento_Medico
    @ID_Procedimiento INT
AS
BEGIN
    DELETE FROM Procedimiento_Medico
    WHERE ID_Procedimiento = @ID_Procedimiento;
END

----------------- DE ALTA 
---- Procedimiento almacenado para listar
CREATE PROCEDURE pp_Listar_Alta
AS
BEGIN
    SELECT * FROM Alta ORDER BY ID_Alta;
END


---- Proc para buscar
CREATE PROCEDURE pp_Buscar_Alta
    @ID_Alta INT
AS
BEGIN
    SELECT ID_ingreso, Fecha_Hora_Alta, Diagnostico, Tratamiento, Observaciones
	FROM Alta WHERE ID_Alta = @ID_Alta;
END


------ Proc para insertar 
CREATE PROCEDURE pp_Insertar_Alta
    @ID_ingreso INT,
    @Fecha_Hora_Alta DATETIME,
    @Diagnostico VARCHAR(100),
    @Tratamiento VARCHAR(100),
    @Observaciones VARCHAR(100)
AS
BEGIN
    INSERT INTO Alta (ID_ingreso, Fecha_Hora_Alta, Diagnostico, Tratamiento, Observaciones)
    VALUES (@ID_ingreso, @Fecha_Hora_Alta, @Diagnostico, @Tratamiento, @Observaciones);
END


------ Proc para actualizar 
CREATE PROCEDURE pp_Actualizar_Alta
    @ID_Alta INT,
    @ID_ingreso INT,
    @Fecha_Hora_Alta DATETIME,
    @Diagnostico VARCHAR(100),
    @Tratamiento VARCHAR(100),
    @Observaciones VARCHAR(100)
AS
BEGIN
    UPDATE Alta
    SET ID_ingreso = @ID_ingreso,
        Fecha_Hora_Alta = @Fecha_Hora_Alta,
        Diagnostico = @Diagnostico,
        Tratamiento = @Tratamiento,
        Observaciones = @Observaciones
    WHERE ID_Alta = @ID_Alta;
END


----- Proc para eliminar
CREATE PROCEDURE pp_Eliminar_Alta
    @ID_Alta INT
AS
BEGIN
    DELETE FROM Alta
    WHERE ID_Alta = @ID_Alta;
END


--------------------- Ingreso 

---- Procedimiento almacenado para listar
CREATE PROCEDURE pp_Listar_Ingreso
AS
BEGIN
    SELECT * FROM Ingreso ORDER BY ID_ingreso;
END


---- Proc para buscar
CREATE PROCEDURE pp_Buscar_Ingreso
    @ID_ingreso INT
AS
BEGIN
    SELECT ID_Paciente, Fecha_Hora_Ingreso, Motivo_Ingreso
	FROM Ingreso WHERE ID_ingreso = @ID_ingreso;
END


------ Proc para insertar 
CREATE PROCEDURE pp_Insertar_Ingreso
    @ID_Paciente INT,
    @ID_Doctor INT,
    @Fecha_Hora_Ingreso DATETIME,
    @Motivo_Ingreso VARCHAR(100)
AS
BEGIN
    INSERT INTO Ingreso (ID_Paciente, ID_Doctor, Fecha_Hora_Ingreso, Motivo_Ingreso)
    VALUES (@ID_Paciente, @ID_Doctor, @Fecha_Hora_Ingreso, @Motivo_Ingreso);
END


------ Proc para actualizar 
CREATE PROCEDURE pp_Actualizar_Ingreso
    @ID_ingreso INT,
    @ID_Doctor INT,
    @Fecha_Hora_Ingreso DATETIME,
    @Motivo_Ingreso VARCHAR(100)
AS
BEGIN
    UPDATE Ingreso
    SET ID_Doctor = @ID_Doctor,
        Fecha_Hora_Ingreso = @Fecha_Hora_Ingreso,
        Motivo_Ingreso = @Motivo_Ingreso
    WHERE ID_ingreso = @ID_ingreso;
END

----- Proc para eliminar
CREATE PROCEDURE pp_Eliminar_Ingreso
    @ID_ingreso INT
AS
BEGIN
    DELETE FROM Ingreso
    WHERE ID_ingreso = @ID_ingreso;
END

