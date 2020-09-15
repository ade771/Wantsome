Create view AllCustomers
AS
Select Customer.Nume,
Product.[Description], OrderProduct.NumberOfProducts,[Order].TotalPrice
From Customer
inner join  Product on Customer.CustomerId= Product.ProductId
inner join OrderProduct on  Customer.CustomerId = OrderProduct.OrderId
inner join [Order] on Customer.CustomerId  = [Order].OrderId;
GO 
Select * from AllCustomers
