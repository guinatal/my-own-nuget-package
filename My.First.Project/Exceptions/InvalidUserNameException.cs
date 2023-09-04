namespace My.First.Project.Exceptions;

public class InvalidUserNameException : Exception
{
    public InvalidUserNameException(string message) : base(message) { }
    public InvalidUserNameException(string message, Exception innerException) : base(message, innerException) { }
}