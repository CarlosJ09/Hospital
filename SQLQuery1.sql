----------------- TblPaciente ---- EXC 1 
CREATE TABLE Paciente (
    ID_Paciente INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    DNI INT,
    sexo VARCHAR(10),
    direccion VARCHAR(30),
    telefono INT,
    edad INT,
    grupo_sanguineo VARCHAR(2),
    Nombre_Paciente VARCHAR(15)
);



----------------Usuario ---- EXC2
CREATE TABLE Usuario (
    ID_Usuario INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Nombre_Usuario VARCHAR(50),
    Contraseña VARCHAR(15),
    Nombre_Rol VARCHAR(20),
);

---------- Enfermera ------ EXC3
CREATE TABLE Enfermera (
    ID_Enfermera INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Nombre_Enfer VARCHAR(30),
    Apellido_Enfer VARCHAR(30),
    Direccion_Enfer VARCHAR(50),
    Telefono INT,
    Fecha_Naci_Enfer DATE,
    Especialidad_Enfer VARCHAR(50),
    ID_Usuario INT,
    FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID_Usuario)
);


------------------ Historial medico ---- EXC4
CREATE TABLE Historial_Medico (
    ID_Historial INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    ID_Paciente INT,
    Antecedentes_Medicos VARCHAR(50),
    Tratamiento_Actual VARCHAR(50),
    Historial_Enfermedades VARCHAR(50),
    Resultado_PruebaMedica VARCHAR(50),
    Enfermedades_Hereditarias VARCHAR(100),
    Estado VARCHAR(30),
    ID_Enfermera INT,
    FOREIGN KEY (ID_Paciente) REFERENCES Paciente(ID_Paciente),
    FOREIGN KEY (ID_Enfermera) REFERENCES Enfermera(ID_Enfermera)
);

------------ Medico ----- EXC5 
CREATE TABLE Medico (
    ID_Doctor INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    nombre_Doc VARCHAR(60),
    Fecha_Naci_DOC DATE,
    direccion VARCHAR(35),
    telefono INT,
    especialidad VARCHAR(50),
    ID_Usuario INT,
    FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID_Usuario)
);




----------- Procedimiento_Medico ---- EXC6
CREATE TABLE Procedimiento_Medico (
    ID_Procedimiento INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Nombre_Proced VARCHAR(25),
    Descripcion_Proced VARCHAR(200),
    Categoria_Proced VARCHAR(30),
    Costo_Proced FLOAT,
    ID_Doctor INT,
    ID_Paciente INT,
    Fecha_Proced DATE,
    FOREIGN KEY (ID_Doctor) REFERENCES Medico(ID_Doctor),
    FOREIGN KEY (ID_Paciente) REFERENCES Paciente(ID_Paciente)
);

------------------- Autorizacion ------ EXC7
CREATE TABLE Autorizacion (
    ID_Autorizacion INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    ID_Paciente INT,
    ID_Procedimiento INT,
    ID_Doctor INT,
    Fecha_Autorizacion DATETIME,
    Descripcion_Autorizacion VARCHAR(100),
    Estado_Autorizacion VARCHAR(15),
    FOREIGN KEY (ID_Paciente) REFERENCES Paciente(ID_Paciente),
    FOREIGN KEY (ID_Procedimiento) REFERENCES Procedimiento_Medico(ID_Procedimiento),
    FOREIGN KEY (ID_Doctor) REFERENCES Medico(ID_Doctor)
);

-------------- Analisis ---- EXC 8
CREATE TABLE Analisis (
    ID_Analisis INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    ID_Paciente INT,
    Tipo_Analisis VARCHAR(50),
    Fecha_Analisis DATETIME,
    Resultado_Analisis VARCHAR(100),
    ID_Doctor INT,
    Observaciones_Analisis VARCHAR(50),
    FOREIGN KEY (ID_Paciente) REFERENCES Paciente(ID_Paciente),
    FOREIGN KEY (ID_Doctor) REFERENCES Medico(ID_Doctor)
);

----------- Ingreso -- EXC 9
CREATE TABLE Ingreso (
    ID_ingreso INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    ID_Paciente INT,
    ID_Doctor INT,
    Fecha_Hora_Ingreso DATETIME,
    Motivo_Ingreso VARCHAR(100),
    FOREIGN KEY (ID_Paciente) REFERENCES Paciente(ID_Paciente),
    FOREIGN KEY (ID_Doctor) REFERENCES Medico(ID_Doctor)
);

