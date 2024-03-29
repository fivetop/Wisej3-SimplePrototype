USE [simplePA]
GO
/****** Object:  Table [dbo].[AssetGroups]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssetGroups](
	[AssetGroupId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NULL,
	[AssetId] [int] NULL,
	[EMNAME] [varchar](max) NULL,
 CONSTRAINT [PK_AssetGroups] PRIMARY KEY CLUSTERED 
(
	[AssetGroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AssetPresetGroups]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssetPresetGroups](
	[AssetPresetGroupId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NULL,
	[AssetId] [int] NULL,
	[EMNAME] [varchar](max) NULL,
	[chk] [int] NULL,
 CONSTRAINT [PK_AssetPresetGroups] PRIMARY KEY CLUSTERED 
(
	[AssetPresetGroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Assets]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assets](
	[AssetId] [int] IDENTITY(1,1) NOT NULL,
	[emServer] [varchar](max) NULL,
	[ip] [varchar](max) NULL,
	[GroupName] [varchar](max) NULL,
	[ZoneName] [varchar](max) NULL,
	[SpeakerName] [varchar](max) NULL,
	[path] [varchar](max) NULL,
	[floor] [int] NULL,
	[DeviceName] [varchar](max) NULL,
	[state] [varchar](max) NULL,
	[state_old] [varchar](max) NULL,
	[chk] [int] NULL,
	[seq] [int] NULL,
	[ch] [int] NULL,
	[em1] [int] NULL,
	[em2] [int] NULL,
	[em3] [int] NULL,
	[DeviceId] [int] NULL,
	[emData] [varchar](max) NULL,
	[building] [varchar](max) NULL,
	[floorname] [varchar](max) NULL,
	[zpc] [varchar](max) NULL,
	[zpci] [int] NULL,
	[zpco] [int] NULL,
 CONSTRAINT [PK_Assets] PRIMARY KEY CLUSTERED 
(
	[AssetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BSTree]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSTree](
	[BSTreeId] [int] IDENTITY(1,1) NOT NULL,
	[EMNAME] [varchar](max) NOT NULL,
	[wtime] [datetime] NULL,
	[chno] [int] NULL,
	[playing] [varchar](max) NULL,
	[AssetId] [int] NULL,
	[MusicId] [int] NULL,
	[user_name] [varchar](max) NULL,
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
/****** Object:  Table [dbo].[BSTreeC]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BSTreeC](
	[BSTreeCId] [int] IDENTITY(1,1) NOT NULL,
	[BSTreeId] [int] NULL,
	[AssetId] [int] NULL,
	[MusicId] [int] NULL,
	[user_name] [varchar](max) NULL,
 CONSTRAINT [PK_BSTreeC] PRIMARY KEY CLUSTERED 
(
	[BSTreeCId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Device]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Device](
	[DeviceId] [int] IDENTITY(1,1) NOT NULL,
	[device] [int] NULL,
	[ip] [varchar](max) NULL,
	[ip_dspctrl] [varchar](max) NULL,
	[name] [varchar](max) NULL,
	[DeviceName] [varchar](max) NULL,
	[DanteModelName] [varchar](max) NULL,
	[chspk] [int] NULL,
	[dsp_name] [varchar](max) NULL,
	[dsp_chno] [int] NULL,
	[dsp_vol] [int] NULL,
	[dsp_vol_em] [int] NULL,
	[path] [varchar](max) NULL,
	[floor_em] [int] NULL,
	[emData] [varchar](max) NULL,
	[chCount] [int] NULL,
	[AssetId] [int] NULL,
	[EMNAME] [varchar](max) NULL,
 CONSTRAINT [PK_Device] PRIMARY KEY CLUSTERED 
(
	[DeviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeviceChannel]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeviceChannel](
	[DeviceChnnelId] [int] IDENTITY(1,1) NOT NULL,
	[chno] [varchar](max) NULL,
	[chname] [varchar](max) NULL,
	[dsp_out_ch1] [varchar](max) NULL,
	[dsp_out_ch2] [varchar](max) NULL,
	[DeviceId] [int] NOT NULL,
	[io] [int] NULL,
	[devicein] [varchar](max) NULL,
	[deviceinch] [int] NULL,
 CONSTRAINT [PK_DeviceChannel] PRIMARY KEY CLUSTERED 
(
	[DeviceChnnelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMBs]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMBs](
	[EMBsId] [int] IDENTITY(1,1) NOT NULL,
	[emData] [varchar](max) NULL,
	[DeviceId] [int] NULL,
	[path] [varchar](max) NULL,
	[EMNAME] [varchar](max) NULL,
 CONSTRAINT [PK_EMBs] PRIMARY KEY CLUSTERED 
(
	[EMBsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMServer]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMServer](
	[EMServerId] [int] IDENTITY(1,1) NOT NULL,
	[EMNAME] [varchar](max) NULL,
	[state] [varchar](max) NULL,
	[state_old] [varchar](max) NULL,
	[com_gpio] [varchar](max) NULL,
	[com_Rtype] [varchar](max) NULL,
	[net_local] [varchar](max) NULL,
	[net_dante] [varchar](max) NULL,
	[dsp_ctrl] [varchar](max) NULL,
	[dsp_dante] [varchar](max) NULL,
	[com_gpio_state] [int] NULL,
	[com_Rtype_state] [int] NULL,
	[sw_all] [int] NULL,
	[sw_1] [int] NULL,
	[sw_2] [int] NULL,
	[sw_3] [int] NULL,
	[sw_4] [int] NULL,
	[err] [int] NULL,
	[fire] [int] NULL,
	[emtest] [int] NULL,
	[em_address] [varchar](max) NULL,
	[em_description] [varchar](max) NULL,
	[em_images] [varchar](max) NULL,
 CONSTRAINT [PK_EMServer] PRIMARY KEY CLUSTERED 
(
	[EMServerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventbs]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventbs](
	[EventbsId] [int] IDENTITY(1,1) NOT NULL,
	[write_time] [datetime] NOT NULL,
	[event_text] [varchar](max) NULL,
	[ip] [varchar](max) NULL,
	[path] [varchar](max) NULL,
	[DeviceName] [varchar](max) NULL,
	[state] [varchar](max) NULL,
	[alarm] [int] NULL,
 CONSTRAINT [PK_Eventbs] PRIMARY KEY CLUSTERED 
(
	[EventbsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventdevice]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventdevice](
	[EventdeviceId] [int] IDENTITY(1,1) NOT NULL,
	[write_time] [datetime] NOT NULL,
	[event_text] [varchar](max) NULL,
	[ip] [varchar](max) NULL,
	[path] [varchar](max) NULL,
	[DeviceName] [varchar](max) NULL,
	[state] [varchar](max) NULL,
	[alarm] [int] NULL,
 CONSTRAINT [PK_Eventdevice] PRIMARY KEY CLUSTERED 
(
	[EventdeviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventpreset]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventpreset](
	[EventpresetId] [int] IDENTITY(1,1) NOT NULL,
	[write_time] [datetime] NOT NULL,
	[event_text] [varchar](max) NULL,
	[ip] [varchar](max) NULL,
	[path] [varchar](max) NULL,
	[DeviceName] [varchar](max) NULL,
	[state] [varchar](max) NULL,
	[alarm] [int] NULL,
 CONSTRAINT [PK_Eventpreset] PRIMARY KEY CLUSTERED 
(
	[EventpresetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventsyslog]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventsyslog](
	[EventsyslogId] [int] IDENTITY(1,1) NOT NULL,
	[write_time] [datetime] NOT NULL,
	[event_text] [varchar](max) NULL,
	[ip] [varchar](max) NULL,
	[path] [varchar](max) NULL,
	[DeviceName] [varchar](max) NULL,
	[state] [varchar](max) NULL,
	[alarm] [int] NULL,
 CONSTRAINT [PK_Eventsyslog] PRIMARY KEY CLUSTERED 
(
	[EventsyslogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventvm]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventvm](
	[EventVMId] [int] IDENTITY(1,1) NOT NULL,
	[write_time] [datetime] NOT NULL,
	[event_text] [varchar](max) NULL,
	[ip] [varchar](max) NULL,
	[path] [varchar](max) NULL,
	[DeviceName] [varchar](max) NULL,
	[state] [varchar](max) NULL,
	[alarm] [int] NULL,
 CONSTRAINT [PK_Eventvm] PRIMARY KEY CLUSTERED 
(
	[EventVMId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Holidays]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Holidays](
	[HolidayId] [int] IDENTITY(1,1) NOT NULL,
	[hDate] [datetime] NOT NULL,
	[Description] [varchar](max) NULL,
 CONSTRAINT [PK_Holidays] PRIMARY KEY CLUSTERED 
(
	[hDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musics]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musics](
	[MusicId] [int] IDENTITY(1,1) NOT NULL,
	[FileName] [varchar](max) NULL,
	[FileContent] [varchar](max) NULL,
	[deletable] [varchar](max) NULL,
	[duration] [varchar](max) NULL,
 CONSTRAINT [PK_Musics] PRIMARY KEY CLUSTERED 
(
	[MusicId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Preset]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preset](
	[PresetId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NULL,
	[EMNAME] [varchar](max) NULL,
	[GroupName] [varchar](max) NULL,
	[user_name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Preset] PRIMARY KEY CLUSTERED 
(
	[PresetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PresetC]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PresetC](
	[PresetCId] [int] IDENTITY(1,1) NOT NULL,
	[PresetId] [int] NULL,
	[AssetId] [int] NULL,
	[MusicId] [int] NULL,
 CONSTRAINT [PK_PreserC] PRIMARY KEY CLUSTERED 
(
	[PresetCId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schdule]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schdule](
	[SchduleId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NULL,
	[EMNAME] [varchar](max) NULL,
	[GroupName] [varchar](max) NULL,
	[user_name] [nvarchar](max) NULL,
	[stime] [datetime] NOT NULL,
	[etime] [datetime] NOT NULL,
	[sdate] [datetime] NOT NULL,
	[day1] [bit] NOT NULL,
	[day2] [bit] NOT NULL,
	[day3] [bit] NOT NULL,
	[day4] [bit] NOT NULL,
	[day5] [bit] NOT NULL,
	[day6] [bit] NOT NULL,
	[day7] [bit] NOT NULL,
	[week] [bit] NOT NULL,
	[chno] [int] NOT NULL,
	[duration] [varchar](50) NULL,
	[tss] [varchar](50) NULL,
	[tse] [varchar](50) NULL,
	[state] [varchar](50) NULL,
 CONSTRAINT [PK_Schdule] PRIMARY KEY CLUSTERED 
(
	[SchduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SchduleC]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SchduleC](
	[SchduleCId] [int] IDENTITY(1,1) NOT NULL,
	[SchduleId] [int] NOT NULL,
	[AssetId] [int] NULL,
	[MusicId] [int] NULL,
 CONSTRAINT [PK_SchduleC] PRIMARY KEY CLUSTERED 
(
	[SchduleCId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Simplepa]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Simplepa](
	[SimplePAId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](max) NULL,
	[sms_server] [varchar](max) NULL,
	[sms_id] [varchar](max) NULL,
	[sms_pw] [varchar](max) NULL,
	[sms_rcvno] [varchar](max) NULL,
	[EmMusic] [varchar](max) NULL,
 CONSTRAINT [PK_Simplepa] PRIMARY KEY CLUSTERED 
(
	[SimplePAId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeData]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeData](
	[type_index] [int] IDENTITY(1,1) NOT NULL,
	[type_group] [int] NOT NULL,
	[type_variable] [int] NULL,
	[type_contents] [varchar](max) NULL,
	[type_description] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTrees]    Script Date: 2023-07-25 오후 2:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTrees](
	[UserTreeId] [int] IDENTITY(1,1) NOT NULL,
	[user_group] [varchar](max) NULL,
	[user_name] [varchar](max) NULL,
	[login_id] [varchar](max) NULL,
	[login_password] [varchar](max) NULL,
	[login_password2] [varchar](max) NULL,
	[mobile] [varchar](max) NULL,
	[email] [varchar](max) NULL,
 CONSTRAINT [PK_UserTrees] PRIMARY KEY CLUSTERED 
(
	[UserTreeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[AssetGroups] ADD  CONSTRAINT [DF__AssetGrou__Asset__0B91BA14]  DEFAULT ((0)) FOR [AssetId]
GO
ALTER TABLE [dbo].[AssetPresetGroups] ADD  CONSTRAINT [DF_AssetPresetGroups_AssetId]  DEFAULT ((0)) FOR [AssetId]
GO
ALTER TABLE [dbo].[AssetPresetGroups] ADD  CONSTRAINT [DF_AssetPresetGroups_chk]  DEFAULT ((0)) FOR [chk]
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
ALTER TABLE [dbo].[EMServer] ADD  CONSTRAINT [DF_EMServer_com_gpio_state]  DEFAULT ((0)) FOR [com_gpio_state]
GO
ALTER TABLE [dbo].[EMServer] ADD  CONSTRAINT [DF_EMServer_com_Rtype_state]  DEFAULT ((0)) FOR [com_Rtype_state]
GO
ALTER TABLE [dbo].[EMServer] ADD  CONSTRAINT [DF_EMServer_sw_all]  DEFAULT ((0)) FOR [sw_all]
GO
ALTER TABLE [dbo].[EMServer] ADD  CONSTRAINT [DF_EMServer_sw_1]  DEFAULT ((0)) FOR [sw_1]
GO
ALTER TABLE [dbo].[EMServer] ADD  CONSTRAINT [DF_EMServer_sw_2]  DEFAULT ((0)) FOR [sw_2]
GO
ALTER TABLE [dbo].[EMServer] ADD  CONSTRAINT [DF_EMServer_sw_3]  DEFAULT ((0)) FOR [sw_3]
GO
ALTER TABLE [dbo].[EMServer] ADD  CONSTRAINT [DF_EMServer_sw_4]  DEFAULT ((0)) FOR [sw_4]
GO
ALTER TABLE [dbo].[EMServer] ADD  CONSTRAINT [DF_EMServer_err]  DEFAULT ((0)) FOR [err]
GO
ALTER TABLE [dbo].[EMServer] ADD  CONSTRAINT [DF_EMServer_fire]  DEFAULT ((0)) FOR [fire]
GO
ALTER TABLE [dbo].[EMServer] ADD  CONSTRAINT [DF_EMServer_emtest]  DEFAULT ((0)) FOR [emtest]
GO
ALTER TABLE [dbo].[Eventvm] ADD  CONSTRAINT [DF__Eventvm__alarm__412EB0B6]  DEFAULT ((0)) FOR [alarm]
GO
ALTER TABLE [dbo].[Schdule] ADD  CONSTRAINT [DF_Schdule_stime]  DEFAULT (getdate()) FOR [stime]
GO
ALTER TABLE [dbo].[Schdule] ADD  CONSTRAINT [DF_Schdule_etime]  DEFAULT (getdate()) FOR [etime]
GO
ALTER TABLE [dbo].[Schdule] ADD  CONSTRAINT [DF_Schdule_sdate]  DEFAULT (getdate()) FOR [sdate]
GO
ALTER TABLE [dbo].[Schdule] ADD  CONSTRAINT [DF_Schdule_day1]  DEFAULT ((0)) FOR [day1]
GO
ALTER TABLE [dbo].[Schdule] ADD  CONSTRAINT [DF_Schdule_day2]  DEFAULT ((0)) FOR [day2]
GO
ALTER TABLE [dbo].[Schdule] ADD  CONSTRAINT [DF_Schdule_day3]  DEFAULT ((0)) FOR [day3]
GO
ALTER TABLE [dbo].[Schdule] ADD  CONSTRAINT [DF_Schdule_day4]  DEFAULT ((0)) FOR [day4]
GO
ALTER TABLE [dbo].[Schdule] ADD  CONSTRAINT [DF_Schdule_day5]  DEFAULT ((0)) FOR [day5]
GO
ALTER TABLE [dbo].[Schdule] ADD  CONSTRAINT [DF_Schdule_day6]  DEFAULT ((0)) FOR [day6]
GO
ALTER TABLE [dbo].[Schdule] ADD  CONSTRAINT [DF_Schdule_day7]  DEFAULT ((0)) FOR [day7]
GO
ALTER TABLE [dbo].[Schdule] ADD  CONSTRAINT [DF_Schdule_week]  DEFAULT ((1)) FOR [week]
GO
ALTER TABLE [dbo].[Schdule] ADD  CONSTRAINT [DF_Schdule_chno]  DEFAULT ((4)) FOR [chno]
GO
ALTER TABLE [dbo].[Schdule] ADD  CONSTRAINT [DF_Schdule_tss]  DEFAULT (getdate()) FOR [tss]
GO
