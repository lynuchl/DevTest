using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib1
{
    class EventTest
    {

    }

    public class EventArgs
    {
        public static readonly EventArgs Enpty = new EventArgs();

        public EventArgs() { }
    }

    public class NewMailEventArgs : EventArgs
    {
        private string from;

        private string to;

        private string content;

        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public string Content { get => content; set => content = value; }

        public NewMailEventArgs() { }
    }

    public class MailManager
    {
        public event EventHandler<NewMailEventArgs> NewMail;

        protected virtual void OnNewMail(NewMailEventArgs e)
        {
            if (this.NewMail!=null)
            {
                this.NewMail(this, e);
            }
        }
    }

    public class Fax{
        public Fax(MailManager mailManager)
        {
            mailManager.NewMail += MailManager_NewMail;
        }

        private void MailManager_NewMail(object sender, NewMailEventArgs e)
        {
            //throw new NotImplementedException();

            Console.WriteLine(string.Format("fax receive ,from:{0} to {1} content is :{2}",e.From,e.To ,e.Content));
        }
    }
}
