namespace ChainOfResponsibility;

public class ResultHandler : HandlerBase
{
	public ResultHandler(HandlerBase? nextHandler) : base(nextHandler) { }
	
	public override void Handle(RequestContext context)
	{
		context.Response.IsSuccessful = true;
		context.Response.Data = "some data";
	}
}