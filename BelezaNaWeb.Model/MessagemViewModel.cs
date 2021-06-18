using BelezaNaWeb.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BelezaNaWeb.Model
{
    public class MessagemViewModel : IMessageViewModel
    {
        public bool success { get; set; }
        public string message { get; set; }

        public IMessageViewModel SetMessage(bool success, string message)
        {
            this.success = success;
            this.message = message;

            return this;
        }
    }
}
