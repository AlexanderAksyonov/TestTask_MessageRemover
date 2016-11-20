using MessageRemover.Storage.Avstract;
using MessageRemover.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageRemover.Storage.Concrete
{
    public class EFMessageRepository : IMessageRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Message> Messages
        {
            get { return context.Messages; }
        }

        public void SaveMessage(string header, string text)
        {
            Message newMessage = new Message (){ Header = header, Text = text, MessageID = 0};
            context.Messages.Add(newMessage);
            context.SaveChanges();
        }

        public void RemovieMessage(int messagesID)
        {
            Message mess = context.Messages.Find(messagesID);
            context.Messages.Remove(mess);
            context.SaveChanges();

        }
    }
}
