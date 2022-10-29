--create table [MovieBusterDB].[dbo].TicketTypes (
--	Id INT,
--	Title VARCHAR(50),
--	Price DECIMAL(4,2)
--);
insert into [MovieBusterDB].[dbo].TicketTypes (Title, Price) values ('Regular', 5.26);
insert into [MovieBusterDB].[dbo].TicketTypes (Title, Price) values ('VIP', 2.31);
insert into [MovieBusterDB].[dbo].TicketTypes (Title, Price) values ('Discounted', 7.1);