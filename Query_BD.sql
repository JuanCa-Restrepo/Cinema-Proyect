create database Sistema_cine
use Sistema_cine

create table Usuario(
Id_user int primary key not null,
Nombre NVARCHAR(60),
Correo NVARCHAR(30),
Contrasenia NVARCHAR(30),
Rol NVARCHAR(15)
)

insert into Usuario(Id_user,Nombre,Correo,Contrasenia,Rol)
values(103223,'Juanca','juan@123','123','admin')
select * from Usuario

create table Pelicula(
Id_peli int primary key identity (1010,1) not null,
Nombre NVARCHAR(60),
Descripcion NVARCHAR(MAX),
Imagen IMAGE,
Duracion NVARCHAR(20),
Genero NVARCHAR(20)
)
create table Sala(
Numero_sala int primary key  not null,
Cantidad_asientos INT,
Tipo_sala NVARCHAR(30),
Precio int
)

create table Funcion(
Numero_funcion int primary key identity (1010,10) not null,
Id_pelicula INT,
Num_sala INT,
Horario NVARCHAR(10),
asientos_disponibles int
CONSTRAINT FK_Funcion_Id_pelicula FOREIGN KEY (Id_pelicula) REFERENCES Pelicula(Id_peli),
CONSTRAINT FK_Funcion_Num_sala FOREIGN KEY (Num_sala) REFERENCES Sala(Numero_sala)

)

create table Venta(
Numero_venta int primary key identity (1010,10) not null,
Num_funcion INT,
valor_pagar int,
Fecha DATETIME
CONSTRAINT FK_Venta_Num_funcon FOREIGN KEY (Num_funcion) REFERENCES Funcion(Numero_funcion) 

)

select * from Sala



