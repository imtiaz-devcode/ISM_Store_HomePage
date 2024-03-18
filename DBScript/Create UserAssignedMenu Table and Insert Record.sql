
select * from tbl_User
select * from tbl_Menu


create table tbl_UserAssignedMenu
(
UserAssignedMenuID int primary key not null identity(1,1),
UserID int,
MenuID int,
MenuURL varchar(500),
IsActive bit,
IsDefaultMenuURL bit,
MenuOrder int,
CreatedBy int,
CreatedAt datetime,
ModifiedBy int,
ModifiedAt datetime
)

insert into tbl_UserAssignedMenu(UserID,MenuID,MenuURL,IsActive,IsDefaultMenuURL,MenuOrder,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt)
values
(
1,
1,
'HRIndex.aspx',
1,
1,
1,
0,
getdate(),
0,
getdate()
)


insert into tbl_UserAssignedMenu(UserID,MenuID,MenuURL,IsActive,IsDefaultMenuURL,MenuOrder,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt)
values
(
1,
2,
'Contact.aspx',
1,
0,
2,
0,
getdate(),
0,
getdate()
)


insert into tbl_UserAssignedMenu(UserID,MenuID,MenuURL,IsActive,IsDefaultMenuURL,MenuOrder,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt)
values
(
2,
1,
'ITIndex.aspx',
1,
0,
1,
0,
getdate(),
0,
getdate()
)


insert into tbl_UserAssignedMenu(UserID,MenuID,MenuURL,IsActive,IsDefaultMenuURL,MenuOrder,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt)
values
(
2,
2,
'Contact.aspx',
1,
1,
2,
0,
getdate(),
0,
getdate()
)


insert into tbl_UserAssignedMenu(UserID,MenuID,MenuURL,IsActive,IsDefaultMenuURL,MenuOrder,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt)
values
(
3,
1,
'MKTIndex.aspx',
1,
1,
1,
0,
getdate(),
0,
getdate()
)

insert into tbl_UserAssignedMenu(UserID,MenuID,MenuURL,IsActive,IsDefaultMenuURL,MenuOrder,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt)
values
(
3,
2,
'Login.aspx',
1,
0,
1,
0,
getdate(),
0,
getdate()
)