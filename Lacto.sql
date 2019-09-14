Create database LactoBioticss

drop database Lacto

use LactoBioticss




-----------------------------------------------------------------------------------------------------
------- User_Accounts -------
drop table User_acc

Create table User_acc
(
users_id int primary key identity (1,1),
user_uname varchar (20) unique not null,
user_pass varchar (20)not null,
user_type varchar (50)not null,
user_Fname varchar (20)not null,
user_Lname varchar (20)not null,
user_email varchar (50)not null,
user_status varchar (20)not null,
secQuest varchar (max)not null,
secAns varchar (max)not null,
date_reg datetime
)

select * from User_acc

insert into User_acc values ('admin', 'admin', 'Administrator', 'earl', 'cejas', 'lykearl@gmail.com', 'Active', 'What is the name of your pet?', 'earl', '05/09/2019')

-------------------------------------------------------------------------------------------------------

drop procedure sp_login

create procedure sp_login_acc
@user_uname varchar (max),
@user_pass varchar (max)
as
select * from user_acc where user_uname = @user_uname and user_pass = @user_pass return

-------------------------------------------------------------------------------------------------------

drop procedure sp_add_acc

create procedure sp_add_acc
@user_uname varchar (20),
@user_pass varchar (20),
@user_type varchar (50),
@user_Fname varchar (20),
@user_Lname varchar (20),
@user_email varchar (50),
@user_status varchar (20), 
@secQuest varchar (max),
@secAns varchar (max),
@date_reg datetime
as
insert into user_acc 
values (@user_uname,@user_pass,@user_type,@user_Fname,@user_Lname, @user_email, @user_status, @secQuest, @secAns,@date_reg) return

-------------------------------------------------------------------------------------------------------

drop procedure sp_update_acc

create proc sp_update_acc
@users_id int,
@user_uname varchar (20),
@user_pass varchar (20),
@user_type varchar (50),
@user_Fname varchar (20),
@user_Lname varchar (20),
@user_email varchar (50),
@user_status varchar (20), 
@secQuest varchar (max),
@secAns varchar (max),
@date_reg datetime
as
update user_acc
set user_uname=@user_uname, user_pass=@user_pass, user_type=@user_type, user_Fname=@user_Fname, user_Lname=@user_Lname, user_email=@user_email,
user_status=@user_status, secQuest=@secQuest, secAns=@secAns, date_reg=@date_reg
from user_acc
where users_id=@users_id;

---------------------------------------------------------------------------------------------------------------

drop procedure sp_delete_acc

create procedure sp_delete_acc
@users_id int
as
delete from user_acc
where users_id = @users_id return

---------------------------------------------------------------------------------------------------------------

drop procedure sp_search_user_acc

create procedure sp_search_user_acc
@key varchar (max)
as
select * from user_acc
where users_id like '%' +@key+ '%' or
      user_uname like '%' +@key+ '%' or
      user_pass like '%' +@key+ '%' or
	  user_type like '%' +@key+ '%' or
      user_Fname like '%' + @key+ '%' or
	  user_Lname like '%' + @key+ '%' or
	  user_email like '%' + @key+ '%' or
	  user_status like '%' + @key+ '%' or
	  secQuest like '%' + @key+ '%'or
	  secAns like '%' + @key+ '%'or
	  date_reg  like '%' + @key+ '%'
	  return

---------------------------------------------------------------------------------------------------------------

drop procedure sp_view_account

create procedure sp_view_acc
as
select * from user_acc

---------------------------------------------------------------------------------------------------------------



----------------------------------------------------------------------------------------------------------------
------Customer-----

drop table customer

create table customers
(
customer_id int primary key identity (1,1),
users_id int foreign key references user_acc(users_id),
customer_name varchar (50),
tin varchar (50),
address_ varchar(50),
business_style varchar (50),
contact_no varchar (20),
customer_type varchar (50),
date_ datetime
)

---------------------------------------------------------------------------------------------------------------

drop procedure sp_add_customer

