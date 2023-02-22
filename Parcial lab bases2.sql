create table Banco
(
	banNit number(10) not null,
	banNombre varchar2(30) not null,
	banFechaCreacion date not null,
	constraint pk_Banco primary key(banNit)
);

create table Sucursal
(
	sucCodigo number(5) not null,
	sucNombre varchar2(30) not null,
	sucUbicacion varchar2(30) not null,
	sucNumEmpleados number(5) not null,
	sucAntiguedadAnios number(5) not null,
    	banNit number(10) not null,
	constraint pk_Sucursal primary key(sucCodigo),
	constraint fk_bansuc foreign key(banNit) references Banco(banNit),
    	constraint ckc_sucubicacion check(sucUbicacion in ('Norte', 'Sur', 'Centro'))
);
--------------------------------------------------------------------------------------
--Insercion Bancos
insert into Banco values(1234, 'bbva', '12/03/1989');
insert into Banco values(1235, 'bancolombia', '20/05/1990');
insert into Banco values(1236, 'caja social', '04/03/1980');
insert into Banco values(1237, 'agrario', '30/10/1995');

--Insercion Sucursales
insert into Sucursal values(981, 'bbva la paz', 'Norte', 8, 20, 1234);
insert into Sucursal values(982, 'bbva lomas', 'Sur', 9, 10, 1234);
insert into Sucursal values(983, 'bancolombia bellavista', 'Norte', 7, 15, 1235);
insert into Sucursal values(984, 'bancolombia empedrado', 'Centro', 5, 5, 1235);
insert into Sucursal values(985, 'bancolombia la maria', 'Sur', 2, 9, 1235);
insert into Sucursal values(986, 'caja social san jose', 'Sur', 4, 10, 1236);
insert into Sucursal values(987, 'caja social la pamba', 'Centro', 8, 2, 1236);
insert into Sucursal values(988, 'agrario asturias', 'Norte', 2, 20, 1237);
insert into Sucursal values(989, 'agrario caldas', 'Centro', 6, 17, 1237);
insert into Sucursal values(990, 'agrario el mirador', 'Sur', 9, 6, 1237);
---------------------------------------------------------------------------------------
--Procedimientos Almacenados

--Procedimiento Almacenado para registrar un banco
create or replace procedure prcRegistrarBanco(v_nit banco.bannit%type, v_nomBan banco.bannombre%type, v_fechaBan banco.banfechacreacion%type)
is
begin
    insert into Banco values(v_nit, v_nomBan , v_fechaBan);
end prcRegistrarBanco;

--Procedimiento almacenado para registrar una sucursal
create or replace procedure prcRegistrarSucursal(v_codigo sucursal.succodigo%type, v_nomSuc sucursal.sucnombre%type, v_ubicacion sucursal.sucubicacion%type, 
                                                 v_numEmp sucursal.sucnumempleados%type, v_aniosSuc sucursal.sucantiguedadanios%type, v_nit sucursal.bannit%type)
is
begin
    insert into Sucursal values(v_codigo, v_nomSuc, v_ubicacion, v_numEmp, v_aniosSuc, v_nit);
end prcRegistrarSucursal;

--Procedimiento almacenado para consultar sucursales asociadas a un banco y ubicacion especificas
create or replace procedure prcConsultarSucursales(v_nomBan banco.bannombre%type, v_ubicacion sucursal.sucubicacion%type, curInfoSucursal out SYS_REFCURSOR)
is    
begin
    open curInfoSucursal for
        select sucCodigo as codigo, sucNombre as nombre, sucNumEmpleados as "NUM EMPLEADOS"
        from sucursal inner join banco
        on sucursal.bannit = banco.bannit
        where banNombre = v_nomBan and sucUbicacion = v_ubicacion;
end prcConsultarSucursales;

