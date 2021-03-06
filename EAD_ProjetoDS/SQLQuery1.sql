﻿CREATE DATABASE ProjetoDS_EAD;
USE ProjetoDS_EAD;

CREATE TABLE Usuario (
idUsuario INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100) NOT NULL,
email VARCHAR(100) NOT NULL UNIQUE,
userName VARCHAR(100) NOT NULL UNIQUE,
senha VARCHAR(50) NOT NULL UNIQUE,
tipo VARCHAR(20) NOT NULL,
ativo VARCHAR(10) NOT NULL DEFAULT 'ativo',
CPF VARCHAR(14) NOT NULL UNIQUE);

SELECT * FROM Usuario;