create procedure sp_add_customer
@users_id int,
@customer_name varchar (50),
@tin varchar (50),
@address_ varchar(50),
@business_style varchar (50),
@contact_no varchar (20),
@customer_type varchar (50),
@date_ datetime 
as
insert into customers
values (@users_id, @customer_name, @tin, @address_, @business_style, @contact_no ,@customer_type, @date_) return

-----------------------------------------------------------------------------------------------------------

drop procedure sp_update_customer

create procedure sp_update_customer
@customer_id int,
@customer_name varchar (50),
@tin varchar (50),
@address_ varchar(20),
@business_style varchar (50),
@contact_no varchar (20),
@customer_type varchar (50),
@date_ datetime
as
update customers
set customer_name = @customer_name, tin = @tin, address_ = @address_, business_style = @business_style, contact_no = @contact_no, customer_type = @customer_type,  date_ = @date_
where customer_id = @customer_id return

---------------------------------------------------------------------------------------------------------------

drop procedure sp_remove_customer

create procedure sp_remove_customer
@customer_id int
as
delete from customers
where customer_id = @customer_id return

---------------------------------------------------------------------------------------------------------------

drop procedure sp_search_customer

create procedure sp_search_customer
@key varchar (max)
as
select * from customers
where customer_id like '%' +@key+ '%' or
	  users_id like '%' +@key+ '%' or
      customer_name like '%' + @key+ '%' or
	  tin like '%' + @key+ '%' or
      address_ like '%' + @key+ '%' or
	  business_style like '%' + @key+ '%' or
	  contact_no like '%' + @key+ '%' or
	  customer_type like '%' + @key+ '%' or
	  date_ like '%' + @key+ '%' 
	  return

---------------------------------------------------------------------------------------------------------------

drop procedure sp_view_customer

create procedure sp_view_customer
as
select * from customers

 


 
----------------------------------------------------------------------------------------------------------------
---------------------------FOR FORGOT PASS------------------------------------

drop procedure forgotPassword

Create procedure forgotPassword
@user_uname varchar (50),
@secQuest varchar (max),
@secAns varchar (max)
as
select * from user_acc where user_uname = @user_uname and secQuest= @secQuest and secAns= @secAns

-----------------------------------------------------------------------------

drop procedure ChangePassword

create procedure ChangePassword
@user_uname varchar (50),
@newPass varchar (50)
as 
update user_acc  set user_pass = @newPass where user_uname = @user_uname

--------------------------------------------------------------------------





----------------------------------------------------------------------------------------------------------------
---------Products-----------

drop table products

create table products
(
productID int primary key identity (1,1),
users_id int foreign key references user_acc(users_id),
product_code varchar (50),
product_name varchar (50),
product_category varchar (50),
product_price int,
product_description varchar (100),
date_ datetime
)

----------------------------------------------------------------------------------------------------------------------

drop procedure sp_add_products

create procedure sp_add_products
@users_id int,
@product_code varchar (50),
@product_name varchar (50),
@product_category varchar (50),
@product_price decimal,
@product_description varchar (100),
@date_ datetime
as
insert into products
values (@users_id, @product_code, @product_name, @product_category, @product_price, @product_description,  @date_) return

----------------------------------------------------------------------------------------------------------------------

drop procedrure sp_update_products

create procedure sp_update_products
@productID int,
@product_code varchar (50),
@product_name varchar (50),
@product_catergory varchar (50),
@product_price decimal,
@product_description varchar (50),
@date_ datetime
as
update products
set product_code = @product_code, product_name = @product_name, product_category = @product_catergory, product_price = @product_price, product_description = @product_description, date_ = @date_
where productID = @productID return

-----------------------------------------------------------------------------------------------------------------------

drop procedure sp_remove_products

create procedure sp_remove_products
@productID int
as
delete from products
where productID = @productID  return

-----------------------------------------------------------------------------------------------------------------------

drop procedure sp_search_products

