using System;
using System.Collections.Generic;
using System.Text;

namespace BetterAddHatAndBehavior
{
    public interface IBehavior
    {
        void Execute();

        string BehaviorName
        { get;set;}

        string Description
        { get;set;}
    }

   abstract class Behavior : IBehavior
    {
        #region IBehavior ≥…‘±

        public abstract void Execute();
        

        public string BehaviorName
        {
            get
            {
                return this._BehaviorName;
            }
            set
            {
                this._BehaviorName = value;
            }
        }private string _BehaviorName = string.Empty;

        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this._Description = value;
            }
        }private string _Description = string.Empty;

        #endregion
    }

    class Swimming : Behavior
    {
        public Swimming()
        {
            this.BehaviorName = "Swimming";
        }

        public override void Execute()
        {
            System.Windows.Forms.MessageBox.Show(string.Format("I'm {0}",this.BehaviorName));
        }
    }

    class PlayTennis : Behavior
    {
        public PlayTennis()
        {
            this.BehaviorName = "Play Tennis";
        }
        public override void Execute()
        {
            System.Windows.Forms.MessageBox.Show(string.Format("I {0}",this.BehaviorName));
        }
    }
}