------------- De alta --- EXC10
CREATE TABLE Alta (
    ID_Alta INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    ID_ingreso INT,
    Fecha_Hora_Alta DATETIME,
    Diagnostico VARCHAR(100),
    Tratamiento VARCHAR(100),
    Observaciones VARCHAR(100),
    FOREIGN KEY (ID_ingreso) REFERENCES Ingreso(ID_ingreso)
);

------------ Habitacion --- EXC11
CREATE TABLE Habitacion (
    ID_Habitacion INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Numero_Habitacion INT,
    Estado_Habitacion VARCHAR(15),
    ID_Paciente INT,
    ID_Ingreso INT,
    FOREIGN KEY (ID_Paciente) REFERENCES Paciente(ID_Paciente),
    FOREIGN KEY (ID_Ingreso) REFERENCES Ingreso(ID_Ingreso)
); 

-------------------------- INSERT EN PACIENTE -----------------
INSERT INTO Paciente (DNI, sexo, direccion, telefono, edad, grupo_sanguineo, Nombre_Paciente)
VALUES
    (12345678, 'Femenino', 'Calle 123', 11111111, 25, 'A+', 'Laura'),
    (23456789, 'Masculino', 'Avenida 456', 22222222, 30, 'B-', 'Juan'),
    (34567890, 'Femenino', 'Plaza 789', 33333333, 40, 'O+', 'María'),
    (45678901, 'Masculino', 'Carrera 321', 44444444, 35, 'B+', 'Carlos'),
    (56789012, 'Femenino', 'Paseo 987', 55555555, 50, 'A-', 'Ana');

	--------------------- INSERT EN USUARIO
	INSERT INTO Usuario (Nombre_Usuario, Contraseña, Nombre_Rol)
VALUES
    ('Admin', 'contraseña1','Administrador' ),
    ('PabloLopez', 'contraseña2', 'Mantenimiento'),
    ('LuciEnfermera', 'contraseña3', 'Empleado'),
    ('DRGalan', 'contraseña4', 'Empleado'),
    ('MariaFinanzas', 'contraseña5', 'Empleado'); 

	INSERT INTO Usuario (Nombre_Usuario, Contraseña, Nombre_Rol)
VALUES
    ('Dr. Guzman', 'contraseña6', 'Empleado' ),
    ('Dra. Torres', 'contraseña7', 'Empleado'),
    ('Dr. Martínez', 'contraseña8', 'Empleado'),
    ('Dra. Sánchez', 'contraseña9', 'Empleado'),
    ('Dr. Gómez', 'contraseña10', 'Empleado');


	---------------------- INSERT EN ENFERMERA 
	INSERT INTO Enfermera (Nombre_Enfer, Apellido_Enfer, Direccion_Enfer, Telefono, Fecha_Naci_Enfer, Especialidad_Enfer, ID_Usuario)
VALUES
    ('Luci', 'Gómez', 'Calle 123', 11111111, '1990-01-01', 'Pediatría', 1),
    ('Pedro', 'López', 'Avenida 456', 22222222, '1985-02-02', 'Cardiología', 2),
    ('Ana', 'Torres', 'Plaza 789', 33333333, '1995-03-03', 'Ginecología', 3),
    ('Luis', 'Martínez', 'Carrera 321', 44444444, '1992-04-04', 'Neurología', 4),
    ('Laura', 'Sánchez', 'Paseo 987', 55555555, '1988-05-05', 'Dermatología', 5);

	---------------- INSERT EN HISTORIAL MEDICO
	INSERT INTO Historial_Medico (ID_Paciente, Antecedentes_Medicos, Tratamiento_Actual, Historial_Enfermedades, Resultado_PruebaMedica, Enfermedades_Hereditarias, Estado, ID_Enfermera)
