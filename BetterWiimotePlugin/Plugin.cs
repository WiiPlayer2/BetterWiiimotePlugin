using FreePIE.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterWiimotePlugin
{
    [GlobalType(Type = typeof(PluginGlobal))]
    public class Plugin : IPlugin
    {
        public string FriendlyName
        {
            get
            {
                return "BetterWiimote";
            }
        }

        public event EventHandler Started;

        public object CreateGlobal()
        {
            return new PluginGlobal(this);
        }

        public void DoBeforeNextExecute()
        {

        }

        public bool GetProperty(int index, IPluginProperty property)
        {
            return false;
        }

        public bool SetProperties(Dictionary<string, object> properties)
        {
            return false;
        }

        public Action Start()
        {
            return null;
        }

        public void Stop()
        {
        }
    }
}
