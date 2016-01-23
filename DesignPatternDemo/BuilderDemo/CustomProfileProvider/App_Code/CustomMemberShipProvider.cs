using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// CustomMemberShipProvider 的摘要说明
/// </summary>
public class CustomMemberShipProvider : MembershipProvider
{
	public CustomMemberShipProvider()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    public override string ApplicationName
    {
        get
        {
            throw new Exception("The method or operation is not implemented.");
        }
        set
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }

    public override bool ChangePassword(string username, string oldPassword, string newPassword)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override bool DeleteUser(string username, bool deleteAllRelatedData)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override bool EnablePasswordReset
    {
        get { throw new Exception("The method or operation is not implemented."); }
    }

    public override bool EnablePasswordRetrieval
    {
        get { throw new Exception("The method or operation is not implemented."); }
    }

    public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override int GetNumberOfUsersOnline()
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override string GetPassword(string username, string answer)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override MembershipUser GetUser(string username, bool userIsOnline)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override string GetUserNameByEmail(string email)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override int MaxInvalidPasswordAttempts
    {
        get { throw new Exception("The method or operation is not implemented."); }
    }

    public override int MinRequiredNonAlphanumericCharacters
    {
        get { throw new Exception("The method or operation is not implemented."); }
    }

    public override int MinRequiredPasswordLength
    {
        get { throw new Exception("The method or operation is not implemented."); }
    }

    public override int PasswordAttemptWindow
    {
        get { throw new Exception("The method or operation is not implemented."); }
    }

    public override MembershipPasswordFormat PasswordFormat
    {
        get { throw new Exception("The method or operation is not implemented."); }
    }

    public override string PasswordStrengthRegularExpression
    {
        get { throw new Exception("The method or operation is not implemented."); }
    }

    public override bool RequiresQuestionAndAnswer
    {
        get { throw new Exception("The method or operation is not implemented."); }
    }

    public override bool RequiresUniqueEmail
    {
        get { throw new Exception("The method or operation is not implemented."); }
    }

    public override string ResetPassword(string username, string answer)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override bool UnlockUser(string userName)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override void UpdateUser(MembershipUser user)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override bool ValidateUser(string username, string password)
    {
        return (username.Equals("test") && password.Equals("test"));            
        
    }
}
