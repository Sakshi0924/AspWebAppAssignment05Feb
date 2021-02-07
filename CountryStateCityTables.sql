use WFADotNet;

create table CountryTable(
	CId int not null primary key identity(1,1),
	CName Varchar(20)
	)

Insert into CountryTable values('India')
Insert into CountryTable values('Australia')
Insert into CountryTable values('USA')

Select * from CountryTable



create table StateTable(
	CId int Foreign Key References CountryTable(CId),
	SId int not null primary key identity(1,1),
	SName Varchar(20)
	)

Insert into StateTable values(1,'Maharashtra')
Insert into StateTable values(1,'Telengana') 
Insert into StateTable values(1,'Rajasthan')

Insert into StateTable values(2,'New South Wales')
Insert into StateTable values(2,'Tasmania')
Insert into StateTable values(2,'Victoria')

Insert into StateTable values(3,'Texas')
Insert into StateTable values(3,'Florida')
Insert into StateTable values(3,'New Jersey')


select * from StateTable

Create Table CityTable(
	SId int foreign key References StateTable(SId),
	CityId int not null primary Key identity(1,1),
	CityName Varchar(20)
	)


Insert into CityTable values(1,'Shegaon')
Insert into CityTable values(1,'Pune')
Insert into CityTable values(1,'Nagpur')

Insert into CityTable values(2,'Hyderabad')
Insert into CityTable values(2,'Warangal')
Insert into CityTable values(2,'Adilabad')

Insert into CityTable values(3,'Jaipur')
Insert into CityTable values(3,'Ajmer')
Insert into CityTable values(3,'Jodhpur')

Insert into CityTable values(4,'Sydney')
Insert into CityTable values(4,'Wollongong')
Insert into CityTable values(4,'Newcastle')

Insert into CityTable values(5,'Hobart')
Insert into CityTable values(5,'Burnie')
Insert into CityTable values(5,'Strahan')

Insert into CityTable values(6,'Geelong')
Insert into CityTable values(6,'Wodonga')
Insert into CityTable values(6,'Melbourne')

Insert into CityTable values(7,'Houstan')
Insert into CityTable values(7,'Dallas')
Insert into CityTable values(7,'Austin')

Insert into CityTable values(8,'Miami')
Insert into CityTable values(8,'Orlando')
Insert into CityTable values(8,'Tampa')

Insert into CityTable values(9,'Newark')
Insert into CityTable values(9,'Trenton')
Insert into CityTable values(9,'Paterson')

Select * from CityTable

