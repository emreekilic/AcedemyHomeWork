-- Soru13

SELECT  TOP(5)
p.ProductName as [Ürün],
SUM(p.UnitPrice * od.Quantity*(1-od.Discount)) AS [Tutar],
COUNT(p.ProductID) as [Adet]
FROM Products p JOIN OrderDetails od on p.ProductID=od.ProductID
GROUP by p.ProductName , p.UnitPrice , p.ProductID
ORDER by p.UnitPrice DESC