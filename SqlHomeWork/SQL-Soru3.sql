--Soru3

SELECT
e.FirstName AS [İsim],
e.LastName AS [Soyisim]
FROM Employees e
group by e.FirstName , e.LastName 