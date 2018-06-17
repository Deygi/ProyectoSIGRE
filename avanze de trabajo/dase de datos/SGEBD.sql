create database SGEBD 
use SGEBD
alter authorization on database::SGEBD to SA

create table typeUser(
idTypeUser int primary key identity(1,1) not null,
description varchar(50) not null

)
insert into typeUser(description) values('Generador de Reportes')
insert into typeUser(description) values('Administrador')

select * from typeUser

create table Usuario(
idUser int primary key identity(1,1) not null,
idTypeUser int not null,
nomUser varchar(50) not null,
apeUser varchar(50)not null,
password varchar(20)not null,
nickNameUser varchar(20)not null,
FOREIGN KEY (idTypeUser) references typeUser(idTypeUser)
)

insert into Usuario(idTypeUser,nomUser,apeUser,password,nickNameUser) values(2,'Katty','Apellido','katty123','Katiu')
insert into Usuario(idTypeUser,nomUser,apeUser,password,nickNameUser) values(1,'Carlos','Sueldo Ulloa','control123','Carlitos')
insert into Usuario(idTypeUser,nomUser,apeUser,password,nickNameUser) values(1,'Ana','Apellido','ana123','Ana')
insert into Usuario(idTypeUser,nomUser,apeUser,password,nickNameUser) values(1,'Blanca','Huaman Vasquez','blanca123','Blanca')

select  * from Usuario

create table Market(
idMarket int primary key identity(1,1) not null,
nomMarket varchar(50),
address varchar(100),
zone varchar(100)
)
insert into Market(nomMarket,address,zone) values ('Mayorista','Jr. Ferrocaril nº123 ','Zona')
select * from Market

create table Report(
idreport int primary key identity(1,1) not null,
idUser int not null,
dateReport date not null,
idMarket int not null,
idProduct int not null,
idUbigeo int ,
FOREIGN key(idUser) references Usuario(idUser),
FOREIGN key(idMarket) references Market(idMarket),
FOREIGN key(idProduct) references Product(idProducto),
FOREIGN key(idMarket) references Ubigeo(idUbigeo)
)

create table typeUnit(
idTypeUnit int primary key identity(1,1) not null,
description varchar(100) not null,
equalUnit int not null
)
insert into typeUnit(description,equalUnit) values('kg',1)
insert into typeUnit(description,equalUnit) values('lata Gde.',1) 
insert into typeUnit(description,equalUnit) values('litro',1) 
insert into typeUnit(description,equalUnit) values('tarro',1) 
insert into typeUnit(description,equalUnit) values('bolsa x120g',1)

select * from typeUnit

select * from typeProduct

create table typeProduct(
idTypeProduct int primary key identity(1,1) not null,
description varchar(100) not null,
)
insert into typeProduct (description) values ('Tubérculos')
insert into typeProduct (description) values ('Hortalisas')
insert into typeProduct (description) values ('Legumbres')
insert into typeProduct (description) values ('Frutas')
insert into typeProduct (description) values ('Carnes y huevos')
insert into typeProduct (description) values ('Agroindustriales')
insert into typeProduct (description) values ('Menestras')
insert into typeProduct (description) values ('Otros de imp.Regional')

select * from typeProduct

create table Ubigeo(
idUbigeo int primary key identity(1,1) not null,
idDep int not null,
idProv int not null,
idDist int not null,
desDep varchar(50) not null,
desProv varchar(50) not null,
desDist varchar(50) not null,
)
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,08,01,'JUNIN','CHANCHAMAYO','CHANCHAMAYO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,08 ,02 ,'JUNIN','CHANCHAMAYO','SAN RAMON')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,08 ,03 ,'JUNIN','CHANCHAMAYO','VITOC')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,08 ,04 ,'JUNIN','CHANCHAMAYO','SAN LUIS DE SHUARO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,08 ,05 ,'JUNIN','CHANCHAMAYO','PICHANAQUI')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,08 ,06 ,'JUNIN','CHANCHAMAYO','PERENE')

insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,09 ,01 ,'JUNIN','CHUPACA','CHUPACA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,09 ,02 ,'JUNIN','CHUPACA','AHUAC')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,09 ,03 ,'JUNIN','CHUPACA','CHONGOS BAJO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,09 ,04 ,'JUNIN','CHUPACA','HUACHAC')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,09 ,05 ,'JUNIN','CHUPACA','HUAMANCACA CHICO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,09 ,06 ,'JUNIN','CHUPACA','SAN JUAN DE YSCOS')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,09 ,07 ,'JUNIN','CHUPACA','SAN JUAN DE JARPA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,09 ,08 ,'JUNIN','CHUPACA','TRES DE DICIEMBRE')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,09 ,09 ,'JUNIN','CHUPACA','YANACANCHA')

insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,02 ,01 ,'JUNIN','CONCEPCION','CONCEPCION')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,02 ,02 ,'JUNIN','CONCEPCION','ACO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,02 ,03 ,'JUNIN','CONCEPCION','ANDAMARCA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,02 ,04 ,'JUNIN','CONCEPCION','COMAS')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,02 ,05 ,'JUNIN','CONCEPCION','COCHAS')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,02 ,06 ,'JUNIN','CONCEPCION','CHAMBARA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,02 ,07 ,'JUNIN','CONCEPCION','HEROINAS TOLEDO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,02 ,08 ,'JUNIN','CONCEPCION','MANZANARES')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,02 ,09 ,'JUNIN','CONCEPCION','MARISCAL CASTILLA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,02 ,10 ,'JUNIN','CONCEPCION','MATAHUASI')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,02 ,11 ,'JUNIN','CONCEPCION','MITO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,02 ,12 ,'JUNIN','CONCEPCION','NUEVE DE JULIO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,02 ,13 ,'JUNIN','CONCEPCION','ORCOTUNA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,02 ,14 ,'JUNIN','CONCEPCION','SANTA ROSA DE OCOPA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,02 ,15 ,'JUNIN','CONCEPCION','SAN JOSE DE QUERO')

insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,01 ,'JUNIN','HUANCAYO','HUANCAYO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,03 ,'JUNIN','HUANCAYO','CARHUACALLANGA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,04 ,'JUNIN','HUANCAYO','COLCA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,05 ,'JUNIN','HUANCAYO','CULLHUAS')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,06 ,'JUNIN','HUANCAYO','CHACAPAMPA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,07 ,'JUNIN','HUANCAYO','CHICCHE')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,08 ,'JUNIN','HUANCAYO','CHILCA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,09 ,'JUNIN','HUANCAYO','CHONGOS ALTO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,12 ,'JUNIN','HUANCAYO','CHUPURO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,13 ,'JUNIN','HUANCAYO','EL TAMBO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,14 ,'JUNIN','HUANCAYO','HUACRAPUQUIO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,16 ,'JUNIN','HUANCAYO','HUALHUAS')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,18 ,'JUNIN','HUANCAYO','HUANCAN')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,19 ,'JUNIN','HUANCAYO','HUASICANCHA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,20 ,'JUNIN','HUANCAYO','HUAYUCACHI')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,21 ,'JUNIN','HUANCAYO','INGENIO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,22 ,'JUNIN','HUANCAYO','PARIAHUANCA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,23 ,'JUNIN','HUANCAYO','PILCOMAYO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,24 ,'JUNIN','HUANCAYO','PUCARA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,25 ,'JUNIN','HUANCAYO','QUICHUAY')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,25 ,'JUNIN','HUANCAYO','QUILCAS')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,27 ,'JUNIN','HUANCAYO','SAN AGUSTIN')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,28 ,'JUNIN','HUANCAYO','SAN JERONIMO DE TUNAN')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,31 ,'JUNIN','HUANCAYO','SANTO DOMINGO DE ACOBAMBA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,32 ,'JUNIN','HUANCAYO','SAÑO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,33 ,'JUNIN','HUANCAYO','SAPALLANGA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,34 ,'JUNIN','HUANCAYO','SICAYA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,01 ,36 ,'JUNIN','HUANCAYO','VIQUES')

insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,01 ,'JUNIN','JAUJA','JAUJA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,02 ,'JUNIN','JAUJA','ACOLLA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,03 ,'JUNIN','JAUJA','APATA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,04 ,'JUNIN','JAUJA','ATAURA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,05 ,'JUNIN','JAUJA','CANCHAYLLO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,06 ,'JUNIN','JAUJA','EL MANTARO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,07 ,'JUNIN','JAUJA','HUAMALI')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,08 ,'JUNIN','JAUJA','HUARIPAMPA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,09 ,'JUNIN','JAUJA','HUERTAS')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,10 ,'JUNIN','JAUJA','JANJAILLO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,11 ,'JUNIN','JAUJA','JULCAN')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,12 ,'JUNIN','JAUJA','LEONOR ORDOÑEZ')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,13 ,'JUNIN','JAUJA','LLOCLLAPAMPA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,14 ,'JUNIN','JAUJA','MARCO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,15 ,'JUNIN','JAUJA','MASMA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,16 ,'JUNIN','JAUJA','MOLINOS')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,17 ,'JUNIN','JAUJA','MONOBAMBA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,18 ,'JUNIN','JAUJA','MUQUI')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,19 ,'JUNIN','JAUJA','MUQUIYAUYO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,20 ,'JUNIN','JAUJA','PACA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,21 ,'JUNIN','JAUJA','PACCHA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,22 ,'JUNIN','JAUJA','PANCAN')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,23 ,'JUNIN','JAUJA','PARCO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,24 ,'JUNIN','JAUJA','POMACANCHA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,25 ,'JUNIN','JAUJA','RICRAN')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,26 ,'JUNIN','JAUJA','SAN LORENZO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,27 ,'JUNIN','JAUJA','SAN PEDRO DE CHUNAN')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,28 ,'JUNIN','JAUJA','SINCOS')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,29 ,'JUNIN','JAUJA','TUNAN MARCA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,30 ,'JUNIN','JAUJA','YAULI')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,31 ,'JUNIN','JAUJA','CURICACA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,32 ,'JUNIN','JAUJA','MASMA CHICCHE')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,33 ,'JUNIN','JAUJA','SAUSA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,34 ,'JUNIN','JAUJA','YAUYOS')

insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,01 ,'JUNIN','JUNIN','JUNIN')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,02 ,'JUNIN','JUNIN','CARHUAMAYO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,03 ,'JUNIN','JUNIN','ONDORES')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,04 ,'JUNIN','JUNIN','ULCUMAYO')

insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,01 ,'JUNIN','SATIPO','SATIPO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,02 ,'JUNIN','SATIPO','COVIRIALI')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,03 ,'JUNIN','SATIPO','LLAYLLA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,04 ,'JUNIN','SATIPO','MAZAMARI')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,05 ,'JUNIN','SATIPO','PAMPA HERMOSA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,06,'JUNIN','SATIPO','PANGOA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,07 ,'JUNIN','SATIPO','RIO NEGRO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,08 ,'JUNIN','SATIPO','RIO TAMBO')

insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,01 ,'JUNIN','TARMA','TARMA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,02 ,'JUNIN','TARMA','ACOBAMBA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,03 ,'JUNIN','TARMA','HUARICOLCA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,04 ,'JUNIN','TARMA','HUASAHUASI')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,05 ,'JUNIN','TARMA','LA UNION')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,06 ,'JUNIN','TARMA','PALCA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,07 ,'JUNIN','TARMA','PALCAMAYO')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,08 ,'JUNIN','TARMA','SAN PEDRO DE CAJAS')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,09 ,'JUNIN','TARMA','TAPO')

insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,01 ,'JUNIN','YAULI','LA OROYA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,02 ,'JUNIN','YAULI','CHACAPALPA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,03 ,'JUNIN','YAULI','HUAY HUAY')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,04 ,'JUNIN','YAULI','MARCAPOMACOCHA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,05 ,'JUNIN','YAULI','MOROCOCHA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,06 ,'JUNIN','YAULI','PACCHA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,07 ,'JUNIN','YAULI','SANTA BARBARA DE CARHUACAYAN')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,08 ,'JUNIN','YAULI','SUITUCANCHA')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,09 ,'JUNIN','YAULI','YAULI')
insert into Ubigeo(idDep,idProv,idDist,desDep,desProv,desDist) values(11,03 ,10 ,'JUNIN','YAULI','SANTA ROSA DE SACCO')


