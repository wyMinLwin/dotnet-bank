using System;
namespace MODEL
{
	public class ServiceReponse<T>
	{
		public T? Data { get; set; }
		public string Message { get; set; } = string.Empty;
		public int Response { get; set; } = 200;
	}
}

