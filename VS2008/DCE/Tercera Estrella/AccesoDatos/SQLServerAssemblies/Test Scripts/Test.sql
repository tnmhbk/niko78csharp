-- Examples for queries that exercise different SQL objects implemented by this assembly

-----------------------------------------------------------------------------------------
-- Stored procedures
-----------------------------------------------------------------------------------------

-- Uso del CLR que devuelve datos inventados
EXEC	[dbo].[GetOperadores]

-- Uso del CLR que devuelve datos de tablas modificados
EXEC	[dbo].[GetPersonasUpercase]

-----------------------------------------------------------------------------------------
-- User defined function
-----------------------------------------------------------------------------------------
 select dbo.GetPI()


-----------------------------------------------------------------------------------------
-- User defined type
-----------------------------------------------------------------------------------------
-- CREATE TABLE test_table (col1 UserType)
-- go
--
-- INSERT INTO test_table VALUES (convert(uri, 'Instantiation String 1'))
-- INSERT INTO test_table VALUES (convert(uri, 'Instantiation String 2'))
-- INSERT INTO test_table VALUES (convert(uri, 'Instantiation String 3'))
--
-- select col1::method1() from test_table



-----------------------------------------------------------------------------------------
-- User defined type
-----------------------------------------------------------------------------------------
-- select dbo.AggregateName(Column1) from Table1

