USE [BibliotecaRHDK]
GO
/****** Object:  Table [dbo].[Livros]    Script Date: 29/10/2018 06:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livros](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](250) NULL,
	[Descricao] [nvarchar](500) NULL,
	[Editora] [nvarchar](150) NULL,
	[Ano] [nvarchar](4) NULL,
	[Autor] [nvarchar](150) NULL,
 CONSTRAINT [PK_Livros] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Livros] ON 

INSERT [dbo].[Livros] ([ID], [NOME], [DESCRICAO], [EDITORA], [ANO], [AUTOR]) VALUES (1, N'Quem Pensa Enriquece', N'Administração & Negócios', N'Fundamento', N'1937', N'Napoleon Hill')
INSERT [dbo].[Livros] ([ID], [NOME], [DESCRICAO], [EDITORA], [ANO], [AUTOR]) VALUES (2, N'Geração de Valor', N'Administração & Negócios', N'Sextante', N'2014', N'Flávio Augusto da Silva')
INSERT [dbo].[Livros] ([ID], [NOME], [DESCRICAO], [EDITORA], [ANO], [AUTOR]) VALUES (3, N'Os Segredos da Mente Milionária', N'Administração & Negócios', N'Sextante', N'2005', N'T. Harv Eker')
INSERT [dbo].[Livros] ([ID], [NOME], [DESCRICAO], [EDITORA], [ANO], [AUTOR]) VALUES (4, N'Pai Rico Pai Pobre', N'Administração & Negócios', N'Campus ', N'2000', N'Robert Kiyosaki')
INSERT [dbo].[Livros] ([ID], [NOME], [DESCRICAO], [EDITORA], [ANO], [AUTOR]) VALUES (5, N'Pai Rico Indepedência Finaceira', N'Administração & Negócios', N'Campus ', N'1998', N'Robert Kiyosaki')
INSERT [dbo].[Livros] ([ID], [NOME], [DESCRICAO], [EDITORA], [ANO], [AUTOR]) VALUES (6, N'Escola de Negócios', N'Administração & Negócios', N'Campus ', N'2010', N'Robert Kiyosaki')
INSERT [dbo].[Livros] ([ID], [NOME], [DESCRICAO], [EDITORA], [ANO], [AUTOR]) VALUES (7, N'O Segredo', N'Auto-Conhecimento', N'Sextante', N'2006', N'Rhonda Byrne')
INSERT [dbo].[Livros] ([ID], [NOME], [DESCRICAO], [EDITORA], [ANO], [AUTOR]) VALUES (8, N'A Magia', N'Auto-Conhecimento', N'Sextante', N'2014', N'Rhonda Byrne')
INSERT [dbo].[Livros] ([ID], [NOME], [DESCRICAO], [EDITORA], [ANO], [AUTOR]) VALUES (9, N'O Poder do Subconsciente', N'Auto-Conhecimento', N'Vivo Livros', N'1962', N'Joseph Murphy')
INSERT [dbo].[Livros] ([ID], [NOME], [DESCRICAO], [EDITORA], [ANO], [AUTOR]) VALUES (10, N'O Negócio do Século XXI', N'Administração & Negócios', N'Campus', N'2017', N'Robert Kiyosaki')
INSERT [dbo].[Livros] ([ID], [NOME], [DESCRICAO], [EDITORA], [ANO], [AUTOR]) VALUES (11, N'O Homem mais Rico da Babilônia', N'Administração & Negócios', N'Penguin Books', N'2002', N'George Samuel Clason')
INSERT [dbo].[Livros] ([ID], [NOME], [DESCRICAO], [EDITORA], [ANO], [AUTOR]) VALUES (12, N'A Jornada', N'Religioso', N'Thomas Nelson', N'2007', N'Billy Graham')
INSERT [dbo].[Livros] ([ID], [NOME], [DESCRICAO], [EDITORA], [ANO], [AUTOR]) VALUES (13, N'Telepsiquismo', N'Auto-Conhecimento', N'Vivo Livros', N'1973', N'Joseph Murphy')
INSERT [dbo].[Livros] ([ID], [NOME], [DESCRICAO], [EDITORA], [ANO], [AUTOR]) VALUES (14, N'Nada é por Acaso', N'Religioso', N'Vida Consciência', N'2006', N'Zibia Gasparetto')
SET IDENTITY_INSERT [dbo].[Livros] OFF
