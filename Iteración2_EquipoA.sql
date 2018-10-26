use DB_EQUIPO_A


CREATE TABLE Usuario(
Nombre varchar(30) PRIMARY KEY);

CREATE TABLE Anunciante(
NombreAn varchar(30) PRIMARY KEY,
Tipo varchar(15)
FOREIGN KEY (NombreAn) REFERENCES Usuario (Nombre));

CREATE TABLE Genero(
NombreGenero varchar(30) PRIMARY KEY);

CREATE TABLE Idioma(
NombreIdioma varchar(30) PRIMARY KEY);

CREATE TABLE InterpreteOriginal(
Nombre varchar(30) PRIMARY KEY);

CREATE TABLE TipoLugar(
Nombre varchar(30) PRIMARY KEY);

CREATE TABLE Provincia(
Nombre varchar(30) PRIMARY KEY);

CREATE TABLE Canton(
NombreCanton varchar(30),
NombreProvincia varchar(30) FOREIGN KEY REFERENCES Provincia (Nombre),
PRIMARY KEY(NombreCanton, NombreProvincia));

CREATE TABLE Lugar(
NombreLugar varchar(30) PRIMARY KEY,
NombreTipo varchar(30) FOREIGN KEY REFERENCES TipoLugar(Nombre),
UbicacionExacta varchar(30), 
NombreCanton varchar(30),
NombreProvincia varchar(30),
CONSTRAINT FK_Canton FOREIGN KEY (NombreCanton, NombreProvincia) REFERENCES Canton (NombreCanton, NombreProvincia));

CREATE TABLE Boleteria(
Nombre_o_URL varchar(30) PRIMARY KEY,
NombreLugar varchar(30) FOREIGN KEY REFERENCES Lugar (NombreLugar));

CREATE TABLE Cancion(
Nombre varchar(30),
NombreInterprete varchar(30) FOREIGN KEY REFERENCES InterpreteOriginal(Nombre),
NombreIdioma varchar(30) FOREIGN KEY REFERENCES Idioma (NombreIdioma),
NombreGenero varchar(30) FOREIGN KEY REFERENCES Genero (NombreGenero),
Año int,
PRIMARY KEY(Nombre, NombreInterprete));

CREATE TABLE Buscador(
Nombre varchar(30) PRIMARY KEY,
Email varchar(30),
NombreCanton varchar(30),
NombreProvincia varchar(30),
CONSTRAINT FK_Canton2 FOREIGN KEY (NombreCanton, NombreProvincia) REFERENCES Canton (NombreCanton, NombreProvincia));

CREATE TABLE Concierto(
NombreConcierto varchar(30),
NombreAn varchar(30) FOREIGN KEY REFERENCES Anunciante (NombreAn),
Cupo int,
Descripcion varchar(50),
NombreLugar varchar(30) FOREIGN KEY REFERENCES Lugar(NombreLugar),
PRIMARY KEY (NombreConcierto, NombreAn));

CREATE TABLE Entrada(
Categoria varchar(30) PRIMARY KEY,
Precio float,
NombreConcierto varchar(30),
NombreAn varchar(30),
FOREIGN KEY(NombreConcierto, NombreAn) REFERENCES Concierto (NombreConcierto, NombreAn));

CREATE TABLE Fecha_Hora(
NombreConcierto varchar(30),
NombreAn varchar(30),
Fecha_Hora smalldatetime, 
FOREIGN KEY (NombreConcierto, NombreAn) REFERENCES Concierto (NombreConcierto, NombreAn));

CREATE TABLE Favoritos(
NombreBusc varchar(30) FOREIGN KEY REFERENCES Buscador (Nombre),
NombreAn varchar(30) FOREIGN KEY REFERENCES Anunciante (NombreAn),
PRIMARY KEY(NombreBusc, NombreAn));

CREATE TABLE Me_Gustas(
NombreBusc varchar(30) FOREIGN KEY REFERENCES Buscador (Nombre),
NombreAn varchar(30) FOREIGN KEY REFERENCES Anunciante (NombreAn),
PRIMARY KEY(NombreBusc, NombreAn));

CREATE TABLE Prefiere(
NombreBusc varchar(30) FOREIGN KEY REFERENCES Buscador (Nombre),
Idioma varchar(30) FOREIGN KEY REFERENCES Idioma (NombreIdioma),
PRIMARY KEY(NombreBusc, Idioma));

CREATE TABLE Se_Consigue(
NombreBoleteria varchar(30) FOREIGN KEY REFERENCES Boleteria (Nombre_o_URL),
TipoEntrada varchar(30) FOREIGN KEY REFERENCES Entrada (Categoria),
PRIMARY KEY(NombreBoleteria, TipoEntrada));

create table Repertorio(
NombreAn varchar(30) FOREIGN KEY REFERENCES Anunciante (NombreAn),
NombreCancion varchar(30),
NombreInterprete varchar(30),
primary key(NombreAn,NombreCancion,NombreInterprete),
foreign key (NombreCancion, NombreInterprete) references Cancion(Nombre, NombreInterprete)
);

create table Se_Interesa(
NombreBusc varchar(30) foreign key references Buscador,
NombreConc varchar(30),
NombreAn varchar(30), 
primary key (NombreBusc,NombreConc,NombreAn),
foreign key (NombreConc, NombreAn) references Concierto (NombreConcierto, NombreAn));

create table Comenta(
NombreBusc varchar(30) foreign key references Buscador,
NombreConc varchar(30),
NombreAn varchar(30), 
Comentario varchar(50),
primary key (NombreBusc,NombreConc,NombreAn),
foreign key (NombreConc, NombreAn) references Concierto (NombreConcierto, NombreAn));

create table Valoracion(
NombreBusc varchar(30) foreign key references Buscador,
NombreConc varchar(30),
NombreAn varchar(30), 
Cant_Estrellas int check(1 <= Cant_Estrellas and 5 >= Cant_Estrellas),
primary key (NombreBusc,NombreConc,NombreAn),
foreign key (NombreConc, NombreAn) references Concierto (NombreConcierto, NombreAn));


create table Se_Tocan(
NombreConc varchar(30),
NombreAn varchar(30), 
NombreCancion varchar(30),
NombreInterprete varchar(30),
foreign key (NombreCancion, NombreInterprete) references Cancion(Nombre, NombreInterprete),
foreign key (NombreConc, NombreAn) references Concierto (NombreConcierto, NombreAn),
primary key (NombreConc, NombreAn, NombreCancion, NombreInterprete)
);

create table Gusta_De(
NombreGen varchar(30) FOREIGN KEY references Genero(NombreGenero),
NombreBusc varchar(30) foreign key references Buscador(Nombre),
primary key (NombreGen,NombreBusc)
);