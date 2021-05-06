DROP TABLE IF EXISTS Project.Workout;
DROP TABLE IF EXISTS Project.Session;
DROP TABLE IF EXISTS Project.Environment;
DROP TABLE IF EXISTS Project.Weather;
DROP TABLE IF EXISTS Project.Location;
DROP TABLE IF EXISTS Project.DailyMetrics;

 CREATE TABLE Project.DailyMetrics
    (   
        MetricID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,   
        Date NVARCHAR(32) NOT NULL ,
        Weight FLOAT NOT NULL,     
        SleepDuration FLOAT NOT NULL, 
        Calories FLOAT NOT NULL
    );

 CREATE TABLE Project.Location
    (   
        LocationID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,   
        Name NVARCHAR(32) NOT NULL
    );


CREATE TABLE Project.Weather
(   
	WeatherID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,   
	WeatherType NVARCHAR(32) NOT NULL
);


CREATE TABLE Project.Environment
(   
    EnvironmentID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,   
    WeatherID INT NOT NULL, 
    LocationID INT NOT NULL,
    IsIndoor INT 

	CONSTRAINT FK_Project_Environment_Project_Weather FOREIGN KEY(WeatherID)
	REFERENCES Project.Weather(WeatherID),

    CONSTRAINT FK_Project_Environment_Project_Location FOREIGN KEY(LocationID)
    REFERENCES Project.Location(LocationID)
);


CREATE TABLE Project.Session
(   
    SessionID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY ,   
    MetricID INT NOT NULL,
    EnvironmentID INT NOT NULL,
    StartTime NVARCHAR(32) NOT NULL, 
    EndTime NVARCHAR(32) NOT NULL, 
    Rating FLOAT NOT NULL
	
	CONSTRAINT FK_Project_Session_Project_DailyMetrics FOREIGN KEY(MetricID)
	REFERENCES Project.DailyMetrics(MetricID),

    CONSTRAINT FK_Project_Session_Project_Environment FOREIGN KEY(EnvironmentID)
    REFERENCES Project.Environment(EnvironmentID)
);

CREATE TABLE Project.Workout
(   
    WorkoutID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    SessionID INT NOT NULL,   
    Duration FLOAT NOT NULL,
    AvgHeartRate FLOAT NOT NULL

	CONSTRAINT FK_Project_Workout_Project_Session FOREIGN KEY(SessionID)
	REFERENCES Project.Session(SessionID)
);