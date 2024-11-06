-- Soru15

SELECT
su.CompanyName as [Kargo],
COUNT(o.ShipVia) as [Toplam Sipariş]
FROM Orders o join OrderDetails od on o.OrderID=od.OrderID
    JOIN Products p on p.ProductID=od.ProductID
    JOIN Suppliers su on p.SupplierID=su.SupplierID
    GROUP by su.CompanyName 
    order by su.CompanyName 
    