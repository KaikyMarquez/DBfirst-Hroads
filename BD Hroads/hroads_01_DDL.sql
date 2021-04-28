CREATE DATABASE SENAI_HROADS_TARDE;

USE SENAI_HROADS_TARDE;

CREATE TABLE Classes
(
 idClasse INT PRIMARY KEY IDENTITY,
 Classe VARCHAR(200)

);

CREATE TABLE Personagens
(
	idPersonagem INT PRIMARY KEY IDENTITY,
	idClasse INT FOREIGN KEY REFERENCES Classes(idClasse),
	Nome VARCHAR (200),
	CapacidadeMaximadeVida VARCHAR (5),
	CapacidadeMaximadeMana VARCHAR (5),
	DatadeAtualizacao DATE,
	DatadeCriacao DATE

);

CREATE TABLE Habilidades
(
idHabilidade INT PRIMARY KEY IDENTITY,
Habilidade VARCHAR (200)

);

CREATE TABLE Intermediarias
(
idIntermediaria INT PRIMARY KEY IDENTITY,
idClasse INT FOREIGN KEY REFERENCES Classes(idClasse),
idHabilidade INT FOREIGN KEY REFERENCES Habilidades(idHabilidade)
);

CREATE TABLE Tipos
(
idTipo INT PRIMARY KEY IDENTITY,
idHabilidade INT FOREIGN KEY REFERENCES Habilidades(idHabilidade),
Tipo VARCHAR (200)

);

CREATE TABLE TipoUsuario
(
idTipoUsuario INT PRIMARY KEY IDENTITY,
TipoUsuario VARCHAR (200)
);

CREATE TABLE Usuario
(
idUsuario INT PRIMARY KEY IDENTITY,
idTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario(idTipoUsuario),
Email VARCHAR (200),
Senha VARCHAR (200)
);