VALUES
    (1, 'Ninguno', 'Ninguno', 'Gripe', 'Negativo', 'Ninguna', 'Activo', 1),
    (2, 'Asma', 'Inhalador', 'Bronquitis', 'Positivo', 'Asma', 'Activo', 2),
    (3, 'Diabetes', 'Insulina', 'Hipertensión', 'Positivo', 'Diabetes', 'Inactivo', 3),
    (4, 'Ninguno', 'Ninguno', 'Resfriado', 'Negativo', 'Ninguna', 'Activo', 4),
    (5, 'Hipertensión', 'Pastillas', 'Ninguna', 'Negativo', 'Ninguna', 'Activo', 5);

	Select * from Medico;
    ---------------- INSERT MEDICO
	INSERT INTO Medico (nombre_Doc, Fecha_Naci_DOC, direccion, telefono, especialidad, ID_Usuario)
VALUES
    ('Dr. Guzman', '1980-01-01', 'Calle 123', 11111111, 'Cardiología', 6),
    ('Dra. Torres', '1975-02-02', 'Avenida 456', 22222222, 'Ginecología', 7),
    ('Dr. Martínez', '1985-03-03', 'Plaza 789', 33333333, 'Pediatría', 8),
    ('Dra. Sánchez', '1982-04-04', 'Carrera 321', 44444444, 'Dermatología', 9),
    ('Dr. Gómez', '1978-05-05', 'Paseo 987', 55555555, 'Neurología', 10); 

	-------------- INSERT EN PROCEDIMIENTO MEDICO 
INSERT INTO Procedimiento_Medico (Nombre_Proced, Descripcion_Proced, Categoria_Proced, Costo_Proced, ID_Doctor, ID_Paciente, Fecha_Proced)
VALUES
    ('Cirugía de apendicitis', 'La cirugía de apendicitis es un procedimiento quirúrgico utilizado para remover el apéndice inflamado.', 'Cirugía', 1000.00, 1, 1, '2023-01-01'),
    ('Extracción del juicio', 'La extracción de muelas del juicio es un procedimiento dental que consiste en remover las muelas.', 'Odontología', 800.00, 2, 2, '2023-02-02'),
    ('Colonoscopia', 'La colonoscopia es un procedimiento endoscópico que permite examinar el colon y el recto en busca de pólipos.', 'Endoscopia', 1200.00, 3, 3, '2023-03-03'),
    ('Artroscopia de rodilla', 'La artroscopia de rodilla es un procedimiento utilizado para diagnosticar y tratar problemas en la articulación de la rodilla, como lesiones de menisco.', 'Ortopedia', 1500.00, 4, 4, '2023-04-04'),
    ('Cateterismo cardíaco', 'El cateterismo cardíaco es un procedimiento en el cual se inserta un catéter en los vasos sanguíneos del corazón para diagnosticar enfermedades cardíacas.', 'Cardiología', 2000.00, 5, 5, '2023-05-05');

	Select * from Procedimiento_Medico;
    Select * from Autorizacion;
	-------------- INSERT EN AUTORIZACION 
	INSERT INTO Autorizacion (ID_Paciente, ID_Procedimiento, ID_Doctor, Fecha_Autorizacion, Descripcion_Autorizacion, Estado_Autorizacion)
VALUES
    (1, 1, 1, '2023-01-01', 'Cirugía apendicitis', 'Aprobada'),
    (2, 2, 2, '2023-02-02', 'Extracción del juicio', 'Aprobada'),
    (3, 3, 3, '2023-03-03', 'Colonoscopia', 'En proceso'),
    (4, 4, 4, '2023-04-04', 'Artroscopia de rodilla', 'Aprobada'),
    (5, 5, 5, '2023-05-05', 'Cateterismo cardíaco', 'En proceso');

	---------------------- INSERT EN ANALISIS
	INSERT INTO Analisis (ID_Paciente, Tipo_Analisis, Fecha_Analisis, Resultado_Analisis, ID_Doctor, Observaciones_Analisis)
VALUES
    (1, 'Hemograma completo', '2023-01-01', 'Dentro de los rangos normales', 1, 'Ninguna'),
    (2, 'Panel metabólico', '2023-02-02', 'Niveles de glucosa ligeramente elevados', 2, 'En la mira'),
    (3, 'Perfil lipídico', '2023-03-03', 'Colesterol LDL alto', 3, 'Observar paciente'),
    (4, 'Análisis de orina', '2023-04-04', 'Sin anomalías detectadas', 4, 'Ninguna'),
    (5, 'Prueba de embarazo', '2023-05-05', 'Resultado negativo', 5, 'Ninguna');


	--------------------- INSERT EN INGRESO 

