IF OBJECT_ID(N'Project.Weather') IS NULL
BEGIN
	CREATE TABLE Project.Weather
	(   
		WeatherID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,   
		WeatherType NVARCHAR(32) NOT NULL
	);
END;