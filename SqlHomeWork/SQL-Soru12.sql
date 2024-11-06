-- Soru12

select
p.ProductName as [ürün adý],
sum(p.UnitPrice) as [Fiyat]

from Products p join OrderDetails od on p.ProductID=od.ProductID
	join Orders o on od.OrderID=o.OrderID
	group by p.ProductName , o.ShipVia 
	order by [Fiyat] DESC