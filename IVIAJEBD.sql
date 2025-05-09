USE [IVIAJE]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 22/4/2025 8:44:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[ID_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Pais] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL,
	[Correo] [nvarchar](50) NULL,
	[TipoViaje] [nvarchar](50) NULL,
	[CantidadPersonas] [int] NULL,
	[Destino] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Destinos]    Script Date: 22/4/2025 8:44:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Destinos](
	[ID_Destinos] [int] IDENTITY(1,1) NOT NULL,
	[ID_Reservas] [int] NULL,
	[Destino] [nvarchar](100) NOT NULL,
	[Precio] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Destinos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservas]    Script Date: 22/4/2025 8:44:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservas](
	[ID_Reservas] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cliente] [int] NULL,
	[Fecha_Salida] [date] NOT NULL,
	[Fecha_Regreso] [date] NOT NULL,
	[Num_Personas] [int] NOT NULL,
	[Estado] [nvarchar](50) NULL,
	[Costo_Total] [decimal](10, 2) NULL,
	[ID_Destino] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Reservas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([ID_Cliente], [Nombre], [Pais], [Telefono], [Correo], [TipoViaje], [CantidadPersonas], [Destino]) VALUES (1, N'Karolyn Paulino', N'Rep Dom', N'8297134569', N'kp@gmail.com', N'Grupo', 3, N'Disney')
INSERT [dbo].[Cliente] ([ID_Cliente], [Nombre], [Pais], [Telefono], [Correo], [TipoViaje], [CantidadPersonas], [Destino]) VALUES (2, N'Cristy Paulino', N'Rep Dom', N'8094561237', N'cp@gmail.com', N'Privado (+3 personas)', 3, N'Dubai')
INSERT [dbo].[Cliente] ([ID_Cliente], [Nombre], [Pais], [Telefono], [Correo], [TipoViaje], [CantidadPersonas], [Destino]) VALUES (3, N'Reyna Báez', N'Rep Dom', N'8294561789', N'rb@gmail.com', N'Privado (+3 personas)', 5, N'Guatemala ')
INSERT [dbo].[Cliente] ([ID_Cliente], [Nombre], [Pais], [Telefono], [Correo], [TipoViaje], [CantidadPersonas], [Destino]) VALUES (4, N'Caleb', N'Rep Dom', N'8097841236', N'cr@gmail.com', N'Grupo', 6, N'Perú (Lima-Cusco) ')
INSERT [dbo].[Cliente] ([ID_Cliente], [Nombre], [Pais], [Telefono], [Correo], [TipoViaje], [CantidadPersonas], [Destino]) VALUES (5, N'Ken Guitierrez ', N'Rep Dom', N'8294406162', N'kb@gmail.com', N'Grupo', 6, N'Dubai')
INSERT [dbo].[Cliente] ([ID_Cliente], [Nombre], [Pais], [Telefono], [Correo], [TipoViaje], [CantidadPersonas], [Destino]) VALUES (7, N'Jose', N'Rep Dom', N'8495556660', N'js@hotmail.com', N'Privado (+3 personas)', 4, N'Disney ')
INSERT [dbo].[Cliente] ([ID_Cliente], [Nombre], [Pais], [Telefono], [Correo], [TipoViaje], [CantidadPersonas], [Destino]) VALUES (9, N'Pedrito', N'Rep Dom', N'8495216643', N'ps@gmail.com', N'Grupo', 5, N'Disney ')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Destinos] ON 

INSERT [dbo].[Destinos] ([ID_Destinos], [ID_Reservas], [Destino], [Precio]) VALUES (2, 1, N'Colombia (Medellín-Bogotá)', 1420)
INSERT [dbo].[Destinos] ([ID_Destinos], [ID_Reservas], [Destino], [Precio]) VALUES (3, 1, N'Dubai', 1600)
INSERT [dbo].[Destinos] ([ID_Destinos], [ID_Reservas], [Destino], [Precio]) VALUES (7, 2, N'Dubai', 4500)
SET IDENTITY_INSERT [dbo].[Destinos] OFF
GO
SET IDENTITY_INSERT [dbo].[Reservas] ON 

INSERT [dbo].[Reservas] ([ID_Reservas], [ID_Cliente], [Fecha_Salida], [Fecha_Regreso], [Num_Personas], [Estado], [Costo_Total], [ID_Destino]) VALUES (1, 2, CAST(N'2025-05-04' AS Date), CAST(N'2025-05-11' AS Date), 3, N'PENDIENTE', CAST(4250.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[Reservas] ([ID_Reservas], [ID_Cliente], [Fecha_Salida], [Fecha_Regreso], [Num_Personas], [Estado], [Costo_Total], [ID_Destino]) VALUES (2, 1, CAST(N'2025-07-20' AS Date), CAST(N'2025-07-26' AS Date), 3, N'PENDIENTE', CAST(2700.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[Reservas] ([ID_Reservas], [ID_Cliente], [Fecha_Salida], [Fecha_Regreso], [Num_Personas], [Estado], [Costo_Total], [ID_Destino]) VALUES (4, 3, CAST(N'2025-04-22' AS Date), CAST(N'2025-04-30' AS Date), 5, N'PENDIENTE', CAST(1500.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[Reservas] ([ID_Reservas], [ID_Cliente], [Fecha_Salida], [Fecha_Regreso], [Num_Personas], [Estado], [Costo_Total], [ID_Destino]) VALUES (6, 2, CAST(N'2025-04-23' AS Date), CAST(N'2025-04-30' AS Date), 3, N'PENDIENTE', CAST(4260.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Reservas] ([ID_Reservas], [ID_Cliente], [Fecha_Salida], [Fecha_Regreso], [Num_Personas], [Estado], [Costo_Total], [ID_Destino]) VALUES (7, 5, CAST(N'2025-05-02' AS Date), CAST(N'2025-05-07' AS Date), 6, N'PENDIENTE', CAST(9600.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[Reservas] ([ID_Reservas], [ID_Cliente], [Fecha_Salida], [Fecha_Regreso], [Num_Personas], [Estado], [Costo_Total], [ID_Destino]) VALUES (8, 2, CAST(N'2025-04-23' AS Date), CAST(N'2025-04-29' AS Date), 5, N'PENDIENTE', CAST(7100.00 AS Decimal(10, 2)), 2)
SET IDENTITY_INSERT [dbo].[Reservas] OFF
GO
ALTER TABLE [dbo].[Destinos]  WITH CHECK ADD FOREIGN KEY([ID_Reservas])
REFERENCES [dbo].[Reservas] ([ID_Reservas])
GO
ALTER TABLE [dbo].[Reservas]  WITH CHECK ADD FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Cliente] ([ID_Cliente])
GO
