using ScriptCs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCs.Nest
{
    public class ScriptPack : IScriptPack
    {
		IScriptPackContext IScriptPack.GetContext()
		{
			return new NestClientFactory();
		}

		void IScriptPack.Initialize(IScriptPackSession session)
		{
			var namespaces = new[]
                {
                    "Nest", 
					"ScriptCs.Nest",
                }.ToList();

			namespaces.ForEach(session.ImportNamespace);
		}

		void IScriptPack.Terminate()
		{
		}
    }
}
