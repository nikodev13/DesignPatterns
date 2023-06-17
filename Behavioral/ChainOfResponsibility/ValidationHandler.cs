namespace ChainOfResponsibility;

public class ValidationHandler : HandlerBase
{
	public ValidationHandler(HandlerBase? nextHandler) : base(nextHandler) { }
	
	public override void Handle(RequestContext context)
	{
		if (context.Request.EntityId > 100)
		{
			nextHandler?.Handle(context);
			return;
		}

		context.Response.IsSuccessful = false;
		context.Response.Message = "Validation error: EntityId must be greater than 100.";
	}
}