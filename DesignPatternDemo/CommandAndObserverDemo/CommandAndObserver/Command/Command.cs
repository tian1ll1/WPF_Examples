using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CommandAndObserver
{
    /// <summary>
    /// ʵ��Command���ģʽ�ĳ�����
    /// </summary>
    public abstract class Command
    {
        public delegate void Action();

        /// <summary>
        /// ǰ�ö���ί��,��������׼���Ͳ������
        /// </summary>
        private Action prevAction = null;

        /// <summary>
        /// ���ö���ί��,�����������ȡ�úʹ���
        /// </summary>
        private Action postAction = null;

        /// <summary>
        /// ȡ��ִ�б�־
        /// </summary>
        private bool cancel = false;

        /// <summary>
        /// �Ƿ�ȡ������ִ������
        /// </summary>
        public bool Cancel
        {
            get
            {
                return this.cancel;
            }
            set
            {
                this.cancel = value;
            }
        }

        /// <summary>
        /// Ĭ�Ϲ��캯��
        /// </summary>
        public Command()
        {
        }

        /// <summary>
        /// ���캯��
        ///     ���������ǰ�úͺ��ö�����
        /// </summary>
        /// <param name="prevaction">ǰ�ö���</param>
        /// <param name="postaction">���ö���</param>
        public Command(Action prevaction, Action postaction)
        {
            this.prevAction = prevaction;
            this.postAction = postaction;
        }

        /// <summary>
        /// ����ִ��
        /// </summary>
        public abstract void Execute();


        #region �û�����ӿ�

        /// <summary>
        /// ʵ�ֹ��߰�ť������ӿ�
        /// </summary>
        /// <param name="button"></param>
        public void ConnectUI(ToolBarButton button)
        {
            button.Parent.ButtonClick += new ToolBarButtonClickEventHandler(this.HandleUIEvent);
        }

        /// <summary>
        /// ʵ�ֲ˵��������ӿ�
        /// </summary>
        /// <param name="menuItem"></param>
        public void ConnectUI(MenuItem menuItem)
        {
            menuItem.Click += new EventHandler(this.HandleUIEvent);
        }

        /// <summary>
        /// ʵ�ְ�ť������ӿ�
        /// </summary>
        /// <param name="button"></param>
        public void ConnectUI(Button button)
        {
            button.Click += new EventHandler(this.HandleUIEvent);
        }

        /// <summary>
        /// ʵ�ִ���ļ��ؽӿ�
        /// </summary>
        /// <param name="form"></param>
        public void ConnectUI(Form form)
        {
            form.Load += new EventHandler(this.HandleUIEvent);
        }

        /// <summary>
        /// �û������¼�����ӿ�
        ///     ������ += Command.HandleUIEvent �ķ�ʽ�����¼�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleUIEvent(object sender, EventArgs e)
        {
            //ȷ�������ȡ��ִ��
            this.cancel = false;

            //ִ��ǰ�ö���
            if (prevAction != null)
            {
                prevAction();
            }

            //�ж��Ƿ�ȡ��ִ��ҵ�񷽷�
            if (!this.cancel)
            {
                //ִ��ҵ�񷽷�
                Execute();

                //ִ�к��ö���
                if (postAction != null)
                {
                    postAction();
                }
            }
        }

        #endregion
    }

    #region ʾ������

    /// <summary>
    /// һ��ʾ����ҵ�񷽷���������
    /// </summary>
    public class DemoCommand : Command
    {

        public DemoCommand(Action prevaction, Action postaction)
            : base(prevaction, postaction)
        {
        }

        //�������������ֵ����
        private String queryCondition = null;
        private object results = null;

        /// <summary>
        /// ����Ĳ���:��ѯ����
        /// </summary>
        public String Condition
        {
            get
            {
                return this.queryCondition;
            }
            set
            {
                this.queryCondition = value;
            }
        }

        /// <summary>
        /// ����صĽ��
        /// </summary>
        public object Results
        {
            get
            {
                return this.results;
            }
        }

        /// <summary>
        /// ҵ��ִ�в���
        /// </summary>
        public override void Execute()
        {
            //TODO: �����ִ��
            System.Console.WriteLine("��ʼִ������");
            System.Console.WriteLine("����Subject�е�ҵ�񷽷�����");
            System.Console.WriteLine("ִ�������OK");
            this.results = new object();
        }
    }

    /// <summary>
    /// һ���򵥵Ĵ��û�����Command,û��ҵ�񲿷�
    /// </summary>
    public class DemoUICommand : Command
    {
        public DemoUICommand(Action prevaction, Action postaction)
            : base(prevaction, postaction)
        {
        }

        public override void Execute()
        {
        }

    }

    /// <summary>
    /// ʾ�����������
    /// </summary>
    public class DemoProgramOrComponent
    {
        //��Ϊʾ���Ľ���Ԫ��
        public MenuItem menuItemQuery = new MenuItem("��ѯ");
        public MenuItem menuItemAbout = new MenuItem("����");
        public Button button = new Button();

        //�����������а���������Command����Ķ����ڴ��г�
        public DemoCommand command;
        public DemoUICommand uiCommand;

        /// <summary>
        /// �����ʼ����Form����ʱ��ʼ��Command����
        /// </summary>
        public void InitCommands()
        {
            command = new DemoCommand(this.CommandPrepared, this.CommandCompleted);
            uiCommand = new DemoUICommand(this.About_Action, null);

            command.ConnectUI(menuItemQuery);
            command.ConnectUI(button);
            uiCommand.ConnectUI(menuItemAbout);
        }

        /// <summary>
        /// ǰ�ö���������CommandPrepared�¼�
        /// </summary>
        void CommandPrepared()
        {
            //TODO: ���Command�����Ƿ����ִ������
            bool checkPass = true;
            System.Console.WriteLine("���");

            //ͨ������ִ��Command������ȡ��ִ��
            if (!checkPass)
            {
                //ȡ������ִ��
                System.Console.WriteLine("��鲻ͨ��");
                command.Cancel = true;
            }
        }

        /// <summary>
        /// ���ö���������CommandCompleted�¼�
        /// </summary>
        void CommandCompleted()
        {
            //TODO: ȡ��ִ�н��

            //TODO: ������
            System.Console.WriteLine("���");
        }

        /// <summary>
        /// ǰ�ö�������ʾ���ڶԻ����޺��ö���
        /// </summary>
        void About_Action()
        {
            //TODO:��ʾ���ڻ���
            System.Console.WriteLine("��ʾ���ڻ���");
        }
    }

    #endregion
}
