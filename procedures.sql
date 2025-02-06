CREATE PROC SP_Insertar
@Id INT,
@Nombre NVARCHAR(60),
@Correo NVARCHAR(30),
@Contrasenia NVARCHAR(30),
@Rol NVARCHAR(15)

AS
INSERT INTO Usuario VALUES(@Id, @Nombre, @Correo,@Contrasenia,@Rol)
GO



CREATE PROC SP_Insertar_Sala
@NUMERO_SALA INT,
@CANTIDAD_ASIENTOS INT,
@TIPO_SALA NVARCHAR(30),
@PRECIO INT


AS 
INSERT INTO Sala VALUES(@NUMERO_SALA,@CANTIDAD_ASIENTOS,@TIPO_SALA,@PRECIO)
GO
CREATE PROCEDURE SP_INSERTAR_PELICULA
@NOMBRE NVARCHAR(60),
@DESCRIPCION NVARCHAR(MAX),
@IMAGEN IMAGE,
@DURACION NVARCHAR(20),
@GENERO NVARCHAR(20)

AS
INSERT INTO Pelicula VALUES(@NOMBRE,@DESCRIPCION,@IMAGEN,@DURACION,@GENERO)
GO

CREATE PROCEDURE SP_INICIAR_SESION
@CORREO NVARCHAR(30),
@CONTRASENIA NVARCHAR(30)
AS
SELECT * FROM Usuario WHERE Correo=@CORREO AND Contrasenia=@CONTRASENIA 
GO
CREATE PROC INICIO_SESION(
@CORREO NVARCHAR(30),
@CONTRASENIA NVARCHAR (30)
)
AS
BEGIN
 SELECT *FROM
 Usuario
 WHERE
 Correo = @CORREO AND Contrasenia = @CONTRASENIA
 RETURN
 END


 CREATE PROC SP_BUSCAR_PELI
AS
SELECT * FROM Pelicula
GO
USE Sistema_cine
GO

CREATE PROCEDURE  SP_INSERTAR_FUNCION
@ID_PELICULA INT,
@NUM_SALA INT,
@HORARIO NVARCHAR(10),
@ASIENTOS INT

AS  
BEGIN
   
    BEGIN TRANSACTION;

    
    INSERT INTO Funcion (Id_pelicula, Num_sala, Horario, Asientos_disponibles)
    VALUES (@ID_PELICULA, @NUM_SALA, @HORARIO, @ASIENTOS);

  
    UPDATE Funcion
    SET Funcion.Asientos_disponibles = Sala.Cantidad_asientos
    FROM Funcion
    INNER JOIN Sala ON Funcion.Num_sala = Sala.Numero_sala
    WHERE Funcion.Num_sala = @NUM_SALA AND Funcion.Id_pelicula = @ID_PELICULA AND Funcion.Horario = @HORARIO;

    COMMIT;
END;
GO


 CREATE PROC SP_BUSCAR_SALA
AS
SELECT * FROM Sala
GO
USE Sistema_cine
GO

CREATE PROC CARTELERA
AS
SELECT TOP 3 *
FROM Pelicula
ORDER BY Id_peli DESC
GO
USE Sistema_cine
GO

CREATE PROC Consulta_funciones
	@idPeli int
AS
BEGIN
	SET NOCOUNT ON;
SELECT        Pelicula.Nombre, Pelicula.Imagen, Funcion.Horario, Funcion.Num_sala,Funcion.Numero_funcion, Sala.Precio, Sala.Tipo_sala, Funcion.asientos_disponibles
FROM            Funcion INNER JOIN
                         Pelicula ON Funcion.Id_pelicula = Pelicula.Id_peli INNER JOIN
                         Sala ON Funcion.Num_sala = Sala.Numero_sala where Id_peli=@idPeli


						 
END
GO

CREATE PROCEDURE SELECT_TIPO_SALA
(
    @Numero_sala NVARCHAR(30)
) 
AS
BEGIN
    SELECT Precio
    FROM sala
    WHERE Numero_sala = @Numero_sala;
END
GO


CREATE PROC PELI_SELECT(
@ID_PELI INT
)
AS
SELECT * FROM Pelicula WHERE Id_peli = @ID_PELI
GO
USE Sistema_cine
GO
Consulta_funciones 1011
select * from Funcion

CREATE PROC SP_MODIFICAR_ASIENTOS
@NUMERO_FUNCION INT,
@DISPONIBLES INT
AS
UPDATE Funcion SET   asientos_disponibles  = @DISPONIBLES
WHERE Numero_funcion = @NUMERO_FUNCION
GO 
