# GeometryLibrary

Задание:

Напишите на C# библиотеку для поставки внешним клиентам, 
которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 

В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.

Решение: 

SELECT Products.Name AS ProductName, Categories.Name AS CategoryName
FROM Products
LEFT JOIN ProductsCategories ON Products.ID = ProductsCategories.ProductID
LEFT JOIN Categories ON ProductsCategories.CategoryID = Categories.ID
