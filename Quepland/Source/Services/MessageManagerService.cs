using System;
using System.Collections.Generic;
using System.Linq;

namespace Quepland
{
    public class MessageManagerService
    {
        public const int MESSAGES_MAX = 12;

        public IReadOnlyCollection<Message> Messages => _messages;
        public event EventHandler StateChanged;
        
        private readonly List<Message> _messages;
        private Message _lastMessage => Messages.Last();
        
        //Helper fields
        private int _repeatMessageCount;
        private string _lastMessageContent;

        public MessageManagerService()
        {
            _messages = new List<Message>();
            _repeatMessageCount = 1;
            _lastMessageContent = string.Empty;
        }

        public void AddMessage(object content) => AddMessageFinal(new Message { Text = content.ToString() });
        public void AddMessage(Message msg) => AddMessageFinal(msg);

        private void AddMessageFinal(Message msg)
        {
            if (_lastMessage.Text == msg.Text)
            {
                _repeatMessageCount++;
                _lastMessage.Text = $"{_lastMessageContent}({_repeatMessageCount})";
            }
            else
            {
                _repeatMessageCount = 1;
                _messages.Add(msg);
                if (_messages.Count >= MESSAGES_MAX)
                {
                    _messages.RemoveAt(0);
                }
            }

            _lastMessageContent = msg.Text;
            StateChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
