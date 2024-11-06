-- Soru17

SELECT
c.CategoryName as [Kategori],
AVG(p.UnitPrice) as [Ortalama Tutar]
FROM Products p JOIN Categories c on p.CategoryID=c.CategoryID
    JOIN OrderDetails od on p.ProductID=od.ProductID
    GROUP by c.CategoryName
    ORDER by c.CategoryName