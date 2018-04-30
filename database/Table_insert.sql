USE MotorcycleDB
GO

IF EXISTS(SELECT * FROM PersistedBrands, PersistedModels, PersistedPersons)
BEGIN
	DELETE FROM PersistedModelPerson
	DELETE FROM PersistedPersons
	DELETE FROM PersistedModels
	DELETE FROM PersistedBrands

	DBCC CHECKIDENT ('[PersistedPersons]', RESEED, 0);
	DBCC CHECKIDENT ('[PersistedModels]', RESEED, 0);
	DBCC CHECKIDENT ('[PersistedBrands]', RESEED, 0);
END



INSERT INTO PersistedBrands (Name, Description, FoundingDate, StyleDescription, Picture)
VALUES
	('Triumph' 
	,'Triumph Motorcycles Ltd. ist der Name eines Motorradherstellers in Hinckley, Großbritannien. Die Triumph Motorcycles Ltd. stellen Motorräder her, vorwiegend unter dem Markennamen Triumph.'
	,CONVERT(Date,'01-01-1884')
	,'Vintage bis Streetracing'
	,'https://www.seeklogo.net/wp-content/uploads/2017/01/triumph-motorcycles-logo.png'),
	('Yamaha'
	,'Die Yamaha Hatsudōki K.K. (Yamaha Hatsudōki kabushiki-gaisha; engl. Yamaha Motor Co., Ltd.) ist ein Unternehmen des Yamaha-Konglomerats mit Hauptsitz in Iwata, Japan. Es stellt Motorräder, Quads und Motoren her.'
	,CONVERT(Date,'06-01-1955')
	,'Vintage und Nakedbikes'
	,'https://i.pinimg.com/originals/db/1d/7e/db1d7e9c19d735ba6efcb2b48832901a.png'),
	('Ducati'
	,'Die Ducati Motor Holding S.p.A. ist ein italienischer Motorradhersteller mit Sitz in Bologna (Stadtteil Borgo Panigale) und Unternehmenstochter der Audi AG und gehört damit zum Volkswagen-Konzern.'
	,CONVERT(Date,'01-01-1926')
	,'Naked und Streetbikes'
	,'https://upload.wikimedia.org/wikipedia/commons/6/66/Ducati_red_logo.PNG'),
	('Harley-Davidson'
	,'Harley-Davidson Inc. ist ein börsennotiertes amerikanisches Unternehmen (NYSE: HOG), das hauptsächlich durch die gleichnamige Motorrad-Marke international bekannt geworden ist.'
	,CONVERT(Date,'01-01-1903')
	,'Vintage/Modern-verschnitte'
	,'https://upload.wikimedia.org/wikipedia/de/thumb/b/b4/Logo_Harley-Davidson.svg/400px-Logo_Harley-Davidson.svg.png')

INSERT INTO PersistedModels (Name, ModelSpecification, Price, BrandID, Picture)
VALUES
	('Bonneville'
	,'T-100'
	,'10000'
	,1
	,'http://triumphmotorcyclesjakarta.com/wp-content/uploads/2016/09/Triumph-MF6_MY14_Bonneville_T100_PGCX_RHS.png'),
	('Bobber'
	,'Black'
	,'12999'
	,1
	,'http://images.triumphmotorcycles.co.uk/media-library/images/configurator/modern%20classics/my18%20classics/dvx-ps-rhs_jet-black-1920-x-1080.png?w=825'),
	('Thruxton'
	,''
	,'13900'
	,1
	,'https://hessmoto.ch/img/572/0x0_ratio/triumph-thruxton-1200thruxton1200.png'),
	('MT'
	,'03'
	,'4500'
	,2
	,'http://www.popcarrent.com/wp-content/uploads/2017/07/03-1.png'),
	('MT'
	,'10'
	,'14999'
	,2
	,'https://www.yamaha-motor.ca/images/pages/products/units/MC/medium/2017_FZ-10_Grey_3.png'),
	('Monster'
	,'1200'
	,'15790'
	,3
	,'https://images.ctfassets.net/rwih0zh59mjt/39FiGaOid24ciiGYSaaC4S/dafef28a87d67cee49552b9c28f4ca7f/Monster-1200-MY18-Red-01-Model-Preview-1050x650.png'),
	('Supersport'
	,'S'
	,'14490'
	,3
	,'https://images.ctfassets.net/rwih0zh59mjt/1suAUVTnCYa62K2UQKUWIc/2ac4397a9f6247e77853153698d0a227/Supersport-MY18-Red-01-Model-Preview-1050x650.png'),
	('XL 1200'
	,'C'
	,'9999'
	,4
	,'http://www.replacementexhausts.com/wp-content/uploads/2016/06/akrapovic-exhaust-Harley-Davidson-Sportster-XL-1200C-Custom-S-HDSPSO2-HB-10.png'),
	('Heritage'
	,'Classic'
	,'22500'
	,4
	,'https://cdn.shopify.com/s/files/1/1890/9317/products/c18_FLHCS_ANV_R-legend_blue-vivid_black_e2f32f8a-7983-436d-8f6b-886f66028568_530x@2x.png?v=1505844932')

INSERT INTO PersistedPersons (FirstName, LastName, Birthdate) 
VALUES
	('Simon'
	,'Baumeler'
	,CONVERT(Date,'02-19-1999')),
	('Jonathan'
	,'Winter'
	,CONVERT(Date,'01-13-2000')),
	('Patrick'
	,'Joller'
	,CONVERT(Date,'01-01-1975'))

INSERT INTO PersistedModelPerson (PersonId, ModelId)
VALUES
	(1,1),
	(1,2),
	(1,3),
	(1,5),
	(1,6),
	(1,7),
	(1,8),
	(2,1),
	(2,3),
	(2,4),
	(2,5),
	(2,7),
	(3,1),
	(3,3),
	(3,5),
	(3,6),
	(3,7),
	(3,8),
	(3,9)	
