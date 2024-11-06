-- Soru20

SELECT
p.ProductName as [Ürün adı],
SUM(p.UnitPrice*od.Quantity) as [Tutar]
FROM Orders o JOIN OrderDetails od on od.OrderID=o.OrderID
    JOIN Products p on p.ProductID=od.ProductID
WHERE YEAR(o.OrderDate)>=1970
GROUP by p.ProductName
ORDER BY p.ProductName



SELECT
p.ProductName as [Ürün adı],
SUM(p.UnitPrice*od.Quantity) as [Tutar]
FROM Orders o JOIN OrderDetails od on od.OrderID=o.OrderID
    JOIN Products p on p.ProductID=od.ProductID
WHERE MONTH(o.OrderDate)>=5
And YEAR(o.OrderDate)>=1970
GROUP by p.ProductName
ORDER BY p.ProductName ASC
