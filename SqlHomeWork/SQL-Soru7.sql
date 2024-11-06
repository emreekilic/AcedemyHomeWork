--Soru7

select Top 5
p.ProductName as [Ürün adý],
p.UnitPrice  as [Ürün Fiyatý]
from Products p
order by UnitPrice DESC