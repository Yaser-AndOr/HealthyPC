use master
go

create database HealthyPC
go

create table Usuario(
IDUsuario int Identity(0,1) NOT NULL,
Correo varchar(255) Unique,
Contraseña varchar(16),
Clave varchar(29) Unique,
PCActivada varchar (max) 
constraint PK_alumno primary key (IDUsuario)
);
go

use HealthyPC
go

create table BenchPromCPU(
ModeloCPU varchar Not Null Unique,
Puntaje int Not Null,
ModoTest varchar(16) Not Null
);

create table BenchCPU(
ModeloCPU varchar Not Null,
Puntaje int Not Null,
ModoTest varchar(16) Not Null
);

create table BenchPromGPU(
ModeloGPU varchar Not Null Unique,
Puntaje int Not Null,
ModoTest varchar(16) Not Null
);

create table BenchGPU(
ModeloGPU varchar Not Null,
Puntaje int Not Null,
ModoTest varchar(16) Not Null
);

create table Actualización(
Versión varchar Unique Not Null,
Link varchar Unique Not Null,
);