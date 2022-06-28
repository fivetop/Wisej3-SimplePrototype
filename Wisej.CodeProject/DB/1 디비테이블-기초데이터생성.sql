USE [simplePA]
GO
SET IDENTITY_INSERT [dbo].[Assets] ON 
GO
INSERT [dbo].[Assets] ([AssetId], [ip], [GroupName], [ZoneName], [SpeakerName], [path], [floor], [DeviceName], [state], [state_old], [chk], [seq], [ch], [em1], [em2], [em3], [DeviceId], [emData]) VALUES (1, N'169.254.150.80', N'1동B1F', N'통신실1', N'1번앰프', N'1동B1F 통신실1 1번앰프', 110, N'MA1000T-845095', N'On-Line', N'', 0, 1, 1, NULL, NULL, NULL, 14, N'01동/01계단/00층')
GO
INSERT [dbo].[Assets] ([AssetId], [ip], [GroupName], [ZoneName], [SpeakerName], [path], [floor], [DeviceName], [state], [state_old], [chk], [seq], [ch], [em1], [em2], [em3], [DeviceId], [emData]) VALUES (2, N'169.254.150.80', N'1동B1F', N'통신실2', N'2번앰프', N'1동B1F 통신실2 2번앰프', 110, N'MA1000T-845095', N'On-Line', N'', 0, 2, 2, NULL, NULL, NULL, 15, N'01동/01계단/00층')
GO
INSERT [dbo].[Assets] ([AssetId], [ip], [GroupName], [ZoneName], [SpeakerName], [path], [floor], [DeviceName], [state], [state_old], [chk], [seq], [ch], [em1], [em2], [em3], [DeviceId], [emData]) VALUES (3, N'169.254.241.123', N'1동1F', N'사무실2', N'2번앰프', N'1동1F 사무실2 2번앰프', 111, N'DPCB-30-917bf0', N'On-Line', N'', 0, 3, 1, NULL, NULL, NULL, 8, N'01동/01계단/01층')
GO
INSERT [dbo].[Assets] ([AssetId], [ip], [GroupName], [ZoneName], [SpeakerName], [path], [floor], [DeviceName], [state], [state_old], [chk], [seq], [ch], [em1], [em2], [em3], [DeviceId], [emData]) VALUES (4, N'169.254.191.220', N'1동2F', N'사무실3', N'4번앰프', N'1동2F 사무실3 4번앰프', 112, N'DPCB-30-93dcbe', N'On-Line', N'', 0, 4, 1, NULL, NULL, NULL, 13, N'01동/01계단/02층')
GO
INSERT [dbo].[Assets] ([AssetId], [ip], [GroupName], [ZoneName], [SpeakerName], [path], [floor], [DeviceName], [state], [state_old], [chk], [seq], [ch], [em1], [em2], [em3], [DeviceId], [emData]) VALUES (5, N'169.254.243.217', N'1동3F', N'사무실4', N'5번앰프', N'1동3F 사무실4 5번앰프', 113, N'DPCB-30-93d9f2', N'On-Line', N'', 0, 5, 1, NULL, NULL, NULL, 11, N'01동/01계단/03층')
GO
INSERT [dbo].[Assets] ([AssetId], [ip], [GroupName], [ZoneName], [SpeakerName], [path], [floor], [DeviceName], [state], [state_old], [chk], [seq], [ch], [em1], [em2], [em3], [DeviceId], [emData]) VALUES (6, N'169.254.223.123', N'2동1F', N'근린사무실5', N'6번앰프', N'2동1F 근린사무실5 6번앰프', 211, N'DPCB-30-917bde', N'On-Line', N'', 0, 6, 1, NULL, NULL, NULL, 12, N'02동/01계단/01층')
GO
INSERT [dbo].[Assets] ([AssetId], [ip], [GroupName], [ZoneName], [SpeakerName], [path], [floor], [DeviceName], [state], [state_old], [chk], [seq], [ch], [em1], [em2], [em3], [DeviceId], [emData]) VALUES (7, N'169.254.77.94', N'2동2F', N'근린사무실6', N'7번앰프', N'2동2F 근린사무실6 7번앰프', 212, N'DPCB-30-955e4c', N'On-Line', N'', 0, 7, 1, NULL, NULL, NULL, 16, N'02동/01계단/02층')
GO
INSERT [dbo].[Assets] ([AssetId], [ip], [GroupName], [ZoneName], [SpeakerName], [path], [floor], [DeviceName], [state], [state_old], [chk], [seq], [ch], [em1], [em2], [em3], [DeviceId], [emData]) VALUES (8, N'169.254.36.139', N'3동1F', N'오피사무실7', N'8번앰프', N'3동1F 오피사무실7 8번앰프', 311, N'DPCB-30-838b23', N'On-Line', N'', 0, 8, 1, NULL, NULL, NULL, 7, N'03동/01계단/01층')
GO
INSERT [dbo].[Assets] ([AssetId], [ip], [GroupName], [ZoneName], [SpeakerName], [path], [floor], [DeviceName], [state], [state_old], [chk], [seq], [ch], [em1], [em2], [em3], [DeviceId], [emData]) VALUES (9, N'169.254.115.98', N'3동2F', N'오피사무실8', N'9번앰프', N'3동2F 오피사무실8 9번앰프', 312, N'DPCB-30-906272', N'On-Line', N'', 0, 9, 1, NULL, NULL, NULL, 10, N'03동/01계단/02층')
GO
SET IDENTITY_INSERT [dbo].[Assets] OFF
GO
SET IDENTITY_INSERT [dbo].[BSroom] ON 
GO
INSERT [dbo].[BSroom] ([BSroomid], [user_name], [state], [mode]) VALUES (1, N'', 0, 0)
GO
INSERT [dbo].[BSroom] ([BSroomid], [user_name], [state], [mode]) VALUES (2, N'', 0, 0)
GO
INSERT [dbo].[BSroom] ([BSroomid], [user_name], [state], [mode]) VALUES (3, N'', 0, 0)
GO
INSERT [dbo].[BSroom] ([BSroomid], [user_name], [state], [mode]) VALUES (4, N'', 0, 0)
GO
INSERT [dbo].[BSroom] ([BSroomid], [user_name], [state], [mode]) VALUES (5, N'', 0, 0)
GO
INSERT [dbo].[BSroom] ([BSroomid], [user_name], [state], [mode]) VALUES (6, N'', 0, 0)
GO
INSERT [dbo].[BSroom] ([BSroomid], [user_name], [state], [mode]) VALUES (7, N'', 0, 0)
GO
SET IDENTITY_INSERT [dbo].[BSroom] OFF
GO
SET IDENTITY_INSERT [dbo].[Device] ON 
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (1, 2, N'169.254.217.9', N'169.254.33.34', N'DSP-16D-011628', N'DSP-16D-011628', N'', 1, N'', 0, 0, 0, N'통신실', 0, N'', 16, NULL)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (2, 2, N'169.254.164.173', N'169.254.20.227', N'DSP-32D-1cd3cc', N'DSP-32D-1cd3cc', N'', 1, N'', 0, 0, 0, N'통신실', 0, N'', 32, NULL)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (3, 9, N'169.254.175.75', N'', N'DESKTOP-CR0J0RD-2', N'DESKTOP-CR0J0RD-2', N'DESKTOP-CR0J0RD', 1, N'', 0, 0, 0, N'통신실', 0, N'', 0, NULL)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (4, 9, N'169.254.158.177', N'', N'DESKTOP-KVOOQ6I', N'DESKTOP-KVOOQ6I', N'DESKTOP-KVOOQ6I', 1, N'', 0, 0, 0, N'통신실', 0, N'', 1, NULL)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (5, 9, N'169.254.246.19', N'', N'DESKTOP-V3A58UI-2', N'DESKTOP-V3A58UI-2', N'DESKTOP-V3A58UI', 1, N'', 0, 0, 0, N'통신실', 0, N'', 2, NULL)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (6, 0, N'169.254.198.94', N'', N'CP-650Da-955ec5', N'CP-650Da-955ec5', N'', 1, N'', 0, 0, 0, N'통신실', 0, N'', 0, NULL)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (7, 0, N'169.254.36.139', N'', N'DPCB-30-838b23', N'DPCB-30-838b23', N'', 1, N'', 0, 0, 0, N'3동1F 오피사무실7 8번앰프', 0, N'03동/01계단/01층', 0, 8)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (8, 0, N'169.254.241.123', N'', N'DPCB-30-917bf0', N'DPCB-30-917bf0', N'', 1, N'', 0, 0, 0, N'1동1F 사무실2 2번앰프', 0, N'01동/01계단/01층', 0, 3)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (9, 3, N'169.254.87.121', N'', N'AVIOBT-527956', N'AVIOBT-527956', N'', 1, N'', 0, 0, 0, N'통신실', 0, N'', 1, NULL)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (10, 0, N'169.254.115.98', N'', N'DPCB-30-906272', N'DPCB-30-906272', N'', 1, N'', 0, 0, 0, N'3동2F 오피사무실8 9번앰프', 0, N'03동/01계단/02층', 0, 9)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (11, 0, N'169.254.243.217', N'', N'DPCB-30-93d9f2', N'DPCB-30-93d9f2', N'', 1, N'', 0, 0, 0, N'1동3F 사무실4 5번앰프', 0, N'01동/01계단/03층', 0, 5)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (12, 0, N'169.254.223.123', N'', N'DPCB-30-917bde', N'DPCB-30-917bde', N'', 1, N'', 0, 0, 0, N'2동1F 근린사무실5 6번앰프', 0, N'02동/01계단/01층', 0, 6)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (13, 0, N'169.254.191.220', N'', N'DPCB-30-93dcbe', N'DPCB-30-93dcbe', N'', 1, N'', 0, 0, 0, N'1동2F 사무실3 4번앰프', 0, N'01동/01계단/02층', 0, 4)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (14, 0, N'169.254.150.80', N'', N'MA1000T-845095', N'MA1000T-845095', N'MA1000T-845095', 1, N'', 0, 0, 0, N'1동B1F 통신실1 1번앰프', 0, N'01동/01계단/00층', 0, 1)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (15, 0, N'169.254.150.80', N'', N'MA1000T-845095', N'MA1000T-845095', N'MA1000T-845095', 2, N'', 0, 0, 0, N'1동B1F 통신실2 2번앰프', 0, N'01동/01계단/00층', 0, 2)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (16, 0, N'169.254.77.94', N'', N'DPCB-30-955e4c', N'DPCB-30-955e4c', N'', 1, N'', 0, 0, 0, N'2동2F 근린사무실6 7번앰프', 0, N'02동/01계단/02층', 0, 7)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (17, 3, N'169.254.98.15', N'', N'AVIOUSB-520f61', N'AVIOUSB-520f61', N'', 1, N'', 0, 0, 0, N'통신실', 0, N'', 0, NULL)
GO
SET IDENTITY_INSERT [dbo].[Device] OFF
GO
SET IDENTITY_INSERT [dbo].[DeviceChannel] ON 
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (1, N'6', N'OUT22', N'271d0035002530100000010100010020002600000000000000000000000000004f55543232004453502d3136442d30313136323800', N'271d0035003530100000010100020020002600000000000000000000000000004f55543232004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (2, N'7', N'OUT23', N'271d0035002630100000010100010020002600000000000000000000000000004f55543233004453502d3136442d30313136323800', N'271d0035003630100000010100020020002600000000000000000000000000004f55543233004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (3, N'8', N'OUT24', N'271d0035002730100000010100010020002600000000000000000000000000004f55543234004453502d3136442d30313136323800', N'271d0035003730100000010100020020002600000000000000000000000000004f55543234004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (4, N'9', N'OUT25', N'271d0035002830100000010100010020002600000000000000000000000000004f55543235004453502d3136442d30313136323800', N'271d0035003830100000010100020020002600000000000000000000000000004f55543235004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (5, N'10', N'OUT26', N'271d0035002930100000010100010020002600000000000000000000000000004f55543236004453502d3136442d30313136323800', N'271d0035003930100000010100020020002600000000000000000000000000004f55543236004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (6, N'11', N'OUT27', N'271d0035002a30100000010100010020002600000000000000000000000000004f55543237004453502d3136442d30313136323800', N'271d0035003a30100000010100020020002600000000000000000000000000004f55543237004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (7, N'12', N'OUT28', N'271d0035002b30100000010100010020002600000000000000000000000000004f55543238004453502d3136442d30313136323800', N'271d0035003b30100000010100020020002600000000000000000000000000004f55543238004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (8, N'13', N'OUT29', N'271d0035002c30100000010100010020002600000000000000000000000000004f55543239004453502d3136442d30313136323800', N'271d0035003c30100000010100020020002600000000000000000000000000004f55543239004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (9, N'14', N'OUT30', N'271d0035002d30100000010100010020002600000000000000000000000000004f55543330004453502d3136442d30313136323800', N'271d0035003d30100000010100020020002600000000000000000000000000004f55543330004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (10, N'15', N'OUT31', N'271d0035002e30100000010100010020002600000000000000000000000000004f55543331004453502d3136442d30313136323800', N'271d0035003e30100000010100020020002600000000000000000000000000004f55543331004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (11, N'16', N'OUT32', N'271d0035002f30100000010100010020002600000000000000000000000000004f55543332004453502d3136442d30313136323800', N'271d0035003f30100000010100020020002600000000000000000000000000004f55543332004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (12, N'1', N'OUT17', N'271d0035002030100000010100010020002600000000000000000000000000004f55543137004453502d3136442d30313136323800', N'271d0035003030100000010100020020002600000000000000000000000000004f55543137004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (13, N'2', N'OUT18', N'271d0035002130100000010100010020002600000000000000000000000000004f55543138004453502d3136442d30313136323800', N'271d0035003130100000010100020020002600000000000000000000000000004f55543138004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (14, N'3', N'OUT19', N'271d0035002230100000010100010020002600000000000000000000000000004f55543139004453502d3136442d30313136323800', N'271d0035003230100000010100020020002600000000000000000000000000004f55543139004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (15, N'4', N'OUT20', N'271d0035002330100000010100010020002600000000000000000000000000004f55543230004453502d3136442d30313136323800', N'271d0035003330100000010100020020002600000000000000000000000000004f55543230004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (16, N'5', N'OUT21', N'271d0035002430100000010100010020002600000000000000000000000000004f55543231004453502d3136442d30313136323800', N'271d0035003430100000010100020020002600000000000000000000000000004f55543231004453502d3136442d30313136323800', 1, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (17, N'17', N'IN17', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (18, N'18', N'IN18', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (19, N'19', N'IN19', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (20, N'20', N'IN20', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (21, N'21', N'IN21', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (22, N'22', N'IN22', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (23, N'23', N'IN23', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (24, N'24', N'IN24', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (25, N'25', N'IN25', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (26, N'26', N'IN26', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (27, N'27', N'IN27', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (28, N'28', N'IN28', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (29, N'29', N'IN29', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (30, N'30', N'IN30', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (31, N'31', N'IN31', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (32, N'32', N'IN32', N'', N'', 1, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (33, N'1', N'OUT1', N'271d0034002030100000010100010020002500000000000000000000000000004f555431004453502d3332442d31636433636300', N'271d0034003030100000010100020020002500000000000000000000000000004f555431004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (34, N'2', N'OUT2', N'271d0034002130100000010100010020002500000000000000000000000000004f555432004453502d3332442d31636433636300', N'271d0034003130100000010100020020002500000000000000000000000000004f555432004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (35, N'3', N'OUT3', N'271d0034002230100000010100010020002500000000000000000000000000004f555433004453502d3332442d31636433636300', N'271d0034003230100000010100020020002500000000000000000000000000004f555433004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (36, N'4', N'OUT4', N'271d0034002330100000010100010020002500000000000000000000000000004f555434004453502d3332442d31636433636300', N'271d0034003330100000010100020020002500000000000000000000000000004f555434004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (37, N'5', N'OUT5', N'271d0034002430100000010100010020002500000000000000000000000000004f555435004453502d3332442d31636433636300', N'271d0034003430100000010100020020002500000000000000000000000000004f555435004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (38, N'6', N'OUT6', N'271d0034002530100000010100010020002500000000000000000000000000004f555436004453502d3332442d31636433636300', N'271d0034003530100000010100020020002500000000000000000000000000004f555436004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (39, N'7', N'OUT7', N'271d0034002630100000010100010020002500000000000000000000000000004f555437004453502d3332442d31636433636300', N'271d0034003630100000010100020020002500000000000000000000000000004f555437004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (40, N'8', N'OUT8', N'271d0034002730100000010100010020002500000000000000000000000000004f555438004453502d3332442d31636433636300', N'271d0034003730100000010100020020002500000000000000000000000000004f555438004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (41, N'9', N'OUT9', N'271d0034002830100000010100010020002500000000000000000000000000004f555439004453502d3332442d31636433636300', N'271d0034003830100000010100020020002500000000000000000000000000004f555439004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (42, N'10', N'OUT10', N'271d0035002930100000010100010020002600000000000000000000000000004f55543130004453502d3332442d31636433636300', N'271d0035003930100000010100020020002600000000000000000000000000004f55543130004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (43, N'11', N'OUT11', N'271d0035002a30100000010100010020002600000000000000000000000000004f55543131004453502d3332442d31636433636300', N'271d0035003a30100000010100020020002600000000000000000000000000004f55543131004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (44, N'12', N'OUT12', N'271d0035002b30100000010100010020002600000000000000000000000000004f55543132004453502d3332442d31636433636300', N'271d0035003b30100000010100020020002600000000000000000000000000004f55543132004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (45, N'13', N'OUT13', N'271d0035002c30100000010100010020002600000000000000000000000000004f55543133004453502d3332442d31636433636300', N'271d0035003c30100000010100020020002600000000000000000000000000004f55543133004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (46, N'14', N'OUT14', N'271d0035002d30100000010100010020002600000000000000000000000000004f55543134004453502d3332442d31636433636300', N'271d0035003d30100000010100020020002600000000000000000000000000004f55543134004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (47, N'15', N'OUT15', N'271d0035002e30100000010100010020002600000000000000000000000000004f55543135004453502d3332442d31636433636300', N'271d0035003e30100000010100020020002600000000000000000000000000004f55543135004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (48, N'16', N'OUT16', N'271d0035002f30100000010100010020002600000000000000000000000000004f55543136004453502d3332442d31636433636300', N'271d0035003f30100000010100020020002600000000000000000000000000004f55543136004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (49, N'17', N'OUT17', N'271d0035003030100000010100010020002600000000000000000000000000004f55543137004453502d3332442d31636433636300', N'271d0035004030100000010100020020002600000000000000000000000000004f55543137004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (50, N'18', N'OUT18', N'271d0035003130100000010100010020002600000000000000000000000000004f55543138004453502d3332442d31636433636300', N'271d0035004130100000010100020020002600000000000000000000000000004f55543138004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (51, N'19', N'OUT19', N'271d0035003230100000010100010020002600000000000000000000000000004f55543139004453502d3332442d31636433636300', N'271d0035004230100000010100020020002600000000000000000000000000004f55543139004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (52, N'20', N'OUT20', N'271d0035003330100000010100010020002600000000000000000000000000004f55543230004453502d3332442d31636433636300', N'271d0035004330100000010100020020002600000000000000000000000000004f55543230004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (53, N'21', N'OUT21', N'271d0035003430100000010100010020002600000000000000000000000000004f55543231004453502d3332442d31636433636300', N'271d0035004430100000010100020020002600000000000000000000000000004f55543231004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (54, N'22', N'OUT22', N'271d0035003530100000010100010020002600000000000000000000000000004f55543232004453502d3332442d31636433636300', N'271d0035004530100000010100020020002600000000000000000000000000004f55543232004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (55, N'23', N'OUT23', N'271d0035003630100000010100010020002600000000000000000000000000004f55543233004453502d3332442d31636433636300', N'271d0035004630100000010100020020002600000000000000000000000000004f55543233004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (56, N'24', N'OUT24', N'271d0035003730100000010100010020002600000000000000000000000000004f55543234004453502d3332442d31636433636300', N'271d0035004730100000010100020020002600000000000000000000000000004f55543234004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (57, N'25', N'OUT25', N'271d0035003830100000010100010020002600000000000000000000000000004f55543235004453502d3332442d31636433636300', N'271d0035004830100000010100020020002600000000000000000000000000004f55543235004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (58, N'26', N'OUT26', N'271d0035003930100000010100010020002600000000000000000000000000004f55543236004453502d3332442d31636433636300', N'271d0035004930100000010100020020002600000000000000000000000000004f55543236004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (59, N'27', N'OUT27', N'271d0035003a30100000010100010020002600000000000000000000000000004f55543237004453502d3332442d31636433636300', N'271d0035004a30100000010100020020002600000000000000000000000000004f55543237004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (60, N'28', N'OUT28', N'271d0035003b30100000010100010020002600000000000000000000000000004f55543238004453502d3332442d31636433636300', N'271d0035004b30100000010100020020002600000000000000000000000000004f55543238004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (61, N'29', N'OUT29', N'271d0035003c30100000010100010020002600000000000000000000000000004f55543239004453502d3332442d31636433636300', N'271d0035004c30100000010100020020002600000000000000000000000000004f55543239004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (62, N'30', N'OUT30', N'271d0035003d30100000010100010020002600000000000000000000000000004f55543330004453502d3332442d31636433636300', N'271d0035004d30100000010100020020002600000000000000000000000000004f55543330004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (63, N'31', N'OUT31', N'271d0035003e30100000010100010020002600000000000000000000000000004f55543331004453502d3332442d31636433636300', N'271d0035004e30100000010100020020002600000000000000000000000000004f55543331004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (64, N'32', N'OUT32', N'271d0035003f30100000010100010020002600000000000000000000000000004f55543332004453502d3332442d31636433636300', N'271d0035004f30100000010100020020002600000000000000000000000000004f55543332004453502d3332442d31636433636300', 2, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (65, N'1', N'IN1', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (66, N'2', N'IN2', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (67, N'3', N'IN3', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (68, N'4', N'IN4', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (69, N'5', N'IN5', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (70, N'6', N'IN6', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (71, N'7', N'IN7', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (72, N'8', N'IN8', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (73, N'9', N'IN9', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (74, N'10', N'IN10', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (75, N'11', N'IN11', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (76, N'12', N'IN12', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (77, N'13', N'IN13', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (78, N'14', N'IN14', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (79, N'15', N'IN15', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (80, N'16', N'IN16', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (81, N'17', N'IN17', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (82, N'18', N'IN18', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (83, N'19', N'IN19', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (84, N'20', N'IN20', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (85, N'21', N'IN21', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (86, N'22', N'IN22', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (87, N'23', N'IN23', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (88, N'24', N'IN24', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (89, N'25', N'IN25', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (90, N'26', N'IN26', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (91, N'27', N'IN27', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (92, N'28', N'IN28', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (93, N'29', N'IN29', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (94, N'30', N'IN30', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (95, N'31', N'IN31', N'', N'', 2, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (96, N'32', N'IN32', N'', N'', 2, 0, N'', 0)
GO
SET IDENTITY_INSERT [dbo].[DeviceChannel] OFF
GO
SET IDENTITY_INSERT [dbo].[EMBs] ON 
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (1, N'03동/01계단/01층', 7, N'3동1F 오피사무실7 8번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (2, N'01동/01계단/01층', 8, N'1동1F 사무실2 2번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (3, N'03동/01계단/02층', 10, N'3동2F 오피사무실8 9번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (4, N'01동/01계단/03층', 11, N'1동3F 사무실4 5번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (5, N'02동/01계단/01층', 12, N'2동1F 근린사무실5 6번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (6, N'01동/01계단/02층', 13, N'1동2F 사무실3 4번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (8, N'01동/01계단/00층', 15, N'1동B1F 통신실2 2번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (9, N'02동/01계단/02층', 16, N'2동2F 근린사무실6 7번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (10, N'01동/01계단/00층', 7, N'3동1F 오피사무실7 8번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (11, N'01동/01계단/00층', 8, N'1동1F 사무실2 2번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (12, N'01동/01계단/02층', 11, N'1동3F 사무실4 5번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (13, N'01동/01계단/02층', 14, N'1동B1F 통신실1 1번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (14, N'01동/01계단/00층', 14, N'1동B1F 통신실1 1번앰프')
GO
SET IDENTITY_INSERT [dbo].[EMBs] OFF
GO
SET IDENTITY_INSERT [dbo].[Eventvm] ON 
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (1, CAST(N'2022-06-21T14:00:18.407' AS DateTime), N'eEM_PRESET_SW', NULL, N'All 프리셋 버튼 : On', NULL, N'ON', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (2, CAST(N'2022-06-21T14:19:35.860' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'ff7ea32e-5807-4eb8-a3b3-eee975a99875', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (3, CAST(N'2022-06-21T14:21:41.040' AS DateTime), N'사용자 로그아웃', NULL, N'Admin', NULL, N'ff7ea32e-5807-4eb8-a3b3-eee975a99875', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (4, CAST(N'2022-06-23T10:36:46.347' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'4ad76608-9961-48d2-b67a-08dce13435e6', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (5, CAST(N'2022-06-23T10:46:18.400' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'01a054bb-ce26-4916-82b1-21774e3d8664', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (6, CAST(N'2022-06-23T11:05:15.733' AS DateTime), N'사용자 로그아웃', NULL, N'Admin', NULL, N'01a054bb-ce26-4916-82b1-21774e3d8664', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (7, CAST(N'2022-06-23T11:10:32.940' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'81c69898-03e5-4c27-8212-09c34ae1024c', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (8, CAST(N'2022-06-23T11:41:15.357' AS DateTime), N'사용자 로그아웃', NULL, N'Admin', NULL, N'81c69898-03e5-4c27-8212-09c34ae1024c', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (9, CAST(N'2022-06-27T09:57:06.247' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'51d33474-65f1-4c52-993d-728c89bc9834', 0)
GO
SET IDENTITY_INSERT [dbo].[Eventvm] OFF
GO
SET IDENTITY_INSERT [dbo].[Musics] ON 
GO
INSERT [dbo].[Musics] ([MusicId], [FileName], [FileContent], [deletable], [duration]) VALUES (1, N'01-cast_of_frozen-frozen_heart.mp3', N'', N'N', N'00:01:47')
GO
INSERT [dbo].[Musics] ([MusicId], [FileName], [FileContent], [deletable], [duration]) VALUES (2, N'05-idina_menzel-let_it_go.mp3', N'', N'N', N'00:03:45')
GO
INSERT [dbo].[Musics] ([MusicId], [FileName], [FileContent], [deletable], [duration]) VALUES (3, N'A Maidens Prayer.mp3', N'', N'N', N'00:00:18')
GO
INSERT [dbo].[Musics] ([MusicId], [FileName], [FileContent], [deletable], [duration]) VALUES (4, N'Amaryllis.mp3', N'', N'N', N'00:00:24')
GO
INSERT [dbo].[Musics] ([MusicId], [FileName], [FileContent], [deletable], [duration]) VALUES (5, N'띠링.mp3', N'', N'N', N'00:00:01')
GO
INSERT [dbo].[Musics] ([MusicId], [FileName], [FileContent], [deletable], [duration]) VALUES (6, N'민방공+경계경보(1분).mp3', N'', N'N', N'00:01:00')
GO
INSERT [dbo].[Musics] ([MusicId], [FileName], [FileContent], [deletable], [duration]) VALUES (7, N'민방공+공습경보(3분).mp3', N'', N'N', N'00:03:07')
GO
INSERT [dbo].[Musics] ([MusicId], [FileName], [FileContent], [deletable], [duration]) VALUES (8, N'시작종소리.mp3', N'', N'N', N'00:00:11')
GO
INSERT [dbo].[Musics] ([MusicId], [FileName], [FileContent], [deletable], [duration]) VALUES (9, N'재난위험경보(3분).mp3', N'', N'N', N'00:03:05')
GO
INSERT [dbo].[Musics] ([MusicId], [FileName], [FileContent], [deletable], [duration]) VALUES (10, N'종료종소리.mp3', N'', N'N', N'00:00:08')
GO
SET IDENTITY_INSERT [dbo].[Musics] OFF
GO
SET IDENTITY_INSERT [dbo].[Simplepa] ON 
GO
INSERT [dbo].[Simplepa] ([SimplePAId], [TileWidth], [MapX], [MapY], [Zoom], [debug], [SpeakerIconSize], [UserName], [EMServerIP], [ServerIP], [ServerPort], [Reserved1], [Reserved2], [Reserved3], [Reserved4], [Reserved5], [Reserved6], [Reserved7], [Reserved8], [Reserved9], [Reserved10], [Reserved11], [GPIOPort], [Rport], [Reserved15], [Reserved16], [Jigsangbalhwa], [SpeakerTimer], [inputvolume], [outputvolume], [disp], [Multi_Ch], [SoundDeviceNum], [SoundDeviceName], [Reserved17], [scalelength], [length], [scale], [noise1], [noise2], [dsp_vol], [dsp_vol_em], [sms_server], [sms_id], [sms_pw], [sms_rcvno], [Pport], [EmMusic]) VALUES (1, 180, 4000, 4000, 0.2, 0, 120, N'엘에스전선', N'127.0.0.1', N'192.168.1.1', NULL, N'0', N'0', N'0', N'0', N'1', N'P형수신기', N'http://www.radio-korea.com/embed/sbs-radio-love-fm-428824', N'http://www.radio-korea.com/embed/ytn-radio-401695', N'http://www.radio-korea.com/embed/ebs-fm-428830', N'', N'0', N'COM3', N'COM4', N'', N'', 1, 10, 0.5, 0.5, 1, 3, 0, NULL, 0, 0, 0, NULL, NULL, NULL, 5, 7, N'https://sms.nicesms.co.kr/cpsms_utf8/cpsms.html', N'lscnssms', N'3ef5afb7e743196d9e0726dba16b02d9', N'', 0, N'재난위험경보(3분).mp3')
GO
SET IDENTITY_INSERT [dbo].[Simplepa] OFF
GO
SET IDENTITY_INSERT [dbo].[UserTrees] ON 
GO
INSERT [dbo].[UserTrees] ([UserTreeId], [user_group], [user_name], [login_id], [login_password], [login_password2], [mobile], [email]) VALUES (1, N'Admin', N'관리자', N'Admin', N'Admin', N'Admin', N'01012341234', N'admin@user.com')
GO
INSERT [dbo].[UserTrees] ([UserTreeId], [user_group], [user_name], [login_id], [login_password], [login_password2], [mobile], [email]) VALUES (2, N'User', N'user', N'user', N'user', N'user', N'(111) 111-1111', N'aaa@aaa.com')
GO
INSERT [dbo].[UserTrees] ([UserTreeId], [user_group], [user_name], [login_id], [login_password], [login_password2], [mobile], [email]) VALUES (3, N'User', N'홍길동', N'hong', N'hong', N'hong', N'(010) 000-0000', N'hong@aaa.com')
GO
SET IDENTITY_INSERT [dbo].[UserTrees] OFF
GO
