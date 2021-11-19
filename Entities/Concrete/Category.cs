using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
/*
select* from Customers
select ContactName adi from Customers
--
select * from Customers where City='london'
select *from Products where CategoryID=2 or CategoryID=7
select *from Products where CategoryID=2 and UnitPrice>10 --<>10 10dan farklı

select *from Products order by CategoryID, ProductName --order by sırala demek ilkönce categori aynıanda isme gore
select *from Products order by UnitPrice --asc kucukten büyüğe desc testen
select *from Products where CategoryID=2 order by UnitPrice

select COUNT(*)adet from Products
select categoryID , COUNT(*)from Products group by CategoryID --kategorilerde kaç ürün var

select * from Products inner join Categories on Products.CategoryID=Categories.CategoryID --on sart inner join birleştir birbirine uygunlari birleştirir
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10
select *from Customers c left join Orders o--solda olup sağda olmayanları birleştir
on c.CustomerID=o.CustomerID
where o.CustomerID is null
*/