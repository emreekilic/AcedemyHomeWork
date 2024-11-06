-- Soru 18

SELECT TOP(5)
cu.CompanyName as [Müşteri Adı],
COUNT(p.UnitPrice) as [Sipariş Sayısı]
FROM Orders o JOIN OrderDetails od on o.OrderID=od.OrderID
    JOIN Products p on p.ProductID=od.ProductID
    join Customers cu ON o.CustomerID=cu.CustomerID
GROUP by cu.CompanyName 
order BY [Sipariş Sayısı] ASC