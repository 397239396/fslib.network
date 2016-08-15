namespace FSLib.Network.Http
{
	using System;

	/// <summary>
	/// ��¼�¼�����
	/// </summary>
	public class HttpMonitorItemEventArgs : EventArgs
	{
		/// <summary>
		/// ����¼����������
		/// </summary>
		public HttpMonitorItem Item { get; private set; }

		/// <summary>
		/// ���� <see cref="HttpMonitorItemEventArgs" />  ����ʵ��(HttpMonitorItemEventArgs)
		/// </summary>
		/// <param name="item"></param>
		public HttpMonitorItemEventArgs(HttpMonitorItem item)
		{
			Item = item;
		}

	}
}