create procedure sp_search_products
@key varchar (max)
as
select * from products
where productID like '%' +@key+ '%' or
	  product_code like '%' +@key+ '%' or
	  product_name like '%' +@key+ '%' or
	  product_category like '%' +@key+ '%' or
	  product_price like '%' +@key+ '%' or
	  product_description like '%' +@key+ '%' or
	  users_id like '%' +@key+ '%' or
	  date_ like '%' +@key+ '%'

------------------------------------------------------------------------------------------------------------------------

drop procedure sp_view_products

create procedure sp_view_products
as
select * from products

-----------------------------------------------------------------------------------------------------------------------


------------------------------------------------------------------------------------------------------------------------




----------------------------------------------------------------------------------------------------------------
------------------- Stocks --------------------

drop table stocks

create table stocks
(
stocks_id int primary key identity (1,1),
productID int foreign key references products(productID),
stock_in int,
users_id int foreign key references user_acc(users_id),
stock_in_date datetime
)

-----------------------------------------------------------------------------------------------------------------

drop procedure sp_add_stocks

create procedure sp_add_stocks
@productID int,
@stock_in int,
@users_id int,
@stock_in_date datetime
as
insert into stocks
values (@productID, @stock_in, @users_id, @stock_in_date)

-----------------------------------------------------------------------------------------------------------------

drop procedure sp_update_stocks

create procedure sp_update_stocks
@stocks_id int,
@productID int,
@stock_in int,
@stock_in_date datetime
as
update stocks
set  productID = @productID, stock_in = @stock_in, stock_in_date = @stock_in_date
where stocks_id = @stocks_id

------------------------------------------------------------------------------------------------------------------

drop procedure sp_delete_stocks

create procedure sp_delete_stocks
@stocks_id int
as
delete from stocks
where stocks_id = @stocks_id

------------------------------------------------------------------------------------------------------------------

drop procedure sp_search_stocks

create procedure sp_search_stocks
@key varchar (max)
as
select * from stocks
where stocks_id like '%' + @key + '%' or
      productId like '%' + @key + '%' or
	  stock_in like '%' + @key + '%' or
	  users_id like '%' + @key + '%' or
	  stock_in_date like '%' + @key + '%'

------------------------------------------------------------------------------------------------------------------

drop procedure sp_update_stocks_pro

create procedure sp_update_stocks_pro
 @productID int,
 @stock_in int
 as
 update stocks 
 set stock_in = stock_in - @stock_in
 WHERE stocks.productID = @productID

-------------------------------------------------------------------------------------------------------------------

drop procedure sp_cancel_order

create procedure sp_cancel_order
@quantityToRevert int,
@product_ID varchar(max)
as
update stocks
set stock_in = stock_in + @quantityToRevert 
where productID = @product_ID

--------------------------------------------------------------------------------------------------------------------

drop procedure sp_view_stocks

create procedure sp_view_stocks
as
select stocks_id, stocks.productID,  products.product_code, products.product_name, products.product_category, products.product_price, stocks.stock_in, products.product_description
from stocks inner join products on stocks.productID = products.productID
 
------------------------------------------------------------------------------------------------------------------





-------------------------------------------------------------------------------------------------------------------
---------- inventory reports --------

drop table inventory

create table inventory
(
inventory_id int primary key identity (1,1),
productID int foreign key references products(productID),
stock_in int,
users_id int foreign key references user_acc(users_id),
stock_in_date datetime
)

------------------------------------------------------------------------------------------------------------------

drop procedure sp_add_inventory

create procedure sp_add_inventory
@productID int,
@stock_in int,
@users_id int,
@stock_in_date datetime
as
insert into inventory
values (@productID, @stock_in, @users_id, @stock_in_date)

------------------------------------------------------------------------------------------------------------------

drop procedure sp_select_stocks_inventory

create procedure sp_select_stocks_inventory
as
select inventory_id, products.productID, products.product_code, products.product_name, products.product_category, products.product_price, inventory.stock_in, products.product_description, User_acc.user_Fname, User_acc.user_Lname, User_acc.users_id, inventory.stock_in_date
from inventory inner join User_acc on inventory.users_id = User_acc.users_id inner join products on inventory.productID = products.productID
 
