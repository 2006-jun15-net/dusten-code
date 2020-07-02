-- Basic exercises:

-- 1
SELECT * FROM Customer WHERE Country != 'USA';

-- 2
SELECT * FROM Customer WHERE Country = 'Brazil';

-- 3
SELECT * FROM Employee WHERE Title = 'Sales Support Agent';

-- 4
SELECT BillingCountry FROM Invoice;

-- 5
SELECT SUM(Total), COUNT(*) FROM Invoice WHERE YEAR(InvoiceDate) = 2009;

-- (CHALLENGE)
SELECT YEAR(InvoiceDate), COUNT(*), SUM(Total) FROM Invoice GROUP BY YEAR(InvoiceDate);

-- 6
SELECT SUM(Quantity) FROM InvoiceLine WHERE InvoiceId = 37;

-- 7 
SELECT BillingCountry, COUNT(*) FROM Invoice GROUP BY BillingCountry;

-- 8
SELECT BillingCountry, SUM(Total) FROM Invoice GROUP BY BillingCountry ORDER BY SUM(Total) DESC;

-- Join Exercises:

-- 1
SELECT CustomerId FROM Customer WHERE Country = 'Brazil';
SELECT * FROM Invoice RIGHT JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE Customer.Country = 'Brazil';

-- 2
-- SELECT * FROM Invoice

-- 3


-- 4
SELECT TOP 1 Employee.EmployeeId, COUNT(Invoice.InvoiceId) as Sales 
	FROM Employee
	LEFT JOIN Customer ON Employee.EmployeeId = Customer.SupportRepId
	RIGHT JOIN Invoice ON Invoice.CustomerId = Customer.CustomerId
	WHERE YEAR(Invoice.InvoiceDate) = 2009
	GROUP BY Employee.EmployeeId ORDER BY COUNT(Invoice.InvoiceId) DESC;

-- exercises

-- solve these with a mixture of joins, subqueries, CTE, and set operators.
-- solve at least one of them in two different ways, and see if the execution
-- plan for them is the same, or different.

-- 1. which artists did not make any albums at all?
SELECT Name FROM Artist WHERE ArtistId NOT IN (SELECT ArtistId FROM Album);

-- 2. which artists did not record any tracks of the Latin genre?
SELECT * FROM Artist WHERE Name NOT IN (SELECT Artist.Name FROM Artist 
	JOIN Album ON Artist.ArtistId = Album.ArtistId
	JOIN Track ON Album.AlbumId = Track.AlbumId
	JOIN Genre ON Track.GenreId = Genre.GenreId
	WHERE Genre.Name = 'Latin');

-- 3. which video track has the longest length? (use media type table)
SELECT TOP 1 t.* FROM Track AS t 
	LEFT JOIN MediaType AS m ON t.MediaTypeId = m.MediaTypeId
	WHERE m.Name LIKE '%video%' ORDER BY t.Milliseconds DESC;

-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)
SELECT CustomerId, FirstName, LastName FROM Customer 
	WHERE City IN (
		SELECT City FROM Employee WHERE ISNULL(ReportsTo, 0) = 0
	) ORDER BY CustomerId;

-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?

-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.