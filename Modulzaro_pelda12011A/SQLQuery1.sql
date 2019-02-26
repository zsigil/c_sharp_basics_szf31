--Táblák létrehozása
create table Vevo (vevo_id int primary key NOT NULL, vevo_nev varchar(50) NOT NULL, irsz int, varos varchar(50), utca varchar(50), hsz int, tel varchar(50))
create table Pizza (pizza_id int primary key NOT NULL, pizza_nev varchar(50) NOT NULL, ar int NOT NULL, meret int)
create table Rendeles (rendeles_id int primary key NOT NULL, v_id int NOT NULL, p_id int NOT NULL, mennyiseg int NOT NULL, datum datetime, ido int,
constraint FK_rendeles_vevo foreign key (v_id) references Vevo(vevo_id),
constraint FK_rendelses_pizza foreign key (p_id) references pizza (pizza_id))

--Táblák feltöltése
insert into Vevo values (1,'Tóth Péter',1111, 'Budapest', 'Széles utca', 1, '06701234567')
insert into Vevo values (2,'Varga Béla', 2222, 'Győr', 'Szűk utca', 2, '06301234567')
insert into Vevo values (3,'Molnár Anna', 3333, 'Eger', 'Poros utca', 3, '06201234567')

insert into Pizza values (1, 'Vega',1000, 32)
insert into Pizza values (2,  'Magyaros', 1500, 32)
insert into Pizza values (3, 'Sonkás', 2000, 32)

insert into Rendeles values (1, 1, 1,  1, '2018.05.05', 30)
insert into Rendeles values (2, 2, 2, 2, '2018.09.10', 30)
insert into Rendeles values (3, 3, 3,  2, '2018.08.06', 40)