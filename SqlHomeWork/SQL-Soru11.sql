-- Soru 11

select
p.ProductName as [ürün adý],
c.CategoryName as [Kategori]
from Products p join Categories c on p.CategoryID=c.CategoryID