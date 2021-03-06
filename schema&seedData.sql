CREATE DATABASE [SeaOfCodSeafood]
USE [SeaOfCodSeafood]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2/24/2017 5:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 2/24/2017 5:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2/24/2017 5:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2/24/2017 5:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2/24/2017 5:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2/24/2017 5:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2/24/2017 5:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[UserName] [nvarchar](256) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 2/24/2017 5:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fish]    Script Date: 2/24/2017 5:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fish](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Fish] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FishChoices]    Script Date: 2/24/2017 5:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FishChoices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FishId] [int] NOT NULL,
	[RecipientId] [int] NOT NULL,
 CONSTRAINT [PK_FishChoices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Recipents]    Script Date: 2/24/2017 5:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recipents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[ZipCode] [nvarchar](max) NULL,
	[ApplicationUserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_Recipents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170217090957_Initial', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170217204601_recipientUserRelationship', N'1.0.0-rtm-21431')
INSERT [dbo].[AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'1', N'1', N'admin', N'ADMIN')
INSERT [dbo].[AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'2', N'2', N'user', N'USER')
INSERT [dbo].[AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'3', N'3', N'superadmin', N'SUPERADMIN')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b6dcbee6-863a-45f0-8360-8fa1b6e4183b', N'2')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'b6dcbee6-863a-45f0-8360-8fa1b6e4183b', 0, N'd03e902c-19d8-4ec0-901b-8b3fcd4e7446', N'j@j.com', 0, 1, NULL, N'J@J.COM', N'J@J.COM', N'AQAAAAEAACcQAAAAEPiBNwYzcfIBetLEXkkf/fbPvoQbQufjUpfZlU3uw7iSRIIKPZJ4V3LGvrNq1qOTQw==', NULL, 0, N'6534235f-89b9-4e51-af04-03a4a1fccc44', 0, N'j@j.com')
SET IDENTITY_INSERT [dbo].[Fish] ON 

INSERT [dbo].[Fish] ([Id], [Name]) VALUES (1, N'anchovy')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (2, N'basa')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (3, N'bass')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (4, N'blowfish')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (5, N'bluefish')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (6, N'bombay duck')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (7, N'bream')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (8, N'brill')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (9, N'butter fish')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (10, N'catfish')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (11, N'atlantic cod')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (12, N'pacific cod')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (13, N'dogfish')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (14, N'dorade')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (15, N'eel')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (16, N'flounder')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (17, N'grouper')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (18, N'haddock')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (19, N'hake')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (20, N'atlantic herring')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (21, N'pacific herring')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (22, N'halibut')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (23, N'illish')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (24, N'john dory')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (25, N'kingfish')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (26, N'lamprey')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (27, N'lingcod')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (28, N'mackerel')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (29, N'monkfish')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (30, N'mullet')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (31, N'pike')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (32, N'pollock')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (33, N'pompano')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (34, N'sablefish')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (35, N'salmon')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (36, N'sardine')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (37, N'shark')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (38, N'smelt')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (39, N'snapper')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (40, N'sole')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (41, N'sturgeon')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (42, N'swordfish')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (43, N'tilapia')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (44, N'tilefish')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (45, N'trout')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (46, N'tuna')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (47, N'turbot')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (48, N'wahoo')
INSERT [dbo].[Fish] ([Id], [Name]) VALUES (49, N'whitefish')
SET IDENTITY_INSERT [dbo].[Fish] OFF
SET IDENTITY_INSERT [dbo].[FishChoices] ON 

INSERT [dbo].[FishChoices] ([Id], [FishId], [RecipientId]) VALUES (18, 1, 15)
INSERT [dbo].[FishChoices] ([Id], [FishId], [RecipientId]) VALUES (19, 1, 16)
INSERT [dbo].[FishChoices] ([Id], [FishId], [RecipientId]) VALUES (20, 3, 17)
INSERT [dbo].[FishChoices] ([Id], [FishId], [RecipientId]) VALUES (21, 16, 18)
INSERT [dbo].[FishChoices] ([Id], [FishId], [RecipientId]) VALUES (22, 2, 20)
INSERT [dbo].[FishChoices] ([Id], [FishId], [RecipientId]) VALUES (23, 4, 20)
INSERT [dbo].[FishChoices] ([Id], [FishId], [RecipientId]) VALUES (24, 1, 21)
SET IDENTITY_INSERT [dbo].[FishChoices] OFF
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[FishChoices]  WITH NOCHECK ADD  CONSTRAINT [FK_FishChoices_Fish_FishId] FOREIGN KEY([FishId])
REFERENCES [dbo].[Fish] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FishChoices] NOCHECK CONSTRAINT [FK_FishChoices_Fish_FishId]
GO
ALTER TABLE [dbo].[FishChoices]  WITH NOCHECK ADD  CONSTRAINT [FK_FishChoices_Recipents_RecipientId] FOREIGN KEY([RecipientId])
REFERENCES [dbo].[Recipents] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FishChoices] NOCHECK CONSTRAINT [FK_FishChoices_Recipents_RecipientId]
GO
ALTER TABLE [dbo].[Recipents]  WITH CHECK ADD  CONSTRAINT [FK_Recipents_AspNetUsers_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Recipents] CHECK CONSTRAINT [FK_Recipents_AspNetUsers_ApplicationUserId]
GO
