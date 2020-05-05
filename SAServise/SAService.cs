using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using ServerConnectionManager;

namespace SAServise
{
   public partial class SAService : ServiceBase
    {
        private ServerConnectionManager server;
     	public SAService()
            {
    		    InitializeComponent();
            }
   	    protected override void OnStart(string[] args)
           {
   	        server = new ServerConnectionManager();
    	    server.StartServer();
            }
   	    protected override void OnStop()
        {
    	    server.ShotDownServer();
   	    }

    }
}
