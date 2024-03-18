-- =============================================
-- Author:		<Aqib Ehsan>
-- Create date: <Jan 31,2024>
-- Description:	<Add New Announcement>
-- =============================================
CREATE PROCEDURE usp_Announcement_Add 
@Subject varchar(200),
@Body varchar(max),
@AnnouncementDate varchar(200),
@IsActive bit,
@CreatedBy int
AS
BEGIN

	SET NOCOUNT ON;

	insert into tbl_Announcement
	(
		Subject,
		Body,
		AnnouncementDate,
		IsActive,
		CreatedBy,
		CreatedAt,
		ModifiedBy,
		ModifiedAt
	)
	values
	(
		@Subject,
		@Body,
		@AnnouncementDate,
		@IsActive,
		@CreatedBy,
		getdate(),
		@CreatedBy,
		getdate()
	)

	SELECT SCOPE_IDENTITY() AS LastIdentity;
END

/*

exec usp_Announcement_Add @Subject = 'test',@Body = 'test',@AnnouncementDate = 'test',@IsActive = 0,@CreatedBy = 2

*/