INSERT INTO Ingreso (ID_Paciente, ID_Doctor, Fecha_Hora_Ingreso, Motivo_Ingreso)
VALUES
    (1, 1, '2023-01-01 08:00:00', 'Infección respiratoria'),
    (2, 2, '2023-02-02 09:00:00', 'Fractura de brazo'),
    (3, 3, '2023-03-03 10:00:00', 'Dolor abdominal'),
    (4, 4, '2023-04-04 11:00:00', 'Ataque al corazón'),
    (5, 5, '2023-05-05 12:00:00', 'Accidente automovilístico');

	select * from Alta;

	-------------------- INSERT EN DE ALTA 

INSERT INTO Alta (ID_ingreso, Fecha_Hora_Alta, Diagnostico, Tratamiento, Observaciones)
VALUES
    (1, '2023-01-03 10:00:00', 'Neumonía', 'Antibióticos y reposo', 'El paciente debe realizar un seguimiento con el médico'),
    (2, '2023-02-04 11:00:00', 'Fractura de brazo', 'Inmovilización y fisioterapia', 'El paciente debe asistir a las sesiones de fisioterapia recomendadas'),
    (3, '2023-03-05 12:00:00', 'Apendicitis aguda', 'Cirugía de apendicectomía', 'El paciente debe tener cuidado con la higiene de la herida quirúrgica'),
    (4, '2023-04-06 13:00:00', 'Infarto de miocardio', 'Angioplastia coronaria y medicamentos', 'El paciente debe seguir una dieta saludable y realizar ejercicio regularmente'),
    (5, '2023-05-07 14:00:00', 'Traumatismo craneoencefálico', 'Observación y reposo', 'El paciente debe evitar actividades físicas intensas y descansar lo suficiente');


	-------------------- INSERT EN HABITACION 

	INSERT INTO Habitacion (Numero_Habitacion, Estado_Habitacion, ID_Paciente, ID_Ingreso)
VALUES
    (101, 'Disponible', 1, 1),
    (102, 'Ocupada', 2, 2),
    (103, 'Disponible', 3, 3),
    (104, 'Ocupada', 4, 4),
    (105, 'Disponible', 5, 5);

    ------- Procedimientos almacenados: 

    ---Procedure para usuarios: 

    ---- Procedimiento almacenado para listar usuarios. 

CREATE PROCEDURE pp_Listar_Usuario
as
select * from Usuario order by ID_Usuario
go

------------ proc para buscar usuario: 

CREATE PROCEDURE pp_BuscarUsuario
@Nombre_Usuario INT
as
select ID_Usuario, Nombre_Usuario, Contraseña, Nombre_Rol from Usuario where Nombre_Usuario like @Nombre_Usuario + '&'
go 

------ Proc para insertar usuario
CREATE PROCEDURE pp_InsertarUsuario
    @Nombre_Usuario VARCHAR(50),
    @Contraseña VARCHAR(15),
    @Nombre_Rol VARCHAR(20)
AS
BEGIN
    INSERT INTO Usuario (Nombre_Usuario, Contraseña, Nombre_Rol)
    VALUES (@Nombre_Usuario, @Contraseña, @Nombre_Rol)
END

------ Proc para actualizar 
CREATE PROCEDURE pp_ActualizarUsuario
    @ID_Usuario INT,
    @Nombre_Usuario VARCHAR(50),
    @Contraseña VARCHAR(15),
    @Nombre_Rol VARCHAR(20)
AS
BEGIN
    UPDATE Usuario
    SET Nombre_Usuario = @Nombre_Usuario,
        Contraseña = @Contraseña,
        Nombre_Rol = @Nombre_Rol
    WHERE ID_Usuario = @ID_Usuario
END

----- proc para eliminar usuario 
CREATE PROCEDURE pp_EliminarUsuario
    @ID_Usuario INT
AS
BEGIN
    DELETE FROM Usuario
    WHERE ID_Usuario = @ID_Usuario
END


------------------------PROCEDURE PACIENTE---------------------------


---- Procedimiento almacenado para listar

CREATE PROCEDURE pp_Listar_Paciente
as
select * from Paciente order by ID_Paciente
go





