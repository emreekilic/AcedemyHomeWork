--Soru 8

select
cu.Country as [Ülke],
COUNT(*) As 'Müþteri Sayýsý'
From Customers cu
group by cu.Country
order by [Müþteri Sayýsý] ASC