select * from Ubigeo



create table Sample(
idSample int primary key identity(1,2) not null,
prices varchar(300),
dateSample date
)
create table Sample_Product(
idProducto int  not null,
idSample int  not null,
FOREIGN key(idProducto) references Product(idProducto),
FOREIGN key(idSample) references Sample(idSample)
)
create table Ubigeo_Product(
idProducto int   not null,
idUbigeo int  not null,
FOREIGN key(idProducto) references Product(idProducto),
FOREIGN key(idUbigeo) references Ubigeo(idUbigeo)
)
create table Product(
idProducto int  primary key identity(1,1) not null,
nomProduct varchar(100) not null,
idTypeProduct int,
idTypeUnit int,
FOREIGN key(idTypeProduct) references typeProduct(idTypeProduct),
FOREIGN key(idTypeUnit) references typeUnit(idTypeUnit)
)
/*------------tuberculos-------------*/
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('PAPA BLANCA',1,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('PAPA COLOR',1,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('CAMOTE AMARILLO',1,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('OLLUCO LARGO',1,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('YUCA BLANCA',1,1)
/*------------hortalizas-------------*/
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('AJO ENTERO',2,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('CEBOLLA DE CABEZA',2,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('CHOCLO CRIOLLO SERRANO',2,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('TOMATE ITALIANO',2,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('ZANAHORIA',2,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('ZAPALLO MACRE',2,1)
/*------------legunbres-------------*/
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('ARVEJA VDE.BLANCA',3,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('HABA VERDE',3,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('VAINITA AMERICANA',3,1)
/*------------frutas-------------*/
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('LIMON SUTIL',4,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('MANDARINA C.PEPA',4,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('MANGO CRIOLLO HADEN',4,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('MANZANA CORRIENTE',4,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('NARANJA PARA JUGO',4,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('PALTA FUERTE',4,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('PAPAYA',4,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('PIÑA',4,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('PLATANO DE SEDA',4,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('SANDIA',4,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('Uva',4,1)
/*------------carnes y huevos-------------*/
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('CARNE DE CARNERO',5,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('CHULETA D CARNERO',5,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('CARNE DE CERDO (pulpa)',5,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('CHULETA DE CERDO',5,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('CARNE DE VACUNO',5,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('BISTECK',5,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('CORTE UNICO',5,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('MONDONGO',5,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('SANCOCHADO',5,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('POLLO EVISERADO',5,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('HUEVO A GRANEL',5,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('JUREL',5,1)
/*------------agroindustriales-------------*/
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('ACEITE COMP A GRANEL.',6,3)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('ACEITE VEGETAL EMVASADO Prim.',6,3)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('ARROZ CORRIENTE',6,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('ARROZ SUPERIOR ENV.',6,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('AZUCAR BLANCA',6,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('AZUCAR RUBIA',6,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('FIDEO A GRANEL',6,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('FIDEO ENV.TALLARIN',6,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('LECHE EVAPORADA',6,2)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('LECHE EN POLVO',6,5)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('LECHE FRESCA',6,3)
/*------------menestras-------------*/
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('FRIJOL CANARIO',7,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('FRIJOL CASTILLA',7,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('LENTEJA',7,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('PALLAR',7,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('GARBANZO',7,1)
/*------------otros de imp.regional-------------*/
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('TRUCHA',8,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('QUESO',8,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('PALTA CRIOLLA',8,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('ARVEJA GRANO SECO',8,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('CEBADA',8,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('TRIGO',8,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('MAIZ AMILACEO',8,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('QUINUA',8,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('HABA GRANO SECO',8,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('CEBOLLA DE RABO',8,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('MAIZ AMARILLO DURO',8,1)
insert into Product(nomProduct,idTypeProduct,idTypeUnit) values ('SOYA GRANO SECO',8,1)


select * from Product

