
--1  LEER BASE DE DATOS

--select titulo, CantidadCanciones, FechaLanzamiento from discos

--select * from DISCOS where CantidadCanciones= 17 AND idEstilo = 3

--select * from TIPOSEDICION

--select * from ESTILOS

select D.Titulo, D.CantidadCanciones, D.IdEstilo, E.Descripcion from DISCOS D, ESTILOS E where D.IdEstilo = E.Id

select D.Titulo, D.CantidadCanciones, D.IdEstilo, E.Descripcion ESTILOS from DISCOS D, ESTILOS E where D.IdEstilo = E.Id
-- LE CAMBIE EL NOMBRE A ESTILOS EN LA COLUMNA QUE SE LLAMABA DESCRIPCIÓN LE PONES ESTILOS


-- escribir en DB
-- comilla simple ' aprender a escribirla con el teclado

-- ejemplo de insertar una linea, con el metodo GetDate() pongo la fecha actual de mi PC

insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion) values 
('ES la que va', GETDATE(), 17,'https://cdns-images.dzcdn.net/images/cover/f08424290260e58c6d76275253b316fd/264x264.jpg', 2, 1)

-- Modificar un Registro

update ESTILOS set Descripcion = 'Minimal Techno' where id = 1 

update DISCOS set  Titulo = 'Cambiamos de titulo' where IdEstilo = 2

-- Eliminar datos de un registro

delete from DISCOS where Titulo = 'Temojojones'
delete from Discos where Titulo = 'Siempre es hoy' -- borre todos los que decian siempre es hoy,, a la ve


