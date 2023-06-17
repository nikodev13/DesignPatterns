namespace ChainOfResponsibility;

public abstract class HandlerBase : IHandler
{
	protected readonly HandlerBase? nextHandler;

	public HandlerBase(HandlerBase? nextHandler)
	{
		this.nextHandler = nextHandler;
	}
	
	public abstract void Handle(RequestContext context);
}