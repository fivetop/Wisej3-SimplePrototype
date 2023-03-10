IF NOT EXISTS (SELECT name FROM sys.server_principals WHERE name = 'IIS APPPOOL\sim')
BEGIN
    CREATE LOGIN [IIS APPPOOL\sim] 
      FROM WINDOWS WITH DEFAULT_DATABASE=[simplePA], 
      DEFAULT_LANGUAGE=[us_english]
END
GO
CREATE USER [ContosoUniversityUser] 
  FOR LOGIN [IIS APPPOOL\sim]
GO
EXEC sp_addrolemember 'db_owner', 'ContosoUniversityUser'
GO