-- =============================================
-- Author:		<Aqib Ehsan>
-- Create date: <Feb 12,2024>
-- Description:	<Add Latest Promotion Video/PDF>
-- =============================================
CREATE PROCEDURE usp_LatestPromotion_Add
@Title varchar(100),
@FileName varchar(100),
@IsVideo bit,
@IsActive bit,
@CreatedBy int
AS
BEGIN

	SET NOCOUNT ON

	insert into tbl_LatestPromotion
	(
		Title,
		AltText,
		FileName,
		IsDefaultFile,
		IsVideo,
		IsActive,
		CreatedBy,
		CreatedAt,
		ModifiedBy,
		ModifiedAt
	)
	values
	(
		@Title,
		@Title,
		@FileName,
		0,
		@IsVideo,
		@IsActive,
		@CreatedBy,
		getdate(),
		@CreatedBy,
		Getdate()
	)

	SELECT SCOPE_IDENTITY() AS LastIdentity;
END


/*

exec usp_LatestPromotion_Add @Title = 'Testing',@FileName = 'testing file.gpg',@IsVideo = 1,@IsActive = 0,@CreatedBy = 1

*/

