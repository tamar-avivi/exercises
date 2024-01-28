-- Select rows from a Table or View 'TableOrViewName' in schema 'SchemaName'
-- Insert rows into table 'TableName'

select *
from Employee

-- INSERT INTO Employee
--     ([id],[fname],[lname])
-- VALUES
--     ( 1, N'Yotam', N'Avivi')
-- GO

-- insert into Employee
--     (id, fname, lname)
-- VALUES
--     (2, 'Yotam', 'Avivi')

-- DELETE from Employee
-- WHERE id=2