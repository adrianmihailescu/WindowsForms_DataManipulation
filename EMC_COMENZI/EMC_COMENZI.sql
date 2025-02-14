/****** Object:  Schema [DBLOG]    Script Date: 06/17/2011 16:56:24 ******/
CREATE SCHEMA [DBLOG]
GO
/****** Object:  Schema [TPC]    Script Date: 06/17/2011 16:56:24 ******/
CREATE SCHEMA [TPC]
GO
/****** Object:  UserDefinedFunction [TPC].[fn_FormatTextFilterEx]    Script Date: 06/17/2011 16:56:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [TPC].[fn_FormatTextFilterEx] 
(
	@FILTRU NVARCHAR(MAX)
)
RETURNS NVARCHAR(MAX)
AS
BEGIN

	DECLARE @FILTRU_SQL NVARCHAR(MAX)

	SET @FILTRU = NULLIF(@FILTRU, '')
	
		IF @FILTRU IS NOT NULL
		BEGIN
			SET @FILTRU_SQL = UPPER(@FILTRU)
			IF CHARINDEX ( '*', @FILTRU_SQL, 1) > 0
				SET @FILTRU_SQL = REPLACE(@FILTRU_SQL, '*', '%')
			ELSE
				SET @FILTRU_SQL = '%' + @FILTRU_SQL + '%'
		END

	RETURN @FILTRU_SQL

END
GO
/****** Object:  UserDefinedFunction [TPC].[fn_FormatTextFilter]    Script Date: 06/17/2011 16:56:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [TPC].[fn_FormatTextFilter] 
(
	@COLOANA NVARCHAR(MAX),
	@FILTRU NVARCHAR(MAX)
)
RETURNS BIT
AS
BEGIN
	DECLARE @RETURN_VAL BIT
	DECLARE @FILTRU_SQL NVARCHAR(MAX)

	SET @RETURN_VAL = 0
	SET @FILTRU = NULLIF(@FILTRU, '')

	IF @COLOANA IS NULL 
		SET @RETURN_VAL = 1
	ELSE
	BEGIN
		if @FILTRU IS NULL
			SET @RETURN_VAL = 1
		ELSE
		BEGIN
			SET @FILTRU_SQL = UPPER(@FILTRU)
			IF CHARINDEX ( '*', @FILTRU_SQL, 1) > 0
				SET @FILTRU_SQL = REPLACE(@FILTRU_SQL, '*', '%')
			ELSE
				SET @FILTRU_SQL = '%' + @FILTRU_SQL + '%'

			IF  ISNULL(UPPER(@COLOANA), '') LIKE @FILTRU_SQL
				SET @RETURN_VAL = 1
			ELSE
				SET @RETURN_VAL = 0
		END
	END

	RETURN @RETURN_VAL

END
GO
/****** Object:  UserDefinedFunction [DBLOG].[fn_FormatErrorNumber]    Script Date: 06/17/2011 16:56:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [DBLOG].[fn_FormatErrorNumber]
(
)
RETURNS NVARCHAR(4000)
AS
BEGIN
	RETURN CASE ERROR_NUMBER()
		WHEN 50000
		THEN -ERROR_STATE()
		ELSE ERROR_NUMBER()
		END
END
GO
/****** Object:  UserDefinedFunction [DBLOG].[fn_FormatErrorMessage]    Script Date: 06/17/2011 16:56:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [DBLOG].[fn_FormatErrorMessage]
(
)
RETURNS NVARCHAR(4000)
AS
BEGIN
	RETURN 
		ISNULL(ERROR_PROCEDURE(), 'Unknown') + ':' + 
		CAST(ISNULL(ERROR_LINE(), -1) AS NVARCHAR) + ' - ' + 
		LEFT(ISNULL(ERROR_MESSAGE(), '-'), 3850)
END
GO
/****** Object:  Table [DBLOG].[ERROR_MESSAGES]    Script Date: 06/17/2011 16:56:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DBLOG].[ERROR_MESSAGES](
	[ID_ERROR_MESSAGE] [int] IDENTITY(1,1) NOT NULL,
	[MESSAGE_ERROR_CODE] [int] NOT NULL,
	[MESSAGE_DATE] [datetime] NOT NULL,
	[MESSAGE_TYPE] [nvarchar](4000) NOT NULL,
	[MESSAGE_TEXT] [nvarchar](4000) NOT NULL,
	[MESSAGE_USER_NAME] [nvarchar](256) NOT NULL,
	[MESSAGE_HOST_NAME] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_ERROR_MESSAGES] PRIMARY KEY CLUSTERED 
(
	[ID_ERROR_MESSAGE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTI]    Script Date: 06/17/2011 16:56:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLIENTI](
	[ID_CLIENT] [int] IDENTITY(1,1) NOT NULL,
	[COD_CLIENT] [varchar](1000) NOT NULL,
	[NUME] [varchar](1000) NOT NULL,
	[ADRESA] [varchar](1000) NOT NULL,
	[TELEFON] [varchar](100) NULL,
	[FAX] [varchar](100) NULL,
	[EMAIL] [varchar](1000) NULL,
	[FLAG_DEL] [bit] NULL,
 CONSTRAINT [PK_CLIENTI] PRIMARY KEY CLUSTERED 
(
	[ID_CLIENT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[backup_clienti_16062011]    Script Date: 06/17/2011 16:56:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[backup_clienti_16062011](
	[ID_CLIENT] [int] IDENTITY(1,1) NOT NULL,
	[COD_CLIENT] [varchar](1000) NOT NULL,
	[NUME] [varchar](1000) NOT NULL,
	[ADRESA] [varchar](1000) NOT NULL,
	[TELEFON] [varchar](100) NULL,
	[FAX] [varchar](100) NULL,
	[EMAIL] [varchar](1000) NULL,
	[FLAG_DEL] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [DBLOG].[SETTINGS]    Script Date: 06/17/2011 16:56:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DBLOG].[SETTINGS](
	[ID_SETTING] [int] NOT NULL,
	[DESCRIPTION] [nvarchar](256) NOT NULL,
	[VALUE_INT] [int] NULL,
 CONSTRAINT [PK_SETTINGS] PRIMARY KEY CLUSTERED 
(
	[ID_SETTING] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUSE]    Script Date: 06/17/2011 16:56:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUSE](
	[ID_PRODUS] [int] IDENTITY(1,1) NOT NULL,
	[COD_PRODUS] [varchar](100) NOT NULL,
	[DENUMIRE] [varchar](1000) NOT NULL,
	[UNITATE_MASURA] [varchar](100) NOT NULL,
	[PRET] [float] NOT NULL,
	[COD_BARE] [varchar](100) NULL,
	[FLAG_DEL] [bit] NULL,
 CONSTRAINT [PK_PRODUSE] PRIMARY KEY CLUSTERED 
(
	[ID_PRODUS] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [DBLOG].[fn_GetSettingValueInt]    Script Date: 06/17/2011 16:56:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [DBLOG].[fn_GetSettingValueInt]
(
	@ID_SETTING INT,
	@DEFAULT_VALUE INT
)
RETURNS INT AS
BEGIN
	RETURN ISNULL((SELECT VALUE_INT FROM DBLOG.SETTINGS WHERE ID_SETTING = @ID_SETTING), @DEFAULT_VALUE)
END
GO
/****** Object:  Table [dbo].[COMENZI]    Script Date: 06/17/2011 16:56:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMENZI](
	[ID_COMANDA] [int] IDENTITY(1,1) NOT NULL,
	[ID_CLIENT] [int] NOT NULL,
	[DATA_COMANDA] [datetime] NOT NULL,
	[DATA_LIVRARE] [datetime] NOT NULL,
 CONSTRAINT [PK_COMENZI] PRIMARY KEY CLUSTERED 
(
	[ID_COMANDA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMENZI_DETALIU]    Script Date: 06/17/2011 16:56:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMENZI_DETALIU](
	[ID_DETALIU_COMANDA] [int] IDENTITY(1,1) NOT NULL,
	[ID_COMANDA] [int] NOT NULL,
	[ID_PRODUS] [int] NOT NULL,
	[CANTITATE] [float] NOT NULL,
	[FLAG_DEL] [bit] NULL,
 CONSTRAINT [PK_COMENZI_DETALIU] PRIMARY KEY CLUSTERED 
(
	[ID_DETALIU_COMANDA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [DBLOG].[sp_SaveErrorMessage]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DBLOG].[sp_SaveErrorMessage]
	@ERC INT,
	@MESSAGE NVARCHAR(4000),
	@CURRENT_DATE DATETIME = NULL
AS

	-- Variabile locale
	DECLARE @MESSAGE_DATE DATETIME
	DECLARE @MESSAGE_TYPE NVARCHAR(4000)
	DECLARE @MESSAGE_TEXT NVARCHAR(4000)	
	DECLARE @MESSAGE_USER_NAME NVARCHAR(256)
	DECLARE @MESSAGE_HOST_NAME NVARCHAR(256)
	DECLARE @SEPARATOR NVARCHAR(10)
	DECLARE @SEPARATOR_POSITION INT
	DECLARE @MEPT_SETTING_ID INT
	DECLARE @MPT_COUNT INT
		
	-- Initializari
	SET @MEPT_SETTING_ID = 1
	SET @MESSAGE_DATE = ISNULL(@CURRENT_DATE, GETDATE())
	SET @MESSAGE_USER_NAME = LEFT(USER_NAME(), 256)
	SET @MESSAGE_HOST_NAME = LEFT(HOST_NAME(), 256)
	
	BEGIN TRY
		-- Verific parametrii primiti
		IF @ERC IS NULL
			RAISERROR ('Parameter @ERC cannot be null', 11, 1)
		
		IF @MESSAGE IS NULL
			RAISERROR ('Parameter @MESSAGE cannot be null', 11, 2)
	
		-- Presupunand ca @MESSAGE a fost initializat de functia
		-- DBLOG.fn_FormatErrorMessage, acesta are formatul: "PROCEDURA:LINIE - MESAJ"
		SET @SEPARATOR = N' - '
		SET @SEPARATOR_POSITION = CHARINDEX(@SEPARATOR, @MESSAGE, 1)
		SET @MESSAGE_TYPE = LEFT(@MESSAGE, @SEPARATOR_POSITION - 1)
		SET @MESSAGE_TEXT = @MESSAGE
		
		-- Extrag numarul maxim de erori pe tip
		SELECT
			@MPT_COUNT = COUNT(ID_ERROR_MESSAGE)
		FROM
			DBLOG.ERROR_MESSAGES
		WHERE
			MESSAGE_TYPE = @MESSAGE_TYPE
		
		-- Verific daca acesta depaseste numarul maxim configurat
		IF @MPT_COUNT < DBLOG.fn_GetSettingValueInt(@MEPT_SETTING_ID, 10)
		BEGIN
			-- Adaug un mesaj nou
			INSERT
				DBLOG.ERROR_MESSAGES
				(
					MESSAGE_ERROR_CODE,
					MESSAGE_DATE,
					MESSAGE_TYPE,
					MESSAGE_TEXT,
					MESSAGE_USER_NAME,
					MESSAGE_HOST_NAME
				)
			SELECT
				@ERC,
				@MESSAGE_DATE,
				@MESSAGE_TYPE,
				@MESSAGE_TEXT,
				@MESSAGE_USER_NAME,
				@MESSAGE_HOST_NAME
		END
			ELSE
		BEGIN
			-- Actualizez mesajul cel mai vechi de acest tip
			UPDATE
				DBLOG.ERROR_MESSAGES
			SET
				MESSAGE_ERROR_CODE = @ERC,
				MESSAGE_DATE = @MESSAGE_DATE,
				MESSAGE_TYPE = @MESSAGE_TYPE,
				MESSAGE_TEXT = @MESSAGE_TEXT,
				MESSAGE_USER_NAME = @MESSAGE_USER_NAME,
				MESSAGE_HOST_NAME = @MESSAGE_HOST_NAME
			WHERE
				ID_ERROR_MESSAGE = 
				(
					SELECT
					TOP 1
						ID_ERROR_MESSAGE
					FROM
						DBLOG.ERROR_MESSAGES
					WHERE
						MESSAGE_TYPE = @MESSAGE_TYPE
					ORDER BY
						MESSAGE_DATE ASC
				)
		END	
	END TRY
	BEGIN CATCH
		-- Ignor eroarea
		SET @ERC = @ERC
	END CATCH
GO
/****** Object:  StoredProcedure [DBLOG].[sp_SaveSetting]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DBLOG].[sp_SaveSetting]
	@ERC INT OUT,
	@MESSAGE NVARCHAR(4000) OUT,
	@ID_SETTING INT,
	@DESCRIPTION NVARCHAR(256),
	@VALUE_INT INT
AS

	-- Variabile locale
	DECLARE @LOCAL_TRAN BIT
	
	-- Initializari
	SET @ERC = 0
	SET @MESSAGE = ''
	SET @LOCAL_TRAN = 0

	-- Bloc tranzactie
	BEGIN TRY
		-- Daca nu exista inca o tranzactie, o deschid acum
		IF @@TRANCOUNT = 0
		BEGIN
			SET @LOCAL_TRAN = 1
			BEGIN TRAN
		END

		-- Actualizez linia existenta
		-- Daca @DESCRIPTION nu este completat, pastrez descrierea veche
		-- Acest lucru este util atunci cand se doreste modificarea doar a valorii
		UPDATE
			DBLOG.SETTINGS
		SET
			DESCRIPTION = ISNULL(@DESCRIPTION, DESCRIPTION),
			VALUE_INT = @VALUE_INT
		WHERE
			ID_SETTING = @ID_SETTING

		-- Daca nu am gasit linia, o inserez
		IF @@ROWCOUNT = 0
		BEGIN
			INSERT
				DBLOG.SETTINGS
				(
					ID_SETTING,
					DESCRIPTION,
					VALUE_INT
				)
			SELECT
				@ID_SETTING,
				@DESCRIPTION,
				@VALUE_INT
		END
	
		-- Inchid tranzactia
		IF @LOCAL_TRAN = 1
			COMMIT TRAN
	END TRY
	BEGIN CATCH
		-- Salvez eroarea in parametrii de iesire
		SET @ERC = DBLOG.fn_FormatErrorNumber()
		SET @MESSAGE = DBLOG.fn_FormatErrorMessage()
		
		-- Inchid tranzactia si loghez mesajul de eroare
		IF @LOCAL_TRAN = 1
		BEGIN
			ROLLBACK TRAN
			EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
		END
	END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_Produse_Update]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Produse_Update]
	(
	@ERC INT OUT, 
	@MESSAGE NVARCHAR(4000) OUT,
	@COD_PRODUS VARCHAR(1000),
	@DENUMIRE VARCHAR(1000),
	@UNITATE_MASURA VARCHAR(100),
	@PRET FLOAT,
	@COD_BARE VARCHAR(100)
	)
AS  

-- Variabile locale
DECLARE @LOCAL_TRAN BIT

-- Initializari
SET @ERC = 0
SET @MESSAGE = ''
SET @LOCAL_TRAN = 0

-- SET @NUME = TPC.fn_FormatTextFilterEx(@NUME)

-- Bloc tranzactie
BEGIN TRY
	-- Daca nu exista inca o tranzactie, o deschid acum
	IF @@TRANCOUNT = 0
	BEGIN
		SET @LOCAL_TRAN = 1
		BEGIN TRAN
	END

	
	IF @COD_PRODUS IS NULL OR @COD_PRODUS = ''
			RAISERROR('Completati codul produsului !', 11, 1)
			
		IF @DENUMIRE IS NULL OR @DENUMIRE = ''
			RAISERROR('Completati denumirea produsului !', 11, 1)
			
		IF @UNITATE_MASURA IS NULL OR @UNITATE_MASURA = ''
			RAISERROR('Completati unitatea de masura a produsului !', 11, 1)
			
		IF @PRET IS NULL OR @PRET = ''
			RAISERROR('Completati pretul produsului !', 11, 1)
			
		IF LEN(@DENUMIRE) > 1000
			RAISERROR('Introduceti Denumire cu lungimea < 1000 caractere !', 11, 1)
		
		IF LEN(@UNITATE_MASURA) > 100
			RAISERROR('Introduceti Unitate Masura cu lungimea < 100 caractere !', 11, 1)
			
		IF LEN(@COD_BARE) > 100
			RAISERROR('Introduceti Cod Bare cu lungimea < 100 caractere !', 11, 1)
		
		if (ISNUMERIC(@PRET) = 0)
			RAISERROR('Completati o valoare numerica pentru pretul produsului !', 11, 1)

		-- inserare in tasks
		UPDATE PRODUSE
		SET
		
		-- PE COD PRODUS NU SE FACE UPDATE
		  [DENUMIRE] = @DENUMIRE,
		  [UNITATE_MASURA] = @UNITATE_MASURA,
		  [PRET] = @PRET,
		  [COD_BARE] = @COD_BARE
		 
		 WHERE COD_PRODUS = @COD_PRODUS
			
		IF @@ROWCOUNT = 0
			RAISERROR('Eroare de modificare a produsului !', 11, 1)
		
	-- Inchid tranzactia
	IF @LOCAL_TRAN = 1
		COMMIT TRAN
END TRY
BEGIN CATCH
	-- Salvez eroarea in parametrii de iesire
	SET @ERC = DBLOG.fn_FormatErrorNumber()
	SET @MESSAGE = DBLOG.fn_FormatErrorMessage()

	-- Inchid tranzactia si loghez mesajul de eroare
	IF @LOCAL_TRAN = 1
	BEGIN
		ROLLBACK TRAN
		EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
	END
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_Produse_Select]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Produse_Select]
	(
	@ERC INT OUT, 
	@MESSAGE NVARCHAR(4000) OUT,
	@COD_PRODUS VARCHAR(1000) = null,
	@DENUMIRE VARCHAR(1000) = null,
	@UNITATE_MASURA VARCHAR(100) = null,
	@PRET FLOAT = null,
	@COD_BARE VARCHAR(100) = null
	)
AS  
-- Variabile locale
DECLARE @LOCAL_TRAN BIT

-- Initializari
SET @ERC = 0
SET @MESSAGE = ''
SET @LOCAL_TRAN = 0

-- SET @NUME = TPC.fn_FormatTextFilterEx(@NUME)

-- Bloc tranzactie
BEGIN TRY
	-- Daca nu exista inca o tranzactie, o deschid acum
	IF @@TRANCOUNT = 0
	BEGIN
		SET @LOCAL_TRAN = 1
		BEGIN TRAN
	END

	SELECT
		[ID_PRODUS],
		  [COD_PRODUS],
		  [DENUMIRE],
		  [UNITATE_MASURA],
		  [PRET],
		  [COD_BARE],
		  [FLAG_DEL]
	FROM
		PRODUSE P
	WHERE
		(@COD_PRODUS IS NULL OR P.COD_PRODUS LIKE replace(@COD_PRODUS, '*', '%')) AND
		(@DENUMIRE IS NULL OR P.DENUMIRE LIKE replace(@DENUMIRE, '*', '%')) AND
		(@UNITATE_MASURA IS NULL OR P.UNITATE_MASURA LIKE replace(@UNITATE_MASURA, '*', '%')) AND
		(@PRET IS NULL OR P.PRET LIKE @PRET OR @PRET = 0) AND
		(@COD_BARE IS NULL OR P.COD_BARE LIKE replace(@COD_BARE, '*', '%')) AND
		(isnull(P.FLAG_DEL, 0) = 0)
		
	ORDER BY ID_PRODUS DESC
		
		
	-- Inchid tranzactia
	IF @LOCAL_TRAN = 1
		COMMIT TRAN
END TRY
BEGIN CATCH
	-- Salvez eroarea in parametrii de iesire
	SET @ERC = DBLOG.fn_FormatErrorNumber()
	SET @MESSAGE = DBLOG.fn_FormatErrorMessage()

	-- Inchid tranzactia si loghez mesajul de eroare
	IF @LOCAL_TRAN = 1
	BEGIN
		ROLLBACK TRAN
		EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
	END
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_Produse_Insert]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Produse_Insert]
	(
	@ERC INT OUT, 
	@MESSAGE NVARCHAR(4000) OUT,
	@COD_PRODUS VARCHAR(1000),
	@DENUMIRE VARCHAR(1000),
	@UNITATE_MASURA VARCHAR(100),
	@PRET FLOAT,
	@COD_BARE VARCHAR(100)
	)
AS  

-- Variabile locale
DECLARE @LOCAL_TRAN BIT

-- Initializari
SET @ERC = 0
SET @MESSAGE = ''
SET @LOCAL_TRAN = 0

-- SET @NUME = TPC.fn_FormatTextFilterEx(@NUME)

-- Bloc tranzactie
BEGIN TRY
	-- Daca nu exista inca o tranzactie, o deschid acum
	IF @@TRANCOUNT = 0
	BEGIN
		SET @LOCAL_TRAN = 1
		BEGIN TRAN
	END

	IF EXISTS(SELECT COD_PRODUS FROM PRODUSE WHERE COD_PRODUS = @COD_PRODUS AND isnull(FLAG_DEL, 0) = 0)
			RAISERROR('Codul de produs introdus exista deja !', 11, 1)
	
	IF @COD_PRODUS IS NULL OR @COD_PRODUS = ''
			RAISERROR('Completati codul produsului !', 11, 1)
			
		IF @DENUMIRE IS NULL OR @DENUMIRE = ''
			RAISERROR('Completati denumirea produsului !', 11, 1)
			
		IF @UNITATE_MASURA IS NULL OR @UNITATE_MASURA = ''
			RAISERROR('Completati unitatea de masura a produsului !', 11, 1)
			
		IF @PRET IS NULL OR @PRET = ''
			RAISERROR('Completati pretul produsului !', 11, 1)
			
		IF LEN(@DENUMIRE) > 1000
			RAISERROR('Introduceti Denumire cu lungimea < 1000 caractere !', 11, 1)
		
		IF LEN(@UNITATE_MASURA) > 100
			RAISERROR('Introduceti Unitate Masura cu lungimea < 100 caractere !', 11, 1)
			
		IF LEN(@COD_BARE) > 100
			RAISERROR('Introduceti Cod Bare cu lungimea < 100 caractere !', 11, 1)
		
		if (ISNUMERIC(@PRET) = 0)
			RAISERROR('Completati o valoare numerica pentru pretul produsului !', 11, 1)

		IF EXISTS(
		SELECT
			COD_PRODUS
		FROM PRODUSE
		WHERE
		COD_PRODUS = @COD_PRODUS AND
		isnull(FLAG_DEL, 0) = 1
		)
		-- DACA EXISTA DEJA UN PRODUS STERS CU ACELASI ID, IL UPDATEZ
		BEGIN
			UPDATE PRODUSE
			SET
			FLAG_DEL = 0,
			COD_PRODUS = @COD_PRODUS,
			  DENUMIRE = @DENUMIRE,
			  UNITATE_MASURA = @UNITATE_MASURA,
			  PRET = @PRET
			WHERE 
			COD_PRODUS = @COD_PRODUS AND
			isnull(FLAG_DEL, 0) = 1
		END

		ELSE
		BEGIN
			-- IL INSEREZ DACA NU EXISTA
			INSERT INTO PRODUSE
			(
				[COD_PRODUS],
			  [DENUMIRE],
			  [UNITATE_MASURA],
			  [PRET],
			  [COD_BARE],
			  [FLAG_DEL]
		   )
			
			VALUES
			(
				@COD_PRODUS,
			  @DENUMIRE,
			  @UNITATE_MASURA,
			  @PRET,
			  @COD_BARE,
			  0 -- [FLAG_DEL]
			  )
		END
			
		IF @@ROWCOUNT = 0
			RAISERROR('Eroare de adaugare a produsului !', 11, 1)
		
	-- Inchid tranzactia
	IF @LOCAL_TRAN = 1
		COMMIT TRAN
END TRY
BEGIN CATCH
	-- Salvez eroarea in parametrii de iesire
	SET @ERC = DBLOG.fn_FormatErrorNumber()
	SET @MESSAGE = DBLOG.fn_FormatErrorMessage()

	-- Inchid tranzactia si loghez mesajul de eroare
	IF @LOCAL_TRAN = 1
	BEGIN
		ROLLBACK TRAN
		EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
	END
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_Produse_Delete]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Produse_Delete]
	(
	@ERC INT OUT, 
	@MESSAGE NVARCHAR(4000) OUT,
	@ID_PRODUS int
	)
AS  

-- Variabile locale
DECLARE @LOCAL_TRAN BIT

-- Initializari
SET @ERC = 0
SET @MESSAGE = ''
SET @LOCAL_TRAN = 0

-- SET @NUME = TPC.fn_FormatTextFilterEx(@NUME)

-- Bloc tranzactie
BEGIN TRY
	-- Daca nu exista inca o tranzactie, o deschid acum
	IF @@TRANCOUNT = 0
	BEGIN
		SET @LOCAL_TRAN = 1
		BEGIN TRAN
	END

	UPDATE PRODUSE
	SET
	FLAG_DEL = 1
	WHERE ID_PRODUS = @ID_PRODUS
		
	-- Inchid tranzactia
	IF @LOCAL_TRAN = 1
		COMMIT TRAN
END TRY
BEGIN CATCH
	-- Salvez eroarea in parametrii de iesire
	SET @ERC = DBLOG.fn_FormatErrorNumber()
	SET @MESSAGE = DBLOG.fn_FormatErrorMessage()

	-- Inchid tranzactia si loghez mesajul de eroare
	IF @LOCAL_TRAN = 1
	BEGIN
		ROLLBACK TRAN
		EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
	END
END CATCH
GO
/****** Object:  StoredProcedure [DBLOG].[sp_DeleteErrorMessages]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DBLOG].[sp_DeleteErrorMessages]
	@ERC INT OUT,
	@MESSAGE NVARCHAR(4000) OUT,
	@DELETE_ALL BIT = 0,
	@DELETE_DAY_COUNT INT = NULL,
	@DELETE_MESSAGE_TYPE NVARCHAR(4000) = NULL	
AS
	-- Variabile locale
	DECLARE @LOCAL_TRAN BIT
	DECLARE @CURRENT_DATE DATETIME
	
	-- Initializari
	SET @ERC = 0
	SET @MESSAGE = ''
	SET @LOCAL_TRAN = 0
	SET @CURRENT_DATE = GETDATE()

	-- Bloc tranzactie
	BEGIN TRY
		-- Daca nu exista inca o tranzactie, o deschid acum
		IF @@TRANCOUNT = 0
		BEGIN
			SET @LOCAL_TRAN = 1
			BEGIN TRAN
		END
		
		DELETE
			DBLOG.ERROR_MESSAGES
		WHERE
			(
				@DELETE_ALL = 1
			)
			OR 
			(
				(@DELETE_DAY_COUNT IS NOT NULL)
				AND DATEDIFF(DAY, MESSAGE_DATE, @CURRENT_DATE) >= @DELETE_DAY_COUNT
			)
			OR
			(
				(@DELETE_MESSAGE_TYPE IS NOT NULL)
				AND MESSAGE_TYPE = @DELETE_MESSAGE_TYPE
			)
	
		-- Inchid tranzactia
		IF @LOCAL_TRAN = 1
			COMMIT TRAN
	END TRY
	BEGIN CATCH
		-- Salvez eroarea in parametrii de iesire
		SET @ERC = DBLOG.fn_FormatErrorNumber()
		SET @MESSAGE = DBLOG.fn_FormatErrorMessage()
		
		-- Inchid tranzactia si loghez mesajul de eroare
		IF @LOCAL_TRAN = 1
		BEGIN
			ROLLBACK TRAN
			EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
		END
	END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_ComenziDetaliu_Update]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ComenziDetaliu_Update]
	(
	@ERC INT OUT, 
	@MESSAGE NVARCHAR(4000) OUT,
	@ID_DETALIU_COMANDA INT,
	@CANTITATE FLOAT
	)
AS  

-- Variabile locale
DECLARE @LOCAL_TRAN BIT

-- Initializari
SET @ERC = 0
SET @MESSAGE = ''
SET @LOCAL_TRAN = 0

-- SET @NUME = TPC.fn_FormatTextFilterEx(@NUME)

-- Bloc tranzactie
BEGIN TRY
	-- Daca nu exista inca o tranzactie, o deschid acum
	IF @@TRANCOUNT = 0
	BEGIN
		SET @LOCAL_TRAN = 1
		BEGIN TRAN
	END
	
	IF @CANTITATE IS NULL OR @CANTITATE = '' OR @CANTITATE = 0
			RAISERROR('Completati cantitatea comandata din produs !', 11, 1)
			
	IF ISNUMERIC(@CANTITATE) = 0
		RAISERROR('Introduceti o valoare numerica pentru cantitate !', 11, 1)

		-- inserare in tasks
		UPDATE COMENZI_DETALIU
		SET
		  [CANTITATE] = @CANTITATE
		 
		 WHERE ID_DETALIU_COMANDA = @ID_DETALIU_COMANDA
			
		IF @@ROWCOUNT = 0
			RAISERROR('Eroare de modificare a clientului!', 11, 1)
		
	-- Inchid tranzactia
	IF @LOCAL_TRAN = 1
		COMMIT TRAN
END TRY
BEGIN CATCH
	-- Salvez eroarea in parametrii de iesire
	SET @ERC = DBLOG.fn_FormatErrorNumber()
	SET @MESSAGE = DBLOG.fn_FormatErrorMessage()

	-- Inchid tranzactia si loghez mesajul de eroare
	IF @LOCAL_TRAN = 1
	BEGIN
		ROLLBACK TRAN
		EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
	END
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_ComenziDetaliu_Select]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ComenziDetaliu_Select]
	(
	@ERC INT OUT, 
	@MESSAGE NVARCHAR(4000) OUT,
	@ID_COMANDA bigint
	)
AS  
 
-- Variabile locale
DECLARE @LOCAL_TRAN BIT

-- Initializari
SET @ERC = 0
SET @MESSAGE = ''
SET @LOCAL_TRAN = 0

-- SET @NUME = TPC.fn_FormatTextFilterEx(@NUME)

-- Bloc tranzactie
BEGIN TRY
	-- Daca nu exista inca o tranzactie, o deschid acum
	IF @@TRANCOUNT = 0
	BEGIN
		SET @LOCAL_TRAN = 1
		BEGIN TRAN
	END

	SELECT

	CD.[ID_DETALIU_COMANDA],
      CD.[ID_COMANDA],
      CD.[ID_PRODUS],
      P.COD_PRODUS,
      P.DENUMIRE,
      CD.[CANTITATE],
      CD.[FLAG_DEL]/*,
      C.DATA_COMANDA,
      REPLACE(C.DATA_LIVRARE, '', NULL) DATA_LIVRARE
      */
	
	FROM
		COMENZI C
	
	INNER JOIN
		COMENZI_DETALIU CD
	ON C.ID_COMANDA = CD.ID_COMANDA
	
	INNER JOIN
		PRODUSE P
	ON CD.ID_PRODUS = P.ID_PRODUS
		
	WHERE
		(@ID_COMANDA IS NULL OR C.ID_COMANDA = @ID_COMANDA) AND
		(isnull(CD.FLAG_DEL, 0) = 0)
		AND (ISNULL(P.FLAG_DEL, 0) = 0) -- SA NU AM O COMANDA PE UN PRODUS STERS
	
	ORDER BY CD.ID_DETALIU_COMANDA DESC
		
	-- Inchid tranzactia
	IF @LOCAL_TRAN = 1
		COMMIT TRAN
