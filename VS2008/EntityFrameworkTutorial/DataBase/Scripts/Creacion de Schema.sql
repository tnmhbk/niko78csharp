--Crea el usuario y el schema
CREATE USER ENTITY_TUTORIAL IDENTIFIED BY ENTITY_TUTORIAL;

--Garantiza la posibilidad de conectarse
GRANT CONNECT TO ENTITY_TUTORIAL;

--Le permite vivir
GRANT RESOURCE TO ENTITY_TUTORIAL;

--Permisos masivos
grant select any table to ENTITY_TUTORIAL;

grant insert any table to ENTITY_TUTORIAL;

grant delete any table to ENTITY_TUTORIAL;

grant update any table to ENTITY_TUTORIAL;

--Hacerlo DBA
GRANT DBA TO ENTITY_TUTORIAL;