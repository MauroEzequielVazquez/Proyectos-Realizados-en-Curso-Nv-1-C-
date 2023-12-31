--Ejercicios Consultas SQL
--A partir de la base de datos DISCOS_DB te propongo que realices las siguientes consultas SQL a modo de práctica:

select * from DISCOS
select* from ESTILOS
select * from TIPOSEDICION

--1. Traer todos los discos con su respectivo estilo. La consulta debe mostrar: Nombre de disco, Fecha de lanzamiento, 
--Estilo (no el id, sino la descripción). LE modifique a T.DESCRIPCION para que diga ESTILO

select D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, E.Descripcion, T.Descripcion Estilo
from DISCOS D , ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdEstilo = T.Id


-- 2. Insertar al menos dos estilos nuevos y un tipo de edición de disco. 

insert into DISCOS (IdEstilo,IdTipoEdicion) values (8,19)
insert into DISCOS (IdEstilo) values (14)

--3. Insertar al menos dos discos nuevos cargando correctamente su información.
-- el id se agrega solo a medida q se van cargando

insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa,IdEstilo,IdTipoEdicion) values
('Korolova', GETDATE(), 28,'https://cdns-images.dzcdn.net/images/cover/f08424290260e58c6d76275253b316fd/264x264.jpg', 23, 56)

insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion) values 
('ES la que va', GETDATE(), 17,'https://cdns-images.dzcdn.net/images/cover/f08424290260e58c6d76275253b316fd/264x264.jpg', 2, 1)

--4. Actualizar al menos un disco modificando la cantidad de canciones y la fecha de lanzamiento. No te olvides del Where.	

update DISCOS set FechaLanzamiento = getdate() where IdEstilo = 8
update DISCOS set CantidadCanciones = 299 where CantidadCanciones = 17
update DISCOS set Titulo ='Temones Mañaneros' where IdTipoEdicion = 19 
update DISCOS set Titulo ='Arriba Domingo' where IdEstilo = 14

-- 5. Borrar un disco a elección.

delete from DISCOS where Titulo = 'Arriba Domingo'

--6. Traer todos los estilos que estén asociados a algún disco.

select E.Descripcion, D.IdEstilo from  ESTILOS E, DISCOS D where D.IdEstilo = E.Id

--7. Traer todos los discos con el siguiente formato: Nombre, Estilo, Edición (todo texto).

select D.Titulo Nombre, D.IdEstilo Estilo , D.IdTipoEdicion Edición from DISCOS D, ESTILOS E, TIPOSEDICION T 
where D.IdEstilo = E.Id AND D.IdEstilo = T.Id

--8. Traer todos los discos que contengan en su nombre la sílaba "ho".
