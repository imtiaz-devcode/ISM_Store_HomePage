-- =============================================
-- Author:		<Aqib Ehsan>
-- Create date: <Jan 22,2024>
-- Description:	<Check User Exist and Login and get User Assigned Menu>
-- =============================================
CREATE PROCEDURE usp_LoginUser
@UserEmail varchar(200),
@UserPassword varchar(200)
AS
BEGIN
	
	SET NOCOUNT ON;

    if exists(select UserID from tbl_User usr with(nolock) where UserEmail = @UserEmail and UserPassword = @UserPassword and IsActive = 1)
	begin

	-- User Name And Default Page URL
	select usr.UserID,usr.UserName,uam.MenuURL
	from tbl_UserAssignedMenu uam with(nolock)
	inner join tbl_User usr with(nolock) on usr.UserID = uam.UserID
	where usr.UserEmail = @UserEmail
	and usr.UserPassword = @UserPassword 
	and usr.IsActive = 1
	and uam.IsDefaultMenuURL = 1


	-- User Related Pages
	select mnu.MenuName,uam.MenuURL
	from tbl_UserAssignedMenu uam with(nolock)
	inner join tbl_User usr with(nolock) on usr.UserID = uam.UserID
	inner join tbl_Menu mnu with(nolock) on mnu.MenuID = uam.MenuID
	where usr.UserEmail = @UserEmail 
	and usr.UserPassword = @UserPassword
	and usr.IsActive = 1
	order by uam.MenuOrder asc

	end

END

