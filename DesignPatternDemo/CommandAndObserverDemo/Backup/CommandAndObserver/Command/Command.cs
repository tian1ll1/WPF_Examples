using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CommandAndObserver
{
    /// <summary>
    /// 实现Command设计模式的抽象类
    /// </summary>
    public abstract class Command
    {
        public delegate void Action();

        /// <summary>
        /// 前置动作委托,完成命令的准备和参数检查
        /// </summary>
        private Action prevAction = null;

        /// <summary>
        /// 后置动作委托,完成命令结果的取得和处理
        /// </summary>
        private Action postAction = null;

        /// <summary>
        /// 取消执行标志
        /// </summary>
        private bool cancel = false;

        /// <summary>
        /// 是否取消命令执行属性
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
        /// 默认构造函数
        /// </summary>
        public Command()
        {
        }

        /// <summary>
        /// 构造函数
        ///     设置命令的前置和后置动作。
        /// </summary>
        /// <param name="prevaction">前置动作</param>
        /// <param name="postaction">后置动作</param>
        public Command(Action prevaction, Action postaction)
        {
            this.prevAction = prevaction;
            this.postAction = postaction;
        }

        /// <summary>
        /// 命令执行
        /// </summary>
        public abstract void Execute();


        #region 用户界面接口

        /// <summary>
        /// 实现工具按钮的命令接口
        /// </summary>
        /// <param name="button"></param>
        public void ConnectUI(ToolBarButton button)
        {
            button.Parent.ButtonClick += new ToolBarButtonClickEventHandler(this.HandleUIEvent);
        }

        /// <summary>
        /// 实现菜单项的命令接口
        /// </summary>
        /// <param name="menuItem"></param>
        public void ConnectUI(MenuItem menuItem)
        {
            menuItem.Click += new EventHandler(this.HandleUIEvent);
        }

        /// <summary>
        /// 实现按钮的命令接口
        /// </summary>
        /// <param name="button"></param>
        public void ConnectUI(Button button)
        {
            button.Click += new EventHandler(this.HandleUIEvent);
        }

        /// <summary>
        /// 实现窗体的加载接口
        /// </summary>
        /// <param name="form"></param>
        public void ConnectUI(Form form)
        {
            form.Load += new EventHandler(this.HandleUIEvent);
        }

        /// <summary>
        /// 用户界面事件处理接口
        ///     可以用 += Command.HandleUIEvent 的方式增加事件连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleUIEvent(object sender, EventArgs e)
        {
            //确保命令不被取消执行
            this.cancel = false;

            //执行前置动作
            if (prevAction != null)
            {
                prevAction();
            }

            //判断是否取消执行业务方法
            if (!this.cancel)
            {
                //执行业务方法
                Execute();

                //执行后置动作
                if (postAction != null)
                {
                    postAction();
                }
            }
        }

        #endregion
    }

    #region 示例程序

    /// <summary>
    /// 一个示例含业务方法的命令类
    /// </summary>
    public class DemoCommand : Command
    {

        public DemoCommand(Action prevaction, Action postaction)
            : base(prevaction, postaction)
        {
        }

        //命令参数及返回值变量
        private String queryCondition = null;
        private object results = null;

        /// <summary>
        /// 命令的参数:查询条件
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
        /// 命令返回的结果
        /// </summary>
        public object Results
        {
            get
            {
                return this.results;
            }
        }

        /// <summary>
        /// 业务执行部分
        /// </summary>
        public override void Execute()
        {
            //TODO: 命令的执行
            System.Console.WriteLine("开始执行命令");
            System.Console.WriteLine("调用Subject中的业务方法……");
            System.Console.WriteLine("执行命令……OK");
            this.results = new object();
        }
    }

    /// <summary>
    /// 一个简单的纯用户界面Command,没有业务部分
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
    /// 示例程序调用类
    /// </summary>
    public class DemoProgramOrComponent
    {
        //作为示例的界面元素
        public MenuItem menuItemQuery = new MenuItem("查询");
        public MenuItem menuItemAbout = new MenuItem("关于");
        public Button button = new Button();

        //本组件或程序中包含的所有Command对象的定义在此列出
        public DemoCommand command;
        public DemoUICommand uiCommand;

        /// <summary>
        /// 组件初始化或Form加载时初始化Command对象
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
        /// 前置动作，处理CommandPrepared事件
        /// </summary>
        void CommandPrepared()
        {
            //TODO: 检查Command对象，是否符合执行条件
            bool checkPass = true;
            System.Console.WriteLine("检查");

            //通过检查后执行Command，否则取消执行
            if (!checkPass)
            {
                //取消命令执行
                System.Console.WriteLine("检查不通过");
                command.Cancel = true;
            }
        }

        /// <summary>
        /// 后置动作，处理CommandCompleted事件
        /// </summary>
        void CommandCompleted()
        {
            //TODO: 取得执行结果

            //TODO: 处理结果
            System.Console.WriteLine("结果");
        }

        /// <summary>
        /// 前置动作，显示关于对话框，无后置动作
        /// </summary>
        void About_Action()
        {
            //TODO:显示关于画面
            System.Console.WriteLine("显示关于画面");
        }
    }

    #endregion
}
