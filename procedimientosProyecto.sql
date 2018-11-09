use DB_EQUIPO_A;

--drop procedure agregarAnunciante

--AGREGAR ANUNCIANTE
GO
CREATE PROCEDURE agregarAnunciante 
	@nombre varchar(30), 
	@tipo varchar(15)
AS
INSERT INTO Usuario(Nombre)
VALUES(@nombre);
INSERT INTO Anunciante (NombreAn,Tipo)
VALUES(@nombre ,@tipo);

--AGREGAR INTERPRETES ORIGINALES
GO
CREATE PROCEDURE agregarInterprete
	@nombre varchar(30)
AS
INSERT INTO InterpreteOriginal(Nombre)
VALUES(@nombre); 

--AGREGAR CANCIONES
GO
CREATE PROCEDURE agregarCanciones
	@nombre varchar(30),
	@nombreIn varchar(30),
	@idioma varchar(30),
	@genero varchar(30)
AS
INSERT INTO Cancion(Nombre, NombreInterprete, NombreIdioma, NombreGenero)
VALUES(@nombre, @nombreIn, @idioma, @genero);

-- AGREGAR TIPOS DE ENTRADA
GO
CREATE PROCEDURE agregarTipoDeEntrada
	@categoria VARCHAR(30),
	@precio FLOAT,
	@nombreConcierto VARCHAR(30),
	@nombreAnunciante VARCHAR(30)
AS
	INSERT INTO Entrada(Categoria, Precio, NombreConcierto, NombreAn)
	VALUES(@categoria, @precio, @nombreConcierto, @nombreAnunciante);

--AGREGAR LUGAR
GO
CREATE PROCEDURE agregarLugar
	@nombre varchar(30),
	@tipoLugar varchar(30),
	@ubicacion varchar(30),
	@canton varchar(30),
	@provincia varchar(30)
AS
INSERT INTO Lugar(NombreLugar, NombreTipo, UbicacionExacta, NombreCanton, NombreProvincia)
VALUES(@nombre, @tipoLugar, @ubicacion, @canton, @provincia)

--AGREGAR CONCIERTO
GO
CREATE PROCEDURE agregarConcierto
	@nombre varchar(30),
	@nombreAn varchar(30),
	@cupo int,
	@descripcion varchar(50),
	@lugar varchar(30)
AS
INSERT INTO Concierto(NombreConcierto, NombreAn, Cupo, Descripcion, NombreLugar)
VALUES(@nombre, @nombreAn, @cupo, @descripcion, @lugar)


--CONSULTAR ANUNCIANTE POR NOMBRE
GO
CREATE PROCEDURE consultarAnuncianteNombre
	@nombreUsuario varchar(30)
AS
SELECT NombreAn
FROM Anunciante
WHERE NombreAn = @nombreUsuario

--CONSULTAR CONCIERTOS
GO
CREATE PROCEDURE consultarConciertos
@nomAn VARCHAR(30)
AS
SELECT *
FROM Concierto
WHERE NombreAn =  @nomAn

drop function filtrarConciertos

GO
CREATE FUNCTION filtrarConciertos(@nombre VARCHAR(30), @filtroTexto
VARCHAR(30), @nomAn VARCHAR(30))
RETURNS TABLE
AS
RETURN (
SELECT *
FROM Concierto e
WHERE e.NombreAn = @nomAn and e.NombreConcierto LIKE '%' + @nombre + '%'
AND (e.NombreConcierto LIKE '%' + @filtroTexto + '%'
OR e.Cupo LIKE '%' + @filtroTexto + '%'
OR e.NombreAn LIKE '%' + @filtroTexto + '%'
OR e.Descripcion LIKE '%' + @filtroTexto + '%'
OR e.NombreLugar LIKE '%' + @filtroTexto + '%'));



 
