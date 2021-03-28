create procedure PersonajeAlta(@Id varchar(255), @Nombre varchar(255), @Faccion varchar(255), @Poder varchar(255), @Nacimiento varchar(255)) as
begin
	insert into Personajes(Id, Nombre, Faccion, Poder, Nacimiento) values (@Id, @Nombre, @Faccion, @Poder, @Nacimiento)
end
GO
create procedure PersonajeBaja(@Id varchar(255)) as
begin
	delete from Personajes where Id=@Id
end
GO
create procedure PersonajeCambio(@Id varchar(255), @Nombre varchar(255), @Faccion varchar(255), @Poder varchar(255), @Nacimiento varchar(255)) as
begin
	update Personajes set Nombre=@Nombre, Faccion=@Faccion, Poder=@Poder, Nacimiento=@Nacimiento where Id=@Id
end
GO
create procedure PersonajeConsulta(@Id varchar(255)) as
begin
	select * from Personajes where Id=@Id
end