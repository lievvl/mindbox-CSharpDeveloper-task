use AdventureWorks2017;
select p.Name, p.ProductSubcategoryID
from [Production].[Product] as p
left join [Production].[ProductSubcategory] as psc 
on psc.ProductSubcategoryID = p.ProductSubcategoryID