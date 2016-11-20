using MessageRemover.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageRemover.Storage.Avstract
{
    public interface IMessageRepository
    {
        IQueryable<Message> Messages { get; }
        void SaveMessage(string header, string text);

        void RemovieMessage(int messagesID);
    }
}
