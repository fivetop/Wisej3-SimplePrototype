USE [simplePA]
GO
/****** Object:  Table [dbo].[AssetGroups]    Script Date: 2022-12-05 오후 1:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssetGroups](
	[AssetGroupId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [text] NULL,
	[AssetId] [int] NOT NULL,
 CONSTRAINT [PK_AssetGroups] PRIMARY KEY CLUSTERED 
(
	[AssetGroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Assets]    Script Date: 2022-12-05 오후 1:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assets](
	[AssetId] [int] IDENTITY(1,1) NOT NULL,
	[emServer] [text] NULL,
	[ip] [text] NULL,
	[GroupName] [text] NULL,
	[ZoneName] [text] NULL,
	[SpeakerName] [text] NULL,
	[path] [text] NULL,
	[floor] [int] NULL,
	[DeviceName] [text] NULL,
	[state] [text] NULL,
	[state_old] [text] NULL,
	[chk] [int] NULL,
	[seq] [int] NULL,
	[ch] [int] NULL,
	[em1] [int] NULL,
	[em2] [int] NULL,
	[em3] [int] NULL,
	[DeviceId] [int] NULL,
	[emData] [text] NULL,
	[building] [text] NULL,
	[floorname] [text] NULL,
	[zpc] [text] NULL,
	[zpci] [int] NULL,
	[zpco] [int] NULL,
 CONSTRAINT [PK_Assets] PRIMARY KEY CLUSTERED 
(
	[AssetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSroom]    Script Date: 2022-12-05 오후 1:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSroom](
	[BSroomid] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [text] NULL,
	[state] [int] NULL,
	[mode] [int] NULL,
 CONSTRAINT [PK_BSroom] PRIMARY KEY CLUSTERED 
(
	[BSroomid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSTree]    Script Date: 2022-12-05 오후 1:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSTree](
	[BSTreeId] [int] IDENTITY(1,1) NOT NULL,
	[EMNAME] [text] NULL,
	[wtime] [datetime] NULL,
	[chno] [int] NULL,
	[playing] [text] NULL,
	[AssetId] [int] NULL,
	[MusicId] [int] NULL,
 CONSTRAINT [PK_BSTree] PRIMARY KEY CLUSTERED 
(
	[BSTreeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__BSTree__CC0A7CE0EAF1E09D] UNIQUE NONCLUSTERED 
(
	[BSTreeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSTreeC]    Script Date: 2022-12-05 오후 1:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSTreeC](
	[BSTreeCId] [int] IDENTITY(1,1) NOT NULL,
	[BSTreeId] [int] NULL,
	[AssetId] [int] NULL,
	[MusicId] [int] NULL,
 CONSTRAINT [PK_BSTreeC] PRIMARY KEY CLUSTERED 
(
	[BSTreeCId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Device]    Script Date: 2022-12-05 오후 1:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Device](
	[DeviceId] [int] IDENTITY(1,1) NOT NULL,
	[device] [int] NULL,
	[ip] [text] NULL,
	[ip_dspctrl] [text] NULL,
	[name] [text] NULL,
	[DeviceName] [text] NULL,
	[DanteModelName] [text] NULL,
	[chspk] [int] NULL,
	[dsp_name] [text] NULL,
	[dsp_chno] [int] NULL,
	[dsp_vol] [int] NULL,
	[dsp_vol_em] [int] NULL,
	[path] [text] NULL,
	[floor_em] [int] NULL,
	[emData] [text] NULL,
	[chCount] [int] NULL,
	[AssetId] [int] NULL,
 CONSTRAINT [PK_Device] PRIMARY KEY CLUSTERED 
(
	[DeviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeviceChannel]    Script Date: 2022-12-05 오후 1:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeviceChannel](
	[DeviceChnnelId] [int] IDENTITY(1,1) NOT NULL,
	[chno] [text] NULL,
	[chname] [text] NULL,
	[dsp_out_ch1] [text] NULL,
	[dsp_out_ch2] [text] NULL,
	[DeviceId] [int] NOT NULL,
	[io] [int] NULL,
	[devicein] [text] NULL,
	[deviceinch] [int] NULL,
 CONSTRAINT [PK_DeviceChannel] PRIMARY KEY CLUSTERED 
(
	[DeviceChnnelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMBs]    Script Date: 2022-12-05 오후 1:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMBs](
	[EMBsId] [int] IDENTITY(1,1) NOT NULL,
	[emData] [text] NULL,
	[DeviceId] [int] NULL,
	[path] [text] NULL,
 CONSTRAINT [PK_EMBs] PRIMARY KEY CLUSTERED 
(
	[EMBsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMServer]    Script Date: 2022-12-05 오후 1:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMServer](
	[EMServerId] [int] IDENTITY(1,1) NOT NULL,
	[EMNAME] [text] NULL,
	[state] [text] NULL,
	[state_old] [text] NULL,
 CONSTRAINT [PK_EMServer] PRIMARY KEY CLUSTERED 
(
	[EMServerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventvm]    Script Date: 2022-12-05 오후 1:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventvm](
	[EventVMId] [int] IDENTITY(1,1) NOT NULL,
	[write_time] [datetime] NOT NULL,
	[event_text] [text] NULL,
	[ip] [text] NULL,
	[path] [text] NULL,
	[DeviceName] [text] NULL,
	[state] [text] NULL,
	[alarm] [int] NULL,
 CONSTRAINT [PK_Eventvm] PRIMARY KEY CLUSTERED 
(
	[EventVMId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Holidays]    Script Date: 2022-12-05 오후 1:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Holidays](
	[HolidayId] [int] IDENTITY(1,1) NOT NULL,
	[hDate] [datetime] NOT NULL,
	[Description] [text] NULL,
 CONSTRAINT [PK_Holidays] PRIMARY KEY CLUSTERED 
(
	[HolidayId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musics]    Script Date: 2022-12-05 오후 1:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musics](
	[MusicId] [int] IDENTITY(1,1) NOT NULL,
	[FileName] [text] NULL,
	[FileContent] [text] NULL,
	[deletable] [text] NULL,
	[duration] [text] NULL,
 CONSTRAINT [PK_Musics] PRIMARY KEY CLUSTERED 
(
	[MusicId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlayItem]    Script Date: 2022-12-05 오후 1:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayItem](
	[PlayItemId] [int] NOT NULL,
	[playflag_onair] [int] NOT NULL,
	[idno] [int] NOT NULL,
	[chno] [int] NOT NULL,
	[kind] [text] NULL,
	[Name] [text] NULL,
	[Start] [datetime] NULL,
	[End] [datetime] NULL,
	[state] [text] NULL,
	[playcnt] [int] NULL,
	[current] [datetime] NULL,
	[duration] [datetime] NULL,
	[p_run] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Simplepa]    Script Date: 2022-12-05 오후 1:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Simplepa](
	[SimplePAId] [int] IDENTITY(1,1) NOT NULL,
	[TileWidth] [int] NOT NULL,
	[MapX] [int] NOT NULL,
	[MapY] [int] NOT NULL,
	[Zoom] [real] NOT NULL,
	[debug] [int] NOT NULL,
	[SpeakerIconSize] [int] NOT NULL,
	[UserName] [text] NULL,
	[EMServerIP] [text] NULL,
	[ServerIP] [text] NULL,
	[ServerPort] [text] NULL,
	[Reserved1] [text] NULL,
	[Reserved2] [text] NULL,
	[Reserved3] [text] NULL,
	[Reserved4] [text] NULL,
	[Reserved5] [text] NULL,
	[Reserved6] [text] NULL,
	[Reserved7] [text] NULL,
	[Reserved8] [text] NULL,
	[Reserved9] [text] NULL,
	[Reserved10] [text] NULL,
	[Reserved11] [text] NULL,
	[GPIOPort] [text] NULL,
	[Rport] [text] NULL,
	[Reserved15] [text] NULL,
	[Reserved16] [text] NULL,
	[Jigsangbalhwa] [int] NOT NULL,
	[SpeakerTimer] [int] NOT NULL,
	[inputvolume] [real] NOT NULL,
	[outputvolume] [real] NOT NULL,
	[disp] [int] NOT NULL,
	[Multi_Ch] [int] NOT NULL,
	[SoundDeviceNum] [int] NOT NULL,
	[SoundDeviceName] [text] NULL,
	[Reserved17] [int] NOT NULL,
	[scalelength] [real] NULL,
	[length] [real] NULL,
	[scale] [real] NULL,
	[noise1] [int] NULL,
	[noise2] [int] NULL,
	[dsp_vol] [int] NOT NULL,
	[dsp_vol_em] [int] NOT NULL,
	[sms_server] [text] NULL,
	[sms_id] [text] NULL,
	[sms_pw] [text] NULL,
	[sms_rcvno] [text] NULL,
	[Pport] [int] NOT NULL,
	[EmMusic] [text] NULL,
 CONSTRAINT [PK_Simplepa] PRIMARY KEY CLUSTERED 
(
	[SimplePAId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTrees]    Script Date: 2022-12-05 오후 1:36:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTrees](
	[UserTreeId] [int] IDENTITY(1,1) NOT NULL,
	[user_group] [text] NULL,
	[user_name] [text] NULL,
	[login_id] [text] NULL,
	[login_password] [text] NULL,
	[login_password2] [text] NULL,
	[mobile] [text] NULL,
	[email] [text] NULL,
 CONSTRAINT [PK_UserTrees] PRIMARY KEY CLUSTERED 
(
	[UserTreeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[AssetGroups] ADD  CONSTRAINT [DF__AssetGrou__Asset__0B91BA14]  DEFAULT ((0)) FOR [AssetId]
GO
ALTER TABLE [dbo].[Assets] ADD  CONSTRAINT [DF__Assets__chk__4316F928]  DEFAULT ((0)) FOR [chk]
GO
ALTER TABLE [dbo].[Assets] ADD  CONSTRAINT [DF__Assets__seq__440B1D61]  DEFAULT ((0)) FOR [seq]
GO
ALTER TABLE [dbo].[Assets] ADD  CONSTRAINT [DF__Assets__ch__44FF419A]  DEFAULT ((0)) FOR [ch]
GO
ALTER TABLE [dbo].[Assets] ADD  CONSTRAINT [DF__Assets__em1__45F365D3]  DEFAULT ((0)) FOR [em1]
GO
ALTER TABLE [dbo].[Assets] ADD  CONSTRAINT [DF__Assets__em2__46E78A0C]  DEFAULT ((0)) FOR [em2]
GO
ALTER TABLE [dbo].[Assets] ADD  CONSTRAINT [DF__Assets__em3__47DBAE45]  DEFAULT ((0)) FOR [em3]
GO
ALTER TABLE [dbo].[BSroom] ADD  CONSTRAINT [DF__BSroom__user_nam__3D5E1FD2]  DEFAULT ('') FOR [user_name]
GO
ALTER TABLE [dbo].[BSroom] ADD  CONSTRAINT [DF__BSroom__state__3E52440B]  DEFAULT ((0)) FOR [state]
GO
ALTER TABLE [dbo].[BSroom] ADD  CONSTRAINT [DF__BSroom__mode__3F466844]  DEFAULT ((0)) FOR [mode]
GO
ALTER TABLE [dbo].[BSTree] ADD  CONSTRAINT [DF__BSTree__chno__1ED998B2]  DEFAULT ('0') FOR [chno]
GO
ALTER TABLE [dbo].[BSTree] ADD  CONSTRAINT [DF__BSTree__AssetId__1FCDBCEB]  DEFAULT ('0') FOR [AssetId]
GO
ALTER TABLE [dbo].[BSTree] ADD  CONSTRAINT [DF__BSTree__MusicId__20C1E124]  DEFAULT ('0') FOR [MusicId]
GO
ALTER TABLE [dbo].[DeviceChannel] ADD  CONSTRAINT [DF__DeviceCha__Devic__4BAC3F29]  DEFAULT ((0)) FOR [DeviceId]
GO
ALTER TABLE [dbo].[DeviceChannel] ADD  CONSTRAINT [DF__DeviceChanne__io__4CA06362]  DEFAULT ((0)) FOR [io]
GO
ALTER TABLE [dbo].[Eventvm] ADD  CONSTRAINT [DF__Eventvm__alarm__412EB0B6]  DEFAULT ((0)) FOR [alarm]
GO
ALTER TABLE [dbo].[PlayItem] ADD  DEFAULT ((0)) FOR [playflag_onair]
GO
ALTER TABLE [dbo].[PlayItem] ADD  DEFAULT ((0)) FOR [idno]
GO
ALTER TABLE [dbo].[PlayItem] ADD  DEFAULT ((0)) FOR [chno]
GO
ALTER TABLE [dbo].[PlayItem] ADD  DEFAULT ((0)) FOR [p_run]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__TileWi__276EDEB3]  DEFAULT ((0)) FOR [TileWidth]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__MapX__286302EC]  DEFAULT ((0)) FOR [MapX]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__MapY__29572725]  DEFAULT ((0)) FOR [MapY]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__Zoom__2A4B4B5E]  DEFAULT ((0)) FOR [Zoom]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__debug__2B3F6F97]  DEFAULT ((0)) FOR [debug]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__Speake__2C3393D0]  DEFAULT ((0)) FOR [SpeakerIconSize]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__Jigsan__2D27B809]  DEFAULT ((0)) FOR [Jigsangbalhwa]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__Speake__2E1BDC42]  DEFAULT ((0)) FOR [SpeakerTimer]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__inputv__2F10007B]  DEFAULT ((0)) FOR [inputvolume]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__output__300424B4]  DEFAULT ((0)) FOR [outputvolume]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__disp__30F848ED]  DEFAULT ((0)) FOR [disp]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__Multi___31EC6D26]  DEFAULT ((0)) FOR [Multi_Ch]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__SoundD__32E0915F]  DEFAULT ((0)) FOR [SoundDeviceNum]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__Reserv__33D4B598]  DEFAULT ((0)) FOR [Reserved17]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__scalel__34C8D9D1]  DEFAULT ((0)) FOR [scalelength]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__length__35BCFE0A]  DEFAULT ((0)) FOR [length]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__scale__36B12243]  DEFAULT ((0)) FOR [scale]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__noise1__37A5467C]  DEFAULT ((0)) FOR [noise1]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__noise2__38996AB5]  DEFAULT ((0)) FOR [noise2]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__dsp_vo__398D8EEE]  DEFAULT ((0)) FOR [dsp_vol]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__dsp_vo__3A81B327]  DEFAULT ((0)) FOR [dsp_vol_em]
GO
ALTER TABLE [dbo].[Simplepa] ADD  CONSTRAINT [DF__Simplepa__Pport__3B75D760]  DEFAULT ((0)) FOR [Pport]
GO
