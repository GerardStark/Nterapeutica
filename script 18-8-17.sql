USE [Licitaciones]
GO
/****** Object:  User [user]    Script Date: 18/08/2017 10:54:44 a. m. ******/
CREATE USER [user] FOR LOGIN [user] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [user]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [user]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [user]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [user]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [user]
GO
ALTER ROLE [db_datareader] ADD MEMBER [user]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [user]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [user]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [user]
GO
/****** Object:  Table [dbo].[aux_cat_trad_ref]    Script Date: 18/08/2017 10:54:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aux_cat_trad_ref](
	[id_trad_ref] [int] IDENTITY(1,1) NOT NULL,
	[id_traduccion] [int] NULL,
	[id_referencia] [int] NULL,
	[creado_en] [date] NULL,
	[actualizado_en] [date] NULL,
 CONSTRAINT [PK_aux_cat_trad_ref] PRIMARY KEY CLUSTERED 
(
	[id_trad_ref] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[aux_entidades_federativas]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aux_entidades_federativas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_estado] [varchar](max) NULL,
	[abreviatura] [varchar](50) NULL,
	[creado_en] [date] NULL,
	[actualizado_en] [date] NULL,
 CONSTRAINT [PK_aux_entidades_federativas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[aux_tipos_expediente]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aux_tipos_expediente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo_expediente] [varchar](max) NULL,
	[articulos] [varchar](max) NULL,
	[creado_en] [date] NULL,
	[actualizado_en] [date] NULL,
 CONSTRAINT [PK_aux_tipos_expediente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[aux_users]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aux_users](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [int] NULL,
	[nombre_usuario] [varchar](50) NULL,
	[contraseña_hash] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_aux_users] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[catalogos_claves_referencias]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[catalogos_claves_referencias](
	[id_clave_catalogo] [int] IDENTITY(1,1) NOT NULL,
	[id_catalogo_productos] [int] NULL,
	[clave_ref_cod] [varchar](max) NULL,
	[descripcion] [varchar](max) NULL,
	[unidad_venta] [varchar](max) NULL,
	[pagina_pdf] [varchar](max) NULL,
	[pagina_cat] [varchar](max) NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_catalogos_claves_referencias] PRIMARY KEY CLUSTERED 
(
	[id_clave_catalogo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[catalogos_info_general]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[catalogos_info_general](
	[id_catalogo] [int] IDENTITY(1,1) NOT NULL,
	[tipo_catalogo] [varchar](max) NULL,
	[nombre_catalogo] [varchar](max) NULL,
	[publicacion] [int] NULL,
	[spec_catalogo] [varchar](max) NULL,
	[fabricante] [varchar](max) NULL,
	[marca] [varchar](max) NULL,
	[idioma] [varchar](max) NULL,
	[dir_archivo] [varchar](max) NULL,
	[creado_en] [date] NULL,
	[actualizado_en] [date] NULL,
 CONSTRAINT [PK_catalogos_info_general] PRIMARY KEY CLUSTERED 
(
	[id_catalogo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[catalogos_traducciones]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[catalogos_traducciones](
	[id_traduccion_cat] [int] IDENTITY(1,1) NOT NULL,
	[id_catalogo_productos] [int] NULL,
	[descripcion_corta] [varchar](max) NULL,
	[claves_referencias] [xml] NULL,
	[dir_archivo] [varchar](max) NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[id_traduccion_cat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[certificados_calidad]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[certificados_calidad](
	[id_certificado] [int] IDENTITY(1,1) NOT NULL,
	[numero_identificador] [varchar](max) NULL,
	[tipo] [varchar](max) NULL,
	[descripcion_detallada] [varchar](max) NULL,
	[fabricante] [varchar](max) NULL,
	[fecha_emision] [datetime] NULL,
	[fecha_vencimiento] [datetime] NULL,
	[idioma] [varchar](max) NULL,
	[dir_archivo] [varchar](max) NULL,
	[dir_archivo_traduccion] [varchar](max) NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_certificados_calidad] PRIMARY KEY CLUSTERED 
(
	[id_certificado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cucop]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cucop](
	[id_cucop] [int] IDENTITY(1,1) NOT NULL,
	[clave] [varchar](12) NULL,
	[descripcion] [varchar](max) NULL,
	[especialidad] [varchar](max) NULL,
	[presentacion_tipo] [varchar](max) NULL,
	[presentacion_cant] [int] NULL,
	[presentacion_cont] [varchar](max) NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_cucop] PRIMARY KEY CLUSTERED 
(
	[id_cucop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cucop_vinculos]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cucop_vinculos](
	[id_vinculacion] [int] IDENTITY(1,1) NOT NULL,
	[opcion] [int] NULL,
	[id_cucop_item] [int] NULL,
	[nombre] [varchar](max) NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_cucop_vinculos] PRIMARY KEY CLUSTERED 
(
	[id_vinculacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cucop_vinculos_catalogos]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cucop_vinculos_catalogos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cucop_vinculo] [int] NULL,
	[id_catalogo] [int] NULL,
	[creado_en] [date] NULL,
	[actualizado_en] [date] NULL,
 CONSTRAINT [PK_cucop_vinculos_catalogos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cucop_vinculos_catalogos_referencias]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cucop_vinculos_catalogos_referencias](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_vinculo_catalogo] [int] NULL,
	[id_referencia] [int] NULL,
	[creado_en] [date] NULL,
	[actualizado_en] [date] NULL,
 CONSTRAINT [PK_cucop_vinculos_catalogos_referencias] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cucop_vinculos_certificados]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cucop_vinculos_certificados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cucop_vinculo] [int] NULL,
	[id_certificados] [int] NULL,
	[creado_en] [date] NULL,
	[actualizado_en] [date] NULL,
 CONSTRAINT [PK_cucop_vinculos_certificados] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cucop_vinculos_registros]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cucop_vinculos_registros](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cucop_vinculo] [int] NULL,
	[id_registro] [int] NULL,
	[creado_en] [date] NULL,
	[actualizado_en] [date] NULL,
 CONSTRAINT [PK_cucop_vinculos_registros] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cucop_vinculos_registros_referencias]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cucop_vinculos_registros_referencias](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_vinculo_registro] [int] NULL,
	[id_referencia] [int] NULL,
	[creado_en] [date] NULL,
	[actualizado_en] [date] NULL,
 CONSTRAINT [PK_cucop_vinculos_registros_referencias] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[data_unidades]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[data_unidades](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[unidad] [varchar](max) NULL,
 CONSTRAINT [PK_data_unidades] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fabricantes_contactos]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fabricantes_contactos](
	[id_contacto] [int] IDENTITY(1,1) NOT NULL,
	[id_ftd] [int] NULL,
	[nombre] [varchar](max) NULL,
	[correo_electronico] [varchar](max) NULL,
	[correo_electronico_dos] [varchar](max) NULL,
	[telefono] [bigint] NULL,
	[telefono_dos] [bigint] NULL,
	[comentarios] [varchar](max) NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_fabricantes_contactos] PRIMARY KEY CLUSTERED 
(
	[id_contacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fabricantes_titulares_distribuidores]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fabricantes_titulares_distribuidores](
	[id_ftd] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](max) NULL,
	[tipo_apoyo] [varchar](max) NULL,
	[distribuidor_mayorista] [varchar](max) NULL,
	[RFC] [varchar](max) NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_fabricantes_titulares_distribuidores] PRIMARY KEY CLUSTERED 
(
	[id_ftd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[licitacion_bases]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[licitacion_bases](
	[id_bases] [int] IDENTITY(1,1) NOT NULL,
	[numero_licitacion] [varchar](max) NULL,
	[unidad_compradora] [varchar](max) NULL,
	[entidad_federativa] [int] NULL,
	[especialidad] [varchar](max) NULL,
	[duracion_contrato] [varchar](max) NULL,
	[tipo_contratacion] [varchar](max) NULL,
	[dir_archivo] [varchar](max) NULL,
	[estado] [tinyint] NULL,
	[expediente] [bigint] NULL,
	[tipo_licitacion] [varchar](max) NULL,
	[tipo_expediente] [int] NULL,
	[operador_nombre] [varchar](max) NULL,
	[operador_correo] [varchar](max) NULL,
	[descripcion] [varchar](max) NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_licitacion_bases] PRIMARY KEY CLUSTERED 
(
	[id_bases] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[licitacion_calendario]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[licitacion_calendario](
	[id_calendario] [int] IDENTITY(1,1) NOT NULL,
	[id_bases] [int] NULL,
	[fecha_publicacion] [datetime] NULL,
	[fecha_junta_aclaraciones] [datetime] NULL,
	[fecha_apertura] [datetime] NULL,
	[fecha_fallo] [datetime] NULL,
	[fecha_firma] [datetime] NULL,
	[fecha_visita] [datetime] NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_licitacion_calendario] PRIMARY KEY CLUSTERED 
(
	[id_calendario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[licitacion_items]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[licitacion_items](
	[id_item] [int] IDENTITY(1,1) NOT NULL,
	[id_paquete] [int] NULL,
	[descripcion] [varchar](max) NULL,
	[unidad_venta] [varchar](max) NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_licitacion_items] PRIMARY KEY CLUSTERED 
(
	[id_item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[licitacion_items_info_Ad]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[licitacion_items_info_Ad](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_item] [int] NULL,
	[nombre_adicional] [varchar](max) NULL,
	[numero_adicional] [int] NULL,
	[creado_en] [date] NULL,
	[actualizado_En] [date] NULL,
 CONSTRAINT [PK_licitacion_items_info_Ad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[licitacion_partidas]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[licitacion_partidas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_bases] [int] NULL,
	[numero_partida] [int] NULL,
	[nombre_partida] [varchar](max) NULL,
	[especialidad] [varchar](max) NULL,
	[creado_en] [date] NULL,
	[actualizado_en] [date] NULL,
 CONSTRAINT [PK_licitacion_partidas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[licitacion_preguntas]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[licitacion_preguntas](
	[id_pregunta_ja] [int] IDENTITY(1,1) NOT NULL,
	[id_vinc] [int] NULL,
	[texto_pregunta] [varchar](max) NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_licitacion_preguntas] PRIMARY KEY CLUSTERED 
(
	[id_pregunta_ja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[licitacion_subpar_proce]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[licitacion_subpar_proce](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_partida] [int] NULL,
	[numero_subpartida] [int] NULL,
	[nombre_subpartida] [varchar](max) NULL,
	[creado_en] [date] NULL,
	[actualizado_en] [date] NULL,
 CONSTRAINT [PK_licitacion_subpar_proce] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[licitacion_vinculacion]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[licitacion_vinculacion](
	[id_vinculacion] [int] IDENTITY(1,1) NOT NULL,
	[id_item] [int] NULL,
	[id_cucop] [int] NULL,
	[id_ftd] [int] NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_licitacion_vinculacion] PRIMARY KEY CLUSTERED 
(
	[id_vinculacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paises_origen]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paises_origen](
	[id_pais] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](max) NULL,
	[tratado de comercio] [varchar](max) NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_paises_origen] PRIMARY KEY CLUSTERED 
(
	[id_pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[registros_claves_referencias]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[registros_claves_referencias](
	[id_clave_registro] [int] IDENTITY(1,1) NOT NULL,
	[id_registro_sanitario] [int] NOT NULL,
	[clave_ref_cod] [varchar](max) NULL,
	[descripcion] [varchar](max) NULL,
	[unidad_venta] [varchar](max) NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_registros_claves_referencias] PRIMARY KEY CLUSTERED 
(
	[id_clave_registro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[registros_sanitarios]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[registros_sanitarios](
	[id_registro] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](max) NULL,
	[numero_registro] [varchar](max) NULL,
	[numero_solicitud] [varchar](max) NULL,
	[titular] [varchar](max) NULL,
	[rfc] [varchar](max) NULL,
	[denom_distintiva] [varchar](max) NULL,
	[denom_generica] [varchar](max) NULL,
	[fabricante] [varchar](max) NULL,
	[marca] [varchar](max) NULL,
	[pais_origen] [int] NULL,
	[fecha_emision] [datetime] NULL,
	[fecha_vencimiento] [datetime] NULL,
	[dir_archivo] [varchar](max) NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_registros_sanitarios] PRIMARY KEY CLUSTERED 
(
	[id_registro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[registros_tramites_prorroga]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[registros_tramites_prorroga](
	[id_tramite_prorroga] [int] IDENTITY(1,1) NOT NULL,
	[id_registro_sanitario] [int] NULL,
	[numero_tramite] [varchar](max) NULL,
	[fecha_emision] [datetime] NULL,
	[dir_archivo] [varchar](max) NULL,
	[creado_en] [datetime] NULL,
	[actualizado_en] [datetime] NULL,
 CONSTRAINT [PK_registros_tramites_prorroga] PRIMARY KEY CLUSTERED 
(
	[id_tramite_prorroga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[aux_cat_trad_ref] ON 

INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (8, 3, 5, CAST(N'2017-07-18' AS Date), CAST(N'2017-07-18' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (9, 3, 6, CAST(N'2017-07-18' AS Date), CAST(N'2017-07-18' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (10, 3, 7, CAST(N'2017-07-18' AS Date), CAST(N'2017-07-18' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (11, 3, 8, CAST(N'2017-07-18' AS Date), CAST(N'2017-07-18' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (12, 3, 9, CAST(N'2017-07-18' AS Date), CAST(N'2017-07-18' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (13, 3, 10, CAST(N'2017-07-18' AS Date), CAST(N'2017-07-18' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (14, 3, 11, CAST(N'2017-07-18' AS Date), CAST(N'2017-07-18' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (17, 2, 4, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (18, 2, 39, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (19, 2, 40, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (20, 2, 41, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (21, 2, 42, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (22, 2, 43, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (23, 2, 44, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (24, 2, 45, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (25, 2, 46, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (26, 2, 47, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (27, 2, 48, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (28, 2, 49, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (29, 2, 50, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (30, 2, 51, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (31, 2, 52, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (32, 2, 53, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (33, 2, 54, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (34, 2, 55, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (35, 2, 56, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (36, 2, 57, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (37, 2, 58, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (38, 2, 59, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (39, 2, 60, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (40, 2, 61, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (41, 2, 62, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (42, 2, 63, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (43, 2, 64, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (44, 2, 65, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (45, 2, 66, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (46, 2, 67, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (47, 2, 68, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (48, 2, 69, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (49, 2, 70, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (50, 2, 71, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (51, 2, 72, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (52, 2, 73, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (53, 2, 74, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (54, 2, 75, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (55, 2, 76, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (56, 2, 77, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (57, 2, 78, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (58, 2, 79, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (59, 2, 80, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (60, 2, 81, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (61, 2, 82, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (62, 2, 83, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (63, 2, 84, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (64, 2, 85, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (65, 2, 86, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (66, 2, 87, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (67, 2, 88, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (68, 2, 89, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (69, 2, 90, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (70, 2, 91, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (71, 2, 92, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (72, 2, 93, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (73, 2, 94, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (74, 2, 95, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (75, 2, 96, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (76, 2, 97, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (77, 2, 98, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (78, 2, 99, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (79, 2, 100, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (80, 2, 101, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (81, 2, 102, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (82, 2, 103, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (83, 2, 104, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (84, 2, 105, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (85, 2, 106, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (86, 2, 107, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (87, 2, 108, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (88, 2, 109, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (89, 2, 110, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (90, 2, 111, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (91, 2, 112, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (92, 2, 113, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (93, 2, 114, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (94, 2, 115, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (95, 2, 116, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (96, 2, 117, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (97, 2, 118, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (98, 2, 119, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (99, 2, 120, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (100, 2, 121, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (101, 2, 122, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (102, 2, 123, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (103, 2, 124, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (104, 2, 125, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (105, 2, 126, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (106, 2, 127, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (107, 2, 128, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (108, 2, 129, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
GO
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (109, 2, 130, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (110, 2, 131, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (111, 2, 132, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (112, 2, 133, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (113, 2, 134, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (114, 2, 135, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (115, 2, 136, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (116, 2, 137, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (117, 2, 138, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (118, 2, 139, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (119, 2, 140, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (120, 2, 141, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (121, 2, 142, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (122, 2, 143, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (123, 2, 144, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (124, 2, 145, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (125, 2, 146, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (126, 2, 147, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (127, 2, 148, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (128, 2, 149, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (129, 2, 150, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (130, 2, 151, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (131, 2, 152, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (132, 2, 153, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
INSERT [dbo].[aux_cat_trad_ref] ([id_trad_ref], [id_traduccion], [id_referencia], [creado_en], [actualizado_en]) VALUES (133, 2, 154, CAST(N'2017-07-28' AS Date), CAST(N'2017-07-28' AS Date))
SET IDENTITY_INSERT [dbo].[aux_cat_trad_ref] OFF
SET IDENTITY_INSERT [dbo].[aux_entidades_federativas] ON 

INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (1, N'Aguascalientes', N'AGU', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (2, N'Baja California', N'BCN', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (3, N'Baja California Sur', N'BCS', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (4, N'Campeche', N'CAM', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (5, N'Chiapas', N'CHP', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (6, N'Chihuahua', N'CHH', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (7, N'Coahuila', N'COA', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (8, N'Colima', N'COL', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (9, N'Distrito Federal', N'DIF', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (10, N'Durango', N'DUR', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (11, N'Guanajuato', N'GUA', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (12, N'Guerrero', N'GRO', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (13, N'Hidalgo', N'HID', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (14, N'Jalisco', N'JAL', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (15, N'México', N'MEX', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (16, N'Michoacán', N'MIC', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (17, N'Morelos', N'MOR', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (18, N'Nayarit', N'NAY', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (19, N'Nuevo León', N'NLE', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (20, N'Oaxaca', N'OAX', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (21, N'Puebla', N'PUE', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (22, N'Querétaro', N'QUE', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (23, N'Quintana Roo', N'ROO', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (24, N'San Luis Potosí', N'SLP', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (25, N'Sinaloa', N'SIN', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (26, N'Sonora', N'SON', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (27, N'Tabasco', N'TAB', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (28, N'Tamaulipas', N'TAM', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (29, N'Tlaxcala', N'TLA', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (30, N'Veracruz', N'VER', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (31, N'Yucatán', N'YUC', CAST(N'2017-08-03' AS Date), NULL)
INSERT [dbo].[aux_entidades_federativas] ([id], [nombre_estado], [abreviatura], [creado_en], [actualizado_en]) VALUES (32, N'Zacatecas', N'ZAC', CAST(N'2017-08-03' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[aux_entidades_federativas] OFF
SET IDENTITY_INSERT [dbo].[aux_tipos_expediente] ON 

INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (1, N'Licitación Pública Nacional LAASSP', N'Art 28 fracc. I LAASSP', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (2, N'Licitación Pública Internacional bajo TLC LAASSP', N'Art 28 fracc. II LAASSP', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (3, N'Licitación Pública Internacional Abierta LAASSP', N'Art 28 fracc. III LAASSP', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (4, N'Invitación a cuando menos tres Nacional LAASSP', N'Art 41 fracc. I, II, III, IV, V, VI,
VII, VIII, IX, X, XI, XII, XIII, XIV,
XV, XVI, XVII, XVIII, XIX, XX
Art. 42 s/f LAASSP', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (5, N'Invitación a cuando menos tres Internacional bajo TLC LAASSP', N'Art 41 fracc. I, II, III, IV, V, VI,
VII, VIII, IX, X, XI, XII, XIII, XIV,
XV, XVI, XVII, XVIII, XIX, XX
Art. 42 s/f LAASSP', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (6, N'Invitación a cuando menos tres Internacional Abierta LAASSP', N'Art 41 fracc. I, II, III, IV, V, VI,
VII, VIII, IX, X, XI, XII, XIII, XIV,
XV, XVI, XVII, XVIII, XIX, XX
Art. 42 s/f LAASSP', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (7, N'Adjudicación Directa Nacional Art. 42 LAASSP', N'Art 42 LAASSP', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (8, N'Adjudicación Directa Internacional Abierta Art. 42 LAASSP', N'Art 42 LAASSP', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (9, N'Licitación Pública Nacional, para OSD LAASSP', N'Art. 28 fracc. I penúltimo
párrafo LAASSP', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (10, N'Licitación Pública Internacional Bajo TLC, para OSD LAASSP', N'Art 28 fracc. II LAASSP y
mismo Art. penúltimo
párrafo', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (11, N'Licitación Pública Internacional Abierta, para OSD LAASSP', N'Art 28 fracc. III LAASSP y
mismo Art. penúltimo
párrafo', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (12, N'Adjudicación Directa Nacional simplificada LAASSP', N'Art 41 fracc. I, II, III, IV, V, VI,
VII, VIII, IX, X, XI, XII, XIII, XIV,
XV, XVI, XVII, XVIII, XIX, XX,
Art. 42 s/f LASSP', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (13, N'Adjudicación Directa Internacional bajo TLC simplificada
LAASSP', N'Art 41 fracc. I, II, III, IV, V, VI,
VII, VIII, IX, X, XI, XII, XIII, XIV,
XV, XVI, XVII, XVIII, XIX, XX
Art. 42 s/f LASSP', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (14, N'Adjudicación Directa Internacional Abierta simplificada
LAASSP', N'Art 41 fracc. I, II, III, IV, V, VI,
VII, VIII, IX, X, XI, XII, XIII, XIV,
XV, XVI, XVII, XVIII, XIX, XX
Art. 42 s/f LAASSP', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (15, N'Proyecto de Convocatoria a Licitación Pública LAASSP', N'Art. 29 penúltimo párrafo
LAASSP', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (16, N'Licitación Pública Nacional LOPSRM', N'Art. 30 LOPSRM fracc. I', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (17, N'Licitación Pública Internacional bajo TLC LOPSRM', N'Art. 30 LOPSRM fracc. II', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (18, N'Licitación Pública Internacional Abierta LOPSRM', N'Art. 30 LOPSRM fracc. III', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (19, N'Invitación a cuando menos tres Nacional LOPSRM', N'Art. 42 fracc. I, II, III, IV, V,
VI, VII, VIII, IX, X, XI, XII, XIII,
XIV
Art 43 s/f LOPSRM', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (20, N'Invitación a cuando menos tres Internacional bajo TLC
LOPSRM', N'Art. 42 fracc. I, II, III, IV, V,
VI, VII, VIII, IX, X, XI, XII, XIII,
XIV
Art 43 s/f LOPSRM', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (21, N'Invitación a cuando menos tres Internacional Abierta LOPSRM', N'Art. 42 fracc. I, II, III, IV, V,
VI, VII, VIII, IX, X, XI, XII, XIII,
XIV
Art 43 s/f LOPSRM', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (22, N'Adjudicación Directa Nacional Art. 43 LOPSRM', N'Art. 43 LOPSRM', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (23, N'Adjudicación Directa Internacional Abierta Art. 43 LOPSRM', N'Art. 43 LOPSRM', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (24, N'Adjudicación Directa Nacional Simplificada LOPSRM', N'Art. 42 fracc. I, II, III, IV, V,
VI, VII, VIII, IX, X, XI, XII, XIII,
XIV
Art 43 s/f LOPSRM', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (25, N'Adjudicación Directa Internacional Bajo TLC Simplificada
LOPSRM', N'Art. 42 fracc. I, II, III, IV, V,
VI, VII, VIII, IX, X, XI, XII, XIII,
XIV
Art 43 s/f LOPSRM', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (26, N'Adjudicación Directa Internacional Abierta Simplificada
LOPSRM', N'Art. 42 fracc. I, II, III, IV, V,
VI, VII, VIII, IX, X, XI, XII, XIII,
XIV
Art 43 s/f LOPSRM', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (27, N'Proyecto de convocatoria a la Licitación Pública LOPSRM', N'Art. 31 antepenúltimo
párrafo LOPSRM', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (28, N'Licitación Pública Nacional de Adquisiciones (Legislación
Estatal)', N'El que aplique de acuerdo
a la Legislación Estatal', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (29, N'Licitación Pública Internacional de Adquisiciones (Legislación
Estatal)', N'El que aplique de acuerdo
a la Legislación Estatal', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (30, N'Licitación Pública Nacional de Obra Pública (Legislación
Estatal)', N'El que aplique de acuerdo
a la Legislación Estatal', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (31, N'Licitación Pública Internacional de Obra Pública (Legislación
Estatal)', N'El que aplique de acuerdo
a la Legislación Estatal', CAST(N'2017-08-04' AS Date), NULL)
INSERT [dbo].[aux_tipos_expediente] ([id], [tipo_expediente], [articulos], [creado_en], [actualizado_en]) VALUES (32, N'Reporte de otras contrataciones', N'Art. 17 LAASSP UC que
participaron en
contrataciones
consolidadas y no fueron
designadas para
coordinar el procedimiento
de contratación, Orgánismos autónomos no
abligados a LAASSP y
LOPSRM, Estados y Municipios
Legislación Estatal
Adjudicación Directa o
equiv alente Inv itación a
cuando menos tres', CAST(N'2017-08-04' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[aux_tipos_expediente] OFF
SET IDENTITY_INSERT [dbo].[catalogos_claves_referencias] ON 

INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (4, 2, N'701-10225', N'Diametro de balon: 2.25
shaft p/d french: 1.9f/2.7f
rbp,atm: 20.', N'Pieza', N'12', N'B-2', CAST(N'2017-07-18T11:15:15.997' AS DateTime), CAST(N'2017-07-28T16:23:47.607' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (5, 3, N'6207-D1', N'-INTRODUCTOR PARA ELECTRODO DE MARCAPASO DEFINITIVO DE DOS CAMARAS (2 VAINAS Y 2 ALAMBRES GUIA POR KIT)
-7 FR', N'KIT', NULL, NULL, CAST(N'2017-07-18T11:32:25.523' AS DateTime), CAST(N'2017-07-18T11:32:21.157' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (6, 3, N'6208-D1', N'-INTRODUCTOR PARA ELECTRODO DE MARCAPASO DEFINITIVO DE DOS CAMARAS (2 VAINAS Y 2 ALAMBRES GUIA POR KIT)
-8 FR', N'KIT', NULL, NULL, CAST(N'2017-07-18T11:33:26.447' AS DateTime), CAST(N'2017-07-18T11:33:22.090' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (7, 3, N'6209-D1', N'-INTRODUCTOR PARA ELECTRODO DE MARCAPASO DEFINITIVO DE DOS CAMARAS (2 VAINAS Y 2 ALAMBRES GUIA POR KIT)
-9 FR', N'KIT', NULL, NULL, CAST(N'2017-07-18T11:33:37.190' AS DateTime), CAST(N'2017-07-18T11:33:32.837' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (8, 3, N'6210-D1', N'-INTRODUCTOR PARA ELECTRODO DE MARCAPASO DEFINITIVO DE DOS CAMARAS (2 VAINAS Y 2 ALAMBRES GUIA POR KIT)
-10.5 FR', N'KIT', NULL, NULL, CAST(N'2017-07-18T11:33:53.743' AS DateTime), CAST(N'2017-07-18T11:33:49.387' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (9, 3, N'6211-D1', N'-INTRODUCTOR PARA ELECTRODO DE MARCAPASO DEFINITIVO DE DOS CAMARAS (2 VAINAS Y 2 ALAMBRES GUIA POR KIT)
-11 FR', N'KIT', NULL, NULL, CAST(N'2017-07-18T11:34:06.660' AS DateTime), CAST(N'2017-07-18T11:34:02.280' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (10, 3, N'5076', N'-CAPSUREFIX NOVUS 
-ELECTRODO PARA MARCAPASO DEFINITIVO BIPOLAR ENDOCARDICO DE 3.2 MM DE DIAMETRO', N'PZA', NULL, NULL, CAST(N'2017-07-18T11:38:05.210' AS DateTime), CAST(N'2017-07-18T11:38:41.010' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (11, 3, N'5092', N'-CAPSURE SP NOVUS 
-ELECTRODOS CUBIERTOS CON SILICON O POLIURETANO CON CONDUCTORES DE DIFERENTES METALES; FIJACION ACTIVA CON TORNILLOS PARA LA AURICULA Y PASIVA PARA EL VENTRICULO; DIAMETRO DE 3.2 MM; LONGITUD: 50 A 60 CM;', N'PZA', NULL, NULL, CAST(N'2017-07-18T11:42:16.410' AS DateTime), CAST(N'2017-07-18T11:42:11.990' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (12, 7, N'EN1DR01', N'MARCAPASO CARDIACO BICAMERAL CON ACTIVIDAD DE FRECUENCIA. MARCAPASO CARDIACO; TIPO BICAMERAL CON ACTIVIDAD DE FRECUENCIA; ESPECIFICACIONES: MULTIPROGRAMACION DE FUNCIONES CON UN MINIMO DE 10 FUNCIONES; POLARIDAD: DE SENSADO BIPOLAR, DE ESTIMULACION BIPOLAR; MODO DE ESTIMULACION: DDDR; ADAPTACION DE FRECUENCIA: BAJO. MEDIO, ALTO O MAS ( MEDIO BAJO O MEDIO ALTO); AMPLITUD DE VOLTAJE: PROGRAMABLE EN FORMA INDEPENDIENTE, POR CAMARA; DIMENSIONES: PESO MENOR DE 40 GRS Y MENOS DE 9 MM DE GROSOR; LONGEVIDAD: 7 AÑOS EN ADELANTE A PARAMETROS NOMINALES; CUBIERTA: CAJA DE TITANIO; FUENTE DE ENERGIA: YODURO DE LITIO', N'PZA', NULL, NULL, CAST(N'2017-07-18T12:16:46.190' AS DateTime), CAST(N'2017-07-18T12:16:41.827' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (13, 8, N'7089', N'-INTRODUCTOR PELABLE 
-7 FR (2,33 MM)
-VAINA 14,2 CM LONG
-DILATADOR 17,7 CM LONG
KIT INCLUYE:
1 DILATADOR
1 FUNDA INTRODUCTORA
1 CABLE GUIA CON PUNTA "J"
1 AGUJA INTRODUCTORA (CALIBRE 18 G)
1 JERINGA DESECHABLE', N'KIT', NULL, NULL, CAST(N'2017-07-18T12:31:00.840' AS DateTime), CAST(N'2017-07-18T12:42:19.777' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (14, 8, N'7090', N'-INTRODUCTOR PELABLE 
-7,5 FR (2,50 MM)
-VAINA 14,2 CM LONG
-DILATADOR 17,7 CM LONG
KIT INCLUYE:
1 DILATADOR
1 FUNDA INTRODUCTORA
1 CABLE GUIA CON PUNTA "J"
1 AGUJA INTRODUCTORA (CALIBRE 18 G)
1 JERINGA DESECHABLE', N'KIT', NULL, NULL, CAST(N'2017-07-18T12:31:23.730' AS DateTime), CAST(N'2017-07-18T12:42:40.913' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (15, 8, N'7091', N'-INTRODUCTOR PELABLE 
-8 FR (2,67 MM)
-VAINA 14,2 CM LONG
-DILATADOR 17,7 CM LONG
KIT INCLUYE:
1 DILATADOR
1 FUNDA INTRODUCTORA
1 CABLE GUIA CON PUNTA "J"
1 AGUJA INTRODUCTORA (CALIBRE 18 G)
1 JERINGA DESECHABLE', N'KIT', NULL, NULL, CAST(N'2017-07-18T12:31:45.173' AS DateTime), CAST(N'2017-07-18T12:43:07.690' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (16, 8, N'7093', N'-INTRODUCTOR PELABLE 
-9 FR (3,00 MM)
-VAINA 14,2 CM LONG
-DILATADOR 17,7 CM LONG
KIT INCLUYE:
1 DILATADOR
1 FUNDA INTRODUCTORA
1 CABLE GUIA CON PUNTA "J"
1 AGUJA INTRODUCTORA (CALIBRE 18 G)
1 JERINGA DESECHABLE', N'KIT', NULL, NULL, CAST(N'2017-07-18T12:32:10.583' AS DateTime), CAST(N'2017-07-18T12:43:17.320' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (17, 8, N'7095', N'-INTRODUCTOR PELABLE 
-10 FR (3,33 MM)
-VAINA 14,2 CM LONG
-DILATADOR 17,7 CM LONG
KIT INCLUYE:
1 DILATADOR
1 FUNDA INTRODUCTORA
1 CABLE GUIA CON PUNTA "J"
1 AGUJA INTRODUCTORA (CALIBRE 18 G)
1 JERINGA DESECHABLE', N'KIT', NULL, NULL, CAST(N'2017-07-18T12:32:38.010' AS DateTime), CAST(N'2017-07-18T12:43:32.983' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (18, 8, N'7096', N'-INTRODUCTOR PELABLE 
-10,5 FR (3,50 MM)
-VAINA 14,2 CM LONG
-DILATADOR 17,7 CM LONG
KIT INCLUYE:
1 DILATADOR
1 FUNDA INTRODUCTORA
1 CABLE GUIA CON PUNTA "J"
1 AGUJA INTRODUCTORA (CALIBRE 18 G)
1 JERINGA DESECHABLE', N'KIT', NULL, NULL, CAST(N'2017-07-18T12:33:04.547' AS DateTime), CAST(N'2017-07-18T12:43:45.843' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (19, 8, N'7097', N'-INTRODUCTOR PELABLE 
-11 FR (3,67 MM)
-VAINA 14,2 CM LONG
-DILATADOR 17,7 CM LONG
KIT INCLUYE:
1 DILATADOR
1 FUNDA INTRODUCTORA
1 CABLE GUIA CON PUNTA "J"
1 AGUJA INTRODUCTORA (CALIBRE 18 G)
1 JERINGA DESECHABLE', N'KIT', NULL, NULL, CAST(N'2017-07-18T12:33:23.507' AS DateTime), CAST(N'2017-07-18T12:43:56.087' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (20, 8, N'7099', N'-INTRODUCTOR PELABLE 
-12 FR (4,00 MM)
-VAINA 14,2 CM LONG
-DILATADOR 17,7 CM LONG
KIT INCLUYE:
1 DILATADOR
1 FUNDA INTRODUCTORA
1 CABLE GUIA CON PUNTA "J"
1 AGUJA INTRODUCTORA (CALIBRE 18 G)
1 JERINGA DESECHABLE', N'KIT', NULL, NULL, CAST(N'2017-07-18T12:33:45.157' AS DateTime), CAST(N'2017-07-18T12:44:04.793' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (21, 8, N'7127', N'-INTRODUCTOR PELABLE 
-9 FR (3,00 MM)
-VAINA 24,8 CM LONG
-DILATADOR 28,3 CM LONG
KIT INCLUYE:
1 DILATADOR
1 FUNDA INTRODUCTORA
1 CABLE GUIA CON PUNTA "J"
1 AGUJA INTRODUCTORA (CALIBRE 18 G)
1 JERINGA DESECHABLE', N'KIT', NULL, NULL, CAST(N'2017-07-18T12:35:17.270' AS DateTime), CAST(N'2017-07-18T12:44:13.627' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (22, 8, N'7129', N'-INTRODUCTOR PELABLE 
-10 FR (3,33 MM)
-VAINA 24,8 CM LONG
-DILATADOR 28,3 CM LONG
KIT INCLUYE:
1 DILATADOR
1 FUNDA INTRODUCTORA
1 CABLE GUIA CON PUNTA "J"
1 AGUJA INTRODUCTORA (CALIBRE 18 G)
1 JERINGA DESECHABLE', N'KIT', NULL, NULL, CAST(N'2017-07-18T12:39:24.163' AS DateTime), CAST(N'2017-07-18T12:44:22.287' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (23, 8, N'7131', N'-INTRODUCTOR PELABLE 
-11 FR (3,67 MM)
-VAINA 24,8 CM LONG
-DILATADOR 28,3 CM LONG
KIT INCLUYE:
1 DILATADOR
1 FUNDA INTRODUCTORA
1 CABLE GUIA CON PUNTA "J"
1 AGUJA INTRODUCTORA (CALIBRE 18 G)
1 JERINGA DESECHABLE', N'KIT', NULL, NULL, CAST(N'2017-07-18T12:39:46.110' AS DateTime), CAST(N'2017-07-18T12:44:29.240' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (24, 8, N'7133', N'-INTRODUCTOR PELABLE 
-12 FR (4,00 MM)
-VAINA 24,8 CM LONG
-DILATADOR 28,3 CM LONG
KIT INCLUYE:
1 DILATADOR
1 FUNDA INTRODUCTORA
1 CABLE GUIA CON PUNTA "J"
1 AGUJA INTRODUCTORA (CALIBRE 18 G)
1 JERINGA DESECHABLE', N'KIT', NULL, NULL, CAST(N'2017-07-18T12:40:09.750' AS DateTime), CAST(N'2017-07-18T12:44:36.243' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (25, 9, N'K185', N'GENERADOR DE IMPULSOS SR 
TAMAÑO: 45.7 X 44.5 X 7.5
PESO (G): 23.5
VOLUMEN: 11.5
VIDA UTIL: 9.7
CONECTOR: IS-1', N'PZA', NULL, NULL, CAST(N'2017-07-18T13:03:40.290' AS DateTime), CAST(N'2017-07-18T13:05:37.667' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (26, 9, N'K186', N'GENERADOR DE IMPULSOS DR 
TAMAÑO: 47 X 44.5 X 7.5
PESO (G): 24.5
VOLUMEN: 12
VIDA UTIL: 7.8
CONECTOR: IS-1', N'PZA', NULL, NULL, CAST(N'2017-07-18T13:04:16.073' AS DateTime), CAST(N'2017-07-18T13:05:56.363' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (27, 10, N'4456', N'ELECTRODOS DE ESTIMULACION PASIVA
LONGITUD: 52 CM
BIPOLAR VENTRICULAR
DIAMETRO: 1,7 MM', N'PZA', NULL, NULL, CAST(N'2017-07-18T13:11:24.413' AS DateTime), CAST(N'2017-07-18T13:25:04.927' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (28, 10, N'4457', N'ELECTRODOS DE ESTIMULACION PASIVA
LONGITUD: 58 CM
BIPOLAR VENTRICULAR
DIAMETRO: 1,7 MM', N'PZA', NULL, NULL, CAST(N'2017-07-18T13:11:39.473' AS DateTime), CAST(N'2017-07-18T13:25:10.590' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (29, 10, N'4458', N'ELECTRODOS DE ESTIMULACION PASIVA
LONGITUD: 52 CM
BIPOLAR VENTRICULAR
DIAMETRO: 2,0 MM', N'PZA', NULL, NULL, CAST(N'2017-07-18T13:15:16.147' AS DateTime), CAST(N'2017-07-18T13:25:16.297' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (30, 10, N'4459', N'ELECTRODOS DE ESTIMULACION PASIVA
LONGITUD: 58 CM
BIPOLAR VENTRICULAR
DIAMETRO: 2,0 MM', N'PZA', NULL, NULL, CAST(N'2017-07-18T13:17:21.250' AS DateTime), CAST(N'2017-07-18T13:25:22.487' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (31, 10, N'4479', N'ELECTRODOS DE ESTIMULACION PASIVA
LONGITUD: 45 CM
BIPOLAR AURICULAR
DIAMETRO: 1,7 MM', N'PZA', NULL, NULL, CAST(N'2017-07-18T13:18:07.853' AS DateTime), CAST(N'2017-07-18T13:25:27.987' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (32, 10, N'4480', N'ELECTRODOS DE ESTIMULACION PASIVA 
LONGITUD: 52 CM
BIPOLAR AURICULAR
DIAMETRO: 1,7 MM', N'PZA', NULL, NULL, CAST(N'2017-07-18T13:19:40.967' AS DateTime), CAST(N'2017-07-18T13:25:34.027' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (33, 10, N'4469', N'ELECTRODOS DE ESTIMULACION ACTIVA
LONGITUD: 45 CM
BIPOLAR AURICULAR/VENTRICULAR
DIAMETRO: 1,7 MM', N'PZA', NULL, NULL, CAST(N'2017-07-18T13:23:06.560' AS DateTime), CAST(N'2017-07-18T13:23:02.177' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (34, 10, N'4470', N'ELECTRODOS DE ESTIMULACION ACTIVA
LONGITUD: 52 CM
BIPOLAR AURICULAR/VENTRICULAR
DIAMETRO: 1,7 MM', N'PZA', NULL, NULL, CAST(N'2017-07-18T13:23:37.020' AS DateTime), CAST(N'2017-07-18T13:23:32.683' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (35, 10, N'4471', N'ELECTRODOS DE ESTIMULACION ACTIVA
LONGITUD: 58 CM
BIPOLAR AURICULAR/VENTRICULAR
DIAMETRO: 1,7 MM', N'PZA', NULL, NULL, CAST(N'2017-07-18T13:23:57.167' AS DateTime), CAST(N'2017-07-18T13:23:52.837' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (36, 10, N'4472', N'ELECTRODOS DE ESTIMULACION ACTIVA
LONGITUD: 45 CM
BIPOLAR AURICULAR/VENTRICULAR
DIAMETRO: 2,0 MM', N'PZA', NULL, NULL, CAST(N'2017-07-18T13:24:25.363' AS DateTime), CAST(N'2017-07-18T13:24:21.027' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (37, 10, N'4473', N'ELECTRODOS DE ESTIMULACION ACTIVA
LONGITUD: 52 CM
BIPOLAR AURICULAR/VENTRICULAR
DIAMETRO: 2,0 MM', N'PZA', NULL, NULL, CAST(N'2017-07-18T13:24:37.790' AS DateTime), CAST(N'2017-07-18T13:24:33.457' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (38, 10, N'4474', N'ELECTRODOS DE ESTIMULACION ACTIVA
LONGITUD: 58 CM
BIPOLAR AURICULAR/VENTRICULAR
DIAMETRO: 2,0 MM', N'PZA', NULL, NULL, CAST(N'2017-07-18T13:24:57.140' AS DateTime), CAST(N'2017-07-18T13:24:52.807' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (39, 2, N'85R12150S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 1.5 DE DIAMETRO X 12 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:02:13.770' AS DateTime), CAST(N'2017-07-21T16:02:12.193' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (40, 2, N'85R15150S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 1.5 DE DIAMETRO X 15 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:02:32.420' AS DateTime), CAST(N'2017-07-21T16:02:30.910' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (41, 2, N'85R15200S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.00 DE DIAMETRO X 15 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:03:43.050' AS DateTime), CAST(N'2017-07-21T16:03:41.537' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (42, 2, N'85R15225S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.25 DE DIAMETRO X 15 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:06:36.700' AS DateTime), CAST(N'2017-07-21T16:06:35.183' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (43, 2, N'85R15275S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.75 DE DIAMETRO X 15 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:13:56.770' AS DateTime), CAST(N'2017-07-21T16:13:55.263' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (44, 2, N'85R15300S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.00 DE DIAMETRO X 15 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:23:28.010' AS DateTime), CAST(N'2017-07-21T16:23:26.500' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (45, 2, N'85R15325S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.25 DE DIAMETRO X 15 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:23:41.870' AS DateTime), CAST(N'2017-07-21T16:23:40.363' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (46, 2, N'85R15350S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.50 DE DIAMETRO X 15 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:24:56.527' AS DateTime), CAST(N'2017-07-21T16:24:55.020' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (47, 2, N'85R15400S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 4.00 DE DIAMETRO X 15 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:25:11.387' AS DateTime), CAST(N'2017-07-21T16:25:09.880' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (48, 2, N'85R12200S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.00 DE DIAMETRO X 12 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:30:11.517' AS DateTime), CAST(N'2017-07-21T16:30:56.627' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (49, 2, N'85R12225S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.25 DE DIAMETRO X 12 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:30:47.110' AS DateTime), CAST(N'2017-07-21T16:30:45.600' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (50, 2, N'85R12250S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.50 DE DIAMETRO X 12 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:35:38.413' AS DateTime), CAST(N'2017-07-21T16:35:36.903' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (51, 2, N'85R12275S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.75 DE DIAMETRO X 12 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:36:20.277' AS DateTime), CAST(N'2017-07-21T16:36:18.767' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (52, 2, N'85R12300S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.00 DE DIAMETRO X 12 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:38:16.713' AS DateTime), CAST(N'2017-07-21T16:38:15.210' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (53, 2, N'85R12325S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.25 DE DIAMETRO X 12 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:39:35.147' AS DateTime), CAST(N'2017-07-21T16:39:33.640' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (54, 2, N'85R12350S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.50 DE DIAMETRO X 12 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:39:48.750' AS DateTime), CAST(N'2017-07-21T16:39:47.247' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (55, 2, N'85R12400S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 4.00 DE DIAMETRO X 12 MM DE LONGITUD. ', N'Pieza', N'20', N'B-10', CAST(N'2017-07-21T16:40:02.540' AS DateTime), CAST(N'2017-07-21T16:40:01.037' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (56, 2, N'85R20150S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 1.50 DE DIAMETRO X 20 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T16:48:09.177' AS DateTime), CAST(N'2017-07-21T16:48:07.670' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (57, 2, N'85R20200S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.00 DE DIAMETRO X 20 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T16:48:26.650' AS DateTime), CAST(N'2017-07-21T16:48:25.150' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (58, 2, N'85R20225S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.25 DE DIAMETRO X 20 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T16:51:30.223' AS DateTime), CAST(N'2017-07-21T16:51:28.720' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (59, 2, N'85R20250S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.50 DE DIAMETRO X 20 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T16:51:51.563' AS DateTime), CAST(N'2017-07-21T16:51:50.063' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (60, 2, N'85R20275S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.75 DE DIAMETRO X 20 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T16:52:31.363' AS DateTime), CAST(N'2017-07-21T16:52:29.860' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (61, 2, N'85R20300S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.00 DE DIAMETRO X 20 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T16:56:26.913' AS DateTime), CAST(N'2017-07-21T16:57:32.950' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (62, 2, N'85R20325S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.25 DE DIAMETRO X 20 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T16:59:16.163' AS DateTime), CAST(N'2017-07-21T16:59:14.660' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (63, 2, N'85R20350S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.50 DE DIAMETRO X 20 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T16:59:33.703' AS DateTime), CAST(N'2017-07-21T16:59:32.207' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (64, 2, N'85R20400S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 4.00 DE DIAMETRO X 20 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T17:00:21.847' AS DateTime), CAST(N'2017-07-21T17:00:20.343' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (65, 2, N'85R30150S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 1.50 DE DIAMETRO X 30 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T17:00:52.550' AS DateTime), CAST(N'2017-07-21T17:00:51.053' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (66, 2, N'85R30200S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.00 DE DIAMETRO X 30 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T17:01:19.153' AS DateTime), CAST(N'2017-07-21T17:01:17.650' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (67, 2, N'85R30225S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.25 DE DIAMETRO X 30 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T17:01:34.373' AS DateTime), CAST(N'2017-07-21T17:01:32.877' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (68, 2, N'85R30250S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.50 DE DIAMETRO X 30 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T17:02:19.023' AS DateTime), CAST(N'2017-07-21T17:02:17.520' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (69, 2, N'85R30275S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.75 DE DIAMETRO X 30 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T17:02:41.800' AS DateTime), CAST(N'2017-07-21T17:02:40.300' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (70, 2, N'85R30300S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.00 DE DIAMETRO X 30 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T17:03:29.540' AS DateTime), CAST(N'2017-07-21T17:03:28.037' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (71, 2, N'85R30325S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.25 DE DIAMETRO X 30 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T17:03:52.757' AS DateTime), CAST(N'2017-07-21T17:03:51.257' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (72, 2, N'85R30350S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.50 DE DIAMETRO X 30 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T17:04:09.830' AS DateTime), CAST(N'2017-07-21T17:04:08.333' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (73, 2, N'85R30400S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 4.00 DE DIAMETRO X 30 MM DE LONGITUD. ', N'Pieza', N'21', N'B-11', CAST(N'2017-07-21T17:04:44.483' AS DateTime), CAST(N'2017-07-21T17:04:42.980' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (74, 2, N'85R06150S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 1.50 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:08:29.723' AS DateTime), CAST(N'2017-07-21T17:08:28.220' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (75, 2, N'85R06200S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.00 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:08:44.290' AS DateTime), CAST(N'2017-07-21T17:08:42.797' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (76, 2, N'85R06225S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.25 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:08:55.643' AS DateTime), CAST(N'2017-07-21T17:08:54.143' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (77, 2, N'85R06250S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.50 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:09:09.367' AS DateTime), CAST(N'2017-07-21T17:09:07.870' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (78, 2, N'85R06275S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.75 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:09:26.097' AS DateTime), CAST(N'2017-07-21T17:09:24.600' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (79, 2, N'85R06300S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.00 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:09:40.433' AS DateTime), CAST(N'2017-07-21T17:09:38.937' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (80, 2, N'85R06325S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.25 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:09:52.687' AS DateTime), CAST(N'2017-07-21T17:09:51.187' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (81, 2, N'85R06350S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.50 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:10:02.390' AS DateTime), CAST(N'2017-07-21T17:10:00.890' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (82, 2, N'85R06400S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 4.00 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:10:16.347' AS DateTime), CAST(N'2017-07-21T17:10:14.850' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (83, 2, N'85R10150S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 1.50 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:10:51.390' AS DateTime), CAST(N'2017-07-21T17:10:49.890' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (84, 2, N'85R10200S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.00 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:11:36.820' AS DateTime), CAST(N'2017-07-21T17:11:35.320' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (85, 2, N'85R10225S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.25 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:11:50.397' AS DateTime), CAST(N'2017-07-21T17:11:48.900' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (86, 2, N'85R10250S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.50 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:12:04.770' AS DateTime), CAST(N'2017-07-21T17:12:03.270' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (87, 2, N'85R10275S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.75 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:12:21.870' AS DateTime), CAST(N'2017-07-21T17:12:20.367' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (88, 2, N'85R10300S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.00 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:12:42.650' AS DateTime), CAST(N'2017-07-21T17:12:41.150' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (89, 2, N'85R10325S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.25 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:12:56.507' AS DateTime), CAST(N'2017-07-21T17:12:55.010' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (90, 2, N'85R10350S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.50 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:13:19.800' AS DateTime), CAST(N'2017-07-21T17:13:18.300' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (91, 2, N'85R10400S', N'BALON SEMICOMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 4.00 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'19', N'B-9', CAST(N'2017-07-21T17:13:32.747' AS DateTime), CAST(N'2017-07-21T17:13:31.250' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (92, 2, N'75R06200N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.00 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:15:11.053' AS DateTime), CAST(N'2017-07-21T17:19:24.513' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (93, 2, N'75R06225N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.25 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:16:43.640' AS DateTime), CAST(N'2017-07-21T17:19:13.547' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (94, 2, N'75R06250N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.50 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:17:31.650' AS DateTime), CAST(N'2017-07-21T17:18:43.000' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (95, 2, N'75R06275N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.75 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:17:48.653' AS DateTime), CAST(N'2017-07-21T17:18:34.283' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (96, 2, N'75R06300N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.00 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:18:25.037' AS DateTime), CAST(N'2017-07-21T17:18:23.537' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (97, 2, N'75R06325N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.25 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:23:28.500' AS DateTime), CAST(N'2017-07-21T17:23:27.000' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (98, 2, N'75R06350N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.50 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:24:09.473' AS DateTime), CAST(N'2017-07-21T17:24:07.973' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (99, 2, N'75R06375N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.75 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:24:27.843' AS DateTime), CAST(N'2017-07-21T17:24:26.350' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (100, 2, N'75R06400N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 4.00 DE DIAMETRO X 6 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:24:59.923' AS DateTime), CAST(N'2017-07-21T17:24:58.430' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (101, 2, N'75R10200N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.00 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:27:06.397' AS DateTime), CAST(N'2017-07-21T17:27:04.893' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (102, 2, N'75R10225N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.25 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:27:25.660' AS DateTime), CAST(N'2017-07-21T17:27:24.167' AS DateTime))
GO
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (103, 2, N'75R10250N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.50 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:28:46.917' AS DateTime), CAST(N'2017-07-21T17:28:45.420' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (104, 2, N'75R10275N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.75 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:29:05.760' AS DateTime), CAST(N'2017-07-21T17:29:04.267' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (105, 2, N'75R10300N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.00 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:29:27.810' AS DateTime), CAST(N'2017-07-21T17:29:26.317' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (106, 2, N'75R10325N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.25 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:29:46.667' AS DateTime), CAST(N'2017-07-21T17:29:45.173' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (107, 2, N'75R10350N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.50 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:30:03.357' AS DateTime), CAST(N'2017-07-21T17:30:01.860' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (108, 2, N'75R10375N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.75 DE DIAMETRO X 10 MM DE LONGITUD. ', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:30:56.233' AS DateTime), CAST(N'2017-07-21T17:31:29.327' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (109, 2, N'75R10400N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 4.00 DE DIAMETRO X 10 MM DE LONGITUD.', N'Pieza', N'23', N'B-13', CAST(N'2017-07-21T17:33:50.100' AS DateTime), CAST(N'2017-07-28T10:55:57.870' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (110, 2, N'75R12200N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.00 DE DIAMETRO X 12 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:49:21.520' AS DateTime), CAST(N'2017-07-28T11:49:20.177' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (111, 2, N'75R12225N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.25 DE DIAMETRO X 12 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:49:33.977' AS DateTime), CAST(N'2017-07-28T11:49:32.633' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (112, 2, N'75R12250N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.50 DE DIAMETRO X 12 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:49:42.577' AS DateTime), CAST(N'2017-07-28T11:49:41.237' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (113, 2, N'75R12275N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.75 DE DIAMETRO X 12 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:49:52.143' AS DateTime), CAST(N'2017-07-28T11:49:50.800' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (114, 2, N'75R12300N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.00 DE DIAMETRO X 12 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:50:05.113' AS DateTime), CAST(N'2017-07-28T11:50:03.773' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (115, 2, N'75R12325N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.25 DE DIAMETRO X 12 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:50:16.890' AS DateTime), CAST(N'2017-07-28T11:50:15.550' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (116, 2, N'75R12350N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.50 DE DIAMETRO X 12 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:50:25.733' AS DateTime), CAST(N'2017-07-28T11:50:24.387' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (117, 2, N'75R12375N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.75 DE DIAMETRO X 12 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:50:35.440' AS DateTime), CAST(N'2017-07-28T11:50:34.097' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (118, 2, N'75R12400N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 4.00 DE DIAMETRO X 12 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:51:11.723' AS DateTime), CAST(N'2017-07-28T11:51:10.373' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (119, 2, N'75R15200N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.00 DE DIAMETRO X 15 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:51:37.560' AS DateTime), CAST(N'2017-07-28T11:51:36.220' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (120, 2, N'75R15225N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.25 DE DIAMETRO X 15 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:51:48.690' AS DateTime), CAST(N'2017-07-28T11:51:47.350' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (121, 2, N'75R15250N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.50 DE DIAMETRO X 15 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:51:57.843' AS DateTime), CAST(N'2017-07-28T11:51:56.497' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (122, 2, N'75R15275N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.75 DE DIAMETRO X 15 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:52:09.010' AS DateTime), CAST(N'2017-07-28T11:52:07.663' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (123, 2, N'75R15300N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.00 DE DIAMETRO X 15 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:52:20.390' AS DateTime), CAST(N'2017-07-28T11:52:19.050' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (124, 2, N'75R15325N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.25 DE DIAMETRO X 15 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:52:28.977' AS DateTime), CAST(N'2017-07-28T11:52:27.637' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (125, 2, N'75R15350N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.50 DE DIAMETRO X 15 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:52:41.467' AS DateTime), CAST(N'2017-07-28T11:52:40.120' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (126, 2, N'75R15375N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.75 DE DIAMETRO X 15 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:52:54.990' AS DateTime), CAST(N'2017-07-28T11:52:53.650' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (127, 2, N'75R15400N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 4.00 DE DIAMETRO X 15 MM DE LONGITUD.', N'Pieza', N'24', N'B-14', CAST(N'2017-07-28T11:53:04.760' AS DateTime), CAST(N'2017-07-28T11:53:03.417' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (128, 2, N'75R20200N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.00 DE DIAMETRO X 20 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:53:33.287' AS DateTime), CAST(N'2017-07-28T11:53:31.943' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (129, 2, N'75R20225N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.25 DE DIAMETRO X 20 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:53:44.550' AS DateTime), CAST(N'2017-07-28T11:53:43.210' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (130, 2, N'75R20250N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.50 DE DIAMETRO X 20 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:53:58.347' AS DateTime), CAST(N'2017-07-28T11:53:57.003' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (131, 2, N'75R20275N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.75 DE DIAMETRO X 20 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:54:07.827' AS DateTime), CAST(N'2017-07-28T11:54:06.487' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (132, 2, N'75R20300N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.00 DE DIAMETRO X 20 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:54:20.167' AS DateTime), CAST(N'2017-07-28T11:54:18.827' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (133, 2, N'75R20325N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.25 DE DIAMETRO X 20 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:54:30.867' AS DateTime), CAST(N'2017-07-28T11:54:29.527' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (134, 2, N'75R20350N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.50 DE DIAMETRO X 20 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:54:42.113' AS DateTime), CAST(N'2017-07-28T11:54:40.773' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (135, 2, N'75R20375N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.75 DE DIAMETRO X 20 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:54:52.143' AS DateTime), CAST(N'2017-07-28T11:54:50.800' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (136, 2, N'75R20400N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 4.00 DE DIAMETRO X 20 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:55:07.750' AS DateTime), CAST(N'2017-07-28T11:55:06.407' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (137, 2, N'75R25200N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.00 DE DIAMETRO X 25 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:55:29.780' AS DateTime), CAST(N'2017-07-28T11:55:28.433' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (138, 2, N'75R25225N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.25 DE DIAMETRO X 25 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:55:44.283' AS DateTime), CAST(N'2017-07-28T11:55:42.943' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (139, 2, N'75R25250N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.50 DE DIAMETRO X 25 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:55:54.743' AS DateTime), CAST(N'2017-07-28T11:55:53.400' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (140, 2, N'75R25275N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.75 DE DIAMETRO X 25 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:56:11.327' AS DateTime), CAST(N'2017-07-28T11:56:09.980' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (141, 2, N'75R25300N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.00 DE DIAMETRO X 25 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:56:34.697' AS DateTime), CAST(N'2017-07-28T11:56:33.350' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (142, 2, N'75R25325N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.25 DE DIAMETRO X 25 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:56:49.667' AS DateTime), CAST(N'2017-07-28T11:56:48.327' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (143, 2, N'75R25350N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.50 DE DIAMETRO X 25 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:57:02.203' AS DateTime), CAST(N'2017-07-28T11:57:00.860' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (144, 2, N'75R25375N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.75 DE DIAMETRO X 25 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:57:11.960' AS DateTime), CAST(N'2017-07-28T11:57:10.617' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (145, 2, N'75R25400N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 4.00 DE DIAMETRO X 25 MM DE LONGITUD.', N'Pieza', N'25', N'B-15', CAST(N'2017-07-28T11:57:25.940' AS DateTime), CAST(N'2017-07-28T11:57:32.210' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (146, 2, N'75R30200N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.00 DE DIAMETRO X 30 MM DE LONGITUD.', N'Pieza', N'26', N'B-16', CAST(N'2017-07-28T11:59:18.107' AS DateTime), CAST(N'2017-07-28T11:59:16.760' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (147, 2, N'75R30225N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.25 DE DIAMETRO X 30 MM DE LONGITUD.', N'Pieza', N'26', N'B-16', CAST(N'2017-07-28T11:59:29.453' AS DateTime), CAST(N'2017-07-28T11:59:28.113' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (148, 2, N'75R30250N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.50 DE DIAMETRO X 30 MM DE LONGITUD.', N'Pieza', N'26', N'B-16', CAST(N'2017-07-28T12:00:29.697' AS DateTime), CAST(N'2017-07-28T12:00:28.353' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (149, 2, N'75R30275N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 2.75 DE DIAMETRO X 30 MM DE LONGITUD.', N'Pieza', N'26', N'B-16', CAST(N'2017-07-28T12:00:42.507' AS DateTime), CAST(N'2017-07-28T12:00:41.160' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (150, 2, N'75R30300N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.00 DE DIAMETRO X 30 MM DE LONGITUD.', N'Pieza', N'26', N'B-16', CAST(N'2017-07-28T12:00:55.390' AS DateTime), CAST(N'2017-07-28T12:00:54.047' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (151, 2, N'75R30325N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.25 DE DIAMETRO X 30 MM DE LONGITUD.', N'Pieza', N'26', N'B-16', CAST(N'2017-07-28T12:03:18.780' AS DateTime), CAST(N'2017-07-28T12:03:17.437' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (152, 2, N'75R30350N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.50 DE DIAMETRO X 30 MM DE LONGITUD.', N'Pieza', N'26', N'B-16', CAST(N'2017-07-28T12:03:33.393' AS DateTime), CAST(N'2017-07-28T12:03:32.053' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (153, 2, N'75R30375N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 3.75 DE DIAMETRO X 30 MM DE LONGITUD.', N'Pieza', N'26', N'B-16', CAST(N'2017-07-28T12:03:45.337' AS DateTime), CAST(N'2017-07-28T12:03:43.990' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (154, 2, N'75R30400N', N'BALON NO COMPLACIENTE PARA DILATACION DE ARTERIA CORONARIA DE 4.00 DE DIAMETRO X 30 MM DE LONGITUD.', N'Pieza', N'26', N'B-16', CAST(N'2017-07-28T12:03:58.477' AS DateTime), CAST(N'2017-07-28T12:03:57.137' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (155, 2, N'556-112-00', N'VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: AMPLATZ DERECHO', N'Pieza', N'37', N'C-9', CAST(N'2017-07-28T12:20:58.903' AS DateTime), CAST(N'2017-07-28T12:20:57.563' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (156, 2, N'556-162-00', N'VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: JFL (FAJADET IZQ)', N'Pieza', N'37', N'C-9', CAST(N'2017-07-28T12:22:04.113' AS DateTime), CAST(N'2017-07-28T12:23:22.777' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (157, 2, N'556-168-00', N'VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: JFR (FAJADET DERECHO)', N'Pieza', N'37', N'C-9', CAST(N'2017-07-28T12:22:24.150' AS DateTime), CAST(N'2017-07-28T12:23:09.707' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (158, 2, N'556-172-00', N'VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: RADIAL BRAQUIAL', N'Pieza', N'37', N'C-9', CAST(N'2017-07-28T12:22:42.467' AS DateTime), CAST(N'2017-07-28T12:22:41.127' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (159, 2, N'556-174-00', N'VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: BARBEAU', N'Pieza', N'37', N'C-9', CAST(N'2017-07-28T12:22:56.917' AS DateTime), CAST(N'2017-07-28T12:22:55.573' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (160, 2, N'556-174-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: BARBEAU LBT', N'Pieza', N'38', N'C-10', CAST(N'2017-07-28T12:26:08.907' AS DateTime), CAST(N'2017-07-28T12:26:07.563' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (161, 2, N'556-162-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: JFL LBT (FAJADET IZQ)', N'Pieza', N'38', N'C-10', CAST(N'2017-07-28T12:27:04.310' AS DateTime), CAST(N'2017-07-28T12:27:02.967' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (162, 2, N'556-168-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: JFR LBT (FAJADET DERECHO)', N'Pieza', N'38', N'C-10', CAST(N'2017-07-28T12:33:02.510' AS DateTime), CAST(N'2017-07-28T12:33:01.163' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (163, 2, N'556-172-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: RADIAL BRAQUIAL LBT', N'Pieza', N'38', N'C-10', CAST(N'2017-07-28T12:33:53.770' AS DateTime), CAST(N'2017-07-28T12:33:52.377' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (164, 2, N'SM7328', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: XB (EXTRA BACK UP) LBT 3.0', N'Pieza', N'38', N'C-10', CAST(N'2017-07-28T12:34:51.137' AS DateTime), CAST(N'2017-07-28T12:34:49.797' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (165, 2, N'SM7331', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: AL 1 (AMPLATZ LEFT)', N'Pieza', N'38', N'C-10', CAST(N'2017-07-28T12:35:28.390' AS DateTime), CAST(N'2017-07-28T12:35:27.047' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (166, 2, N'SM7332', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: AL 3 (AMPLATZ LEFT)', N'Pieza', N'38', N'C-10', CAST(N'2017-07-28T12:35:43.023' AS DateTime), CAST(N'2017-07-28T12:35:41.687' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (167, 2, N'SM7329', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: JL 4.5 (JUDKINS LEFT)', N'Pieza', N'38', N'C-10', CAST(N'2017-07-28T12:36:17.890' AS DateTime), CAST(N'2017-07-28T12:36:16.547' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (168, 2, N'SM7330', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: JR 5 (JUDKINS RIGHT)', N'Pieza', N'38', N'C-10', CAST(N'2017-07-28T12:38:05.660' AS DateTime), CAST(N'2017-07-28T12:38:04.317' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (169, 2, N'556-278-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: HOCKEY STICK LBT', N'Pieza', N'38', N'C-10', CAST(N'2017-07-28T12:38:51.000' AS DateTime), CAST(N'2017-07-28T12:38:49.657' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (170, 2, N'556-040-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: AL 2 LBT (AMPLATZ LEFT)', N'Pieza', N'39', N'C-11', CAST(N'2017-07-28T12:40:14.843' AS DateTime), CAST(N'2017-07-28T12:40:13.507' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (171, 2, N'556-112-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: AR 2 LBT (AMPLATZ RIGHT)', N'Pieza', N'39', N'C-11', CAST(N'2017-07-28T12:40:44.160' AS DateTime), CAST(N'2017-07-28T12:40:42.770' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (172, 2, N'556-054-0L', N'Long vista brite tip - cateteres guia - 5 fr
longitud: 100 cm
morfologia: xb 3.5 lbt (extra backup)', N'Pieza', N'39', N'C-11', CAST(N'2017-07-28T12:52:59.053' AS DateTime), CAST(N'2017-07-28T17:00:58.813' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (173, 2, N'556-056-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: XB 4 LBT (EXTRA BACKUP)', N'Pieza', N'39', N'C-11', CAST(N'2017-07-28T12:53:10.620' AS DateTime), CAST(N'2017-07-28T12:53:09.287' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (174, 2, N'556-060-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: XBLAD 3.5 LBT (EXTRA BACKUP)', N'Pieza', N'39', N'C-11', CAST(N'2017-07-28T12:53:34.493' AS DateTime), CAST(N'2017-07-28T12:53:33.157' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (175, 2, N'556-278-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: HOCKEY STICK LBT', N'Pieza', N'39', N'C-11', CAST(N'2017-07-28T12:54:16.800' AS DateTime), CAST(N'2017-07-28T12:54:15.467' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (176, 2, N'556-190-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: IM LBT(INTERNAL MAMMARY)', N'Pieza', N'39', N'C-11', CAST(N'2017-07-28T12:54:41.607' AS DateTime), CAST(N'2017-07-28T12:54:40.270' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (177, 2, N'556-002-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: JL 3.5 LBT (JUDKINS IZQUIERDO)', N'Pieza', N'39', N'C-11', CAST(N'2017-07-28T12:55:28.873' AS DateTime), CAST(N'2017-07-28T12:55:27.537' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (178, 2, N'556-004-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: JL 4 LBT (JUDKINS IZQUIERDO)', N'Pieza', N'39', N'C-11', CAST(N'2017-07-28T12:55:40.137' AS DateTime), CAST(N'2017-07-28T12:55:38.803' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (179, 2, N'556-008-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: JL 5 LBT (JUDKINS IZQUIERDO)', N'Pieza', N'39', N'C-11', CAST(N'2017-07-28T12:55:53.960' AS DateTime), CAST(N'2017-07-28T12:55:52.623' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (180, 2, N'556-080-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: JR 3.5 LBT (JUDKINS DERECHO)', N'Pieza', N'39', N'C-11', CAST(N'2017-07-28T12:57:32.757' AS DateTime), CAST(N'2017-07-28T12:57:31.423' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (181, 2, N'556-082-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: JR 4 LBT (JUDKINS DERECHO)', N'Pieza', N'39', N'C-11', CAST(N'2017-07-28T12:57:45.267' AS DateTime), CAST(N'2017-07-28T12:57:43.930' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (182, 2, N'556-270-0L', N'LONG VISTA BRITE TIP - CATETERES GUIA - 5FR
LONGITUD: 100 CM
MORFOLOGIA: MPA 1 LBT (MULTIPROPOSITO)', N'Pieza', N'39', N'C-11', CAST(N'2017-07-28T12:58:15.317' AS DateTime), CAST(N'2017-07-28T12:58:13.983' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (183, 2, N'SM7717', N'Vista brite tip - cateteres guia - 6fr
longitud: 100 cm
morfologia: rbl 4 (radial bilateral).', N'Pieza', N'40', N'C-12', CAST(N'2017-07-28T15:03:03.750' AS DateTime), CAST(N'2017-07-28T16:51:53.037' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (184, 2, N'SM7718', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: RBL 5 (RADIAL BILATERAL)', N'Pieza', N'40', N'C-12', CAST(N'2017-07-28T15:03:21.090' AS DateTime), CAST(N'2017-07-28T15:03:19.763' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (185, 2, N'SM7729', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: RBL 4.5 (RADIAL BILATERAL)', N'Pieza', N'40', N'C-12', CAST(N'2017-07-28T15:03:40.933' AS DateTime), CAST(N'2017-07-28T15:03:39.613' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (186, 2, N'SM7464', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: XB 2.0 (EXTRA BACKUP)', N'Pieza', N'40', N'C-12', CAST(N'2017-07-28T15:04:30.403' AS DateTime), CAST(N'2017-07-28T15:04:29.083' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (187, 2, N'SM7465', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: XB 2.5 (EXTRA BACKUP)', N'Pieza', N'40', N'C-12', CAST(N'2017-07-28T15:04:48.267' AS DateTime), CAST(N'2017-07-28T15:04:46.943' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (188, 2, N'SM7636', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: BRAQUIAL LEFT', N'Pieza', N'40', N'C-12', CAST(N'2017-07-28T15:05:19.260' AS DateTime), CAST(N'2017-07-28T15:05:17.933' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (189, 2, N'670-174-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: BARBEAU', N'Pieza', N'40', N'C-12', CAST(N'2017-07-28T15:05:50.533' AS DateTime), CAST(N'2017-07-28T15:05:49.210' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (190, 2, N'670-162-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jfl (fajadet izquierdo)', N'Pieza', N'40', N'C-12', CAST(N'2017-07-28T15:07:11.097' AS DateTime), CAST(N'2017-07-28T16:58:00.633' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (191, 2, N'670-164-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: JFL ST (FAJADET IZQUIERDO, PUNTA CORTA)', N'Pieza', N'40', N'C-12', CAST(N'2017-07-28T15:07:46.017' AS DateTime), CAST(N'2017-07-28T15:07:44.697' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (192, 2, N'670-166-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: JFL LT (FAJADET IZQUIERDO, PUNTA LARGA)', N'Pieza', N'40', N'C-12', CAST(N'2017-07-28T15:08:09.390' AS DateTime), CAST(N'2017-07-28T15:08:08.067' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (193, 2, N'670-168-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: JFR (FAJADET DERECHO)', N'Pieza', N'40', N'C-12', CAST(N'2017-07-28T15:08:30.890' AS DateTime), CAST(N'2017-07-28T15:08:29.567' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (194, 2, N'670-172-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: RB (RADIAL BRAQUIAL)', N'Pieza', N'40', N'C-12', CAST(N'2017-07-28T15:08:53.363' AS DateTime), CAST(N'2017-07-28T15:08:52.033' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (195, 2, N'670-170-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: JFR ST (FAJADET DERECHO, PUNTA CORTA)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:10:45.953' AS DateTime), CAST(N'2017-07-28T15:10:44.633' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (196, 2, N'670-278-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: HOCKEY STICK', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:11:10.160' AS DateTime), CAST(N'2017-07-28T15:11:08.837' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (197, 2, N'670-279-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: HOCKEY STICK (SH)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:11:41.690' AS DateTime), CAST(N'2017-07-28T15:11:40.367' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (198, 2, N'670-034-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: AL .75 (AMPLATZ LEFT)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:13:07.467' AS DateTime), CAST(N'2017-07-28T15:13:06.140' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (199, 2, N'670-035-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: AL .75 SH (AMPLATZ LEFT)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:13:21.037' AS DateTime), CAST(N'2017-07-28T15:13:19.717' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (200, 2, N'670-036-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: AL 1 (AMPLATZ LEFT)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:13:41.393' AS DateTime), CAST(N'2017-07-28T15:13:40.073' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (201, 2, N'670-037-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: AL 1 SH (AMPLATZ LEFT)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:13:54.693' AS DateTime), CAST(N'2017-07-28T15:13:53.373' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (202, 2, N'670-044-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: AL 1 ST (AMPLATZ LEFT, PUNTA CORTA)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:14:20.670' AS DateTime), CAST(N'2017-07-28T15:14:19.343' AS DateTime))
GO
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (203, 2, N'670-038-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: AL 1.5 (AMPLATZ LEFT)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:14:51.863' AS DateTime), CAST(N'2017-07-28T15:14:50.543' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (204, 2, N'670-040-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: AL 2 (AMPLATZ LEFT)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:15:02.980' AS DateTime), CAST(N'2017-07-28T15:15:01.660' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (205, 2, N'670-041-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: AL 2 SH (AMPLATZ LEFT, ORIFICIOS LATERALES)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:15:53.793' AS DateTime), CAST(N'2017-07-28T15:15:52.467' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (206, 2, N'670-048-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: AL 2 ST (AMPLATZ LEFT, PUNTA CORTA)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:16:15.163' AS DateTime), CAST(N'2017-07-28T15:16:13.837' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (207, 2, N'670-042-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: AL 3 (AMPLATZ LEFT)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:17:11.270' AS DateTime), CAST(N'2017-07-28T15:17:09.947' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (208, 2, N'670-110-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: AR 1 (AMPLATZ RIGHT)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:17:49.880' AS DateTime), CAST(N'2017-07-28T15:17:48.557' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (209, 2, N'670-111-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: ar 1 sh (amplatz right, orificios laterales)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:18:45.320' AS DateTime), CAST(N'2017-07-28T16:57:28.093' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (210, 2, N'670-112-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: AR 2 (AMPLATZ RIGHT)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:19:02.960' AS DateTime), CAST(N'2017-07-28T15:19:01.640' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (211, 2, N'670-113-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: AR 2 SH (AMPLATZ RIGHT, ORIFICIOS LATERALES)', N'Pieza', N'41', N'C-13', CAST(N'2017-07-28T15:19:54.703' AS DateTime), CAST(N'2017-07-28T15:19:53.377' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (212, 2, N'670-052-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: XB 3 (EXTRA BACKUP)', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:21:19.480' AS DateTime), CAST(N'2017-07-28T15:21:18.163' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (213, 2, N'670-053-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: XB 3 SH (EXTRA BACKUP, ORIFICIOS LATERALES)', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:21:58.923' AS DateTime), CAST(N'2017-07-28T15:21:57.603' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (214, 2, N'670-054-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: XB 3.5 (EXTRA BACKUP)', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:22:51.580' AS DateTime), CAST(N'2017-07-28T15:22:50.260' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (215, 2, N'670-055-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: XB 3.5 SH (EXTRA BACKUP, ORIFICIOS LATERALES)', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:23:39.037' AS DateTime), CAST(N'2017-07-28T15:23:37.717' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (216, 2, N'670-056-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: XB 4 (EXTRA BACKUP)', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:25:42.017' AS DateTime), CAST(N'2017-07-28T15:25:40.693' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (217, 2, N'670-057-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: XB 4 SH (EXTRA BACKUP,ORIFICIOS LATERALES)', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:26:09.000' AS DateTime), CAST(N'2017-07-28T15:26:07.677' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (218, 2, N'670-058-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: XB 4.5 (EXTRA BACKUP)', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:26:39.083' AS DateTime), CAST(N'2017-07-28T15:26:37.763' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (219, 2, N'670-059-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: XB 4.5 SH (EXTRA BACKUP,ORIFICIOS LATERALES)', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:27:03.637' AS DateTime), CAST(N'2017-07-28T15:27:02.313' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (220, 2, N'670-070-00', N'VISTA BRITE TIP - CATETERES GUIA - 6FR
LONGITUD: 100 CM
MORFOLOGIA: XBC 3', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:28:24.687' AS DateTime), CAST(N'2017-07-28T15:28:23.360' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (221, 2, N'670-071-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xbc 3 sh', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:48:31.717' AS DateTime), CAST(N'2017-07-28T15:50:49.390' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (222, 2, N'670-072-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xbc 3.5', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:48:56.147' AS DateTime), CAST(N'2017-07-28T15:50:37.487' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (223, 2, N'670-073-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xbc 3.5 sh', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:49:14.500' AS DateTime), CAST(N'2017-07-28T15:50:30.040' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (224, 2, N'670-074-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xbc 4', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:49:27.293' AS DateTime), CAST(N'2017-07-28T15:52:58.387' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (225, 2, N'670-075-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xbc 4 sh', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:55:22.023' AS DateTime), CAST(N'2017-07-28T15:55:20.707' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (226, 2, N'670-076-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xbc 4.5', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:55:52.570' AS DateTime), CAST(N'2017-07-28T15:55:51.253' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (227, 2, N'670-077-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xbc 4.5 sh', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:56:02.770' AS DateTime), CAST(N'2017-07-28T15:56:01.447' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (228, 2, N'670-066-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xblad 3', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:56:23.310' AS DateTime), CAST(N'2017-07-28T15:56:21.990' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (229, 2, N'670-067-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xblad 3 sh', N'Pieza', N'42', N'C-14', CAST(N'2017-07-28T15:56:36.883' AS DateTime), CAST(N'2017-07-28T15:56:35.563' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (230, 2, N'670-060-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xblad 3.5', N'Pieza', N'43', N'C-15', CAST(N'2017-07-28T15:58:18.257' AS DateTime), CAST(N'2017-07-28T15:58:16.937' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (231, 2, N'670-061-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xblad 3.5 sh (orificios laterales)', N'Pieza', N'43', N'C-15', CAST(N'2017-07-28T15:59:05.770' AS DateTime), CAST(N'2017-07-28T15:59:04.453' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (232, 2, N'670-062-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xblad 4', N'Pieza', N'43', N'C-15', CAST(N'2017-07-28T15:59:17.987' AS DateTime), CAST(N'2017-07-28T15:59:16.667' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (233, 2, N'670-063-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xblad 4 sh (orificios laterales)', N'Pieza', N'43', N'C-15', CAST(N'2017-07-28T15:59:46.540' AS DateTime), CAST(N'2017-07-28T15:59:45.220' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (234, 2, N'670-064-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xblad 4.5', N'Pieza', N'43', N'C-15', CAST(N'2017-07-28T16:00:02.133' AS DateTime), CAST(N'2017-07-28T16:00:00.817' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (235, 2, N'670-065-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xblad 4.5 sh (orificios laterales)', N'Pieza', N'43', N'C-15', CAST(N'2017-07-28T16:00:21.203' AS DateTime), CAST(N'2017-07-28T16:00:19.880' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (236, 2, N'670-122-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xbr 1 (extra backup derecho)', N'Pieza', N'43', N'C-15', CAST(N'2017-07-28T16:01:19.943' AS DateTime), CAST(N'2017-07-28T16:01:18.620' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (237, 2, N'670-123-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xbr 1 sh (extra backup derecho,orificios laterales)', N'Pieza', N'43', N'C-15', CAST(N'2017-07-28T16:02:07.500' AS DateTime), CAST(N'2017-07-28T16:02:06.147' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (238, 2, N'670-124-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xbr 2 (extra backup derecho)', N'Pieza', N'43', N'C-15', CAST(N'2017-07-28T16:02:32.980' AS DateTime), CAST(N'2017-07-28T16:02:31.660' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (239, 2, N'670-125-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xbr 2 sh (extra backup derecho, orificios laterales)', N'Pieza', N'43', N'C-15', CAST(N'2017-07-28T16:03:17.523' AS DateTime), CAST(N'2017-07-28T16:03:16.200' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (240, 2, N'670-126-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xbrca', N'Pieza', N'43', N'C-15', CAST(N'2017-07-28T16:04:04.953' AS DateTime), CAST(N'2017-07-28T16:04:03.637' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (241, 2, N'670-127-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: xbrca sh', N'Pieza', N'43', N'C-15', CAST(N'2017-07-28T16:04:14.440' AS DateTime), CAST(N'2017-07-28T16:04:13.123' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (242, 2, N'670-190-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: im (internal mammary)', N'Pieza', N'43', N'C-15', CAST(N'2017-07-28T16:04:47.607' AS DateTime), CAST(N'2017-07-28T16:04:46.290' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (243, 2, N'670-191-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: im sh (internal mammary, orificios laterales)', N'Pieza', N'43', N'C-15', CAST(N'2017-07-28T16:05:06.410' AS DateTime), CAST(N'2017-07-28T16:05:05.090' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (244, 2, N'670-000-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jl 3 (judkins left)', N'Pieza', N'44', N'C-16', CAST(N'2017-07-28T16:05:54.657' AS DateTime), CAST(N'2017-07-28T16:05:53.337' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (245, 2, N'670-002-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jl 3.5 (judkins left)', N'Pieza', N'44', N'C-16', CAST(N'2017-07-28T16:06:07.647' AS DateTime), CAST(N'2017-07-28T16:06:06.327' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (246, 2, N'670-003-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jl 3.5 sh (judkins left,orificios laterales)', N'Pieza', N'44', N'C-16', CAST(N'2017-07-28T16:06:32.560' AS DateTime), CAST(N'2017-07-28T16:06:31.247' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (247, 2, N'670-012-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jl 3.5 st (judkins left, punta corta)', N'Pieza', N'44', N'C-16', CAST(N'2017-07-28T16:07:29.050' AS DateTime), CAST(N'2017-07-28T16:07:27.730' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (248, 2, N'670-004-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jl 4 (judkins left)', N'Pieza', N'44', N'C-16', CAST(N'2017-07-28T16:08:55.450' AS DateTime), CAST(N'2017-07-28T16:08:54.133' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (249, 2, N'670-005-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jl 4 sh (judkins left, orificios laterales)', N'Pieza', N'44', N'C-16', CAST(N'2017-07-28T16:10:31.253' AS DateTime), CAST(N'2017-07-28T16:10:29.940' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (250, 2, N'670-014-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jl 4 st (judkins left, punta corta)', N'Pieza', N'44', N'C-16', CAST(N'2017-07-28T16:11:01.193' AS DateTime), CAST(N'2017-07-28T16:10:59.877' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (251, 2, N'670-006-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jl 4.5 (judkins left)', N'Pieza', N'44', N'C-16', CAST(N'2017-07-28T16:11:30.687' AS DateTime), CAST(N'2017-07-28T16:11:29.367' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (252, 2, N'670-016-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jl 4.5 st (judkins left, punta corta)', N'Pieza', N'44', N'C-16', CAST(N'2017-07-28T16:12:09.460' AS DateTime), CAST(N'2017-07-28T16:12:08.140' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (253, 2, N'670-008-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jl 5 (judkins left)', N'Pieza', N'44', N'C-16', CAST(N'2017-07-28T16:13:15.263' AS DateTime), CAST(N'2017-07-28T16:13:13.943' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (254, 2, N'670-010-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jl 6 (judkins left)', N'Pieza', N'44', N'C-16', CAST(N'2017-07-28T16:14:18.457' AS DateTime), CAST(N'2017-07-28T16:14:17.137' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (255, 2, N'670-080-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jr 3.5 (judkins right)', N'Pieza', N'45', N'C-17', CAST(N'2017-07-28T16:15:03.530' AS DateTime), CAST(N'2017-07-28T16:15:02.210' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (256, 2, N'670-081-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jr 3.5 sh (judkins right, orificios laterales)', N'Pieza', N'45', N'C-17', CAST(N'2017-07-28T16:15:39.540' AS DateTime), CAST(N'2017-07-28T16:15:38.220' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (257, 2, N'670-082-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jr 4 (judkins right)', N'Pieza', N'45', N'C-17', CAST(N'2017-07-28T16:16:16.350' AS DateTime), CAST(N'2017-07-28T16:16:15.030' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (258, 2, N'670-083-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jr 4 sh (judkins right, orificios laterales)', N'Pieza', N'45', N'C-17', CAST(N'2017-07-28T16:17:08.360' AS DateTime), CAST(N'2017-07-28T16:17:07.040' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (259, 2, N'670-090-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jr 4 st (judkins right, punta corta)', N'Pieza', N'45', N'C-17', CAST(N'2017-07-28T16:17:28.423' AS DateTime), CAST(N'2017-07-28T16:17:27.103' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (260, 2, N'670-084-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: jr 5 (judkins right)', N'Pieza', N'45', N'C-17', CAST(N'2017-07-28T16:23:06.353' AS DateTime), CAST(N'2017-07-28T16:36:10.397' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (261, 2, N'670-180-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: lcb (left coronary bypass)', N'Pieza', N'45', N'C-17', CAST(N'2017-07-28T16:37:25.397' AS DateTime), CAST(N'2017-07-28T16:37:24.070' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (262, 2, N'670-181-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: lcb sh (left coronary bypass, orificios laterales)', N'Pieza', N'45', N'C-17', CAST(N'2017-07-28T16:38:57.390' AS DateTime), CAST(N'2017-07-28T16:38:56.073' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (263, 2, N'670-270-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: mpa 1 (multiproposito a) ', N'Pieza', N'45', N'C-17', CAST(N'2017-07-28T16:56:39.210' AS DateTime), CAST(N'2017-07-28T16:57:50.877' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (264, 2, N'670-271-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: mpa 1 sh (multiproposito a, orificios laterales) ', N'Pieza', N'45', N'C-17', CAST(N'2017-07-28T17:00:05.433' AS DateTime), CAST(N'2017-07-28T17:00:04.117' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (265, 2, N'670-272-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: mpb 1 (multiproposito b) ', N'Pieza', N'45', N'C-17', CAST(N'2017-07-28T17:01:53.010' AS DateTime), CAST(N'2017-07-28T17:01:51.693' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (266, 2, N'670-182-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: rcb (right coronary bypass)', N'Pieza', N'46', N'C-18', CAST(N'2017-07-28T17:10:44.333' AS DateTime), CAST(N'2017-07-28T17:10:43.017' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (267, 2, N'670-183-00', N'Vista brite tip - cateteres guia - 6fr 
longitud: 100 cm
morfologia: rcb sh (right coronary bypass, orificios laterales)', N'Pieza', N'46', N'C-18', CAST(N'2017-07-28T17:14:20.670' AS DateTime), CAST(N'2017-07-28T17:14:19.360' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (268, 2, N'670-278-90', N'Vista brite tip - cateteres guia - 6fr 
longitud: 90 cm
morfologia: hockey stick', N'Pieza', N'46', N'C-18', CAST(N'2017-07-28T17:16:01.777' AS DateTime), CAST(N'2017-07-28T17:16:00.463' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (269, 2, N'670-190-90', N'Vista brite tip - cateteres guia - 6fr 
longitud: 90 cm
morfologia: im (internal mammary)', N'Pieza', N'46', N'C-18', CAST(N'2017-07-28T17:16:29.153' AS DateTime), CAST(N'2017-07-28T17:16:27.837' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (270, 2, N'670-004-90', N'Vista brite tip - cateteres guia - 6fr 
longitud: 90 cm
morfologia: jl 4 (judkins left)', N'Pieza', N'46', N'C-18', CAST(N'2017-07-28T17:19:52.140' AS DateTime), CAST(N'2017-07-28T17:19:50.827' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (271, 2, N'670-082-90', N'Vista brite tip - cateteres guia - 6fr 
longitud: 90 cm
morfologia: jr 4 (judkins right)', N'Pieza', N'46', N'C-18', CAST(N'2017-07-28T17:21:52.450' AS DateTime), CAST(N'2017-07-28T17:21:51.133' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (272, 2, N'670-180-90', N'Vista brite tip - cateteres guia - 6fr 
longitud: 90 cm
morfologia: lcb (left coronary bypass)', N'Pieza', N'46', N'C-18', CAST(N'2017-07-28T17:22:22.710' AS DateTime), CAST(N'2017-07-28T17:22:21.393' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (273, 2, N'670-270-90', N'Vista brite tip - cateteres guia - 6fr 
longitud: 90 cm
morfologia: mpa 1 (multiproposito a)', N'Pieza', N'46', N'C-18', CAST(N'2017-07-28T17:23:11.023' AS DateTime), CAST(N'2017-07-28T17:23:09.707' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (274, 2, N'670-182-90', N'Vista brite tip - cateteres guia - 6fr 
longitud: 90 cm
morfologia: rcb (right coronary bypass)', N'Pieza', N'46', N'C-18', CAST(N'2017-07-28T17:24:42.363' AS DateTime), CAST(N'2017-07-28T17:24:41.047' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (275, 2, N'670-054-90', N'Vista brite tip - cateteres guia - 6fr 
longitud: 90 cm
morfologia: xb 3.5 (extra back up)', N'Pieza', N'46', N'C-18', CAST(N'2017-07-28T17:26:09.343' AS DateTime), CAST(N'2017-07-28T17:26:08.027' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (276, 2, N'778-034-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: al .75 (amplatz left)', N'Pieza', N'48', N'C-20', CAST(N'2017-07-29T11:00:28.647' AS DateTime), CAST(N'2017-07-29T11:00:26.537' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (277, 2, N'778-036-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: al 1 (amplatz left)', N'Pieza', N'48', N'C-20', CAST(N'2017-07-29T11:00:47.143' AS DateTime), CAST(N'2017-07-29T11:00:45.040' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (278, 2, N'778-037-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: al 1 sh (amplatz left,orificios laterales)', N'Pieza', N'48', N'C-20', CAST(N'2017-07-29T11:01:19.367' AS DateTime), CAST(N'2017-07-29T11:01:17.260' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (279, 2, N'778-044-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: al 1 st (amplatz left,punta corta)', N'Pieza', N'48', N'C-20', CAST(N'2017-07-29T11:01:37.753' AS DateTime), CAST(N'2017-07-29T11:01:35.650' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (280, 2, N'778-045-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: al 1 st sh (amplatz left,punta corta, orificios laterales)', N'Pieza', N'48', N'C-20', CAST(N'2017-07-29T11:02:08.050' AS DateTime), CAST(N'2017-07-29T11:02:05.940' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (281, 2, N'778-038-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: al 1.5 (amplatz left)', N'Pieza', N'48', N'C-20', CAST(N'2017-07-29T11:02:36.460' AS DateTime), CAST(N'2017-07-29T11:04:15.617' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (282, 2, N'778-039-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: al 1.5 sh (amplatz left, orificios laterales)', N'Pieza', N'48', N'C-20', CAST(N'2017-07-29T11:04:05.027' AS DateTime), CAST(N'2017-07-29T11:04:02.923' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (283, 2, N'778-040-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: al 2 (amplatz left)', N'Pieza', N'48', N'C-20', CAST(N'2017-07-29T11:05:05.600' AS DateTime), CAST(N'2017-07-29T11:05:03.497' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (284, 2, N'778-041-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: al 2 sh (amplatz left, orificios laterales)', N'Pieza', N'49', N'C-21', CAST(N'2017-07-29T11:07:34.917' AS DateTime), CAST(N'2017-07-29T11:07:32.807' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (285, 2, N'778-048-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: al 2 st (amplatz left, punta corta)', N'Pieza', N'49', N'C-21', CAST(N'2017-07-29T11:08:02.470' AS DateTime), CAST(N'2017-07-29T11:08:00.363' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (286, 2, N'778-049-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: al 2 st sh(amplatz left, punta corta, orificios laterales)', N'Pieza', N'49', N'C-21', CAST(N'2017-07-29T11:08:35.380' AS DateTime), CAST(N'2017-07-29T11:08:33.273' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (287, 2, N'778-042-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: al 3 (amplatz left)', N'Pieza', N'49', N'C-21', CAST(N'2017-07-29T11:10:27.817' AS DateTime), CAST(N'2017-07-29T11:10:25.707' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (288, 2, N'778-043-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: al 3 sh (amplatz left, orificios laterales)', N'Pieza', N'49', N'C-21', CAST(N'2017-07-29T11:15:28.233' AS DateTime), CAST(N'2017-07-29T11:15:26.123' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (289, 2, N'778-110-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: ar 1 (amplatz right)', N'Pieza', N'49', N'C-21', CAST(N'2017-07-29T11:32:42.507' AS DateTime), CAST(N'2017-07-29T11:32:40.390' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (290, 2, N'778-112-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: ar 2 (amplatz right)', N'Pieza', N'49', N'C-21', CAST(N'2017-07-29T11:32:57.433' AS DateTime), CAST(N'2017-07-29T11:32:55.330' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (291, 2, N'778-111-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: ar 1 sh (amplatz right, orificios laterales)', N'Pieza', N'49', N'C-21', CAST(N'2017-07-29T11:33:18.820' AS DateTime), CAST(N'2017-07-29T11:33:16.710' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (292, 2, N'778-113-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: ar 2 sh (amplatz right, orificios laterales)', N'Pieza', N'49', N'C-21', CAST(N'2017-07-29T11:33:33.823' AS DateTime), CAST(N'2017-07-29T11:33:31.723' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (293, 2, N'778-052-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: xb 3 (extra backup)', N'Pieza', N'49', N'C-21', CAST(N'2017-07-29T11:35:11.313' AS DateTime), CAST(N'2017-07-29T11:35:09.210' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (294, 2, N'778-053-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: xb 3 sh (extra backup, orificios laterales)', N'Pieza', N'49', N'C-21', CAST(N'2017-07-29T11:35:28.330' AS DateTime), CAST(N'2017-07-29T11:35:26.227' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (295, 2, N'778-054-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: xb 3.5 (amplatz right)', N'Pieza', N'49', N'C-21', CAST(N'2017-07-29T11:35:52.193' AS DateTime), CAST(N'2017-07-29T11:35:50.087' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (296, 2, N'778-055-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: xb 3.5 sh (amplatz right, orificios laterales)', N'Pieza', N'49', N'C-21', CAST(N'2017-07-29T11:36:12.670' AS DateTime), CAST(N'2017-07-29T11:36:10.563' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (297, 2, N'778-056-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: xb 4 (extra backup)', N'Pieza', N'50', N'C-22', CAST(N'2017-07-29T12:12:45.267' AS DateTime), CAST(N'2017-07-29T12:12:43.157' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (298, 2, N'778-058-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: xb 4.5 (extra backup)', N'Pieza', N'50', N'C-22', CAST(N'2017-07-29T12:13:01.777' AS DateTime), CAST(N'2017-07-29T12:12:59.670' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (299, 2, N'778-060-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: xblad 3.5 (extra backup)', N'Pieza', N'50', N'C-22', CAST(N'2017-07-29T12:13:28.313' AS DateTime), CAST(N'2017-07-29T12:13:26.207' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (300, 2, N'778-062-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: xblad 4 (extra backup)', N'Pieza', N'50', N'C-22', CAST(N'2017-07-29T12:13:53.360' AS DateTime), CAST(N'2017-07-29T12:13:51.257' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (301, 2, N'778-064-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: xblad 4.5 (extra backup)', N'Pieza', N'50', N'C-22', CAST(N'2017-07-29T12:14:21.363' AS DateTime), CAST(N'2017-07-29T12:14:19.260' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (302, 2, N'778-278-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: hockey stick', N'Pieza', N'50', N'C-22', CAST(N'2017-07-29T12:14:43.577' AS DateTime), CAST(N'2017-07-29T12:14:41.470' AS DateTime))
GO
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (303, 2, N'778-190-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: im (internal mammary)', N'Pieza', N'50', N'C-22', CAST(N'2017-07-29T12:15:08.007' AS DateTime), CAST(N'2017-07-29T12:15:05.900' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (304, 2, N'778-000-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: jl 3 (judkins left)', N'Pieza', N'50', N'C-22', CAST(N'2017-07-29T12:16:22.420' AS DateTime), CAST(N'2017-07-29T12:16:20.317' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (305, 2, N'778-002-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: jl 3.5 (judkins left)', N'Pieza', N'50', N'C-22', CAST(N'2017-07-29T12:16:40.257' AS DateTime), CAST(N'2017-07-29T12:16:38.150' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (306, 2, N'778-004-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: jl 4 (judkins left)', N'Pieza', N'51', N'C-23', CAST(N'2017-07-29T12:17:20.860' AS DateTime), CAST(N'2017-07-29T12:17:18.753' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (307, 2, N'778-006-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: jl 4.5 (judkins left)', N'Pieza', N'51', N'C-23', CAST(N'2017-07-29T12:17:43.750' AS DateTime), CAST(N'2017-07-29T12:17:41.643' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (308, 2, N'778-008-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: jl 5 (judkins left)', N'Pieza', N'51', N'C-23', CAST(N'2017-07-29T12:19:51.790' AS DateTime), CAST(N'2017-07-29T12:19:49.673' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (309, 2, N'778-010-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: jl 6 (judkins left)', N'Pieza', N'51', N'C-23', CAST(N'2017-07-29T12:20:05.430' AS DateTime), CAST(N'2017-07-29T12:20:03.327' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (310, 2, N'778-080-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: jr 3.5 (judkins rigth)', N'Pieza', N'52', N'C-24', CAST(N'2017-07-29T12:24:15.343' AS DateTime), CAST(N'2017-07-29T12:24:13.240' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (311, 2, N'778-082-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: jr 4 (judkins rigth)', N'Pieza', N'52', N'C-24', CAST(N'2017-07-29T12:25:15.237' AS DateTime), CAST(N'2017-07-29T12:25:13.127' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (312, 2, N'778-084-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: jr 5 (judkins rigth)', N'Pieza', N'52', N'C-24', CAST(N'2017-07-29T12:25:38.210' AS DateTime), CAST(N'2017-07-29T12:25:36.103' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (313, 2, N'778-180-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: lcb (left coronary bypass)', N'Pieza', N'52', N'C-24', CAST(N'2017-07-29T12:26:33.660' AS DateTime), CAST(N'2017-07-29T12:26:31.553' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (314, 2, N'778-270-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: mpa 1 (multiproposito a)', N'Pieza', N'52', N'C-24', CAST(N'2017-07-29T12:26:58.870' AS DateTime), CAST(N'2017-07-29T12:26:56.763' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (315, 2, N'778-272-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: mpb 1 (multiproposito b)', N'Pieza', N'52', N'C-24', CAST(N'2017-07-29T12:27:17.203' AS DateTime), CAST(N'2017-07-29T12:27:15.103' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (316, 2, N'778-182-00', N'Vista brite tip - cateteres guia - 7fr 
longitud: 100 cm
morfologia: rcb (right coronary bypass)', N'Pieza', N'53', N'C-25', CAST(N'2017-07-29T12:28:07.177' AS DateTime), CAST(N'2017-07-29T12:28:05.073' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (317, 2, N'778-036-90', N'Vista brite tip - cateteres guia - 7fr 
longitud: 90 cm
morfologia: al 1 (amplatz left)', N'Pieza', N'53', N'C-25', CAST(N'2017-07-29T12:28:46.317' AS DateTime), CAST(N'2017-07-29T12:28:44.210' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (318, 2, N'778-040-90', N'Vista brite tip - cateteres guia - 7fr 
longitud: 90 cm
morfologia: al 2 (amplatz left)', N'Pieza', N'53', N'C-25', CAST(N'2017-07-29T12:29:04.007' AS DateTime), CAST(N'2017-07-29T12:29:01.907' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (319, 2, N'778-110-90', N'Vista brite tip - cateteres guia - 7fr 
longitud: 90 cm
morfologia: ar 1 (amplatz right)', N'Pieza', N'53', N'C-25', CAST(N'2017-07-29T12:29:41.547' AS DateTime), CAST(N'2017-07-29T12:29:39.443' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (320, 2, N'778-278-90', N'Vista brite tip - cateteres guia - 7fr 
longitud: 90 cm
morfologia: hockey stick', N'Pieza', N'53', N'C-25', CAST(N'2017-07-29T12:30:06.700' AS DateTime), CAST(N'2017-07-29T12:30:04.593' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (321, 2, N'778-190-90', N'Vista brite tip - cateteres guia - 7fr 
longitud: 90 cm
morfologia: im (internal mammary)', N'Pieza', N'53', N'C-25', CAST(N'2017-07-29T12:30:50.940' AS DateTime), CAST(N'2017-07-29T12:30:48.837' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (322, 2, N'778-002-90', N'Vista brite tip - cateteres guia - 7fr 
longitud: 90 cm
morfologia: jl 3.5 (judkins left)', N'Pieza', N'53', N'C-25', CAST(N'2017-07-29T12:31:22.410' AS DateTime), CAST(N'2017-07-29T12:31:20.313' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (323, 2, N'778-004-90', N'Vista brite tip - cateteres guia - 7fr 
longitud: 90 cm
morfologia: jl 4 (judkins left)', N'Pieza', N'53', N'C-25', CAST(N'2017-07-29T12:31:36.687' AS DateTime), CAST(N'2017-07-29T12:31:34.580' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (324, 2, N'778-082-90', N'Vista brite tip - cateteres guia - 7fr 
longitud: 90 cm
morfologia: jr 4 (judkins right)', N'Pieza', N'53', N'C-25', CAST(N'2017-07-29T12:32:02.100' AS DateTime), CAST(N'2017-07-29T12:32:00.000' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (325, 2, N'778-180-90', N'Vista brite tip - cateteres guia - 7fr 
longitud: 90 cm
morfologia: lcb (left coronary bypass)', N'Pieza', N'53', N'C-25', CAST(N'2017-07-29T12:32:38.723' AS DateTime), CAST(N'2017-07-29T12:32:36.617' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (326, 2, N'778-270-90', N'Vista brite tip - cateteres guia - 7fr 
longitud: 90 cm
morfologia: mpa 1 (multiproposito a)', N'Pieza', N'53', N'C-25', CAST(N'2017-07-29T12:33:10.650' AS DateTime), CAST(N'2017-07-29T12:33:08.547' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (327, 2, N'588-890', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: al .75 (amplatz left)', N'Pieza', N'54', N'C-26', CAST(N'2017-07-29T12:34:03.910' AS DateTime), CAST(N'2017-07-29T12:34:01.807' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (328, 2, N'588-843', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: al 1 (amplatz left)', N'Pieza', N'54', N'C-26', CAST(N'2017-07-29T12:39:27.353' AS DateTime), CAST(N'2017-07-29T12:39:25.250' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (329, 2, N'588-876', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: al 1.5 (amplatz left)', N'Pieza', N'54', N'C-26', CAST(N'2017-07-29T12:39:44.870' AS DateTime), CAST(N'2017-07-29T12:39:42.767' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (330, 2, N'588-844', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: al 2 (amplatz left)', N'Pieza', N'55', N'C-27', CAST(N'2017-07-29T12:40:12.797' AS DateTime), CAST(N'2017-07-29T12:44:21.970' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (331, 2, N'588-849', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: al 3 (amplatz left)', N'Pieza', N'55', N'C-27', CAST(N'2017-07-29T12:40:24.000' AS DateTime), CAST(N'2017-07-29T12:44:11.857' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (332, 2, N'588-845', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: ar 1 (amplatz right)', N'Pieza', N'55', N'C-27', CAST(N'2017-07-29T12:40:49.933' AS DateTime), CAST(N'2017-07-29T12:43:57.647' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (333, 2, N'588-846', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: ar 2 (amplatz right)', N'Pieza', N'55', N'C-27', CAST(N'2017-07-29T12:41:00.943' AS DateTime), CAST(N'2017-07-29T12:43:41.903' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (334, 2, N'588-829', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: xb 3 (extra backup)', N'Pieza', N'56', N'C-28', CAST(N'2017-07-29T12:53:50.607' AS DateTime), CAST(N'2017-07-29T12:53:48.503' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (335, 2, N'588-882', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: xb 3.5 (extra backup)', N'Pieza', N'56', N'C-28', CAST(N'2017-07-29T12:54:08.980' AS DateTime), CAST(N'2017-07-29T12:54:06.880' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (336, 2, N'588-894', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: xb 4 (extra backup)', N'Pieza', N'56', N'C-28', CAST(N'2017-07-29T12:54:57.930' AS DateTime), CAST(N'2017-07-29T12:54:55.827' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (337, 2, N'588-898', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: xb 4.5 (extra backup)', N'Pieza', N'56', N'C-28', CAST(N'2017-07-29T12:56:52.553' AS DateTime), CAST(N'2017-07-29T12:56:50.447' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (338, 2, N'588-8100', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: xblad 3.5 (extra backup)', N'Pieza', N'56', N'C-28', CAST(N'2017-07-29T12:57:53.110' AS DateTime), CAST(N'2017-07-29T12:57:51.007' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (339, 2, N'588-8101', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: xblad 4 (extra backup)', N'Pieza', N'56', N'C-28', CAST(N'2017-07-29T12:58:14.187' AS DateTime), CAST(N'2017-07-29T12:58:12.087' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (340, 2, N'588-8102', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: xblad 4.5 (extra backup)', N'Pieza', N'56', N'C-28', CAST(N'2017-07-29T12:58:27.577' AS DateTime), CAST(N'2017-07-29T12:58:25.473' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (341, 2, N'588-841', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: hockey stick', N'Pieza', N'56', N'C-28', CAST(N'2017-07-29T12:58:47.870' AS DateTime), CAST(N'2017-07-29T12:58:45.767' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (342, 2, N'588-817', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia:im (internal mammary)', N'Pieza', N'56', N'C-28', CAST(N'2017-07-29T12:59:05.273' AS DateTime), CAST(N'2017-07-29T13:13:35.987' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (343, 2, N'588-812', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: jl 3 (judkins left)', N'Pieza', N'57', N'C-29', CAST(N'2017-07-29T13:14:14.150' AS DateTime), CAST(N'2017-07-29T13:14:12.047' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (344, 2, N'588-851', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: jl 3.5 (judkins left)', N'Pieza', N'57', N'C-29', CAST(N'2017-07-29T13:14:28.487' AS DateTime), CAST(N'2017-07-29T13:14:26.383' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (345, 2, N'588-823', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: jl 4 (judkins left)', N'Pieza', N'58', N'C-30', CAST(N'2017-07-29T13:15:03.493' AS DateTime), CAST(N'2017-07-29T13:15:01.390' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (346, 2, N'588-852', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: jl 4.5 (judkins left)', N'Pieza', N'58', N'C-30', CAST(N'2017-07-29T13:15:19.210' AS DateTime), CAST(N'2017-07-29T13:15:17.107' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (347, 2, N'588-853', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: jl 5 (judkins left)', N'Pieza', N'58', N'C-30', CAST(N'2017-07-29T13:15:32.767' AS DateTime), CAST(N'2017-07-29T13:15:30.660' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (348, 2, N'588-854', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: jl 6 (judkins left)', N'Pieza', N'58', N'C-30', CAST(N'2017-07-29T13:15:44.440' AS DateTime), CAST(N'2017-07-29T13:15:42.337' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (349, 2, N'588-855', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: jr 3.5 (judkins right)', N'Pieza', N'59', N'C-31', CAST(N'2017-07-29T13:16:37.013' AS DateTime), CAST(N'2017-07-29T13:16:34.910' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (350, 2, N'588-830', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: jr 4 (judkins right)', N'Pieza', N'59', N'C-31', CAST(N'2017-07-29T13:17:00.337' AS DateTime), CAST(N'2017-07-29T13:16:58.237' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (351, 2, N'588-856', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: jr 5 (judkins right)', N'Pieza', N'59', N'C-31', CAST(N'2017-07-29T13:17:19.577' AS DateTime), CAST(N'2017-07-29T13:17:17.480' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (352, 2, N'588-857', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: jr 6 (judkins right)', N'Pieza', N'59', N'C-31', CAST(N'2017-07-29T13:17:34.130' AS DateTime), CAST(N'2017-07-29T13:17:32.033' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (353, 2, N'588-815', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: lcb (left coronary bypass)', N'Pieza', N'59', N'C-31', CAST(N'2017-07-29T13:17:58.913' AS DateTime), CAST(N'2017-07-29T13:17:56.817' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (354, 2, N'588-842', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: mpa 1 (multiproposito a)', N'Pieza', N'60', N'C-32', CAST(N'2017-07-29T13:20:26.773' AS DateTime), CAST(N'2017-07-29T13:20:24.670' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (355, 2, N'588-886', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: mpb 1 (multiproposito b)', N'Pieza', N'60', N'C-32', CAST(N'2017-07-29T13:20:46.240' AS DateTime), CAST(N'2017-07-29T13:20:44.143' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (356, 2, N'588-816', N'Vista brite tip - cateteres guia - 8fr 
longitud: 100 cm
morfologia: rcb (right coronary bypass)', N'Pieza', N'60', N'C-32', CAST(N'2017-07-29T13:21:18.787' AS DateTime), CAST(N'2017-07-29T13:21:16.683' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (357, 2, N'588-843T', N'Vista brite tip - cateteres guia - 8fr 
longitud: 90 cm
morfologia: al 1 (amplatz left)', N'Pieza', N'61', N'C-33', CAST(N'2017-08-02T11:18:29.937' AS DateTime), CAST(N'2017-08-02T11:18:26.153' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (358, 2, N'588-844T', N'Vista brite tip - cateteres guia - 8fr 
longitud: 90 cm
morfologia: al 2 (amplatz left)', N'Pieza', N'61', N'C-33', CAST(N'2017-08-02T11:18:42.367' AS DateTime), CAST(N'2017-08-02T11:18:38.607' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (359, 2, N'588-845T', N'Vista brite tip - cateteres guia - 8fr 
longitud: 90 cm
morfologia: ar 2 (amplatz right)', N'Pieza', N'61', N'C-33', CAST(N'2017-08-02T11:19:01.557' AS DateTime), CAST(N'2017-08-02T11:18:57.797' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (360, 2, N'588-841T', N'Vista brite tip - cateteres guia - 8fr 
longitud: 90 cm
morfologia: hockey stick', N'Pieza', N'61', N'C-33', CAST(N'2017-08-02T11:19:25.577' AS DateTime), CAST(N'2017-08-02T11:19:21.817' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (361, 2, N'588-801', N'Vista brite tip - cateteres guia - 8fr 
longitud: 90 cm
morfologia: im (internal mammary)', N'Pieza', N'61', N'C-33', CAST(N'2017-08-02T11:19:47.003' AS DateTime), CAST(N'2017-08-02T11:19:43.243' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (362, 2, N'588-851T', N'Vista brite tip - cateteres guia - 8fr 
longitud: 90 cm
morfologia: jl 3.5 (judkins left)', N'Pieza', N'61', N'C-33', CAST(N'2017-08-02T11:20:11.537' AS DateTime), CAST(N'2017-08-02T11:20:07.773' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (363, 2, N'588-823T', N'Vista brite tip - cateteres guia - 8fr 
longitud: 90 cm
morfologia: jl 4 (judkins left)', N'Pieza', N'61', N'C-33', CAST(N'2017-08-02T11:20:27.207' AS DateTime), CAST(N'2017-08-02T11:20:23.443' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (364, 2, N'588-830T', N'Vista brite tip - cateteres guia - 8fr 
longitud: 90 cm
morfologia: jr 4 (judkins right)', N'Pieza', N'61', N'C-33', CAST(N'2017-08-02T11:20:44.933' AS DateTime), CAST(N'2017-08-02T11:20:41.177' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (365, 2, N'588-815T', N'Vista brite tip - cateteres guia - 8fr 
longitud: 90 cm
morfologia: lcb (left coronary bypass)', N'Pieza', N'61', N'C-33', CAST(N'2017-08-02T11:21:09.513' AS DateTime), CAST(N'2017-08-02T11:21:05.753' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (366, 2, N'588-842P', N'Vista brite tip - cateteres guia - 8fr 
longitud: 90 cm
morfologia: mpa 1 (multiproposito a)', N'Pieza', N'61', N'C-33', CAST(N'2017-08-02T11:21:29.477' AS DateTime), CAST(N'2017-08-02T11:21:25.717' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (367, 2, N'588-816T', N'Vista brite tip - cateteres guia - 8fr 
longitud: 90 cm
morfologia: rcb (right coronary bypass)', N'Pieza', N'61', N'C-33', CAST(N'2017-08-02T11:22:02.120' AS DateTime), CAST(N'2017-08-02T11:21:58.363' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (368, 2, N'588-880', N'Vista brite tip - cateteres guia - 8fr 
longitud: 90 cm
morfologia: son 1 ', N'Pieza', N'61', N'C-33', CAST(N'2017-08-02T11:22:22.593' AS DateTime), CAST(N'2017-08-02T11:22:18.833' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (369, 2, N'598-943', N'Vista brite tip - cateteres guia - 9fr 
longitud: 98 cm
morfologia: al 1 (amplatz left)', N'Pieza', N'62', N'C-34', CAST(N'2017-08-02T11:23:13.027' AS DateTime), CAST(N'2017-08-02T11:23:09.263' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (370, 2, N'598-944', N'Vista brite tip - cateteres guia - 9fr 
longitud: 98 cm
morfologia: al 2 (amplatz left)', N'Pieza', N'62', N'C-34', CAST(N'2017-08-02T11:23:24.603' AS DateTime), CAST(N'2017-08-02T11:23:20.843' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (371, 2, N'598-945', N'Vista brite tip - cateteres guia - 9fr 
longitud: 98 cm
morfologia: ar 1 (amplatz right)', N'Pieza', N'63', N'C-35', CAST(N'2017-08-02T11:24:02.510' AS DateTime), CAST(N'2017-08-02T11:23:58.750' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (372, 2, N'598-937', N'Vista brite tip - cateteres guia - 9fr 
longitud: 98 cm
morfologia: ar 2 sh (amplatz right, orificios laterales)', N'Pieza', N'63', N'C-35', CAST(N'2017-08-02T11:24:26.950' AS DateTime), CAST(N'2017-08-02T11:24:23.190' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (373, 2, N'598-941', N'Vista brite tip - cateteres guia - 9fr 
longitud: 98 cm
morfologia: hockey stick', N'Pieza', N'63', N'C-35', CAST(N'2017-08-02T11:24:49.090' AS DateTime), CAST(N'2017-08-02T11:24:45.327' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (374, 2, N'598-917', N'Vista brite tip - cateteres guia - 9fr 
longitud: 98 cm
morfologia: im (internal mammary)', N'Pieza', N'63', N'C-35', CAST(N'2017-08-02T11:26:36.333' AS DateTime), CAST(N'2017-08-02T11:26:32.573' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (375, 2, N'598-951', N'Vista brite tip - cateteres guia - 9fr 
longitud: 98 cm
morfologia: jl 3.5 (judkins left)', N'Pieza', N'64', N'C-36', CAST(N'2017-08-02T11:27:14.493' AS DateTime), CAST(N'2017-08-02T11:27:10.730' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (376, 2, N'598-923', N'Vista brite tip - cateteres guia - 9fr 
longitud: 98 cm
morfologia: jl 4 (judkins left)', N'Pieza', N'64', N'C-36', CAST(N'2017-08-02T11:28:38.210' AS DateTime), CAST(N'2017-08-02T11:28:34.450' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (377, 2, N'598-952', N'Vista brite tip - cateteres guia - 9fr 
longitud: 98 cm
morfologia: jl 4.5 (judkins left)', N'Pieza', N'64', N'C-36', CAST(N'2017-08-02T11:29:17.960' AS DateTime), CAST(N'2017-08-02T11:29:14.197' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (378, 2, N'598-955', N'Vista brite tip - cateteres guia - 9fr 
longitud: 98 cm
morfologia: jr 3.5 (judkins right)', N'Pieza', N'65', N'C-37', CAST(N'2017-08-02T11:37:13.430' AS DateTime), CAST(N'2017-08-02T11:37:09.667' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (379, 2, N'598-930', N'Vista brite tip - cateteres guia - 9fr 
longitud: 98 cm
morfologia: jr 4 (judkins right)', N'Pieza', N'65', N'C-37', CAST(N'2017-08-02T11:37:31.583' AS DateTime), CAST(N'2017-08-02T11:37:27.823' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (380, 2, N'598-915', N'Vista brite tip - cateteres guia - 9fr 
longitud: 98 cm
morfologia: lcb (left coronary bypass)', N'Pieza', N'65', N'C-37', CAST(N'2017-08-02T11:37:51.753' AS DateTime), CAST(N'2017-08-02T11:37:47.993' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (381, 2, N'598-942', N'Vista brite tip - cateteres guia - 9fr 
longitud: 98 cm
morfologia: mpa 1 (multiproposito a)', N'Pieza', N'65', N'C-37', CAST(N'2017-08-02T11:38:18.177' AS DateTime), CAST(N'2017-08-02T11:38:14.413' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (382, 2, N'598-986', N'Vista brite tip - cateteres guia - 9fr 
longitud: 98 cm
morfologia: mpb 1 (multiproposito b)', N'Pieza', N'65', N'C-37', CAST(N'2017-08-02T11:38:40.723' AS DateTime), CAST(N'2017-08-02T11:38:36.970' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (383, 2, N'598-916', N'Vista brite tip - cateteres guia - 9fr 
longitud: 98 cm
morfologia: rcb (right coronary bypass)', N'Pieza', N'65', N'C-37', CAST(N'2017-08-02T11:39:10.977' AS DateTime), CAST(N'2017-08-02T11:39:07.217' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (384, 2, N'595-014', N'Atw - alambres guia, 
diametro inch: .014" 
longitud total: 195 cm
flexibilidad de la punta: floppy 
forma de la punta: recta ', N'Pieza', N'69', N'D-1', CAST(N'2017-08-02T11:47:26.980' AS DateTime), CAST(N'2017-08-02T11:47:50.873' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (385, 2, N'595-J014', N'Atw - alambres guia, 
diametro inch: .014" 
longitud total: 195 cm
flexibilidad de la punta: floppy 
forma de la punta: en "j"', N'Pieza', N'69', N'D-1', CAST(N'2017-08-02T11:49:03.523' AS DateTime), CAST(N'2017-08-02T11:48:59.660' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (386, 2, N'595-X014', N'Atw - alambres guia, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: floppy 
forma de la punta: recta', N'Pieza', N'69', N'D-1', CAST(N'2017-08-02T11:49:27.620' AS DateTime), CAST(N'2017-08-02T11:49:23.753' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (387, 2, N'595-Y014', N'Atw - alambres guia, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: floppy 
forma de la punta: en "j"', N'Pieza', N'69', N'D-1', CAST(N'2017-08-02T11:49:47.450' AS DateTime), CAST(N'2017-08-02T11:49:43.590' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (388, 2, N'595-M014', N'Atw - alambres guia con marcadores, 
diametro inch: .014" 
longitud total: 195 cm
flexibilidad de la punta: floppy 
forma de la punta: recta', N'Pieza', N'70', N'D-2', CAST(N'2017-08-02T11:55:15.923' AS DateTime), CAST(N'2017-08-02T11:55:23.463' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (389, 2, N'595-MJ014', N'Atw - alambres guia con marcadores, 
diametro inch: .014" 
longitud total: 195 cm
flexibilidad de la punta: floppy 
forma de la punta: en "j"', N'Pieza', N'70', N'D-2', CAST(N'2017-08-02T11:56:11.453' AS DateTime), CAST(N'2017-08-02T11:56:07.590' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (390, 2, N'595-MX014', N'Atw - alambres guia con marcadores, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: floppy 
forma de la punta: recta', N'Pieza', N'70', N'D-2', CAST(N'2017-08-02T11:57:03.050' AS DateTime), CAST(N'2017-08-02T11:56:59.183' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (391, 2, N'595-MY014', N'Atw - alambres guia con marcadores, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: floppy 
forma de la punta: en "j"', N'Pieza', N'70', N'D-2', CAST(N'2017-08-02T11:57:23.223' AS DateTime), CAST(N'2017-08-02T11:57:19.360' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (392, 2, N'512-143', N'Wizdom alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 180 cm
flexibilidad de la punta: super suave  
forma de la punta: recta', N'Pieza', N'71', N'D-3', CAST(N'2017-08-02T11:59:42.210' AS DateTime), CAST(N'2017-08-02T12:00:53.780' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (393, 2, N'512-143J', N'Wizdom alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 180 cm
flexibilidad de la punta: super suave  
forma de la punta: en "j"', N'Pieza', N'71', N'D-3', CAST(N'2017-08-02T12:00:08.387' AS DateTime), CAST(N'2017-08-02T12:00:58.957' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (394, 2, N'512-143X', N'Wizdom alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: super suave  
forma de la punta: recta', N'Pieza', N'71', N'D-3', CAST(N'2017-08-02T12:00:25.077' AS DateTime), CAST(N'2017-08-02T12:01:05.190' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (395, 2, N'512-143Y', N'Wizdom alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: super suave  
forma de la punta: en "j"', N'Pieza', N'71', N'D-3', CAST(N'2017-08-02T12:00:43.380' AS DateTime), CAST(N'2017-08-02T12:01:10.963' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (396, 2, N'512-142', N'Wizdom alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 180 cm
flexibilidad de la punta: suave
forma de la punta: recta', N'Pieza', N'71', N'D-3', CAST(N'2017-08-02T12:02:24.360' AS DateTime), CAST(N'2017-08-02T12:02:22.893' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (397, 2, N'512-142J', N'Wizdom alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 180 cm
flexibilidad de la punta: suave
forma de la punta: en "j"', N'Pieza', N'71', N'D-3', CAST(N'2017-08-02T12:02:46.180' AS DateTime), CAST(N'2017-08-02T12:02:44.713' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (398, 2, N'512-142X', N'Wizdom alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: suave
forma de la punta: recta', N'Pieza', N'71', N'D-3', CAST(N'2017-08-02T12:03:04.030' AS DateTime), CAST(N'2017-08-02T12:03:02.563' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (399, 2, N'512-142Y', N'Wizdom alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: suave
forma de la punta: en "j"', N'Pieza', N'71', N'D-3', CAST(N'2017-08-02T12:03:18.313' AS DateTime), CAST(N'2017-08-02T12:03:16.847' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (400, 2, N'512-114', N'Wizdom alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 180 cm
flexibilidad de la punta: floppy
forma de la punta: recta', N'Pieza', N'72', N'D-4', CAST(N'2017-08-02T12:13:24.630' AS DateTime), CAST(N'2017-08-02T12:13:23.163' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (401, 2, N'512-114J', N'Wizdom alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 180 cm
flexibilidad de la punta: floppy
forma de la punta: en "j"', N'Pieza', N'72', N'D-4', CAST(N'2017-08-02T12:13:42.617' AS DateTime), CAST(N'2017-08-02T12:13:41.150' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (402, 2, N'512-114X', N'Wizdom alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: floppy
forma de la punta: recta', N'Pieza', N'72', N'D-4', CAST(N'2017-08-02T12:14:01.920' AS DateTime), CAST(N'2017-08-02T12:14:00.450' AS DateTime))
GO
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (403, 2, N'512-114Y', N'Wizdom alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: floppy
forma de la punta: en "j"', N'Pieza', N'72', N'D-4', CAST(N'2017-08-02T12:15:38.683' AS DateTime), CAST(N'2017-08-02T12:15:37.220' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (404, 2, N'507-914', N'Stabilizer alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 180 cm
flexibilidad de la punta: super suave
forma de la punta: recta', N'Pieza', N'73', N'D-5', CAST(N'2017-08-02T12:19:50.173' AS DateTime), CAST(N'2017-08-02T12:19:48.707' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (405, 2, N'507-914J', N'Stabilizer alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 180 cm
flexibilidad de la punta: super suave
forma de la punta: jota', N'Pieza', N'73', N'D-5', CAST(N'2017-08-02T12:20:26.413' AS DateTime), CAST(N'2017-08-02T12:20:24.947' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (406, 2, N'507-914X', N'Stabilizer alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: super suave
forma de la punta: recta', N'Pieza', N'73', N'D-5', CAST(N'2017-08-02T12:22:13.917' AS DateTime), CAST(N'2017-08-02T12:22:12.453' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (407, 2, N'507-914Y', N'Stabilizer alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: super suave
forma de la punta: jota', N'Pieza', N'73', N'D-5', CAST(N'2017-08-02T12:22:26.023' AS DateTime), CAST(N'2017-08-02T12:22:24.557' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (408, 2, N'507-714', N'Stabilizer alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 180 cm
flexibilidad de la punta: suave
forma de la punta: recta', N'Pieza', N'73', N'D-5', CAST(N'2017-08-02T12:22:56.107' AS DateTime), CAST(N'2017-08-02T12:22:54.643' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (409, 2, N'507-714J', N'Stabilizer alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 180 cm
flexibilidad de la punta: suave
forma de la punta: jota', N'Pieza', N'73', N'D-5', CAST(N'2017-08-02T12:23:09.900' AS DateTime), CAST(N'2017-08-02T12:23:08.437' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (410, 2, N'507-714X', N'Stabilizer alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: suave
forma de la punta: recta', N'Pieza', N'73', N'D-5', CAST(N'2017-08-02T12:23:24.500' AS DateTime), CAST(N'2017-08-02T12:23:23.037' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (411, 2, N'507-714Y', N'Stabilizer alambres guia dirigibles, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: suave
forma de la punta: jota', N'Pieza', N'73', N'D-5', CAST(N'2017-08-02T12:23:39.123' AS DateTime), CAST(N'2017-08-02T12:23:37.660' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (412, 2, N'527-914', N'Stabilizer xs alambres guia dirigibles , 
diametro inch: .014" 
longitud total: 180 cm
flexibilidad de la punta: super suave
forma de la punta: recta', N'Pieza', N'74', N'D-6', CAST(N'2017-08-02T12:30:21.110' AS DateTime), CAST(N'2017-08-02T12:30:19.647' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (413, 2, N'527-914J', N'Stabilizer xs alambres guia dirigibles , 
diametro inch: .014" 
longitud total: 180 cm
flexibilidad de la punta: super suave
forma de la punta: jota', N'Pieza', N'74', N'D-6', CAST(N'2017-08-02T12:31:53.650' AS DateTime), CAST(N'2017-08-02T12:31:52.190' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (414, 2, N'527-914X', N'Stabilizer xs alambres guia dirigibles , 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: super suave
forma de la punta: recta', N'Pieza', N'74', N'D-6', CAST(N'2017-08-02T12:32:12.100' AS DateTime), CAST(N'2017-08-02T12:32:10.637' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (415, 2, N'527-914Y', N'Stabilizer xs alambres guia dirigibles , 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: super suave
forma de la punta: jota', N'Pieza', N'74', N'D-6', CAST(N'2017-08-02T12:32:25.547' AS DateTime), CAST(N'2017-08-02T12:32:24.087' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (416, 2, N'518-224', N'Stabilizer alambres guia dirigibles con marcadores, 
diametro inch: .014" 
longitud total: 180 cm
flexibilidad de la punta: super suave
forma de la punta: recta
marcadores: 6', N'Pieza', N'75', N'D-7', CAST(N'2017-08-02T12:37:37.753' AS DateTime), CAST(N'2017-08-02T12:37:36.290' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (417, 2, N'518-224J', N'Stabilizer alambres guia dirigibles con marcadores, 
diametro inch: .014" 
longitud total: 180 cm
flexibilidad de la punta: super suave
forma de la punta: jota
marcadores: 6', N'Pieza', N'75', N'D-7', CAST(N'2017-08-02T12:39:29.043' AS DateTime), CAST(N'2017-08-02T12:39:27.583' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (418, 2, N'518-224X', N'Stabilizer alambres guia dirigibles con marcadores, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: super suave
forma de la punta: recta
marcadores: 6', N'Pieza', N'75', N'D-7', CAST(N'2017-08-02T12:42:58.953' AS DateTime), CAST(N'2017-08-02T12:42:57.493' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (419, 2, N'518-224Y', N'Stabilizer alambres guia dirigibles con marcadores, 
diametro inch: .014" 
longitud total: 300 cm
flexibilidad de la punta: super suave
forma de la punta: jota
marcadores: 6', N'Pieza', N'75', N'D-7', CAST(N'2017-08-02T12:43:12.430' AS DateTime), CAST(N'2017-08-02T12:43:10.970' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (420, 2, N'547-114', N'Shinobi alambres guia dirigibles 
diametro inch: .014" 
longitud total: 180 cm
forma de la punta: recta', N'Pieza', N'76', N'D-8', CAST(N'2017-08-02T12:44:27.213' AS DateTime), CAST(N'2017-08-02T12:47:07.667' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (421, 2, N'547-114X', N'Shinobi alambres guia dirigibles 
diametro inch: .014" 
longitud total: 300 cm
forma de la punta: recta', N'Pieza', N'76', N'D-8', CAST(N'2017-08-02T12:44:44.210' AS DateTime), CAST(N'2017-08-02T12:47:03.503' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (422, 2, N'547-214', N'Shinobi plus alambres guia dirigibles 
diametro inch: .014" 
longitud total: 180 cm
forma de la punta: recta', N'Pieza', N'76', N'D-8', CAST(N'2017-08-02T12:46:13.170' AS DateTime), CAST(N'2017-08-02T12:46:49.193' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (423, 2, N'547-214X', N'Shinobi plus alambres guia dirigibles 
diametro inch: .014" 
longitud total: 300 cm
forma de la punta: recta', N'Pieza', N'76', N'D-8', CAST(N'2017-08-02T12:46:41.933' AS DateTime), CAST(N'2017-08-02T12:46:54.320' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (424, 2, N'SRD7057', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: rbl 4 (radial braquial) 
longitud: 100 cm', N'Pieza', N'88', N'E-8', CAST(N'2017-08-02T12:54:45.063' AS DateTime), CAST(N'2017-08-02T12:54:43.600' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (425, 2, N'SRD7058', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: rbl 5 (radial braquial) 
longitud: 100 cm', N'Pieza', N'88', N'E-8', CAST(N'2017-08-02T12:54:57.070' AS DateTime), CAST(N'2017-08-02T12:54:55.613' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (426, 2, N'538-430', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: son 1 (sones) 
longitud: 80 cm', N'Pieza', N'88', N'E-8', CAST(N'2017-08-02T12:55:27.930' AS DateTime), CAST(N'2017-08-02T12:55:26.470' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (427, 2, N'538-431', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: son 2 (sones) 
longitud: 80 cm', N'Pieza', N'88', N'E-8', CAST(N'2017-08-02T12:55:41.977' AS DateTime), CAST(N'2017-08-02T12:55:40.517' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (428, 2, N'538-418', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: jl 3.5 (judkins left) 
longitud: 100 cm', N'Pieza', N'88', N'E-8', CAST(N'2017-08-02T12:56:19.643' AS DateTime), CAST(N'2017-08-02T12:56:18.183' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (429, 2, N'538-420', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: jl 4 (judkins left) 
longitud: 100 cm', N'Pieza', N'88', N'E-8', CAST(N'2017-08-02T12:56:34.340' AS DateTime), CAST(N'2017-08-02T12:56:32.883' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (430, 2, N'538-417', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: jl 4.5 (judkins left) 
longitud: 100 cm', N'Pieza', N'89', N'E-9', CAST(N'2017-08-02T12:57:04.583' AS DateTime), CAST(N'2017-08-02T12:57:03.127' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (431, 2, N'538-422', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: jl 5 (judkins left) 
longitud: 100 cm', N'Pieza', N'89', N'E-9', CAST(N'2017-08-02T12:57:17.740' AS DateTime), CAST(N'2017-08-02T12:57:16.283' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (432, 2, N'538-424', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: jl 6 (judkins left) 
longitud: 100 cm.', N'Pieza', N'89', N'E-9', CAST(N'2017-08-02T12:58:20.030' AS DateTime), CAST(N'2017-08-14T12:28:40.953' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (433, 2, N'538-419', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: jr 3.5 (judkins right) 
longitud: 100 cm', N'Pieza', N'89', N'E-9', CAST(N'2017-08-02T12:59:25.253' AS DateTime), CAST(N'2017-08-02T12:59:23.793' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (434, 2, N'538-421', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: jr 4 (judkins right) 
longitud: 100 cm', N'Pieza', N'89', N'E-9', CAST(N'2017-08-02T12:59:47.600' AS DateTime), CAST(N'2017-08-02T12:59:46.140' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (435, 2, N'538-427', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: jr 4 st (judkins right, punta corta) 
longitud: 100 cm', N'Pieza', N'89', N'E-9', CAST(N'2017-08-02T13:00:06.593' AS DateTime), CAST(N'2017-08-02T13:00:05.133' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (436, 2, N'538-423', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: jr 5 (judkins right) 
longitud: 100 cm', N'Pieza', N'89', N'E-9', CAST(N'2017-08-02T13:00:33.003' AS DateTime), CAST(N'2017-08-02T13:00:31.543' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (437, 2, N'538-425', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: jr 6 (judkins right) 
longitud: 100 cm', N'Pieza', N'89', N'E-9', CAST(N'2017-08-02T13:00:49.710' AS DateTime), CAST(N'2017-08-02T13:00:48.253' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (438, 2, N'538-440', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: mpa 2 (multiproposito a)
longitud: 65 cm', N'Pieza', N'89', N'E-9', CAST(N'2017-08-02T13:01:43.627' AS DateTime), CAST(N'2017-08-02T13:01:42.170' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (439, 2, N'538-449', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: mpa 2 (multiproposito a)
longitud: 80 cm', N'Pieza', N'89', N'E-9', CAST(N'2017-08-02T13:01:56.373' AS DateTime), CAST(N'2017-08-02T13:01:54.920' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (440, 2, N'538-442', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: mpa 2 (multiproposito a)
longitud: 100 cm', N'Pieza', N'89', N'E-9', CAST(N'2017-08-02T13:02:10.807' AS DateTime), CAST(N'2017-08-02T13:02:09.343' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (441, 2, N'538-444', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: mpa 2 (multiproposito a)
longitud: 125 cm', N'Pieza', N'89', N'E-9', CAST(N'2017-08-02T13:02:21.177' AS DateTime), CAST(N'2017-08-02T13:02:19.720' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (442, 2, N'538-445', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: al 1 (amplatz left) 
longitud: 100 cm', N'Pieza', N'89', N'E-9', CAST(N'2017-08-02T13:02:55.977' AS DateTime), CAST(N'2017-08-02T13:02:54.517' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (443, 2, N'538-446', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: al 2 (amplatz left) 
longitud: 100 cm', N'Pieza', N'89', N'E-9', CAST(N'2017-08-02T13:03:11.430' AS DateTime), CAST(N'2017-08-02T13:03:09.977' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (444, 2, N'538-447', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: al 3 (amplatz left) 
longitud: 100 cm', N'Pieza', N'89', N'E-9', CAST(N'2017-08-02T13:03:21.187' AS DateTime), CAST(N'2017-08-02T13:03:19.727' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (445, 2, N'538-470', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: rcb (right coronary bypass) 
longitud: 100 cm', N'Pieza', N'90', N'E-10', CAST(N'2017-08-16T10:17:17.450' AS DateTime), CAST(N'2017-08-16T10:17:15.350' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (446, 2, N'538-472', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: lcb (left coronary bypass) 
longitud: 100 cm', N'Pieza', N'90', N'E-10', CAST(N'2017-08-16T10:17:35.133' AS DateTime), CAST(N'2017-08-16T10:17:33.043' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (447, 2, N'538-460', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: im (internal mammary)
longitud: 100 cm', N'Pieza', N'90', N'E-10', CAST(N'2017-08-16T10:18:31.503' AS DateTime), CAST(N'2017-08-16T10:18:29.413' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (448, 2, N'538-450E', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: pigtail 
8 orificios laterales
longitud: 110 cm', N'Pieza', N'90', N'E-10', CAST(N'2017-08-16T10:28:33.827' AS DateTime), CAST(N'2017-08-16T10:28:52.857' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (449, 2, N'538-450S', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: pigtail 
6 orificios laterales
longitud: 110 cm', N'Pieza', N'90', N'E-10', CAST(N'2017-08-16T10:28:48.737' AS DateTime), CAST(N'2017-08-16T10:28:46.653' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (450, 2, N'538-453S', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: pigtail 145°
6 orificios laterales
longitud: 110 cm', N'Pieza', N'90', N'E-10', CAST(N'2017-08-16T10:30:06.403' AS DateTime), CAST(N'2017-08-16T10:30:04.317' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (451, 2, N'538-455S', N'Infiniti 4f - cateteres diagnosticos  
estilo de curva: pigtail 155°
6 orificios laterales
longitud: 110 cm', N'Pieza', N'90', N'E-10', CAST(N'2017-08-16T10:30:24.137' AS DateTime), CAST(N'2017-08-16T10:30:22.057' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (452, 2, N'534-518T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: jl 3.5 (judkins left)
longitud: 100 cm', N'Pieza', N'92', N'E-12', CAST(N'2017-08-16T10:53:21.003' AS DateTime), CAST(N'2017-08-16T10:53:18.927' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (453, 2, N'534-520T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: jl 4 (judkins left)
longitud: 100 cm', N'Pieza', N'92', N'E-12', CAST(N'2017-08-16T10:53:33.080' AS DateTime), CAST(N'2017-08-16T10:53:31.003' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (454, 2, N'534-517T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: jl 4.5 (judkins left)
longitud: 100 cm', N'Pieza', N'92', N'E-12', CAST(N'2017-08-16T10:53:45.617' AS DateTime), CAST(N'2017-08-16T10:53:43.537' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (455, 2, N'534-522T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: jl 5 (judkins left)
longitud: 100 cm', N'Pieza', N'92', N'E-12', CAST(N'2017-08-16T10:54:15.090' AS DateTime), CAST(N'2017-08-16T10:54:13.010' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (456, 2, N'534-524T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: jl 6 (judkins left)
longitud: 100 cm', N'Pieza', N'92', N'E-12', CAST(N'2017-08-16T10:54:25.923' AS DateTime), CAST(N'2017-08-16T10:54:23.850' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (457, 2, N'534-519T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: jr 3.5 (judkins right)
longitud: 100 cm', N'Pieza', N'92', N'E-12', CAST(N'2017-08-16T10:56:31.060' AS DateTime), CAST(N'2017-08-16T10:56:28.980' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (458, 2, N'534-521T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: jr 4 (judkins right)
longitud: 100 cm', N'Pieza', N'92', N'E-12', CAST(N'2017-08-16T10:56:47.700' AS DateTime), CAST(N'2017-08-16T10:56:45.623' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (459, 2, N'534-523T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: jr 5 (judkins right)
longitud: 100 cm', N'Pieza', N'92', N'E-12', CAST(N'2017-08-16T10:57:08.200' AS DateTime), CAST(N'2017-08-16T10:57:06.120' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (460, 2, N'534-525T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: jr 6 (judkins right)
longitud: 100 cm', N'Pieza', N'92', N'E-12', CAST(N'2017-08-16T10:57:22.180' AS DateTime), CAST(N'2017-08-16T10:57:20.103' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (461, 2, N'534-540T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: mpa 2
longitud: 65 cm', N'Pieza', N'93', N'E-13', CAST(N'2017-08-16T11:00:04.940' AS DateTime), CAST(N'2017-08-16T11:00:02.863' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (462, 2, N'534-549T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: mpa 2
longitud: 80 cm', N'Pieza', N'93', N'E-13', CAST(N'2017-08-16T11:01:44.010' AS DateTime), CAST(N'2017-08-16T11:01:41.930' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (463, 2, N'534-542T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: mpa 2
longitud: 100 cm', N'Pieza', N'93', N'E-13', CAST(N'2017-08-16T11:01:56.773' AS DateTime), CAST(N'2017-08-16T11:01:54.690' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (464, 2, N'534-544T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: mpa 2
longitud: 125 cm', N'Pieza', N'93', N'E-13', CAST(N'2017-08-16T11:02:12.677' AS DateTime), CAST(N'2017-08-16T11:02:10.603' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (465, 2, N'534-539T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: mpb 
longitud: 100 cm', N'Pieza', N'93', N'E-13', CAST(N'2017-08-16T11:02:39.583' AS DateTime), CAST(N'2017-08-16T11:02:37.507' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (466, 2, N'534-541T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: ar1 mod (amplatz derecho)
longitud: 100 cm', N'Pieza', N'93', N'E-13', CAST(N'2017-08-16T11:03:35.293' AS DateTime), CAST(N'2017-08-16T11:03:33.220' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (467, 2, N'534-543T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: ar 2 mod (amplatz derecho)
longitud: 100 cm', N'Pieza', N'93', N'E-13', CAST(N'2017-08-16T11:03:48.610' AS DateTime), CAST(N'2017-08-16T11:03:46.533' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (468, 2, N'534-545T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: al 1 (amplatz izquierdo)
longitud: 100 cm', N'Pieza', N'93', N'E-13', CAST(N'2017-08-16T11:04:19.957' AS DateTime), CAST(N'2017-08-16T11:04:17.880' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (469, 2, N'534-546T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: al 2 (amplatz izquierdo)
longitud: 100 cm', N'Pieza', N'93', N'E-13', CAST(N'2017-08-16T11:05:07.683' AS DateTime), CAST(N'2017-08-16T11:05:05.607' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (470, 2, N'534-547T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: al 3 (amplatz izquierdo)
longitud: 100 cm', N'Pieza', N'93', N'E-13', CAST(N'2017-08-16T11:06:12.890' AS DateTime), CAST(N'2017-08-16T11:06:10.817' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (471, 2, N'534-560T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: im (internal mammary) 
longitud: 100 cm', N'Pieza', N'93', N'E-13', CAST(N'2017-08-16T11:06:36.580' AS DateTime), CAST(N'2017-08-16T11:06:34.507' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (472, 2, N'534-570T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: rcb (right coronary bypass) 
longitud: 100 cm', N'Pieza', N'94', N'E-14', CAST(N'2017-08-16T11:07:38.280' AS DateTime), CAST(N'2017-08-16T11:07:36.203' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (473, 2, N'534-572T', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: lcb (left coronary bypass) 
longitud: 100 cm', N'Pieza', N'94', N'E-14', CAST(N'2017-08-16T11:07:59.813' AS DateTime), CAST(N'2017-08-16T11:07:57.743' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (474, 2, N'534-550S', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: pig tail 
longitud: 110 cm', N'Pieza', N'94', N'E-14', CAST(N'2017-08-16T11:09:17.750' AS DateTime), CAST(N'2017-08-16T11:09:39.277' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (475, 2, N'534-552S', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: pig tail 145°
longitud: 110 cm', N'Pieza', N'94', N'E-14', CAST(N'2017-08-16T11:11:44.380' AS DateTime), CAST(N'2017-08-16T11:11:42.307' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (476, 2, N'534-554S', N'Infiniti 5f - cateteres diagnosticos  
estilo de curva: pig tail 155°
longitud: 110 cm', N'Pieza', N'94', N'E-14', CAST(N'2017-08-16T11:12:22.660' AS DateTime), CAST(N'2017-08-16T11:12:20.587' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (477, 2, N'SDR7048', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: rbl 4
longitud: 100 cm', N'Pieza', N'95', N'E-15', CAST(N'2017-08-16T11:15:21.003' AS DateTime), CAST(N'2017-08-16T11:15:18.927' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (478, 2, N'SDR7049', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: rbl 5
longitud: 100 cm', N'Pieza', N'95', N'E-15', CAST(N'2017-08-16T11:15:33.797' AS DateTime), CAST(N'2017-08-16T11:15:31.723' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (479, 2, N'SDR7064', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: rbl 4
longitud: 100 cm', N'Pieza', N'95', N'E-15', CAST(N'2017-08-16T11:16:26.163' AS DateTime), CAST(N'2017-08-16T11:16:24.093' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (480, 2, N'SDR7066', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: rbl 5
longitud: 100 cm', N'Pieza', N'95', N'E-15', CAST(N'2017-08-16T11:16:42.913' AS DateTime), CAST(N'2017-08-16T11:16:40.843' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (481, 2, N'SDR7073', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: rbl 4.5
longitud: 100 cm', N'Pieza', N'95', N'E-15', CAST(N'2017-08-16T11:16:58.430' AS DateTime), CAST(N'2017-08-16T11:16:56.360' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (482, 2, N'534-635T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: son 1
longitud: 100 cm', N'Pieza', N'95', N'E-15', CAST(N'2017-08-16T11:17:31.803' AS DateTime), CAST(N'2017-08-16T11:17:29.733' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (483, 2, N'534-637T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: son 2
longitud: 100 cm', N'Pieza', N'95', N'E-15', CAST(N'2017-08-16T11:17:41.170' AS DateTime), CAST(N'2017-08-16T11:17:39.097' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (484, 2, N'534-618T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: jl 3.5 (judkins left) 
longitud: 100 cm', N'Pieza', N'96', N'E-16', CAST(N'2017-08-16T11:19:36.307' AS DateTime), CAST(N'2017-08-16T11:19:34.230' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (485, 2, N'534-620T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: jl 4 (judkins left) 
longitud: 100 cm', N'Pieza', N'96', N'E-16', CAST(N'2017-08-16T11:20:47.783' AS DateTime), CAST(N'2017-08-16T11:20:45.710' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (486, 2, N'534-617T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: jl 4.5 (judkins left) 
longitud: 100 cm', N'Pieza', N'96', N'E-16', CAST(N'2017-08-16T11:21:12.347' AS DateTime), CAST(N'2017-08-16T11:21:10.273' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (487, 2, N'534-622T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: jl 5 (judkins left) 
longitud: 100 cm', N'Pieza', N'96', N'E-16', CAST(N'2017-08-16T11:21:25.723' AS DateTime), CAST(N'2017-08-16T11:21:23.657' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (488, 2, N'534-624T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: jl 6 (judkins left) 
longitud: 100 cm', N'Pieza', N'96', N'E-16', CAST(N'2017-08-16T11:22:05.903' AS DateTime), CAST(N'2017-08-16T11:22:03.833' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (489, 2, N'534-619T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: jr 3.5 (judkins right) 
longitud: 100 cm', N'Pieza', N'96', N'E-16', CAST(N'2017-08-16T11:29:32.197' AS DateTime), CAST(N'2017-08-16T11:29:30.127' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (490, 2, N'534-621T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: jr 4 (judkins right) 
longitud: 100 cm', N'Pieza', N'96', N'E-16', CAST(N'2017-08-16T11:29:46.763' AS DateTime), CAST(N'2017-08-16T11:29:44.697' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (491, 2, N'534-623T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: jr 5 (judkins right) 
longitud: 100 cm', N'Pieza', N'96', N'E-16', CAST(N'2017-08-16T11:30:29.293' AS DateTime), CAST(N'2017-08-16T11:30:27.223' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (492, 2, N'534-625T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: jr 6 (judkins right) 
longitud: 100 cm', N'Pieza', N'96', N'E-16', CAST(N'2017-08-16T11:30:45.493' AS DateTime), CAST(N'2017-08-16T11:30:43.427' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (493, 2, N'534-642T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: mpa 2  
longitud: 100 cm', N'Pieza', N'97', N'E-17', CAST(N'2017-08-16T11:32:04.763' AS DateTime), CAST(N'2017-08-16T11:32:02.697' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (494, 2, N'534-649T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: mpb 2  
longitud: 100 cm', N'Pieza', N'97', N'E-17', CAST(N'2017-08-16T11:32:25.473' AS DateTime), CAST(N'2017-08-16T11:34:32.750' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (495, 2, N'534-645T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: al 1 (amplatz left) 
longitud: 100 cm', N'Pieza', N'97', N'E-17', CAST(N'2017-08-16T11:34:25.177' AS DateTime), CAST(N'2017-08-16T11:34:23.110' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (496, 2, N'534-646T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: al 2 (amplatz left) 
longitud: 100 cm', N'Pieza', N'97', N'E-17', CAST(N'2017-08-16T11:36:50.760' AS DateTime), CAST(N'2017-08-16T11:36:48.697' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (497, 2, N'534-647T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: al 3 (amplatz left) 
longitud: 100 cm', N'Pieza', N'97', N'E-17', CAST(N'2017-08-16T11:37:41.733' AS DateTime), CAST(N'2017-08-16T11:37:39.670' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (498, 2, N'534-641T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: ar 1 mod (amplatz right) 
longitud: 100 cm', N'Pieza', N'97', N'E-17', CAST(N'2017-08-16T11:39:22.720' AS DateTime), CAST(N'2017-08-16T11:39:20.653' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (499, 2, N'534-643T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: ar 2 mod (amplatz right) 
longitud: 100 cm', N'Pieza', N'97', N'E-17', CAST(N'2017-08-16T11:39:39.120' AS DateTime), CAST(N'2017-08-16T11:39:37.053' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (500, 2, N'534-672T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: lcb (left coronary bypass) 
longitud: 100 cm', N'Pieza', N'97', N'E-17', CAST(N'2017-08-16T11:40:14.927' AS DateTime), CAST(N'2017-08-16T11:40:12.857' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (501, 2, N'534-670T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: rcb (right coronary bypass) 
longitud: 100 cm', N'Pieza', N'97', N'E-17', CAST(N'2017-08-16T11:40:31.780' AS DateTime), CAST(N'2017-08-16T11:40:29.720' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (502, 2, N'534-660T', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: im (internal mammary) 
longitud: 100 cm', N'Pieza', N'97', N'E-17', CAST(N'2017-08-16T11:41:07.773' AS DateTime), CAST(N'2017-08-16T11:41:05.703' AS DateTime))
GO
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (503, 2, N'534-650S', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: pigtail 
longitud: 110 cm', N'Pieza', N'98', N'E-18', CAST(N'2017-08-16T11:44:52.623' AS DateTime), CAST(N'2017-08-16T11:44:50.560' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (504, 2, N'534-652S', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: pigtail 145°
longitud: 110 cm', N'Pieza', N'98', N'E-18', CAST(N'2017-08-16T11:45:13.003' AS DateTime), CAST(N'2017-08-16T11:45:10.937' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (505, 2, N'534-654S', N'Infiniti 6f - cateteres diagnosticos  
estilo de curva: pigtail 155°
longitud: 110 cm', N'Pieza', N'98', N'E-18', CAST(N'2017-08-16T11:45:26.430' AS DateTime), CAST(N'2017-08-16T11:45:24.363' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (506, 2, N'533-635', N'Super torque 6f 
cateteres diagnosticos 
estilo de la curva: nih 
longitud: 80 cm', N'Pieza', N'103', N'E-23', CAST(N'2017-08-16T11:47:28.697' AS DateTime), CAST(N'2017-08-16T11:49:43.297' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (507, 2, N'504-604X', N'Avanti - introductores
french: 4 
longitud de la canula: 11 cm 
mini-guia: si 
', N'Pieza', N'123', N'F-1', CAST(N'2017-08-16T12:25:10.400' AS DateTime), CAST(N'2017-08-16T12:25:10.733' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (508, 2, N'504-605X', N'Avanti - introductores
french: 5 
longitud de la canula: 11 cm 
mini-guia: si 
', N'Pieza', N'123', N'F-1', CAST(N'2017-08-16T12:25:54.190' AS DateTime), CAST(N'2017-08-16T12:25:54.557' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (509, 2, N'504-606X', N'Avanti - introductores
french: 6 
longitud de la canula: 11 cm 
mini-guia: si 
', N'Pieza', N'123', N'F-1', CAST(N'2017-08-16T12:26:28.373' AS DateTime), CAST(N'2017-08-16T12:26:28.733' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (510, 2, N'504-607X', N'Avanti - introductores
french: 7 
longitud de la canula: 11 cm 
mini-guia: si 
', N'Pieza', N'124', N'F-2', CAST(N'2017-08-16T12:27:43.047' AS DateTime), CAST(N'2017-08-16T12:27:43.403' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (511, 2, N'504-608X', N'Avanti - introductores
french: 8 
longitud de la canula: 11 cm 
mini-guia: si 
', N'Pieza', N'124', N'F-2', CAST(N'2017-08-16T12:27:54.930' AS DateTime), CAST(N'2017-08-16T12:27:55.293' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (512, 2, N'504-609X', N'Avanti - introductores
french: 9 
longitud de la canula: 11 cm 
mini-guia: si 
', N'Pieza', N'124', N'F-2', CAST(N'2017-08-16T12:28:12.580' AS DateTime), CAST(N'2017-08-16T12:28:12.947' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (513, 2, N'504-604P', N'Avanti - introductores
french: 4 
longitud de la canula: 5.5 cm 
mini-guia: si 
', N'Pieza', N'126', N'F-4', CAST(N'2017-08-16T12:35:29.017' AS DateTime), CAST(N'2017-08-16T12:35:29.377' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (514, 2, N'504-605P', N'Avanti - introductores
french: 5 
longitud de la canula: 5.5 cm 
mini-guia: si 
', N'Pieza', N'126', N'F-4', CAST(N'2017-08-16T12:35:41.880' AS DateTime), CAST(N'2017-08-16T12:35:42.243' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (515, 2, N'504-606P', N'Avanti - introductores
french: 6 
longitud de la canula: 5.5 cm 
mini-guia: si 
', N'Pieza', N'126', N'F-4', CAST(N'2017-08-16T12:35:51.750' AS DateTime), CAST(N'2017-08-16T12:35:52.113' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (516, 2, N'504-604S', N'Avanti - introductores
french: 4 
longitud de la canula: 7.5 cm 
mini-guia: si (0.021")', N'Pieza', N'126', N'F-4', CAST(N'2017-08-16T12:36:20.753' AS DateTime), CAST(N'2017-08-16T12:36:21.120' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (517, 2, N'504-605S', N'Avanti - introductores
french: 5 
longitud de la canula: 7.5 cm 
mini-guia: si (0.021")', N'Pieza', N'126', N'F-4', CAST(N'2017-08-16T12:36:30.437' AS DateTime), CAST(N'2017-08-16T12:36:30.807' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (518, 2, N'504-606S', N'Avanti - introductores
french: 6 
longitud de la canula: 7.5 cm 
mini-guia: si (0.021")', N'Pieza', N'126', N'F-4', CAST(N'2017-08-16T12:36:39.490' AS DateTime), CAST(N'2017-08-16T12:36:39.857' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (519, 2, N'505615S', N'Radialsource - kit de acceso transradial 
french: 5 
longitud de vaina: 10 cm 
diametro interno de la vaina: 0.077"
diametro interno de la punta de la vaina: 0.072"
mini guia: 0.018"
longitud de la guia: 45 cm.', N'Kit', N'127', N'F-5', CAST(N'2017-08-16T12:37:38.383' AS DateTime), CAST(N'2017-08-16T12:46:16.470' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (520, 2, N'505615P', N'Radialsource - kit de acceso transradial 
french: 5 
longitud de vaina: 10 cm 
diametro interno de la vaina: 0.077"
diametro interno de la punta de la vaina: 0.072"
mini guia: 0.014"
longitud de la guia: 55 cm', N'Kit', N'127', N'F-5', CAST(N'2017-08-16T12:37:50.233' AS DateTime), CAST(N'2017-08-16T12:45:55.813' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (521, 2, N'505616S', N'Radialsource - kit de acceso transradial 
french: 6 
longitud de vaina: 10 cm 
diametro interno de la vaina: 0.088"
diametro interno de la punta de la vaina: 0.083"
mini guia: 0.018"
longitud de la guia: 45 cm', N'Kit', N'127', N'F-5', CAST(N'2017-08-16T12:38:04.890' AS DateTime), CAST(N'2017-08-16T12:46:05.553' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (522, 2, N'505616P', N'Radialsource - kit de acceso transradial 
french: 6 
longitud de vaina: 10 cm 
diametro interno de la vaina: 0.088"
diametro interno de la punta de la vaina: 0.083"
mini guia: 0.014"
longitud de la guia: 55 cm', N'Kit', N'127', N'F-5', CAST(N'2017-08-16T12:38:15.840' AS DateTime), CAST(N'2017-08-16T12:46:08.883' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (523, 2, N'502-521', N'Emerald - cables guia 
diametro: 0.035" 
longitud: 150 cm 
j radio: 3 
longiud de la punta flexible: 7 cm 
punta estandar', N'Pieza', N'135', N'G-1', CAST(N'2017-08-16T12:49:58.017' AS DateTime), CAST(N'2017-08-16T12:49:58.383' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (524, 2, N'502-524', N'Emerald - cables guia 
diametro: 0.025" 
longitud: 150 cm 
j radio: 3 
longiud de la punta flexible: 7 cm 
punta estandar', N'Pieza', N'135', N'G-1', CAST(N'2017-08-16T12:50:33.033' AS DateTime), CAST(N'2017-08-16T12:50:33.403' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (525, 2, N'502-587', N'Emerald - cables guia 
diametro: 0.035" 
longitud: 150 cm 
j radio: 3 
longiud de la punta flexible: 10 cm 
lt (newton)', N'Pieza', N'135', N'G-1', CAST(N'2017-08-16T12:51:13.180' AS DateTime), CAST(N'2017-08-16T12:52:12.060' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (526, 2, N'502-521F', N'Emerald - cables guia 
diametro: 0.035" 
longitud: 150 cm 
j radio: 3 
longiud de la punta flexible: 5 cm 
punta firme', N'Pieza', N'135', N'G-1', CAST(N'2017-08-16T12:53:02.640' AS DateTime), CAST(N'2017-08-16T12:53:03.007' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (527, 2, N'502-521E', N'Emerald - cables guia 
diametro: 0.035" 
longitud: 150 cm 
j radio: 3 
longiud de la punta flexible: 3 cm 
punta extra firme', N'Pieza', N'135', N'G-1', CAST(N'2017-08-16T12:53:39.677' AS DateTime), CAST(N'2017-08-16T12:53:40.047' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (528, 2, N'502-520', N'Emerald - cables guia 
diametro: 0.038" 
longitud: 150 cm 
j radio: 3 
longiud de la punta flexible: 7 cm 
punta estandar', N'Pieza', N'136', N'G-2', CAST(N'2017-08-18T10:29:11.140' AS DateTime), CAST(N'2017-08-18T10:29:08.897' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (529, 2, N'502-733', N'Emerald - cables guia 
diametro: 0.035" 
longitud: 180 cm 
j radio: 3 
longiud de la punta flexible: 8 cm 
amplatz super stiff', N'Pieza', N'136', N'G-2', CAST(N'2017-08-18T10:31:34.900' AS DateTime), CAST(N'2017-08-18T10:31:32.657' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (530, 2, N'502-703', N'Emerald - cables guia 
diametro: 0.021" 
longitud: 150 cm 
longiud de la punta flexible: 7 cm 
punta recta', N'Pieza', N'137', N'G-3', CAST(N'2017-08-18T10:34:32.113' AS DateTime), CAST(N'2017-08-18T10:34:29.873' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (531, 2, N'502-542', N'Emerald - cables guia 
diametro: 0.035" 
longitud: 150 cm 
longiud de la punta flexible: 7 cm 
punta estandar', N'Pieza', N'137', N'G-3', CAST(N'2017-08-18T10:36:00.583' AS DateTime), CAST(N'2017-08-18T10:35:58.307' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (532, 2, N'502-541', N'Emerald - cables guia 
diametro: 0.038" 
longitud: 150 cm 
longiud de la punta flexible: 7 cm 
punta estandar', N'Pieza', N'137', N'G-3', CAST(N'2017-08-18T10:36:31.807' AS DateTime), CAST(N'2017-08-18T10:36:29.567' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (533, 2, N'502-452', N'Emerald - cables guia 
diametro: 0.025" 
longitud: 260 cm 
j radio: 3 
longiud de la punta flexible: 7 cm 
punta estandar', N'Pieza', N'138', N'G-4', CAST(N'2017-08-18T10:39:54.277' AS DateTime), CAST(N'2017-08-18T10:39:52.037' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (534, 2, N'502-455', N'Emerald - cables guia 
diametro: 0.035" 
longitud: 260 cm 
j radio: 3 
longiud de la punta flexible: 7 cm 
punta estandar', N'Pieza', N'138', N'G-4', CAST(N'2017-08-18T10:41:11.863' AS DateTime), CAST(N'2017-08-18T10:41:09.627' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (535, 2, N'502-453', N'Emerald - cables guia 
diametro: 0.038" 
longitud: 260 cm 
j radio: 3 
longiud de la punta flexible: 7 cm 
punta estandar', N'Pieza', N'138', N'G-4', CAST(N'2017-08-18T10:42:35.820' AS DateTime), CAST(N'2017-08-18T10:42:33.583' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (536, 2, N'502-455F', N'Emerald - cables guia 
diametro: 0.035" 
longitud: 260 cm 
j radio: 3 
longiud de la punta flexible: 5 cm 
punta firme', N'Pieza', N'138', N'G-4', CAST(N'2017-08-18T10:43:29.950' AS DateTime), CAST(N'2017-08-18T10:43:27.650' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (537, 2, N'502-455E', N'Emerald - cables guia 
diametro: 0.035" 
longitud: 260 cm 
j radio: 3 
longiud de la punta flexible: 3 cm 
punta extra firme', N'Pieza', N'138', N'G-4', CAST(N'2017-08-18T10:43:55.217' AS DateTime), CAST(N'2017-08-18T10:43:52.957' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (538, 2, N'502-571A', N'Emerald - cables guia 
diametro: 0.035" 
longitud: 150 cm 
j radio: 3 
punta estandar', N'Pieza', N'140', N'G-6', CAST(N'2017-08-18T10:50:38.850' AS DateTime), CAST(N'2017-08-18T10:50:36.557' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (539, 2, N'502-570A', N'Emerald - cables guia 
diametro: 0.038" 
longitud: 150 cm 
j radio: 3 
punta extra firme', N'Pieza', N'140', N'G-6', CAST(N'2017-08-18T10:51:04.073' AS DateTime), CAST(N'2017-08-18T10:51:01.833' AS DateTime))
INSERT [dbo].[catalogos_claves_referencias] ([id_clave_catalogo], [id_catalogo_productos], [clave_ref_cod], [descripcion], [unidad_venta], [pagina_pdf], [pagina_cat], [creado_en], [actualizado_en]) VALUES (540, 2, N'504-300L', N'Pinzas de biopsia miocárdica de 2.3 mm, 7 fr., longitud de 104 cm femoral', N'Pieza', N'145', N'H-1', CAST(N'2017-08-18T10:53:14.930' AS DateTime), CAST(N'2017-08-18T10:53:12.693' AS DateTime))
SET IDENTITY_INSERT [dbo].[catalogos_claves_referencias] OFF
SET IDENTITY_INSERT [dbo].[catalogos_info_general] ON 

INSERT [dbo].[catalogos_info_general] ([id_catalogo], [tipo_catalogo], [nombre_catalogo], [publicacion], [spec_catalogo], [fabricante], [marca], [idioma], [dir_archivo], [creado_en], [actualizado_en]) VALUES (2, N'Catálogo', N'CARDIOLOGY PRODUCTS', 2012, N'Cirugia Cardiovascular', N'Johnson & Johnson', N'Cordis', N'Inglés', N'CAT_001_CARDIOLOGY PRODUCTS_CORDIS.pdf', CAST(N'2017-07-18' AS Date), CAST(N'2017-07-18' AS Date))
INSERT [dbo].[catalogos_info_general] ([id_catalogo], [tipo_catalogo], [nombre_catalogo], [publicacion], [spec_catalogo], [fabricante], [marca], [idioma], [dir_archivo], [creado_en], [actualizado_en]) VALUES (3, N'Catálogo', N'CARDIAC LEADS AND DELIVERY SYSTEMS', 2009, N'Cirugia Cardiovascular', N'MEDTRONIC', N'MEDTRONIC', N'Inglés', N'CAT_01_CARDIAC LEADS AND DELIVERY SYSTEMS.pdf', CAST(N'2017-07-18' AS Date), CAST(N'2017-07-21' AS Date))
INSERT [dbo].[catalogos_info_general] ([id_catalogo], [tipo_catalogo], [nombre_catalogo], [publicacion], [spec_catalogo], [fabricante], [marca], [idioma], [dir_archivo], [creado_en], [actualizado_en]) VALUES (7, N'Ficha Técnica', N'ENSURA DR MRI SureScan', 0, N'Marcapasos', N'MEDTRONIC', N'ENSURA', N'Español', N'CAT_02_ENSURA MRI SURESCAN_.pdf', CAST(N'2017-07-18' AS Date), CAST(N'2017-07-21' AS Date))
INSERT [dbo].[catalogos_info_general] ([id_catalogo], [tipo_catalogo], [nombre_catalogo], [publicacion], [spec_catalogo], [fabricante], [marca], [idioma], [dir_archivo], [creado_en], [actualizado_en]) VALUES (8, N'Brochure', N'GREATBATCH MEDICAL', 2010, N'Cirugia Cardiovascular', N'GREATBATCH MEDICAL', N'GREATBATCH', N'Español', N'CAT_01_GREATBATCH MEDICAL_INTRODUCTOR.pdf', CAST(N'2017-07-18' AS Date), CAST(N'2017-07-21' AS Date))
INSERT [dbo].[catalogos_info_general] ([id_catalogo], [tipo_catalogo], [nombre_catalogo], [publicacion], [spec_catalogo], [fabricante], [marca], [idioma], [dir_archivo], [creado_en], [actualizado_en]) VALUES (9, N'Ficha Técnica', N'SISTEMA DE ESTIMULACIÓN INGENIO', 2012, N'Marcapasos', N'BOSTON SCIENTIFIC', N'INGENIO', N'Español', N'CAT_02_INGENIO MRI SISTEMA DE ESTIMULACION_BOSTON.pdf', CAST(N'2017-07-18' AS Date), CAST(N'2017-07-21' AS Date))
INSERT [dbo].[catalogos_info_general] ([id_catalogo], [tipo_catalogo], [nombre_catalogo], [publicacion], [spec_catalogo], [fabricante], [marca], [idioma], [dir_archivo], [creado_en], [actualizado_en]) VALUES (10, N'Brochure', N'FINELINE II STEROX ELECTRODOS DE ESTIMULACION', 2010, N'Cirugia Cardiovascular', N'BOSTON SCIENTIFIC', N'FINELINE', N'Español', N'CAT_03_FINELINE II STEROX Y STEROX EZ_BOSTON.pdf', CAST(N'2017-07-18' AS Date), CAST(N'2017-07-21' AS Date))
SET IDENTITY_INSERT [dbo].[catalogos_info_general] OFF
SET IDENTITY_INSERT [dbo].[catalogos_traducciones] ON 

INSERT [dbo].[catalogos_traducciones] ([id_traduccion_cat], [id_catalogo_productos], [descripcion_corta], [claves_referencias], [dir_archivo], [creado_en], [actualizado_en]) VALUES (2, 2, N'TRADUCCION CORDIS COMPLETA
', NULL, N'CAT_001_CARDIOLOGY PRODUCTS_CORDIS_TRAD.pdf', CAST(N'2017-07-18T11:12:33.960' AS DateTime), CAST(N'2017-07-18T11:12:33.950' AS DateTime))
INSERT [dbo].[catalogos_traducciones] ([id_traduccion_cat], [id_catalogo_productos], [descripcion_corta], [claves_referencias], [dir_archivo], [creado_en], [actualizado_en]) VALUES (3, 3, N'CARDIAC LEADS AND DELIVERY SISTEMS', NULL, N'Label', CAST(N'2017-07-18T11:44:35.463' AS DateTime), CAST(N'2017-07-18T11:44:31.107' AS DateTime))
SET IDENTITY_INSERT [dbo].[catalogos_traducciones] OFF
SET IDENTITY_INSERT [dbo].[certificados_calidad] ON 

INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (3, N'766692015', N'ISO', N'Electrodos implantables, monitores, parches , productos relacionados', N'MEDTRONIC INC', CAST(N'2016-10-26T00:00:00.000' AS DateTime), CAST(N'2017-10-25T00:00:00.000' AS DateTime), N'Inglés', N'766692015 CFG Villalba_PR_(Exp 25-10-17)_O.pdf', N'766692015 CFG Villalba_PR_(Exp 25-10-17)_T.pdf', CAST(N'2017-07-29T10:13:11.570' AS DateTime), CAST(N'2017-07-29T10:13:08.170' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (4, N'1391622013', N'ISO', N'El presente certificado es válido para el alcance que se indica a continuación: 
la venta de servicios de maquila, incluyendo, pero no limitado, a la fabricación, prueba, distribución y servicio de ensamblajes pcb, ensamblajes de alto nivel y dispositivos médicos terminados. ', N'PLEXU CORP', CAST(N'2016-08-23T00:00:00.000' AS DateTime), CAST(N'2019-09-01T00:00:00.000' AS DateTime), N'Inglés', N'1391622013AQUSANA  ISO 13485-Plexus Corp. (Exp. 01Sep19).pdf', N'1391622013AQUSANA ISO 13485-Plexus (Exp 01Sep19)_T.pdf', CAST(N'2017-07-29T10:30:45.560' AS DateTime), CAST(N'2017-07-29T10:30:42.143' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (5, N'MD94974', N'ISO', N'El diseño y la fabricación de dispositivos vasculares y sistemas de carga y administración de la válvula cardiaca. La fabricación de sistemas de administración de marcapasos/ terapia cardiaca, sistemas de administración y stents biliares, dispositivos médicos no activos implantables y no implantables con sistemas de catéter e impregnación/ recubrimiento de fármaco para denervación renal. La carga y ensamblaje final de sistemas de marcapasos transcatéter. Suministro de servicios analíticos de prueba para las instalaciones/ sitios de medtronic corporation. ', N'MEDTRONIC IRELAND', CAST(N'2016-08-15T00:00:00.000' AS DateTime), CAST(N'2019-02-28T00:00:00.000' AS DateTime), N'Inglés', N'MD94974 ISO 13485 Irlanda_(Exp28Feb19).pdf', N'MD94974 ISO 13485 Irlanda_(Exp28Feb19)_T.PDF', CAST(N'2017-07-29T10:32:46.687' AS DateTime), CAST(N'2017-07-29T10:32:43.280' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (6, N'Q1N16123970901071', N'ISO', N'Diseño y desarrollo, producción y distribución de ipg para bradicardia y taquicardia, sistemas de administración de marcapasos, electrodos y accesorios ipg para bradicardia y taquicardia, sistemas/dispositivos de ablación, catéteres de diagnóstico y ablación y sus accesorios, programadores para aimd, software de aplicación (externa), marcapasos externos, sistemas de hardware y software para adquisición y gestión de ecg y datos de dispositivos cardiacos, sistemas implantables de monitoreo y registro, y mantenimiento de programadores para aimd, marcapasos externos y monitores externos del paciente ', N'MEDTRONIC INC', CAST(N'2017-01-01T00:00:00.000' AS DateTime), CAST(N'2019-12-31T00:00:00.000' AS DateTime), N'Inglés', N'Q1N16123970901071 ISO 13485 Mounds-Columbia (Exp. 31-Dic-19).pdf', N'Q1N16123970901071 ISO 13485 Mounds-Columbia (Exp. 31-Dic-19)_T.pdf', CAST(N'2017-07-29T10:35:08.780' AS DateTime), CAST(N'2017-07-29T10:35:05.373' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (7, N'Q2N16093970901058', N'ISO', N'Producción de dispositivos médicos activos 
implantables y terminales implantables para aimd', N'MEDTRONIC INC', CAST(N'2016-10-01T00:00:00.000' AS DateTime), CAST(N'2019-09-30T00:00:00.000' AS DateTime), N'Inglés', N'Q2N16093970901058  ISO Singapur (Exp. 30Sep19).pdf', N'Q2N16093970901058 ISO 13485 Singapur (Exp 30Sep19)_T.PDF', CAST(N'2017-07-29T10:40:14.750' AS DateTime), CAST(N'2017-07-29T10:40:11.343' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (8, N'Q2N17053970901082', N'ISO', N'Producción y distribución de electrodos para 
ipg de bradicardia, electrodos para icd de taquicardia, electrodos para tratamiento de insuficiencia cardiaca, electrodos para ipg musculares y neurológicos, catéteres de diagnóstico y ablación, 
accesorios para aimd ', N'MEDTRONIC INC', CAST(N'2017-06-01T00:00:00.000' AS DateTime), CAST(N'2020-05-31T00:00:00.000' AS DateTime), N'Inglés', N'Q2N17053970901082 ISO 13485 Villalba PR (Exp 31May20).pdf', N'Q2N17053970901082 ISO 13485 Villalba PR (Exp 31May20)_T.pdf', CAST(N'2017-07-29T10:42:14.080' AS DateTime), CAST(N'2017-07-29T10:42:10.680' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (9, N'UQA0959680C', N'ISO', N'Diseño y fabricación de los catéteres de crioablación, consolas, 
componentes de ecg y accesorios de recubrimiento. 
Servicio e instalación de consolas. ', N'METRONIC CRYOCATH LP', CAST(N'2015-04-01T00:00:00.000' AS DateTime), CAST(N'2018-01-31T00:00:00.000' AS DateTime), N'Inglés', N'UQA0959680C ISO13485 CMDCAS Pointe-Claire-Canada (Exp  31Mar18).pdf', N'UQA0959680C ISO 13485 CMDCAS Pointe-Claire-Canada (Exp31Mar18)_T.pdf', CAST(N'2017-07-29T10:46:18.257' AS DateTime), CAST(N'2017-07-29T10:46:14.853' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (10, N'C15/1127', N'CLV', N'Dispositivos medicos implantables activos.
Cateters', N'METRONIC IRELAND', CAST(N'2015-04-23T00:00:00.000' AS DateTime), CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'Inglés', N'C151127_CLV_Galway CRHF Products -  (Exp 23Abr20).pdf', N'C151127_CLV_ Galway CRHF Products -  (Exp23Abr20)_T.pdf', CAST(N'2017-07-29T11:26:15.577' AS DateTime), CAST(N'2017-07-29T11:27:15.583' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (12, N'1520333', N'CLV', N'Dispositivos implantables', N'METRONIC INC', CAST(N'2015-02-23T00:00:00.000' AS DateTime), CAST(N'2018-02-22T00:00:00.000' AS DateTime), N'Inglés', N'1520333_FSC  IPG''s Suiza (Exp 22Feb18).pdf', N'1520333_FSC  IPG''s Suiza (Exp 22Feb18)_T.PDF', CAST(N'2017-07-29T12:27:05.793' AS DateTime), CAST(N'2017-07-29T12:27:02.353' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (13, N'005383', N'CLV', N'Set coronarios', N'METRONIC IRELAND', CAST(N'2013-01-25T00:00:00.000' AS DateTime), CAST(N'2018-01-25T00:00:00.000' AS DateTime), N'Inglés', N'005383 - CLV Resolute Integrity (Exp. 25-01-2018).pdf', N'005383 - CLV Resolute Integrity (Exp. 25-01-2018)_T.pdf', CAST(N'2017-07-29T12:34:23.890' AS DateTime), CAST(N'2017-07-29T12:34:20.450' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (14, N'006490', N'CLV', N'Dispositivos medicos integrity rx', N'METRONIC IRELAND', CAST(N'2014-08-14T00:00:00.000' AS DateTime), CAST(N'2019-08-14T00:00:00.000' AS DateTime), N'Inglés', N'CFS006490 - CLV Integrity RX (Expires 14-Aug-2019)_O.pdf', N'CFS006490 - CLV Integrity RX (Expires 14-Aug-2019)_T.pdf', CAST(N'2017-07-29T12:37:47.673' AS DateTime), CAST(N'2017-07-29T12:37:44.200' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (15, N'1209-1-2016', N'FDA', N'Coaguladores
verificadores de temperatura
software de datos externos scanner , codigos de barra,
sistemas termicos de regulacion', N'METRONIC INC', CAST(N'2016-02-09T00:00:00.000' AS DateTime), CAST(N'2018-02-08T00:00:00.000' AS DateTime), N'Inglés', N'1209-1-2016 - CFG Perfusion II (Exp Feb 8, 2018).pdf', N'1209-1-2016 -.pdf', CAST(N'2017-07-29T12:53:46.833' AS DateTime), CAST(N'2017-07-29T12:53:43.403' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (16, N'FM534441', N'ISO', N'El diseño, desarrollo, fabricación y distribución de dispositivos médicos (y accesorios asociados) incluyendo angiografía, angioplastia y otros equipos de procedimiento / packs, catéteres angiográficos, catéteres vasculares, catéteres periféricos, que guían catéteres guías (con y sin recubrimiento), alambres de guía de oclusión, la inserción alambre guía herramientas, trócares, catéteres de hemodiálisis, obturadores titulares cortopunzantes, dispositivos introductores, dispositivos de inserción, dispositivos de par, sistemas de eliminación de residuos, dispositivos ras, dispositivos de administración / manejo de fluidos (incluyendo presión alta y baja - tubos, colectores, llaves de paso, válvulas) y kits, dilatadores, válvulas de hemostasia, monitores de presión y transductores (incluyendo electrónica), dispositivos de inflación (digitales y electrónicos), dispositivos de drenaje, dispositivos de administración de contraste (sistemas y kits), dispositivos de embolectomía, trampa dispositivos y accesorios, dispositivos de hemostasia, sistemas de inflado (analógica y sistemas digitales), dispositivos de infusión, agujas angiográficos, dispositivos de compresión, escalpelos, jeringas, traqueobronquiales y stent esofágico (y accesorios), los sistemas de stent biliar, guías endoscópicos, catéteres de globo sondas de coagulación bipolar, sistema de posicionamiento stent destinados a procedimientos intervencionistas coronarios o renales, catéteres de diálisis peritoneal, accesorios kits, partículas de embolización, y los componentes de los clientes no estéril especificado para los dispositivos médicos mínimamente invasivos. ', N'MERIT MEDICAL SYSTEMS', CAST(N'2014-12-22T00:00:00.000' AS DateTime), CAST(N'2017-12-21T00:00:00.000' AS DateTime), N'Inglés', N'06_ BSI-ISO-FM-534441-April-2-2014-ORIGINAL.pdf', N'06_ BSI-ISO-FM-534441-April-2-2014OK-TRADUCCION.pdf', CAST(N'2017-08-15T10:57:19.290' AS DateTime), CAST(N'2017-08-15T10:57:14.917' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (17, N'745004578', N'ISO', N'Para el diseño y desarrollo y fabricación de
dispositivos médicos para intervenciones periféricas, procedimientos quirúrgicos mínimamente invasivos, end.??scopy, gástrico, ginecológico, neurofisiológico, neurológico, quirúrgico, urológico, quirúrgico, quirúrgico, para el d1stnbut1on, el servico y la instalaci6n de dispositivos médicos', N'BOSTON SCIENTIFIC CORPORATION', CAST(N'2017-08-15T00:00:00.000' AS DateTime), CAST(N'2017-08-15T00:00:00.000' AS DateTime), N'Inglés', N'745004578 ISO-BOSTON-08OCT2017-ORIGINAL.pdf', N'BOSTON_CERTIFICADO_GENERAL_745004578- TRADUCCION.pdf', CAST(N'2017-08-15T11:11:32.860' AS DateTime), CAST(N'2017-08-15T11:11:28.600' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (18, N'242CE', N'ISO', N'Sistemas de drenaje de torax, sistemas y accesorios de monitoreo de la presion arterial fisiologica de los sitemas de drenaje incluyendo cables cardioplegia sistemas de tubos y conectores para bypass cardiopulmonar.', N'BIOMETRIX LIMITED', CAST(N'2013-06-15T00:00:00.000' AS DateTime), CAST(N'2018-06-14T00:00:00.000' AS DateTime), N'Español', N'BIOMETRIX_242CE-ORIGINAL.pdf', N'BIOMETRIX_242CE-ORIGINAL.pdf', CAST(N'2017-08-15T15:28:40.337' AS DateTime), CAST(N'2017-08-15T15:28:36.073' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (19, N'2128896', N'ISO', N'Catéteres ptca y accesorios ;
liberador de fármaco sistemas de stent coronarios y periféricos ; sistemas de stent coronario recubierto de drogas ; liberador de fármaco sistemas bifurcación de stents coronarios ;
sistemas de stent coronario ;
termodilución , arteria pulmonar , venosa central , los dispositivos de estimulación bipolar y embolectomía catéteres, sistemas de control de la presión
distribución de los globos liberadores de fármacos para aplicaciones coronarias y periféricas .
Incluyendo la compra y reventa de dispositivos y accesorios para vasculares coronaria y periférica aplicaciones.
Fabricación, almacenamiento, almacenamiento, distribución , instalación y mantenimiento de sistema de imágenes de spect
aplicaciones cardiacas .
El montaje y la distribución de kits de angiográficos y el procedimiento quirúrgico conjunto de catéter introducción', N'BIOSENSORS INTERNATIONAL GROUP LTD.', CAST(N'2015-10-01T00:00:00.000' AS DateTime), CAST(N'2018-10-01T00:00:00.000' AS DateTime), N'Inglés', N'BIOSENSORS _ISO_2128896-Original.pdf', N'BIOSENSORS _ISO_2128896-TRADUCCION.pdf', CAST(N'2017-08-15T15:38:53.350' AS DateTime), CAST(N'2017-08-15T15:38:49.170' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (20, N'CE554734', N'ISO', N'El diseño y la fabricación de catéteres de balón de dilatación, catéteres angiografos, guía de micro-catéteres, catéteres de imágenes coronarias y sistema de tomografía de coherencia óptica coronaria. ', N'TERUMO CORPORATION', CAST(N'2014-06-04T00:00:00.000' AS DateTime), CAST(N'2019-08-12T00:00:00.000' AS DateTime), N'Inglés', N'CE_554734_TERUMO_CERT OK.pdf', N'CE_554734_TERUMO_CERT OK - TRADUCCION.pdf', CAST(N'2017-08-15T15:43:32.003' AS DateTime), CAST(N'2017-08-15T15:43:27.817' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (21, N'556903', N'ISO', N'El diseño, desarrollo y fabricación de stents endo-y cardio -vasculares y biliares, stents liberadores 
de fármacos, filtros de la vena cava, catéteres intravasculares y gastrointestinales y accesorios 
directamente relacionados para aplicaciones de diagnóstico e intervención. ', N'CORDIS CASHEL ', CAST(N'2013-09-15T00:00:00.000' AS DateTime), CAST(N'2018-09-21T00:00:00.000' AS DateTime), N'Inglés', N'CE_554734_TERUMO_CERT OK.pdf', N'CE_554734_TERUMO_CERT OK - TRADUCCION.pdf', CAST(N'2017-08-15T15:47:44.170' AS DateTime), CAST(N'2017-08-15T15:47:40.000' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (22, N'CE631845', N'ISO', N'El diseño, desarrollo y fabricación de dispositivos de eliminación de trombos tejidos y mínimamente 
invasivas.', N'BAYER MEDICAL CARE INC.', CAST(N'2015-03-04T00:00:00.000' AS DateTime), CAST(N'2020-03-20T00:00:00.000' AS DateTime), N'Inglés', N'CE631845-ISO-BAYER-20MAR2020-tejidos minima mente invasivos y dispositivos para remover trombos.pdf', N'CE631845-ISO-BAYER-20MAR2020-tejidos minima mente invasivos y dispositivos para remover trombos - TRADUCCION.pdf', CAST(N'2017-08-15T17:28:00.153' AS DateTime), CAST(N'2017-08-15T17:27:55.903' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (23, N'FM84895', N'ISO', N'El diseño, el desarrollo, la fabricación, la esterilización y distribución interna de catéteres de imágenes por ultrasonidos, sistemas electrónicos de imágenes por ultrasonidos, cables de guía de medición de presión y flujo intravasculares, microcatéteres y sistemas electrónicos, hilos guía, cables para pacientes, dispositivos de retroceso y cubiertas estériles y filtro de vena cava implantable con sistema de entrega. Instalación y mantenimiento de sistemas electrónicos. ', N'VOLCANO CORPORATION', CAST(N'2016-05-06T00:00:00.000' AS DateTime), CAST(N'2019-02-28T00:00:00.000' AS DateTime), N'Español', N'FM84895 02_28_2018_CERTI MED VOLCANO_SIN MARCA-OK.pdf', N'FM84895 02_28_2018_CERTI MED VOLCANO_SIN MARCA-OK - TRADUCCION.pdf', CAST(N'2017-08-15T17:33:00.457' AS DateTime), CAST(N'2017-08-15T17:32:56.277' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (24, N'Q1N150344936008', N'ISO', N'Diseño y desarrollo, la producción y distribución de uso individual estéril y estéril no medical products 
para muestra de sangre, transfusión, inyección e infusióne alambres guias hidrofilicos. ', N'NIPRO MEDICAL INDUSTRIES LTD.', CAST(N'2015-08-01T00:00:00.000' AS DateTime), CAST(N'2018-07-31T00:00:00.000' AS DateTime), N'Inglés', N'NIPRO_Q1N 15 03 44936 008-OK.pdf', N'NIPRO_Q1N 15 03 44936 008-OK - traduccion.pdf', CAST(N'2017-08-17T10:54:31.170' AS DateTime), CAST(N'2017-08-17T10:54:30.237' AS DateTime))
INSERT [dbo].[certificados_calidad] ([id_certificado], [numero_identificador], [tipo], [descripcion_detallada], [fabricante], [fecha_emision], [fecha_vencimiento], [idioma], [dir_archivo], [dir_archivo_traduccion], [creado_en], [actualizado_en]) VALUES (25, N'Q1N141257470005', N'ISO', N'Diseño y desarrollo, pproducción y distribución de 
adhesivos quirúrgicos y dispositivos 
de entrega relevantes', N'GEM S.r.l.', CAST(N'2015-01-01T00:00:00.000' AS DateTime), CAST(N'2017-12-31T00:00:00.000' AS DateTime), N'Inglés', N'Q1N14125747000-ISO-GEM S.r.l.-31DIC2017-PEGAMENTOS QUIRURJICOS Y DISPOSITIVOS OK copia.pdf', N'Q1N14125747000-ISO-GEM S.r.l.-31DIC2017-PEGAMENTOS QUIRURJICOS Y DISPOSITIVOS OK trad.pdf', CAST(N'2017-08-17T11:10:31.067' AS DateTime), CAST(N'2017-08-17T11:10:30.143' AS DateTime))
SET IDENTITY_INSERT [dbo].[certificados_calidad] OFF
SET IDENTITY_INSERT [dbo].[cucop] ON 

INSERT [dbo].[cucop] ([id_cucop], [clave], [descripcion], [especialidad], [presentacion_tipo], [presentacion_cant], [presentacion_cont], [creado_en], [actualizado_en]) VALUES (1, N'S.C.C/B', N'Catéter diagnostico de cuerpo de nylon del segmento proximal a segmento distal, segunda capa de nylon no trenzado para flexibilidad y tercera capa de suave nylon opaco a la radiación, max de presión de 1200 psi, compatible con guía 0.038, cal 5 y 6 fr, longitud de 100 cm, morfología: judkin derecho, curva 3.5, 4.0, 4.5, 5.0. Y 6.0', N'Hemodinamia', N'Pieza', 1, N'Pieza', NULL, CAST(N'2017-08-17T12:12:59.397' AS DateTime))
INSERT [dbo].[cucop] ([id_cucop], [clave], [descripcion], [especialidad], [presentacion_tipo], [presentacion_cant], [presentacion_cont], [creado_en], [actualizado_en]) VALUES (2, N'S.C.C/B', N'Kit introductor para punción femoral de 1.65 mm, longitud de 11 cm contiene dilatador de vaina que facilita la entrada percutánea, introductor con válvula hemostática y mini guía corta de 0.097 mm de diámetro ', N'Hemodinamia', N'Pieza', 1, N'Pieza', NULL, CAST(N'2017-08-17T12:12:48.973' AS DateTime))
INSERT [dbo].[cucop] ([id_cucop], [clave], [descripcion], [especialidad], [presentacion_tipo], [presentacion_cant], [presentacion_cont], [creado_en], [actualizado_en]) VALUES (3, N'S.C.C/B', N'1 angiógrafo monoplanar para estudios hemodinámicos.
1.1 equipo monoplanar para procedimientos vasculares, neurovasculares y cardiovasculares, con un brazo en ""c "" suspendido al techo o montado a piso, de acuerdo a la configuración actual de la sala a sustituir.
1.2 generador de rayos x: generador convertidor de alta frecuencia de 100 kw o mayor controlado por microprocesador.
1.3 kilovoltaje seleccionable en el rango de 50 o menor a 125 kv o mayor
1.4 corriente del generador seleccionable de 10 ma o menor a 1000 ma o mayor.
1.5 potencia nominal (corriente eléctrica más alta): 100 kw.
1.6 tubo de rayos x, con cambio de rejilla y valores nominales, con al menos dos  punto focales de 0,4 mm y 0,7 mm (+/- 1 mm).
1.7 colimador vascular que combine un juego de obturadores horizontales y verticales, así como filtros cuneiformes independientes, los cuales se re-establezcan a su total campo de visión (fov) al toque de un botón.
1.8 cambio de rejilla en modalidad de fluoroscopía pulsada o por impulsos controlada por rejilla.
1.9 capacidad de almacenamiento térmico del ánodo: 2.4 mhu o mayor.
1.10 disipación de calor continua del sistema: 3200 watts o mayor.
1.11 con capacidad de disipación de calor por medio de una unidad de enfriamiento
1.12 detector de pantalla plana (flat panel) de 30 x 38 cm o 31 x 31 o 30 x 40 (+/- 1cm).
1.12.1 tamaño de píxeles: 200 µm o menor.
1.13 salida de vídeo digital y matriz de imagen de al menos 1024x1024 x14 bits.
1.13.1 velocidad de adquisición:
1.13.2 velocidad de adquisición variable como mínimo de 15 y 30 cuadros (o imágenes) por segundo o mayor, a 1024 x 1024 x 12 bits.
1.13.4 velocidad de rotación mínima: 0 - 20 °/s del brazo en c.
1.13.5 velocidad de angulación mínima: 0 - 18 °/s del brazo en c.
1.14 brazo en la cabecera de mesa con angulación de cran/caud (rotación) . 45°/45° ó mayor.
1.15 brazo en mesa que permita movimiento craneal de 185° o mayor  y caudal de 120° o mayor rao y lao a 90° o mayor.
1.16 con posicionamiento automático del arco a partir de una imagen adquirida para navegación en 3d
1.17 mesa del paciente:
1.18.1 longitud: 280 cm o mayor.
1.18.2 anchura: 50 cm o mayor
1.18.3 movimiento longitudinal.
1.18.4 movimiento transversal.
1.18.5 ajuste de altura.
1.18.6 soporte de paciente de al menos: 200 kg.+10kg o mayor para maniobras de rcp
1.19 al menos un monitor hd de 50 pulgadas o mayor con suspensión al techo, para la visualización de imágenes en tiempo real, cine, fluoroscopia, referencia, polígrafo, etc., de acuerdo al catálogo y recomendaciones del fabricante.
1.20 monitores en la sala de control: dos monitores de pantalla plana tipo lcd de 18 pulgadas para revisión, manejo de datos de paciente, preparación, adquisición, revisión, reportes, archivo, etc., cuando menos. De acuerdo al catalogo y recomendaciones del fabricante.
1.21 modulo o interface del usuario
1.21.1 interface de usuario con indicador de rayos x
1.21.2 con indicador de la temperatura del tubo
1.21.3 despliegue del tamaño del campo del detector
1.21.4 tiempo de fluoroscopia integrado
1.21.5 dosis de rayos x (tasa y dosis acumulado)
1.22 programas especializados para aplicaciones y mediciones cardiovasculares
1.23 paquete para cuantificación o análisis ventricular izquierdo y derecho con cálculo de la fracción de eyección, movimiento de pared por línea central o regional, gasto cardiaco.
1.24 paquete de cuantificación vascular con medición de índice de estenosis, análisis automático de vasos
1.25 paquete de cuantificación coronaria con medición de estenosis en las arterias coronarias, medición de diámetro a lo largo de segmento seleccionado, área seccional, valores de gradiente de presión.
1.26 realce de bordes del stent
1.27 programa de seguimiento de bolo con sustracción.
1.28 con función de sustracción de imágenes.
1.29 angiografía rotacional mediante el giro del arco en dos ejes simultáneamente. Con trayectorias pre-programadas. Trayectorias dedicadas para coronarias izquierda y derecha.
1.30 adquisición y reconstrucción de imágenes tridimensionales
1.31 transferencia al archivo de imágenes / estación externa (dicom).con  interfase de red ethernet 100/1000 base. Interfasedicom 3.0 con las siguientes clase de servicio habilitadas para su uso irrestricto:storage service class,query/retrieve,print management, media storage,worklist
1.32 estación de post-procesamiento de acuerdo a las especificaciones y catálogo del fabricante del angiógrafos.
1.32.1 con al menos un monitor a color de 18” o mayor con tecnología lcd o tft, grado diagnóstico de al menos 2 megapixeles.
1.32.2 paquete para generación y medición de imágenes 3d para angiografía.
1.32.3 superposición del modelo 3d en la fluoroscopia en tiempo real. 
1.32.4 programa especializado para aplicaciones y mediciones cardiovasculares
1.32.5 paquete para cuantificación o análisis ventricular izquierdo y derecho con cálculo de la fracción de eyección, movimiento de pared por línea central o regional, gasto cardiaco.
1.32.6 paquete de cuantificación vascular con medición de índice de estenosis, análisis automático de vasos
1.32.7 paquete de cuantificación coronaria con medición de estenosis en las arterias coronarias, medición de diámetro a lo largo de segmento seleccionado, área seccional, valores de gradiente de presión.
1.32.8 realce de bordes del stent (stent boost)
1.32.9 programa de seguimiento de bolo con sustracción.
1.32.10 interface y licencias dicom:  storage, worklist, query/retrieve, media storage.
1.32.11 interface con el sistema ris/pacs, designado por la unidad médica. 
1.33.1 software para planeación de tavi
1.34.1 software para perfusión
1.34 accesorios:
1.34.1 mampara de protección radiológica suspendida al techo y faldón de protección radiológica anexa a la mesa del paciente, de acuerdo al catálogo y recomendaciones del fabricante de la sala de hemodinamia.
1.34.6 con unidad de energía ininterrumpible ups en línea grado médico o que cumpla con las norma ul1778 y60601-1  con capacidad de respaldo de 10 minutos, se deberá de incluir alarma audiovisual en la sala que advierta la entrada de operación del ups
1.34.7 lámpara suspendida al techo de acuerdo a catálogo y recomendaciones del fabricante.
1.35 alimentación:
1.35.1 corriente eléctrica trifásica 380/480 volts, de acuerdo a especificaciones del fabricante a 60hz.
1.35.2 que no requiera más espacio para la instalación de todo el equipo y sus accesorios, que del que dispone la unidad médica asignada para estos fines.
1.35.3 el proveedor adjudicado deberá realizar un estudio de la línea eléctrica y tierras físicas, por una empresa certificada.
1.35.4 el proveedor adjudicado debe de realizar todas las adecuaciones necesarias (estructurales, albañilería, electricidad, iluminación, refrigeración, red de datos, gases medicinales, muros, protección radiológica, vidrio con protección radiológica, pisos, plafones, acabados, etc.), de acuerdo a los parámetros solicitados por el fabricante para el buen funcionamiento del cuarto de gabinetes, cuarto de control y sala de hemodinamia.
1.35.5 cumplir las normas oficiales mexicanas de protección radiológica, levantamiento de niveles, verificación y certificación radiológica de la sala de hemodinamia, de acuerdo a la nom-229-ssa1-2002.
1.35.6 realizar la certificación de protección radiológica a las salas de hemodinamia correspondientes, de acuerdo a la norma correspondiente, vigente, ante una empresa certificada para este rubro.
1.35.7 el proveedor adjudicado deberá realizar la instalación de todo el sistema solicitado
1.36 sistema de procesamiento digital de imágenes
1.36.1 con sustracción digital en tiempo real dsa, modo cine y modo mascara
1.36.2 capacidad de almacenamiento en disco duro de 100,000 imágenes o mayor a 1024x1024
1.36.3 con realce de bordes,brillo, contraste, inversion y reducción del ruido.
1.36.4 con sistema anti-artificios de movimiento durante dsa de tiempo real o algoritmo avanzado dedicado para reducir el ruido en imágenes clínicas.', N'Hemodinamia', N'Pieza', 1, N'Pieza', NULL, CAST(N'2017-08-01T14:54:52.510' AS DateTime))
SET IDENTITY_INSERT [dbo].[cucop] OFF
SET IDENTITY_INSERT [dbo].[cucop_vinculos] ON 

INSERT [dbo].[cucop_vinculos] ([id_vinculacion], [opcion], [id_cucop_item], [nombre], [creado_en], [actualizado_en]) VALUES (15, 1, 1, N'asd', CAST(N'2017-07-28T14:28:55.030' AS DateTime), CAST(N'2017-07-28T14:28:55.030' AS DateTime))
INSERT [dbo].[cucop_vinculos] ([id_vinculacion], [opcion], [id_cucop_item], [nombre], [creado_en], [actualizado_en]) VALUES (16, 2, 1, N'Probando', CAST(N'2017-08-01T16:54:42.640' AS DateTime), CAST(N'2017-08-01T16:54:42.637' AS DateTime))
INSERT [dbo].[cucop_vinculos] ([id_vinculacion], [opcion], [id_cucop_item], [nombre], [creado_en], [actualizado_en]) VALUES (17, 1, 3, N'Angiografo', CAST(N'2017-08-01T17:09:44.053' AS DateTime), CAST(N'2017-08-01T17:09:44.053' AS DateTime))
INSERT [dbo].[cucop_vinculos] ([id_vinculacion], [opcion], [id_cucop_item], [nombre], [creado_en], [actualizado_en]) VALUES (18, 3, 1, NULL, CAST(N'2017-08-02T12:38:13.767' AS DateTime), CAST(N'2017-08-02T12:38:13.767' AS DateTime))
SET IDENTITY_INSERT [dbo].[cucop_vinculos] OFF
SET IDENTITY_INSERT [dbo].[cucop_vinculos_catalogos] ON 

INSERT [dbo].[cucop_vinculos_catalogos] ([id], [id_cucop_vinculo], [id_catalogo], [creado_en], [actualizado_en]) VALUES (8, 15, 2, CAST(N'2017-07-31' AS Date), CAST(N'2017-07-31' AS Date))
INSERT [dbo].[cucop_vinculos_catalogos] ([id], [id_cucop_vinculo], [id_catalogo], [creado_en], [actualizado_en]) VALUES (9, 16, 2, CAST(N'2017-08-01' AS Date), CAST(N'2017-08-01' AS Date))
INSERT [dbo].[cucop_vinculos_catalogos] ([id], [id_cucop_vinculo], [id_catalogo], [creado_en], [actualizado_en]) VALUES (10, 17, 10, CAST(N'2017-08-01' AS Date), CAST(N'2017-08-01' AS Date))
SET IDENTITY_INSERT [dbo].[cucop_vinculos_catalogos] OFF
SET IDENTITY_INSERT [dbo].[cucop_vinculos_catalogos_referencias] ON 

INSERT [dbo].[cucop_vinculos_catalogos_referencias] ([id], [id_vinculo_catalogo], [id_referencia], [creado_en], [actualizado_en]) VALUES (4, 8, 4, CAST(N'2017-07-31' AS Date), CAST(N'2017-07-31' AS Date))
INSERT [dbo].[cucop_vinculos_catalogos_referencias] ([id], [id_vinculo_catalogo], [id_referencia], [creado_en], [actualizado_en]) VALUES (5, 9, 4, CAST(N'2017-08-01' AS Date), CAST(N'2017-08-01' AS Date))
INSERT [dbo].[cucop_vinculos_catalogos_referencias] ([id], [id_vinculo_catalogo], [id_referencia], [creado_en], [actualizado_en]) VALUES (6, 9, 39, CAST(N'2017-08-01' AS Date), CAST(N'2017-08-01' AS Date))
INSERT [dbo].[cucop_vinculos_catalogos_referencias] ([id], [id_vinculo_catalogo], [id_referencia], [creado_en], [actualizado_en]) VALUES (7, 9, 41, CAST(N'2017-08-01' AS Date), CAST(N'2017-08-01' AS Date))
SET IDENTITY_INSERT [dbo].[cucop_vinculos_catalogos_referencias] OFF
SET IDENTITY_INSERT [dbo].[cucop_vinculos_certificados] ON 

INSERT [dbo].[cucop_vinculos_certificados] ([id], [id_cucop_vinculo], [id_certificados], [creado_en], [actualizado_en]) VALUES (3, 15, 4, CAST(N'2017-07-29' AS Date), CAST(N'2017-07-29' AS Date))
INSERT [dbo].[cucop_vinculos_certificados] ([id], [id_cucop_vinculo], [id_certificados], [creado_en], [actualizado_en]) VALUES (4, 16, 10, CAST(N'2017-08-01' AS Date), CAST(N'2017-08-01' AS Date))
INSERT [dbo].[cucop_vinculos_certificados] ([id], [id_cucop_vinculo], [id_certificados], [creado_en], [actualizado_en]) VALUES (5, 17, 15, CAST(N'2017-08-01' AS Date), CAST(N'2017-08-01' AS Date))
INSERT [dbo].[cucop_vinculos_certificados] ([id], [id_cucop_vinculo], [id_certificados], [creado_en], [actualizado_en]) VALUES (6, 18, 4, CAST(N'2017-08-02' AS Date), CAST(N'2017-08-02' AS Date))
SET IDENTITY_INSERT [dbo].[cucop_vinculos_certificados] OFF
SET IDENTITY_INSERT [dbo].[cucop_vinculos_registros] ON 

INSERT [dbo].[cucop_vinculos_registros] ([id], [id_cucop_vinculo], [id_registro], [creado_en], [actualizado_en]) VALUES (7, 15, 2, CAST(N'2017-07-31' AS Date), CAST(N'2017-07-31' AS Date))
INSERT [dbo].[cucop_vinculos_registros] ([id], [id_cucop_vinculo], [id_registro], [creado_en], [actualizado_en]) VALUES (8, 16, 20, CAST(N'2017-08-01' AS Date), CAST(N'2017-08-01' AS Date))
INSERT [dbo].[cucop_vinculos_registros] ([id], [id_cucop_vinculo], [id_registro], [creado_en], [actualizado_en]) VALUES (9, 15, 3, CAST(N'2017-08-01' AS Date), CAST(N'2017-08-01' AS Date))
INSERT [dbo].[cucop_vinculos_registros] ([id], [id_cucop_vinculo], [id_registro], [creado_en], [actualizado_en]) VALUES (10, 15, 4, CAST(N'2017-08-01' AS Date), CAST(N'2017-08-01' AS Date))
INSERT [dbo].[cucop_vinculos_registros] ([id], [id_cucop_vinculo], [id_registro], [creado_en], [actualizado_en]) VALUES (11, 17, 2, CAST(N'2017-08-01' AS Date), CAST(N'2017-08-01' AS Date))
SET IDENTITY_INSERT [dbo].[cucop_vinculos_registros] OFF
SET IDENTITY_INSERT [dbo].[cucop_vinculos_registros_referencias] ON 

INSERT [dbo].[cucop_vinculos_registros_referencias] ([id], [id_vinculo_registro], [id_referencia], [creado_en], [actualizado_en]) VALUES (5, 9, 2, CAST(N'2017-08-01' AS Date), CAST(N'2017-08-01' AS Date))
INSERT [dbo].[cucop_vinculos_registros_referencias] ([id], [id_vinculo_registro], [id_referencia], [creado_en], [actualizado_en]) VALUES (6, 10, 3, CAST(N'2017-08-01' AS Date), CAST(N'2017-08-01' AS Date))
INSERT [dbo].[cucop_vinculos_registros_referencias] ([id], [id_vinculo_registro], [id_referencia], [creado_en], [actualizado_en]) VALUES (7, 11, 1, CAST(N'2017-08-01' AS Date), CAST(N'2017-08-01' AS Date))
SET IDENTITY_INSERT [dbo].[cucop_vinculos_registros_referencias] OFF
SET IDENTITY_INSERT [dbo].[data_unidades] ON 

INSERT [dbo].[data_unidades] ([id], [unidad]) VALUES (1, N'Pieza')
INSERT [dbo].[data_unidades] ([id], [unidad]) VALUES (2, N'Kit')
INSERT [dbo].[data_unidades] ([id], [unidad]) VALUES (3, N'Bolsa')
INSERT [dbo].[data_unidades] ([id], [unidad]) VALUES (4, N'Sobre')
INSERT [dbo].[data_unidades] ([id], [unidad]) VALUES (5, N'Paquete')
INSERT [dbo].[data_unidades] ([id], [unidad]) VALUES (6, N'Caja')
INSERT [dbo].[data_unidades] ([id], [unidad]) VALUES (7, N'Servicio')
INSERT [dbo].[data_unidades] ([id], [unidad]) VALUES (8, N'Equipo')
SET IDENTITY_INSERT [dbo].[data_unidades] OFF
SET IDENTITY_INSERT [dbo].[fabricantes_titulares_distribuidores] ON 

INSERT [dbo].[fabricantes_titulares_distribuidores] ([id_ftd], [nombre], [tipo_apoyo], [distribuidor_mayorista], [RFC], [creado_en], [actualizado_en]) VALUES (1, N'Medtronic', N'Directo', N'Medtronic S.A de C.V', N'MED741258ERA', CAST(N'2017-08-18T10:50:18.010' AS DateTime), CAST(N'2017-08-18T10:50:18.010' AS DateTime))
SET IDENTITY_INSERT [dbo].[fabricantes_titulares_distribuidores] OFF
SET IDENTITY_INSERT [dbo].[licitacion_bases] ON 

INSERT [dbo].[licitacion_bases] ([id_bases], [numero_licitacion], [unidad_compradora], [entidad_federativa], [especialidad], [duracion_contrato], [tipo_contratacion], [dir_archivo], [estado], [expediente], [tipo_licitacion], [tipo_expediente], [operador_nombre], [operador_correo], [descripcion], [creado_en], [actualizado_en]) VALUES (1, N'AAAAAAAAAAAAAA', N'asdasd', 2, N'Minima Invasion', N'sdasd', N'asdasd', N'licitaciones.pdf', 0, 321312, N'LA', 1, N'asdas', N'asdas', N'asdasd', CAST(N'2017-08-04T12:19:08.937' AS DateTime), CAST(N'2017-08-17T00:00:00.000' AS DateTime))
INSERT [dbo].[licitacion_bases] ([id_bases], [numero_licitacion], [unidad_compradora], [entidad_federativa], [especialidad], [duracion_contrato], [tipo_contratacion], [dir_archivo], [estado], [expediente], [tipo_licitacion], [tipo_expediente], [operador_nombre], [operador_correo], [descripcion], [creado_en], [actualizado_en]) VALUES (2, N'XXXXXXXXXXXXXXXXXXXXX', N'asdasd', 2, N'Minima Invasion', N'sdasd', N'asdasd', N'licitaciones.pdf', 0, 321312, N'LA', 1, N'asdas', N'asdas', N'asdasd', CAST(N'2017-08-04T13:00:31.627' AS DateTime), CAST(N'2017-08-17T00:00:00.000' AS DateTime))
INSERT [dbo].[licitacion_bases] ([id_bases], [numero_licitacion], [unidad_compradora], [entidad_federativa], [especialidad], [duracion_contrato], [tipo_contratacion], [dir_archivo], [estado], [expediente], [tipo_licitacion], [tipo_expediente], [operador_nombre], [operador_correo], [descripcion], [creado_en], [actualizado_en]) VALUES (3, N'ASDASDXXX', N'asdasd', 2, N'Minima Invasion', N'sdasd', N'asdasd', N'licitaciones.pdf', 0, 321312, N'LA', 1, N'asdas', N'asdas', N'asdasd', CAST(N'2017-08-04T16:13:45.260' AS DateTime), CAST(N'2017-08-17T00:00:00.000' AS DateTime))
INSERT [dbo].[licitacion_bases] ([id_bases], [numero_licitacion], [unidad_compradora], [entidad_federativa], [especialidad], [duracion_contrato], [tipo_contratacion], [dir_archivo], [estado], [expediente], [tipo_licitacion], [tipo_expediente], [operador_nombre], [operador_correo], [descripcion], [creado_en], [actualizado_en]) VALUES (4, N'ASDASDXXX', N'asdasd', 2, N'Minima Invasion', N'sdasd', N'asdasd', N'licitaciones.pdf', 0, 321312, N'LA', 1, N'asdas', N'asdas', N'asdasd', CAST(N'2017-08-05T10:49:47.093' AS DateTime), CAST(N'2017-08-17T00:00:00.000' AS DateTime))
INSERT [dbo].[licitacion_bases] ([id_bases], [numero_licitacion], [unidad_compradora], [entidad_federativa], [especialidad], [duracion_contrato], [tipo_contratacion], [dir_archivo], [estado], [expediente], [tipo_licitacion], [tipo_expediente], [operador_nombre], [operador_correo], [descripcion], [creado_en], [actualizado_en]) VALUES (5, N'ASDASDXXX', N'asdasd', 2, N'Minima Invasion', N'sdasd', N'asdasd', N'licitaciones.pdf', 0, 321312, N'LA', 1, N'asdas', N'asdas', N'asdasd', CAST(N'2017-08-05T10:53:14.347' AS DateTime), CAST(N'2017-08-17T00:00:00.000' AS DateTime))
INSERT [dbo].[licitacion_bases] ([id_bases], [numero_licitacion], [unidad_compradora], [entidad_federativa], [especialidad], [duracion_contrato], [tipo_contratacion], [dir_archivo], [estado], [expediente], [tipo_licitacion], [tipo_expediente], [operador_nombre], [operador_correo], [descripcion], [creado_en], [actualizado_en]) VALUES (7, N'ASDASDXXX', N'asdasd', 2, N'Minima Invasion', N'sdasd', N'asdasd', N'licitaciones.pdf', 0, 321312, N'LA', 1, N'asdas', N'asdas', N'asdasd', CAST(N'2017-08-09T17:03:04.563' AS DateTime), CAST(N'2017-08-17T00:00:00.000' AS DateTime))
INSERT [dbo].[licitacion_bases] ([id_bases], [numero_licitacion], [unidad_compradora], [entidad_federativa], [especialidad], [duracion_contrato], [tipo_contratacion], [dir_archivo], [estado], [expediente], [tipo_licitacion], [tipo_expediente], [operador_nombre], [operador_correo], [descripcion], [creado_en], [actualizado_en]) VALUES (8, N'ASDASDXXX', N'asdasd', 2, N'Minima Invasion', N'sdasd', N'asdasd', N'licitaciones.pdf', 0, 321312, N'LA', 1, N'asdas', N'asdas', N'asdasd', CAST(N'2017-08-09T17:06:02.623' AS DateTime), CAST(N'2017-08-17T00:00:00.000' AS DateTime))
INSERT [dbo].[licitacion_bases] ([id_bases], [numero_licitacion], [unidad_compradora], [entidad_federativa], [especialidad], [duracion_contrato], [tipo_contratacion], [dir_archivo], [estado], [expediente], [tipo_licitacion], [tipo_expediente], [operador_nombre], [operador_correo], [descripcion], [creado_en], [actualizado_en]) VALUES (9, N'ASDASDXXX', N'asdasd', 2, N'Minima Invasion', N'sdasd', N'asdasd', N'licitaciones.pdf', 0, 321312, N'LA', 1, N'asdas', N'asdas', N'asdasd', CAST(N'2017-08-09T17:09:20.160' AS DateTime), CAST(N'2017-08-17T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[licitacion_bases] OFF
SET IDENTITY_INSERT [dbo].[licitacion_calendario] ON 

INSERT [dbo].[licitacion_calendario] ([id_calendario], [id_bases], [fecha_publicacion], [fecha_junta_aclaraciones], [fecha_apertura], [fecha_fallo], [fecha_firma], [fecha_visita], [creado_en], [actualizado_en]) VALUES (6, 1, CAST(N'2017-08-14T00:00:00.000' AS DateTime), CAST(N'2017-08-14T00:00:00.000' AS DateTime), CAST(N'2017-08-14T00:00:00.000' AS DateTime), CAST(N'2017-08-14T00:00:00.000' AS DateTime), CAST(N'2017-08-29T00:00:00.000' AS DateTime), CAST(N'2017-08-14T00:00:00.000' AS DateTime), CAST(N'2017-08-14T10:00:19.470' AS DateTime), CAST(N'2017-08-14T00:00:00.000' AS DateTime))
INSERT [dbo].[licitacion_calendario] ([id_calendario], [id_bases], [fecha_publicacion], [fecha_junta_aclaraciones], [fecha_apertura], [fecha_fallo], [fecha_firma], [fecha_visita], [creado_en], [actualizado_en]) VALUES (7, 2, CAST(N'2017-08-14T00:00:00.000' AS DateTime), CAST(N'2017-08-14T00:00:00.000' AS DateTime), CAST(N'2017-08-14T00:00:00.000' AS DateTime), CAST(N'2017-08-14T00:00:00.000' AS DateTime), CAST(N'2017-08-13T00:00:00.000' AS DateTime), CAST(N'2017-08-14T00:00:00.000' AS DateTime), CAST(N'2017-08-14T10:00:43.230' AS DateTime), CAST(N'2017-08-14T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[licitacion_calendario] OFF
SET IDENTITY_INSERT [dbo].[licitacion_items] ON 

INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (1, 1, N'asd', N'Pieza', CAST(N'2017-08-16T16:25:45.760' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (2, 2, N'asd', N'Pieza', CAST(N'2017-08-16T16:25:52.383' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (3, 3, N'asd', N'Pieza', CAST(N'2017-08-16T16:25:55.270' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (4, 4, N'asd', N'Pieza', CAST(N'2017-08-16T16:25:58.120' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (5, 5, N'asd', N'Pieza', CAST(N'2017-08-16T16:26:04.660' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (6, 6, N'asd', N'Pieza', CAST(N'2017-08-16T16:26:09.900' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (7, 7, N'asd', N'Pieza', CAST(N'2017-08-16T16:26:12.167' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (9, 1, N'asda', N'Pieza', CAST(N'2017-08-16T17:16:19.600' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (10, 1, N'sdasd', N'Pieza', CAST(N'2017-08-16T17:16:21.433' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (11, 1, N'asdasdasd', N'Pieza', CAST(N'2017-08-16T17:16:22.760' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (12, 1, N'asdasd', N'Pieza', CAST(N'2017-08-16T17:16:23.970' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (13, 1, N'asdasd', N'Pieza', CAST(N'2017-08-16T17:16:25.100' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (14, 1, N'asdasda', N'Pieza', CAST(N'2017-08-16T17:16:26.260' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (15, 1, N'sdasda', N'Pieza', CAST(N'2017-08-16T17:16:27.367' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (16, 2, N'sdasdasd', N'Pieza', CAST(N'2017-08-16T17:16:29.667' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (17, 2, N'asdasdasd', N'Pieza', CAST(N'2017-08-16T17:16:31.287' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (18, 2, N'asdasdas', N'Pieza', CAST(N'2017-08-16T17:16:32.727' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (19, 2, N'dasdasdas', N'Pieza', CAST(N'2017-08-16T17:16:34.040' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (20, 2, N'dasdasdas', N'Pieza', CAST(N'2017-08-16T17:16:35.543' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (21, 3, N'dasdasdas', N'Pieza', CAST(N'2017-08-16T17:16:37.420' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (22, 3, N'dasdasdasd', N'Pieza', CAST(N'2017-08-16T17:16:39.073' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (23, 3, N'asdasdasd', N'Pieza', CAST(N'2017-08-16T17:16:41.427' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (24, 4, N'asdasdasd', N'Pieza', CAST(N'2017-08-16T17:16:43.977' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (25, 5, N'asdasdasd', N'Pieza', CAST(N'2017-08-16T17:16:45.593' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (26, 6, N'asdasdasd', N'Pieza', CAST(N'2017-08-16T17:16:47.530' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (27, 7, N'asdasdasd', N'Pieza', CAST(N'2017-08-16T17:16:49.287' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (28, 7, N'asdasdasd', N'Pieza', CAST(N'2017-08-16T17:16:51.020' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (29, 7, N'asdasdasd', N'Pieza', CAST(N'2017-08-16T17:16:52.703' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (30, 7, N'asdasdasd', N'Pieza', CAST(N'2017-08-16T17:16:54.227' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (31, 7, N'asdaacaca', N'Pieza', CAST(N'2017-08-16T17:16:55.650' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (32, 7, N'cacascaca', N'Pieza', CAST(N'2017-08-16T17:16:57.147' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (33, 7, N'csacscasc', N'Pieza', CAST(N'2017-08-16T17:16:58.593' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (34, 7, N'ascasc', N'Pieza', CAST(N'2017-08-16T17:16:59.983' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (35, 7, N'ascasca', N'Pieza', CAST(N'2017-08-16T17:17:01.327' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (36, 7, N'scasca', N'Pieza', CAST(N'2017-08-16T17:17:03.053' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (37, 7, N'scasc', N'Pieza', CAST(N'2017-08-16T17:17:05.350' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (38, 7, N'ascascascascasc', N'Pieza', CAST(N'2017-08-16T17:17:07.870' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (39, 2, N'dadadad', N'Pieza', CAST(N'2017-08-16T17:17:58.520' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (40, 2, N'adasdsa', N'Pieza', CAST(N'2017-08-16T17:17:59.283' AS DateTime), NULL)
INSERT [dbo].[licitacion_items] ([id_item], [id_paquete], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (41, 2, N'adadadadad', N'Pieza', CAST(N'2017-08-16T17:18:27.967' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[licitacion_items] OFF
SET IDENTITY_INSERT [dbo].[licitacion_partidas] ON 

INSERT [dbo].[licitacion_partidas] ([id], [id_bases], [numero_partida], [nombre_partida], [especialidad], [creado_en], [actualizado_en]) VALUES (1, 1, 1, N'Hemodinamia', N'Hemodinamia', NULL, NULL)
INSERT [dbo].[licitacion_partidas] ([id], [id_bases], [numero_partida], [nombre_partida], [especialidad], [creado_en], [actualizado_en]) VALUES (2, 2, 1, N'Hemodinamia', N'Hemodinamia', NULL, NULL)
INSERT [dbo].[licitacion_partidas] ([id], [id_bases], [numero_partida], [nombre_partida], [especialidad], [creado_en], [actualizado_en]) VALUES (3, 1, 2, N'CX Cardio', N'Cirugia Cardiovascular', NULL, NULL)
INSERT [dbo].[licitacion_partidas] ([id], [id_bases], [numero_partida], [nombre_partida], [especialidad], [creado_en], [actualizado_en]) VALUES (4, 1, 3, N'Neuro', N'Cirugia Neurovascular', NULL, NULL)
INSERT [dbo].[licitacion_partidas] ([id], [id_bases], [numero_partida], [nombre_partida], [especialidad], [creado_en], [actualizado_en]) VALUES (5, 2, 2, N'Minima', N'Miniva Invasion', NULL, NULL)
SET IDENTITY_INSERT [dbo].[licitacion_partidas] OFF
SET IDENTITY_INSERT [dbo].[licitacion_subpar_proce] ON 

INSERT [dbo].[licitacion_subpar_proce] ([id], [id_partida], [numero_subpartida], [nombre_subpartida], [creado_en], [actualizado_en]) VALUES (1, 1, 1, N'Paq 1', NULL, NULL)
INSERT [dbo].[licitacion_subpar_proce] ([id], [id_partida], [numero_subpartida], [nombre_subpartida], [creado_en], [actualizado_en]) VALUES (2, 3, 1, N'Paq 1', NULL, NULL)
INSERT [dbo].[licitacion_subpar_proce] ([id], [id_partida], [numero_subpartida], [nombre_subpartida], [creado_en], [actualizado_en]) VALUES (3, 4, 1, N'Paq 1', NULL, NULL)
INSERT [dbo].[licitacion_subpar_proce] ([id], [id_partida], [numero_subpartida], [nombre_subpartida], [creado_en], [actualizado_en]) VALUES (4, 1, 2, N'Paq 2', NULL, NULL)
INSERT [dbo].[licitacion_subpar_proce] ([id], [id_partida], [numero_subpartida], [nombre_subpartida], [creado_en], [actualizado_en]) VALUES (5, 1, 3, N'Paq 3', NULL, NULL)
INSERT [dbo].[licitacion_subpar_proce] ([id], [id_partida], [numero_subpartida], [nombre_subpartida], [creado_en], [actualizado_en]) VALUES (6, 2, 1, N'Listado 1', NULL, NULL)
INSERT [dbo].[licitacion_subpar_proce] ([id], [id_partida], [numero_subpartida], [nombre_subpartida], [creado_en], [actualizado_en]) VALUES (7, 2, 2, N'Listado 2', NULL, NULL)
SET IDENTITY_INSERT [dbo].[licitacion_subpar_proce] OFF
SET IDENTITY_INSERT [dbo].[licitacion_vinculacion] ON 

INSERT [dbo].[licitacion_vinculacion] ([id_vinculacion], [id_item], [id_cucop], [id_ftd], [creado_en], [actualizado_en]) VALUES (1, 1, 1, NULL, CAST(N'2017-08-16T16:26:44.463' AS DateTime), NULL)
INSERT [dbo].[licitacion_vinculacion] ([id_vinculacion], [id_item], [id_cucop], [id_ftd], [creado_en], [actualizado_en]) VALUES (2, 2, 2, NULL, CAST(N'2017-08-16T16:26:48.400' AS DateTime), NULL)
INSERT [dbo].[licitacion_vinculacion] ([id_vinculacion], [id_item], [id_cucop], [id_ftd], [creado_en], [actualizado_en]) VALUES (3, 3, 3, NULL, CAST(N'2017-08-16T16:27:01.533' AS DateTime), NULL)
INSERT [dbo].[licitacion_vinculacion] ([id_vinculacion], [id_item], [id_cucop], [id_ftd], [creado_en], [actualizado_en]) VALUES (5, 4, 1, NULL, CAST(N'2017-08-16T16:27:10.463' AS DateTime), NULL)
INSERT [dbo].[licitacion_vinculacion] ([id_vinculacion], [id_item], [id_cucop], [id_ftd], [creado_en], [actualizado_en]) VALUES (6, 5, 2, NULL, CAST(N'2017-08-16T16:27:13.300' AS DateTime), NULL)
INSERT [dbo].[licitacion_vinculacion] ([id_vinculacion], [id_item], [id_cucop], [id_ftd], [creado_en], [actualizado_en]) VALUES (7, 6, 3, NULL, CAST(N'2017-08-16T16:27:17.220' AS DateTime), NULL)
INSERT [dbo].[licitacion_vinculacion] ([id_vinculacion], [id_item], [id_cucop], [id_ftd], [creado_en], [actualizado_en]) VALUES (8, 7, 1, NULL, CAST(N'2017-08-16T16:27:19.573' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[licitacion_vinculacion] OFF
SET IDENTITY_INSERT [dbo].[paises_origen] ON 

INSERT [dbo].[paises_origen] ([id_pais], [nombre], [tratado de comercio], [creado_en], [actualizado_en]) VALUES (1, N'Estados Unidos', N'TLCAN', NULL, NULL)
INSERT [dbo].[paises_origen] ([id_pais], [nombre], [tratado de comercio], [creado_en], [actualizado_en]) VALUES (2, N'Suiza', N'AELC', NULL, NULL)
INSERT [dbo].[paises_origen] ([id_pais], [nombre], [tratado de comercio], [creado_en], [actualizado_en]) VALUES (3, N'Irlanda', N'TLCUE', NULL, NULL)
INSERT [dbo].[paises_origen] ([id_pais], [nombre], [tratado de comercio], [creado_en], [actualizado_en]) VALUES (4, N'Canada', N'TLCAN', NULL, NULL)
INSERT [dbo].[paises_origen] ([id_pais], [nombre], [tratado de comercio], [creado_en], [actualizado_en]) VALUES (5, N'Singapur', NULL, NULL, NULL)
INSERT [dbo].[paises_origen] ([id_pais], [nombre], [tratado de comercio], [creado_en], [actualizado_en]) VALUES (6, N'Israel', NULL, NULL, NULL)
INSERT [dbo].[paises_origen] ([id_pais], [nombre], [tratado de comercio], [creado_en], [actualizado_en]) VALUES (7, N'Corea', NULL, NULL, NULL)
INSERT [dbo].[paises_origen] ([id_pais], [nombre], [tratado de comercio], [creado_en], [actualizado_en]) VALUES (8, N'México', NULL, NULL, NULL)
INSERT [dbo].[paises_origen] ([id_pais], [nombre], [tratado de comercio], [creado_en], [actualizado_en]) VALUES (9, N'Alemania', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[paises_origen] OFF
SET IDENTITY_INSERT [dbo].[registros_claves_referencias] ON 

INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (1, 2, N'AVA 500 HC', N'Controlador Manual Multipaciente', N'', CAST(N'2017-07-18T11:02:01.253' AS DateTime), CAST(N'2017-07-21T15:50:47.127' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (2, 3, N'EN1DR01', N'MARCAPASO DOBLE CAMARA CON FUNCIONALIDAD PARA MRI', N'PIEZA', CAST(N'2017-07-18T13:50:05.090' AS DateTime), CAST(N'2017-07-18T13:49:57.943' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (3, 4, N'5076', N'CABLE CAPSURE FIX NOVUS MRI SURESCAN', N'PIEZA', CAST(N'2017-07-18T14:06:59.777' AS DateTime), CAST(N'2017-07-18T14:06:52.663' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (4, 5, N'5092', N'ELECTRODO DE ESTIMULACION CARDIACA MEDTRONIC CAPSURE SP NOVUS 5092', N'PIEZA', CAST(N'2017-07-18T14:17:50.390' AS DateTime), CAST(N'2017-07-18T14:17:43.060' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (5, 6, N'6207 D1', N'INTRODUCTOR DESECHABLE, PARA CABLE IMPLANTABLE. ES UN PRODUCTO ESTERIL POR MEDIO DE OXIDO DE ETILENO Y LIBRE DE PIROGENOS. 
EL ALAMBRE GUIA FLEXIBLE EN FORMA DE J TIENE MARCAS A INTERVALOS DE 10CM QUE SIRVE PARA ESTIMAR LA LONGITUD DEL ELECTRODO.', N'PIEZA', CAST(N'2017-07-18T14:29:01.077' AS DateTime), CAST(N'2017-07-18T14:28:53.737' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (6, 6, N'6208 D1', N'INTRODUCTOR DESECHABLE, PARA CABLE IMPLANTABLE. ES UN PRODUCTO ESTERIL POR MEDIO DE OXIDO DE ETILENO Y LIBRE DE PIROGENOS. 
EL ALAMBRE GUIA FLEXIBLE EN FORMA DE J TIENE MARCAS A INTERVALOS DE 10CM QUE SIRVE PARA ESTIMAR LA LONGITUD DEL ELECTRODO.', N'PIEZA', CAST(N'2017-07-18T14:29:16.743' AS DateTime), CAST(N'2017-07-18T14:29:09.403' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (7, 6, N'6209 D1', N'INTRODUCTOR DESECHABLE, PARA CABLE IMPLANTABLE. ES UN PRODUCTO ESTERIL POR MEDIO DE OXIDO DE ETILENO Y LIBRE DE PIROGENOS. 
EL ALAMBRE GUIA FLEXIBLE EN FORMA DE J TIENE MARCAS A INTERVALOS DE 10CM QUE SIRVE PARA ESTIMAR LA LONGITUD DEL ELECTRODO.', N'PIEZA', CAST(N'2017-07-18T14:29:24.820' AS DateTime), CAST(N'2017-07-18T14:29:17.483' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (8, 6, N'6210 D1', N'INTRODUCTOR DESECHABLE, PARA CABLE IMPLANTABLE. ES UN PRODUCTO ESTERIL POR MEDIO DE OXIDO DE ETILENO Y LIBRE DE PIROGENOS. 
EL ALAMBRE GUIA FLEXIBLE EN FORMA DE J TIENE MARCAS A INTERVALOS DE 10CM QUE SIRVE PARA ESTIMAR LA LONGITUD DEL ELECTRODO.', N'PIEZA', CAST(N'2017-07-18T14:29:37.640' AS DateTime), CAST(N'2017-07-18T14:29:30.300' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (9, 6, N'6211 D1', N'INTRODUCTOR DESECHABLE, PARA CABLE IMPLANTABLE. ES UN PRODUCTO ESTERIL POR MEDIO DE OXIDO DE ETILENO Y LIBRE DE PIROGENOS. 
EL ALAMBRE GUIA FLEXIBLE EN FORMA DE J TIENE MARCAS A INTERVALOS DE 10CM QUE SIRVE PARA ESTIMAR LA LONGITUD DEL ELECTRODO.', N'PIEZA', CAST(N'2017-07-18T14:29:42.217' AS DateTime), CAST(N'2017-07-18T14:29:34.880' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (10, 6, N'6212 D1', N'INTRODUCTOR DESECHABLE, PARA CABLE IMPLANTABLE. ES UN PRODUCTO ESTERIL POR MEDIO DE OXIDO DE ETILENO Y LIBRE DE PIROGENOS. 
EL ALAMBRE GUIA FLEXIBLE EN FORMA DE J TIENE MARCAS A INTERVALOS DE 10CM QUE SIRVE PARA ESTIMAR LA LONGITUD DEL ELECTRODO.', N'PIEZA', CAST(N'2017-07-18T14:29:48.263' AS DateTime), CAST(N'2017-07-18T14:29:40.933' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (11, 6, N'6214 D1', N'INTRODUCTOR DESECHABLE, PARA CABLE IMPLANTABLE. ES UN PRODUCTO ESTERIL POR MEDIO DE OXIDO DE ETILENO Y LIBRE DE PIROGENOS. 
EL ALAMBRE GUIA FLEXIBLE EN FORMA DE J TIENE MARCAS A INTERVALOS DE 10CM QUE SIRVE PARA ESTIMAR LA LONGITUD DEL ELECTRODO.', N'PIEZA', CAST(N'2017-07-18T14:29:54.983' AS DateTime), CAST(N'2017-07-18T14:29:47.657' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (12, 30, N'11010-S1', N'son partículas embólicas de núcleo, consisten en un núcleo de hidrogel hecho de polimetacrilato de Sodio recubierto con un polímero inorgánico perfluorinatado llamado Polizene® para crear una cubierta exterior biocompatible. Son desarrolladas con base en cuatro parámetros: Biocompatibilidad, Calibración precisa, Suspensión e Integridad de sus partículas. ', N'Pieza', CAST(N'2017-07-21T17:06:42.803' AS DateTime), CAST(N'2017-07-21T17:06:37.353' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (13, 30, N'11020-S1', N'son partículas embólicas de núcleo, consisten en un núcleo de hidrogel hecho de polimetacrilato de Sodio recubierto con un polímero inorgánico perfluorinatado llamado Polizene® para crear una cubierta exterior biocompatible. Son desarrolladas con base en cuatro parámetros: Biocompatibilidad, Calibración precisa, Suspensión e Integridad de sus partículas. ', N'Pieza', CAST(N'2017-07-21T17:06:53.293' AS DateTime), CAST(N'2017-07-21T17:06:47.870' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (14, 30, N'12010-S1', N'son partículas embólicas de núcleo, consisten en un núcleo de hidrogel hecho de polimetacrilato de Sodio recubierto con un polímero inorgánico perfluorinatado llamado Polizene® para crear una cubierta exterior biocompatible. Son desarrolladas con base en cuatro parámetros: Biocompatibilidad, Calibración precisa, Suspensión e Integridad de sus partículas. ', N'Pieza', CAST(N'2017-07-21T17:07:06.930' AS DateTime), CAST(N'2017-07-21T17:09:21.533' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (15, 30, N'12020-S1', N'son partículas embólicas de núcleo, consisten en un núcleo de hidrogel hecho de polimetacrilato de Sodio recubierto con un polímero inorgánico perfluorinatado llamado Polizene® para crear una cubierta exterior biocompatible. Son desarrolladas con base en cuatro parámetros: Biocompatibilidad, Calibración precisa, Suspensión e Integridad de sus partículas. ', N'Pieza', CAST(N'2017-07-21T17:09:52.383' AS DateTime), CAST(N'2017-07-21T17:09:46.957' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (16, 30, N'14010-S1', N'son partículas embólicas de núcleo, consisten en un núcleo de hidrogel hecho de polimetacrilato de Sodio recubierto con un polímero inorgánico perfluorinatado llamado Polizene® para crear una cubierta exterior biocompatible. Son desarrolladas con base en cuatro parámetros: Biocompatibilidad, Calibración precisa, Suspensión e Integridad de sus partículas. ', N'Pieza', CAST(N'2017-07-21T17:10:14.923' AS DateTime), CAST(N'2017-07-21T17:10:09.493' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (17, 30, N'14020-S1', N'son partículas embólicas de núcleo, consisten en un núcleo de hidrogel hecho de polimetacrilato de Sodio recubierto con un polímero inorgánico perfluorinatado llamado Polizene® para crear una cubierta exterior biocompatible. Son desarrolladas con base en cuatro parámetros: Biocompatibilidad, Calibración precisa, Suspensión e Integridad de sus partículas. ', N'Pieza', CAST(N'2017-07-21T17:10:19.103' AS DateTime), CAST(N'2017-07-21T17:10:13.677' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (18, 30, N'15010-S1', N'son partículas embólicas de núcleo, consisten en un núcleo de hidrogel hecho de polimetacrilato de Sodio recubierto con un polímero inorgánico perfluorinatado llamado Polizene® para crear una cubierta exterior biocompatible. Son desarrolladas con base en cuatro parámetros: Biocompatibilidad, Calibración precisa, Suspensión e Integridad de sus partículas. ', N'Pieza', CAST(N'2017-07-21T17:10:39.087' AS DateTime), CAST(N'2017-07-21T17:10:33.660' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (19, 30, N'15020-S1', N'son partículas embólicas de núcleo, consisten en un núcleo de hidrogel hecho de polimetacrilato de Sodio recubierto con un polímero inorgánico perfluorinatado llamado Polizene® para crear una cubierta exterior biocompatible. Son desarrolladas con base en cuatro parámetros: Biocompatibilidad, Calibración precisa, Suspensión e Integridad de sus partículas. ', N'Pieza', CAST(N'2017-07-21T17:10:44.487' AS DateTime), CAST(N'2017-07-21T17:10:39.060' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (20, 30, N'17010-S1', N'son partículas embólicas de núcleo, consisten en un núcleo de hidrogel hecho de polimetacrilato de Sodio recubierto con un polímero inorgánico perfluorinatado llamado Polizene® para crear una cubierta exterior biocompatible. Son desarrolladas con base en cuatro parámetros: Biocompatibilidad, Calibración precisa, Suspensión e Integridad de sus partículas. ', N'Pieza', CAST(N'2017-07-21T17:11:10.027' AS DateTime), CAST(N'2017-07-21T17:11:04.597' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (21, 30, N'17020-S1', N'son partículas embólicas de núcleo, consisten en un núcleo de hidrogel hecho de polimetacrilato de Sodio recubierto con un polímero inorgánico perfluorinatado llamado Polizene® para crear una cubierta exterior biocompatible. Son desarrolladas con base en cuatro parámetros: Biocompatibilidad, Calibración precisa, Suspensión e Integridad de sus partículas. ', N'Pieza', CAST(N'2017-07-21T17:11:14.873' AS DateTime), CAST(N'2017-07-21T17:11:09.447' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (22, 31, N'610120', N'DISPOSITIVO HEMOSTATICO, COMPUESTO POR UNA ESPONJA DE COLAGENO Y UN ANCLA DE POLIMERO ABSORBILE, CONECTADO POR UNA SUTURA ABSORBIBLE, EN CONJUNTO CON UNA VAINA GAMMA, LIBRE DE PIROGENOS, PARA UN SOLO USO, NO REUTILIZABLE.', N'Pieza', CAST(N'2017-07-25T10:29:21.163' AS DateTime), CAST(N'2017-07-25T10:29:19.817' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (23, 31, N'610122', N'DISPOSITIVO HEMOSTATICO, COMPUESTO POR UNA ESPONJA DE COLAGENO Y UN ANCLA DE POLIMERO ABSORBILE, CONECTADO POR UNA SUTURA ABSORBIBLE, EN CONJUNTO CON UNA VAINA GAMMA, LIBRE DE PIROGENOS, PARA UN SOLO USO, NO REUTILIZABLE.', N'Pieza', CAST(N'2017-07-25T10:29:34.303' AS DateTime), CAST(N'2017-07-25T10:29:32.953' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (24, 11, N'BQ-9050', N'Dispositivo para inflación de 20cc
váivula de clic para angioplastia
dispositivo de torsión
herramienta para inserción', N'Pieza', CAST(N'2017-07-31T10:43:19.853' AS DateTime), CAST(N'2017-08-01T00:43:21.330' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (25, 11, N'BQ-9001', N'Oisposhivo para imlacion de 20cc', N'Pieza', CAST(N'2017-07-31T10:45:48.307' AS DateTime), CAST(N'2017-08-01T00:45:49.783' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (26, 38, N'H74939208181650', N'Dispositivo para otc truepath ™', N'Pieza', CAST(N'2017-07-31T11:03:15.493' AS DateTime), CAST(N'2017-08-01T01:03:16.977' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (27, 38, N'H74939208001601', N'Guía de extensión truepath (caja con 5)', N'Caja', CAST(N'2017-07-31T11:03:51.503' AS DateTime), CAST(N'2017-08-01T01:03:52.983' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (28, 37, N'RSINT22508X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-07-31T11:12:12.783' AS DateTime), CAST(N'2017-07-31T11:14:00.993' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (29, 37, N'RSINT25008X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-07-31T11:12:40.997' AS DateTime), CAST(N'2017-07-31T11:14:06.383' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (30, 37, N'RSINT27508X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-07-31T11:13:01.193' AS DateTime), CAST(N'2017-08-15T06:00:12.770' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (31, 39, N'H749LTV230', N'Sistema valvular lotus, 23 mm', N'Pieza', CAST(N'2017-07-31T11:13:04.593' AS DateTime), CAST(N'2017-08-01T01:13:06.080' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (32, 39, N'H749LTV250', N'Sistema valvular lotus, 25 mm', N'Pieza', CAST(N'2017-07-31T11:13:14.443' AS DateTime), CAST(N'2017-08-01T01:13:15.927' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (33, 39, N'H749LTV270', N'Sistema valvular lotus, 27 mm', N'Pieza', CAST(N'2017-07-31T11:13:23.460' AS DateTime), CAST(N'2017-08-01T01:13:24.943' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (34, 40, N'H74916391212', N'Model d 5f fl3.5 b/5', N'Pieza', CAST(N'2017-07-31T11:24:05.123' AS DateTime), CAST(N'2017-08-01T01:24:06.603' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (35, 40, N'H74916391222', N'Model d 5f fl4 (5pk)', N'Pieza', CAST(N'2017-07-31T11:24:52.277' AS DateTime), CAST(N'2017-08-01T01:24:53.757' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (36, 40, N'H74916391224', N'Model d 5f fl5 (5pk)', N'Pieza', CAST(N'2017-07-31T11:26:08.207' AS DateTime), CAST(N'2017-08-01T01:26:09.687' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (37, 40, N'H74916599212', N'Model - d 6f impulse fl3.5 5 pack', N'Paquete', CAST(N'2017-07-31T11:28:29.403' AS DateTime), CAST(N'2017-08-01T01:28:30.887' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (38, 40, N'H74916599222', N'Model - d 6f impulse fl4 5 pack', N'Paquete', CAST(N'2017-07-31T11:29:02.643' AS DateTime), CAST(N'2017-08-01T01:29:04.127' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (39, 40, N'H74916599242', N'Model - d 6f impulse fl5 5 pack', N'Paquete', CAST(N'2017-07-31T11:29:56.517' AS DateTime), CAST(N'2017-08-01T01:29:57.997' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (40, 40, N'H74916391012', N'Model d 5f fr3.5 (5pk)', N'Paquete', CAST(N'2017-07-31T11:30:28.100' AS DateTime), CAST(N'2017-08-01T01:30:29.580' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (41, 40, N'H74916391022', N'Modelo 5f fr4 (5pk)', N'Paquete', CAST(N'2017-07-31T11:31:23.303' AS DateTime), CAST(N'2017-08-01T01:31:24.783' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (42, 40, N'H74916599012', N'Model - d 6f impulse fr3.5 5 pack', N'Paquete', CAST(N'2017-07-31T11:33:30.403' AS DateTime), CAST(N'2017-08-01T01:33:31.887' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (43, 40, N'H74916599022', N'Model - d 6f impulse fr4 5 pack', N'Paquete', CAST(N'2017-07-31T11:34:29.997' AS DateTime), CAST(N'2017-08-01T01:34:31.477' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (44, 40, N'H74916599032', N'Model - d 6f impulse fr5 5 pack', N'Paquete', CAST(N'2017-07-31T11:35:46.763' AS DateTime), CAST(N'2017-08-01T01:35:48.243' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (45, 40, N'H74916391962', N'Model d 5f al 1 5-pack', N'Paquete', CAST(N'2017-07-31T11:36:15.250' AS DateTime), CAST(N'2017-08-01T01:36:16.733' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (46, 40, N'H74916391982', N'Model d 5f al2 5-pack', N'Paquete', CAST(N'2017-07-31T11:42:23.877' AS DateTime), CAST(N'2017-08-01T01:42:25.360' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (47, 40, N'H74916391842', N'Model d 5f ar1 (5pk)', N'Paquete', CAST(N'2017-07-31T11:43:25.910' AS DateTime), CAST(N'2017-08-01T01:43:27.390' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (48, 40, N'H74916391862', N'Model d 5f ar2 (5pk)', N'Paquete', CAST(N'2017-07-31T11:44:12.037' AS DateTime), CAST(N'2017-08-01T01:44:13.517' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (49, 40, N'H74916599962', N'Impulse al 1 5 pack', N'Paquete', CAST(N'2017-07-31T11:47:37.403' AS DateTime), CAST(N'2017-08-01T01:47:38.883' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (50, 40, N'H74916599982', N'Model - d 6f impulse al2 5 pack', N'Paquete', CAST(N'2017-07-31T11:48:31.853' AS DateTime), CAST(N'2017-08-01T01:48:33.330' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (51, 40, N'H74916599842', N'Model - d 6f impulse ar1 5 pack', N'Paquete', CAST(N'2017-07-31T11:49:29.973' AS DateTime), CAST(N'2017-08-01T01:49:31.450' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (52, 40, N'H74916599862', N'Model - d 6f impulse ar2 5 pack', N'Paquete', CAST(N'2017-07-31T11:50:55.307' AS DateTime), CAST(N'2017-08-01T01:50:56.787' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (53, 40, N'H749163911172', N'Model d 5f mpa-1 (5pk)', N'Paquete', CAST(N'2017-07-31T11:55:53.560' AS DateTime), CAST(N'2017-08-01T01:55:55.040' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (54, 40, N'H749163911212', N'Model d 5f mpa2 w/sh (5pk)', N'Paquete', CAST(N'2017-07-31T12:01:47.620' AS DateTime), CAST(N'2017-08-01T02:01:49.100' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (55, 40, N'H749163911222', N'Model d 5f mpa2 125cm (5pk)', N'Paquete', CAST(N'2017-07-31T12:02:13.360' AS DateTime), CAST(N'2017-08-01T02:02:14.843' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (56, 40, N'H749163911422', N'Model d 5f mpb-1 (5pk)', N'Paquete', CAST(N'2017-07-31T12:03:50.060' AS DateTime), CAST(N'2017-08-01T02:30:45.677' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (57, 40, N'H749163911462', N'Model d 5f mpb-2 w/sh (5pk)', N'Paquete', CAST(N'2017-07-31T12:04:44.627' AS DateTime), CAST(N'2017-08-01T02:04:46.107' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (58, 40, N'H749165991172', N'Model - d 6f impulse mpa-1 5 pack', N'Paquete', CAST(N'2017-07-31T12:05:34.530' AS DateTime), CAST(N'2017-08-01T02:05:36.010' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (59, 40, N'H749165991212', N'Model - d 6f impulse mpa-2 5 pack', N'Paquete', CAST(N'2017-07-31T12:06:27.593' AS DateTime), CAST(N'2017-08-01T02:06:29.073' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (60, 40, N'H749165991222', N'Model- d 6f impulse mpa-2 125 cm 5 pack', N'Paquete', CAST(N'2017-07-31T12:07:22.557' AS DateTime), CAST(N'2017-08-01T02:07:24.033' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (61, 40, N'H749165991422', N'Model - d 6f impulse mpb-1 5 pack', N'Paquete', CAST(N'2017-07-31T12:07:59.480' AS DateTime), CAST(N'2017-08-01T02:08:59.747' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (62, 40, N'H749165991462', N'Model - d 6f impulse mpb-2 5 pack', N'Paquete', CAST(N'2017-07-31T12:08:47.553' AS DateTime), CAST(N'2017-08-01T02:11:34.980' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (63, 40, N'H749163912012', N'Model d 5f im 5-pack', N'Paquete', CAST(N'2017-07-31T12:13:09.013' AS DateTime), CAST(N'2017-08-01T02:19:20.077' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (64, 40, N'H749165992012', N'Model - d 6f impulse im 5 pack', N'Paquete', CAST(N'2017-07-31T12:13:40.643' AS DateTime), CAST(N'2017-08-01T02:19:30.017' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (65, 40, N'H74916391402', N'Model-d 5f pig 110cm (5pk)', N'Paquete', CAST(N'2017-08-02T10:14:42.937' AS DateTime), CAST(N'2017-08-03T00:14:42.330' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (66, 40, N'H74916599412', N'Model- d 6f impulse pig 145 5 pack', N'Paquete', CAST(N'2017-08-02T10:41:49.550' AS DateTime), CAST(N'2017-08-03T00:41:48.943' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (67, 41, N'HL4904527011', N'Advantage 26 (sgl)', N'Pieza', CAST(N'2017-08-02T11:03:39.320' AS DateTime), CAST(N'2017-08-03T01:03:38.713' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (68, 41, N'H74904527052', N'Model-advantage 26 (5pk)', N'Paquete', CAST(N'2017-08-02T11:04:15.587' AS DateTime), CAST(N'2017-08-09T00:17:59.553' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (69, 42, N'M001491181', N'Star/j fc/035/150/3j/ptfe/3/10 box10', N'Caja', CAST(N'2017-08-02T11:28:40.140' AS DateTime), CAST(N'2017-08-03T01:30:32.400' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (70, 42, N'M001491201', N'Star/jfc/035/180/3j/ptfe/3/5
box5', N'Caja', CAST(N'2017-08-02T11:29:30.890' AS DateTime), CAST(N'2017-08-03T01:29:30.287' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (71, 42, N'M001491211', N'Star/jfc/035/260/3j/ptfe/3/5
box5', N'Caja', CAST(N'2017-08-02T11:30:07.003' AS DateTime), CAST(N'2017-08-03T01:30:06.400' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (72, 42, N'M001491011', N'Star/jfc/035/150/str/ptfe/3/10
box10', N'Caja', CAST(N'2017-08-02T11:31:43.770' AS DateTime), CAST(N'2017-08-03T01:34:26.520' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (73, 42, N'M001491031', N'Star/sfc/035/260/str/ptfe/3/5
box5', N'Caja', CAST(N'2017-08-02T11:33:41.930' AS DateTime), CAST(N'2017-08-03T01:34:01.623' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (74, 42, N'H74912132012', N'Model-choice flop (5pk)', N'Paquete', CAST(N'2017-08-02T11:40:54.053' AS DateTime), CAST(N'2017-08-03T01:40:53.447' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (75, 42, N'H7491213201J2', N'Model-choice flop j (5pk)', N'Paquete', CAST(N'2017-08-02T11:41:39.557' AS DateTime), CAST(N'2017-08-03T01:41:38.950' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (76, 42, N'H74912116012', N'Model-choice 300 flop (5pk)', N'Paquete', CAST(N'2017-08-02T11:42:04.523' AS DateTime), CAST(N'2017-08-03T01:42:03.920' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (77, 42, N'H7491211601J2', N'Model-choice 300 flop j (5pk)', N'Paquete', CAST(N'2017-08-02T11:42:33.113' AS DateTime), CAST(N'2017-08-03T01:42:32.510' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (78, 42, N'H74912133012', N'Model-choice int (5pk)', N'Paquete', CAST(N'2017-08-02T11:46:07.767' AS DateTime), CAST(N'2017-08-03T01:46:07.160' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (79, 42, N'H7491213301J2', N'Model-choice int j (5pk)', N'Paquete', CAST(N'2017-08-02T11:46:46.387' AS DateTime), CAST(N'2017-08-03T01:46:45.783' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (80, 42, N'H74912117012', N'Model-choice 300 int (5pk)', N'Paquete', CAST(N'2017-08-02T11:47:23.930' AS DateTime), CAST(N'2017-08-16T06:12:19.877' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (81, 42, N'H7491211701J2', N'Model-choice 300 int j (5pk)', N'Paquete', CAST(N'2017-08-02T11:49:53.963' AS DateTime), CAST(N'2017-08-03T01:49:53.360' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (82, 42, N'H74912134012', N'Model-choice std (15pk)', N'Paquete', CAST(N'2017-08-02T11:51:15.997' AS DateTime), CAST(N'2017-08-03T01:51:15.393' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (83, 42, N'H7491213401J2', N'Model-choice std j (5pk)', N'Paquete', CAST(N'2017-08-02T11:53:10.780' AS DateTime), CAST(N'2017-08-03T01:53:10.177' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (84, 42, N'H74912118012', N'Model-choice 300 std (5pk)', N'Paquete', CAST(N'2017-08-02T11:53:52.730' AS DateTime), CAST(N'2017-08-03T01:53:52.127' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (85, 42, N'H7491211801J2', N'Model-choice 300 std j (5pk)', N'Paquete', CAST(N'2017-08-02T11:55:18.273' AS DateTime), CAST(N'2017-08-03T01:55:17.670' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (86, 42, N'H74912160012', N'Model-choice pt (5pk)', N'Paquete', CAST(N'2017-08-02T12:14:56.427' AS DateTime), CAST(N'2017-08-03T02:14:58.217' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (87, 42, N'H7491216001J2', N'Model-choice pt j (5pk)', N'Paquete', CAST(N'2017-08-02T12:15:22.523' AS DateTime), CAST(N'2017-08-03T02:15:24.317' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (88, 42, N'H74912154012', N'Model-choice 300 pt (5pk)', N'Paquete', CAST(N'2017-08-02T12:17:47.567' AS DateTime), CAST(N'2017-08-03T02:17:49.360' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (89, 42, N'H7491215401J2', N'Model:choice 300 pt j (5pk)', N'Paquete', CAST(N'2017-08-02T12:18:15.923' AS DateTime), CAST(N'2017-08-03T02:18:17.717' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (90, 42, N'H7491211701J2', N'Model-choice 300 int j (5pk)', N'Paquete', CAST(N'2017-08-02T12:22:19.877' AS DateTime), CAST(N'2017-08-03T02:22:21.670' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (91, 42, N'H74912118012', N'Model-choice 300 std (5pk)', N'Paquete', CAST(N'2017-08-02T12:23:04.947' AS DateTime), CAST(N'2017-08-03T02:23:06.743' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (92, 42, N'H7491211801J2', N'Model-choice 300 std j (5pk)', N'Paquete', CAST(N'2017-08-02T12:23:57.443' AS DateTime), CAST(N'2017-08-03T02:23:59.240' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (93, 42, N'H74914903012', N'Model-graphix std (5pk)', N'Paquete', CAST(N'2017-08-02T12:25:00.547' AS DateTime), CAST(N'2017-08-03T02:25:02.343' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (94, 42, N'H74912135012', N'Model-choice es (5pk)', N'Paquete', CAST(N'2017-08-02T12:25:26.117' AS DateTime), CAST(N'2017-08-03T02:25:27.910' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (95, 42, N'H74912119012', N'Model-choice 300 es (5pk)', N'Paquete', CAST(N'2017-08-02T12:25:48.400' AS DateTime), CAST(N'2017-08-16T06:11:57.763' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (96, 42, N'H74912155012', N'Model-choice 300 pt es (5pk)', N'Paquete', CAST(N'2017-08-02T12:29:38.693' AS DateTime), CAST(N'2017-08-03T02:29:40.487' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (97, 43, N'SPL12506X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 1.25mm x 06mm', N'Pieza', CAST(N'2017-08-03T12:09:04.473' AS DateTime), CAST(N'2017-08-03T12:11:11.873' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (98, 43, N'SPL20006X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.00mm x 06mm', N'Pieza', CAST(N'2017-08-03T12:21:29.050' AS DateTime), CAST(N'2017-08-03T12:21:26.383' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (99, 43, N'SPL25006X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.50mm x 06mm', N'Pieza', CAST(N'2017-08-03T12:22:16.213' AS DateTime), CAST(N'2017-08-03T12:22:13.543' AS DateTime))
GO
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (100, 43, N'SPL30006X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.00mm x 06mm', N'Pieza', CAST(N'2017-08-03T12:23:33.427' AS DateTime), CAST(N'2017-08-03T12:23:30.760' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (101, 43, N'SPL40006X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 4.00mm x 06mm', N'Pieza', CAST(N'2017-08-03T12:24:21.493' AS DateTime), CAST(N'2017-08-03T12:24:18.827' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (102, 43, N'SPL15010X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 1.50mm x 10mm', N'Pieza', CAST(N'2017-08-03T12:25:34.080' AS DateTime), CAST(N'2017-08-03T12:25:31.407' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (103, 43, N'SPL22510X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.25mm x 10mm', N'Pieza', CAST(N'2017-08-03T12:27:07.417' AS DateTime), CAST(N'2017-08-03T12:27:04.743' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (104, 43, N'SPL30010X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.00mm x 10mm', N'Pieza', CAST(N'2017-08-03T12:30:46.223' AS DateTime), CAST(N'2017-08-03T12:30:43.553' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (105, 43, N'SPL40010X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 4.00mm x 10mm', N'Pieza', CAST(N'2017-08-03T12:30:58.970' AS DateTime), CAST(N'2017-08-03T12:30:56.303' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (106, 43, N'SPL15012X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 1.50mm x 12mm', N'Pieza', CAST(N'2017-08-03T12:31:42.697' AS DateTime), CAST(N'2017-08-03T12:31:40.023' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (107, 43, N'SPL22512X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.25mm x 12mm', N'Pieza', CAST(N'2017-08-03T12:32:13.740' AS DateTime), CAST(N'2017-08-03T12:32:11.073' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (108, 43, N'SPL27512X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.75mm x 12mm', N'Pieza', CAST(N'2017-08-03T12:32:31.480' AS DateTime), CAST(N'2017-08-03T12:32:28.810' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (109, 43, N'SPL32512X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.25mm x 12mm', N'Pieza', CAST(N'2017-08-03T12:32:49.883' AS DateTime), CAST(N'2017-08-03T12:32:47.217' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (110, 43, N'SPL37512X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.75mm x 12mm', N'Pieza', CAST(N'2017-08-03T12:33:53.830' AS DateTime), CAST(N'2017-08-03T12:33:51.160' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (111, 43, N'SPL12515X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 1.25mm x 15mm', N'Pieza', CAST(N'2017-08-03T12:34:29.997' AS DateTime), CAST(N'2017-08-03T12:34:27.330' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (112, 43, N'SPL20015X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.00mm x 15mm', N'Pieza', CAST(N'2017-08-03T12:39:22.647' AS DateTime), CAST(N'2017-08-03T12:39:19.977' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (113, 43, N'SPL25015X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.50mm x 15mm', N'Pieza', CAST(N'2017-08-03T12:39:43.870' AS DateTime), CAST(N'2017-08-03T12:39:41.200' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (114, 43, N'SPL30015X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.00mm x 15mm', N'Pieza', CAST(N'2017-08-03T12:40:07.000' AS DateTime), CAST(N'2017-08-03T12:40:04.320' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (115, 43, N'SPL35015X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.50mm x 15mm', N'Pieza', CAST(N'2017-08-03T12:40:22.490' AS DateTime), CAST(N'2017-08-03T12:40:19.817' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (116, 43, N'SPL40015X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 4.00mm x 15mm', N'Pieza', CAST(N'2017-08-03T12:40:38.437' AS DateTime), CAST(N'2017-08-03T12:40:35.770' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (117, 43, N'SPL15020X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 1.50mm x 20mm', N'Pieza', CAST(N'2017-08-03T12:41:41.883' AS DateTime), CAST(N'2017-08-03T12:41:39.210' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (118, 43, N'SPL22520X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.25mm x 20mm', N'Pieza', CAST(N'2017-08-03T12:42:14.613' AS DateTime), CAST(N'2017-08-03T12:42:11.943' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (119, 43, N'SPL27520X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.75mm x 20mm', N'Pieza', CAST(N'2017-08-03T12:42:43.203' AS DateTime), CAST(N'2017-08-03T12:42:40.530' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (120, 43, N'SPL32520X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.25mm x 20mm', N'Pieza', CAST(N'2017-08-03T12:43:11.197' AS DateTime), CAST(N'2017-08-03T12:43:08.530' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (121, 43, N'SPL37520X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.75mm x 20mm', N'Pieza', CAST(N'2017-08-03T12:43:29.753' AS DateTime), CAST(N'2017-08-03T12:44:35.137' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (122, 43, N'SPL20025X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.00mm x 25mm', N'Pieza', CAST(N'2017-08-03T12:46:09.203' AS DateTime), CAST(N'2017-08-03T12:46:06.530' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (123, 43, N'SPL25025X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.50mm x 25mm', N'Pieza', CAST(N'2017-08-03T12:46:56.443' AS DateTime), CAST(N'2017-08-03T12:46:53.770' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (124, 43, N'SPL30025X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.00mm x 25mm', N'Pieza', CAST(N'2017-08-03T12:47:26.893' AS DateTime), CAST(N'2017-08-03T12:47:24.223' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (125, 43, N'SPL40025X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 4.00mm x 25mm', N'Pieza', CAST(N'2017-08-03T12:47:45.230' AS DateTime), CAST(N'2017-08-03T12:47:42.560' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (126, 43, N'SPL25030X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.50mm x 30mm', N'Pieza', CAST(N'2017-08-03T12:48:14.043' AS DateTime), CAST(N'2017-08-03T12:48:11.370' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (127, 43, N'SPL35030X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.50mm x 30mm', N'Pieza', CAST(N'2017-08-03T12:48:32.337' AS DateTime), CAST(N'2017-08-03T12:48:29.667' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (128, 43, N'SPL15006X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 1.50mm x 06mm', N'Pieza', CAST(N'2017-08-03T12:50:36.237' AS DateTime), CAST(N'2017-08-03T12:50:33.560' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (129, 43, N'SPL22506X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.25mm x 06mm', N'Pieza', CAST(N'2017-08-03T12:51:05.010' AS DateTime), CAST(N'2017-08-03T12:51:02.337' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (130, 43, N'SPL27506X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.75mm x 06mm', N'Pieza', CAST(N'2017-08-03T12:51:34.373' AS DateTime), CAST(N'2017-08-03T12:51:31.697' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (131, 43, N'SPL35006X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.50mm x 06mm', N'Pieza', CAST(N'2017-08-03T12:52:08.737' AS DateTime), CAST(N'2017-08-03T12:52:06.067' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (132, 43, N'SPL12510X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 1.25mm x 10mm', N'Pieza', CAST(N'2017-08-03T12:52:54.767' AS DateTime), CAST(N'2017-08-03T12:52:52.080' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (133, 43, N'SPL20010X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.00mm x 10mm', N'Pieza', CAST(N'2017-08-03T12:53:10.857' AS DateTime), CAST(N'2017-08-03T12:54:25.907' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (134, 43, N'SPL25010X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.50mm x 10mm', N'Pieza', CAST(N'2017-08-03T12:55:14.630' AS DateTime), CAST(N'2017-08-03T12:55:11.953' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (135, 43, N'SPL35010X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.50mm x 10mm', N'Pieza', CAST(N'2017-08-03T12:55:35.317' AS DateTime), CAST(N'2017-08-03T12:55:32.640' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (136, 43, N'SPL12512X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 1.25mm x 12mm', N'Pieza', CAST(N'2017-08-03T12:56:34.183' AS DateTime), CAST(N'2017-08-03T12:56:31.507' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (137, 43, N'SPL20012X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 200mm x 12mm', N'Pieza', CAST(N'2017-08-03T12:56:58.440' AS DateTime), CAST(N'2017-08-03T12:58:09.650' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (138, 43, N'SPL25012X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 250mm x 12mm', N'Pieza', CAST(N'2017-08-03T12:59:25.300' AS DateTime), CAST(N'2017-08-03T12:59:30.130' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (139, 43, N'SPL30012X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.00mm x 12mm', N'Pieza', CAST(N'2017-08-03T13:09:06.137' AS DateTime), CAST(N'2017-08-03T13:09:03.460' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (140, 43, N'SPL35012X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.50mm x 12mm', N'Pieza', CAST(N'2017-08-03T13:09:35.467' AS DateTime), CAST(N'2017-08-03T13:09:32.793' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (141, 43, N'SPL40012X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 4.00mm x 12mm', N'Pieza', CAST(N'2017-08-03T13:09:53.470' AS DateTime), CAST(N'2017-08-03T13:09:50.787' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (142, 43, N'SPL15015X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 1.50mm x 15mm', N'Pieza', CAST(N'2017-08-03T13:10:56.623' AS DateTime), CAST(N'2017-08-03T13:10:53.947' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (143, 43, N'SPL22515X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.25mm x 15mm', N'Pieza', CAST(N'2017-08-03T13:11:17.460' AS DateTime), CAST(N'2017-08-03T13:11:14.787' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (144, 43, N'SPL27515X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.75mm x 15mm', N'Pieza', CAST(N'2017-08-03T13:12:03.140' AS DateTime), CAST(N'2017-08-03T13:12:00.457' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (145, 43, N'SPL32515X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.25mm x 15mm', N'Pieza', CAST(N'2017-08-03T13:12:25.730' AS DateTime), CAST(N'2017-08-03T13:12:23.057' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (146, 43, N'SPL37515X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.75mm x 15mm', N'Pieza', CAST(N'2017-08-03T13:13:42.017' AS DateTime), CAST(N'2017-08-03T13:13:39.337' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (147, 43, N'SPL12520X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 1.25mm x 20mm', N'Pieza', CAST(N'2017-08-03T13:15:38.063' AS DateTime), CAST(N'2017-08-03T13:15:35.387' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (148, 43, N'SPL20020X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.00mm x 20mm', N'Pieza', CAST(N'2017-08-03T13:15:57.087' AS DateTime), CAST(N'2017-08-03T13:15:54.413' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (149, 43, N'SPL25020X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.50mm x 20mm', N'Pieza', CAST(N'2017-08-03T13:16:11.603' AS DateTime), CAST(N'2017-08-03T13:16:08.930' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (150, 43, N'SPL30020X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.00mm x 20mm', N'Pieza', CAST(N'2017-08-03T13:16:28.783' AS DateTime), CAST(N'2017-08-03T13:16:26.107' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (151, 43, N'SPL35020X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.50mm x 20mm', N'Pieza', CAST(N'2017-08-03T13:16:43.820' AS DateTime), CAST(N'2017-08-03T13:16:41.147' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (152, 43, N'SPL40020X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 4.00mm x 20mm', N'Pieza', CAST(N'2017-08-03T13:17:02.070' AS DateTime), CAST(N'2017-08-03T13:16:59.393' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (153, 43, N'SPL22525X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.25mm x 25mm', N'Pieza', CAST(N'2017-08-03T13:17:35.750' AS DateTime), CAST(N'2017-08-03T13:17:33.073' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (154, 43, N'SPL27525X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.75mm x 25mm', N'Pieza', CAST(N'2017-08-03T13:17:52.133' AS DateTime), CAST(N'2017-08-03T13:17:49.457' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (155, 43, N'SPL35025X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.50mm x 25mm', N'Pieza', CAST(N'2017-08-03T13:18:43.360' AS DateTime), CAST(N'2017-08-03T13:18:40.683' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (156, 43, N'SPL20030X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 2.00mm x 30mm', N'Pieza', CAST(N'2017-08-03T13:19:22.157' AS DateTime), CAST(N'2017-08-03T13:19:19.483' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (157, 43, N'SPL30030X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 3.00mm x 30mm', N'Pieza', CAST(N'2017-08-03T13:20:30.643' AS DateTime), CAST(N'2017-08-03T13:20:27.963' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (158, 43, N'SPL40030X', N'Cateter balon de rapido intercambio cuerpo 142 cm de 4.00mm x 30mm', N'Pieza', CAST(N'2017-08-03T13:20:41.823' AS DateTime), CAST(N'2017-08-03T13:20:39.147' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (159, 45, N'402-03', N'Equipo medico para monitorear la hemostasis en cirugia cardiovascular', N'Pieza', CAST(N'2017-08-03T13:38:42.773' AS DateTime), CAST(N'2017-08-03T13:38:40.093' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (160, 45, N'402-01', N'Equipo medico para monitorear la hemostasis en cirugia cardiovascular', N'Pieza', CAST(N'2017-08-03T13:38:48.433' AS DateTime), CAST(N'2017-08-03T13:38:45.757' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (161, 46, N'MCS-P3-2334', N'Pav de 23 mm (válvula percutánea aórtica)', N'Pieza', CAST(N'2017-08-03T15:27:05.807' AS DateTime), CAST(N'2017-08-03T15:27:03.090' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (162, 46, N'MCS-P3-640', N'Pav de 26 mm (válvula percutánea aórtica)', N'Pieza', CAST(N'2017-08-03T15:27:34.457' AS DateTime), CAST(N'2017-08-03T15:27:31.743' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (163, 46, N'MCS-P3-943', N'Pav de 29 mm (válvula percutánea aórtica)', N'Pieza', CAST(N'2017-08-03T15:27:47.537' AS DateTime), CAST(N'2017-08-03T15:27:44.823' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (164, 46, N'MCS-P3-3143', N'Pav de 31 mm (válvula percutánea aórtica)', N'Pieza', CAST(N'2017-08-03T15:28:01.720' AS DateTime), CAST(N'2017-08-03T15:27:59.007' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (165, 47, N'6682-M1', N'Guias para cateter 3mm j , 0.021 pulgadas y 150 cm  de largo', N'Pieza', CAST(N'2017-08-03T16:50:20.847' AS DateTime), CAST(N'2017-08-03T16:50:42.130' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (166, 47, N'6682-N3', N'Guias para cateter 3mm j , 0.021 pulgadas y 180 cm  de largo', N'Pieza', CAST(N'2017-08-03T16:52:39.927' AS DateTime), CAST(N'2017-08-03T16:52:37.197' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (167, 47, N'6682-E1', N'Guias para cateter 3mm j , 0.025 pulgadas y 150 cm  de largo', N'Pieza', CAST(N'2017-08-03T16:53:07.710' AS DateTime), CAST(N'2017-08-03T16:53:04.980' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (168, 47, N'6682-41', N'Guias para cateter 3mm j , 0.038 pulgadas y 150 cm  de largo', N'Pieza', CAST(N'2017-08-03T16:53:36.770' AS DateTime), CAST(N'2017-08-03T16:53:34.043' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (169, 47, N'6682-C1', N'Guias para cateter 3mm j , 0.035 pulgadas y 150 cm  de largo', N'Pieza', CAST(N'2017-08-03T16:54:56.397' AS DateTime), CAST(N'2017-08-03T16:54:53.667' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (170, 48, N'', N'Cobija tamaño adulto reusable', N'Pieza', CAST(N'2017-08-04T10:25:47.170' AS DateTime), CAST(N'2017-08-04T10:30:17.707' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (171, 48, N'', N'Cobija tamaño pediatrico reusable', N'Pieza', CAST(N'2017-08-04T10:27:16.203' AS DateTime), CAST(N'2017-08-04T10:30:08.793' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (172, 48, N'', N'Cobija tamaño infantil reusable', N'Pieza', CAST(N'2017-08-04T10:27:33.600' AS DateTime), CAST(N'2017-08-04T10:30:02.370' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (173, 48, N'', N'Cobija tamaño adulto desechable', N'Pieza', CAST(N'2017-08-04T10:27:48.403' AS DateTime), CAST(N'2017-08-04T10:29:57.203' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (174, 48, N'', N'Cobija tamaño pediatrico desechable', N'Pieza', CAST(N'2017-08-04T10:28:10.647' AS DateTime), CAST(N'2017-08-04T10:29:50.947' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (175, 48, N'', N'Cobija tamaño infantil desechable', N'Pieza', CAST(N'2017-08-04T10:29:44.383' AS DateTime), CAST(N'2017-08-04T10:29:40.427' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (176, 48, N'', N'Cobija en "u" de 11 x 12 reusable', N'Pieza', CAST(N'2017-08-04T10:30:50.997' AS DateTime), CAST(N'2017-08-04T10:30:47.043' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (177, 48, N'', N'Cobija de 12 x 15" reusable ', N'Pieza', CAST(N'2017-08-04T10:31:18.453' AS DateTime), CAST(N'2017-08-04T10:31:14.500' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (178, 48, N'', N'Cobija de 3 x 18" reusable ', N'Pieza', CAST(N'2017-08-04T10:31:30.517' AS DateTime), CAST(N'2017-08-04T10:31:26.563' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (179, 48, N'', N'Cobija de 3 x 20" reusable ', N'Pieza', CAST(N'2017-08-04T10:32:00.620' AS DateTime), CAST(N'2017-08-04T10:32:13.073' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (180, 48, N'', N'Cobija de 5 x 10" reusable ', N'Pieza', CAST(N'2017-08-04T10:32:50.847' AS DateTime), CAST(N'2017-08-04T10:32:46.890' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (181, 48, N'', N'Cobija de 8 x 14" reusable ', N'Pieza', CAST(N'2017-08-04T10:33:04.557' AS DateTime), CAST(N'2017-08-04T10:33:00.603' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (182, 48, N'', N'Cobija de 10 x 11" reusable ', N'Pieza', CAST(N'2017-08-04T10:33:18.663' AS DateTime), CAST(N'2017-08-04T10:33:14.707' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (183, 48, N'', N'Cobija de 11 x 12" reusable ', N'Pieza', CAST(N'2017-08-04T10:33:25.027' AS DateTime), CAST(N'2017-08-04T10:33:21.073' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (184, 48, N'', N'Cobija de 12 x 18" reusable ', N'Pieza', CAST(N'2017-08-04T10:33:33.897' AS DateTime), CAST(N'2017-08-04T10:33:29.947' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (185, 48, N'', N'Cobija para tobillo de 7x 6" reusable', N'Pieza', CAST(N'2017-08-04T10:33:59.287' AS DateTime), CAST(N'2017-08-04T10:33:55.330' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (186, 48, N'', N'Manguera de conexión para cobijas reusables o desechables', N'Pieza', CAST(N'2017-08-04T10:34:32.393' AS DateTime), CAST(N'2017-08-04T10:34:28.437' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (187, 48, N'', N'Manguera de conexión de 30.5 cm', N'Pieza', CAST(N'2017-08-04T10:34:51.950' AS DateTime), CAST(N'2017-08-04T10:35:07.507' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (188, 48, N'', N'Manguera de conexión de 38.1 cm', N'Pieza', CAST(N'2017-08-04T10:35:30.990' AS DateTime), CAST(N'2017-08-04T10:35:27.033' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (189, 48, N'', N'Cobija desechable en tubo de 28 x 66"', N'Pieza', CAST(N'2017-08-04T10:36:00.893' AS DateTime), CAST(N'2017-08-04T10:35:56.937' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (190, 48, N'', N'Cobija desechable para uci adulto de 92 x 60"', N'Pieza', CAST(N'2017-08-04T10:36:20.143' AS DateTime), CAST(N'2017-08-04T10:36:16.187' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (191, 48, N'', N'Cobija desechable para uci pediatrica de 52 x 40"', N'Pieza', CAST(N'2017-08-04T10:36:44.477' AS DateTime), CAST(N'2017-08-04T10:36:40.523' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (192, 48, N'', N'Cobija desechable para quiriofanos superior de 58 x 40"', N'Pieza', CAST(N'2017-08-04T10:37:31.580' AS DateTime), CAST(N'2017-08-04T10:37:27.627' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (193, 48, N'', N'Cobija desechable para quiriofanos inferior de 88 x 30"', N'Pieza', CAST(N'2017-08-04T10:37:49.193' AS DateTime), CAST(N'2017-08-04T10:37:45.243' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (194, 48, N'', N'Filtro de 0.3 micras', N'Pieza', CAST(N'2017-08-04T10:38:12.567' AS DateTime), CAST(N'2017-08-04T10:38:08.610' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (195, 48, N'', N'Filtro de 0.05 micras', N'Pieza', CAST(N'2017-08-04T10:38:20.790' AS DateTime), CAST(N'2017-08-04T10:38:16.833' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (196, 48, N'', N'Soporte rodable', N'Pieza', CAST(N'2017-08-04T10:38:30.590' AS DateTime), CAST(N'2017-08-04T10:38:26.633' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (197, 48, N'', N'Cubierta desechable para cobija adulto ', N'Pieza', CAST(N'2017-08-04T10:38:43.487' AS DateTime), CAST(N'2017-08-04T10:38:39.530' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (198, 48, N'', N'Cubierta desechable para cobija pediatrica', N'Pieza', CAST(N'2017-08-04T10:38:52.270' AS DateTime), CAST(N'2017-08-04T10:38:48.313' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (199, 48, N'', N'Cubierta desechable para cobija infantil', N'Pieza', CAST(N'2017-08-04T10:39:00.950' AS DateTime), CAST(N'2017-08-04T10:38:56.993' AS DateTime))
GO
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (200, 48, N'', N'Sondas de temperatura reusables', N'Pieza', CAST(N'2017-08-04T10:39:20.503' AS DateTime), CAST(N'2017-08-04T10:39:16.547' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (201, 48, N'', N'Sondas de temperatura desechables', N'Pieza', CAST(N'2017-08-04T10:39:33.173' AS DateTime), CAST(N'2017-08-04T10:39:29.220' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (202, 49, N'406102', N'Fast-cath hemostasis introducer. 5f , 12cm, with accesories', N'Pieza', CAST(N'2017-08-04T10:59:56.200' AS DateTime), CAST(N'2017-08-04T10:59:52.240' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (203, 49, N'406103', N'Fast-cath hemostasis introducer. 6f , 12cm, with accesories', N'Pieza', CAST(N'2017-08-04T11:00:28.327' AS DateTime), CAST(N'2017-08-04T11:00:24.373' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (204, 49, N'406107', N'Fast-cath hemostasis introducer. 7f , 12cm, with accesories', N'Pieza', CAST(N'2017-08-04T11:01:02.607' AS DateTime), CAST(N'2017-08-04T11:00:58.650' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (205, 49, N'406114', N'Fast-cath hemostasis introducer. 8f , 12cm, with accesories', N'Pieza', CAST(N'2017-08-04T11:01:25.400' AS DateTime), CAST(N'2017-08-04T11:01:21.443' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (206, 49, N'406100', N'Fast-cath hemostasis introducer. 5f , 12cm', N'Pieza', CAST(N'2017-08-04T11:02:17.873' AS DateTime), CAST(N'2017-08-04T11:03:21.637' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (207, 49, N'406104', N'Fast-cath hemostasis introducer. 6f , 12cm', N'Pieza', CAST(N'2017-08-04T11:02:38.350' AS DateTime), CAST(N'2017-08-04T11:03:48.523' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (208, 49, N'406108', N'Fast-cath hemostasis introducer. 7f , 12cm', N'Pieza', CAST(N'2017-08-04T11:02:59.853' AS DateTime), CAST(N'2017-08-04T11:04:20.633' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (209, 49, N'406112', N'Fast-cath hemostasis introducer. 8f , 12cm', N'Pieza', CAST(N'2017-08-04T11:05:43.973' AS DateTime), CAST(N'2017-08-04T11:05:40.010' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (210, 49, N'406115', N'Fast-cath hemostasis introducer. 4f , 12cm, small gw', N'Pieza', CAST(N'2017-08-04T11:06:28.983' AS DateTime), CAST(N'2017-08-04T11:07:23.540' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (211, 49, N'406101', N'Fast-cath hemostasis introducer. 5f , 12cm, small gw', N'Pieza', CAST(N'2017-08-04T11:08:08.863' AS DateTime), CAST(N'2017-08-04T11:08:04.907' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (212, 49, N'406105', N'Fast-cath hemostasis introducer. 6f , 12cm, small gw', N'Pieza', CAST(N'2017-08-04T11:08:31.350' AS DateTime), CAST(N'2017-08-04T11:09:18.563' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (213, 49, N'406109', N'Fast-cath hemostasis introducer. 7f , 12cm, small gw', N'Pieza', CAST(N'2017-08-04T11:09:08.880' AS DateTime), CAST(N'2017-08-04T11:09:04.923' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (214, 49, N'406553', N'Fast-cath transseptal guiding introducer', N'Pieza', CAST(N'2017-08-04T11:13:49.740' AS DateTime), CAST(N'2017-08-04T11:13:45.780' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (215, 49, N'406805', N'Fast-cath transseptal guiding introducer', N'Pieza', CAST(N'2017-08-04T11:14:22.720' AS DateTime), CAST(N'2017-08-04T11:14:18.763' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (216, 49, N'406590', N'Fast-cath hemostasis introducer, 9.5f, 30 cm, with obturador 8f', N'Pieza', CAST(N'2017-08-04T11:16:13.933' AS DateTime), CAST(N'2017-08-04T11:16:09.970' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (217, 49, N'406591', N'Fast-cath hemostasis introducer, 10f, 30 cm, with obturador 9f', N'Pieza', CAST(N'2017-08-04T11:17:17.490' AS DateTime), CAST(N'2017-08-04T11:17:13.530' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (218, 49, N'406592', N'Fast-cath hemostasis introducer, 10.5f, 30 cm, with obturador 9f', N'Pieza', CAST(N'2017-08-04T11:17:45.123' AS DateTime), CAST(N'2017-08-04T11:17:41.163' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (219, 49, N'406593', N'Fast-cath hemostasis introducer, 11f, 30 cm, with obturador 10f', N'Pieza', CAST(N'2017-08-04T11:18:16.650' AS DateTime), CAST(N'2017-08-04T11:18:12.690' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (220, 49, N'406594', N'Fast-cath hemostasis introducer, 12f, 30 cm, with obturador 11f', N'Pieza', CAST(N'2017-08-04T11:18:44.290' AS DateTime), CAST(N'2017-08-04T11:18:40.330' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (221, 49, N'406840', N'Fast-cath guiding introducer', N'Pieza', CAST(N'2017-08-04T11:20:52.683' AS DateTime), CAST(N'2017-08-04T11:20:48.723' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (222, 49, N'406849', N'Fast-cath guiding introducer, swariz sl transseptal series 8f', N'Pieza', CAST(N'2017-08-04T11:22:12.100' AS DateTime), CAST(N'2017-08-04T11:22:08.140' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (223, 49, N'407202', N'Brk transseptal needle', N'Pieza', CAST(N'2017-08-04T11:23:17.703' AS DateTime), CAST(N'2017-08-04T11:23:13.740' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (224, 49, N'407203', N'Brk-2 transseptal needle', N'Pieza', CAST(N'2017-08-04T11:23:40.150' AS DateTime), CAST(N'2017-08-04T11:23:36.187' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (225, 49, N'406841', N'Fast-cath guiding introducer', N'Pieza', CAST(N'2017-08-04T11:25:02.343' AS DateTime), CAST(N'2017-08-04T11:24:58.380' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (226, 49, N'406842', N'Fast-cath guiding introducer', N'Pieza', CAST(N'2017-08-04T11:25:16.913' AS DateTime), CAST(N'2017-08-04T11:25:12.957' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (227, 49, N'406843', N'Fast-cath guiding introducer, swartz sl transseptal series 7.5f', N'Pieza', CAST(N'2017-08-04T11:26:01.967' AS DateTime), CAST(N'2017-08-04T11:25:58.003' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (228, 50, N'M001182510', N'F/c renegade 150/10/1tip', N'Pieza', CAST(N'2017-08-04T11:43:53.493' AS DateTime), CAST(N'2017-08-05T01:43:55.180' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (229, 50, N'M001182530', N'F/c renegade 150/20/1tip', N'Pieza', CAST(N'2017-08-04T11:44:29.077' AS DateTime), CAST(N'2017-08-05T01:44:30.763' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (230, 49, N'406850', N'Fast-cath guiding introducer', N'Pieza', CAST(N'2017-08-04T11:46:25.383' AS DateTime), CAST(N'2017-08-04T11:46:24.053' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (231, 49, N'406851', N'Fast-cath guiding introducer', N'Pieza', CAST(N'2017-08-04T11:46:37.743' AS DateTime), CAST(N'2017-08-04T11:46:36.417' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (232, 49, N'406852', N'Fast-cath guiding introducer', N'Pieza', CAST(N'2017-08-04T11:46:56.353' AS DateTime), CAST(N'2017-08-04T11:46:55.027' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (233, 49, N'406853', N'Fast-cath guiding introducer', N'Pieza', CAST(N'2017-08-04T11:47:20.633' AS DateTime), CAST(N'2017-08-04T11:47:19.307' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (234, 49, N'406854', N'Fast-cath guiding introducer', N'Pieza', CAST(N'2017-08-04T11:47:39.927' AS DateTime), CAST(N'2017-08-04T11:47:38.593' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (235, 50, N'M001182840', N'Renegade hi flo 105/10', N'Pieza', CAST(N'2017-08-04T11:50:39.930' AS DateTime), CAST(N'2017-08-05T01:50:41.617' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (236, 50, N'M001182850', N'Renegade hi flo 105/20', N'Pieza', CAST(N'2017-08-04T11:50:55.303' AS DateTime), CAST(N'2017-08-05T01:50:56.997' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (237, 50, N'M001182860', N'Renegade hi flo 115/10', N'Pieza', CAST(N'2017-08-04T11:51:21.967' AS DateTime), CAST(N'2017-08-05T01:51:23.653' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (238, 50, N'M001182870', N'Renegade hi flo 115/20', N'Pieza', CAST(N'2017-08-04T11:52:10.117' AS DateTime), CAST(N'2017-08-05T01:52:11.803' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (239, 49, N'407200', N'Brk transspetal neddle', N'Pieza', CAST(N'2017-08-04T12:21:14.797' AS DateTime), CAST(N'2017-08-04T12:21:13.460' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (240, 49, N'407201', N'Brk-1 transspetal neddle', N'Pieza', CAST(N'2017-08-04T12:21:30.803' AS DateTime), CAST(N'2017-08-04T12:21:29.467' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (241, 51, N'SPT002', N'Cateter para septostomía-imisa ', N'Pieza', CAST(N'2017-08-04T12:34:00.607' AS DateTime), CAST(N'2017-08-04T12:33:59.267' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (242, 51, N'SPT003', N'Cateter para septostomía-imisa ', N'Pieza', CAST(N'2017-08-04T12:34:07.747' AS DateTime), CAST(N'2017-08-04T12:34:06.410' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (243, 52, N'MTK 145', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T16:44:00.230' AS DateTime), CAST(N'2017-08-04T18:11:28.580' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (244, 52, N'RMC 145', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T16:44:40.883' AS DateTime), CAST(N'2017-08-04T18:11:24.230' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (245, 52, N'MMTA0580', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:12:14.987' AS DateTime), CAST(N'2017-08-04T18:11:19.997' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (246, 52, N'RM0281', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:12:30.993' AS DateTime), CAST(N'2017-08-04T18:11:13.580' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (247, 52, N'RM0279-01', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:12:42.540' AS DateTime), CAST(N'2017-08-04T18:11:09.827' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (248, 52, N'SO004', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:51:48.633' AS DateTime), CAST(N'2017-08-04T18:11:06.267' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (249, 52, N'SO035', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:51:57.170' AS DateTime), CAST(N'2017-08-04T18:11:01.780' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (250, 52, N'SO036', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:52:03.343' AS DateTime), CAST(N'2017-08-04T18:10:58.723' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (251, 52, N'SO043', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:52:12.440' AS DateTime), CAST(N'2017-08-04T18:10:54.860' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (252, 52, N'SO069', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:52:19.543' AS DateTime), CAST(N'2017-08-04T18:10:51.590' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (253, 52, N'SO018', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:53:13.093' AS DateTime), CAST(N'2017-08-04T18:10:46.547' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (254, 52, N'PDC511', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:53:22.687' AS DateTime), CAST(N'2017-08-04T18:10:43.077' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (255, 52, N'PDC512', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:53:29.137' AS DateTime), CAST(N'2017-08-04T18:10:39.787' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (256, 52, N'PDC513', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:53:33.930' AS DateTime), CAST(N'2017-08-04T18:10:35.677' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (257, 52, N'PDC514', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:53:38.433' AS DateTime), CAST(N'2017-08-04T18:10:31.100' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (258, 52, N'PDC515', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:53:43.467' AS DateTime), CAST(N'2017-08-04T18:10:26.133' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (259, 52, N'PDC516', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:53:47.560' AS DateTime), CAST(N'2017-08-04T18:10:19.997' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (260, 52, N'PDC517', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:53:54.057' AS DateTime), CAST(N'2017-08-04T18:10:14.253' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (261, 52, N'PDC518', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:53:59.490' AS DateTime), CAST(N'2017-08-04T18:10:09.620' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (262, 52, N'SN002', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:54:11.890' AS DateTime), CAST(N'2017-08-04T18:10:04.627' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (263, 52, N'PDC513', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:54:20.830' AS DateTime), CAST(N'2017-08-04T18:09:59.820' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (264, 52, N'PDC514', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:54:25.953' AS DateTime), CAST(N'2017-08-04T18:09:55.043' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (265, 52, N'PDC515', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:54:32.933' AS DateTime), CAST(N'2017-08-04T18:09:50.027' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (266, 52, N'PDC516', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:54:40.313' AS DateTime), CAST(N'2017-08-04T18:09:44.843' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (267, 52, N'PDC517', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:54:49.933' AS DateTime), CAST(N'2017-08-04T18:09:40.627' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (268, 52, N'PDC518', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:54:54.580' AS DateTime), CAST(N'2017-08-04T18:09:34.140' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (269, 52, N'SN002', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:55:03.957' AS DateTime), CAST(N'2017-08-04T18:09:28.773' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (270, 52, N'PDC519', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:55:11.843' AS DateTime), CAST(N'2017-08-04T18:09:23.483' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (271, 52, N'PDC520', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:55:20.360' AS DateTime), CAST(N'2017-08-04T18:09:19.237' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (272, 52, N'PDC521', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:55:29.610' AS DateTime), CAST(N'2017-08-04T18:09:14.787' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (273, 52, N'PDC522', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:55:35.210' AS DateTime), CAST(N'2017-08-04T18:09:09.860' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (274, 52, N'PDC523', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:55:43.343' AS DateTime), CAST(N'2017-08-04T18:09:01.627' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (275, 52, N'PDC524', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:55:46.650' AS DateTime), CAST(N'2017-08-04T18:08:56.213' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (276, 52, N'PDC525', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:55:50.410' AS DateTime), CAST(N'2017-08-04T18:08:48.413' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (277, 52, N'PDC526', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:55:56.390' AS DateTime), CAST(N'2017-08-04T18:08:42.947' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (278, 52, N'PDC527', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:56:01.817' AS DateTime), CAST(N'2017-08-04T18:08:26.877' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (279, 52, N'PDC528', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:56:08.097' AS DateTime), CAST(N'2017-08-04T18:08:22.420' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (280, 52, N'PDC529', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:56:12.520' AS DateTime), CAST(N'2017-08-04T18:08:17.963' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (281, 52, N'PDC530', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:56:19.030' AS DateTime), CAST(N'2017-08-04T18:08:13.237' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (282, 52, N'SN001', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:56:25.903' AS DateTime), CAST(N'2017-08-04T18:08:08.620' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (283, 52, N'PDC526', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:56:44.997' AS DateTime), CAST(N'2017-08-04T18:07:51.037' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (284, 52, N'PDC527', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:56:50.273' AS DateTime), CAST(N'2017-08-04T18:07:59.707' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (285, 52, N'PDC528', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:56:54.433' AS DateTime), CAST(N'2017-08-04T18:07:46.620' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (286, 52, N'PDC529', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:56:59.673' AS DateTime), CAST(N'2017-08-04T18:07:41.300' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (287, 52, N'PDC530', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:57:04.760' AS DateTime), CAST(N'2017-08-04T18:07:36.220' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (288, 52, N'SN001', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:57:17.250' AS DateTime), CAST(N'2017-08-04T18:07:30.907' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (289, 52, N'PDC531', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:57:30.293' AS DateTime), CAST(N'2017-08-04T18:07:26.147' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (290, 52, N'PDC532', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:57:34.377' AS DateTime), CAST(N'2017-08-04T18:07:19.283' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (291, 52, N'PDC533', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:57:37.540' AS DateTime), CAST(N'2017-08-04T18:07:14.253' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (292, 52, N'PDC534', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:57:40.963' AS DateTime), CAST(N'2017-08-04T18:07:07.973' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (293, 52, N'SN013', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:57:49.557' AS DateTime), CAST(N'2017-08-04T18:07:00.020' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (294, 52, N'PDC525', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:57:57.440' AS DateTime), CAST(N'2017-08-04T18:06:54.460' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (295, 52, N'PDC535', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:58:03.820' AS DateTime), CAST(N'2017-08-04T18:06:49.613' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (296, 52, N'PDC536', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:58:12.360' AS DateTime), CAST(N'2017-08-04T18:06:43.677' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (301, 52, N'PDC537', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:59:30.953' AS DateTime), CAST(N'2017-08-04T18:06:38.797' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (302, 52, N'PDC538', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T17:59:35.503' AS DateTime), CAST(N'2017-08-04T18:06:32.940' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (303, 52, N'PDC539', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T18:01:41.047' AS DateTime), CAST(N'2017-08-04T18:06:27.843' AS DateTime))
GO
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (304, 52, N'PDC540', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T18:01:50.990' AS DateTime), CAST(N'2017-08-04T18:06:21.950' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (305, 52, N'PDC541', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T18:01:54.950' AS DateTime), CAST(N'2017-08-04T18:06:16.747' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (306, 52, N'PDC542', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T18:01:58.910' AS DateTime), CAST(N'2017-08-04T18:06:11.227' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (307, 52, N'PDC543', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T18:02:02.513' AS DateTime), CAST(N'2017-08-04T18:06:04.453' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (308, 52, N'PDC544', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T18:02:06.540' AS DateTime), CAST(N'2017-08-04T18:05:57.797' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (309, 52, N'PDC545', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T18:02:11.947' AS DateTime), CAST(N'2017-08-04T18:05:53.180' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (310, 52, N'PDC546', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T18:02:15.393' AS DateTime), CAST(N'2017-08-04T18:05:48.507' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (311, 52, N'PDC547', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T18:02:19.650' AS DateTime), CAST(N'2017-08-04T18:05:43.397' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (312, 52, N'PDC548', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T18:02:23.700' AS DateTime), CAST(N'2017-08-04T18:05:36.860' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (313, 52, N'PDC549', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T18:02:27.683' AS DateTime), CAST(N'2017-08-04T18:05:27.260' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (314, 52, N'PDC550', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T18:02:59.380' AS DateTime), CAST(N'2017-08-04T18:05:15.610' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (315, 52, N'SO022', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T18:03:51.643' AS DateTime), CAST(N'2017-08-04T18:05:10.620' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (316, 52, N'SO024', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T18:03:56.100' AS DateTime), CAST(N'2017-08-04T18:05:22.243' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (317, 52, N'SO025', N'Kit de dilatacion mitral multi-track ', N'Pieza', CAST(N'2017-08-04T18:03:59.843' AS DateTime), CAST(N'2017-08-04T18:04:58.750' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (318, 53, N'M0017600121', N'Contour 45-150 2 vials bx/2', N'Caja', CAST(N'2017-08-07T09:45:29.093' AS DateTime), CAST(N'2017-08-07T23:46:07.667' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (319, 53, N'M0017600221', N'Contour 150-250 2 vials bx/2', N'Caja', CAST(N'2017-08-07T09:45:56.270' AS DateTime), CAST(N'2017-08-07T23:45:59.873' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (320, 53, N'M0017600321', N'Contour 250-355 2 vials bx/2', N'Caja', CAST(N'2017-08-07T09:46:24.213' AS DateTime), CAST(N'2017-08-07T23:50:12.337' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (321, 53, N'M0017600421', N'Contour 355-500 2 vials bx/2', N'Caja', CAST(N'2017-08-07T09:46:33.247' AS DateTime), CAST(N'2017-08-07T23:50:09.667' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (322, 53, N'M0017600621', N'Contour 500-710 2 vials bx/2', N'Caja', CAST(N'2017-08-07T09:47:10.233' AS DateTime), CAST(N'2017-08-07T23:50:06.290' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (323, 53, N'M0017600821', N'Contour 710-1000 2 vials bx/2', N'Caja', CAST(N'2017-08-07T09:48:32.280' AS DateTime), CAST(N'2017-08-07T23:50:02.913' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (324, 53, N'M0017601151', N'Contour 1000-1180 5 vials bx/5', N'Caja', CAST(N'2017-08-07T09:49:48.687' AS DateTime), CAST(N'2017-08-07T23:49:52.290' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (325, 54, N'M001465001', N'Ampl ss jtip 035/145/3mm (b/5)', N'Caja', CAST(N'2017-08-07T10:04:46.087' AS DateTime), CAST(N'2017-08-08T00:09:43.547' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (326, 54, N'M001465011', N'Ampl ss jtip 035/180/3mm (b/5)', N'Caja', CAST(N'2017-08-07T10:05:06.223' AS DateTime), CAST(N'2017-08-08T00:09:40.920' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (327, 54, N'M001465021', N'Ampl ss jtip 035/260/3mm (b/5)', N'Caja', CAST(N'2017-08-07T10:05:27.690' AS DateTime), CAST(N'2017-08-08T00:09:37.770' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (328, 54, N'M001465261', N'Ampla tz sis xch/035/260 (bx/5)', N'Caja', CAST(N'2017-08-07T10:06:49.430' AS DateTime), CAST(N'2017-08-08T00:06:53.033' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (329, 15, N'H965SCH647010', N'Carotid wallstent monorail 6.0-30', N'Pieza', CAST(N'2017-08-07T10:22:26.193' AS DateTime), CAST(N'2017-08-08T00:22:29.793' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (330, 15, N'H965SCH647070', N'Carotid wallstent monorail 8.0-30', N'Pieza', CAST(N'2017-08-07T10:22:42.270' AS DateTime), CAST(N'2017-08-08T00:22:45.873' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (331, 15, N'H965SCH647080', N'Carotid wallstent monorail 8.0-40', N'Pieza', CAST(N'2017-08-07T10:22:57.830' AS DateTime), CAST(N'2017-08-09T00:21:31.083' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (332, 15, N'H965SCH647090', N'Carotid wallstent monorail 8.0-50', N'Pieza', CAST(N'2017-08-07T10:23:25.797' AS DateTime), CAST(N'2017-08-08T00:23:29.400' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (333, 15, N'H965SCH647120', N'Carotid wallstent monorail 10.0-30', N'Pieza', CAST(N'2017-08-07T10:28:16.747' AS DateTime), CAST(N'2017-08-08T00:28:20.353' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (334, 15, N'H965SCH647130', N'Carotid wallstent monorail 10.0-40', N'Pieza', CAST(N'2017-08-07T10:28:33.453' AS DateTime), CAST(N'2017-08-08T00:28:37.063' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (335, 15, N'H965SCH647140', N'Carotid wallstent monorail 10.0-50', N'Pieza', CAST(N'2017-08-07T10:28:49.350' AS DateTime), CAST(N'2017-08-08T00:28:52.953' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (336, 55, N'H74939202070540', N'Sistema de catéter de reintroducción
offroad™ /corto\, 5.4 mm/70cm/79cm', N'Pieza', CAST(N'2017-08-07T10:35:13.693' AS DateTime), CAST(N'2017-08-08T00:35:17.297' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (337, 55, N'H74939202100540', N'Sistema de catéter de reintroducción
offroad™ /larao), 5.4 mm/100cm/109cm', N'Pieza', CAST(N'2017-08-07T10:35:45.180' AS DateTime), CAST(N'2017-08-08T00:35:48.783' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (338, 18, N'H74939181050230', N'Sistema de stent autoexpansible innova, 5 mm de diámetro del stent, 20 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T10:46:45.913' AS DateTime), CAST(N'2017-08-08T00:50:25.503' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (339, 18, N'H74939181054030', N'Sistema de stent autoexpansible innova, 5 mm de diámetro del stent, 40 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T10:47:09.037' AS DateTime), CAST(N'2017-08-08T00:50:20.567' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (340, 18, N'H74939181056030', N'Sistema de stent autoexpansible innova, 5 mm de diámetro del stent, 59 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T10:50:08.303' AS DateTime), CAST(N'2017-08-08T00:50:11.903' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (341, 18, N'H74939181058030', N'Sistema de stent autoexpansible innova, 5 mm de diámetro del stent, 79 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T10:55:43.610' AS DateTime), CAST(N'2017-08-08T00:55:47.217' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (342, 18, N'H74939181051030', N'Sistema de stent autoexpansible innova, 5 mm de diámetro del stent, 100 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T10:56:06.117' AS DateTime), CAST(N'2017-08-08T00:56:09.720' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (343, 18, N'H74939181051230', N'Sistema de stent autoexpansible innova, 5 mm de diámetro del stent, 120 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T10:56:22.030' AS DateTime), CAST(N'2017-08-08T00:56:25.633' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (344, 18, N'H74939181051530', N'Sistema de stent autoexpansible innova, 5 mm de diámetro del stent, 151 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T10:56:39.193' AS DateTime), CAST(N'2017-08-08T00:56:42.793' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (345, 18, N'H74939181051830', N'Sistema de stent autoexpansible innova, 5 mm de diámetro del stent, 179 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T10:57:44.070' AS DateTime), CAST(N'2017-08-08T00:57:47.663' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (346, 18, N'H74939181052030', N'Sistema de stent autoexpansible innova, 5 mm de diámetro del stent, 200 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T10:58:12.040' AS DateTime), CAST(N'2017-08-08T00:58:15.647' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (347, 18, N'H74939181060230', N'Sistema de stent autoexpansible innova, 6 mm de diámetro del stent, 20 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T10:58:39.270' AS DateTime), CAST(N'2017-08-08T00:58:42.873' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (348, 18, N'H74939181064030', N'Sistema de stent autoexpansible innova, 6 mm de diámetro del stent, 39 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T10:59:01.307' AS DateTime), CAST(N'2017-08-08T00:59:04.913' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (349, 18, N'H74939181066030', N'Sistema de stent autoexpansible innova, 6 mm de diámetro del stent, 60 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T10:59:27.397' AS DateTime), CAST(N'2017-08-08T00:59:31.000' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (350, 18, N'H74939181068030', N'Sistema de stent autoexpansible innova, 6 mm de diámetro del stent, 79 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T10:59:53.467' AS DateTime), CAST(N'2017-08-08T00:59:57.073' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (351, 18, N'H74939181061030', N'Sistema de stent autoexpansible innova, 6 mm de diámetro del stent, 100 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:00:37.757' AS DateTime), CAST(N'2017-08-08T01:00:41.360' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (352, 18, N'H74939181061230', N'Sistema de stent autoexpansible innova, 6 mm de diámetro del stent, 119 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:03:21.957' AS DateTime), CAST(N'2017-08-08T01:03:25.560' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (353, 18, N'H74939181061530', N'Sistema de stent autoexpansible innova, 6 mm de diámetro del stent, 150 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:04:14.440' AS DateTime), CAST(N'2017-08-08T01:04:18.040' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (354, 18, N'H74939181061830', N'Sistema de stent autoexpansible innova, 6 mm de diámetro del stent, 180 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:04:43.677' AS DateTime), CAST(N'2017-08-08T01:04:47.280' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (355, 18, N'H74939181062030', N'Sistema de stent autoexpansible innova, 6 mm de diámetro del stent, 201 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:07:00.293' AS DateTime), CAST(N'2017-08-08T01:07:03.897' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (356, 18, N'H74939181070230', N'Sistema de stent autoexpansible innova, 7 mm de diámetro del stent, 20 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:07:37.683' AS DateTime), CAST(N'2017-08-08T01:07:41.287' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (357, 18, N'H74939181074030', N'Sistema de stent autoexpansible innova, 7 mm de diámetro del stent, 39 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:11:48.660' AS DateTime), CAST(N'2017-08-08T01:11:52.263' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (358, 18, N'H74939181076030', N'Sistema de stent autoexpansible innova, 7 mm de diámetro del stent, 60 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:12:06.570' AS DateTime), CAST(N'2017-08-08T01:12:10.177' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (359, 18, N'H74939181078030', N'Sistema de stent autoexpansible innova, 7 mm de diámetro del stent, 79 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:14:24.850' AS DateTime), CAST(N'2017-08-08T01:14:28.457' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (360, 18, N'H74939181071030', N'Sistema de stent autoexpansible innova, 7 mm de diámetro del stent, 100 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:14:42.930' AS DateTime), CAST(N'2017-08-08T01:14:46.537' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (361, 18, N'H74939181071230', N'Sistema de stent autoexpansible innova, 7 mm de diámetro del stent, 119 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:15:11.333' AS DateTime), CAST(N'2017-08-08T01:15:14.937' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (362, 18, N'H74939181071530', N'Sistema de stent autoexpansible innova, 7 mm de diámetro del stent, 150 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:19:23.873' AS DateTime), CAST(N'2017-08-08T01:19:27.480' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (363, 18, N'H74939181072030', N'Sistema de stent autoexpansible innova, 7 mm de diámetro del stent, 200 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:19:46.843' AS DateTime), CAST(N'2017-08-08T01:19:50.447' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (364, 18, N'H74939181080230', N'Sistema de stent autoexpansible innova, 8 mm de diámetro del stent, 20 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:25:29.450' AS DateTime), CAST(N'2017-08-08T01:25:33.053' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (365, 18, N'H74939181084030', N'Sistema de stent autoexpansible innova, 8 mm de diámetro del stent, 39 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:25:54.907' AS DateTime), CAST(N'2017-08-08T01:26:29.040' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (366, 18, N'H74939181086030', N'Sistema de stent autoexpansible innova, 8 mm de diámetro del stent, 60 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:26:52.720' AS DateTime), CAST(N'2017-08-08T01:26:56.320' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (367, 18, N'H74939181088030', N'Sistema de stent autoexpansible innova, 8 mm de diámetro del stent, 81 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T11:27:12.563' AS DateTime), CAST(N'2017-08-08T01:27:16.167' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (368, 18, N'H74939181081030', N'Sistema de stent autoexpansible innova, 8 mm de diámetro del stent, 99 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T12:01:06.077' AS DateTime), CAST(N'2017-08-08T02:01:09.680' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (369, 18, N'H74939181081230', N'Sistema de stent autoexpansible innova, 8 mm de diámetro del stent, 120 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T12:01:30.577' AS DateTime), CAST(N'2017-08-08T02:01:34.183' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (370, 18, N'H74939181081530', N'Sistema de stent autoexpansible innova, 8 mm de diámetro del stent, 151 mm de longitud, sistema introductor de 130 cm de longitud', N'Pieza', CAST(N'2017-08-07T12:01:49.290' AS DateTime), CAST(N'2017-08-08T02:01:52.897' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (371, 56, N'H8Q2227680020', N'Rotalink burr 1.25 mm', N'Pieza', CAST(N'2017-08-07T12:22:34.650' AS DateTime), CAST(N'2017-08-08T02:22:38.253' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (372, 56, N'H8Q2227680030', N'Rotalink burr 1.50 mm', N'Pieza', CAST(N'2017-08-07T12:22:49.597' AS DateTime), CAST(N'2017-08-08T02:22:53.207' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (373, 56, N'H8Q2227680040', N'Rotalink burr 1.75 mm', N'Pieza', CAST(N'2017-08-07T12:23:01.067' AS DateTime), CAST(N'2017-08-08T02:23:04.670' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (374, 56, N'H8Q2227680050', N'Rotalink burr 2.00 mm', N'Pieza', CAST(N'2017-08-07T12:23:12.190' AS DateTime), CAST(N'2017-08-08T02:23:15.797' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (375, 56, N'H8Q2227680060', N'Rotalink burr 2.25 mm', N'Pieza', CAST(N'2017-08-07T12:23:22.660' AS DateTime), CAST(N'2017-08-08T02:23:26.270' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (376, 56, N'H8Q2227680070', N'Rotalink burr 2.50 mm', N'Pieza', CAST(N'2017-08-07T12:23:39.570' AS DateTime), CAST(N'2017-08-08T02:23:43.173' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (377, 56, N'H80222782001A0', N'Rotalink advancer w/tubular drive shaft', N'Pieza', CAST(N'2017-08-07T12:24:31.137' AS DateTime), CAST(N'2017-08-08T02:24:34.743' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (378, 29, N'H74934356380', N'Model-6f mach 1 guide mp1', N'Pieza', CAST(N'2017-08-07T12:33:28.633' AS DateTime), CAST(N'2017-08-08T02:33:32.237' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (379, 29, N'H74934356390', N'Model-6f mach 1 guide mp2', N'Pieza', CAST(N'2017-08-07T12:33:37.263' AS DateTime), CAST(N'2017-08-08T02:33:40.870' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (380, 29, N'H7493924215050', N'Catéter guía con extensión guidezillar tm, 145 cm-, 5f-en-6f', N'Pieza', CAST(N'2017-08-07T12:34:19.280' AS DateTime), CAST(N'2017-08-08T02:34:22.887' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (381, 7, N'030403', N'Gia universal 12 mm instrumento de un solo uso (cirugia abierta)', N'Pieza', CAST(N'2017-08-08T09:36:05.250' AS DateTime), CAST(N'2017-08-08T09:36:04.070' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (382, 7, N'030403', N'Endo gia universal 12 mm instrumento de un solo uso (para laparoscopia)', N'Pieza', CAST(N'2017-08-08T09:36:31.290' AS DateTime), CAST(N'2017-08-08T09:36:30.110' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (383, 7, N'EGIAUNIVXL', N'Endo gia universal xl', N'Pieza', CAST(N'2017-08-08T09:36:50.423' AS DateTime), CAST(N'2017-08-08T09:36:49.247' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (384, 7, N'030450', N'Endo gia roticulador universal 302.0 sulu', N'Pieza', CAST(N'2017-08-08T09:37:16.383' AS DateTime), CAST(N'2017-08-08T09:37:15.207' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (385, 7, N'030451', N'Endo gia roticulador universal 302.05 sulu', N'Pieza', CAST(N'2017-08-08T09:37:33.000' AS DateTime), CAST(N'2017-08-08T09:37:31.820' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (386, 7, N'030452', N'Endo gia roticulador universal 303.05 sulu', N'Pieza', CAST(N'2017-08-08T09:37:45.197' AS DateTime), CAST(N'2017-08-08T09:37:44.020' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (387, 7, N'030453', N'Endo gia roticulador universal 452.0 sulu', N'Pieza', CAST(N'2017-08-08T09:38:15.230' AS DateTime), CAST(N'2017-08-08T09:39:06.143' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (388, 7, N'030454', N'Endo gia roticulador universal 452.5 sulu', N'Pieza', CAST(N'2017-08-08T09:38:44.230' AS DateTime), CAST(N'2017-08-08T09:38:43.047' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (389, 7, N'030455', N'Endo gia roticulador universal 453.5 sulu', N'Pieza', CAST(N'2017-08-08T09:39:53.130' AS DateTime), CAST(N'2017-08-08T09:39:51.950' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (390, 7, N'030456', N'Endo gia roticulador universal 454.8 sulu', N'Pieza', CAST(N'2017-08-08T09:40:07.247' AS DateTime), CAST(N'2017-08-08T09:40:06.070' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (391, 7, N'030457', N'Endo gia roticulador universal 602.5 sulu', N'Pieza', CAST(N'2017-08-08T09:40:21.160' AS DateTime), CAST(N'2017-08-08T09:40:19.980' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (392, 7, N'030458', N'Endo gia roticulador universal 603.5 sulu', N'Pieza', CAST(N'2017-08-08T09:40:30.300' AS DateTime), CAST(N'2017-08-08T09:40:29.110' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (393, 7, N'030459', N'Endo gia roticulador universal 604.8 sulu', N'Pieza', CAST(N'2017-08-08T09:40:41.717' AS DateTime), CAST(N'2017-08-08T09:40:40.540' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (394, 7, N'030416', N'Endo gia  universal recta 30-2.0 sulu', N'Pieza', CAST(N'2017-08-08T09:41:04.597' AS DateTime), CAST(N'2017-08-08T09:41:18.373' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (395, 7, N'030418', N'Endo gia  universal recta 30-2.5 sulu', N'Pieza', CAST(N'2017-08-08T09:41:55.870' AS DateTime), CAST(N'2017-08-08T09:41:54.693' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (396, 7, N'030419', N'Endo gia  universal recta 30-3.5 sulu', N'Pieza', CAST(N'2017-08-08T09:42:07.070' AS DateTime), CAST(N'2017-08-08T09:42:05.893' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (397, 7, N'030426', N'Endo gia  universal recta 45-2.0 sulu', N'Pieza', CAST(N'2017-08-08T09:42:30.893' AS DateTime), CAST(N'2017-08-08T09:42:29.717' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (398, 7, N'030425', N'Endo gia  universal recta 45-2.5 sulu', N'Pieza', CAST(N'2017-08-08T09:43:15.913' AS DateTime), CAST(N'2017-08-08T09:43:14.733' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (399, 7, N'030422', N'Endo gia  universal recta 45-3.5 sulu', N'Pieza', CAST(N'2017-08-08T09:43:43.000' AS DateTime), CAST(N'2017-08-08T09:43:41.820' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (400, 7, N'030423', N'Endo gia  universal recta 45-4.8 sulu', N'Pieza', CAST(N'2017-08-08T09:43:56.693' AS DateTime), CAST(N'2017-08-08T09:43:55.517' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (401, 7, N'030412', N'Endo gia  universal recta 60-2.5 sulu', N'Pieza', CAST(N'2017-08-08T09:44:09.933' AS DateTime), CAST(N'2017-08-08T09:44:08.757' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (402, 7, N'030414', N'Endo gia  universal recta 60-3.5 sulu', N'Pieza', CAST(N'2017-08-08T09:44:21.567' AS DateTime), CAST(N'2017-08-08T09:44:20.390' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (403, 7, N'030415', N'Endo gia  universal recta 60-4.8 sulu', N'Pieza', CAST(N'2017-08-08T09:46:49.507' AS DateTime), CAST(N'2017-08-08T09:46:48.327' AS DateTime))
GO
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (404, 7, N'GIA6025S', N'Gia 60-2.5 engrapadora recargable de un solo uso', N'Pieza', CAST(N'2017-08-08T09:47:34.517' AS DateTime), CAST(N'2017-08-08T09:47:33.333' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (405, 7, N'GIA6038S', N'Gia 60-3.8 engrapadora recargable de un solo uso', N'Pieza', CAST(N'2017-08-08T09:47:46.957' AS DateTime), CAST(N'2017-08-08T09:47:45.780' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (406, 7, N'GIA6048S', N'Gia 60-4.8 engrapadora recargable de un solo uso', N'Pieza', CAST(N'2017-08-08T09:48:00.473' AS DateTime), CAST(N'2017-08-08T09:47:59.293' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (407, 7, N'GIA8038S', N'Gia 80-3.8 engrapadora recargable de un solo uso', N'Pieza', CAST(N'2017-08-08T09:48:24.417' AS DateTime), CAST(N'2017-08-08T09:48:23.237' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (408, 7, N'GIA8048S', N'Gia 80-4.8 engrapadora recargable de un solo uso', N'Pieza', CAST(N'2017-08-08T09:48:48.390' AS DateTime), CAST(N'2017-08-08T09:48:47.213' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (409, 7, N'GIA10038S', N'Gia 100-3.8 engrapadora recargable de un solo uso', N'Pieza', CAST(N'2017-08-08T09:49:22.320' AS DateTime), CAST(N'2017-08-08T09:49:21.143' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (410, 7, N'GIA10048S', N'Gia 100-4.8 engrapadora recargable de un solo uso', N'Pieza', CAST(N'2017-08-08T09:49:34.670' AS DateTime), CAST(N'2017-08-08T09:49:33.493' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (411, 7, N'GIA6025L', N'Gia 60-2.5 unidad de carga de un solo uso ', N'Pieza', CAST(N'2017-08-08T09:50:01.040' AS DateTime), CAST(N'2017-08-08T09:49:59.853' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (412, 7, N'GIA6038L', N'Gia 60-3.8 unidad de carga de un solo uso ', N'Pieza', CAST(N'2017-08-08T09:51:25.950' AS DateTime), CAST(N'2017-08-08T09:51:24.767' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (413, 7, N'GIA6048L', N'Gia 60-4.8 unidad de carga de un solo uso ', N'Pieza', CAST(N'2017-08-08T09:51:44.853' AS DateTime), CAST(N'2017-08-08T09:51:43.677' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (414, 7, N'GIA8038L', N'Gia 80-3.8 unidad de carga de un solo uso ', N'Pieza', CAST(N'2017-08-08T09:52:34.297' AS DateTime), CAST(N'2017-08-08T09:52:33.117' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (415, 7, N'GIA8048L', N'Gia 80-4.8 unidad de carga de un solo uso ', N'Pieza', CAST(N'2017-08-08T09:52:50.103' AS DateTime), CAST(N'2017-08-08T09:52:48.927' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (416, 7, N'GIA10038L', N'Gia 100-3.8 unidad de carga de un solo uso ', N'Pieza', CAST(N'2017-08-08T09:53:14.753' AS DateTime), CAST(N'2017-08-08T09:53:13.573' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (417, 7, N'GIA10048L', N'Gia 100-4.8 unidad de carga de un solo uso ', N'Pieza', CAST(N'2017-08-08T09:53:23.230' AS DateTime), CAST(N'2017-08-08T09:53:22.053' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (418, 7, N'EGIAUXL', N'Engrapadora endo gia ultra universal xl-un solo uso', N'Pieza', CAST(N'2017-08-08T09:53:56.397' AS DateTime), CAST(N'2017-08-08T09:53:55.213' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (419, 7, N'EGIAUSTND', N'Engrapadora endo gia ultra universal-un solo uso', N'Pieza', CAST(N'2017-08-08T10:01:12.917' AS DateTime), CAST(N'2017-08-08T10:01:11.730' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (420, 7, N'EGIA60CTAMT', N'Endo gia sulu de punta curva articulada con tri-staple tecnologia 60mm espesor/medio.', N'Pieza', CAST(N'2017-08-08T10:02:40.003' AS DateTime), CAST(N'2017-08-08T10:02:38.823' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (421, 7, N'EGIA60CTAVM', N'Endo gia sulu de punta curva articulada con tri-staple tecnologia 60mm vascular/medio.', N'Pieza', CAST(N'2017-08-08T10:02:59.280' AS DateTime), CAST(N'2017-08-08T10:02:58.093' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (422, 7, N'EGIA45CTAVM', N'Endo gia sulu de punta curva articulada con tri-staple tecnologia 45mm vascular/medio.', N'Pieza', CAST(N'2017-08-08T10:03:19.680' AS DateTime), CAST(N'2017-08-08T10:03:18.493' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (423, 7, N'EGIA45CTAV', N'Endo gia sulu de punta articulada 45mm vascular', N'Pieza', CAST(N'2017-08-08T10:03:58.760' AS DateTime), CAST(N'2017-08-08T10:03:57.573' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (424, 7, N'EGIA30CTAVM', N'Endo gia sulu de punta articulada con tri-staple tecnologia 30mm vascular/medio', N'Pieza', CAST(N'2017-08-08T10:05:02.520' AS DateTime), CAST(N'2017-08-08T10:05:01.333' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (425, 7, N'EGIA60AMT', N'Endo guia sulu articulada con tri-staple tecnologia 60mm espesor/medio', N'Pieza', CAST(N'2017-08-08T10:06:06.323' AS DateTime), CAST(N'2017-08-08T10:06:05.143' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (426, 7, N'EGIA60AVM', N'Endo guia sulu articulada con tri-staple tecnologia 60mm vascular/medio', N'Pieza', CAST(N'2017-08-08T10:06:27.817' AS DateTime), CAST(N'2017-08-08T10:06:26.637' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (427, 7, N'EGIAUSHORT', N'Endo guia ultra universal engrapadora corta-un solo uso', N'Pieza', CAST(N'2017-08-08T10:07:41.987' AS DateTime), CAST(N'2017-08-08T10:07:40.800' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (428, 7, N'EGIA30AVM', N'Endo gia sulu de punta curva articulada con tri-staple tecnologia de 30mm vascular/medio', N'Pieza', CAST(N'2017-08-08T10:07:56.020' AS DateTime), CAST(N'2017-08-08T10:09:25.407' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (429, 7, N'EGIA45AMT', N'Endo gia sulu articulada con tri-staple tecnologia 45mm espesor/medio', N'Pieza', CAST(N'2017-08-08T10:08:40.123' AS DateTime), CAST(N'2017-08-08T10:08:38.940' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (430, 29, N'M001196160', N'Modef-6f pv mach1 c1', N'Pieza', CAST(N'2017-08-08T10:09:01.370' AS DateTime), CAST(N'2017-08-09T00:09:04.963' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (431, 29, N'M001196200', N'Modef-6f pv mach1 c2', N'Pieza', CAST(N'2017-08-08T10:09:16.550' AS DateTime), CAST(N'2017-08-09T00:09:20.147' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (432, 29, N'M001197160', N'Modef-7f pv mach1 c1', N'Pieza', CAST(N'2017-08-08T10:09:37.103' AS DateTime), CAST(N'2017-08-09T00:09:40.700' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (433, 29, N'M001197200', N'Modef-7f pv mach1 c2', N'Pieza', CAST(N'2017-08-08T10:09:51.753' AS DateTime), CAST(N'2017-08-09T00:09:55.347' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (434, 7, N'EGIA30AMT', N'Endo gia sulu de punta curva articulada con tri-staple tecnologia de 30mm espesor/medio', N'Pieza', CAST(N'2017-08-08T10:10:10.050' AS DateTime), CAST(N'2017-08-08T10:10:08.863' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (435, 29, N'M001198160', N'Modef-8f pv mach1 c1', N'Pieza', CAST(N'2017-08-08T10:10:12.297' AS DateTime), CAST(N'2017-08-09T00:10:15.890' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (436, 7, N'EGIA45AV', N'Endo gia sulu de punta curva articulada con tri-staple tecnologia de 45mm vascular//medio', N'Pieza', CAST(N'2017-08-08T10:10:59.297' AS DateTime), CAST(N'2017-08-08T10:10:58.110' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (437, 29, N'M001198200', N'Modef-8f pv mach1 c2', N'Pieza', CAST(N'2017-08-08T10:11:31.613' AS DateTime), CAST(N'2017-08-09T00:11:35.203' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (438, 7, N'EGIA45AVM', N'Endo gia sulu articulada 45mm vascular/media', N'Pieza', CAST(N'2017-08-08T10:11:47.983' AS DateTime), CAST(N'2017-08-08T10:11:46.797' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (439, 29, N'M001196230', N'Modef-6f pv mach1 mp', N'Pieza', CAST(N'2017-08-08T10:11:52.497' AS DateTime), CAST(N'2017-08-09T00:11:56.090' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (440, 7, N'EGIA60AXT', N'Endo gia 60mm recarga extragruesa articulada de un solo uso con tecnologia tri-staple', N'Pieza', CAST(N'2017-08-08T10:12:34.297' AS DateTime), CAST(N'2017-08-08T10:12:33.110' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (441, 29, N'M001196300', N'Modef-6f pv mach1 mp 2', N'Pieza', CAST(N'2017-08-08T10:12:47.990' AS DateTime), CAST(N'2017-08-09T00:12:51.580' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (442, 7, N'EGIA45AXT', N'Endo gia 45mm recarga extragruesa articulada de un solo uso con tecnologia tri-staple', N'Pieza', CAST(N'2017-08-08T10:12:48.043' AS DateTime), CAST(N'2017-08-08T10:12:46.863' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (443, 29, N'M001197230', N'Modef-7f pv mach1 mp', N'Pieza', CAST(N'2017-08-08T10:13:04.837' AS DateTime), CAST(N'2017-08-09T00:13:08.427' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (444, 29, N'M001197300', N'Modef-7f pv mach1 mp 2', N'Pieza', CAST(N'2017-08-08T10:13:24.733' AS DateTime), CAST(N'2017-08-09T00:13:28.323' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (445, 29, N'M001198230', N'Modef-8f pv mach1 mp', N'Pieza', CAST(N'2017-08-08T10:13:43.030' AS DateTime), CAST(N'2017-08-09T00:13:46.620' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (446, 29, N'M001198300', N'Modef-8f pv mach1 mp 2', N'Pieza', CAST(N'2017-08-08T10:14:01.010' AS DateTime), CAST(N'2017-08-09T00:14:04.603' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (447, 29, N'M001196260', N'Modef-6f pv mach1 mp  90cm', N'Pieza', CAST(N'2017-08-08T10:14:23.120' AS DateTime), CAST(N'2017-08-09T00:14:26.667' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (448, 8, N'365110', N'Pantera lux 2.0/10/140', N'Pieza', CAST(N'2017-08-08T10:14:52.190' AS DateTime), CAST(N'2017-08-08T10:14:51.000' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (449, 8, N'365120', N'Pantera lux 2.5/10/140', N'Pieza', CAST(N'2017-08-08T10:15:01.900' AS DateTime), CAST(N'2017-08-08T10:15:00.720' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (450, 29, N'M001196330', N'Modef-6f pv mach1 mp 2  90cm', N'Pieza', CAST(N'2017-08-08T10:15:13.290' AS DateTime), CAST(N'2017-08-09T00:15:16.883' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (451, 8, N'365125', N'Pantera lux 3.0/10/140', N'Pieza', CAST(N'2017-08-08T10:15:17.550' AS DateTime), CAST(N'2017-08-08T10:15:16.367' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (452, 8, N'365130', N'Pantera lux 3.5/10/140', N'Pieza', CAST(N'2017-08-08T10:15:29.490' AS DateTime), CAST(N'2017-08-08T10:15:28.303' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (453, 29, N'M001197260', N'Modef-7f pv mach1 mp 90cm', N'Pieza', CAST(N'2017-08-08T10:15:39.653' AS DateTime), CAST(N'2017-08-09T00:15:43.243' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (454, 8, N'365135', N'Pantera lux 4.0/10/140', N'Pieza', CAST(N'2017-08-08T10:15:43.597' AS DateTime), CAST(N'2017-08-08T10:15:42.413' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (455, 8, N'365111', N'Pantera lux 2.0/15/140', N'Pieza', CAST(N'2017-08-08T10:15:56.180' AS DateTime), CAST(N'2017-08-08T10:15:55.000' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (456, 29, N'M001197330', N'Modef-7f pv mach1 mp 2 90cm', N'Pieza', CAST(N'2017-08-08T10:16:06.557' AS DateTime), CAST(N'2017-08-09T00:16:10.147' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (457, 8, N'365121', N'Pantera lux 2.5/15/140', N'Pieza', CAST(N'2017-08-08T10:16:08.650' AS DateTime), CAST(N'2017-08-08T10:16:07.470' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (458, 8, N'365126', N'Pantera lux 3.0/15/140', N'Pieza', CAST(N'2017-08-08T10:16:21.923' AS DateTime), CAST(N'2017-08-08T10:16:20.743' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (459, 29, N'M001198260', N'Modef-8f pv mach1 mp 90cm', N'Pieza', CAST(N'2017-08-08T10:16:25.713' AS DateTime), CAST(N'2017-08-09T00:16:29.307' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (460, 8, N'365131', N'Pantera lux 3.5/15/140', N'Pieza', CAST(N'2017-08-08T10:16:33.723' AS DateTime), CAST(N'2017-08-08T10:16:32.533' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (461, 29, N'M001198330', N'Modef-8f pv mach1 mp 2 90cm', N'Pieza', CAST(N'2017-08-08T10:16:45.710' AS DateTime), CAST(N'2017-08-09T00:16:49.297' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (462, 8, N'365136', N'Pantera lux 4.0/15/140', N'Pieza', CAST(N'2017-08-08T10:16:47.523' AS DateTime), CAST(N'2017-08-08T10:16:46.343' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (463, 8, N'365112', N'Pantera lux 2.0/20/140', N'Pieza', CAST(N'2017-08-08T10:17:07.467' AS DateTime), CAST(N'2017-08-08T10:17:06.287' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (464, 8, N'365122', N'Pantera lux 2.5/20/140', N'Pieza', CAST(N'2017-08-08T10:17:31.450' AS DateTime), CAST(N'2017-08-08T10:17:30.263' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (465, 8, N'365127', N'Pantera lux 3.0/20/140', N'Pieza', CAST(N'2017-08-08T10:17:47.337' AS DateTime), CAST(N'2017-08-08T10:17:46.150' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (466, 8, N'365132', N'Pantera lux 3.5/20/140', N'Pieza', CAST(N'2017-08-08T10:17:56.460' AS DateTime), CAST(N'2017-08-08T10:17:55.280' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (467, 8, N'365137', N'Pantera lux 4.0/20/140', N'Pieza', CAST(N'2017-08-08T10:18:08.347' AS DateTime), CAST(N'2017-08-08T10:18:07.167' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (468, 8, N'365113', N'Pantera lux 2.0/25/140', N'Pieza', CAST(N'2017-08-08T10:18:36.180' AS DateTime), CAST(N'2017-08-08T10:19:17.213' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (469, 8, N'365123', N'Pantera lux 2.5/25/140', N'Pieza', CAST(N'2017-08-08T10:20:01.160' AS DateTime), CAST(N'2017-08-08T10:19:59.977' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (470, 8, N'365128', N'Pantera lux 3.0/25/140', N'Pieza', CAST(N'2017-08-08T10:20:21.020' AS DateTime), CAST(N'2017-08-08T10:20:19.840' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (471, 8, N'365133', N'Pantera lux 3.5/25/140', N'Pieza', CAST(N'2017-08-08T10:20:33.963' AS DateTime), CAST(N'2017-08-08T10:20:32.783' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (472, 8, N'365138', N'Pantera lux 4.0/25/140', N'Pieza', CAST(N'2017-08-08T10:20:44.253' AS DateTime), CAST(N'2017-08-08T10:20:43.070' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (473, 8, N'365114', N'Pantera lux 2.0/30/140', N'Pieza', CAST(N'2017-08-08T10:21:05.737' AS DateTime), CAST(N'2017-08-08T10:21:04.550' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (474, 8, N'365124', N'Pantera lux 2.5/30/140', N'Pieza', CAST(N'2017-08-08T10:21:21.493' AS DateTime), CAST(N'2017-08-08T10:21:20.310' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (475, 8, N'365129', N'Pantera lux 3.0/30/140', N'Pieza', CAST(N'2017-08-08T10:21:31.973' AS DateTime), CAST(N'2017-08-08T10:21:30.790' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (476, 8, N'365134', N'Pantera lux 3.5/30/140', N'Pieza', CAST(N'2017-08-08T10:21:42.763' AS DateTime), CAST(N'2017-08-08T10:21:41.583' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (477, 8, N'365139', N'Pantera lux 4.0/30/140', N'Pieza', CAST(N'2017-08-08T10:21:55.983' AS DateTime), CAST(N'2017-08-08T10:21:54.800' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (479, 9, N'411504S', N'Cateter de diagnostico powerflex 5f pta 10mmx4cm 80 cm', N'Pieza', CAST(N'2017-08-08T10:50:35.083' AS DateTime), CAST(N'2017-08-08T10:50:33.897' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (480, 9, N'411504V', N'Cateter de diagnostico powerflex 5f pta 10mmx2cm 65 cm', N'Pieza', CAST(N'2017-08-08T10:50:49.850' AS DateTime), CAST(N'2017-08-08T10:50:48.663' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (481, 9, N'411540L', N'Cateter de diagnostico powerflex 5f pta 4mmx10cm 110 cm', N'Pieza', CAST(N'2017-08-08T10:55:35.310' AS DateTime), CAST(N'2017-08-08T10:55:34.120' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (482, 9, N'411540S', N'Cateter de diagnostico powerflex 5f pta 4mmx10cm 80cm', N'Pieza', CAST(N'2017-08-08T10:56:13.973' AS DateTime), CAST(N'2017-08-08T10:56:12.783' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (483, 9, N'411542L', N'Cateter de diagnostico powerflex 5f pta 4mmx2cm 110cm', N'Pieza', CAST(N'2017-08-08T10:57:07.640' AS DateTime), CAST(N'2017-08-08T10:57:06.447' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (484, 9, N'411542S', N'Cateter de diagnostico powerflex 5f pta 4mmx2cm 80cm', N'Pieza', CAST(N'2017-08-08T10:57:29.333' AS DateTime), CAST(N'2017-08-08T10:57:28.143' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (485, 9, N'411542X', N'Cateter de diagnostico powerflex 5f pta 4mmx2cm 135cm', N'Pieza', CAST(N'2017-08-08T10:57:52.947' AS DateTime), CAST(N'2017-08-08T10:57:51.760' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (486, 9, N'411544L', N'Cateter de diagnostico powerflex 5f pta 4mmx4cm 110 cm', N'Pieza', CAST(N'2017-08-08T11:05:14.867' AS DateTime), CAST(N'2017-08-08T11:05:55.017' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (487, 9, N'411544S', N'Cateter de diagnostico powerflex 5f pta 4mmx4cm 80 cm', N'Pieza', CAST(N'2017-08-08T11:05:41.150' AS DateTime), CAST(N'2017-08-08T11:05:39.960' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (488, 12, N'8185', N'Primerwire prestige 185cm straight', N'Pieza', CAST(N'2017-08-08T11:28:03.053' AS DateTime), CAST(N'2017-08-08T11:28:01.857' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (489, 12, N'8185J', N'Primerwire prestige 185cm j-tip', N'Pieza', CAST(N'2017-08-08T11:28:16.663' AS DateTime), CAST(N'2017-08-08T11:28:15.467' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (490, 12, N'8300', N'Primerwire prestige 300 straight', N'Pieza', CAST(N'2017-08-08T11:28:36.480' AS DateTime), CAST(N'2017-08-08T11:28:35.280' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (491, 12, N'8300J', N'Primerwire prestige 300cm j-tip', N'Pieza', CAST(N'2017-08-08T11:28:56.323' AS DateTime), CAST(N'2017-08-08T11:28:55.127' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (492, 13, N'SSQK-65/115VS MEDRAD', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:43:54.447' AS DateTime), CAST(N'2017-08-08T11:43:53.243' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (493, 13, N'SDS-CTP-SPK MEDRAD', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:44:08.690' AS DateTime), CAST(N'2017-08-08T11:44:07.490' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (494, 13, N'SDS-CTP-QFT MEDRAD', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:44:32.767' AS DateTime), CAST(N'2017-08-08T11:44:31.567' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (495, 13, N'SSS-CTP-QFT MEDRAD', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:45:03.907' AS DateTime), CAST(N'2017-08-08T11:45:02.703' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (496, 13, N'SSS-CTP-SPK MEDRAD', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:45:14.620' AS DateTime), CAST(N'2017-08-08T11:45:13.423' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (497, 13, N'SQK-65VS MEDRAD', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:45:48.870' AS DateTime), CAST(N'2017-08-08T11:45:47.663' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (498, 13, N'150-FT-1 MEDRAD', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:46:02.853' AS DateTime), CAST(N'2017-08-08T11:46:01.657' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (499, 13, N'CTP-200-FLS-MEDRAD', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:46:23.667' AS DateTime), CAST(N'2017-08-08T11:46:22.463' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (500, 13, N'150-FT-A-Q + DCT-130 MEDRAD', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:46:35.987' AS DateTime), CAST(N'2017-08-08T11:47:16.530' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (501, 13, N'150-FT-A-Q MEDRAD', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:47:50.330' AS DateTime), CAST(N'2017-08-08T11:47:49.130' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (502, 13, N'DSK-130-Q-MEDRAD', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:48:09.033' AS DateTime), CAST(N'2017-08-08T11:48:07.833' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (503, 13, N'200-FLS-MEDRAD', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:48:20.457' AS DateTime), CAST(N'2017-08-08T11:48:19.257' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (504, 13, N'DCT-100', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:48:27.263' AS DateTime), CAST(N'2017-08-08T11:48:26.063' AS DateTime))
GO
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (505, 13, N'DCT-120', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:48:32.533' AS DateTime), CAST(N'2017-08-08T11:49:15.770' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (506, 13, N'DCT-130', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:48:42.800' AS DateTime), CAST(N'2017-08-08T11:48:41.600' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (507, 13, N'DCT-148', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:48:49.390' AS DateTime), CAST(N'2017-08-08T11:48:48.193' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (508, 13, N'LPDCT-160', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:49:07.463' AS DateTime), CAST(N'2017-08-08T11:49:30.400' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (509, 13, N'QFT 200', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:49:54.590' AS DateTime), CAST(N'2017-08-08T11:49:53.383' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (510, 13, N'SIT-96V', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:50:09.127' AS DateTime), CAST(N'2017-08-08T11:50:07.930' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (511, 13, N'SSIT-96-VLD', N'Jeringa de plastico grado medico, transparente, esteriles y desechables, con accesorios.', N'Pieza', CAST(N'2017-08-08T11:50:21.800' AS DateTime), CAST(N'2017-08-08T11:50:20.600' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (512, 58, N'H965520250', N'Wallgraft pkg, 6x20 9fr comml', N'Paquete', CAST(N'2017-08-14T11:53:50.800' AS DateTime), CAST(N'2017-08-15T01:53:51.313' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (513, 58, N'H965520010', N'Wallgraft pkg, 6x30 9fr comml', N'Paquete', CAST(N'2017-08-14T11:54:48.567' AS DateTime), CAST(N'2017-08-15T01:54:49.097' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (514, 59, N'H749RB4200060', N'Flextome cb monorail 06/2.00', N'Pieza', CAST(N'2017-08-14T12:06:02.843' AS DateTime), CAST(N'2017-08-15T03:07:39.023' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (515, 58, N'H965520020', N'Wallgraft pkg, 6x50 9fr comml', N'Paquete', CAST(N'2017-08-14T12:13:42.260' AS DateTime), CAST(N'2017-08-15T02:13:42.783' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (516, 58, N'H965520030', N'Wallgraft pkg, 6x70 9fr comml', N'Paquete', CAST(N'2017-08-14T12:14:32.330' AS DateTime), CAST(N'2017-08-15T02:14:32.863' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (517, 58, N'H965520260', N'Wallgraft pkg, 7x20 9fr comml', N'Paquete', CAST(N'2017-08-14T12:15:21.610' AS DateTime), CAST(N'2017-08-15T02:15:22.143' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (518, 58, N'H965520050', N'Wallgraft pkg, 7x30 9fr comml', N'Paquete', CAST(N'2017-08-14T12:16:58.730' AS DateTime), CAST(N'2017-08-15T02:16:59.263' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (519, 58, N'H965520060', N'Wallgraft pkg, 7x50 9fr comml', N'Paquete', CAST(N'2017-08-14T12:18:54.113' AS DateTime), CAST(N'2017-08-15T02:21:22.007' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (520, 58, N'H965520070', N'Wallgraft pkg, 7x70 9fr comml', N'Paquete', CAST(N'2017-08-14T12:19:23.933' AS DateTime), CAST(N'2017-08-15T02:21:16.007' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (521, 58, N'H965520270', N'Wallgraft pkg, 8x20 9fr comml', N'Paquete', CAST(N'2017-08-14T12:20:11.893' AS DateTime), CAST(N'2017-08-15T02:20:12.430' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (522, 58, N'H965520090', N'Wallgraft pkg, 8x30 9fr comml', N'Paquete', CAST(N'2017-08-14T12:21:05.913' AS DateTime), CAST(N'2017-08-15T02:21:06.447' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (523, 58, N'H965520100', N'Wallgraft pkg, 8x50 9fr comml', N'Paquete', CAST(N'2017-08-14T12:22:46.780' AS DateTime), CAST(N'2017-08-15T02:22:47.310' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (524, 58, N'H965520110', N'Wallgraft pkg, 8x70 9fr comml', N'Paquete', CAST(N'2017-08-14T12:23:32.027' AS DateTime), CAST(N'2017-08-15T02:25:19.670' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (525, 58, N'H965520280', N'Wallgraft pkg, 9x20 10fr comml', N'Paquete', CAST(N'2017-08-14T12:24:47.383' AS DateTime), CAST(N'2017-08-15T02:24:47.910' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (526, 58, N'H965520130', N'Wallgraft pkg, 9x30 10fr comml', N'Paquete', CAST(N'2017-08-14T12:26:34.000' AS DateTime), CAST(N'2017-08-15T02:26:34.537' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (527, 58, N'H965520140', N'Wallgraft pkg, 9x50 10fr comml', N'Paquete', CAST(N'2017-08-14T12:27:18.340' AS DateTime), CAST(N'2017-08-15T02:27:18.880' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (528, 58, N'H965520150', N'Wallgraft pkg, 9x70 10fr comml', N'Paquete', CAST(N'2017-08-14T12:27:47.377' AS DateTime), CAST(N'2017-08-15T02:27:47.910' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (529, 58, N'H965520290', N'Wallgraft pkg, 10x20 10fr comm', N'Paquete', CAST(N'2017-08-14T12:28:31.253' AS DateTime), CAST(N'2017-08-15T02:28:31.790' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (530, 58, N'H965520170', N'Wallgraft pkg, 10x30 10fr comm', N'Paquete', CAST(N'2017-08-14T12:29:28.700' AS DateTime), CAST(N'2017-08-15T02:29:29.240' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (531, 58, N'H965520180', N'Wallgraft pkg, 10x50 10fr comm', N'Paquete', CAST(N'2017-08-14T12:30:04.593' AS DateTime), CAST(N'2017-08-15T02:30:05.127' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (532, 58, N'H965520190', N'Wallgraft pkg, 10x70 10fr comm', N'Paquete', CAST(N'2017-08-14T12:30:44.857' AS DateTime), CAST(N'2017-08-15T02:30:45.390' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (533, 58, N'H965520210', N'Wallgraft pkg, 12x30 11fr comm', N'Paquete', CAST(N'2017-08-14T12:31:13.193' AS DateTime), CAST(N'2017-08-15T02:31:13.727' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (534, 58, N'H965520220', N'Wallgraft pkg, 12x50 11fr comm', N'Paquete', CAST(N'2017-08-14T12:31:58.800' AS DateTime), CAST(N'2017-08-15T02:31:59.333' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (535, 58, N'H965520230', N'Wallgraft pkg, 12x70 11fr comm', N'Paquete', CAST(N'2017-08-14T12:32:28.140' AS DateTime), CAST(N'2017-08-15T02:32:28.680' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (536, 58, N'H965520320', N'Wallgraft pkg, 14x50 12fr comm', N'Paquete', CAST(N'2017-08-14T12:32:49.853' AS DateTime), CAST(N'2017-08-15T02:32:50.390' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (537, 58, N'H965520330', N'Wallgraft pkg, 14x70 12fr comm', N'Paquete', CAST(N'2017-08-14T12:33:33.933' AS DateTime), CAST(N'2017-08-15T02:33:34.470' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (542, 59, N'H749RB4200100', N'Flextome cb monorail 10/2.00', N'Pieza', CAST(N'2017-08-14T13:01:22.230' AS DateTime), CAST(N'2017-08-15T03:01:22.767' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (543, 59, N'H749RB4200150', N'Flextome cb monorail 15/2.00', N'Pieza', CAST(N'2017-08-14T13:01:54.643' AS DateTime), CAST(N'2017-08-15T03:07:31.520' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (544, 59, N'H749RB4225060', N'Flextome cb monorail 06/2.25', N'Pieza', CAST(N'2017-08-14T13:07:19.977' AS DateTime), CAST(N'2017-08-15T03:07:20.520' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (545, 59, N'H749RB4225100', N'Flextome cb monorail 10/2.25', N'Pieza', CAST(N'2017-08-14T13:08:25.790' AS DateTime), CAST(N'2017-08-15T03:08:26.333' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (546, 59, N'H749RB4225150', N'Flextome cb monorail 15/2.25', N'Pieza', CAST(N'2017-08-14T13:08:47.917' AS DateTime), CAST(N'2017-08-15T03:08:48.463' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (547, 59, N'H749RB4250060', N'Flextome cb monorail 06/2.50', N'Pieza', CAST(N'2017-08-14T13:09:07.343' AS DateTime), CAST(N'2017-08-15T03:09:07.887' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (548, 59, N'H749RB4250100', N'Flextome cb monorail 10/2.50', N'Pieza', CAST(N'2017-08-14T13:09:37.093' AS DateTime), CAST(N'2017-08-15T03:09:37.637' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (549, 59, N'H749RB4250150', N'Flextome cb monorail 15/2.50', N'Pieza', CAST(N'2017-08-14T13:10:02.237' AS DateTime), CAST(N'2017-08-15T03:10:02.783' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (550, 59, N'H749RB4275060', N'Flextome cb monorail 06/2.75', N'Pieza', CAST(N'2017-08-14T13:10:41.267' AS DateTime), CAST(N'2017-08-15T03:16:58.383' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (551, 59, N'H749RB4275100', N'Flextome cb monorail 10/2.75', N'Pieza', CAST(N'2017-08-14T13:11:04.710' AS DateTime), CAST(N'2017-08-15T03:16:50.997' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (552, 59, N'H749RB4275150', N'Ftextome cb monorail 15/2.75', N'Pieza', CAST(N'2017-08-14T13:11:28.180' AS DateTime), CAST(N'2017-08-15T03:11:28.727' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (553, 59, N'H749RB4300060', N'Flextome cb monorail 06/3.00', N'Pieza', CAST(N'2017-08-14T13:11:48.077' AS DateTime), CAST(N'2017-08-15T03:11:48.620' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (554, 59, N'H749RB4300100', N'Flextome cb monorail 10/3.00', N'Pieza', CAST(N'2017-08-14T13:12:21.067' AS DateTime), CAST(N'2017-08-15T03:12:21.607' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (555, 59, N'H749RB4300150', N'Flextome cb monorail 15/3.00', N'Pieza', CAST(N'2017-08-14T13:12:47.817' AS DateTime), CAST(N'2017-08-15T03:12:48.357' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (556, 59, N'H749RB4325060', N'Flextome cb monorail 06/3.25', N'Pieza', CAST(N'2017-08-14T13:13:15.347' AS DateTime), CAST(N'2017-08-15T03:13:15.893' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (557, 59, N'H749RB4325100', N'Flextome cb monorail 10/3.25', N'Pieza', CAST(N'2017-08-14T13:13:43.157' AS DateTime), CAST(N'2017-08-15T03:13:43.693' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (558, 59, N'H749RB4350060', N'Flextome cb monorail 06/3.50', N'Pieza', CAST(N'2017-08-14T13:14:17.740' AS DateTime), CAST(N'2017-08-15T03:14:18.287' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (559, 59, N'H749RB4350150', N'Flextome cb monorail 15/3.50', N'Pieza', CAST(N'2017-08-14T13:14:37.077' AS DateTime), CAST(N'2017-08-15T03:14:37.623' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (560, 59, N'H749RB4375060', N'Flextome cb.monorail 06/3.75', N'Pieza', CAST(N'2017-08-14T13:15:08.050' AS DateTime), CAST(N'2017-08-15T03:15:08.597' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (561, 59, N'H749RB4375150', N'Flextome cb monorail 15/3.75', N'Pieza', CAST(N'2017-08-14T13:15:47.090' AS DateTime), CAST(N'2017-08-15T03:16:45.510' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (562, 59, N'H749RB4400060', N'Flextome cb monorail 06/4.00', N'Pieza', CAST(N'2017-08-14T13:16:10.873' AS DateTime), CAST(N'2017-08-15T03:16:39.373' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (563, 59, N'H749RB4400100', N'Flextome cb monorail 10/4.00', N'Pieza', CAST(N'2017-08-14T13:18:01.990' AS DateTime), CAST(N'2017-08-15T03:18:02.533' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (564, 59, N'H749RB4400150', N'Flextome cb monorail 15/4.00', N'Pieza', CAST(N'2017-08-14T13:18:46.443' AS DateTime), CAST(N'2017-08-15T03:18:46.990' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (565, 60, N'H74920105 1900', N'Model-fw ez 190 cm mt ous pv', N'Pieza', CAST(N'2017-08-14T13:58:58.457' AS DateTime), CAST(N'2017-08-15T03:58:59.003' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (566, 60, N'H74920105 3000', N'Model-fw ez 300 cm mt ous pv', N'Pieza', CAST(N'2017-08-14T13:59:22.273' AS DateTime), CAST(N'2017-08-15T03:59:22.820' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (567, 61, N'H749518050', N'Catéter para toma de lmágenes coronarias icross, 40 mhz, 3.6f x 135 cm', N'Pieza', CAST(N'2017-08-14T14:15:06.293' AS DateTime), CAST(N'2017-08-15T04:15:06.843' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (568, 62, N'WS-2106', N'Dispositivo de cierre watchman (implante), y sistema de suministro 21 12 fr', N'Pieza', CAST(N'2017-08-14T14:51:39.970' AS DateTime), CAST(N'2017-08-15T04:54:03.987' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (569, 62, N'WS-2406', N'Dispositivo de cierre watchman (implante), y sistema de suministro 24 12 fr', N'Pieza', CAST(N'2017-08-14T14:52:14.423' AS DateTime), CAST(N'2017-08-15T04:53:56.027' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (570, 62, N'WS-2706', N'Dispositivo de cierre watchman (implante), y sistema de suministro 27 12 fr', N'Pieza', CAST(N'2017-08-14T14:52:37.627' AS DateTime), CAST(N'2017-08-15T04:53:50.757' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (571, 62, N'WS-3006', N'Dispositivo de cierre watchman (implante), y sistema de suministro 30 12 fr', N'Pieza', CAST(N'2017-08-14T14:53:30.133' AS DateTime), CAST(N'2017-08-15T04:54:19.603' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (572, 62, N'WS-3306', N'Dispositivo de cierre watchman (implante), y sistema de suministro 33 12 fr', N'Pieza', CAST(N'2017-08-14T14:55:01.557' AS DateTime), CAST(N'2017-08-15T04:55:02.113' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (573, 37, N'RSINT30009X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T15:58:15.360' AS DateTime), CAST(N'2017-08-15T06:00:20.130' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (574, 37, N'RSINT35009X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:01:03.037' AS DateTime), CAST(N'2017-08-15T06:01:03.600' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (575, 37, N'RSINT40009X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:01:11.413' AS DateTime), CAST(N'2017-08-15T06:01:11.983' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (576, 37, N'RSINT22512X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:01:21.277' AS DateTime), CAST(N'2017-08-15T06:01:21.847' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (577, 37, N'RSINT25012X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:01:29.397' AS DateTime), CAST(N'2017-08-15T06:01:29.967' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (578, 37, N'RSINT27512X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:01:37.413' AS DateTime), CAST(N'2017-08-15T06:01:37.983' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (579, 37, N'RSINT30012X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:01:45.500' AS DateTime), CAST(N'2017-08-15T06:01:46.063' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (580, 37, N'RSINT35012X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:01:54.700' AS DateTime), CAST(N'2017-08-15T06:01:55.263' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (581, 37, N'RSINT40012X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:02:02.943' AS DateTime), CAST(N'2017-08-15T06:02:03.510' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (582, 37, N'RSINT22514X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:02:12.607' AS DateTime), CAST(N'2017-08-15T06:02:13.177' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (583, 37, N'RSINT25014X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:02:19.390' AS DateTime), CAST(N'2017-08-15T06:02:19.957' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (584, 37, N'RSINT27514X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:02:27.597' AS DateTime), CAST(N'2017-08-15T06:02:28.167' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (585, 37, N'RSINT30015X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:02:34.140' AS DateTime), CAST(N'2017-08-15T06:02:34.710' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (586, 37, N'RSINT35015X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:02:41.167' AS DateTime), CAST(N'2017-08-15T06:02:41.733' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (587, 37, N'RSINT40015X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:02:49.387' AS DateTime), CAST(N'2017-08-15T06:02:49.950' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (588, 37, N'RSINT22518X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:03:01.003' AS DateTime), CAST(N'2017-08-15T06:03:01.567' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (589, 37, N'RSINT25018X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:03:12.733' AS DateTime), CAST(N'2017-08-15T06:03:13.303' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (590, 37, N'RSINT27518X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:03:19.830' AS DateTime), CAST(N'2017-08-15T06:03:20.400' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (591, 37, N'RSINT30018X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:03:27.117' AS DateTime), CAST(N'2017-08-15T06:03:27.687' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (592, 37, N'RSINT35018X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:03:34.007' AS DateTime), CAST(N'2017-08-15T06:03:34.577' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (593, 37, N'RSINT40018X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:03:41.070' AS DateTime), CAST(N'2017-08-15T06:03:41.637' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (594, 37, N'RSINT22522X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:03:48.470' AS DateTime), CAST(N'2017-08-15T06:03:49.040' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (595, 37, N'RSINT25022X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:03:54.437' AS DateTime), CAST(N'2017-08-15T06:03:54.997' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (596, 37, N'RSINT27522X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:04:02.787' AS DateTime), CAST(N'2017-08-15T06:04:03.350' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (597, 37, N'RSINT30022X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:04:10.373' AS DateTime), CAST(N'2017-08-15T06:04:10.943' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (598, 37, N'RSINT35022X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:04:16.413' AS DateTime), CAST(N'2017-08-15T06:04:16.983' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (599, 37, N'RSINT40022X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:04:24.780' AS DateTime), CAST(N'2017-08-15T06:04:25.350' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (600, 37, N'RSINT22526X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:04:31.830' AS DateTime), CAST(N'2017-08-15T06:04:32.400' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (601, 37, N'RSINT25026X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:04:38.300' AS DateTime), CAST(N'2017-08-15T06:04:38.870' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (602, 37, N'RSINT27526X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:04:44.787' AS DateTime), CAST(N'2017-08-15T06:04:45.350' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (603, 37, N'RSINT30026X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:04:51.973' AS DateTime), CAST(N'2017-08-15T06:04:52.543' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (604, 37, N'RSINT35026X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:05:01.033' AS DateTime), CAST(N'2017-08-15T06:05:01.600' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (605, 37, N'RSINT40026X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:05:16.187' AS DateTime), CAST(N'2017-08-15T06:05:16.750' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (606, 37, N'RSINT22530X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:05:23.630' AS DateTime), CAST(N'2017-08-15T06:05:24.197' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (607, 37, N'RSINT25030X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:05:32.717' AS DateTime), CAST(N'2017-08-15T06:05:33.287' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (608, 37, N'RSINT27030X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:05:39.660' AS DateTime), CAST(N'2017-08-15T06:05:40.230' AS DateTime))
GO
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (609, 37, N'RSINT30030X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:05:47.047' AS DateTime), CAST(N'2017-08-15T06:05:47.617' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (610, 37, N'RSINT35030X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:05:53.930' AS DateTime), CAST(N'2017-08-15T06:05:54.500' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (611, 37, N'RSINT40030X', N'Fabricado con aleacion de cobalto, el stent coronario se fabrica a partir de un unico alambre continuo que se enrolla sobre un mandril siguiendo un patron sinusoidal continuo y posteriormente fusionado con laser sobre si mismo, esterilizado por oxido de etileno.', N'Pieza', CAST(N'2017-08-14T16:06:00.543' AS DateTime), CAST(N'2017-08-15T06:06:01.110' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (612, 63, N'043325M', N'Marinr cs 7 fr 2/5/2 mm long 90 cm', N'Pieza', CAST(N'2017-08-14T17:31:30.880' AS DateTime), CAST(N'2017-08-15T07:35:28.560' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (613, 63, N'05508SP', N'Cable adaptador, 4 conductores, 8 pies torq/voyager a ecg esteril y pin protegido', N'Pieza', CAST(N'2017-08-14T17:33:00.293' AS DateTime), CAST(N'2017-08-15T07:33:00.863' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (615, 63, N'04401SM', N'Stable mapr long 110 cm 7 fr 2/10/2 mm sin curva pre formada', N'Pieza', CAST(N'2017-08-14T17:37:19.700' AS DateTime), CAST(N'2017-08-15T07:37:20.270' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (616, 65, N'203CX', N'Coaxial umbilical / 1pza', N'Pieza', CAST(N'2017-08-14T18:17:48.340' AS DateTime), CAST(N'2017-08-15T08:17:48.920' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (617, 29, N'H749343566610', N'Model-6f mach 1 jl3.5', N'Pieza', CAST(N'2017-08-15T10:29:52.970' AS DateTime), CAST(N'2017-08-16T00:32:51.870' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (618, 29, N'H749343566620', N'Model-6f mach 1 jl4', N'Pieza', CAST(N'2017-08-15T10:31:30.217' AS DateTime), CAST(N'2017-08-16T00:32:57.347' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (619, 29, N'H749343566640', N'Model-6f mach 1 jl5', N'Pieza', CAST(N'2017-08-15T10:35:52.047' AS DateTime), CAST(N'2017-08-16T00:39:13.780' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (620, 29, N'H749343576610', N'Model-7f mach1 jl3.5', N'Pieza', CAST(N'2017-08-15T10:37:08.500' AS DateTime), CAST(N'2017-08-16T00:39:22.043' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (621, 29, N'H749343576620', N'Model-7f mach1 jl4', N'Pieza', CAST(N'2017-08-15T10:37:56.263' AS DateTime), CAST(N'2017-08-16T00:39:32.403' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (622, 29, N'H749343576640', N'Model-7f mach1 jl5', N'Pieza', CAST(N'2017-08-15T10:41:02.117' AS DateTime), CAST(N'2017-08-16T00:41:03.380' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (623, 29, N'H749343586610', N'Model-8f mach1 jl3.5', N'Pieza', CAST(N'2017-08-15T10:42:06.130' AS DateTime), CAST(N'2017-08-16T00:42:07.393' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (624, 29, N'H749343586620', N'Model-8f mach1 jl4', N'Pieza', CAST(N'2017-08-15T10:43:00.043' AS DateTime), CAST(N'2017-08-16T00:43:01.307' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (625, 29, N'H749343586640', N'Model-8f mach1 jl5', N'Pieza', CAST(N'2017-08-15T10:44:05.987' AS DateTime), CAST(N'2017-08-16T00:44:07.253' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (626, 29, N'H749343566850', N'Model- 6f mach1 jr3.5', N'Pieza', CAST(N'2017-08-15T10:45:10.387' AS DateTime), CAST(N'2017-08-16T00:45:11.653' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (627, 29, N'H749343566860', N'Model - 6f mach1 jr4', N'Pieza', CAST(N'2017-08-15T10:45:53.997' AS DateTime), CAST(N'2017-08-16T00:45:55.260' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (628, 29, N'H749343566880', N'Model - 6f mach1 jr5', N'Pieza', CAST(N'2017-08-15T10:46:44.027' AS DateTime), CAST(N'2017-08-16T00:46:45.293' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (629, 29, N'H749343576850', N'Model-7f mach1 jr3.5', N'Pieza', CAST(N'2017-08-15T10:48:12.730' AS DateTime), CAST(N'2017-08-16T00:50:29.403' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (630, 29, N'H749343576860', N'Model-7f mach1 jr4', N'Pieza', CAST(N'2017-08-15T10:49:13.313' AS DateTime), CAST(N'2017-08-16T00:50:23.627' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (631, 29, N'H749343576880', N'Model-7f mach1 jr5', N'Pieza', CAST(N'2017-08-15T10:50:13.787' AS DateTime), CAST(N'2017-08-16T00:50:15.053' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (632, 29, N'H749343586850', N'Model-8f mach1 jr3.5', N'Pieza', CAST(N'2017-08-15T10:51:49.510' AS DateTime), CAST(N'2017-08-16T00:51:50.777' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (633, 29, N'H749343586860', N'Model-8f mach1 jr4', N'Pieza', CAST(N'2017-08-15T10:54:53.473' AS DateTime), CAST(N'2017-08-16T00:54:54.743' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (634, 29, N'H749343586880', N'Model-8f mach1 jr5', N'Pieza', CAST(N'2017-08-15T10:56:10.390' AS DateTime), CAST(N'2017-08-16T00:56:11.657' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (635, 29, N'H74934356190', N'Model-6f mach 1 guide al1', N'Pieza', CAST(N'2017-08-15T10:58:04.770' AS DateTime), CAST(N'2017-08-16T00:58:06.040' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (636, 29, N'H74934356200', N'Model-6f mach 1 guide al2', N'Pieza', CAST(N'2017-08-15T10:59:28.340' AS DateTime), CAST(N'2017-08-16T00:59:29.607' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (637, 29, N'H74934356210', N'Model-6f mach 1 al3', N'Pieza', CAST(N'2017-08-15T11:02:25.840' AS DateTime), CAST(N'2017-08-16T01:02:27.113' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (638, 29, N'H74934357190', N'Model-7f maeh 1 al1', N'Pieza', CAST(N'2017-08-15T11:04:17.290' AS DateTime), CAST(N'2017-08-16T01:09:28.820' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (639, 29, N'H74934357200', N'Model-7f mach 1 al2', N'Pieza', CAST(N'2017-08-15T11:05:28.193' AS DateTime), CAST(N'2017-08-16T01:05:29.463' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (640, 29, N'H74934357210', N'Model-7f mach 1 al3', N'Pieza', CAST(N'2017-08-15T11:06:40.317' AS DateTime), CAST(N'2017-08-16T01:06:41.583' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (641, 29, N'H74934358190', N'Model-8f mach 1 al1', N'Pieza', CAST(N'2017-08-15T11:08:15.327' AS DateTime), CAST(N'2017-08-16T01:09:23.547' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (642, 29, N'H74934358200', N'Model-8f mach 1 al2', N'Pieza', CAST(N'2017-08-15T11:08:54.683' AS DateTime), CAST(N'2017-08-16T01:27:43.677' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (644, 29, N'H74934358210', N'Model-8f mach 1 al3', N'Pieza', CAST(N'2017-08-15T11:10:40.090' AS DateTime), CAST(N'2017-08-16T01:10:41.360' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (645, 29, N'H74934356710', N'Model-6f mach 1 guide vl3', N'Pieza', CAST(N'2017-08-15T11:12:25.437' AS DateTime), CAST(N'2017-08-16T01:12:26.703' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (646, 29, N'H74934356730', N'Model-6f mach 1 guide vl4', N'Pieza', CAST(N'2017-08-15T11:13:22.100' AS DateTime), CAST(N'2017-08-16T01:13:23.370' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (647, 29, N'H74934356750 ', N'Model-6f mach 1 guide vl5', N'Pieza', CAST(N'2017-08-15T11:13:53.450' AS DateTime), CAST(N'2017-08-16T01:13:54.720' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (648, 29, N'H74934357710', N'Model-7f mach 1 vl3', N'Pieza', CAST(N'2017-08-15T11:15:05.983' AS DateTime), CAST(N'2017-08-16T01:15:07.257' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (649, 29, N'H74934357730', N'Model-7f mach 1 vl4', N'Pieza', CAST(N'2017-08-15T11:16:28.150' AS DateTime), CAST(N'2017-08-16T01:16:29.423' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (650, 29, N'H74934357750', N'Model-7f mach 1 vl5', N'Pieza', CAST(N'2017-08-15T11:16:56.190' AS DateTime), CAST(N'2017-08-16T01:16:57.463' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (651, 29, N'H74934358710', N'Model-8f mach 1 vl3', N'Pieza', CAST(N'2017-08-15T11:17:51.550' AS DateTime), CAST(N'2017-08-16T01:17:52.817' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (652, 29, N'H74934358730', N'Model-8f mach 1 vl4', N'Pieza', CAST(N'2017-08-15T11:19:09.050' AS DateTime), CAST(N'2017-08-16T01:19:10.320' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (653, 29, N'H74934358750', N'Model-8f mach 1 vl5', N'Pieza', CAST(N'2017-08-15T11:20:02.383' AS DateTime), CAST(N'2017-08-16T01:20:03.657' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (654, 29, N'H74934356170', N'Model-6f mach 1 guide ar1', N'Pieza', CAST(N'2017-08-15T11:21:24.300' AS DateTime), CAST(N'2017-08-16T01:21:25.567' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (655, 29, N'H74934356180', N'Model-6f mach 1 guide ar2', N'Pieza', CAST(N'2017-08-15T11:22:05.533' AS DateTime), CAST(N'2017-08-16T01:22:06.800' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (656, 29, N'H74934357170', N'Model-7f mach 1 ar1', N'Pieza', CAST(N'2017-08-15T11:23:20.867' AS DateTime), CAST(N'2017-08-16T01:27:59.043' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (657, 29, N'H74934357180', N'Model-7f mach 1 ar2', N'Pieza', CAST(N'2017-08-15T11:30:39.210' AS DateTime), CAST(N'2017-08-16T01:30:40.480' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (658, 29, N'H74934358170', N'Model-7f mach 1 ar2', N'Pieza', CAST(N'2017-08-15T11:32:34.800' AS DateTime), CAST(N'2017-08-16T01:32:36.073' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (659, 29, N'H74934358180', N'Model-8f mach 1 ar2', N'Pieza', CAST(N'2017-08-15T11:33:13.770' AS DateTime), CAST(N'2017-08-16T01:33:15.040' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (660, 29, N'H749343562300', N'Model-6f mach 1 guide vr1', N'Pieza', CAST(N'2017-08-15T11:34:07.033' AS DateTime), CAST(N'2017-08-16T01:34:08.303' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (661, 29, N'H749343562310', N'Model-6f mach 1 guide vr2', N'Pieza', CAST(N'2017-08-15T11:34:35.980' AS DateTime), CAST(N'2017-08-16T01:34:37.257' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (662, 29, N'H749343572300', N'Model-7f mach 1 vr1', N'Pieza', CAST(N'2017-08-15T11:35:13.687' AS DateTime), CAST(N'2017-08-16T01:35:14.960' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (663, 29, N'H749343572310', N'Model-7f mach 1 vr2', N'Pieza', CAST(N'2017-08-15T11:35:35.090' AS DateTime), CAST(N'2017-08-16T01:35:36.367' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (664, 29, N'H749343582300', N'Model-8f mach 1 vr1', N'Pieza', CAST(N'2017-08-15T11:36:11.593' AS DateTime), CAST(N'2017-08-16T01:36:12.863' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (665, 29, N'H749343582310', N'Model-8f mach 1 vr2', N'Pieza', CAST(N'2017-08-15T11:36:31.553' AS DateTime), CAST(N'2017-08-16T01:36:32.833' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (666, 29, N'H74934356380', N'Model-6f mach 1 guide mp1', N'Pieza', CAST(N'2017-08-15T11:37:06.473' AS DateTime), CAST(N'2017-08-16T01:37:07.743' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (667, 29, N'H74934356390', N'Model-6f mach 1 guide mp2', N'Pieza', CAST(N'2017-08-15T11:37:28.680' AS DateTime), CAST(N'2017-08-16T01:37:29.960' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (668, 29, N'H74934357380', N'Model-7f mach 1 mp1', N'Pieza', CAST(N'2017-08-15T11:38:12.470' AS DateTime), CAST(N'2017-08-16T01:38:13.743' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (669, 29, N'H74934357390', N'Model-7f mach 1 mp2', N'Pieza', CAST(N'2017-08-15T11:38:39.657' AS DateTime), CAST(N'2017-08-16T01:38:40.933' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (670, 29, N'H74934358380', N'Model-8f mach 1 mp1', N'Pieza', CAST(N'2017-08-15T11:39:29.830' AS DateTime), CAST(N'2017-08-16T01:39:31.103' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (671, 29, N'H74934356260', N'Model-6f mach 1 guide im 100 cm', N'Pieza', CAST(N'2017-08-15T11:41:10.017' AS DateTime), CAST(N'2017-08-16T01:41:11.287' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (672, 29, N'H74934357260', N'Model-7f mach 1 im', N'Pieza', CAST(N'2017-08-15T11:42:12.703' AS DateTime), CAST(N'2017-08-16T01:42:13.977' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (673, 29, N'H74934358390', N'Model-8f mach 1 mp2', N'Pieza', CAST(N'2017-08-15T11:42:55.377' AS DateTime), CAST(N'2017-08-16T01:42:56.647' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (674, 29, N'H74934358260', N'Model-8f mach 1 im
', N'Pieza', CAST(N'2017-08-15T11:45:20.200' AS DateTime), CAST(N'2017-08-16T01:45:21.470' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (675, 40, N'H74916391212', N'Model d 5f fl3.5 b/5', N'Pieza', CAST(N'2017-08-15T12:17:38.910' AS DateTime), CAST(N'2017-08-16T02:17:40.190' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (676, 40, N'H74916391032', N'Model d 5f fr5(5pk)', N'Paquete', CAST(N'2017-08-15T12:19:19.677' AS DateTime), CAST(N'2017-08-16T02:19:20.957' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (677, 40, N'H74916391242', N'Model d 5f fl5 (5pk)', N'Paquete', CAST(N'2017-08-15T12:20:22.457' AS DateTime), CAST(N'2017-08-16T02:20:23.733' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (678, 40, N'H74916391412', N'Model-d 5f pig 145 110cm (5pk)', N'Paquete', CAST(N'2017-08-15T12:21:47.717' AS DateTime), CAST(N'2017-08-16T02:21:49.000' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (679, 40, N'H74916599402', N'Model - d 6f impulse pig 5 pack', N'Paquete', CAST(N'2017-08-15T12:30:26.367' AS DateTime), CAST(N'2017-08-16T02:30:27.643' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (680, 41, N'M001491181', N'Star/jfc/035/150/3j/ptfe/3/10 box 10', N'Caja', CAST(N'2017-08-15T12:52:30.297' AS DateTime), CAST(N'2017-08-16T02:52:31.583' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (681, 41, N'M001491201', N'Star/jfc/035/180/3j/ptfe/3/5 box 5', N'Caja', CAST(N'2017-08-15T12:54:13.370' AS DateTime), CAST(N'2017-08-16T02:54:14.653' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (682, 41, N'M001491211', N'Star/jfc/035/260/3j/ptfe/3/5 box 5', N'Caja', CAST(N'2017-08-15T12:55:52.267' AS DateTime), CAST(N'2017-08-16T02:55:53.550' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (683, 41, N'M001491011', N'Star/sfc/035/150/str/ptfe/3/10 box 10', N'Caja', CAST(N'2017-08-15T12:58:22.510' AS DateTime), CAST(N'2017-08-16T02:58:23.797' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (684, 41, N'M001491031', N'Star/sfc/035/260/str/ptfe/3/5 box 5', N'Caja', CAST(N'2017-08-15T13:00:30.460' AS DateTime), CAST(N'2017-08-16T03:00:31.750' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (685, 41, N'H74912132012', N'Model-choice flop (5pk)', N'Paquete', CAST(N'2017-08-15T13:09:10.820' AS DateTime), CAST(N'2017-08-16T03:10:40.130' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (686, 41, N'H74912160012', N'Model-choice pt (5pk)', N'Paquete', CAST(N'2017-08-15T13:10:22.847' AS DateTime), CAST(N'2017-08-16T03:10:24.133' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (687, 41, N'H74912133012', N'Model-choice int (5pk)', N'Paquete', CAST(N'2017-08-15T13:11:15.860' AS DateTime), CAST(N'2017-08-16T03:11:53.423' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (688, 41, N'H74912134012', N'Model-choice std (5pk)', N'Paquete', CAST(N'2017-08-15T13:13:36.900' AS DateTime), CAST(N'2017-08-16T03:13:38.190' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (689, 41, N'H7491213201J2', N'Model-choice flop j (5pk) ', N'Paquete', CAST(N'2017-08-15T13:20:36.590' AS DateTime), CAST(N'2017-08-16T03:20:37.880' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (690, 41, N'H7491211601J2', N'Model-choice 300 pt j (5pk) ', N'Paquete', CAST(N'2017-08-15T13:22:25.673' AS DateTime), CAST(N'2017-08-16T03:55:15.783' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (691, 41, N'H7491213301J2', N'Model-choice int j (5pk) ', N'Paquete', CAST(N'2017-08-15T13:23:13.880' AS DateTime), CAST(N'2017-08-16T03:23:15.173' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (692, 41, N'H74912117012', N'Model-choice 300 int (5pk) ', N'Paquete', CAST(N'2017-08-15T13:24:35.690' AS DateTime), CAST(N'2017-08-16T03:24:36.980' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (693, 41, N'H7491211701J2', N'Model-choice 300 int j (5pk) ', N'Paquete', CAST(N'2017-08-15T13:24:51.800' AS DateTime), CAST(N'2017-08-16T03:24:53.093' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (694, 41, N'H7491213401J2', N'Model-choice std j (5pk) ', N'Paquete', CAST(N'2017-08-15T13:25:42.840' AS DateTime), CAST(N'2017-08-16T03:54:27.710' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (695, 41, N'H74912118012', N'Model-choice 300 std (5pk) ', N'Paquete', CAST(N'2017-08-15T13:28:19.033' AS DateTime), CAST(N'2017-08-16T03:28:20.323' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (696, 41, N'H7491211801J2', N'Model-choice 300 std j (5pk) ', N'Paquete', CAST(N'2017-08-15T13:28:35.707' AS DateTime), CAST(N'2017-08-16T03:28:36.997' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (697, 41, N'H7491216001J2', N'Model-choice pt j (5pk) ', N'Paquete', CAST(N'2017-08-15T13:51:01.430' AS DateTime), CAST(N'2017-08-16T04:09:50.807' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (698, 41, N'H74938931032', N'Pt2 moderate support 185cm str, 5-pack', N'Paquete', CAST(N'2017-08-15T13:56:38.310' AS DateTime), CAST(N'2017-08-16T03:56:39.603' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (699, 41, N'H7493893103J2', N'Pt2 moderate support 185cm j-tip, 5-pack', N'Paquete', CAST(N'2017-08-15T13:57:39.517' AS DateTime), CAST(N'2017-08-16T03:57:40.813' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (700, 41, N'H74914903012', N'Model-graphix std (5pk)', N'Paquete', CAST(N'2017-08-15T13:58:44.477' AS DateTime), CAST(N'2017-08-16T03:58:45.773' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (701, 41, N'H14912135012', N'Model-choice es (5pk)', N'Paquete', CAST(N'2017-08-15T14:00:56.637' AS DateTime), CAST(N'2017-08-16T04:00:57.933' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (702, 41, N'H74912119012', N'Model-choice 300 es (5pk)', N'Paquete', CAST(N'2017-08-15T14:01:57.587' AS DateTime), CAST(N'2017-08-16T04:01:58.860' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (703, 41, N'H74912155012', N'Model-choice 300 pt es (5pk)', N'Paquete', CAST(N'2017-08-15T14:02:55.067' AS DateTime), CAST(N'2017-08-16T04:02:56.367' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (704, 41, N'H74912116012', N'Model-choice 300 flop (5pk)', N'Paquete', CAST(N'2017-08-15T14:07:50.020' AS DateTime), CAST(N'2017-08-16T04:07:51.310' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (705, 41, N'H74912154012', N'Model-choice 300 pt (5pk)', N'Paquete', CAST(N'2017-08-15T14:12:45.403' AS DateTime), CAST(N'2017-08-16T04:12:46.700' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (723, 66, N'AI-05210', N'Cateteres electrodo para marcapasos (sin balon) - marcapaso temporal 5 fr. 110 cm.', N'Pieza', CAST(N'2017-08-15T18:12:53.950' AS DateTime), CAST(N'2017-08-16T08:20:41.753' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (724, 66, N'AI-05225', N'Cateteres electrodo para marcapasos (sin balon) - marcapaso temporal 5 fr. 110 cm.', N'Pieza', CAST(N'2017-08-15T18:14:30.210' AS DateTime), CAST(N'2017-08-16T08:21:17.560' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (725, 66, N'AI-06210', N'Cateteres electrodo para marcapasos (sin balon) - marcapaso temporal 6 fr. 110 cm.', N'Pieza', CAST(N'2017-08-15T18:15:40.857' AS DateTime), CAST(N'2017-08-16T08:21:31.177' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (726, 66, N'AI-6225', N'Cateteres electrodo para marcapasos (sin balon) - marcapaso temporal 6 fr. 110 cm.', N'Pieza', CAST(N'2017-08-15T18:16:03.520' AS DateTime), CAST(N'2017-08-16T08:21:42.000' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (727, 66, N'AI-07154', N'Cateteres electrodo para marcapasos (con balon) - marcapaso temporal 5 fr. 105 cm.', N'Pieza', CAST(N'2017-08-15T18:17:23.750' AS DateTime), CAST(N'2017-08-16T08:22:17.033' AS DateTime))
GO
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (728, 66, N'AI-07155-IK', N'Cateteres electrodo para marcapasos (con balon) - marcapaso temporal 5 fr. 110 cm.', N'Pieza', CAST(N'2017-08-15T18:27:40.130' AS DateTime), CAST(N'2017-08-16T08:27:41.467' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (729, 66, N'AL-07067', N'Cateter termodilucion 7 fr. 110cm.', N'Pieza', CAST(N'2017-08-15T18:31:49.510' AS DateTime), CAST(N'2017-08-16T08:31:50.847' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (730, 66, N'AI-07167', N'Cateter termodilucion 7 fr 110 cm.', N'Pieza', CAST(N'2017-08-15T18:32:45.177' AS DateTime), CAST(N'2017-08-16T08:32:46.517' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (731, 66, N'AI-07134', N'Cateteres angiograficos berman - berman 4 fr. 50 cm.', N'Pieza', CAST(N'2017-08-15T18:33:58.247' AS DateTime), CAST(N'2017-08-16T08:33:59.590' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (732, 66, N'AI-07130', N'Cateteres angiograficos berman - berman 5 fr. 50 cm.', N'Pieza', CAST(N'2017-08-16T13:42:02.483' AS DateTime), CAST(N'2017-08-17T03:42:03.247' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (733, 66, N'AI-07135', N'Cateteres angiograficos berman - berman 5 fr. 80 cm.', N'Pieza', CAST(N'2017-08-16T13:42:21.690' AS DateTime), CAST(N'2017-08-17T03:42:22.450' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (734, 67, N'IAB-06840-U', N'Catéter con balón lntra-aórtico 40 cc 7.5 fr. Doble lumen ultraflex', N'Pieza', CAST(N'2017-08-16T14:04:32.890' AS DateTime), CAST(N'2017-08-17T04:04:33.657' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (735, 67, N'IAB-06830-U', N'Catéter con balón lntra-aórtico 30 cc 7.5 fr. Doble lumen ultraflex', N'Pieza', CAST(N'2017-08-16T14:04:58.397' AS DateTime), CAST(N'2017-08-17T04:04:59.160' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (736, 67, N'IAB-06850-U', N'Catéter con balón lntra-aórtico 50 cc 9.0 fr. Doble lumen ultraflex', N'Pieza', CAST(N'2017-08-16T14:05:10.833' AS DateTime), CAST(N'2017-08-17T04:05:11.600' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (737, 68, N'HB-A4400', N'Catéteres de diagnóstico para angiografia - jr 4.0 4fr', N'Pieza', CAST(N'2017-08-16T17:22:35.520' AS DateTime), CAST(N'2017-08-17T07:22:36.357' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (738, 68, N'HB-A5350', N'Catéteres de diagnóstico para angiografia - jr 3.5 5fr', N'Pieza', CAST(N'2017-08-16T17:23:26.707' AS DateTime), CAST(N'2017-08-17T07:23:27.550' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (739, 68, N'HB-A5400', N'Catéteres de diagnóstico para angiografia - jr 4.0 5fr', N'Pieza', CAST(N'2017-08-16T17:24:02.050' AS DateTime), CAST(N'2017-08-17T07:24:02.883' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (740, 68, N'HB-A6350', N'Catéteres de diagnóstico para angiografia - jr 3.5 6fr', N'Pieza', CAST(N'2017-08-16T17:25:30.353' AS DateTime), CAST(N'2017-08-17T07:25:31.187' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (741, 68, N'HB-A6400', N'Catéteres de diagnóstico para angiografia - jr 4.0 6fr', N'Pieza', CAST(N'2017-08-16T17:26:00.880' AS DateTime), CAST(N'2017-08-17T07:26:01.717' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (742, 68, N'HB-B5350', N'Catéteres de diagnóstico para angiografia - jl 3.5 5fr', N'Pieza', CAST(N'2017-08-16T17:27:37.017' AS DateTime), CAST(N'2017-08-17T07:28:01.283' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (743, 68, N'HB-B5400', N'Catéteres de diagnóstico para angiografia - jl 4.0 5fr', N'Pieza', CAST(N'2017-08-16T17:28:45.410' AS DateTime), CAST(N'2017-08-17T07:28:46.237' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (744, 68, N'HB-B5500', N'Catéteres de diagnóstico para angiografia - jl 5.0 5fr', N'Pieza', CAST(N'2017-08-16T17:29:12.990' AS DateTime), CAST(N'2017-08-17T07:29:13.830' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (745, 68, N'HB-B6350', N'Catéteres de diagnóstico para angiografia - jl 3.5 6fr', N'Pieza', CAST(N'2017-08-16T17:29:49.377' AS DateTime), CAST(N'2017-08-17T07:29:50.213' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (746, 68, N'HB-B6400', N'Catéteres de diagnóstico para angiografia - jl 4.0 6fr', N'Pieza', CAST(N'2017-08-16T17:30:07.087' AS DateTime), CAST(N'2017-08-17T07:30:07.933' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (747, 68, N'HB-B6500', N'Catéteres de diagnóstico para angiografia - jl 5.0 6fr', N'Pieza', CAST(N'2017-08-16T17:30:36.647' AS DateTime), CAST(N'2017-08-17T07:30:37.483' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (748, 68, N'HB-D5000', N'Catéteres de diagnóstico para angiografia - mpa 1 5fr', N'Pieza', CAST(N'2017-08-16T17:31:29.847' AS DateTime), CAST(N'2017-08-17T07:31:30.683' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (749, 68, N'HB-D6000', N'Catéteres de diagnóstico para angiografia - mpa 1 6fr', N'Pieza', CAST(N'2017-08-16T17:31:44.580' AS DateTime), CAST(N'2017-08-17T07:31:45.427' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (750, 68, N'HB-E4000', N'Catéteres de diagnóstico para angiografia - mpa 2 sh 100cm 4fr', N'Pieza', CAST(N'2017-08-16T17:32:16.607' AS DateTime), CAST(N'2017-08-17T07:32:17.447' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (751, 68, N'HB-E5000', N'Catéteres de diagnóstico para angiografia - mpa 2 sh 100cm 5fr', N'Pieza', CAST(N'2017-08-16T17:32:38.407' AS DateTime), CAST(N'2017-08-17T07:32:39.247' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (752, 68, N'HB-E6000', N'Catéteres de diagnóstico para angiografia - mpa 2 sh 100cm 6fr', N'Pieza', CAST(N'2017-08-16T17:33:03.957' AS DateTime), CAST(N'2017-08-17T07:33:04.803' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (753, 68, N'HB-E6001', N'Catéteres de diagnóstico para angiografia - mpa 2 sh 105cm 6fr', N'Pieza', CAST(N'2017-08-16T17:33:25.077' AS DateTime), CAST(N'2017-08-17T07:33:25.923' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (754, 68, N'HB-H5000', N'Catéteres de diagnóstico para angiografia - al 1 5fr', N'Pieza', CAST(N'2017-08-16T17:36:48.143' AS DateTime), CAST(N'2017-08-17T07:36:48.980' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (755, 68, N'HB-H6000', N'Catéteres de diagnóstico para angiografia - al 1 6fr', N'Pieza', CAST(N'2017-08-16T17:37:07.967' AS DateTime), CAST(N'2017-08-17T07:37:08.813' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (756, 68, N'HB-I5000', N'Catéteres de diagnóstico para angiografia - al 2 5fr', N'Pieza', CAST(N'2017-08-16T17:37:30.397' AS DateTime), CAST(N'2017-08-17T07:37:31.243' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (757, 68, N'HB-I6000', N'Catéteres de diagnóstico para angiografia - al 2 6fr', N'Pieza', CAST(N'2017-08-16T17:37:45.260' AS DateTime), CAST(N'2017-08-17T07:37:46.110' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (758, 68, N'HB-K5000', N'Catéteres de diagnóstico para angiografia - ar 1 5fr', N'Pieza', CAST(N'2017-08-16T17:38:15.353' AS DateTime), CAST(N'2017-08-17T07:38:16.190' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (759, 68, N'HB-K6000', N'Catéteres de diagnóstico para angiografia - ar 1 6fr', N'Pieza', CAST(N'2017-08-16T17:38:28.803' AS DateTime), CAST(N'2017-08-17T07:38:29.653' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (760, 68, N'HB-N5000', N'Catéteres de diagnóstico para angiografia - im 5fr', N'Pieza', CAST(N'2017-08-16T17:38:53.587' AS DateTime), CAST(N'2017-08-17T07:38:54.430' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (761, 68, N'HB-N6000', N'Catéteres de diagnóstico para angiografia - im 6fr', N'Pieza', CAST(N'2017-08-16T17:39:14.633' AS DateTime), CAST(N'2017-08-17T07:39:15.477' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (762, 69, N'BG-A6F-ASPICATH', N'Catéter de aspiración de 6f', N'Pieza', CAST(N'2017-08-16T18:04:43.997' AS DateTime), CAST(N'2017-08-17T08:04:44.843' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (763, 69, N'BG-A7F-ASPICATH', N'Catéter de aspiración de 7f', N'Pieza', CAST(N'2017-08-16T18:05:04.520' AS DateTime), CAST(N'2017-08-17T08:05:05.370' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (764, 25, N'BG-C15010-CETO', N'Catéter de balón de dilatación ceto tm - 1.5mm x 10mm', N'Pieza', CAST(N'2017-08-16T18:32:39.473' AS DateTime), CAST(N'2017-08-18T03:50:39.500' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (765, 25, N'BG-C15015-CETO', N'Catéter de balón de dilatación ceto tm - 1.5mm x 15mm', N'Pieza', CAST(N'2017-08-17T13:49:20.907' AS DateTime), CAST(N'2017-08-18T03:50:56.763' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (766, 25, N'BG-C15020-CETO', N'Catéter de balón de dilatación ceto tm - 1.5mm x 20mm', N'Pieza', CAST(N'2017-08-17T13:50:22.573' AS DateTime), CAST(N'2017-08-18T03:51:13.603' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (767, 25, N'BG-C15030-CETO', N'Catéter de balón de dilatación ceto tm - 1.5mm x 30mm', N'Pieza', CAST(N'2017-08-17T13:51:51.963' AS DateTime), CAST(N'2017-08-18T03:51:51.240' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (768, 25, N'BG-C20010-CETO', N'Catéter de balón de dilatación ceto tm - 2mm x 10mm', N'Pieza', CAST(N'2017-08-17T13:52:20.943' AS DateTime), CAST(N'2017-08-18T03:52:20.223' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (769, 25, N'BG-C20020-CETO', N'Catéter de balón de dilatación ceto tm - 2mm x 20mm', N'Pieza', CAST(N'2017-08-17T13:57:11.177' AS DateTime), CAST(N'2017-08-18T03:57:10.457' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (770, 25, N'BG-C20030-CETO', N'Catéter de balón de dilatación ceto tm - 2mm x 30mm', N'Pieza', CAST(N'2017-08-17T13:57:31.170' AS DateTime), CAST(N'2017-08-18T03:57:30.457' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (771, 25, N'BG-C22510-CETO', N'Catéter de balón de dilatación ceto tm - 2.25mm x 10mm', N'Pieza', CAST(N'2017-08-17T13:58:10.430' AS DateTime), CAST(N'2017-08-18T03:58:09.710' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (772, 25, N'BG-C22515-CETO', N'Catéter de balón de dilatación ceto tm - 2.25mm x 15mm', N'Pieza', CAST(N'2017-08-17T13:58:29.010' AS DateTime), CAST(N'2017-08-18T03:58:28.297' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (773, 25, N'BG-C22520-CETO', N'Catéter de balón de dilatación ceto tm - 2.25mm x 20mm', N'Pieza', CAST(N'2017-08-17T13:58:44.273' AS DateTime), CAST(N'2017-08-18T03:58:43.560' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (774, 25, N'BG-C22530-CETO', N'Catéter de balón de dilatación ceto tm - 2.25mm x 30mm', N'Pieza', CAST(N'2017-08-17T13:58:58.633' AS DateTime), CAST(N'2017-08-18T03:58:57.920' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (775, 25, N'BG-C25010-CETO', N'Catéter de balón de dilatación ceto tm - 2.5mm x 10mm', N'Pieza', CAST(N'2017-08-17T13:59:21.853' AS DateTime), CAST(N'2017-08-18T04:00:12.213' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (776, 25, N'BG-C25015-CETO', N'Catéter de balón de dilatación ceto tm - 2.5mm x 15mm', N'Pieza', CAST(N'2017-08-17T14:00:27.637' AS DateTime), CAST(N'2017-08-18T04:00:26.920' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (777, 25, N'BG-C25020-CETO', N'Catéter de balón de dilatación ceto tm - 2.5mm x 20mm', N'Pieza', CAST(N'2017-08-17T14:00:53.923' AS DateTime), CAST(N'2017-08-18T04:00:53.210' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (778, 25, N'BG-C25030-CETO', N'Catéter de balón de dilatación ceto tm - 2.5mm x 30mm', N'Pieza', CAST(N'2017-08-17T14:01:16.473' AS DateTime), CAST(N'2017-08-18T04:01:15.757' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (779, 25, N'BG-C30010-CETO', N'Catéter de balón de dilatación ceto tm - 3mm x 10mm', N'Pieza', CAST(N'2017-08-17T14:01:42.557' AS DateTime), CAST(N'2017-08-18T04:05:42.493' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (780, 25, N'BG-C30015-CETO', N'Catéter de balón de dilatación ceto tm - 3mm x 15mm', N'Pieza', CAST(N'2017-08-17T14:01:58.217' AS DateTime), CAST(N'2017-08-18T04:05:36.470' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (781, 25, N'BG-C30020-CETO', N'Catéter de balón de dilatación ceto tm - 3mm x 20mm', N'Pieza', CAST(N'2017-08-17T14:02:14.427' AS DateTime), CAST(N'2017-08-18T04:05:29.797' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (782, 25, N'BG-C30030-CETO', N'Catéter de balón de dilatación ceto tm - 3mm x 30mm', N'Pieza', CAST(N'2017-08-17T14:02:30.020' AS DateTime), CAST(N'2017-08-18T04:05:21.950' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (783, 25, N'BG-C35010-CETO', N'Catéter de balón de dilatación ceto tm - 3.5mm x 10mm', N'Pieza', CAST(N'2017-08-17T14:02:59.010' AS DateTime), CAST(N'2017-08-18T04:02:58.293' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (784, 25, N'BG-C35015-CETO', N'Catéter de balón de dilatación ceto tm - 3.5mm x 15mm', N'Pieza', CAST(N'2017-08-17T14:03:11.313' AS DateTime), CAST(N'2017-08-18T04:03:10.600' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (785, 25, N'BG-C35020-CETO', N'Catéter de balón de dilatación ceto tm - 3.5mm x 20mm', N'Pieza', CAST(N'2017-08-17T14:03:24.977' AS DateTime), CAST(N'2017-08-18T04:03:24.263' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (786, 25, N'BG-C35030-CETO', N'Catéter de balón de dilatación ceto tm - 3.5mm x 30mm', N'Pieza', CAST(N'2017-08-17T14:03:48.760' AS DateTime), CAST(N'2017-08-18T04:03:48.040' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (787, 25, N'BG-C40010-CETO', N'Catéter de balón de dilatación ceto tm - 4mm x 10mm', N'Pieza', CAST(N'2017-08-17T14:04:03.530' AS DateTime), CAST(N'2017-08-18T04:05:13.893' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (788, 25, N'BG-C40015-CETO', N'Catéter de balón de dilatación ceto tm - 4mm x 15mm', N'Pieza', CAST(N'2017-08-17T14:04:15.227' AS DateTime), CAST(N'2017-08-18T04:05:07.837' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (789, 25, N'BG-C40020-CETO', N'Catéter de balón de dilatación ceto tm - 4mm x 20mm', N'Pieza', CAST(N'2017-08-17T14:04:32.730' AS DateTime), CAST(N'2017-08-18T04:05:02.020' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (790, 25, N'BG-C40030-CETO', N'Catéter de balón de dilatación ceto tm - 4mm x 30mm', N'Pieza', CAST(N'2017-08-17T14:04:50.327' AS DateTime), CAST(N'2017-08-18T04:04:49.607' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (791, 70, N'HR-3031', N'Cables guia diagnósticos - 0.035 x 150cm - j 3 mm - distal doble - nucleo fijo, se endereza manualmente', N'Pieza', CAST(N'2017-08-17T15:29:51.393' AS DateTime), CAST(N'2017-08-18T05:54:56.730' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (792, 70, N'HR-3812', N'Cables guia diagnósticos - 0.035 x 150cm - recta - distal sencillo - nucleo fijo', N'Pieza', CAST(N'2017-08-17T15:31:00.643' AS DateTime), CAST(N'2017-08-18T05:55:02.770' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (794, 70, N'HR-3822', N'Cables guia diagnósticos - 0.035 x 150cm - j 3 mm - distal sencillo - nucleo fijo, se endereza manualmente', N'Pieza', CAST(N'2017-08-17T15:32:12.690' AS DateTime), CAST(N'2017-08-18T05:55:07.907' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (795, 70, N'HR-3823', N'Cables guia diagnósticos - 0.035 x 150cm - j 3 mm - distal sencillo - nucleo fijo, se endereza manualmente, cuerpo firme', N'Pieza', CAST(N'2017-08-17T15:33:32.877' AS DateTime), CAST(N'2017-08-18T05:55:13.907' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (796, 70, N'HR-3828', N'Cables guia amplatz - 0.035 x 260cm - long. 12cm - j modificada', N'Pieza', CAST(N'2017-08-17T15:35:35.503' AS DateTime), CAST(N'2017-08-18T05:35:34.797' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (797, 70, N'HR-3831', N'Cables guia diagnósticos - 0.035 x 150cm - j 3mm - distal doble - nucleo fijo, se endereza manualmente', N'Pieza', CAST(N'2017-08-17T15:37:24.797' AS DateTime), CAST(N'2017-08-18T05:55:19.833' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (798, 70, N'HR-3922', N'Cables guia diagnósticos - 0.035 x 260cm - j 3mm - distal sencillo - nucleo fijo, se endereza manualmente', N'Pieza', CAST(N'2017-08-17T15:38:06.583' AS DateTime), CAST(N'2017-08-18T05:55:24.313' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (799, 70, N'HR-5521', N'Cables guia diagnósticos - 0.035 x 150cm - j 3 mm - distal sencillo - nucleo movil', N'Pieza', CAST(N'2017-08-17T15:42:31.140' AS DateTime), CAST(N'2017-08-18T05:55:28.657' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (800, 70, N'HR-4822', N'Cables guia diagnósticos - 0.038 x 150cm - j 3 mm - distal sencillo - nucleo fijo, se endereza manualmente', N'Pieza', CAST(N'2017-08-17T15:54:50.473' AS DateTime), CAST(N'2017-08-18T05:58:18.427' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (801, 70, N'HR-4862', N'Cables guia diagnósticos - 0.038 x 150cm - recta - distal sencillo - nucleo fijo', N'Pieza', CAST(N'2017-08-17T15:58:05.293' AS DateTime), CAST(N'2017-08-18T05:58:04.597' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (802, 70, N'HR-4912', N'Cables guia diagnósticos - 0.038 x 260cm - j 3 mm - distal sencillo - nucleo fijo', N'Pieza', CAST(N'2017-08-17T15:59:02.770' AS DateTime), CAST(N'2017-08-18T06:00:38.777' AS DateTime))
INSERT [dbo].[registros_claves_referencias] ([id_clave_registro], [id_registro_sanitario], [clave_ref_cod], [descripcion], [unidad_venta], [creado_en], [actualizado_en]) VALUES (803, 70, N'HR-4922', N'Cables guia diagnósticos - 0.038 x 260cm - j 3 mm - distal sencillo - nucleo fijo, se endereza manualmente', N'Pieza', CAST(N'2017-08-17T16:00:15.497' AS DateTime), CAST(N'2017-08-18T06:00:14.797' AS DateTime))
SET IDENTITY_INSERT [dbo].[registros_claves_referencias] OFF
SET IDENTITY_INSERT [dbo].[registros_sanitarios] ON 

INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (2, N'Modificación', N'0013C2009', N'153300402A1105', N'JUAMA S.A de C.V', N'JUA 850809 GK7', N'Controlador Manual Multipaciente "AVA 500 HC"', N'Controlador manual para sistema de inyección de medios de contraste', N'Bayer Medical Care Inc', N'Bayer Medical Care Inc', 1, CAST(N'2014-01-14T00:00:00.000' AS DateTime), CAST(N'2019-01-14T00:00:00.000' AS DateTime), N'0013C2009_MEDRAD_AVANTA.pdf', CAST(N'2017-07-18T10:59:54.240' AS DateTime), CAST(N'2017-07-18T11:36:47.993' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (3, N'Prórroga', N'2145C2011', N'163300421D0177', N'MEDTRONIC, S. DE R.L. DE C.V.', N'MED 730308NF0', N'ENSURA DR MRI™ SURESCAN™.', N'MARCAPASO CARDIACO PROGRAMABLE.', N'MEDTRONIC EUROPE SARL.', N'MEDTRONIC', 2, CAST(N'2016-09-30T00:00:00.000' AS DateTime), CAST(N'2021-09-30T00:00:00.000' AS DateTime), N'2145C2011_MEDTRONIC_ENSURA MRI SURESCAN.pdf', CAST(N'2017-07-18T13:42:33.497' AS DateTime), CAST(N'2017-07-18T13:42:26.380' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (4, N'Registro', N'2372C2015', N'163300C1080057', N'MEDTRONIC, S. DE R.L. DE C.V.', N'MED 730308 NF0', N'ELECTRODO DE ESTIMULACION CARDIACA MEDTRONIC CAPSURE', N'ELECTRODO DE ESTIMULACION CARDIACA IMPLANTABLE', N'MEDTRONIC PUERTO RICO OPERATION., VILLALBA', N'MEDTRONIC', 1, CAST(N'2015-12-15T00:00:00.000' AS DateTime), CAST(N'2020-12-15T00:00:00.000' AS DateTime), N'2372C2015_MEDTRONIC_ELECTRODO CAPSURE.pdf', CAST(N'2017-07-18T13:58:51.030' AS DateTime), CAST(N'2017-07-18T13:58:43.917' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (5, N'Registro', N'2389C2015', N'163300C1080018', N'MEDTRONIC, S. DE R.L. DE C.V.', N'MED 730308NF0', N'ELECTRODO DE ESTIMULACION CARDIACA MEDTRONIC CAPSURE NOVUS', N'ELECTRODO DE ESTIMULACION CARDIACA', N'MEDTRONIC PUERTO RICO OPERATION CO.,VILLALBA', N'MEDTRONIC', 1, CAST(N'2015-12-18T00:00:00.000' AS DateTime), CAST(N'2020-12-18T00:00:00.000' AS DateTime), N'NR  Capsure Novus 2389C2015 SSA  20ene16.pdf', CAST(N'2017-07-18T14:16:33.033' AS DateTime), CAST(N'2017-07-18T14:16:25.703' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (6, N'Modificación', N'556C93', N'143300402A0893', N'MEDTRONIC, S. DE R.L DE C.V.', N'MED 730308 NF0', N'INTRODUCTOR PARA CABLE IMPLANTABLE MEDTRONIC', N'INTRODUCTOR PARA CABLE IMPLANTABLE ', N'MEDTRONIC, INC', N'MEDTRONIC', 1, CAST(N'2012-06-19T00:00:00.000' AS DateTime), CAST(N'2017-06-19T00:00:00.000' AS DateTime), N'Introductor para cable implantable-556C93SSA con acuse de prorroga-OK.pdf', CAST(N'2017-07-18T14:23:23.523' AS DateTime), CAST(N'2017-07-18T14:23:16.180' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (7, N'Prórroga', N'0573C2011', N'153300421D0082', N'KENDALL DE MEXICO, S.A. DE C.V.', N'KME 590502HY7', N'AUTOSUTURE™ GIA™ COVIDIEN', N'ENGRAPADORA QUIRURGICA RECARGABLE.', N'COVIDIEN,  LLC.', N'COVIDIEN', 1, CAST(N'2016-03-11T00:00:00.000' AS DateTime), CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'ENGI-009_AUTOSUTURE GIA_0573C2011_PRORROGA.PDF', CAST(N'2017-07-19T10:09:32.023' AS DateTime), CAST(N'2017-07-19T10:09:23.850' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (8, N'Registro', N'0005C2012', N'113300401B0462', N'IMPULSO MEXICANO, S.A DE C.V.', N'IME960710 JZ2', N'CATETER BALON PANTERA LUX BIOTRONIK', N'CATETER BALON CORONARIO CON LIBERACION DE PACLITAXEL', N'BIOTRONIK AG', N'BIOTRONIK', 2, CAST(N'2012-01-05T00:00:00.000' AS DateTime), CAST(N'2017-01-05T00:00:00.000' AS DateTime), N'0005C2012SSA_ BALON PANTERA LUX_05_01_17.pdf', CAST(N'2017-07-19T12:27:47.203' AS DateTime), CAST(N'2017-07-19T12:27:38.970' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (9, N'Prórroga', N'1421C96', N'153300421C2526', N'JOHNSON & JOHNSON DE MEXICO, S.A DE C.V.', N'JJM531116CE7', N'CATETER DE DIAGNOSTICO EN CARDIOLOGIA CORDIS', N'CATETER DE DIAGNOSTICO', N'CORDIS CASHEL', N'CORDIS', 3, CAST(N'2016-08-01T00:00:00.000' AS DateTime), CAST(N'2021-08-01T00:00:00.000' AS DateTime), N'1421C96SSA_JHONSON_INFINITI.pdf', CAST(N'2017-07-19T12:34:27.930' AS DateTime), CAST(N'2017-07-19T12:34:19.737' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (11, N'Registro', N'0023C2015', N'143300401M0617', N'MSM SALUD S.A. DE C.V.', N'MSA 110126 UC4', N'ANGIO-LINE™ PTCA KITS & ACCESORIOS', N'KITS PARA ANGIOGRAFIA, ANGIOPLASTIA Y CATETERISMO', N'BIOMETRIX LIMITED', N'BIOMETRIX', 1, CAST(N'2015-01-07T00:00:00.000' AS DateTime), CAST(N'2020-01-07T00:00:00.000' AS DateTime), N'0023C2015SSA_KIT ACTP 07ENE2020.pdf', CAST(N'2017-07-19T13:55:09.077' AS DateTime), CAST(N'2017-07-19T13:55:00.863' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (12, N'Registro', N'0133E2012', N'123300C1080150', N'MEDSTENT, S.A DE C.V.', N'MED 9503001RK2', N'PRIMEWIRE PRESTIGE™', N'GUIA DE PRESION', N'VOLCANO CORPORATION', N'VOLCANO', 1, CAST(N'2012-02-20T00:00:00.000' AS DateTime), CAST(N'2017-01-23T00:00:00.000' AS DateTime), N'133E2012SSA_23_01_2017_PRIME WIRE PRESTIGE.pdf', CAST(N'2017-07-19T16:25:01.920' AS DateTime), CAST(N'2017-07-19T16:24:52.823' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (13, N'Prórroga', N'0171C98', N'103300CT082010', N'JUAMA, S.A. DE C.V.', N'JUA-850809GK7', N'JERINGA PARA MEDIO DE CONTRASTE MEDRAD-JUAMA', N'JERINGA PARA MEDIO DE CONTRASTE', N'MEDRAD INC.', N'MEDRAD', 1, CAST(N'2012-05-30T00:00:00.000' AS DateTime), CAST(N'2017-05-30T00:00:00.000' AS DateTime), N'0171C98 SSA_30_05_2017_JUAMA_JERINGAS_.pdf', CAST(N'2017-07-19T16:27:43.227' AS DateTime), CAST(N'2017-07-19T16:27:34.203' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (14, N'Modificación', N'0194C2010', N'153300402A1104', N'JUAMA, S.A DE C.V.', N'JUA 850809 GK7', N'EQUIPO DESECHABLE PARA EL SISTEMA DE INYECCION DE ADMINISTRACION DE FLUIDO AVANTA MEDRAD', N'EQUIPO PARA LA APLICACION DE VOLUMENES MEDIDOS', N'BAYER MEDICAL CARE INC.', N'BAYER', 1, CAST(N'2015-10-15T00:00:00.000' AS DateTime), CAST(N'2020-03-09T00:00:00.000' AS DateTime), N'0194C2010SSA AVA500 SPTA MPTA 9MAR2020.pdf', CAST(N'2017-07-19T16:30:45.260' AS DateTime), CAST(N'2017-07-20T09:45:10.460' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (15, N'Prórroga', N'0219C2001', N'143300421C16', N'BOSTON SCIENTIFIC DE MEXICO, S.A DE C.V.', N'BSM 961107QV7', N'STENT PERIFERICO VASCULAR CAROLID WALLSTENT BOSTON SCIENTIFIC', N' STENT PERIFERICO VASCULAR', N'BOSTON SCIENTIFIC LIMITED', N'BOSTON', 1, CAST(N'2015-06-23T00:00:00.000' AS DateTime), CAST(N'2020-06-23T00:00:00.000' AS DateTime), N'0219C2001_CAROTID WALLSTENT_23Jun2020.pdf', CAST(N'2017-07-20T11:05:51.327' AS DateTime), CAST(N'2017-07-20T11:05:47.427' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (16, N'Prórroga', N'0399C2010', N'143300C1081098', N'JOHNSON & JOHNSON DE MEXICO, S.A DE C.V.', N'JJM 531116 CE7', N'MAXI LD™ CATETER DE BALON DE GRAN DIAMETRO PARA ANGIOPLASTIA', N'CATETER BALON', N'CORDIS CASHEL', N'CORDIS', 3, CAST(N'2015-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-17T00:00:00.000' AS DateTime), N'0399C2010 MAXI LD_JUN2020.pdf', CAST(N'2017-07-20T11:31:52.143' AS DateTime), CAST(N'2017-07-20T11:31:48.510' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (17, N'Prórroga', N'0446C2002', N'143300421C1011', N'JOHNSON & JOHNSON DE MEXICO, S.A DE C.V.', N'JJM 531116 CE7', N'STENT PERIFERICO PALMAZ GENESIS EN SISTEMAS DE POSICIONAMIENTO', N'STENT PERIFERICO', N'CORDIS CASHEL', N'CORDIS', 3, CAST(N'2015-06-21T00:00:00.000' AS DateTime), CAST(N'2020-06-21T00:00:00.000' AS DateTime), N'0446C2002__21_06_2020_STENT PALMAZ GENESIS.pdf', CAST(N'2017-07-20T11:56:07.450' AS DateTime), CAST(N'2017-07-20T11:56:03.810' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (18, N'Registro', N'0452C2013', N'123300401F0372', N'BOSTON SCIENTIFIC DE MEXICO S.A. DE C.V.', N'BSM 961107QV7', N'SISTEMA DE STENT AUTOEXPANSIBLE INNOVA™ BOSTON SCIENTIFIC ', N'SISTEMA DE STENT AUTOEXPANSIBLE', N'BOSTON SCIENTIFIC CORPORATION', N'BOSTON', 1, CAST(N'2013-02-22T00:00:00.000' AS DateTime), CAST(N'2018-02-22T00:00:00.000' AS DateTime), N'0452C2013_STENT INOVA_22Feb2018.pdf', CAST(N'2017-07-20T12:00:07.773' AS DateTime), CAST(N'2017-07-20T12:00:04.137' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (20, N'Registro', N'0454C2015', N'153300C1080220', N'SOLUCION INTEGRAL A SUS NECESIDADES REGULATORIAS, S.A DE C.V.', N'SIA090603 FS3', N'BIOFREEDOM™', N'SISTEMA DE STENT CORONARIO FARMACOACTIVO', N'BIOSENSORS INTERVENTIONAL TECHNOLOGIES PTE, LTD.', N'BIOSENSORS', 5, CAST(N'2015-03-11T00:00:00.000' AS DateTime), CAST(N'2020-02-17T00:00:00.000' AS DateTime), N'0454C2015SSA STENT BIOFREDOM 17FEB20.pdf', CAST(N'2017-07-20T12:43:45.693' AS DateTime), CAST(N'2017-07-20T12:44:38.380' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (21, N'Modificación', N'0464C2008', N'153300C1080646', N'BOSTON SCIENTIFIC DE MEXICO S.A. DE C.V.', N'BSM961107QV7', N'CATETER DE DILATACION PTCA APEXTM', N'CATETER DE DILATACION', N'BOSTON SCIENTIFIC LIMITED', N'BOSTON', 3, CAST(N'2013-05-29T00:00:00.000' AS DateTime), CAST(N'2018-05-29T00:00:00.000' AS DateTime), N'0464C2008_29_05_2018 BALON APEX RX.pdf', CAST(N'2017-07-20T12:57:40.543' AS DateTime), CAST(N'2017-07-20T12:57:36.853' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (22, N'Registro', N'0488C2012', N'113300401F0226', N'JOHNSON & JOHNSON DE MEXICO, S.A DE C.V.', N'JJM 531116CE7', N'EMPIRA™ PTCA DILATATION CATHETER', N'CATETER DE DILATACION CON BALON PARA ATP', N'CREGANNA-TACTX MEDICAL PTE LTD.', N'CREGANNA', 5, CAST(N'2012-03-06T00:00:00.000' AS DateTime), CAST(N'2017-03-06T00:00:00.000' AS DateTime), N'0488C2012 EMPIRA MAR2017.pdf', CAST(N'2017-07-20T13:00:49.850' AS DateTime), CAST(N'2017-07-20T13:00:46.203' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (23, N'Prórroga', N'0548C2008', N'143300C1080450', N'JOHNSON & JHONSON DE MEXICO, S.A DE C.V.', N'JJM531116CE7', N'CORDIS AVIATOR™ PLUS', N'CATETER PERCUTANEO', N'CORDIS CASHEL', N'CORDIS', 3, CAST(N'2014-03-28T00:00:00.000' AS DateTime), CAST(N'2018-07-18T00:00:00.000' AS DateTime), N'0548C2008SSA_AVIATOR PLUS JUL2018.pdf', CAST(N'2017-07-20T13:04:24.420' AS DateTime), CAST(N'2017-07-20T13:04:20.773' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (24, N'Prórroga', N'627E96', N'153300CI1080750', N'JOHNSON & JOHNSON DE MEXICO, S.A. DE C.V.', N'JJM 531116CE7', N'CORDIS GUIA IMISA CORDIS', N'CATETER GUIA PARA ANGIOGRAFIA', N'CORDIS CORPORATION', N'CORDIS', 1, CAST(N'2015-09-06T00:00:00.000' AS DateTime), CAST(N'2020-09-06T00:00:00.000' AS DateTime), N'627E96 CAT GUIA_06_09_2020.pdf', CAST(N'2017-07-20T15:00:01.177' AS DateTime), CAST(N'2017-07-20T14:59:57.500' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (25, N'Registro', N'0689C2015', N'143300401M0619', N'MSM SALUD, S.A DE C.V.', N'MSA 110126UC4', N'CATETER BALON DE ANGIOPLASTIA CETO - BIOMETRIX', N'CATETER BALON PARA ACTP', N'BIOMETRIX LIMITED', N'BIOMETRIX', 6, CAST(N'2015-03-18T00:00:00.000' AS DateTime), CAST(N'2020-03-18T00:00:00.000' AS DateTime), N'0689C2015SSA__18_03_2020_BALONES PARA ACTP_BIOMETRIX.pdf', CAST(N'2017-07-20T16:13:45.140' AS DateTime), CAST(N'2017-07-20T16:43:22.250' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (26, N'Registro', N'0705C2012', N'133300CT080134', N'BOSTON SCIENTIFIC DE MEXICO, S.A. DE C.V.', N'BSM961107QV7', N'INTERLOCK™ SISTEMA DE OCLUSION IDC™ CON FIBRA BOSTON SCIENTIFIC ', N'ESPIRAL PARA EMBOLIZACION VASCULAR', N'BOSTON SCIENTIFIC CORK, LTD.', N'BOSTON ', 3, CAST(N'2013-06-12T00:00:00.000' AS DateTime), CAST(N'2017-03-20T00:00:00.000' AS DateTime), N'0705C2012_INTERLOCK_20_03_2017.pdf', CAST(N'2017-07-20T16:27:58.527' AS DateTime), CAST(N'2017-07-20T16:29:01.193' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (27, N'Modificación', N'0793C2008', N'143300402A0528', N'JHONSON & JHONSON DE MEXICO, S.A. DE C.V.', N'JJM531116CE7', N'CATETER DE DIAGNOSTICO POR ULTRASONIDO ACUSON ACUNAV', N'CATETER DE IMAGENOLOGIA POR ULTRASONIDO', N'SIEMENS LD. SEOUL', N'SIEMENS', 7, CAST(N'2013-06-24T00:00:00.000' AS DateTime), CAST(N'2018-06-24T00:00:00.000' AS DateTime), N'0793C2008SSA_24_06_2018_ ACUSON ACUNAV.pdf', CAST(N'2017-07-20T17:31:32.463' AS DateTime), CAST(N'2017-07-20T17:54:41.860' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (28, N'Registro', N'0833C2015', N'153300C1080515', N'BOSTON SCIENTIFIC DE MEXICO, S.A. DE C.V.', N'BSM 961107QV7', N'ALAMBRE GUIA PREFORMADA TAVR/TAVI SAFARI™', N'ALAMBRE GUIA', N'LAKE REGIONAL MEDICAL', N'LAKE', 1, CAST(N'2015-04-10T00:00:00.000' AS DateTime), CAST(N'2020-04-10T00:00:00.000' AS DateTime), N'0833C2015_10_04_2020_GUIA SAFARI TAVI.pdf', CAST(N'2017-07-20T18:08:11.717' AS DateTime), CAST(N'2017-07-20T18:08:08.027' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (29, N'Prórroga', N'00841E2000', N'153300C1080742', N'BOSTON SCIENTIFIC DE MEXICO, S.A. DE C.V.', N'BSM 961107QV7', N'CATETER GUIA BOSTON SCIENTIFIC ', N'CATETER GUIA', N'AVAILMED. S.A. DE C.V.', N'AVAILMED', 8, CAST(N'2015-07-02T00:00:00.000' AS DateTime), CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'00841E2000_02Jul2020_Próg MACH1 cat guia.pdf', CAST(N'2017-07-20T18:23:20.903' AS DateTime), CAST(N'2017-07-20T18:23:17.210' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (30, N'Modificación', N'2233C2012', N'143300CT080758', N'LEVBETH MEDICAL, S.A DE C.V.', N'LME 051104FZ8', N'MICROESFERAS EMBOZENE®', N'MICROESFERAS PARA EMBOLIZACION', N'CELONOVA BIOSCIENCES GERMANY GMBH', N'CELONOVA', 9, CAST(N'2012-08-24T00:00:00.000' AS DateTime), CAST(N'2017-08-24T00:00:00.000' AS DateTime), N'2233C2012SSA_CELONOVA BIOSCIENCES_EMBOZENE MICROESFERAS.pdf', CAST(N'2017-07-21T16:35:49.467' AS DateTime), CAST(N'2017-07-21T16:35:44.020' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (31, N'Modificación', N'00055C2000', N'113300402A0606', N'SJ MEDICAL MEXICO, S. DE R.L. DE C.V.', N'SMM080923UA', N'ANGIO SEAL DAIG', N'DISPOSITIVO HEMOSTATICO DE CIERRE VASCULAR', N'SI JUDE MEDICAL', N'SI JUDE ', 1, CAST(N'2012-10-03T00:00:00.000' AS DateTime), CAST(N'2016-05-25T00:00:00.000' AS DateTime), N'00055C2000SSA_AngioSeal.pdf', CAST(N'2017-07-25T10:26:22.960' AS DateTime), CAST(N'2017-07-25T10:26:21.567' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (37, N'Registro', N'0653C2013', N'133300C1080417', N'MEDTRONIC, S. DE R.L. DE C.V.', N'MED 730308 NF0', N'Resolute integritu rx', N'Sistema de stent coronario', N'MEDTRONIC IRELAND', N'MEDTRONIC ', 3, CAST(N'2013-05-27T00:00:00.000' AS DateTime), CAST(N'2018-03-15T00:00:00.000' AS DateTime), N'NR - Resolute Integrity 0653C2013SSA - 27May13.pdf', CAST(N'2017-07-31T11:00:38.293' AS DateTime), CAST(N'2017-07-31T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (38, N'Registro', N'0483C2013', N'123300401E0679', N'Boston Scientific de México, S.A. de C.V.', N'BSM961107QV7', N'Sistema para oclusiones totales crónicas boston scientific', N'Alambre guía', N'Boston Scientific Cork, Ud.', N'Boston Scientific', 3, CAST(N'2013-03-01T00:00:00.000' AS DateTime), CAST(N'2018-03-01T00:00:00.000' AS DateTime), N'BOSTON_0483C2013_ OTC TRUE PATH.pdf', CAST(N'2017-07-31T11:01:15.540' AS DateTime), CAST(N'2017-08-01T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (39, N'Registro', N'1388C2015', N'153300401M0309', N'Boston Scientlfic de Mexico, SA de C.V.', N'BSM961107 QV7', N'Sistema valvular lotus boston scientific', N'Prótesis de válvula aórtica transcatéter', N'BOSTON SCIENTIFIC LIMITED', N'BOSTON SCIENTIFIC', 1, CAST(N'2015-06-26T00:00:00.000' AS DateTime), CAST(N'2020-06-26T00:00:00.000' AS DateTime), N'BOSTON_1388C2015SSA_LOTUS.pdf', CAST(N'2017-07-31T11:11:35.533' AS DateTime), CAST(N'2017-08-02T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (40, N'Prórroga', N'00855E2000', N'153300421C0068', N'Boston Scientific de México, S.A. de C.V.', N'BSM961107 QV7', N'Catéter de diagnóstico boston scientific', N'Catéter para diagnóstico intravascular.', N'Availmed, S.A. de C.V.', N'Boston Scientific', 8, CAST(N'2015-06-25T00:00:00.000' AS DateTime), CAST(N'2020-06-25T00:00:00.000' AS DateTime), N'BOSTON_00855E2000SSA_IMPULSE.pdf', CAST(N'2017-07-31T11:19:38.033' AS DateTime), CAST(N'2017-08-01T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (41, N'Modificación', N'00863E2000', N'153300402M0507', N'Boston Scientific de México, SA de C.V.', N'BSM961107QV7', N'Accesorios para angioplastia boston scientific', N'Accesorios para angioplastia', N'Boston Scíéntific Limited', N'Boston Scíéntific Limited', 3, CAST(N'2015-04-15T00:00:00.000' AS DateTime), CAST(N'2020-04-15T00:00:00.000' AS DateTime), N'00863E2000SSA_BOSTON_ADVANTAGE.pdf', CAST(N'2017-08-02T10:59:46.050' AS DateTime), CAST(N'2017-08-03T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (42, N'Registro', N'00874E2000', N'153300CI080877', N'Boston Scientific de México, S.A. de CV', N'BSM 961107 QV7', N'Guias boston scientific', N'Al.ambres guias', N'Lake Region Medical Ud.', N'', 3, CAST(N'2015-08-19T00:00:00.000' AS DateTime), CAST(N'2020-08-06T00:00:00.000' AS DateTime), N'00874E2000SSA REOK.pdf', CAST(N'2017-08-02T11:21:37.250' AS DateTime), CAST(N'2017-08-03T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (43, N'Prórroga', N'2372C2009', N'143300421C1348', N'MEDTRONIC, S. DE R.L. DE C.V.', N'MED 730308 NF0', N'Sprinter legend rx', N'Cateter balon de dilatacion', N'MEDTRONIC MEXICO, S. DE R.L. DE C.V.', N'MEDTRONIC', 8, CAST(N'2015-03-17T00:00:00.000' AS DateTime), CAST(N'2020-03-12T00:00:00.000' AS DateTime), N'MEDTRONIC_2372C2009SSA_SPRINTER LEGEND RX.pdf', CAST(N'2017-08-03T12:05:06.767' AS DateTime), CAST(N'2017-08-15T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (44, N'Prórroga', N'00934C2000', N'153300421C1886', N'BoSTON SCIENTIFIC DE MEXICO, S.A. DE C.V.', N'BSM961107QV7', N'Cateter balon para  angioplastia boston scientific', N'Cateter balon para  angioplastia transluminal percutanea', N'BOSTON SCIENTIFIC LIMITED', N'BOSTON SCIENTIFIC', 3, CAST(N'2016-05-23T00:00:00.000' AS DateTime), CAST(N'2021-05-23T00:00:00.000' AS DateTime), N'00934C2000_BOSTON_XXL.pdf', CAST(N'2017-08-03T12:09:11.447' AS DateTime), CAST(N'2017-08-04T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (45, N'Prórroga', N'0660E95', N'153300421C1400', N'MEDTRONIC, S. DE R.L. DE C.V.', N'MED730308NF0', N'Sistema para el monitoreo de la hemostasis en cirugia de cardiovascular medtronic', N'Sistema para el monitoreo de la hemostasis ', N'MEDTRONIC PERFUSION SYSTEMS', N'MEDTRONIC ', 1, CAST(N'2016-02-02T00:00:00.000' AS DateTime), CAST(N'2021-02-02T00:00:00.000' AS DateTime), N'RW - Sist de Hemostasis 0660E95SSA REF ok.pdf', CAST(N'2017-08-03T13:36:54.267' AS DateTime), CAST(N'2017-08-03T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (46, N'Registro', N'2706C2012', N'123300C1081363', N'MEDTRONIC, S. DE R.L. DE C.V.', N'MED730308NF0', N'Corevalve® system', N'Prótesis de válvula aórtica-biólogica', N'MEDTRONIC COREVALVE LLC', N'MEDTRONIC ', 1, CAST(N'2012-11-08T00:00:00.000' AS DateTime), CAST(N'2017-10-04T00:00:00.000' AS DateTime), N'MEDTRONIC_2706C2012SSA _COREVALVE.pdf', CAST(N'2017-08-03T15:25:29.100' AS DateTime), CAST(N'2017-08-03T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (47, N'Prórroga', N'0053E96', N'103300CT070438', N'CARDIO-NEF, S.A. DE C.V. ', N'CNE9104252S7', N'Cuerda guía de diagnóstico merit medical - cardio nef', N'Cuerda guía', N'MERIT MEDICAL SYSTEMS INC', N'MERIT', 1, CAST(N'2011-08-16T00:00:00.000' AS DateTime), CAST(N'2016-08-16T00:00:00.000' AS DateTime), N'MERIT_ 0053E96SSA_CUERDA GUIA.pdf', CAST(N'2017-08-03T16:40:35.940' AS DateTime), CAST(N'2017-08-03T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (48, N'Prórroga', N'1339E2002', N'113300CT082257', N'CEURAC, S.A. DE C.V.', N'CEU 980706GL7', N'Equipo termorregulador y accesorios', N'Equipo termorregulador', N'CINCINNATI SUB-ZERO PRODUCTS INC.', N'CINCINNATI', 1, CAST(N'2011-09-30T00:00:00.000' AS DateTime), CAST(N'2016-09-30T00:00:00.000' AS DateTime), N'1339E2002SSA_CEURAC .pdf', CAST(N'2017-08-04T10:15:05.450' AS DateTime), CAST(N'2017-08-04T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (49, N'Modificación', N'981C94', N'113300402A0619', N'SJ MEDICAL MEXICO, S. DE R.L. DE C.V.', N'SMM0809235UA', N'Catéteres introductores y accesorios', N'Catéter para introductor de catéteres cardiovasculares', N'ST.JUDE MEDICAL', N'ST.JUDE', 1, CAST(N'2012-10-05T00:00:00.000' AS DateTime), CAST(N'2016-05-25T00:00:00.000' AS DateTime), N'981C94SSA_ 25_05_2016INTRODUCTORES Y ACCS_ ST JUDE.pdf', CAST(N'2017-08-04T10:48:40.983' AS DateTime), CAST(N'2017-08-04T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (50, N'Prórroga', N'00991E2000', N'153300421C1785', N'BOSTON SCIENTIFIC DE MEXICO, S.A. DE C.V.', N'BSM 961107 QV7', N'Cateter de lnfusión boston sciéntific.', N'Cateter de lnfusión', N'BOSTON SCIENTIFIC LIMITED', N'BOSTON SCIENTIFIC', 3, CAST(N'2016-04-18T00:00:00.000' AS DateTime), CAST(N'2021-04-18T00:00:00.000' AS DateTime), N'00991E2000_BOSTON_RENEGADE.pdf', CAST(N'2017-08-04T11:41:32.763' AS DateTime), CAST(N'2017-08-05T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (51, N'Prórroga', N'01265C2000', N'113300CT082752', N'INSTRUMENTOS MEDICOS INTERNACIONALES S.A. DE C.V.', N'IMI790406618', N'Catéter para septostomía numed-imisa', N'Catéter para septostomía', N'NuMED CANADA, INC', N'NuMeD', 4, CAST(N'2012-04-26T00:00:00.000' AS DateTime), CAST(N'2017-04-26T00:00:00.000' AS DateTime), N'RS-Numed Cateter Septostomia  01265C2000SSA.pdf', CAST(N'2017-08-04T12:31:27.503' AS DateTime), CAST(N'2017-08-16T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (52, N'Prórroga', N'01266C2000', N'113300CT082751', N'INSTRUMENTOS MÉDICOS INTERNACIONALES, S.A DE C.V.', N'IMI790406618', N'Catéter para valvuloplastía numed imisa', N'Catéter para valvuloplastia', N'NuMED CANADA, INC', N'NuMED', 4, CAST(N'2012-05-02T00:00:00.000' AS DateTime), CAST(N'2017-05-02T00:00:00.000' AS DateTime), N'01266C2000SSA_NUMED_THYSHAK ZMED.pdf', CAST(N'2017-08-04T14:24:05.893' AS DateTime), CAST(N'2017-08-04T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (53, N'Modificación', N'01091C2000', N'153300402A0636', N'Boston Scientific de México, S.A. de C. V.', N'BSM961107QV7', N'Partículas para embolización contour boston scientific.', N'Dispositivo de embolización artificial.', N'Boston Scientific Limited.', N'Boston Scientific Limited.', 3, CAST(N'2015-07-06T00:00:00.000' AS DateTime), CAST(N'2020-07-06T00:00:00.000' AS DateTime), N'01091C2000SSA.pdf', CAST(N'2017-08-07T09:44:54.250' AS DateTime), CAST(N'2017-08-07T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (54, N'Prórroga', N'01405E2000', N'153300CI080995', N'Boston Scientific de México, S.A. de C.V.', N'BSM961107QV7', N'Cuerdas guía de uso endoscópico boston scientific', N'Cuerdas guía de uso endoscópico', N'Boston Scientific Corporation', N'Boston Scientific Corporation', 1, CAST(N'2015-07-06T00:00:00.000' AS DateTime), CAST(N'2020-07-06T00:00:00.000' AS DateTime), N'01405E2000_Prór_CI_11sep2015.pdf', CAST(N'2017-08-07T10:04:04.520' AS DateTime), CAST(N'2017-08-08T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (55, N'Registro', N'0448C2013', N'123300401F0382', N'Boston Scientific de México, S.A. de C.V.', N'BSM961107QV7', N'Sistema de catéter balón de posicionamiento para reintroducción boston
scientific', N'Sistema de catéter balón de posicionamiento', N'Boston Scientific lreland, ltd.', N'Boston Scientific', 3, CAST(N'2013-02-28T00:00:00.000' AS DateTime), CAST(N'2018-02-28T00:00:00.000' AS DateTime), N'0448C2013_OFF ROAD_28Feb2018.pdf', CAST(N'2017-08-07T10:34:52.173' AS DateTime), CAST(N'2017-08-08T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (56, N'Prórroga', N'00831E2000', N'153300421C0152', N'Boston Scientific de México, s.a. de c.v.', N'BSM 961107 qv7', N'Equipo de aterectomía rotacional y accesorios boston scientific', N'Equipo de aterectomía', N'Boston Scientific Corporation', N'Boston Scientific ', 1, CAST(N'2015-07-07T00:00:00.000' AS DateTime), CAST(N'2020-08-25T00:00:00.000' AS DateTime), N'00831E2000SSA.pdf', CAST(N'2017-08-07T12:21:45.043' AS DateTime), CAST(N'2017-08-15T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (57, N'Registro', N'1133C2014', N'143300CI080615', N'Boston Scientific de México, S.A. de C.V.', N'BSM 961107QV7', N'Sistema de deaervación renal vessix™ boston scientific', N'Sistema de denervacion renal', N'Vessix Vascular lnc.', N'Boston Scientific', 1, CAST(N'2014-05-26T00:00:00.000' AS DateTime), CAST(N'2019-05-26T00:00:00.000' AS DateTime), N'1133C2014SSA_BOSTON_VESSIX.pdf', CAST(N'2017-08-08T10:35:16.613' AS DateTime), CAST(N'2017-08-09T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (58, N'Prórroga', N'1295C2001', N'153300421C0071', N'Boston Scientific de México, S.A. de C.V.', N'BSM 961107 QV7', N'Stents grafts boston scientific', N'Stents perifericos', N'Boston Scientific Limited', N'Boston Scientific', 3, CAST(N'2015-07-06T00:00:00.000' AS DateTime), CAST(N'2020-08-02T00:00:00.000' AS DateTime), N'1295C2001_WALLGRAFT_28Abr2020.pdf', CAST(N'2017-08-08T11:20:59.857' AS DateTime), CAST(N'2017-08-09T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (59, N'Prórroga', N'1379C2005', N'153300421C0920', N'Boston Scientific de México, S.A. de C.V.', N'BSM961107QV7', N'Catéter balón de corte boston-scientífic modelo flextome cuttíng balloon', N'Catéter balón', N'Boston Scientific Limited', N'Boston Scientific Limited', 3, CAST(N'2015-07-09T00:00:00.000' AS DateTime), CAST(N'2020-12-22T00:00:00.000' AS DateTime), N'1379C2005SSA.pdf', CAST(N'2017-08-14T12:02:18.013' AS DateTime), CAST(N'2017-08-15T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (60, N'Prórroga', N'1638C2001', N'153300CI080862', N'Boston Scientific de México, S.A. de C.V.', N'BSM 961107 QV7', N'Sistema filter wire ex boston scientific', N'Sistema de protección embolica', N'Boston Scientific Corporation', N'Boston Scientific Corporation', 1, CAST(N'2015-08-03T00:00:00.000' AS DateTime), CAST(N'2020-07-05T00:00:00.000' AS DateTime), N'1638C2001SSA_Prórroga-2015 FILTER WIRE.pdf', CAST(N'2017-08-14T13:53:11.507' AS DateTime), CAST(N'2017-08-15T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (61, N'Registro', N'1796E2014', N'143300401E0137', N'Boston Scientific de México, S.A. de C.V.', N'BSM 961107 QV7', N'Catéter para toma de imágenes coronarias icrosstm boston scientific.', N'Catéter transductor de ultrasonido.', N'Boston Scientific Corporation', N'Boston Scientific Corporation', 1, CAST(N'2014-09-03T00:00:00.000' AS DateTime), CAST(N'2019-09-03T00:00:00.000' AS DateTime), N'1796E2014SSA OK.pdf', CAST(N'2017-08-14T14:08:09.843' AS DateTime), CAST(N'2017-08-15T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (62, N'Registro', N'2498C2012', N'123300CI081273', N'Boston Scientific de México, S.A. de C.V.', N'BSM 961107 QV7', N'Sistema de cierre de la órejuela auricular, watchman®', N'Oclusor cardíaco', N'Atritech, Inc. a Subsidiary of Boston Scientific Corp.', N'Boston Scientific', 1, CAST(N'2012-11-09T00:00:00.000' AS DateTime), CAST(N'2017-09-10T00:00:00.000' AS DateTime), N'2498C2012SSA_BOSTON_WATCHMAN.pdf', CAST(N'2017-08-14T14:48:56.133' AS DateTime), CAST(N'2017-08-15T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (63, N'Prórroga', N'0908E95', N'113300CT080896', N'Medtronic, S. de R.L. de C.V.', N'MED730308NF0', N'Sistema de ablacion cardiaca medtronic', N'Equipo para el diagnostico y tratamiento de padecimientos cardacos de tipo
arritmico.', N'Medtronic Inc.', N'Medtronic Inc.', 1, CAST(N'2012-08-20T00:00:00.000' AS DateTime), CAST(N'2017-08-20T00:00:00.000' AS DateTime), N'0908E95_MEDTRONIC_ABLACION.pdf', CAST(N'2017-08-14T17:30:28.670' AS DateTime), CAST(N'2017-08-15T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (64, N'Modificación', N'2243C2013', N'153300402M0586', N'Medtronic, S. de R.L. de C.V.', N'MED 730308 NFO', N'Catéter de crioablación cardiaca medtronic freezor ®.', N'Cateter de crioablación cardiaca', N'Medtronic Cryocath LP.', N'Medtronic', 4, CAST(N'2016-03-01T00:00:00.000' AS DateTime), CAST(N'2018-08-28T00:00:00.000' AS DateTime), N'TA - Freezor 2243C2013 SSA -01Mar16.pdf', CAST(N'2017-08-14T17:49:30.770' AS DateTime), CAST(N'2017-08-15T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (65, N'Modificación', N'2450E2013', N'153300402M0647', N'Medtronic, S. de R.L. de C.V.', N'MEO 730308 NF0', N'Sistema de crioablación medtronic', N'Sistema de crioablación', N'Plexus Corp.', N'Medtronic Cryocath LP.', 8, CAST(N'2016-03-18T00:00:00.000' AS DateTime), CAST(N'2018-10-03T00:00:00.000' AS DateTime), N'TA - Cryoconsole  2450E2013SSA -  18Mar16.pdf', CAST(N'2017-08-14T18:15:57.450' AS DateTime), CAST(N'2017-08-15T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (66, N'Prórroga', N'1084C91', N'163300421C0432', N'Aarow Internacional De Mexico, S.A. De C.V.', N'AIM 9307162M9', N'Catéteres cardiovasculares arrow', N'Catéteres cardiovasculares', N'Arrow lnternational, lnc.', N'Arrow lnternational, lnc.', 1, CAST(N'2017-04-03T00:00:00.000' AS DateTime), CAST(N'2021-08-05T00:00:00.000' AS DateTime), N'1084C91SSA ok.pdf', CAST(N'2017-08-15T18:06:28.773' AS DateTime), CAST(N'2017-08-16T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (67, N'Prórroga', N'0654C2008', N'123300421C0905', N'Aarow Internacional De Mexico, S.A. De C.V.', N'AIM 9307162M9', N'Catéteres de balón lntra-aórtico. Fiberoptix arrow', N'Catéter de balón lntra- aórtico', N'Arrow lnternational, lnc.', N'Arrow lnternational, lnc.', 1, CAST(N'2013-07-05T00:00:00.000' AS DateTime), CAST(N'2018-07-05T00:00:00.000' AS DateTime), N'0654C2008SSA_ ARROW_BALON INTRA AORTICO.pdf', CAST(N'2017-08-16T13:58:07.420' AS DateTime), CAST(N'2017-08-17T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (68, N'Registro', N'0236C2015', N'143300401M0616', N'MSM Salud, S.A. de C.V.', N'MSA 110126 UC4', N'Angio-line ™ catéteres de diagnóstico para angiografia', N'Catéteres de diagnóstico para angiografia', N'Biometrix Limited', N'Biometrix Limited', 8, CAST(N'2015-01-15T00:00:00.000' AS DateTime), CAST(N'2020-01-15T00:00:00.000' AS DateTime), N'0236C2015SSA.pdf', CAST(N'2017-08-16T17:14:50.547' AS DateTime), CAST(N'2017-08-17T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (69, N'Registro', N'0333C2015', N'143300401M0618', N'MSM Salud, S.A. de C.V', N'MSA 110126 UC4', N'Aspicath tm catéter de aspiración', N'Catéter para embolectomía', N'Bíometrix Limited', N'Bíometrix Limited', 6, CAST(N'2015-01-23T00:00:00.000' AS DateTime), CAST(N'2020-01-23T00:00:00.000' AS DateTime), N'0333C2015SSA.pdf', CAST(N'2017-08-16T18:03:00.683' AS DateTime), CAST(N'2017-08-17T00:00:00.000' AS DateTime))
INSERT [dbo].[registros_sanitarios] ([id_registro], [tipo], [numero_registro], [numero_solicitud], [titular], [rfc], [denom_distintiva], [denom_generica], [fabricante], [marca], [pais_origen], [fecha_emision], [fecha_vencimiento], [dir_archivo], [creado_en], [actualizado_en]) VALUES (70, N'Registro', N'2344C2014', N'143300CI081317', N'MSM Salud, S.A. de C.V.', N'MSA 110126 UC4', N'Angio-line tm guide wires.', N'Cables guía.', N'Biometrix Limited', N'Biometrix Limited.', 6, CAST(N'2013-11-14T00:00:00.000' AS DateTime), CAST(N'2019-11-13T00:00:00.000' AS DateTime), N'2344C2014SSA.pdf', CAST(N'2017-08-17T15:18:38.293' AS DateTime), CAST(N'2017-08-18T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[registros_sanitarios] OFF
ALTER TABLE [dbo].[aux_cat_trad_ref] ADD  CONSTRAINT [DF_aux_cat_trad_ref_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[aux_entidades_federativas] ADD  CONSTRAINT [DF_aux_entidades_federativas_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[aux_tipos_expediente] ADD  CONSTRAINT [DF_aux_tipos_expediente_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[aux_users] ADD  CONSTRAINT [DF_aux_users_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[catalogos_claves_referencias] ADD  CONSTRAINT [DF_catalogos_claves_referencias_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[catalogos_info_general] ADD  CONSTRAINT [DF_catalogos_info_general_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[catalogos_traducciones] ADD  CONSTRAINT [DF_Table_1_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[certificados_calidad] ADD  CONSTRAINT [DF_certificados_calidad_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[cucop_vinculos] ADD  CONSTRAINT [DF_cucop_vinculos_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[cucop_vinculos_catalogos] ADD  CONSTRAINT [DF_cucop_vinculos_catalogos_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[cucop_vinculos_catalogos_referencias] ADD  CONSTRAINT [DF_cucop_vinculos_catalogos_referencias_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[cucop_vinculos_certificados] ADD  CONSTRAINT [DF_cucop_vinculos_certificados_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[cucop_vinculos_registros] ADD  CONSTRAINT [DF_cucop_vinculos_registros_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[cucop_vinculos_registros_referencias] ADD  CONSTRAINT [DF_cucop_vinculos_registros_referencias_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[fabricantes_contactos] ADD  CONSTRAINT [DF_fabricantes_contactos_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[fabricantes_titulares_distribuidores] ADD  CONSTRAINT [DF_fabricantes_titulares_distribuidores_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[licitacion_bases] ADD  CONSTRAINT [DF_licitacion_bases_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[licitacion_calendario] ADD  CONSTRAINT [DF_licitacion_calendario_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[licitacion_items] ADD  CONSTRAINT [DF_licitacion_items_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[licitacion_vinculacion] ADD  CONSTRAINT [DF_licitacion_vinculacion_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[registros_claves_referencias] ADD  CONSTRAINT [DF_registros_claves_referencias_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[registros_sanitarios] ADD  CONSTRAINT [DF_registros_sanitarios_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[registros_tramites_prorroga] ADD  CONSTRAINT [DF_registros_tramites_prorroga_creado_en]  DEFAULT (getdate()) FOR [creado_en]
GO
ALTER TABLE [dbo].[aux_cat_trad_ref]  WITH CHECK ADD  CONSTRAINT [FK_aux_cat_trad_ref_catalogos_claves_referencias] FOREIGN KEY([id_referencia])
REFERENCES [dbo].[catalogos_claves_referencias] ([id_clave_catalogo])
GO
ALTER TABLE [dbo].[aux_cat_trad_ref] CHECK CONSTRAINT [FK_aux_cat_trad_ref_catalogos_claves_referencias]
GO
ALTER TABLE [dbo].[aux_cat_trad_ref]  WITH CHECK ADD  CONSTRAINT [FK_aux_cat_trad_ref_catalogos_traducciones] FOREIGN KEY([id_traduccion])
REFERENCES [dbo].[catalogos_traducciones] ([id_traduccion_cat])
GO
ALTER TABLE [dbo].[aux_cat_trad_ref] CHECK CONSTRAINT [FK_aux_cat_trad_ref_catalogos_traducciones]
GO
ALTER TABLE [dbo].[catalogos_claves_referencias]  WITH CHECK ADD  CONSTRAINT [FK_catalogos_claves_referencias_catalogos_info_general] FOREIGN KEY([id_catalogo_productos])
REFERENCES [dbo].[catalogos_info_general] ([id_catalogo])
GO
ALTER TABLE [dbo].[catalogos_claves_referencias] CHECK CONSTRAINT [FK_catalogos_claves_referencias_catalogos_info_general]
GO
ALTER TABLE [dbo].[catalogos_traducciones]  WITH CHECK ADD  CONSTRAINT [FK_catalogos_traducciones_catalogos_info_general] FOREIGN KEY([id_catalogo_productos])
REFERENCES [dbo].[catalogos_info_general] ([id_catalogo])
GO
ALTER TABLE [dbo].[catalogos_traducciones] CHECK CONSTRAINT [FK_catalogos_traducciones_catalogos_info_general]
GO
ALTER TABLE [dbo].[cucop_vinculos]  WITH CHECK ADD  CONSTRAINT [FK_cucop_vinculos_cucop] FOREIGN KEY([id_cucop_item])
REFERENCES [dbo].[cucop] ([id_cucop])
GO
ALTER TABLE [dbo].[cucop_vinculos] CHECK CONSTRAINT [FK_cucop_vinculos_cucop]
GO
ALTER TABLE [dbo].[cucop_vinculos_catalogos]  WITH CHECK ADD  CONSTRAINT [FK_cucop_vinculos_catalogos_catalogos_info_general] FOREIGN KEY([id_catalogo])
REFERENCES [dbo].[catalogos_info_general] ([id_catalogo])
GO
ALTER TABLE [dbo].[cucop_vinculos_catalogos] CHECK CONSTRAINT [FK_cucop_vinculos_catalogos_catalogos_info_general]
GO
ALTER TABLE [dbo].[cucop_vinculos_catalogos]  WITH CHECK ADD  CONSTRAINT [FK_cucop_vinculos_catalogos_cucop_vinculos] FOREIGN KEY([id_cucop_vinculo])
REFERENCES [dbo].[cucop_vinculos] ([id_vinculacion])
GO
ALTER TABLE [dbo].[cucop_vinculos_catalogos] CHECK CONSTRAINT [FK_cucop_vinculos_catalogos_cucop_vinculos]
GO
ALTER TABLE [dbo].[cucop_vinculos_catalogos_referencias]  WITH CHECK ADD  CONSTRAINT [FK_cucop_vinculos_catalogos_referencias_catalogos_claves_referencias] FOREIGN KEY([id_referencia])
REFERENCES [dbo].[catalogos_claves_referencias] ([id_clave_catalogo])
GO
ALTER TABLE [dbo].[cucop_vinculos_catalogos_referencias] CHECK CONSTRAINT [FK_cucop_vinculos_catalogos_referencias_catalogos_claves_referencias]
GO
ALTER TABLE [dbo].[cucop_vinculos_catalogos_referencias]  WITH CHECK ADD  CONSTRAINT [FK_cucop_vinculos_catalogos_referencias_cucop_vinculos_catalogos] FOREIGN KEY([id_vinculo_catalogo])
REFERENCES [dbo].[cucop_vinculos_catalogos] ([id])
GO
ALTER TABLE [dbo].[cucop_vinculos_catalogos_referencias] CHECK CONSTRAINT [FK_cucop_vinculos_catalogos_referencias_cucop_vinculos_catalogos]
GO
ALTER TABLE [dbo].[cucop_vinculos_certificados]  WITH CHECK ADD  CONSTRAINT [FK_cucop_vinculos_certificados_certificados_calidad] FOREIGN KEY([id_certificados])
REFERENCES [dbo].[certificados_calidad] ([id_certificado])
GO
ALTER TABLE [dbo].[cucop_vinculos_certificados] CHECK CONSTRAINT [FK_cucop_vinculos_certificados_certificados_calidad]
GO
ALTER TABLE [dbo].[cucop_vinculos_certificados]  WITH CHECK ADD  CONSTRAINT [FK_cucop_vinculos_certificados_cucop_vinculos] FOREIGN KEY([id_cucop_vinculo])
REFERENCES [dbo].[cucop_vinculos] ([id_vinculacion])
GO
ALTER TABLE [dbo].[cucop_vinculos_certificados] CHECK CONSTRAINT [FK_cucop_vinculos_certificados_cucop_vinculos]
GO
ALTER TABLE [dbo].[cucop_vinculos_registros]  WITH CHECK ADD  CONSTRAINT [FK_cucop_vinculos_registros_cucop_vinculos] FOREIGN KEY([id_cucop_vinculo])
REFERENCES [dbo].[cucop_vinculos] ([id_vinculacion])
GO
ALTER TABLE [dbo].[cucop_vinculos_registros] CHECK CONSTRAINT [FK_cucop_vinculos_registros_cucop_vinculos]
GO
ALTER TABLE [dbo].[cucop_vinculos_registros]  WITH CHECK ADD  CONSTRAINT [FK_cucop_vinculos_registros_registros_sanitarios] FOREIGN KEY([id_registro])
REFERENCES [dbo].[registros_sanitarios] ([id_registro])
GO
ALTER TABLE [dbo].[cucop_vinculos_registros] CHECK CONSTRAINT [FK_cucop_vinculos_registros_registros_sanitarios]
GO
ALTER TABLE [dbo].[cucop_vinculos_registros_referencias]  WITH CHECK ADD  CONSTRAINT [FK_cucop_vinculos_registros_referencias_cucop_vinculos_registros] FOREIGN KEY([id_vinculo_registro])
REFERENCES [dbo].[cucop_vinculos_registros] ([id])
GO
ALTER TABLE [dbo].[cucop_vinculos_registros_referencias] CHECK CONSTRAINT [FK_cucop_vinculos_registros_referencias_cucop_vinculos_registros]
GO
ALTER TABLE [dbo].[cucop_vinculos_registros_referencias]  WITH CHECK ADD  CONSTRAINT [FK_cucop_vinculos_registros_referencias_registros_claves_referencias] FOREIGN KEY([id_referencia])
REFERENCES [dbo].[registros_claves_referencias] ([id_clave_registro])
GO
ALTER TABLE [dbo].[cucop_vinculos_registros_referencias] CHECK CONSTRAINT [FK_cucop_vinculos_registros_referencias_registros_claves_referencias]
GO
ALTER TABLE [dbo].[fabricantes_contactos]  WITH CHECK ADD  CONSTRAINT [FK_fabricantes_contactos_fabricantes_titulares_distribuidores] FOREIGN KEY([id_ftd])
REFERENCES [dbo].[fabricantes_titulares_distribuidores] ([id_ftd])
GO
ALTER TABLE [dbo].[fabricantes_contactos] CHECK CONSTRAINT [FK_fabricantes_contactos_fabricantes_titulares_distribuidores]
GO
ALTER TABLE [dbo].[licitacion_bases]  WITH CHECK ADD  CONSTRAINT [FK_licitacion_bases_aux_entidades_federativas] FOREIGN KEY([entidad_federativa])
REFERENCES [dbo].[aux_entidades_federativas] ([id])
GO
ALTER TABLE [dbo].[licitacion_bases] CHECK CONSTRAINT [FK_licitacion_bases_aux_entidades_federativas]
GO
ALTER TABLE [dbo].[licitacion_bases]  WITH CHECK ADD  CONSTRAINT [FK_licitacion_bases_aux_tipos_expediente] FOREIGN KEY([tipo_expediente])
REFERENCES [dbo].[aux_tipos_expediente] ([id])
GO
ALTER TABLE [dbo].[licitacion_bases] CHECK CONSTRAINT [FK_licitacion_bases_aux_tipos_expediente]
GO
ALTER TABLE [dbo].[licitacion_calendario]  WITH CHECK ADD  CONSTRAINT [FK_licitacion_calendario_licitacion_bases] FOREIGN KEY([id_bases])
REFERENCES [dbo].[licitacion_bases] ([id_bases])
GO
ALTER TABLE [dbo].[licitacion_calendario] CHECK CONSTRAINT [FK_licitacion_calendario_licitacion_bases]
GO
ALTER TABLE [dbo].[licitacion_items]  WITH CHECK ADD  CONSTRAINT [FK_licitacion_items_licitacion_subpar_proce] FOREIGN KEY([id_paquete])
REFERENCES [dbo].[licitacion_subpar_proce] ([id])
GO
ALTER TABLE [dbo].[licitacion_items] CHECK CONSTRAINT [FK_licitacion_items_licitacion_subpar_proce]
GO
ALTER TABLE [dbo].[licitacion_items_info_Ad]  WITH CHECK ADD  CONSTRAINT [FK_licitacion_items_info_Ad_licitacion_subpar_proce] FOREIGN KEY([id_item])
REFERENCES [dbo].[licitacion_subpar_proce] ([id])
GO
ALTER TABLE [dbo].[licitacion_items_info_Ad] CHECK CONSTRAINT [FK_licitacion_items_info_Ad_licitacion_subpar_proce]
GO
ALTER TABLE [dbo].[licitacion_partidas]  WITH CHECK ADD  CONSTRAINT [FK_licitacion_partidas_licitacion_bases] FOREIGN KEY([id_bases])
REFERENCES [dbo].[licitacion_bases] ([id_bases])
GO
ALTER TABLE [dbo].[licitacion_partidas] CHECK CONSTRAINT [FK_licitacion_partidas_licitacion_bases]
GO
ALTER TABLE [dbo].[licitacion_preguntas]  WITH CHECK ADD  CONSTRAINT [FK_licitacion_preguntas_licitacion_vinculacion] FOREIGN KEY([id_vinc])
REFERENCES [dbo].[licitacion_vinculacion] ([id_vinculacion])
GO
ALTER TABLE [dbo].[licitacion_preguntas] CHECK CONSTRAINT [FK_licitacion_preguntas_licitacion_vinculacion]
GO
ALTER TABLE [dbo].[licitacion_subpar_proce]  WITH CHECK ADD  CONSTRAINT [FK_licitacion_subpar_proce_licitacion_partidas] FOREIGN KEY([id_partida])
REFERENCES [dbo].[licitacion_partidas] ([id])
GO
ALTER TABLE [dbo].[licitacion_subpar_proce] CHECK CONSTRAINT [FK_licitacion_subpar_proce_licitacion_partidas]
GO
ALTER TABLE [dbo].[licitacion_vinculacion]  WITH CHECK ADD  CONSTRAINT [FK_licitacion_vinculacion_cucop] FOREIGN KEY([id_cucop])
REFERENCES [dbo].[cucop] ([id_cucop])
GO
ALTER TABLE [dbo].[licitacion_vinculacion] CHECK CONSTRAINT [FK_licitacion_vinculacion_cucop]
GO
ALTER TABLE [dbo].[licitacion_vinculacion]  WITH CHECK ADD  CONSTRAINT [FK_licitacion_vinculacion_fabricantes_titulares_distribuidores] FOREIGN KEY([id_ftd])
REFERENCES [dbo].[fabricantes_titulares_distribuidores] ([id_ftd])
GO
ALTER TABLE [dbo].[licitacion_vinculacion] CHECK CONSTRAINT [FK_licitacion_vinculacion_fabricantes_titulares_distribuidores]
GO
ALTER TABLE [dbo].[licitacion_vinculacion]  WITH CHECK ADD  CONSTRAINT [FK_licitacion_vinculacion_licitacion_items] FOREIGN KEY([id_item])
REFERENCES [dbo].[licitacion_items] ([id_item])
GO
ALTER TABLE [dbo].[licitacion_vinculacion] CHECK CONSTRAINT [FK_licitacion_vinculacion_licitacion_items]
GO
ALTER TABLE [dbo].[registros_claves_referencias]  WITH CHECK ADD  CONSTRAINT [FK_registros_claves_referencias_registros_sanitarios] FOREIGN KEY([id_registro_sanitario])
REFERENCES [dbo].[registros_sanitarios] ([id_registro])
GO
ALTER TABLE [dbo].[registros_claves_referencias] CHECK CONSTRAINT [FK_registros_claves_referencias_registros_sanitarios]
GO
ALTER TABLE [dbo].[registros_sanitarios]  WITH CHECK ADD  CONSTRAINT [FK_registros_sanitarios_paises_origen] FOREIGN KEY([pais_origen])
REFERENCES [dbo].[paises_origen] ([id_pais])
GO
ALTER TABLE [dbo].[registros_sanitarios] CHECK CONSTRAINT [FK_registros_sanitarios_paises_origen]
GO
ALTER TABLE [dbo].[registros_tramites_prorroga]  WITH CHECK ADD  CONSTRAINT [FK_registros_tramites_prorroga_registros_sanitarios] FOREIGN KEY([id_registro_sanitario])
REFERENCES [dbo].[registros_sanitarios] ([id_registro])
GO
ALTER TABLE [dbo].[registros_tramites_prorroga] CHECK CONSTRAINT [FK_registros_tramites_prorroga_registros_sanitarios]
GO
/****** Object:  StoredProcedure [dbo].[licitaciones_bases_insert]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[licitaciones_bases_insert](
       @numero varchar(max),
	   @unidadComp varchar(max),
	   @entidadFed tinyint,
	   @espec varchar(max),
	   @duracion varchar(max),
	   @tipoContrat varchar(max), 
	   @estado tinyint,
	   @expediente varchar(max),
	   @tipoLic varchar(max),
	   @tipoExp varchar(max),
	   @nombre varchar(max),
	   @email varchar(max),
	   @descripcion varchar(max),
	   @archivo varchar(max),
	   @updated date)
AS 
BEGIN 
     SET NOCOUNT ON
	 IF NOT EXISTS (
			SELECT numero_licitacion,unidad_compradora,expediente 
			FROM licitacion_bases 
			WHERE numero_licitacion = @numero AND unidad_compradora = @unidadComp AND expediente = @expediente 
		  )
		  BEGIN
				INSERT INTO licitacion_bases
				  ( 
					[numero_licitacion],
					[unidad_compradora],
					[entidad_federativa],
					[especialidad],
					[duracion_contrato],
					[tipo_contratacion],
					[estado],
					[expediente],
					[tipo_licitacion],
					[tipo_expediente],
					[operador_nombre],
					[operador_correo],
					[descripcion],
					[dir_archivo],
					[actualizado_en]			          
				  ) 
			 OUTPUT inserted.id_bases
			 VALUES 
				  ( 
					@numero,
				    @unidadComp,
				    @entidadFed,
				    @espec,
				    @duracion,
				    @tipoContrat, 
				    @estado,
				    @expediente,
				    @tipoLic,
				    @tipoExp,
				    @nombre,
				    @email,
				    @descripcion,
				    @archivo,
				    @updated                 
				  )
		  END
	     	  
END 
GO
/****** Object:  StoredProcedure [dbo].[licitaciones_bases_update]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[licitaciones_bases_update](
	   @idBases int,
       @numero varchar(max),
	   @unidadComp varchar(max),
	   @entidadFed tinyint,
	   @espec varchar(max),
	   @duracion varchar(max),
	   @tipoContrat varchar(max), 
	   @estado tinyint,
	   @expediente varchar(max),
	   @tipoLic varchar(max),
	   @tipoExp varchar(max),
	   @nombre varchar(max),
	   @email varchar(max),
	   @descripcion varchar(max),
	   @archivo varchar(max),
	   @updated date)
AS 
BEGIN 
     SET NOCOUNT ON	 
		  BEGIN
				UPDATE licitacion_bases SET
				   
					[numero_licitacion] = @numero,
					[unidad_compradora] =  @unidadComp,
					[entidad_federativa] =  @entidadFed,
					[especialidad] = @espec,
					[duracion_contrato] = @duracion,
					[tipo_contratacion] = @tipoContrat,
					[estado] =  @estado,
					[expediente] = @expediente,
					[tipo_licitacion] = @tipoLic,
					[tipo_expediente] = @tipoExp,
					[operador_nombre] = @nombre,
					[operador_correo] = @email,
					[descripcion] = @descripcion,
					[dir_archivo] = @archivo,
					[actualizado_en] = @updated	
				WHERE id_bases = @idBases				  
		  END
	     	  
END 
GO
/****** Object:  StoredProcedure [dbo].[licitaciones_calendario_insert]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[licitaciones_calendario_insert](
				@idbases int,
				@junta date,
				@apertura date,
				@fallo date,
				@firma date,
				@visita date,
				@updated date,
				@publicacion date
	)
AS 
BEGIN 
     SET NOCOUNT ON
		  BEGIN
				INSERT INTO [licitacion_calendario]
				  ( 
						[id_bases],
						[fecha_junta_aclaraciones],
						[fecha_apertura],
						[fecha_fallo],
						[fecha_firma],
						[fecha_visita],
						[actualizado_en],
						[fecha_publicacion]
								          
				  ) 
			 OUTPUT inserted.id_bases
			 VALUES 
				  ( 
						@idbases,
					    @junta ,
						@apertura ,
						@fallo ,
						@firma ,
						@visita ,
						@updated ,
						@publicacion             
				  )
		  END
	     	  
END 
GO
/****** Object:  StoredProcedure [dbo].[licitaciones_calendario_update]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[licitaciones_calendario_update](
				@idCalendario int,
				@junta date,
				@apertura date,
				@fallo date,
				@firma date,
				@visita date,
				@updated date,
				@publicacion date
	)
AS 
BEGIN 
     SET NOCOUNT ON
		  BEGIN
				UPDATE [licitacion_calendario] SET 
			
						[fecha_junta_aclaraciones] =  @junta,
						[fecha_apertura] = @apertura,
						[fecha_fallo] = @fallo,
						[fecha_firma] = @firma,
						[fecha_visita] = @visita,
						[actualizado_en] = @updated,
						[fecha_publicacion] = @publicacion

					WHERE [id_calendario] = @idCalendario
						
						
		  END
	     	  
END 
GO
/****** Object:  StoredProcedure [dbo].[registros_insert]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[registros_insert](
       @tipo varchar(max),
	   @numero varchar(max),
	   @solicitud varchar(max),
	   @titular varchar(max),
	   @rfc varchar(max),
	   @distintiva varchar(max), 
	   @generica varchar(max),
	   @fabricante varchar(max),
	   @marca varchar(max),
	   @pais int,
	   @emision date,
	   @vencimiento date,
	   @archivo varchar(max),
	   @actualizado date)
AS 
BEGIN 
     SET NOCOUNT ON
	 IF NOT EXISTS (
			SELECT tipo,numero_registro,numero_solicitud 
			FROM registros_sanitarios 
			WHERE numero_registro = @numero OR numero_solicitud = @solicitud 
		  )
		  BEGIN
				INSERT INTO registros_sanitarios
				  ( 
					tipo,
					numero_registro,
					numero_solicitud,
					titular,
					rfc,
					denom_distintiva,
					denom_generica,
					fabricante,
					marca,
					pais_origen,
					fecha_emision,
					fecha_vencimiento,
					dir_archivo,
					actualizado_en			          
				  ) 
			 OUTPUT inserted.id_registro
			 VALUES 
				  ( 
					@tipo,
					@numero,
					@solicitud,
					@titular,
					@rfc,
					@distintiva,
					@generica,
					@fabricante,
					@marca,
					@pais,
					@emision,
					@vencimiento,
					@archivo,
					@actualizado                 
				  )
		  END
	     	  
END 

GO
/****** Object:  StoredProcedure [dbo].[registros_update]    Script Date: 18/08/2017 10:54:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[registros_update](
	   @id int,
       @tipo varchar(max),
	   @numero varchar(max),
	   @solicitud varchar(max),
	   @titular varchar(max),
	   @rfc varchar(max),
	   @distintiva varchar(max), 
	   @generica varchar(max),
	   @fabricante varchar(max),
	   @marca varchar(max),
	   @pais int,
	   @emision date,
	   @vencimiento date,
	   @archivo varchar(max),
	   @actualizado date)
AS 
BEGIN 
     SET NOCOUNT ON
	 
		  BEGIN
				UPDATE registros_sanitarios set
				  
					tipo = @tipo,
					numero_registro =@numero,
					numero_solicitud = @solicitud,
					titular = @titular,
					rfc = @rfc,
					denom_distintiva = @distintiva,
					denom_generica = @generica,
					fabricante = @fabricante,
					marca = @marca,
					pais_origen = @pais,
					fecha_emision = @emision,
					fecha_vencimiento = @vencimiento,
					dir_archivo = @archivo,
					actualizado_en = @actualizado   		          
				 WHERE id_registro = @id 
				 			  
		  END
	     	  
END 

GO
