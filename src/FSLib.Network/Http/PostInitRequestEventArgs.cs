namespace FSLib.Network.Http
{
	using System;
	using System.Net;

	/// <summary>
	/// �����¼� <see cref="HttpSetting.PostInitRequest"/> ������
	/// </summary>
	public class PostInitRequestEventArgs : EventArgs
	{
		/// <summary>
		/// ���������� <see cref="HttpWebRequest"/>
		/// </summary>
		public HttpWebRequest Request { get; private set; }

		/// <summary>
		/// ���������� <see cref="HttpContext"/>
		/// </summary>
		public HttpContext HttpContext { get; private set; }

		/// <summary>
		/// ���������� <see cref="HttpClient"/>
		/// </summary>
		public HttpClient HttpClient { get; private set; }

		/// <summary>
		/// ���� <see cref="PostInitRequestEventArgs" />  ����ʵ��(PostInitRequestEventArgs)
		/// </summary>
		/// <param name="request"></param>
		/// <param name="httpContext"></param>
		/// <param name="httpClient"></param>
		public PostInitRequestEventArgs(HttpWebRequest request, HttpContext httpContext, HttpClient httpClient)
		{
			Request = request;
			HttpContext = httpContext;
			HttpClient = httpClient;
		}
	}
}