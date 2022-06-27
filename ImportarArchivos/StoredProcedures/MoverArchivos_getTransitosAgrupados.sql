IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('MoverArchivos_getTransitosAgrupados') and sysstat & 0xf = 4)
	drop procedure MoverArchivos_getTransitosAgrupados
GO

CREATE PROCEDURE MoverArchivos_getTransitosAgrupados(	
	@fDesde datetime = NULL,
	@fHasta datetime = NULL,
	@placa varchar(8) = NULL,
	@via tinyint = NULL
)
as

if @placa = '' 
	set @placa = null

select
	tra_coest Estacion,
	tra_nuvia Via,
	CONVERT(date, tra_fecha) Fecha,
	CONVERT(TIME, tra_fecha) Hora,
	tra_paten Placa,
	tra_manua Categoria,
	for_descr FormaPago,
	tra_numev Evento

from transitos
	join forpag on for_tipop = tra_tipop and for_tipbo = tra_tipbo

where
	(tra_nuvia = @via OR @via IS NULL) 
	AND (tra_fecha between @fDesde AND @fHasta) 
	AND (tra_paten = @placa OR @placa IS NULL)

group by 
	tra_coest,
	tra_nuvia,
	CONVERT(date, tra_fecha),
	CONVERT(TIME, tra_fecha),
	tra_paten,
	tra_manua,
	for_descr,
	tra_numev


-- exec MoverArchivos_getTransitosAgrupados '20191225', '20200327'
-- 647060143