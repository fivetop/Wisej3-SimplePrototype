USE [simplePA]
GO
SET IDENTITY_INSERT [dbo].[BSroom] ON 
GO
INSERT [dbo].[BSroom] ([BSroomid], [user_name], [state], [mode]) VALUES (1, N'관리자', 1, 0)
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
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (35, 2, N'169.254.217.9', N'169.254.33.34', N'DSP-16D-011628', N'DSP-16D-011628', N'', 1, N'', 0, 0, 0, N'', 0, N'', 16, NULL)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (36, 2, N'169.254.164.173', N'169.254.20.227', N'DSP-32D-1cd3cc', N'DSP-32D-1cd3cc', N'', 1, N'', 0, 0, 0, N'', 0, N'', 32, NULL)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (37, 9, N'169.254.175.75', N'', N'DESKTOP-CR0J0RD-2', N'DESKTOP-CR0J0RD-2', N'DESKTOP-CR0J0RD', 1, N'', 0, 0, 0, N'', 0, N'', 0, NULL)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (38, 9, N'169.254.158.177', N'', N'DESKTOP-KVOOQ6I', N'DESKTOP-KVOOQ6I', N'DESKTOP-KVOOQ6I', 1, N'', 0, 0, 0, N'', 0, N'', 1, NULL)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (39, 9, N'169.254.246.19', N'', N'DESKTOP-V3A58UI-2', N'DESKTOP-V3A58UI-2', N'DESKTOP-V3A58UI', 1, N'', 0, 0, 0, N'', 0, N'', 2, NULL)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (40, 0, N'169.254.198.94', N'', N'CP-650Da-955ec5', N'CP-650Da-955ec5', N'', 1, N'', 0, 0, 0, N'', 0, N'', 0, NULL)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (41, 0, N'169.254.36.139', N'', N'DPCB-30-838b23', N'DPCB-30-838b23', N'', 1, N'', 0, 0, 0, N'3동 1F 오피사무실7 8번앰프', 0, N'03동/01계단/01층', 0, 53)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (42, 0, N'169.254.241.123', N'', N'DPCB-30-917bf0', N'DPCB-30-917bf0', N'', 1, N'', 0, 0, 0, N'1동 1F 사무실2 2번앰프', 0, N'01동/01계단/01층', 0, 48)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (43, 3, N'169.254.87.121', N'', N'AVIOBT-527956', N'AVIOBT-527956', N'', 1, N'', 0, 0, 0, N'', 0, N'', 1, NULL)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (44, 0, N'169.254.115.98', N'', N'DPCB-30-906272', N'DPCB-30-906272', N'', 1, N'', 0, 0, 0, N'3동 2F 오피사무실8 9번앰프', 0, N'03동/01계단/02층', 0, 54)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (45, 0, N'169.254.243.217', N'', N'DPCB-30-93d9f2', N'DPCB-30-93d9f2', N'', 1, N'', 0, 0, 0, N'1동 3F 사무실4 5번앰프', 0, N'01동/01계단/03층', 0, 50)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (46, 0, N'169.254.223.123', N'', N'DPCB-30-917bde', N'DPCB-30-917bde', N'', 1, N'', 0, 0, 0, N'2동 1F 근린사무실5 6번앰프', 0, N'02동/01계단/01층', 0, 51)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (47, 0, N'169.254.191.220', N'', N'DPCB-30-93dcbe', N'DPCB-30-93dcbe', N'', 1, N'', 0, 0, 0, N'1동 2F 사무실3 4번앰프', 0, N'01동/01계단/02층', 0, 49)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (48, 0, N'169.254.150.80', N'', N'MA1000T-845095', N'MA1000T-845095', N'MA1000T-845095', 1, N'', 0, 0, 0, N'1동 B1F 통신실1 1번앰프', 0, N'01동/01계단/00층', 0, 46)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (49, 0, N'169.254.150.80', N'', N'MA1000T-845095', N'MA1000T-845095', N'MA1000T-845095', 2, N'', 0, 0, 0, N'1동 B1F 통신실2 2번앰프', 0, N'01동/01계단/00층', 0, 47)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (50, 0, N'169.254.77.94', N'', N'DPCB-30-955e4c', N'DPCB-30-955e4c', N'', 1, N'', 0, 0, 0, N'2동 2F 근린사무실6 7번앰프', 0, N'02동/01계단/02층', 0, 52)
GO
INSERT [dbo].[Device] ([DeviceId], [device], [ip], [ip_dspctrl], [name], [DeviceName], [DanteModelName], [chspk], [dsp_name], [dsp_chno], [dsp_vol], [dsp_vol_em], [path], [floor_em], [emData], [chCount], [AssetId]) VALUES (51, 3, N'169.254.98.15', N'', N'AVIOUSB-520f61', N'AVIOUSB-520f61', N'', 1, N'', 0, 0, 0, N'', 0, N'', 0, NULL)
GO
SET IDENTITY_INSERT [dbo].[Device] OFF
GO
SET IDENTITY_INSERT [dbo].[DeviceChannel] ON 
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (193, N'6', N'OUT22', N'271d0035002530100000010100010020002600000000000000000000000000004f55543232004453502d3136442d30313136323800', N'271d0035003530100000010100020020002600000000000000000000000000004f55543232004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (194, N'7', N'OUT23', N'271d0035002630100000010100010020002600000000000000000000000000004f55543233004453502d3136442d30313136323800', N'271d0035003630100000010100020020002600000000000000000000000000004f55543233004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (195, N'8', N'OUT24', N'271d0035002730100000010100010020002600000000000000000000000000004f55543234004453502d3136442d30313136323800', N'271d0035003730100000010100020020002600000000000000000000000000004f55543234004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (196, N'9', N'OUT25', N'271d0035002830100000010100010020002600000000000000000000000000004f55543235004453502d3136442d30313136323800', N'271d0035003830100000010100020020002600000000000000000000000000004f55543235004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (197, N'10', N'OUT26', N'271d0035002930100000010100010020002600000000000000000000000000004f55543236004453502d3136442d30313136323800', N'271d0035003930100000010100020020002600000000000000000000000000004f55543236004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (198, N'11', N'OUT27', N'271d0035002a30100000010100010020002600000000000000000000000000004f55543237004453502d3136442d30313136323800', N'271d0035003a30100000010100020020002600000000000000000000000000004f55543237004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (199, N'12', N'OUT28', N'271d0035002b30100000010100010020002600000000000000000000000000004f55543238004453502d3136442d30313136323800', N'271d0035003b30100000010100020020002600000000000000000000000000004f55543238004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (200, N'13', N'OUT29', N'271d0035002c30100000010100010020002600000000000000000000000000004f55543239004453502d3136442d30313136323800', N'271d0035003c30100000010100020020002600000000000000000000000000004f55543239004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (201, N'14', N'OUT30', N'271d0035002d30100000010100010020002600000000000000000000000000004f55543330004453502d3136442d30313136323800', N'271d0035003d30100000010100020020002600000000000000000000000000004f55543330004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (202, N'15', N'OUT31', N'271d0035002e30100000010100010020002600000000000000000000000000004f55543331004453502d3136442d30313136323800', N'271d0035003e30100000010100020020002600000000000000000000000000004f55543331004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (203, N'16', N'OUT32', N'271d0035002f30100000010100010020002600000000000000000000000000004f55543332004453502d3136442d30313136323800', N'271d0035003f30100000010100020020002600000000000000000000000000004f55543332004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (204, N'1', N'OUT17', N'271d0035002030100000010100010020002600000000000000000000000000004f55543137004453502d3136442d30313136323800', N'271d0035003030100000010100020020002600000000000000000000000000004f55543137004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (205, N'2', N'OUT18', N'271d0035002130100000010100010020002600000000000000000000000000004f55543138004453502d3136442d30313136323800', N'271d0035003130100000010100020020002600000000000000000000000000004f55543138004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (206, N'3', N'OUT19', N'271d0035002230100000010100010020002600000000000000000000000000004f55543139004453502d3136442d30313136323800', N'271d0035003230100000010100020020002600000000000000000000000000004f55543139004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (207, N'4', N'OUT20', N'271d0035002330100000010100010020002600000000000000000000000000004f55543230004453502d3136442d30313136323800', N'271d0035003330100000010100020020002600000000000000000000000000004f55543230004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (208, N'5', N'OUT21', N'271d0035002430100000010100010020002600000000000000000000000000004f55543231004453502d3136442d30313136323800', N'271d0035003430100000010100020020002600000000000000000000000000004f55543231004453502d3136442d30313136323800', 35, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (209, N'17', N'IN17', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (210, N'18', N'IN18', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (211, N'19', N'IN19', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (212, N'20', N'IN20', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (213, N'21', N'IN21', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (214, N'22', N'IN22', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (215, N'23', N'IN23', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (216, N'24', N'IN24', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (217, N'25', N'IN25', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (218, N'26', N'IN26', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (219, N'27', N'IN27', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (220, N'28', N'IN28', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (221, N'29', N'IN29', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (222, N'30', N'IN30', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (223, N'31', N'IN31', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (224, N'32', N'IN32', N'', N'', 35, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (225, N'1', N'OUT1', N'271d0034002030100000010100010020002500000000000000000000000000004f555431004453502d3332442d31636433636300', N'271d0034003030100000010100020020002500000000000000000000000000004f555431004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (226, N'2', N'OUT2', N'271d0034002130100000010100010020002500000000000000000000000000004f555432004453502d3332442d31636433636300', N'271d0034003130100000010100020020002500000000000000000000000000004f555432004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (227, N'3', N'OUT3', N'271d0034002230100000010100010020002500000000000000000000000000004f555433004453502d3332442d31636433636300', N'271d0034003230100000010100020020002500000000000000000000000000004f555433004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (228, N'4', N'OUT4', N'271d0034002330100000010100010020002500000000000000000000000000004f555434004453502d3332442d31636433636300', N'271d0034003330100000010100020020002500000000000000000000000000004f555434004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (229, N'5', N'OUT5', N'271d0034002430100000010100010020002500000000000000000000000000004f555435004453502d3332442d31636433636300', N'271d0034003430100000010100020020002500000000000000000000000000004f555435004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (230, N'6', N'OUT6', N'271d0034002530100000010100010020002500000000000000000000000000004f555436004453502d3332442d31636433636300', N'271d0034003530100000010100020020002500000000000000000000000000004f555436004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (231, N'7', N'OUT7', N'271d0034002630100000010100010020002500000000000000000000000000004f555437004453502d3332442d31636433636300', N'271d0034003630100000010100020020002500000000000000000000000000004f555437004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (232, N'8', N'OUT8', N'271d0034002730100000010100010020002500000000000000000000000000004f555438004453502d3332442d31636433636300', N'271d0034003730100000010100020020002500000000000000000000000000004f555438004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (233, N'9', N'OUT9', N'271d0034002830100000010100010020002500000000000000000000000000004f555439004453502d3332442d31636433636300', N'271d0034003830100000010100020020002500000000000000000000000000004f555439004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (234, N'10', N'OUT10', N'271d0035002930100000010100010020002600000000000000000000000000004f55543130004453502d3332442d31636433636300', N'271d0035003930100000010100020020002600000000000000000000000000004f55543130004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (235, N'11', N'OUT11', N'271d0035002a30100000010100010020002600000000000000000000000000004f55543131004453502d3332442d31636433636300', N'271d0035003a30100000010100020020002600000000000000000000000000004f55543131004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (236, N'12', N'OUT12', N'271d0035002b30100000010100010020002600000000000000000000000000004f55543132004453502d3332442d31636433636300', N'271d0035003b30100000010100020020002600000000000000000000000000004f55543132004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (237, N'13', N'OUT13', N'271d0035002c30100000010100010020002600000000000000000000000000004f55543133004453502d3332442d31636433636300', N'271d0035003c30100000010100020020002600000000000000000000000000004f55543133004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (238, N'14', N'OUT14', N'271d0035002d30100000010100010020002600000000000000000000000000004f55543134004453502d3332442d31636433636300', N'271d0035003d30100000010100020020002600000000000000000000000000004f55543134004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (239, N'15', N'OUT15', N'271d0035002e30100000010100010020002600000000000000000000000000004f55543135004453502d3332442d31636433636300', N'271d0035003e30100000010100020020002600000000000000000000000000004f55543135004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (240, N'16', N'OUT16', N'271d0035002f30100000010100010020002600000000000000000000000000004f55543136004453502d3332442d31636433636300', N'271d0035003f30100000010100020020002600000000000000000000000000004f55543136004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (241, N'17', N'OUT17', N'271d0035003030100000010100010020002600000000000000000000000000004f55543137004453502d3332442d31636433636300', N'271d0035004030100000010100020020002600000000000000000000000000004f55543137004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (242, N'18', N'OUT18', N'271d0035003130100000010100010020002600000000000000000000000000004f55543138004453502d3332442d31636433636300', N'271d0035004130100000010100020020002600000000000000000000000000004f55543138004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (243, N'19', N'OUT19', N'271d0035003230100000010100010020002600000000000000000000000000004f55543139004453502d3332442d31636433636300', N'271d0035004230100000010100020020002600000000000000000000000000004f55543139004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (244, N'20', N'OUT20', N'271d0035003330100000010100010020002600000000000000000000000000004f55543230004453502d3332442d31636433636300', N'271d0035004330100000010100020020002600000000000000000000000000004f55543230004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (245, N'21', N'OUT21', N'271d0035003430100000010100010020002600000000000000000000000000004f55543231004453502d3332442d31636433636300', N'271d0035004430100000010100020020002600000000000000000000000000004f55543231004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (246, N'22', N'OUT22', N'271d0035003530100000010100010020002600000000000000000000000000004f55543232004453502d3332442d31636433636300', N'271d0035004530100000010100020020002600000000000000000000000000004f55543232004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (247, N'23', N'OUT23', N'271d0035003630100000010100010020002600000000000000000000000000004f55543233004453502d3332442d31636433636300', N'271d0035004630100000010100020020002600000000000000000000000000004f55543233004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (248, N'24', N'OUT24', N'271d0035003730100000010100010020002600000000000000000000000000004f55543234004453502d3332442d31636433636300', N'271d0035004730100000010100020020002600000000000000000000000000004f55543234004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (249, N'25', N'OUT25', N'271d0035003830100000010100010020002600000000000000000000000000004f55543235004453502d3332442d31636433636300', N'271d0035004830100000010100020020002600000000000000000000000000004f55543235004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (250, N'26', N'OUT26', N'271d0035003930100000010100010020002600000000000000000000000000004f55543236004453502d3332442d31636433636300', N'271d0035004930100000010100020020002600000000000000000000000000004f55543236004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (251, N'27', N'OUT27', N'271d0035003a30100000010100010020002600000000000000000000000000004f55543237004453502d3332442d31636433636300', N'271d0035004a30100000010100020020002600000000000000000000000000004f55543237004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (252, N'28', N'OUT28', N'271d0035003b30100000010100010020002600000000000000000000000000004f55543238004453502d3332442d31636433636300', N'271d0035004b30100000010100020020002600000000000000000000000000004f55543238004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (253, N'29', N'OUT29', N'271d0035003c30100000010100010020002600000000000000000000000000004f55543239004453502d3332442d31636433636300', N'271d0035004c30100000010100020020002600000000000000000000000000004f55543239004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (254, N'30', N'OUT30', N'271d0035003d30100000010100010020002600000000000000000000000000004f55543330004453502d3332442d31636433636300', N'271d0035004d30100000010100020020002600000000000000000000000000004f55543330004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (255, N'31', N'OUT31', N'271d0035003e30100000010100010020002600000000000000000000000000004f55543331004453502d3332442d31636433636300', N'271d0035004e30100000010100020020002600000000000000000000000000004f55543331004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (256, N'32', N'OUT32', N'271d0035003f30100000010100010020002600000000000000000000000000004f55543332004453502d3332442d31636433636300', N'271d0035004f30100000010100020020002600000000000000000000000000004f55543332004453502d3332442d31636433636300', 36, 1, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (257, N'1', N'IN1', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (258, N'2', N'IN2', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (259, N'3', N'IN3', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (260, N'4', N'IN4', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (261, N'5', N'IN5', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (262, N'6', N'IN6', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (263, N'7', N'IN7', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (264, N'8', N'IN8', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (265, N'9', N'IN9', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (266, N'10', N'IN10', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (267, N'11', N'IN11', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (268, N'12', N'IN12', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (269, N'13', N'IN13', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (270, N'14', N'IN14', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (271, N'15', N'IN15', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (272, N'16', N'IN16', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (273, N'17', N'IN17', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (274, N'18', N'IN18', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (275, N'19', N'IN19', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (276, N'20', N'IN20', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (277, N'21', N'IN21', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (278, N'22', N'IN22', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (279, N'23', N'IN23', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (280, N'24', N'IN24', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (281, N'25', N'IN25', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (282, N'26', N'IN26', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (283, N'27', N'IN27', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (284, N'28', N'IN28', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (285, N'29', N'IN29', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (286, N'30', N'IN30', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (287, N'31', N'IN31', N'', N'', 36, 0, N'', 0)
GO
INSERT [dbo].[DeviceChannel] ([DeviceChnnelId], [chno], [chname], [dsp_out_ch1], [dsp_out_ch2], [DeviceId], [io], [devicein], [deviceinch]) VALUES (288, N'32', N'IN32', N'', N'', 36, 0, N'', 0)
GO
SET IDENTITY_INSERT [dbo].[DeviceChannel] OFF
GO
SET IDENTITY_INSERT [dbo].[EMBs] ON 
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (24, N'03동/01계단/01층', 41, N'3동 1F 오피사무실7 8번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (25, N'01동/01계단/01층', 42, N'1동 1F 사무실2 2번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (26, N'03동/01계단/02층', 44, N'3동 2F 오피사무실8 9번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (27, N'01동/01계단/03층', 45, N'1동 3F 사무실4 5번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (28, N'02동/01계단/01층', 46, N'2동 1F 근린사무실5 6번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (29, N'01동/01계단/02층', 47, N'1동 2F 사무실3 4번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (30, N'01동/01계단/00층', 48, N'1동 B1F 통신실1 1번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (32, N'02동/01계단/02층', 50, N'2동 2F 근린사무실6 7번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (37, N'01동/01계단/02층', 40, N'')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (1033, N'01동/01계단/00층', 46, N'2동 1F 근린사무실5 6번앰프')
GO
INSERT [dbo].[EMBs] ([EMBsId], [emData], [DeviceId], [path]) VALUES (1034, N'01동/01계단/00층', 44, N'3동 2F 오피사무실8 9번앰프')
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
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (10, CAST(N'2022-06-29T11:55:18.710' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'a91444e4-f479-4ed1-8360-b22f1c9e8518', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (11, CAST(N'2022-06-29T12:01:04.580' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'6ee78ad4-6eed-44c1-8a99-3a7fd83b62cd', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (12, CAST(N'2022-06-29T12:01:33.777' AS DateTime), N'다원방송시작', NULL, N'2번 채널', NULL, N'19,20 : 2', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (13, CAST(N'2022-06-29T12:04:20.810' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'86985937-6252-4540-b876-995573a06200', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (14, CAST(N'2022-06-30T09:52:08.760' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'fdb76bb6-03ff-4721-98eb-b8de24cc5b53', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (15, CAST(N'2022-06-30T09:53:33.880' AS DateTime), N'사용자 로그아웃', NULL, N'Admin', NULL, N'fdb76bb6-03ff-4721-98eb-b8de24cc5b53', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (16, CAST(N'2022-06-30T09:56:49.377' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'b6adaff0-4c5d-4bbb-9466-0e647790b5d6', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (17, CAST(N'2022-06-30T09:57:09.327' AS DateTime), N'사용자 로그아웃', NULL, N'Admin', NULL, N'48b855bb-fe4e-40a6-ab3a-d23577c0f0c7', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (18, CAST(N'2022-06-30T10:07:20.513' AS DateTime), N'사용자 로그아웃', NULL, N'Admin', NULL, N'b6adaff0-4c5d-4bbb-9466-0e647790b5d6', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (19, CAST(N'2022-07-18T17:06:35.707' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'e0914933-3360-463f-9855-ba316151bf97', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (20, CAST(N'2022-07-18T17:07:10.563' AS DateTime), N'다원방송시작', NULL, N'2번 채널', NULL, N'46,47,48,49 : 1,2', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (21, CAST(N'2022-07-28T16:34:17.093' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'256d02a6-ae25-447d-92a3-e94c0122aeff', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (22, CAST(N'2022-07-28T16:34:45.187' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'32387837-8c49-43d5-908b-62f573654f79', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (23, CAST(N'2022-07-28T16:35:12.130' AS DateTime), N'사용자 로그아웃', NULL, N'Admin', NULL, N'256d02a6-ae25-447d-92a3-e94c0122aeff', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (24, CAST(N'2022-07-28T16:35:16.583' AS DateTime), N'다원방송시작', NULL, N'2번 채널', NULL, N'46,48 : 2', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (25, CAST(N'2022-07-28T17:03:25.610' AS DateTime), N'사용자 로그아웃', NULL, N'Admin', NULL, N'32387837-8c49-43d5-908b-62f573654f79', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (1021, CAST(N'2022-08-10T14:12:32.257' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'f880ac06-dc59-46a1-acac-1b9e0adb448d', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (1022, CAST(N'2022-08-10T14:12:59.543' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'42fe4c13-f023-4f06-98ef-e223ca8722fe', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (1023, CAST(N'2022-08-10T14:13:22.273' AS DateTime), N'사용자 로그아웃', NULL, N'Admin', NULL, N'f880ac06-dc59-46a1-acac-1b9e0adb448d', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (1024, CAST(N'2022-08-10T14:18:47.980' AS DateTime), N'사용자 로그아웃', NULL, N'Admin', NULL, N'42fe4c13-f023-4f06-98ef-e223ca8722fe', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (1025, CAST(N'2022-08-11T16:06:20.050' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'e1b62f75-dbbf-469b-aa3c-fa954f3dbe29', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (1026, CAST(N'2022-08-18T17:20:13.657' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'486c8aa2-a3f0-4d15-bbcd-f98cad423b78', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (1027, CAST(N'2022-08-18T17:20:39.813' AS DateTime), N'다원방송시작', NULL, N'2번 채널', NULL, N'46,47 : 2,3', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (1028, CAST(N'2022-08-18T17:21:01.867' AS DateTime), N'다원방송시작', NULL, N'3번 채널', NULL, N'46,47 : 2,3', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (1029, CAST(N'2022-09-23T10:27:33.560' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'70075191-6ba3-402c-9213-9143777c7a12', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (1030, CAST(N'2022-09-23T10:28:17.383' AS DateTime), N'다원방송시작', NULL, N'2번 채널', NULL, N'46,47 : 1', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (1031, CAST(N'2022-10-06T14:26:19.430' AS DateTime), N'사용자 로그인', NULL, N'Admin', NULL, N'2f70abc0-4f46-4919-91d9-10abe436c70b', 0)
GO
INSERT [dbo].[Eventvm] ([EventVMId], [write_time], [event_text], [ip], [path], [DeviceName], [state], [alarm]) VALUES (1032, CAST(N'2022-10-06T14:26:37.303' AS DateTime), N'다원방송시작', NULL, N'2번 채널', NULL, N'46,47 : 2', 0)
GO
SET IDENTITY_INSERT [dbo].[Eventvm] OFF
GO
SET IDENTITY_INSERT [dbo].[Musics] ON 
GO
INSERT [dbo].[Musics] ([MusicId], [FileName], [FileContent], [deletable], [duration]) VALUES (1, N'01-cast_of_frozen-frozen_heart.mp3', N'시험1', N'N', N'00:01:47')
GO
INSERT [dbo].[Musics] ([MusicId], [FileName], [FileContent], [deletable], [duration]) VALUES (2, N'05-idina_menzel-let_it_go.mp3', N'시험2', N'N', N'00:03:45')
GO
INSERT [dbo].[Musics] ([MusicId], [FileName], [FileContent], [deletable], [duration]) VALUES (3, N'A Maidens Prayer.mp3', N'시험3', N'N', N'00:00:18')
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
INSERT [dbo].[Musics] ([MusicId], [FileName], [FileContent], [deletable], [duration]) VALUES (10, N'종료종소리.mp3', N'학습시간 종료', N'N', N'00:00:08')
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
