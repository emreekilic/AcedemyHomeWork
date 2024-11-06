--Soru 10

select
e.FirstName as [Çalýþan Ýsmi],
e.LastName As [Çalýþan Soyisim],
e.Extension as [Sipariþ Sayýsý]
from Employees e
order by e.Extension DESC
