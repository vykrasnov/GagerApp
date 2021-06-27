using System;
using System.Collections.Generic;
using System.Text;
using Calcium.Messaging;

namespace GagerApp.Core.ViewModel.Messages
{
    /// <summary>
    /// TODO: Needs refactoring! A part of duct-taping for screenshots.
    /// </summary>
    public class MontagAcceptedMessage : MessageBase<int>
    {
        public MontagAcceptedMessage(object sender, int payload) : base(sender, payload)
        {
        }
    }
}
