USE master

--Checking from master.dbo.syslogins if AdvWorks2012 is greater than 0 then 
--then use BEGIN and END statement to start dropping the AdvWorks2012.

If (Select count(*) FROM master.dbo.syslogins WHERE NAME = 'AdvWorks2012') > 0 
BEGIN
drop login AdvWorks2012
USE AdventureWorks2012
DROP USER advWorks2012
USE master
END

--Create sql server login called AdvWorks2012

Create login AdvWorks2012 with password = '!@#$'
alter login  AdvWorks2012 with default_database = AdventureWorks2012

Use AdventureWorks2012

create user advWorks2012 for login advWorks2012

--create Role to add user to have read and write
-- access to all schema.
alter role db_datareader add member advWorks2012
alter role db_datawriter add member AdvWorks2012

-- Deny user's access on HumanResources and Person's schema. 
deny select, update, delete, insert, alter on schema:: HumanResources to AdvWorks2012
deny update, delete, insert, alter on schema:: Person to AdvWorks2012


--A stored procedure that accepts customerID and 
--return all the details of the customers  sales order.
 GO
 alter procedure SalesDetails
 (
    @CustomerID int
 )
 AS
      BEGIN
          select soh.SalesOrderID as [Sales Order ID], soh.OrderDate as [Date Order],soh.ShipDate as [Shipped Date],
	      p.FirstName + '  ' + p.LastName as [Sales Person], pa. City + ' , ' + psp.Name as [Address], soh.TotalDue as [Total Amount Due]
	      from Sales.SalesOrderHeader soh
	      left join Sales.SalesPerson sp
		  on soh.SalesPersonID = sp.BusinessEntityID
		  left join HumanResources.Employee e
		  on soh.SalesPersonID = e.BusinessEntityID
		  left join Person.Person p 
		  on e.BusinessEntityID = p.BusinessEntityID
		  left join Sales.Customer c
		  on soh.CustomerID = c.CustomerID
		  left join Person.Address pa
		  on soh.ShipToAddressID = pa.AddressID
		  left join Person.StateProvince psp
		  on pa.StateProvinceID = psp. StateProvinceID
		  where c.CustomerID = @CustomerID
	 
	 
    END


--A stored procedure to return the 
--list of  active customer.
GO
alter PROCEDURE ActiveCustList

As
    Begin
	    Select  c.CustomerID as [Customer ID],  p.FirstName + '   ' + p.LastName as [Active Customer]
		from Sales.Customer c
		inner join Person.Person p
		on c.PersonID = p.BusinessEntityID

	End