END TRY
BEGIN CATCH
	-- Salvez eroarea in parametrii de iesire
	SET @ERC = DBLOG.fn_FormatErrorNumber()
	SET @MESSAGE = DBLOG.fn_FormatErrorMessage()

	-- Inchid tranzactia si loghez mesajul de eroare
	IF @LOCAL_TRAN = 1
	BEGIN
		ROLLBACK TRAN
		EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
	END
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_ComenziDetaliu_Insert]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ComenziDetaliu_Insert]
	(
	@ERC INT OUT, 
	@MESSAGE NVARCHAR(4000) OUT,
	@ID_COMANDA int,
	@ID_PRODUS INT,
	@CANTITATE FLOAT
	)
AS  

-- Variabile locale
DECLARE @LOCAL_TRAN BIT

-- Initializari
SET @ERC = 0
SET @MESSAGE = ''
SET @LOCAL_TRAN = 0

-- SET @NUME = TPC.fn_FormatTextFilterEx(@NUME)

-- Bloc tranzactie
BEGIN TRY
	-- Daca nu exista inca o tranzactie, o deschid acum
	IF @@TRANCOUNT = 0
	BEGIN
		SET @LOCAL_TRAN = 1
		BEGIN TRAN
	END

	-- verific daca produsul selectat exista deja pentru aceasta comanda
	IF EXISTS(
	SELECT * FROM COMENZI C
	
	INNER JOIN COMENZI_DETALIU CD
	ON C.ID_COMANDA = CD.ID_COMANDA
	
	WHERE C.ID_COMANDA = @ID_COMANDA AND CD.ID_PRODUS = @ID_PRODUS AND CD.FLAG_DEL = 0
	)
	RAISERROR('Produsul selectat exista deja pentru aceasta comanda !', 11, 1)
	

	IF @ID_PRODUS IS NULL OR @ID_PRODUS = ''
			RAISERROR('Selectati produsul !', 11, 1)
			
	IF @CANTITATE IS NULL OR @CANTITATE = '' OR @CANTITATE = 0
			RAISERROR('Selectati cantitatea !', 11, 1)
			
	IF ISNUMERIC(@CANTITATE) = 0
		RAISERROR('Introduceti o valoare numerica pentru cantitate !', 11, 1)

	
	-- DACA AM GTASIT O COMANDA CU ACELASI PRODUS PE ACEEASI COMANDA
	IF EXISTS(
	SELECT * FROM COMENZI C
	
	INNER JOIN COMENZI_DETALIU CD
	ON C.ID_COMANDA = CD.ID_COMANDA
	
	WHERE C.ID_COMANDA = @ID_COMANDA AND CD.ID_PRODUS = @ID_PRODUS AND CD.FLAG_DEL = 1
	)
	
	BEGIN
		UPDATE COMENZI_DETALIU
		SET
		CANTITATE = @CANTITATE,
		FLAG_DEL = 0
		FROM COMENZI C
	
		INNER JOIN COMENZI_DETALIU CD
		ON C.ID_COMANDA = CD.ID_COMANDA
		
		WHERE
		C.ID_COMANDA = @ID_COMANDA
		AND CD.ID_PRODUS = @ID_PRODUS -- AND CD.FLAG_DEL = 1		
	END

	ELSE
	BEGIN
		-- inserare in tasks
		INSERT INTO COMENZI_DETALIU
		(
			[ID_COMANDA] ,
			[ID_PRODUS],
			[CANTITATE],
			[FLAG_DEL]
       )
		
		VALUES
		(
			@ID_COMANDA,
			@ID_PRODUS,
			@CANTITATE
			, 0 -- il inserez ca nesters
		  )
	END
			
		IF @@ROWCOUNT = 0
			RAISERROR('Eroare de adaugare a produsului in comanda !', 11, 1)
		
	-- Inchid tranzactia
	IF @LOCAL_TRAN = 1
		COMMIT TRAN
