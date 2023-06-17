﻿namespace ChainOfResponsibility;

public class RequestContext
{
	public Request Request { get; set; }
	public Response Response { get; set; }
}

public class Response
{
	public bool IsSuccessful { get; set; }
	public string Message { get; set; }
	public object Data { get; set; }
}

public class Request
{
	public string UserRole { get; set; }
	public int UserId { get; set; }
	public int EntityId { get; set; }
}