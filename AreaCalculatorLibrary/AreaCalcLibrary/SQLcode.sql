SELECT Products.ProductName, ISNULL(Categories.CategoryName, 'No Category') AS CategoryName
FROM Products
LEFT JOIN Categories ON Products.ProductID = Categories.ProductID
ORDER BY Products.ProductName;
