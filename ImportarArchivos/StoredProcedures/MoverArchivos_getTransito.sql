IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id('MoverArchivos_getTransito') and sysstat & 0xf = 4)
	drop procedure MoverArchivos_getTransito
GO

CREATE PROCEDURE MoverArchivos_getTransito(	
	@evento int = NULL
)
as

select
	case when trf_nombr is null
		then ''
		else trf_nombr
	end ArchivoNombre,
	tra_coest Estacion,
	tra_nuvia Via,
	CONVERT(date, tra_fecha) Fecha,
	CONVERT(TIME, tra_fecha) Hora,
	tra_paten Placa,
	tra_manua Categoria,
	for_descr FormaPago,
	tra_numev Evento

from transitos
	left join trfoto on trf_coest = tra_coest and trf_nuvia = tra_nuvia and trf_numev = tra_numev
	join forpag on for_tipop = tra_tipop and for_tipbo = tra_tipbo

where
	 tra_numev = @evento

group by 
	case when trf_nombr is null
		then ''
		else trf_nombr
	end,
	tra_coest,
	tra_nuvia,
	CONVERT(date, tra_fecha),
	CONVERT(TIME, tra_fecha),
	tra_paten,
	tra_manua,
	for_descr,
	tra_numev


-- exec MoverArchivos_getTransito 648078318


