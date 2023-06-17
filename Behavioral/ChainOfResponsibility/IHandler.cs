namespace ChainOfResponsibility;

public interface IHandler
{
	void Handle(RequestContext context);
}