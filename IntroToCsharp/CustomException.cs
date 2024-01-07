using System;
using System.Runtime.Serialization;

/*
 If none of the already existing dotnet exceptions adequately describes the problem
 Example:
 1. I have an asp.net web app
 2. The app should allow the user to have only one logged in session
 3. If the user is already logged in, and if he opens another browser window and tries to login again,
    the app should throw an error stating he is already logged in another browser window
 */

/*
 If you want your ex class obj to work across app domains, then object must be serializable. To make your ex class serializable mark it with
 Serializable attribute and provide a constructor that invokes the base Ex class constructor that takes in SerializationInfo & StreamingContext objects as params.
 */

namespace IntroToCsharp
{
    internal class CustomException
    {
        public static void Func()
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is logged in - no duplicate session allowed");
            }
            catch (UserAlreadyLoggedInException ex) 
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }

    [Serializable]
    public class UserAlreadyLoggedInException: Exception
    {
        public UserAlreadyLoggedInException() 
            : base() 
        {
        }
        public UserAlreadyLoggedInException(string message) 
            : base(message)
        {
        }
        public UserAlreadyLoggedInException(string message, Exception innerException) 
            : base(message, innerException) 
        { 
        }
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
