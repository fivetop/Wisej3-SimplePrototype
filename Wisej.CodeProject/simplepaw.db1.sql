BEGIN TRANSACTION;
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
	CONSTRAINT "PK_AssetBases" PRIMARY KEY("AssetBaseId" AUTOINCREMENT)
);
COMMIT;