END TRY
BEGIN CATCH
	-- Salvez eroarea in parametrii de iesire
	SET @ERC = DBLOG.fn_FormatErrorNumber()
	SET @MESSAGE = DBLOG.fn_FormatErrorMessage()

	-- Inchid tranzactia si loghez mesajul de eroare
	IF @LOCAL_TRAN = 1
	BEGIN
		ROLLBACK TRAN
		EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
	END
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_ComenziDetaliu_Delete]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ComenziDetaliu_Delete]
	(
	@ERC INT OUT, 
	@MESSAGE NVARCHAR(4000) OUT,
	@ID_DETALIU_COMANDA int
	)
AS  
 
-- Variabile locale
DECLARE @LOCAL_TRAN BIT

-- Initializari
SET @ERC = 0
SET @MESSAGE = ''
SET @LOCAL_TRAN = 0

-- SET @NUME = TPC.fn_FormatTextFilterEx(@NUME)

-- Bloc tranzactie
BEGIN TRY
	-- Daca nu exista inca o tranzactie, o deschid acum
	IF @@TRANCOUNT = 0
	BEGIN
		SET @LOCAL_TRAN = 1
		BEGIN TRAN
	END

	UPDATE COMENZI_DETALIU
	SET
	FLAG_DEL = 1
	WHERE ID_DETALIU_COMANDA = @ID_DETALIU_COMANDA
		
	-- Inchid tranzactia
	IF @LOCAL_TRAN = 1
		COMMIT TRAN
