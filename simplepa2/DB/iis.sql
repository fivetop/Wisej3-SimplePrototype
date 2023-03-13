IF NOT EXISTS (SELECT name FROM sys.server_principals WHERE name = 'IIS APPPOOL\simplepa')
BEGIN
    CREATE LOGIN [IIS APPPOOL\simplepa] 
      FROM WINDOWS WITH DEFAULT_DATABASE=[simplePA], 
      DEFAULT_LANGUAGE=[us_english]
END
GO
CREATE USER [SimpleUser] 
  FOR LOGIN [IIS APPPOOL\simplepa]
GO
EXEC sp_addrolemember 'db_owner', 'SimpleUser'
GO
