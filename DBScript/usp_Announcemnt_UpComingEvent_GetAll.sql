-- =============================================
-- Author:		<Aqib Ehsan>
-- Create date: <Feb 01,2019>
-- Description:	<Get Announcement And Upcoming Event>
-- =============================================
alter PROCEDURE usp_Announcemnt_UpComingEvent_GetAll
(
	@IsActive AS INT = NULL,
	@pagenum AS INT = 1,
	@pagesize AS INT = 50
)
AS
BEGIN
	
	DECLARE @ItemsCount INT = NULL;
	
	
	SELECT * FROM(
		SELECT ROW_NUMBER() OVER(ORDER BY Tbl1.AnnouncementEventDate ASC) AS SNo,Tbl1.* 
		FROM(
			select AE.*,usr.UserName 
			from
				(
					select 
					'Announcement' as AEName,
					Subject as Title,
					Body as Message, 
					AnnouncementDate as AnnouncementEventDate,
					IsActive,
					CreatedBy,
					CreatedAt,
					0 as OrderNumber
					from tbl_Announcement with(nolock)

					union all

					select 
					'Event' as AEName,
					EventTitle as Title, 
					EventLocation as Message, 
					EventDate as AnnouncementEventDate,
					IsActive,
					CreatedBy,
					CreatedAt,
					OrderNumber
					from tbl_UpcommingEvent with(nolock)
				) AE
				inner join tbl_User usr with(nolock) on usr.UserID = AE.CreatedBy
				where AE.IsActive = COALESCE(@IsActive,AE.IsActive)
		)AS Tbl1
	)AS Tbl2
	
	WHERE SNo BETWEEN ((@pagenum - 1) * @pagesize + 1) AND (@pagenum * @pagesize)
	
	SELECT	@ItemsCount = COUNT(AE.Title)
	from
		(
			select 
			Subject as Title,
			IsActive,
			CreatedBy
			from tbl_Announcement with(nolock)

			union all

			select 
			EventTitle as Title,
			IsActive,
			CreatedBy
			from tbl_UpcommingEvent with(nolock)
		) AE
		inner join tbl_User usr with(nolock) on usr.UserID = AE.CreatedBy
		where AE.IsActive = COALESCE(@IsActive,AE.IsActive)
				
	SELECT CAST(CEILING(@ItemsCount * 1.0 / @pagesize) AS INT) Pages, @ItemsCount ItemsCount

END

/*
Exec usp_Announcemnt_UpComingEvent_GetAll 
Exec usp_Announcemnt_UpComingEvent_GetAll @pagesize=10,@IsActive=2
Exec usp_Announcemnt_UpComingEvent_GetAll @pagesize=5,@pagenum=2

*/
