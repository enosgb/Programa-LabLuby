CREATE DATABASE luby_software;
USE lubysoftware;

#desabilitar safe mode

SET SQL_SAFE_UPDATES = 0;

#criando tabelas iniciais 

CREATE TABLE tabela_pessoa
(
	id INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(30) NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE tabela_evento
(
	id INT NOT NULL AUTO_INCREMENT,
    evento VARCHAR(30) NOT NULL,
    pessoa_id INT NULL,
    PRIMARY KEY(id)
);

#Inserindo dados iniciais na tabela pessoa
INSERT INTO tabela_pessoa VALUES(1,'John Doe');
INSERT INTO tabela_pessoa VALUES(2,'Jane Doe');
INSERT INTO tabela_pessoa VALUES(3,'Alice Jones');
INSERT INTO tabela_pessoa VALUES(4,'Bobby Louis');
INSERT INTO tabela_pessoa VALUES(5,'Lisa Romero');

#Inserindo dados iniciais na tabela eventos
INSERT INTO tabela_evento VALUES(1,'Evento A',2);
INSERT INTO tabela_evento VALUES(2,'Evento B',3);
INSERT INTO tabela_evento VALUES(3,'Evento C',2);
INSERT INTO tabela_evento VALUES(4,'Evento D',null);

SELECT * FROM tabela_pessoa;
SELECT * FROM tabela_evento;
