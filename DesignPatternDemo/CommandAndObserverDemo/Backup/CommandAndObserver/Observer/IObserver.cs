using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

namespace CommandAndObserver
{
    /// <summary>
    /// 主题数据变化的观察者
    /// </summary>
    public interface IObserver
    {
        void Update(object sender, SubjectEventArgs e);
    }

    public class SubjectEventArgs : EventArgs
    {
        public SubjectEventArgs(string str)
        {
            this._Message = str;
        }
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }private string _Message = string.Empty;

        public Subject SubjectObject
        {
            get { return _Subject; }
            set { _Subject = value; }
        }private Subject _Subject = null;
    }

    public abstract class AbsSubject
    {
        public delegate void DataChangedEevntHandler(object sender, SubjectEventArgs e);
        public virtual event DataChangedEevntHandler DataChanged;

        public abstract string SubjectData
        {
            get;
            set;
        }

        public void AddObServer(IObserver observer)
        {
            this.DataChanged += new DataChangedEevntHandler(observer.Update);
        }

        public void RemoveObServer(IObserver observer)
        {
            this.DataChanged -= new DataChangedEevntHandler(observer.Update);
        }

        public void Notify()
        {
            if (DataChanged != null)
                this.DataChanged(this, new SubjectEventArgs(this.SubjectData));
        }
    }

    public class Subject : AbsSubject
    {
        public Subject(string sData)
        {
            this._SubjectData = sData;
        }

        private string _SubjectData = string.Empty;
        public override string SubjectData
        {
            get { return _SubjectData; }
            set { _SubjectData = value; }
        }
    }
}