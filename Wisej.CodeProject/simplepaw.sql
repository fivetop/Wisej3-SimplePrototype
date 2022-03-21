-- Script Date: 2022-03-21 오전 10:42  - ErikEJ.SqlCeScripting version 3.5.2.91
-- Database information:
-- Database: E:\0 신사업\demo\webPA\newrep\0 wisej\0 CodeProject\Wisej.CodeProject\simplepaw.db
-- ServerVersion: 3.35.5
-- DatabaseSize: 388 KB
-- Created: 2022-03-07 오전 11:36

-- User Table information:
-- Number of tables: 14
-- AssetGroups: -1 row(s)
-- Assets: -1 row(s)
-- BSTree: -1 row(s)
-- Device: -1 row(s)
-- Eventvm: -1 row(s)
-- Floorbases: -1 row(s)
-- Floormaps: -1 row(s)
-- Holidays: -1 row(s)
-- InfoTrees: -1 row(s)
-- Musics: -1 row(s)
-- PlayItem: -1 row(s)
-- SimpleMultis: -1 row(s)
-- Simplepa: -1 row(s)
-- UserTrees: -1 row(s)

SELECT 1;
PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE [UserTrees] (
  [UserTreeId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL     // ID
, [user_group] text NULL                                      // Admin / User
, [user_name] text NULL                                       // 이름
, [login_id] text NULL                                        // 아이디
, [login_password] text NULL                                  // 패스워드
, [login_password2] text NULL                                 // 패스워드
, [mobile] text NULL                                          // 핸드폰
, [email] text NULL                                           // 이메일
);
CREATE TABLE [Simplepa] (
  [SimplePAId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [TileWidth] bigint NOT NULL
, [MapX] bigint NOT NULL
, [MapY] bigint NOT NULL
, [Zoom] real NOT NULL
, [debug] bigint NOT NULL
, [SpeakerIconSize] bigint NOT NULL
, [UserName] text NULL
, [EMServerIP] text NULL
, [ServerIP] text NULL
, [ServerPort] text NULL
, [Reserved1] text NULL
, [Reserved2] text NULL
, [Reserved3] text NULL
, [Reserved4] text NULL
, [Reserved5] text NULL
, [Reserved6] text NULL
, [Reserved7] text NULL
, [Reserved8] text NULL
, [Reserved9] text NULL
, [Reserved10] text NULL
, [Reserved11] text NULL
, [GPIOPort] text NULL
, [Rport] text NULL
, [Reserved14] text NULL
, [Reserved15] text NULL
, [Reserved16] text NULL
, [Jigsangbalhwa] bigint NOT NULL
, [SpeakerTimer] bigint NOT NULL
, [inputvolume] real NOT NULL
, [outputvolume] real NOT NULL
, [disp] bigint NOT NULL
, [Multi_Ch] bigint NOT NULL
, [SoundDeviceNum] bigint NOT NULL
, [SoundDeviceName] text NULL
, [Reserved17] bigint NOT NULL
, [scalelength] real NOT NULL
, [length] real NOT NULL
, [scale] real NOT NULL
, [noise1] bigint NOT NULL
, [noise2] bigint NOT NULL
, [dsp_vol] bigint NOT NULL
, [dsp_vol_em] bigint NOT NULL
, [sms_server] text NULL
, [sms_id] text NULL
, [sms_pw] text NULL
, [sms_rcvno] text NULL
, [Pport] bigint NOT NULL
);
CREATE TABLE [SimpleMultis] (
  [SimpleMultiId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Id] text NULL
, [idno] bigint NOT NULL
, [chno] bigint NOT NULL
, [Subject] text NULL
, [Name] text NULL
, [gstreeAssetGroupId] bigint NULL
, [stm] text NOT NULL
, [etm] text NOT NULL
, [duration] text NULL
, [week] bigint NOT NULL
, [day1] bigint NOT NULL
, [day2] bigint NOT NULL
, [day3] bigint NOT NULL
, [day4] bigint NOT NULL
, [day5] bigint NOT NULL
, [day6] bigint NOT NULL
, [day7] bigint NOT NULL
, [tss] text NOT NULL
, [tse] text NOT NULL
, [Color16] text NULL
, [overlap] bigint NOT NULL
, [weekday] bigint NOT NULL
);
CREATE TABLE [PlayItem] (
  [PlayItemId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [playflag_onair] bigint DEFAULT (0) NOT NULL
, [idno] bigint DEFAULT (0) NOT NULL
, [chno] bigint DEFAULT (0) NOT NULL
, [kind] text NULL
, [Name] text NULL
, [Start] datetime NULL
, [End] datetime NULL
, [state] text NULL
, [playcnt] bigint NULL
, [current] datetime NULL
, [duration] datetime NULL
, [p_run] bigint DEFAULT (0) NOT NULL
);
CREATE TABLE [Musics] (
  [MusicId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL          // ID
, [FileName] text NULL                                          // 파일명 
, [FileContent] text NULL                                       // 파일내용 
, [deletable] text NULL                                         // 삭제가능여부
, [duration] text NULL                                          // 음원재생시간
);
CREATE TABLE [InfoTrees] (
  [InfoTreeId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Id] text NULL
, [Subject] text NULL
, [Name] text NULL
, [gstreeAssetGroupId] bigint NULL
);
CREATE TABLE [Holidays] (
  [HolidayId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL        // ID
, [hDate] datetime NOT NULL                                     // 날자
, [Description] text NULL                                       // 내용
);
CREATE TABLE [Floormaps] (
  [FloorMapId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [buildingname] text NULL
, [floororder] bigint DEFAULT (1) NULL
, [floor] text NULL
, [filename] text NULL
, [left] bigint DEFAULT (100) NULL
, [top] bigint DEFAULT (100) NULL
, [content] text NULL
, [assetname] text NULL
);
CREATE TABLE [Floorbases] (
  [FloorBaseId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [buildingname] text NULL
, [floororder] bigint DEFAULT (1) NULL
, [floor] text NULL
, [filename] text NULL
, [left] bigint DEFAULT (100) NULL
, [top] bigint DEFAULT (100) NULL
, [content] text NULL
, [assetname] text NULL
);
CREATE TABLE [Eventvm] (
  [EventVMId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL              // ID
, [write_time] datetime NOT NULL                                      // 발생시간
, [event_text] text NULL                                              // 발생내용
, [ip] text NULL                                                      // IP
, [path] text NULL                                                    // 발생장소
, [DeviceName] text NULL                                              // 장비이름
, [state] text NULL                                                   // 상태정보
);
CREATE TABLE [Device] (
  [DeviceId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [device] bigint DEFAULT (0) NULL
, [ip] text NULL
, [ip_dspctrl] text NULL
, [name] text NULL
, [DeviceName] text NULL
, [DanteModelName] text NULL
, [dsp_off_ch1] text NULL
, [dsp_off_ch2] text NULL
, [chspk] text NULL
, [dsp_name] text NULL
, [dsp_chno] bigint DEFAULT (0) NULL
, [dsp_vol] bigint DEFAULT (0) NULL
, [dsp_vol_em] bigint DEFAULT (0) NULL
, [path] text NULL
, [floor_em] bigint DEFAULT (0) NULL
, [emData] text NULL
);
CREATE TABLE [BSTree] (
  [BSTreeId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL               // ID
, [wtime] datetime NULL                                               // 발생시간
, [chno] bigint DEFAULT ('0') NOT NULL                                // 채널번호
, [AssetId] bigint DEFAULT ('0') NOT NULL                             // 자산 ID
, [MusicId] bigint DEFAULT ('0') NOT NULL                             // 음원 ID
);
CREATE TABLE [Assets] (
  [AssetId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL                // ID
, [ip] text NULL                                                      // IP
, [GroupName] text NULL                                               // 그룸병
, [ZoneName] text NULL                                                // 존병
, [SpeakerName] text NULL                                             // 스피커명
, [path] text NULL                                                    // 그룹/존/스피커
, [floor] text NULL                                                   // 층정보
, [DeviceName] text NULL                                              // 디바이스명
, [state] text NULL                                                   // 상태 
, [state_old] text NULL                                               // 이전상태
, [chk] bigint DEFAULT (0) NULL                                       // 체크상태
, [seq] bigint DEFAULT (0) NULL                                       // 순번
, [ch] bigint DEFAULT (0) NULL                                        // 채널번호
, [em1] bigint DEFAULT (1) NULL                                       // 동
, [em2] bigint DEFAULT (1) NULL                                       // 계단
, [em3] bigint DEFAULT (1) NULL                                       // 층
);
CREATE TABLE [AssetGroups] (
  [AssetGroupId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL            // ID
, [Name] text NULL                                                     // 자산 그룹명
, [AssetId] bigint DEFAULT (0) NOT NULL                                // 자산ID
);
CREATE UNIQUE INDEX [BSTree_sqlite_autoindex_BSTree_1] ON [BSTree] ([BSTreeId] ASC);
COMMIT;

