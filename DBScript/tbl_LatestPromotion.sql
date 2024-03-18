create table tbl_LatestPromotion
(
PromotionID int primary key not null identity(1,1),
Title varchar(100),
AltText varchar(200),
FileName varchar(100),
IsDefaultFile bit,
IsVideo bit,
IsActive bit,
CreatedBy int,
CreatedAt datetime,
ModifiedBy int,
ModifiedAt datetime
)