------------------------------------------------------------------------------------------------------------------





-------------------------------------------------------------------------------------------------------------------
---------- Reservation ----------

drop table ProductsReservation

create table ProductsReservation
(
ReservationId int primary key identity (1,1),
productID int foreign key references products(productID),
order_quantity int,
totalPrice decimal,
transactiontype varchar(50),
ClaimDate datetime,
reservationStatus varchar (50),
customer_id int foreign key references customers(customer_id),
users_id int foreign key references User_acc(users_id),
Reservation_Date datetime
)

---------------------------------------------------------------------------------------------------------------------

drop procedure sp_add_reservation


create procedure sp_add_reservation
@productId int,
@order_quantity int,
@totalPrice decimal,
@transactiontype varchar(50),
@ClaimDate datetime,
@reservationStatus varchar (50),
@customer_id int,
@user_id int,
@Reservation_Date datetime
as
insert into ProductsReservation
values (@productID, @order_quantity, @totalPrice, @transactiontype, @ClaimDate, @reservationStatus, @customer_id, @user_id, @Reservation_Date)

---------------------------------------------------------------------------------------------------------------------

drop procedure sp_update_reservation

create procedure sp_update_reservation
@ReservationId int,
@reservationStatus varchar(50)
as
update ProductsReservation
set reservationStatus = @reservationStatus
where ReservationId = @ReservationId

----------------------------------------------------------------------------------------------------------------------

drop procedure sp_select_reservation

create procedure sp_select_reservation
as
select ReservationId, products.productId, products.product_code, products.product_name, ProductsReservation.order_quantity, ProductsReservation.totalPrice, ProductsReservation.transactiontype, ProductsReservation.ClaimDate, ProductsReservation.reservationStatus, 
customers.customer_name, customers.address_, customers.customer_id, User_acc.users_id, ProductsReservation.Reservation_Date
from ProductsReservation inner join products on ProductsReservation.productID = products.productId inner join customers on ProductsReservation.customer_id = customers.customer_id inner join User_acc on ProductsReservation.users_id = User_acc.users_id

----------------------------------------------------------------------------------------------------------------------





----------------------------------------------------------------------------------------------------------------------
------------- Delivery ---------------


drop table ProductsDelivery

create table ProductsDelivery
(
DeliveryId int primary key identity (1,1),
productID int foreign key references products(productID),
order_quantity int,
totalPrice decimal,
transactiontype varchar(50),
Delivery_Date datetime,
deliveryStatus varchar (50),
customer_id int foreign key references customers(customer_id),
users_id int foreign key references User_acc(users_id),
Date_ datetime
)

---------------------------------------------------------------------------------------------------------------------

drop procedure sp_add_delivery

create procedure sp_add_delivery
@productId int,
@order_quantity int,
@totalPrice decimal,
@transactiontype varchar(50),
@Delivery_Date datetime,
@deliveryStatus varchar (50),
@customer_id int,
@user_id int,
@Date_ datetime
as
insert into ProductsReservation
values (@productID, @order_quantity, @totalPrice, @transactiontype, @Delivery_Date, @deliveryStatus, @customer_id, @user_id, @Date_)

---------------------------------------------------------------------------------------------------------------------

drop procedure sp_update_delivery

create procedure sp_update_delivery
@DeliveryId int,
@deliveryStatus varchar(50)
as
update ProductsDelivery
set deliveryStatus = @deliveryStatus
where DeliveryId = @DeliveryId

----------------------------------------------------------------------------------------------------------------------

drop procedure sp_select_delivery

create procedure sp_select_delivery
as
select DeliveryId, products.productId, products.product_code, products.product_name, ProductsDelivery.order_quantity, ProductsDelivery.totalPrice,  ProductsDelivery.transactiontype, ProductsDelivery.Delivery_Date, ProductsDelivery.deliveryStatus, 
customers.customer_name, customers.address_, customers.customer_id, User_acc.users_id, ProductsDelivery.Date_
from ProductsDelivery inner join products on ProductsDelivery.productID = products.productId inner join customers on ProductsDelivery.customer_id = customers.customer_id inner join User_acc on ProductsDelivery.users_id = User_acc.users_id

