CREATE TABLE Product_Master (
id int IDENTITY(1,1) NOT NULL, 
product_name varchar(250) NULL, 
product_desc varchar(250) NULL, 
cost decimal(18,0) NULL, 
stock int NULL, 
CONSTRAINT PK_Product_Master PRIMARY KEY CLUSTERED(id ASC)
);