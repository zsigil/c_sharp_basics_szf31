/*--Táblák létrehozása--

CREATE TABLE ugyfel (Ugyfel_neve varchar(50) NOT NULL, Ir_szam int, Varos varchar(50), Utca varchar(50), Hazszam int, Szig_Sz varchar(50) not null Primary key, Tel_sz varchar(50));
create table Konyv(Konyv_cime varchar(50) not null, ISBN varchar(50) not null primary key, Oldalszam int, Szerzo varchar(50), Kiado varchar(50));   
create table kolcsonzes (Kolcsonzes_ID int not null primary key, Sz_ig_sz varchar(50), ISBN_azon varchar(50), mikor date, 
constraint FK_kolcsonzes_ugyfel foreign key (Sz_ig_sz) references ugyfel(Szig_sz),
constraint FK_kolcsonzes_konyv foreign key (ISBN_azon) references Konyv(ISBN));

--Táblák feltöltése adatokkal--

insert into ugyfel values('Kiss Istvan', 1111, 'Budapest', 'Lejtos utca', 12, '123456', '06301234567');
insert into ugyfel values('Tóth Éva', 2222, 'Vác', 'Poros utca', 5, '456789', '06201234567');

insert into Konyv values('C programozás', 'qwe123', 1000, 'Kiss Péter', 'Computer Books');
insert into Konyv values('Java programozás', 'asd456', 2000, 'Nagy Erika', 'Computer Books');

insert into kolcsonzes values(1, '123456', 'qwe123', '2018.01.01');
insert into kolcsonzes values(2, '456789', 'asd456', '2018.02.05');
*/