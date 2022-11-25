USE master;

DROP DATABASE IF EXISTS AssociationCrm;
CREATE DATABASE AssociationCrm;
GO

USE AssociationCrm;


--   public string Name { get; set; } = String.Empty;
  --      public double Price { get; set; } = 0;

    --    public ProductCategory ProductCategory = ProductCategory.Other;

CREATE TABLE Product (
  Id INT NOT NULL IDENTITY,
  Name VARCHAR(40) NOT NULL,
  Price FLOAT DEFAULT NULL,
  ProductCategory INT DEFAULT NULL,
  PRIMARY KEY (id)
);
GO


INSERT INTO Product (Name,Price,ProductCategory) VALUES
('coca',1.5, 1),
('burger',15.5, 1)


select * from Product

--drop table Product;
--GO