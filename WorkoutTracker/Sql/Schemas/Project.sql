IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'Project'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [Project] AUTHORIZATION [dbo]');
END;