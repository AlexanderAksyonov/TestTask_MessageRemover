using MessageRemover.Storage.Avstract;
using MessageRemover.Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestTask_MessageRemover.Models
{
    public class MessageModel
    {

        [DisplayName("Выбрать")]
        public bool Selected { get; set; }

        [HiddenInput(DisplayValue = false)]  
        public int MessageID { get; set; }

        [DisplayName("Заголовок")]
        public string Header{ get; set; }

        [DisplayName("Текст сообщения")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
    }
}