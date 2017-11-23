SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE [dbo].[InsertBitacora]
	@descripcion text,
	@fecha varchar(20)
AS
BEGIN
	insert into dbo.bitacora(descripcion, fecha) values (@descripcion, @fecha)
END
GO

exec InsertarBitacora javier, jam
select * from dbo.Usuarios