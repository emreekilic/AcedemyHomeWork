
select
c.CategoryName AS [Kategori],
SUM(p.UnitsInStock) AS [Stok Miktarý]
FROM Products p JOIN Categories c ON p.CategoryID=c.CategoryID
GROUP BY c.CategoryName