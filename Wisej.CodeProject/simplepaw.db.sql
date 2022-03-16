BEGIN TRANSACTION;

CREATE TABLE IF NOT EXISTS "UserTrees" (
	"UserTreeId"	INTEGER NOT NULL,
	"user_group"	TEXT,
	"user_name"	TEXT,
	"login_id"	TEXT,
	"login_password"	TEXT,
	"login_password2"	TEXT,
	"mobile"	TEXT,
	"SimplePAId"	INTEGER,
	CONSTRAINT "PK_UserTrees" PRIMARY KEY("UserTreeId" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Musics" (
	"MusicId"	INTEGER NOT NULL,
	"id"	TEXT,
	"FileName"	TEXT,
	"FileContent"	TEXT,
	"FilePlay"	INTEGER,
	"deletable"	TEXT,
	"duration"	TEXT,
	"InfoTreeId"	INTEGER,
	"SimpleMultiId"	INTEGER,
	CONSTRAINT "PK_Musics" PRIMARY KEY("MusicId" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "InfoTrees" (
	"InfoTreeId"	INTEGER NOT NULL,
	"Id"	TEXT,
	"Subject"	TEXT,
	"Name"	TEXT,
	"gstreeAssetGroupId"	INTEGER,
	CONSTRAINT "PK_InfoTrees" PRIMARY KEY("InfoTreeId" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "SimpleMultis" (
	"SimpleMultiId"	INTEGER NOT NULL,
	"Id"	TEXT,
	"idno"	INTEGER NOT NULL,
	"chno"	INTEGER NOT NULL,
	"Subject"	TEXT,
	"Name"	TEXT,
	"gstreeAssetGroupId"	INTEGER,
	"stm"	TEXT NOT NULL,
	"etm"	TEXT NOT NULL,
	"duration"	TEXT,
	"week"	INTEGER NOT NULL,
	"day1"	INTEGER NOT NULL,
	"day2"	INTEGER NOT NULL,
	"day3"	INTEGER NOT NULL,
	"day4"	INTEGER NOT NULL,
	"day5"	INTEGER NOT NULL,
	"day6"	INTEGER NOT NULL,
	"day7"	INTEGER NOT NULL,
	"tss"	TEXT NOT NULL,
	"tse"	TEXT NOT NULL,
	"Color16"	TEXT,
	"overlap"	INTEGER NOT NULL,
	"weekday"	INTEGER NOT NULL,
	CONSTRAINT "PK_SimpleMultis" PRIMARY KEY("SimpleMultiId" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "AssetBases" (
	"AssetBaseId"	INTEGER NOT NULL,
	"id"	TEXT,
	"logicid"	TEXT,
	"ip"	TEXT,
	"GroupName"	TEXT,
	"ZoneName"	TEXT,
	"SpeakerName"	TEXT,
	"path"	TEXT,
	"floor"	TEXT,
	"DeviceName"	TEXT,
	"state"	TEXT,
	"state_old"	TEXT,
	"chk"	INTEGER NOT NULL DEFAULT 0,
	"seq"	INTEGER NOT NULL,
	"AssetGroupId"	INTEGER NOT NULL,
	CONSTRAINT "PK_AssetBases" PRIMARY KEY("AssetBaseId" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Holidays" (
	"HolidayId"	INTEGER NOT NULL,
	"id"	TEXT,
	"hDate"	DATETIME NOT NULL,
	"UserName"	TEXT,
	"Description"	TEXT,
	"SimplePAId"	INTEGER,
	CONSTRAINT "PK_Holidays" PRIMARY KEY("HolidayId" AUTOINCREMENT)
);

COMMIT;
