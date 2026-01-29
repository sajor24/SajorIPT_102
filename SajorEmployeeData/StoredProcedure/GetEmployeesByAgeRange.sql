CREATE PROCEDURE [dbo].[GetEmployeesByAgeRange]
    @MinAge INT,
    @MaxAge INT
AS
BEGIN
    SELECT 
        EmployeeId,
        FirstName,
        LastName,
        Age,
        Position
    FROM [dbo].[Employee]
    WHERE Age BETWEEN @MinAge AND @MaxAge
    ORDER BY Age, LastName, FirstName;
END