END TRY
BEGIN CATCH
	-- Salvez eroarea in parametrii de iesire
	SET @ERC = DBLOG.fn_FormatErrorNumber()
	SET @MESSAGE = DBLOG.fn_FormatErrorMessage()

	-- Inchid tranzactia si loghez mesajul de eroare
	IF @LOCAL_TRAN = 1
	BEGIN
		ROLLBACK TRAN
		EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
	END
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_Comenzi_Select]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Comenzi_Select]
	(
	@ERC INT OUT, 
	@MESSAGE NVARCHAR(4000) OUT,
	@ID_CLIENT BIGINT = NULL,
	@ID_PRODUS BIGINT = NULL,
	@DATA_START DATETIME,
	@DATA_STOP DATETIME
	)
AS  
 
-- Variabile locale
DECLARE @LOCAL_TRAN BIT

-- Initializari
SET @ERC = 0
SET @MESSAGE = ''
SET @LOCAL_TRAN = 0

-- SET @NUME = TPC.fn_FormatTextFilterEx(@NUME)

-- Bloc tranzactie
BEGIN TRY
	-- Daca nu exista inca o tranzactie, o deschid acum
	IF @@TRANCOUNT = 0
	BEGIN
		SET @LOCAL_TRAN = 1
		BEGIN TRAN
	END

	SELECT DISTINCT
	
	C.ID_COMANDA,
	C.ID_CLIENT,
	CC.COD_CLIENT,
	CC.NUME,
	convert(varchar(10), C.DATA_COMANDA, 101) DATA_COMANDA,
	case C.DATA_LIVRARE when '' then null else convert(varchar(10), C.DATA_LIVRARE, 101) end DATA_LIVRARE,
	CD.[FLAG_DEL]
	
	-- into #temp
	FROM
		COMENZI C

	LEFT OUTER JOIN
		COMENZI_DETALIU CD
	ON C.ID_COMANDA = CD.ID_COMANDA
	
	INNER JOIN
		CLIENTI CC
	ON C.ID_CLIENT = CC.ID_CLIENT
		
	WHERE
		(@ID_CLIENT IS NULL OR C.ID_CLIENT LIKE replace(@ID_CLIENT, '*', '%')) AND
		(@ID_PRODUS IS NULL OR CD.ID_PRODUS LIKE replace(@ID_PRODUS, '*', '%')) AND
		-- (C.DATA_COMANDA BETWEEN @DATA_START AND @DATA_STOP) AND
		(
			(
				@DATA_START IS NULL AND
				@DATA_STOP IS NULL
			) OR
			
			(
				@DATA_START IS NULL AND
				@DATA_STOP IS NOT NULL AND
				C.DATA_COMANDA <= @DATA_STOP
			) OR
			
			(
				@DATA_START IS NOT NULL AND
				@DATA_STOP IS NULL AND
				C.DATA_COMANDA >= @DATA_START
			) OR
			
			(
				@DATA_START IS NOT NULL AND
				@DATA_STOP IS NOT NULL AND
				C.DATA_COMANDA BETWEEN @DATA_START AND @DATA_STOP
			)
		) AND
		(ISNULL(CC.FLAG_DEL, 0) = 0) AND -- SA NU AM O COMANDA PE UN CLIENT STERS		
		(isnull(CD.FLAG_DEL, 0) = 0)
		
	ORDER BY C.ID_COMANDA DESC
	
		
	-- Inchid tranzactia
	IF @LOCAL_TRAN = 1
		COMMIT TRAN
