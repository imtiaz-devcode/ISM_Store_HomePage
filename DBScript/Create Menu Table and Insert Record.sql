
create table tbl_Menu
(
MenuID int primary key not null identity(1,1),
MenuName varchar(200),
CreatedBy int,
CreatedAt datetime,
ModifiedBy int,
ModifiedAt datetime
)



insert into tbl_Menu
(
MenuName,
CreatedBy,
CreatedAt,
ModifiedBy,
ModifiedAt
)
values
(
'Dashboard',
0,
Getdate(),
0,
getdate()
)


insert into tbl_Menu
(
MenuName,
CreatedBy,
CreatedAt,
ModifiedBy,
ModifiedAt
)
values
(
'Report',
0,
Getdate(),
0,
getdate()
)


insert into tbl_Menu
(
MenuName,
CreatedBy,
CreatedAt,
ModifiedBy,
ModifiedAt
)
values
(
'Users',
0,
Getdate(),
0,
getdate()
)