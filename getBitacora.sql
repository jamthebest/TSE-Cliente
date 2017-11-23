SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getBitacora]
AS
BEGIN
	select descripcion, fecha from [dbo].[bitacora]
END
GO