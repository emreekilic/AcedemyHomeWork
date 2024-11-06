-- Soru19

SELECT
cu.Country as [Ülke],
SUM(p.UnitPrice*od.Quantity) as [Toplam Tutar]
FROM Products p Join OrderDetails od on p.ProductID=od.ProductID
    JOIN Orders o on od.OrderID=o.OrderID
    JOIN Customers cu on o.CustomerID=cu.CustomerID
GROUP by cu.Country
ORDER by [Toplam Tutar]