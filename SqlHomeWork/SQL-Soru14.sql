-- Soru14

SELECT
o.ShipName as [Müşteri Adı],
SUM(p.UnitPrice * od.Quantity) as [Tutar]
FROM Orders o JOIN OrderDetails od on o.OrderID=od.OrderID
    JOIN Products p on p.ProductID=od.ProductID
GROUP by o.ShipName , p.UnitPrice
order BY p.UnitPrice DESC
