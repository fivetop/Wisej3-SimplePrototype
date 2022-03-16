CREATE TABLE "Musics" (
	"MusicId"	INTEGER NOT NULL,
	"id"	TEXT,
	"FileName"	TEXT,
	"FileContent"	TEXT,
	"FilePlay"	INTEGER,
	"deletable"	TEXT,
	"duration"	TEXT,
	"InfoTreeId"	INTEGER,
	"SimpleMultiId"	INTEGER,
	CONSTRAINT "FK_Musics_InfoTrees_InfoTreeId" FOREIGN KEY("InfoTreeId") REFERENCES "InfoTrees"("InfoTreeId") ON DELETE RESTRICT,
	CONSTRAINT "FK_Musics_SimpleMultis_SimpleMultiId" FOREIGN KEY("SimpleMultiId") REFERENCES "SimpleMultis"("SimpleMultiId") ON DELETE RESTRICT,
	CONSTRAINT "PK_Musics" PRIMARY KEY("MusicId" AUTOINCREMENT)
);

INSERT INTO "Musics" ("MusicId", "id", "FileName", "FileContent", "FilePlay", "deletable", "duration", "InfoTreeId", "SimpleMultiId") VALUES
('1', 'D9CA6DA3-DD31-4E9F-93C1-A2FAE2A64ADF', '민방공+공습경보(3분).mp3', '', '1', 'N', '00:03:07', NULL, NULL),
('2', '8697CB71-278F-4F9A-B8F2-889B5DC7ECC9', '03. Track 3.mp3', '', '1', 'N', '00:05:35', NULL, NULL),
('3', '88E76A5C-E9FE-4D05-A11B-90AB7D236C3E', '01. Track 1.mp3', '01. Track 1.mp3', '1', 'Y', '', NULL, NULL),
('4', 'DBDABB6F-65B9-4107-A7F8-7C006FE79D51', 'KpopSong.mp3', '', '1', 'N', '02:26:56', NULL, NULL),
('5', '0C732C81-B63A-4406-B936-A48A14DC389A', '종료종소리.mp3', '', '1', 'N', '00:00:08', NULL, NULL),
('6', '7BF5DC22-4057-41D5-93BA-76A320D0189C', '재난위험경보(3분).mp3', '', '1', 'N', '00:03:05', NULL, NULL),
('7', '4FD7A036-469E-4E46-9703-03BC83F018FF', '시작종소리.mp3', '', '1', 'N', '00:00:11', NULL, NULL),
('8', '9B363D36-9789-4AA5-876F-F2C143874E40', '민방공+경계경보(1분).mp3', '', '1', 'N', '00:01:00', NULL, NULL),
('9', '9F83C083-789C-4048-8A9F-3F9EAABCA7FD', '07. Track 7.mp3', '', '1', 'N', '00:10:20', NULL, NULL),
('10', '95E45AF6-208A-4608-9E68-3DE2B602C005', 'y2mate.com - 2000년대 노래모음 시리즈2010년 노래모음 40곡 연속듣기 2010년 히트했던 댄스 발라드 노래모음 보고듣는 소울뮤직TV_320kbps.mp3', '', '1', 'N', '02:26:56', NULL, NULL),
('11', 'BF152EB2-6798-4214-AE71-D6DC9061FEB9', 'Evegeny Svetlanov - Wagner.mp3', '', '1', 'N', '00:56:43', NULL, NULL),
('12', '23A6E858-0544-452C-B6A6-EC6E663DBFDD', 'Amaryllis.mp3', '', '1', 'N', '00:00:24', NULL, NULL),
('13', 'E6C3BF84-E654-492D-B8E0-A7AD05FE7986', 'A Maidens Prayer.mp3', '', '1', 'N', '00:00:18', NULL, NULL),
('14', '7F8DEFFC-071E-4910-84EF-CA9B021023BF', '05-idina_menzel-let_it_go.mp3', '', '1', 'N', '00:03:45', NULL, NULL),
('15', 'AB9C9735-162A-4E87-9E83-32A396FE0D39', '03-kristen_bell_and_idina_menzel-for_the_first_time_in_forever.mp3', '', '1', 'N', '00:03:45', NULL, NULL),
('16', '03A93F55-292B-4C58-BF67-C58EAD985146', '01-cast_of_frozen-frozen_heart.mp3', '', '1', 'N', '00:01:47', NULL, NULL),
('17', '3D20A10B-2C90-452C-9988-19B3D441DFF0', '띠링.mp3', '', '1', 'N', '00:00:01', NULL, NULL);