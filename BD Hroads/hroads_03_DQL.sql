
--06--
SELECT * FROM Personagens

--07--
SELECT * FROM Classes

--08--
SELECT Classes.Classe FROM Classes

--09--
SELECT * FROM Habilidades

--10--
SELECT COUNT (Habilidades.Habilidade) as Quantidade_Cadastrada FROM Habilidades

--11--
SELECT Habilidades.idHabilidade FROM Habilidades ORDER BY idHabilidade ASC

--12--
SELECT Tipos.tipo FROM Tipos

--13--
SELECT * FROM Habilidades
LEFT JOIN Tipos
ON Habilidades.idHabilidade = Tipos.idHabilidade

--14--
SELECT * FROM Personagens
LEFT JOIN Classes
ON Personagens.idClasse = Classes.idClasse

--15--
SELECT * FROM Personagens
Right Join Classes
ON Personagens.idClasse = Classes.idClasse



--16--
SELECT Classes.Classe, Habilidades.Habilidade FROM Intermediarias
RIGHT Join Classes
ON Intermediarias.idClasse = Classes.idClasse 
LEFT Join Habilidades
ON Intermediarias.idHabilidade = Habilidades.idHabilidade

--17--
SELECT Habilidades.Habilidade, Classes.Classe FROM Intermediarias
INNER Join Habilidades
ON Intermediarias.idHabilidade = Habilidades.idHabilidade
INNER Join Classes
ON Intermediarias.idClasse = Classes.idClasse 

--18--
SELECT  Habilidades.Habilidade, Classes.Classe FROM Intermediarias
RIGHT Join Classes
ON Intermediarias.idClasse = Classes.idClasse 
LEFT Join Habilidades
ON Intermediarias.idHabilidade = Habilidades.idHabilidade

-- Usuario --
SELECT Email,Senha,TipoUsuario FROM Usuario
INNER Join TipoUsuario
ON Usuario.idTipoUsuario = TipoUsuario.idTipoUsuario

-- TipoUsuario --
SELECT TipoUsuario From TipoUsuario



