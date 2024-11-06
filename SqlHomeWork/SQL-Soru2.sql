--Soru2

SELECT 
c.CompanyName as [Þirket adý],
o.ShipCity as [Þehir]
FROM Products p JOIN Orders o ON o.OrderID=o.OrderID
    JOIN Customers c ON o.CustomerID=c.CustomerID
    ORDER BY o.ShipCity ASC