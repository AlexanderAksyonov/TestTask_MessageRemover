using MessageRemover.Storage.Avstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageRemover.Storage.Entities
{
    public class Message
    {
        public int MessageID { get; set; }

        public string Header { get; set; }

        public string Text { get; set; }
    }
}
