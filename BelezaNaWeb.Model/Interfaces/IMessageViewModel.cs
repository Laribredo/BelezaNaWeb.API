using System;
using System.Collections.Generic;
using System.Text;

namespace BelezaNaWeb.Model.Interfaces
{
    public interface IMessageViewModel
    {
        public bool success { get; set; }
        public string message { get; set; }

        IMessageViewModel SetMessage(bool success, string message);
    }
}
