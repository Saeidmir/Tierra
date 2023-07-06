namespace Tierra.Shared.Abstractions.Exceptions;

public abstract class TierraExceptions: Exception
{
    protected TierraExceptions(string message): base(message)
    {
        
    }
}