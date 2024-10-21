Create Database Paulovnija;


Use Paulovnija;

CREATE TABLE Radnici (
    ID_Radnika INT PRIMARY KEY IDENTITY (1,1),
    Ime VARCHAR(50) not null,
    Prezime VARCHAR(50)not null,
    Godine INT not null,
    Pozicija VARCHAR(50) not null,
    Plata DECIMAL(10,2)not null,
);

CREATE TABLE Zadaci (
    ID_Zadatka INT PRIMARY KEY IDENTITY (1,1),
    Opis VARCHAR(255) not null,
    Datum_pocetka DATE  not null,
    Datum_zavrsetka DATE not null,
    Status_Zadatka VARCHAR(50) not null
);


CREATE TABLE Sadnice (
    ID_Sadnice INT PRIMARY KEY IDENTITY (1,1),
    Vrsta VARCHAR(50) not null,
    Visina DECIMAL(5,2) not null,
    Starost INT not null,
    Datum_sadnje DATE not null,
    ID_Rasadnika INT not null,

);


CREATE TABLE Strojevi (
    ID_Stroja INT PRIMARY KEY IDENTITY (1,1),
    Marka VARCHAR(50) not null,
    Model VARCHAR(50) not null,
    Godiste INT not null,
    Tip VARCHAR(50) not null,
    Kapacitet_rezervoara DECIMAL(10,2) not null,
    ID_Radnika INT not null
    
);


CREATE TABLE Rasadnik (
    ID_Rasadnika INT PRIMARY KEY IDENTITY (1,1),
    Naziv VARCHAR(100) not null,
    Lokacija VARCHAR(100) not null,
    Povrsina DECIMAL(10,2) not null,
    Datum_otvaranja DATE not null
);

ALTER TABLE Zadaci ADD FOREIGN KEY (ID_Zadatka) references Radnici(ID_Radnika);
ALTER TABLE Strojevi ADD FOREIGN KEY (ID_Stroja) references Radnici(ID_Radnika);
ALTER TABLE Sadnice ADD FOREIGN KEY (ID_Sadnice) references Rasadnik(ID_Rasadnika);

Select*From Radnici;

insert into Radnici (Ime,Prezime,Godine,Pozicija,Plata)
values ('Pero','Magdenovic',36,'Traktorista',1200);

insert into Radnici (Ime,Prezime,Godine,Pozicija,Plata)
values ('Josip','Maglovic',38,'Bagerist',1900);

insert into Radnici (Ime,Prezime,Godine,Pozicija,Plata)
values ('Ivan','Golub',36,'Poslovoda',3000);

Select*From Zadaci

insert into Zadaci (Opis,Datum_pocetka,Datum_zavrsetka,Status_Zadatka)
Values ('Tanjuranje','2024-05-21','2024-05-30','Nezavrsen');

insert into Zadaci (Opis,Datum_pocetka,Datum_zavrsetka,Status_Zadatka)
Values ('Vadenjekorjena','2024-05-26','2024-06-5','Nezavrsen');

insert into Zadaci (Opis,Datum_pocetka,Datum_zavrsetka,Status_Zadatka)
Values ('Zbrajanjeradnisati','2024-05-21','2024-05-28','Zavrsen');