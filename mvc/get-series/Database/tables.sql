-- Create a new table called 'TableName' in schema 'SchemaName'
-- Drop the table if it already exists
IF OBJECT_ID('GetSeries.Employee', 'U') IS NOT NULL
DROP TABLE Employee
GO
-- Create the table in the specified schema
CREATE TABLE Employee
(
    id INT NOT NULL PRIMARY KEY,
    -- primary key column
    fname [NVARCHAR](50) NOT NULL,
    lname [NVARCHAR](50) NOT NULL
    -- specify more columns here
);
GO