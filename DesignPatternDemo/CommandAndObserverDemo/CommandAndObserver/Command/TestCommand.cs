using System;
using System.Data;
using System.Collections.Generic;
using System.Text;


namespace CommandAndObserver
{
    class TestCommand : Command
    {
        private TestForm detailForm;

        private Subject _Subject;
        public Subject OriginalSubject
        {
            set {
                _Subject = value;               
            }
        }

        public string UserID
        {
            get { return  _UserID; }
            set { _UserID = value; }
        }private string _UserID = string.Empty;

        public TestCommand(Action prevaction, Action postaction)
            : base(prevaction, postaction)
        {
        }

        public override void Execute()
        {
           if(detailForm == null || detailForm.IsDisposed)
                detailForm = new TestForm(this.UserID);

            this.detailForm.OriginalSubject = _Subject;
            this.detailForm.Show();
        }


    }
}
