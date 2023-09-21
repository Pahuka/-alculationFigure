# CalculationFigure

SQL скрипт по второй задаче:

```sql
create table Products 
(
	Id int not null IDENTITY PRIMARY KEY,
	Name nvarchar(50) not null
);

create table Categories 
(
	Id int not null IDENTITY PRIMARY KEY,
	Name nvarchar(50) not null
);

create table ProductsCategories 
(
	ProductId int references Products(id),
	CategoryId int references Categories(id),
	constraint ProdCatPK primary key (ProductId, CategoryId)
);

insert into Categories (name) values ('Action');
insert into Categories (name) values ('RPG');
insert into Categories (name) values ('Racing');
insert into Categories (name) values ('Strategy');
insert into Categories (name) values ('Simulator');
insert into Categories (name) values ('Indie');
insert into Categories (name) values ('MMORPG');

insert into Products (name) values ('Gothic');
insert into Products (name) values ('Ragnarok Online');
insert into Products (name) values ('Need for Speed');
insert into Products (name) values ('Space Engineers');
insert into Products (name) values ('Diablo 2');
insert into Products (name) values ('Minecraft');
insert into Products (name) values ('Dwarf Fortress');
insert into Products (name) values ('Код доступа: РАЙ');
insert into Products (name) values ('Worms 2 Armageddon');
insert into Products (name) values ('Noita');

insert into ProductsCategories values 
(1, 1), (1, 2), (2, 1), (2, 2), (2, 7), (3, 3), 
(4, 4), (4, 5), (5, 1), (5, 2), (6, 5), (6, 6), 
(7, 4), (7, 5), (7, 6);

select Products.Name, Categories.Name from Products 
left join ProductsCategories on ProductId=Products.Id 
left join Categories on Categories.Id=CategoryId;
```
