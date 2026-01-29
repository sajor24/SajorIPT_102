CREATE PROCEDURE [dbo].[SearchEmployeesByPosition]
    @Position NVARCHAR(100)
AS
BEGIN
    SELECT 
        EmployeeId,
        FirstName,
        LastName,
        Age,
        Position
    FROM [dbo].[Employee]
    WHERE Position LIKE '%' + @Position + '%'
    ORDER BY LastName, FirstName;
END