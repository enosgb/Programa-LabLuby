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

#2.1 Crie uma query para selecionar todas as pessoas 'tabela_pessoa'
# e os respectivos eventos 'tabela_evento' o qual elas participam.

SELECT pessoa.id, pessoa.nome, evento.evento 
FROM tabela_pessoa AS pessoa JOIN tabela_evento AS evento 
ON pessoa.id = evento.pessoa_id;

#2.2 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' com sobrenome 'Doe'.

SELECT * FROM tabela_pessoa 
WHERE nome LIKE '%Doe%';

#2.3 Crie uma query para adicionar um novo evento 'tabela_evento' e relacionar à pessoa 'Lisa Romero'.

INSERT INTO tabela_evento (evento,pessoa_id) VALUES('Evento E',
(SELECT id FROM tabela_pessoa WHERE nome = 'Lisa Romero'));

#2.4 Crie uma query para atualizar 'Evento D' na 'tabela_evento' e relacionar à pessoa 'Joh Doe'

UPDATE tabela_evento SET pessoa_id = (SELECT id FROM tabela_pessoa WHERE nome = 'John Doe')
WHERE evento = 'Evento D'; 

#2.5 Crie uma query para remover o 'Evento B' na 'tabela_evento'.

DELETE FROM tabela_evento WHERE evento = 'Evento B';

#2.6 Crie uma query para remover todas as pessoas 'tabela_pessoa' 
#que não possuem eventos 'tabela_evento' relacionados.
#*********
DELETE FROM tabela_pessoa
WHERE id NOT IN (SELECT DISTINCT pessoa.id FROM tabela_pessoa AS pessoa JOIN tabela_evento AS evento
ON pessoa.id = evento.pessoa_id);

#2.7 Crie uma query para alterar a tabela 'tabela_pessoa' e adicionar a coluna 'idade' (int)

ALTER TABLE tabela_pessoa
ADD COLUMN idade INT;

#2.8 Crie uma query para criar uma tabela chamada 'tabela_telefone' que pertence a uma pessoa com seguintes campos:
/*id: int (PK)
telefone: varchar(200)
pessoa_id: int(FK)*/

CREATE TABLE tabela_telefone
(	
	id INT NOT NULL AUTO_INCREMENT,
    telefone VARCHAR(100),
    pessoa_id int,
    PRIMARY KEY(id),
    FOREIGN KEY(pessoa_id) REFERENCES tabela_pessoa (id)
);

#2.9 Crie uma query para criar uma índice do tipo único na coluna telefone da 'tabela_telefone'.
ALTER TABLE tabela_telefone
ADD CONSTRAINT indice_unico UNIQUE (telefone);

#2.10 Crie uma query para remover a 'tabela_telefone'.

DROP TABLE tabela_telefone;


