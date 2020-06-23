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
