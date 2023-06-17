namespace ChainOfResponsibility;

public class AuthorizationHandler : HandlerBase
{
	private Dictionary<int, int> _entityOwners = new()
	{
		{ 100, 13 },
		{ 101, 14 },
	};
	
	public AuthorizationHandler(HandlerBase? nextHandler) : base(nextHandler) { }
	
	public override void Handle(RequestContext context)
	{
		if (context.Request.UserRole == "Admin")
		{
			nextHandler?.Handle(context);
			return;
		} 
		else if (_entityOwners.TryGetValue(context.Request.EntityId, out int ownerId))
		{
			if (ownerId == context.Request.UserId)
			{
				nextHandler?.Handle(context);
				return;
			}	
		}

		context.Response.IsSuccessful = false;
		context.Response.Message = "User is not authorized";
	}
}