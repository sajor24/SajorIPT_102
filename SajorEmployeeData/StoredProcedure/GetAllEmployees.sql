CREATE PROCEDURE [dbo].[GetAllEmployees]
AS
BEGIN
    SELECT 
        EmployeeId,
        FirstName,
        LastName,
        Age,
        Position
    FROM [dbo].[Employee]
    ORDER BY LastName, FirstName;
END