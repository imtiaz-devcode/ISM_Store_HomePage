-- =============================================
-- Author:		<Aqib Ehsan>
-- Create date: <Jan 31,2024>
-- Description:	<Add UpComing Event>
-- =============================================
create PROCEDURE usp_UpcomingEvent_Add 
@EventTitle varchar(100),
@EventDate varchar(100),
@EventLocation varchar(max),
@IsActive bit,
@CreatedBy int
AS
BEGIN

	SET NOCOUNT ON;

	declare @NewDisplayOrder int;

	select top 1 @NewDisplayOrder = OrderNumber from tbl_UpcommingEvent order by OrderNumber desc

	insert into tbl_UpcommingEvent
	(
		EventTitle,
		EventDate,
		EventLocation,
		EventOrginazer,
		IsActive,
		CreatedBy,
		CreatedAt,
		ModifiedBy,
		ModifiedAt,
		OrderNumber
	)
	values
	(
		@EventTitle,
		@EventDate,
		@EventLocation,
		'ISM',
		@IsActive,
		@CreatedBy,
		getdate(),
		@CreatedBy,
		getdate(),
		@NewDisplayOrder + 1
	)

	SELECT SCOPE_IDENTITY() AS LastIdentity;


END

/*

exec usp_UpcomingEvent_Add @EventTitle = 'test',@EventDate = 'test',@EventLocation = 'test',@IsActive = 0,@CreatedBy = 3

*/