END TRY
BEGIN CATCH
	-- Salvez eroarea in parametrii de iesire
	SET @ERC = DBLOG.fn_FormatErrorNumber()
	SET @MESSAGE = DBLOG.fn_FormatErrorMessage()

	-- Inchid tranzactia si loghez mesajul de eroare
	IF @LOCAL_TRAN = 1
	BEGIN
		ROLLBACK TRAN
		EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
	END
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_Comenzi_Insert]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Comenzi_Insert]
	(
	@ERC INT OUT, 
	@MESSAGE NVARCHAR(4000) OUT,
	@ID_CLIENT INT,
	@DATA_COMANDA DATETIME,
	@DATA_LIVRARE DATETIME
	)
AS  

-- Variabile locale
DECLARE @LOCAL_TRAN BIT

-- Initializari
SET @ERC = 0
SET @MESSAGE = ''
SET @LOCAL_TRAN = 0

-- SET @NUME = TPC.fn_FormatTextFilterEx(@NUME)

-- Bloc tranzactie
BEGIN TRY
	DECLARE @DATA_COMANDA_FARA_ORA_MINUT DATETIME
	SET @DATA_COMANDA_FARA_ORA_MINUT = 
	(
		CAST(convert(varchar(10), @DATA_COMANDA, 101) as datetime)
	)

	DECLARE @DATA_LIVRARE_FARA_ORA_MINUT DATETIME
	SET @DATA_LIVRARE_FARA_ORA_MINUT = 
	(
		CAST(convert(varchar(10), @DATA_LIVRARE, 101) as datetime)
	)
	
	-- Daca nu exista inca o tranzactie, o deschid acum
	IF @@TRANCOUNT = 0
	BEGIN
		SET @LOCAL_TRAN = 1
		BEGIN TRAN
	END

	IF @DATA_COMANDA IS NULL OR @DATA_COMANDA = ''
			RAISERROR('Completati data comenzii !', 11, 1)
			
	IF @DATA_LIVRARE IS NULL OR @DATA_LIVRARE = ''
		RAISERROR('Completati data livrarii !', 11, 1)
	
	if DATEDIFF(dd, @DATA_COMANDA, @DATA_LIVRARE) < 0
		RAISERROR('Data livrarii nu poate fi anterioara datei comenzii !', 11, 1)
	
	IF EXISTS ( -- DACA CLIENTUL MAI ARE O COMANDA CU ACEEASI DATA COMANDA SI ACEEASI DATA LIVRARE
		SELECT
			ID_COMANDA
		FROM
			COMENZI
		WHERE
		(
			ID_CLIENT = @ID_CLIENT AND
			cast(convert(varchar(10), DATA_COMANDA, 101) as datetime) = @DATA_COMANDA_FARA_ORA_MINUT AND
			cast(convert(varchar(10), DATA_LIVRARE, 101) as datetime) = @DATA_LIVRARE_FARA_ORA_MINUT
		)
	)
	begin	
		DECLARE @MESAJ_EROARE_COMANDA VARCHAR(4000)
		SET @MESAJ_EROARE_COMANDA = 
		'Exista deja o comanda cu data comenzii (mm/dd/yyyy): '
		+ CONVERT(VARCHAR(10), @DATA_COMANDA, 101)
		+ ' si data livrarii (mm/dd/yyyy): '
		+ CONVERT(VARCHAR(10), @DATA_LIVRARE, 101)
		+ ' pentru clientul cu codul: '''
		+ (
			SELECT TOP 1 COD_CLIENT
			FROM
				CLIENTI
			WHERE
				ID_CLIENT = @ID_CLIENT
			)
		+ ''''
		RAISERROR(@MESAJ_EROARE_COMANDA, 11, 1)
	end

		-- inserare in tasks
		INSERT INTO COMENZI
		(
			[ID_CLIENT],
			[DATA_COMANDA],
			[DATA_LIVRARE]
       )
		
		VALUES
		(
			@ID_CLIENT,
			@DATA_COMANDA,
			@DATA_LIVRARE
		  )
			
		IF @@ROWCOUNT = 0
			RAISERROR('Eroare de adaugare a comenzii !', 11, 1)
		
	-- Inchid tranzactia
	IF @LOCAL_TRAN = 1
		COMMIT TRAN
END TRY
BEGIN CATCH
	-- Salvez eroarea in parametrii de iesire
	SET @ERC = DBLOG.fn_FormatErrorNumber()
	SET @MESSAGE = DBLOG.fn_FormatErrorMessage()

	-- Inchid tranzactia si loghez mesajul de eroare
	IF @LOCAL_TRAN = 1
	BEGIN
		ROLLBACK TRAN
		EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
	END
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_Clienti_Update]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Clienti_Update]
	(
	@ERC INT OUT, 
	@MESSAGE NVARCHAR(4000) OUT,
	@COD_CLIENT VARCHAR(1000) = NULL,
	@NUME VARCHAR(1000) = NULL,
	@ADRESA VARCHAR(1000) = NULL,
	@TELEFON VARCHAR(100) = NULL,
	@FAX VARCHAR(100) = NULL,
	@EMAIL VARCHAR(1000) = NULL
	)
AS  
 
-- Variabile locale
DECLARE @LOCAL_TRAN BIT

-- Initializari
SET @ERC = 0
SET @MESSAGE = ''
SET @LOCAL_TRAN = 0

-- SET @NUME = TPC.fn_FormatTextFilterEx(@NUME)

-- Bloc tranzactie
BEGIN TRY
	-- Daca nu exista inca o tranzactie, o deschid acum
	IF @@TRANCOUNT = 0
	BEGIN
		SET @LOCAL_TRAN = 1
		BEGIN TRAN
	END
	
	IF @COD_CLIENT IS NULL OR @COD_CLIENT = ''
			RAISERROR('Completati codul clientului !', 11, 1)
			
		IF @NUME IS NULL OR @NUME = ''
			RAISERROR('Completati numele clientului !', 11, 1)
			
		IF @ADRESA IS NULL OR @ADRESA = ''
			RAISERROR('Completati adresa clientului !', 11, 1)
			
		IF LEN(@COD_CLIENT) > 1000
			RAISERROR('Introduceti Cod Client cu lungimea < 1000 caractere !', 11, 1)
		
		IF LEN(@NUME) > 1000
			RAISERROR('Introduceti Nume cu lungimea < 1000 caractere !', 11, 1)
			
		IF LEN(@ADRESA) > 1000
			RAISERROR('Introduceti Adresa cu lungimea < 1000 caractere !', 11, 1)
		
		IF LEN(@TELEFON) > 100
			RAISERROR('Introduceti Cod Client cu lungimea < 100 caractere !', 11, 1)
			
		IF LEN(@FAX) > 100
			RAISERROR('Introduceti Fax cu lungimea < 100 caractere !', 11, 1)
			
		IF LEN(@EMAIL) > 1000
			RAISERROR('Introduceti E-mail cu lungimea < 1000 caractere !', 11, 1)

			
		IF @TELEFON IS NULL OR @TELEFON = ''
			RAISERROR('Completati telefonul clientului !', 11, 1)

		-- inserare in tasks
		UPDATE CLIENTI
		SET
		  [NUME] = @NUME,
		  [ADRESA] = @ADRESA,
		  [TELEFON] = @TELEFON,
		  [FAX] = @FAX,
		  [EMAIL] = @EMAIL
		 
		 WHERE COD_CLIENT = @COD_CLIENT
			
		IF @@ROWCOUNT = 0
			RAISERROR('Eroare de modificare a clientului!', 11, 1)
		
	-- Inchid tranzactia
	IF @LOCAL_TRAN = 1
		COMMIT TRAN
END TRY
BEGIN CATCH
	-- Salvez eroarea in parametrii de iesire
	SET @ERC = DBLOG.fn_FormatErrorNumber()
	SET @MESSAGE = DBLOG.fn_FormatErrorMessage()

	-- Inchid tranzactia si loghez mesajul de eroare
	IF @LOCAL_TRAN = 1
	BEGIN
		ROLLBACK TRAN
		EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
	END
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_Clienti_Select]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Clienti_Select]
	(
	@ERC INT OUT, 
	@MESSAGE NVARCHAR(4000) OUT,
	@COD_CLIENT VARCHAR(1000) = null,
	@NUME VARCHAR(1000) = null,
	@ADRESA VARCHAR(1000) = null,
	@TELEFON VARCHAR(100) = null
	)
AS  
 
-- Variabile locale
DECLARE @LOCAL_TRAN BIT

-- Initializari
SET @ERC = 0
SET @MESSAGE = ''
SET @LOCAL_TRAN = 0

SET @NUME = TPC.fn_FormatTextFilterEx(@NUME)

-- Bloc tranzactie
BEGIN TRY
	-- Daca nu exista inca o tranzactie, o deschid acum
	IF @@TRANCOUNT = 0
	BEGIN
		SET @LOCAL_TRAN = 1
		BEGIN TRAN
	END

	SELECT
		[ID_CLIENT],
		  [COD_CLIENT],
		  [NUME],
		  [ADRESA],
		  [TELEFON],
		  [FAX],
		  [EMAIL],
		  [FLAG_DEL]
	FROM
		CLIENTI C
	WHERE
		(@COD_CLIENT is null OR C.COD_CLIENT LIKE replace(@COD_CLIENT, '*', '%')) AND
		(@NUME is null OR C.NUME LIKE replace(@NUME, '*', '%')) AND
		(@ADRESA is null OR C.ADRESA LIKE replace(@ADRESA, '*', '%')) AND
		(@TELEFON is null OR C.TELEFON LIKE replace(@TELEFON, '*', '%')) AND
		(isnull(C.FLAG_DEL, 0) = 0)
		
	ORDER BY ID_CLIENT DESC
		
	-- Inchid tranzactia
	IF @LOCAL_TRAN = 1
		COMMIT TRAN
END TRY
BEGIN CATCH
	-- Salvez eroarea in parametrii de iesire
	SET @ERC = DBLOG.fn_FormatErrorNumber()
	SET @MESSAGE = DBLOG.fn_FormatErrorMessage()

	-- Inchid tranzactia si loghez mesajul de eroare
	IF @LOCAL_TRAN = 1
	BEGIN
		ROLLBACK TRAN
		EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
	END
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_Clienti_Insert]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Clienti_Insert]
	(
	@ERC INT OUT, 
	@MESSAGE NVARCHAR(4000) OUT,
	@COD_CLIENT VARCHAR(1000) = null,
	@NUME VARCHAR(1000) = null,
	@ADRESA VARCHAR(1000) = null,
	@TELEFON VARCHAR(100)= null,
	@FAX VARCHAR(100) = null,
	@EMAIL VARCHAR(1000) = null
	)
AS  
 
-- Variabile locale
DECLARE @LOCAL_TRAN BIT

-- Initializari
SET @ERC = 0
SET @MESSAGE = ''
SET @LOCAL_TRAN = 0

-- SET @NUME = TPC.fn_FormatTextFilterEx(@NUME)

-- Bloc tranzactie
BEGIN TRY
	-- Daca nu exista inca o tranzactie, o deschid acum
	IF @@TRANCOUNT = 0
	BEGIN
		SET @LOCAL_TRAN = 1
		BEGIN TRAN
	END
	
	IF EXISTS(SELECT COD_CLIENT FROM CLIENTI WHERE COD_CLIENT = @COD_CLIENT AND isnull(FLAG_DEL, 0) = 0)
			RAISERROR('Codul de client introdus exista deja !', 11, 1)
	
	IF @COD_CLIENT IS NULL OR @COD_CLIENT = ''
			RAISERROR('Completati codul clientului !', 11, 1)
			
		IF @NUME IS NULL OR @NUME = ''
			RAISERROR('Completati numele clientului !', 11, 1)
			
		IF @ADRESA IS NULL OR @ADRESA = ''
			RAISERROR('Completati adresa clientului !', 11, 1)
			
		IF LEN(@COD_CLIENT) > 1000
			RAISERROR('Introduceti Cod Client cu lungimea < 1000 caractere !', 11, 1)
		
		IF LEN(@NUME) > 1000
			RAISERROR('Introduceti Nume cu lungimea < 1000 caractere !', 11, 1)
			
		IF LEN(@ADRESA) > 1000
			RAISERROR('Introduceti Adresa cu lungimea < 1000 caractere !', 11, 1)
		
		IF LEN(@TELEFON) > 100
			RAISERROR('Introduceti Cod Client cu lungimea < 100 caractere !', 11, 1)
			
		IF LEN(@FAX) > 100
			RAISERROR('Introduceti Fax cu lungimea < 100 caractere !', 11, 1)
			
		IF LEN(@EMAIL) > 1000
			RAISERROR('Introduceti E-mail cu lungimea < 1000 caractere !', 11, 1)
			
		IF @TELEFON IS NULL OR @TELEFON = ''
			RAISERROR('Completati telefonul clientului !', 11, 1)

		IF EXISTS(
		SELECT
			COD_CLIENT
		FROM CLIENTI
		WHERE
		COD_CLIENT = @COD_CLIENT AND
		isnull(FLAG_DEL, 0) = 1
		)
		-- DACA EXISTA DEJA UN CLIENT STERS CU ACELASI ID, IL UPDATEZ
		BEGIN
			UPDATE CLIENTI
			SET
				FLAG_DEL = 0,
				COD_CLIENT = @COD_CLIENT,
				NUME = @NUME,
				ADRESA = @ADRESA,
				TELEFON = @TELEFON,
				FAX = @FAX,
				EMAIL = @EMAIL
			WHERE 
			COD_CLIENT = @COD_CLIENT AND
			isnull(FLAG_DEL, 0) = 1
		END
		
		ELSE
		BEGIN
			-- ALTFEL IL INSEREZ
			INSERT INTO CLIENTI
			(
				[COD_CLIENT],
			  [NUME],
			  [ADRESA],
			  [TELEFON],
			  [FAX],
			  [EMAIL],
			  [FLAG_DEL]
		   )
			
			VALUES
			(
				@COD_CLIENT,
			  @NUME,
			  @ADRESA,
			  @TELEFON,
			  @FAX,
			  @EMAIL,
			  0 -- [FLAG_DEL]
			  )
		END
			
		IF @@ROWCOUNT = 0
			RAISERROR('Eroare de adaugare a clientului!', 11, 1)
			
	-- Inchid tranzactia
	IF @LOCAL_TRAN = 1
		COMMIT TRAN
END TRY
BEGIN CATCH
	-- Salvez eroarea in parametrii de iesire
	SET @ERC = DBLOG.fn_FormatErrorNumber()
	SET @MESSAGE = DBLOG.fn_FormatErrorMessage()

	-- Inchid tranzactia si loghez mesajul de eroare
	IF @LOCAL_TRAN = 1
	BEGIN
		ROLLBACK TRAN
		EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
	END
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_Clienti_Delete]    Script Date: 06/17/2011 16:56:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Clienti_Delete]
	(
	@ERC INT OUT, 
	@MESSAGE NVARCHAR(4000) OUT,
	@ID_CLIENT int
	)
AS  

-- Variabile locale
DECLARE @LOCAL_TRAN BIT

-- Initializari
SET @ERC = 0
SET @MESSAGE = ''
SET @LOCAL_TRAN = 0

-- SET @NUME = TPC.fn_FormatTextFilterEx(@NUME)

-- Bloc tranzactie
BEGIN TRY
	-- Daca nu exista inca o tranzactie, o deschid acum
	IF @@TRANCOUNT = 0
	BEGIN
		SET @LOCAL_TRAN = 1
		BEGIN TRAN
	END

	UPDATE CLIENTI
	SET
	FLAG_DEL = 1
	WHERE ID_CLIENT = @ID_CLIENT
		
	-- Inchid tranzactia
	IF @LOCAL_TRAN = 1
		COMMIT TRAN
END TRY
BEGIN CATCH
	-- Salvez eroarea in parametrii de iesire
	SET @ERC = DBLOG.fn_FormatErrorNumber()
	SET @MESSAGE = DBLOG.fn_FormatErrorMessage()

	-- Inchid tranzactia si loghez mesajul de eroare
	IF @LOCAL_TRAN = 1
	BEGIN
		ROLLBACK TRAN
		EXEC DBLOG.sp_SaveErrorMessage @ERC, @MESSAGE
	END
END CATCH
GO
/****** Object:  ForeignKey [FK_COMENZI_CLIENTI]    Script Date: 06/17/2011 16:56:19 ******/
ALTER TABLE [dbo].[COMENZI]  WITH CHECK ADD  CONSTRAINT [FK_COMENZI_CLIENTI] FOREIGN KEY([ID_CLIENT])
REFERENCES [dbo].[CLIENTI] ([ID_CLIENT])
GO
ALTER TABLE [dbo].[COMENZI] CHECK CONSTRAINT [FK_COMENZI_CLIENTI]
GO
/****** Object:  ForeignKey [FK_COMENZI_DETALIU_COMENZI]    Script Date: 06/17/2011 16:56:19 ******/
ALTER TABLE [dbo].[COMENZI_DETALIU]  WITH CHECK ADD  CONSTRAINT [FK_COMENZI_DETALIU_COMENZI] FOREIGN KEY([ID_COMANDA])
REFERENCES [dbo].[COMENZI] ([ID_COMANDA])
GO
ALTER TABLE [dbo].[COMENZI_DETALIU] CHECK CONSTRAINT [FK_COMENZI_DETALIU_COMENZI]
GO
/****** Object:  ForeignKey [FK_COMENZI_DETALIU_PRODUSE]    Script Date: 06/17/2011 16:56:19 ******/
ALTER TABLE [dbo].[COMENZI_DETALIU]  WITH CHECK ADD  CONSTRAINT [FK_COMENZI_DETALIU_PRODUSE] FOREIGN KEY([ID_PRODUS])
REFERENCES [dbo].[PRODUSE] ([ID_PRODUS])
GO
ALTER TABLE [dbo].[COMENZI_DETALIU] CHECK CONSTRAINT [FK_COMENZI_DETALIU_PRODUSE]
GO
