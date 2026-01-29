CREATE PROCEDURE [dbo].[ReadEmployee]
    @EmployeeId INT
AS
BEGIN
    SELECT *
    FROM [dbo].[Employee]
    WHERE EmployeeId = @EmployeeId;
END