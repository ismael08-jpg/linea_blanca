/**********CREANDO BASE DE DATOS**********/
create database linea_blanca
go
use linea_blanca
go


--USE master
--GO
-- ALTER DATABASE linea_blanca
--SET OFFLINE WITH ROLLBACK IMMEDIATE
--GO

--drop database linea_blanca




--Creacion de usuarios
--Creacionde contraseñas
--Creación de Tablas--

--Tabla Cliente
create table cliente(
id_cliente int IDENTITY(1,1) not null,
nombre varchar(50) not null,
telefono varchar (20) not null,
dui varchar(10) not null,
nit varchar(20) not null
)

--Tabla Usuario
create table usuario(
id_usuario int IDENTITY(1,1) not null,
nombre varchar(50) not null,
username varchar(50) not null,
cargo varchar(50) not null,
pass_word varchar(30)not null,
rol int not null
)

--Tabla Producto
create table producto(
id_producto int IDENTITY(1,1) not null,
nombre varchar(200) not null,
precio money not null,
id_credito int null,
id_tipo int not null
)

--Tabla Categoria
create table categoria(
id_categoria int IDENTITY(1,1) not null,
nombre varchar(50) not null
)

--Tabla Tipo
create table tipo(
id_tipo int IDENTITY(1,1) not null,
nombre varchar(50) not null,
id_categoria int not null
)

--Tabla Credito
create table credito(
	id_credito int IDENTITY(1,1) not null,
	id_usuario int not null,
	id_cliente int not null,
	interes decimal(18,6) not null,
	fecha_compra date,
	total money not null,
	-- cuota
	cuota money null,
	cantidad_cuotas int null,
	fecha_inicio date null,
	estado varchar(50) null,
)



--Tabla Pago
--create table pago(
--id_pago int IDENTITY(1,1) not null,
--fecha_pago date,
--monto money not null,
--id_credito int not null,
--total money not null,
--id_cuota int not null --new
--)

--Tabla pagos
create table pago(
id_pago int IDENTITY(1,1) not null,
fecha_pago date null,
monto money not null,
fecha_limite date null,
mora money null,
estado varchar(50) null,
id_credito int not null,
)


--Creando llaves Primarias
 alter table cliente add primary key(id_cliente)
 alter table usuario add primary key(id_usuario)
 alter table producto add primary key(id_producto)
 alter table categoria add primary key(id_categoria)
 alter table tipo add primary key(id_tipo)
 alter table credito add primary key(id_credito)
 alter table pago add primary key(id_pago)
 --alter table cuota add primary key(id_cuota)

 --creacion de llaves foraneas y relaciones
 alter table credito
add constraint fk_Clienteid_cliente foreign key(id_cliente)
references cliente(id_cliente) on update cascade on delete cascade

 alter table credito
add constraint fk_Usuarioid_usuario foreign key(id_usuario)
references usuario(id_usuario) on update cascade on delete cascade

alter table producto
add constraint fk_Creditoid_credito foreign key(id_credito)
references credito(id_credito) on update cascade on delete cascade

alter table producto
add constraint fk_tipo_credito foreign key(id_tipo)
references tipo(id_tipo) on update cascade on delete cascade
 /*alter table Producto
add constraint fk_Tipoid_tipo foreign key(id_tipo)
references Tipo(id_tipo) on update cascade on delete cascade*/

alter table tipo
add constraint fk_Categoriaid_categoria foreign key(id_categoria)
references categoria(id_categoria) on update cascade on delete cascade

--alter table pago
--add constraint fk_Pagoid_pago foreign key(id_cuota)
--references cuota(id_cuota) on update cascade on delete cascade


alter table pago
add constraint fk_id_credito_pago foreign key(id_credito)
references credito(id_credito) on update cascade on delete cascade

 /*alter table Credito
add constraint fk_Cuotaid_credito foreign key(id_credito)
references Cuota(id_credito) on update cascade on delete cascade*/

--Inserción de registros en las Tablas--