----------------------------------------------------------------------------------------------------------------------





-------------------------------------------------------------------------------------------------------------------
--------------- Sales Reports -------------------


drop table SalesReports

create table SalesReports
(
SalesReport_ID int primary key identity (1,1),
productID int foreign key references products(productID),
order_quantity int,
TotalAmount decimal,
transactiontype varchar (50),
customer_id int foreign key references customers(customer_id),
users_id int foreign key references User_acc(users_id),
date_ datetime
)
-------------------------------------------------------------------------------------------------------------------


drop procedure sp_add_SalesReports

create procedure sp_add_SalesReports
@productID int,
@order_quantity int,
@TotalAmount decimal,
@transactiontype varchar (50),
@customer_id int,
@users_id int,
@date_ datetime
as
insert into SalesReports
values(@productID,@order_quantity ,@TotalAmount ,@transactiontype, @customer_id, @users_id, @date_)

---------------------------------------------------------------------------------------------------------------------

drop procedure sp_view_SalesReports

create procedure sp_view_SalesReports
as
select SalesReport_ID, products.productID, products.product_code, products.product_name, products.product_category, products.product_price, order_quantity, SalesReports.TotalAmount, SalesReports.transactiontype, products.product_description, customers.customer_id, User_acc.users_id, SalesReports.date_
from SalesReports inner join products on SalesReports.productID = products.productID inner join User_acc on SalesReports.users_id = User_acc.users_id
inner join customers on SalesReports.customer_id = customers.customer_id 
 
---------------------------------------------------------------------------------------------------------------------





----------------------------------------------------------------------------------------------------------------------
------------ generate product code ------------

drop procedure spGenerateSoapProCode

create procedure spGenerateSoapProCode
as
declare @productID int
select @productID = IDENT_CURRENT('products')
return @productID

----------------------------------------------

drop procedure spGenerateHerbalProCode

create procedure spGenerateHerbalProCode
as
declare @productID int
select @productID = IDENT_CURRENT('products')
return @productID

----------------------------------------------

drop procedure spGenerateDogFoodProCode

create procedure spGenerateDogFoodProCode
as
declare @productID int
select @productID = IDENT_CURRENT('products')
return @productID
---------------------------------------------------------------------------------------------------------------------











select * from ProductsReservation






































drop table OrderDetails

create table OrderDetails
(
OrderDetailsId int primary key identity (1,1),
OrderID int foreign key references productOrder(OrderID),
productID int foreign key references products(productID),
customer_id int foreign key references customers(customer_id),
users_id int foreign key references User_acc(users_id),
date_ datetime
)

---------------------------------------------------------------------------------------------------------------------

drop procedure sp_add_OrderDetails

create procedure sp_add_OrderDetails
@OrderID int,
@productID int,
@customer_id int,
@users_id int,
@Order_Date datetime
as
insert into OrderDetails
values(@OrderId, @productID, @customer_id, @users_id, @Order_Date)

---------------------------------------------------------------------------------------------------------------------

drop procedure sp_view_OrderDetails

create procedure sp_view_OrderDetails
as
select OrderDetailsId, products.productID, products.product_code, products.product_name, products.product_category, products.product_price, order_quantity, products.product_description, customers.customer_id, User_acc.users_id, productOrder.OrderID 
from OrderDetailsId inner join products on OrderDetailsId.productID = products.productID inner join User_acc on OrderDetails.users_id = User_acc.users_id 
inner join productOrder on OrderDetailsId.OrderID = productOrder.OrderId inner join customers on OrderDetailsId.customer_id = customers.customer_id 
 
---------------------------------------------------------------------------------------------------------------------










select * from SalesReports

select * from ProductsDelivery
































































------------------------------------------------------------------------------------------------------------------
------------ purchase order ------------
drop table productOrder

