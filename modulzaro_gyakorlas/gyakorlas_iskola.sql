/*create table iskola (isk_azon varchar(50) not null primary key, isk_neve varchar(50), isk_varos varchar(50), isk_irszam varchar(50), isk_utca varchar(50));*/
/*
CREATE TABLE [dbo].[tanulo]
(
	[tan_azon] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [tan_nev] VARCHAR(50) NULL, 
    [tan_szul] DATE NULL, 
    [tan_varos] VARCHAR(50) NULL, 
    [tan_irszam] VARCHAR(50) NULL, 
    [tan_utca] VARCHAR(50) NULL, 
    [tan_anyjaneve] VARCHAR(50) NULL, 
    [tan_oszt] VARCHAR(50) NULL, 
    [tan_atlag] FLOAT NULL
)
*/
/*
INSERT INTO iskola values('abcdef2', 'Petőfi Sándor Ált Isk', 'Gödöllő', '2100', 'Levendula u 3.', '28/123-456');
INSERT INTO iskola values('abcdef3', 'Kossuth Lajos Ált Isk', 'Budapest', '1113', 'Karaván u 3.', '1/1234-456');
INSERT INTO iskola values('abcdef4', 'Nagy Pagony Ált Isk', 'Bugyi', '5063', 'Kutya u 5.', '42/123-456');
INSERT INTO iskola values('abcdef5', 'Kis Pagony Ált Isk', 'iassszonyfalva', '7240', 'Béka u 10.', '23/123-456');
*/
/*
INSERT INTO tanulo values('abc1', 'Kis Béci', '2008.10.02', 'Gödöllő', '2100', 'Lovász utca 2.', 'Nagy Mariska', '5.b', 3.4);
INSERT INTO tanulo values('abc2', 'Nagy Lajos', '2007.02.05', 'Budapest', '1117', 'Lovász utca 12.', 'Nagy Juliska', '4.c', 4.4);
INSERT INTO tanulo values('abc3', 'Csöpp Beáta', '2008.11.02', 'Budapest', '1134', 'Kisrigó utca 2.', 'Nagy Lola', '10.b', 5.0);
INSERT INTO tanulo values('abc4', 'Zöld Virág', '2008.09.02', 'Budapest', '1216', 'Lovász utca 5.', 'Kiss Éva', '7.a', 3.9);
INSERT INTO tanulo values('abc5', 'Kovács Aranka', '2008.01.12', 'Gyöngyös', '2567', 'Petőfi utca 2.', 'Kovács Mariann', '3.d', 2.4);

INSERT INTO iskolatanulo values(1, 'abcdef3', 'abc2');
INSERT INTO iskolatanulo values(2, 'abcdef3', 'abc3');
INSERT INTO iskolatanulo values(3, 'abcdef3', 'abc4');
INSERT INTO iskolatanulo values(4, 'abcdef2', 'abc1');
INSERT INTO iskolatanulo values(5, 'abcdef5', 'abc5');
*/