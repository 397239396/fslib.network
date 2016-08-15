using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace FSLib.Network.Http
{
	/// <summary>
	/// ��������ͨ��֤����֤���
	/// </summary>
	public class BasicAuthorization : Authorization
	{
		/// <summary>
		/// ��û������û���
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		/// ��û���������
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// ��û����ñ����ʽ
		/// </summary>
		public Encoding TextEncoding { get; set; }

		/// <summary>
		/// ����һ���µĶ���
		/// </summary>
		/// <param name="userName">�û���</param>
		/// <param name="password">����</param>
		public BasicAuthorization(string userName, string password)
		{
			Password = password;
			UserName = userName;
			TextEncoding = System.Text.Encoding.Default;
		}
		/// <summary>
		/// ����Ϣд��HttpWebRequest��
		/// </summary>
		/// <param name="request">����</param>
		/// <param name="httpContext">��ǰ��������</param>
		public override void SetRequest(HttpWebRequest request,
			HttpContext httpContext)
		{
			if (UserName.IsNullOrEmpty() || Password.IsNullOrEmpty())
				return;

			request.Headers.Add(HttpRequestHeader.Authorization, "Basic " + Convert.ToBase64String(TextEncoding.GetBytes(UserName + ":" + Password)));
		}

	}
}