create table productOrder
(
OrderId int primary key identity (1,1),
productID int foreign key references products(productID),
order_quantity int,
totalPrice decimal,
transactiontype varchar(50),
customer_id int foreign key references customers(customer_id),
users_id int foreign key references User_acc(users_id),
Order_Date datetime
)

-------------------------------------------------------------------------------------------------------------------

drop procedure sp_add_order

create procedure sp_add_order
@product_id int,
@order_quantity int,
@totalPrice decimal,
@transactiontype varchar(50),
@customer_id int,
@users_id int,
@Order_Date datetime
as
insert into productOrder
values (@product_id, @order_quantity, @totalPrice, @transactiontype, @customer_id, @users_id, @Order_Date)

-------------------------------------------------------------------------------------------------------------------

drop procedure sp_delete_order

create procedure sp_delete_order
@OrderID int
as
delete from productOrder
where OrderID = @OrderID

-------------------------------------------------------------------------------------------------------------------

drop procedure sp_view_order

create procedure sp_view_order
as
select OrderID,  products.productID, products.product_code, products.product_name, products.product_category, products.product_price, order_quantity, productOrder.totalPrice, productOrder.transactiontype, customers.customer_name, customers.address_, customers.customer_id, User_acc.users_id, productOrder.Order_Date
from productOrder inner join products on productOrder.productID = products.productID inner join User_acc on productOrder.users_id = User_acc.users_id 
 inner join customers on productOrder.customer_id = customers.customer_id
-------------------------------------------------------------------------------------------------------------------- 








------------------------------------------------------------------------------------------------------------------------------
create procedure sp_view_order
as
select OrderID,  products.productID, products.product_code, products.product_name, products.product_category, products.product_price, order_quantity, products.product_description, customers.customer_id, User_acc.users_id
from productOrder inner join products on productOrder.productID = products.productID inner join User_acc on productOrder.users_id = User_acc.users_id 
inner join stocks on productOrder.stocks_id = stocks.stocks_id inner join customers on productOrder.customer_id = customers.customer_id 
 
---------------------------------------------------------------------------------------------------------------------








----------------------------------------------------------------------------------------------------------------

drop procedure sp_add_stocks

create procedure sp_add_stocks
@productId int,
@users_id int,
@stock_in int,
@stock_in_date datetime
as
insert into stocks
values (@productID, @users_id, @stock_in, @stock_in_date)return

-----------------------------------------------------------------------------------------------------------------

drop procedure sp_view_stocks

create procedure sp_view_stocks
    as
    select tblstocks.ProductID, products.product_name, stocks.stock_in, stocks.stock_in_date, [Name] = user_acc.user_Fname + ' ' + User_acc.user_Lname
	from Stocks inner join tblProduct on tblStocks.ProductID = tblProduct.ProductID inner join User_acc on products.UserID = User_acc.users_id

----------------------------------------------------------------------------------------------------------------

drop procedure spViewProductsAndStocks sp_view_pro_stocks

create proc spViewProductsAndStocks
as
select stocks.productID, products.product_name, products.product_description, products.product_price, stock_in from stocks inner join products on stocks.productID = products.productID

----------------------------------------------------------------------------------------------------------------

drop procedure spStockUpdate

create proc spStockUpdate
@productID int,
@stocks_id int,
@stock_in int
as
update stocks set productID = @productID, stock_in = @stock_in
where stocks_ID = @stocks_ID
----------------------------------------------------------------------------------------------------------------

drop procedure sp_update_stockQuantity

create proc sp_update_stockQuantity
@productID int,
@stock_in int
as
update stocks set stock_in = @stock_in where productID = @productID

----------------------------------------------------------------------------------------------------------------

drop procedure sp_stock_delete

create proc sp_stock_delete
@stocks_id int
as
delete from stocks where stocks_id = @stocks_id

----------------------------------------------------------------------------------------------------------------
drop procedure sp_product_stocks

create proc sp_product_stocks
as
select products.ProductID, products.product_name, products.product_price, products.product_stock from products

