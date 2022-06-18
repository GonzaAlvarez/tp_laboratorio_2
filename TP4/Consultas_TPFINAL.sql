-- Select de todas las tablas --
select * from Productos;
select * from Clientes;
select * from Mensajes;

-- Busca los mensajes enviados a los clientes --
select m.contenido, m.id_cliente, c.nombre, c.apellido from Mensajes m inner join Clientes c on m.id_cliente = c.id;

-- Consultas utiles de precio (Tabla Productos) --
select AVG(precio) from Productos; -- Promedio de precios --
select SUM(precio) from Productos; -- Suma de precios --
select MAX(precio) from Productos; -- Precio mas alto --
select MIN(precio) from Productos; -- Precio mas bajo --
select COUNT(*) from Productos where precio > 50000.00; -- Cantidad de productos que valen mas de 50mil --

