create table TicketTypes (
	Id INT,
	Price DECIMAL(4,2),
	Title VARCHAR(50)
);
insert into TicketTypes (Id, Price, Title) values (1, 5.26, 'Regular');
insert into TicketTypes (Id, Price, Title) values (2, 2.31, 'VIP');
insert into TicketTypes (Id, Price, Title) values (3, 7.1, 'Discounted');