------------------------------------------------------------------------------------------------------------------------

drop procedure sp_cancel_order

create proc sp_cancel_order
@quantityToRevert int,
@product_ID varchar(max)
as
update products
set product_stock = product_stock + @quantityToRevert where ProductID = @product_ID

---------------------------------------------------------------------------------------------------------------------

drop procedure sp_cancel_order

create proc sp_add_stocks
@quantityToRevert int,
@product_ID varchar(max)
as
update products
set product_stock = PRODUCT_STOCK + @quantityToRevert where ProductID = @product_ID

-----------------------------------------------------------------------------------------------------------------

drop procedure sp_updatestocks	

create procedure sp_updatestocks
 @Product_Name varchar (20),
 @product_stock int

 as
 update products set product_stock = product_stock - @product_stock
 WHERE products.product_name = @product_name

-----------------------------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------------------------

-------------------- Order -------------------------------------

drop table Order_

create table Order_
(
OrderID int primary key identity(1,1),
users_id int foreign key references User_acc(users_id),
OrderDate datetime
)

-----------------------------------------------------------------------------------------------------------------------

drop procedure sp_add_order

create proc spOrderAdd
@ProductID int,
@Quantity int,
@TotalPrice decimal(8,2),
@UserID int,
@OrderDate date
as 
begin
declare @OrderID int
insert into Order_ values(@user_id, date_)
select @OrderID = @@IDENTITY
insert into tblOrderDetails values (@OrderID, @poductID, @Quantity, @TotalPrice)
end

-----------------------------------------------------------------------------------------------------------------------

drpo procedure sp_order_view

create proc sp_order_view
as
select products.productID, products.products_name, Quantity, TotalPrice from OrderDetails inner join products on OrderDetails.productID = products.productID

-----------------------------------------------------------------------------------------------------------------------

create table OrderDetails
(
OrderDetailsID int identity(1,1) primary key,
OrderID int foreign key references tblOrder(OrderID),
productID int foreign key references products(ProductID),
Quantity int not null,
TotalPrice decimal (8,2)
)

-----------------------------------------------------------------------------------------------------------------------

create table StocksInLogs(
StocksInLog int identity(1,1),
ProductID int foreign key references tblProduct(ProductID),
Quantity int,
LogDetails varchar(max),
LogDate datetime,
UserID int foreign key references tblUser(UserID)
)

-----------------------------------------------------------------------------------------------------------------------

create proc sp_stocks_InLogs
@productID int,
@Quantity int,
@LogDetails varchar(max),
@LogDate datetime,
@UserID int
as
insert into sp_stocks_InLogs values( @ProductID, @Quantity, @LogDetails, @LogDate, @UserID)


-----------------------------------------------------------------------------------------------------------------------

drop proc spStocksInView

create proc sp_stocks_InView
as
select stocks.productID, products.product_name, Quantity, LogDetails, LogDate, [Staff Name] = User_acc.user_Fname + ' '+ User_acc.user_Lname from StocksInLogs
inner join products on StocksInLogs.productID= products.productID inner join stocks on stocks.productID = product.productID 
inner join User_acc on stocks.users_id = User_acc.users_id

-----------------------------------------------------------------------------------------------------------------------

create proc sp_Sales_Report
as
select OrderDetails.productID, products.product_name, OrderDetails.Quantity, OrderDetails.TotalPrice, Order.OrderDate, [Staff Name] = user_Fname + ' ' + user_Lname from User_acc
inner join Order_ on User_acc.users_id = Order_.users_id inner join OrderDetails on Order_.OrderID = OrderDetails.OrderID inner join products on OrderDetails.productID = products.productID
select * from OrderDetails

-----------------------------------------------------------------------------------------------------------------------

create proc sp_Quantity_Update
@ProductID int,
@StocksUsed int
as
begin
declare @StocksOld int
set @StocksOld = (select stock_in from stocks where productID = @productID)
update stocks set
stock_in = @StocksOld - @StocksUsed
where productID = @productID
end

-----------------------------------------------------------------------------------------------------------------------
