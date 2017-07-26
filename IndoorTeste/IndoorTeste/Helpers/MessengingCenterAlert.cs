using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndoorTeste.Helpers
{
    public class MessengingCenterAlert
    {
        public static void Init()
        {
            var time = DateTime.UtcNow;
        }

        public string Title { get; set; }

        public string Message { get; set; }
        
        public string Cancel { get; set; }
        
        public Action OnCompleted { get; set; }
    }
}
