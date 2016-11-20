using MessageRemover.Storage.Avstract;
using MessageRemover.Storage.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTask_MessageRemover.Models;

namespace TestTask_MessageRemover.Controllers
{
    public class MessageController : Controller
    {
        private IMessageRepository repository;

        public MessageController (IMessageRepository messageRepository)
        {
            this.repository = messageRepository;
        }

        public ViewResult MessageList()
        {
            List<MessageModel> model = new List<MessageModel> ();

            model.AddRange(repository.Messages.Select(m => new MessageModel ()
                {
                    MessageID = m.MessageID, 
                    Header = m.Header, 
                    Text = m.Text, 
                    Selected = false
                }).ToList());

            return View(model);
        }

        [HttpPost]
        public ActionResult SendMessage(string Header, string Text)
        {
            repository.SaveMessage(Header, Text);
            return RedirectToAction("MessageList");
        }

        [HttpPost]
        public ActionResult RemoveMessage (ICollection<MessageModel> model)
        {
            foreach (var messId in model.Where(m=>m.Selected).Select(s=>s.MessageID))
            {
                repository.RemovieMessage(messId);
            }
            return RedirectToAction("MessageList");
        }

    }
}
