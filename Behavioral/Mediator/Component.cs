namespace Mediator;

public abstract class Component
{
	protected IMediator? mediator;

	public void SetMediator(IMediator mediator)
	{
		this.mediator = mediator;
	}
}