USE SENAI_HROADS_TARDE;

INSERT INTO Classes		(Classe)
VALUES					('Barbáro'),
						('Cruzado'),
						('Caçadora de Demônios'),
						('Monge'),
						('Necromante'),
						('Feiticeiro'),
						('Arcanista')

						INSERT INTO Personagens (Nome, CapacidadeMaximadeVida, CapacidadeMaximadeMana, DatadeAtualizacao, DatadeCriacao, idClasse)
VALUES					('DeuBug','100','80','2021-03-01','2019-01-18',1),
						('BitBug','70','100','2021-03-01','17-03-2016',4),
						('Fer8','75','60','2021-03-01','18-03-2016',7);

INSERT INTO Habilidades (Habilidade)
VALUES					('Lança Mortal'),
						('Escudo Supremo'),
						('Recuperar Vida');

INSERT INTO Intermediarias	(idClasse,idHabilidade)
VALUES						(1,1),
							(1,2),
							(2,2),
							(3,1),
							(4,3),
							(4,2),
							(5,NULL),
							(6,3),
							(7,NULL);
INSERT INTO Tipos		(Tipo,idHabilidade)
VALUES					('Ataque',1),
						('Defesa',2),
						('Cura',3),
						('Mágia',NULL);


UPDATE Classes
SET Classe = 'Necromancer'
WHERE idClasse = 5

UPDATE Personagens
SET Nome = 'Fer7'
WHERE idPersonagem = 3

INSERT INTO TipoUsuario (TipoUsuario)
VALUES					('Jogador'),('Administrador');

INSERT INTO Usuario		(Email,Senha,idTipoUsuario)
VALUES					('adm@adm.com','adm',2),
						('jogador@jogador.com','jogador',1);