use DB_EQUIPO_A

go
CREATE TRIGGER Fav
on Favoritos instead of insert
as
	declare @numF int, @busc varchar(30), @anun varchar(30)
	select @busc = i.NombreBusc, @anun = i.NombreAn
	from inserted i
	group by i.NombreAn, i.NombreBusc
	
	select @numF = count(*)
	from Favoritos f
	where f.NombreBusc = @busc
	if @numF < 5 begin
		insert into Favoritos values(@busc, @anun)
	end
go

drop trigger Fav
select * from Favoritos

select * from Anunciante

insert into Favoritos values('alberto','Maria');


go
create trigger conc
on Concierto instead of insert 
as
	declare @anun varchar(30),
			@lugar varchar(30),
			@fechaYhora smalldatetime

	select  @anun = i.NombreAn, @lugar = i.NombreLugar, @fechaYhora = f.Fecha_Hora
	from inserted i join Fecha_Hora f on f.NombreConcierto = i.NombreConcierto and i.NombreAn = f.NombreAn

	if exists(
				select *
				from Concierto c join Fecha_Hora f2 on c.NombreConcierto = f2.NombreConcierto
				where f2.Fecha_Hora = @fechaYhora and c.NombreLugar = @lugar
			 )
	begin 
		print 'existe un puto concierto'
	end
go

drop trigger conc
select * from Concierto
select * from Fecha_Hora

insert into Fecha_Hora values('otro', 'katherine', '2018-12-07 14:30:00')
