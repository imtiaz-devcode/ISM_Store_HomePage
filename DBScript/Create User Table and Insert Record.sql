
drop table tbl_User

create table tbl_User
(
UserID int primary key identity(1,1),
UserName varchar(200),
UserEmail varchar(200),
UserPassword varchar(200),
IsActive bit,
CreatedBy int,
CreatedAt datetime,
ModifiedBy int,
ModifiedAt datetime
)




insert into tbl_User 
(
UserName,
UserEmail,
UserPassword,
IsActive,
CreatedBy,
CreatedAt,
ModifiedBy,
ModifiedAt
)
values
(
'Aqib Ehsan',
'aqib.ehsan@imtiaz.com.pk',
'HR_abc@123',
1,
0,
getdate(),
0,
getdate()
)


insert into tbl_User 
(
UserName,
UserEmail,
UserPassword,
IsActive,
CreatedBy,
CreatedAt,
ModifiedBy,
ModifiedAt
)
values
(
'Aqib Ehsan',
'aqib.ehsan@imtiaz.com.pk',
'IT_abc@123',
1,
0,
getdate(),
0,
getdate()
)



insert into tbl_User 
(
UserName,
UserEmail,
UserPassword,
IsActive,
CreatedBy,
CreatedAt,
ModifiedBy,
ModifiedAt
)
values
(
'Aqib Ehsan',
'aqib.ehsan@imtiaz.com.pk',
'MKT_abc@123',
1,
0,
getdate(),
0,
getdate()
)


