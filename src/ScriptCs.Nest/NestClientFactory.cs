using Nest;
using ScriptCs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCs.Nest
{
	public class NestClientFactory : IScriptPackContext
	{
		private ConnectionSettings _connectionSettings;

		public ElasticClient CreateClient(Uri uri, Func<ConnectionSettings, ConnectionSettings> connectionSettingsSetter)
		{
			var connectionSettings = connectionSettingsSetter(new ConnectionSettings(uri));
			return new ElasticClient(connectionSettings);

		}
	}
}
