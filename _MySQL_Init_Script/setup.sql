CREATE DATABASE testDB;
GO
USE testDB;
GO
CREATE TABLE comprobante (
    id_comprobante int,
    tipo_comprobante varchar(255),
    fecha_comprobante DATE,
    proceso_origen varchar(255),
    glosa varchar(255),
    estado varchar(255),
	id_registro_externo int
);
GO
INSERT INTO comprobante(id_comprobante, tipo_comprobante, fecha_comprobante, proceso_origen, glosa, estado, id_registro_externo) 
VALUES (1,'ADELANTO','2022-12-07','ALM','DETALLE ALMACEN','DEFINITIVO',1)
GO