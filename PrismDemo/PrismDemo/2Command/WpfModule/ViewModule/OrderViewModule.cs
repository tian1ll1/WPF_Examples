using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Commands;

namespace WpfModule.ViewModule
{
    public class OrderViewModule : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly Services.Order _order;

        public OrderViewModule()
        {
            this._order = new Services.Order();
            this._order.Name = "empty";
            this._order.Age = 0;
            this._order.Quantity = 0;
            this._order.Price = 0;

            this.InitialData();
        }

        public OrderViewModule(Services.Order od)
        {
            this._order = od;

            this.InitialData();
        }

        private void InitialData()
        {
            this.SaveOrderCommand = new DelegateCommand<object>(this.Save, this.CanSave);
            this.PropertyChanged += this.OnPropertyChanged;
        }

        #region properties
        public string UserName
        {
            get { return _order.Name; }
            set { _order.Name = value; NotifyPropertyChanged("UserName"); }
        }


        public int? Quantity
        {
            get { return _order.Quantity; }
            set
            {
                if (_order.Quantity != value)
                {
                    _order.Quantity = value;
                    this.NotifyPropertyChanged("Quantity");
                }
            }
        }

        public decimal? Price
        {
            get { return _order.Price; }
            set
            {
                if (_order.Price != value)
                {
                    _order.Price = value;
                    this.NotifyPropertyChanged("Price");
                }
            }
        }

        public decimal? Age
        {
            get { return _order.Age; }
            set
            {
                if (_order.Age != value)
                {
                    _order.Age = value;
                    this.NotifyPropertyChanged("Age");
                }
            }
        }

        public decimal Total
        {
            get
            {
                if (this.Price != null && this.Quantity != null)
                {
                    return this.Price.Value * this.Quantity.Value;
                }
                return 0;
            }
        }

        #endregion

        private void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            string propertyName = e.PropertyName;
            if (propertyName == "Price" || propertyName == "Quantity")
            {
                this.NotifyPropertyChanged("Total");
            }

          this.SaveOrderCommand.RaiseCanExecuteChanged();
        }

        public DelegateCommand<object> SaveOrderCommand { get; private set; }

        public event EventHandler<DataEventArgs<OrderViewModule>> Saved;

        private void OnSaved(DataEventArgs<OrderViewModule> e)
        {
            EventHandler<DataEventArgs<OrderViewModule>> savedHandler = this.Saved;
            if (savedHandler != null)
            {
                savedHandler(this, e);
            }

            System.Windows.MessageBox.Show("saved " +this.UserName.ToString() + "   " + e.Value.ToString());
        }

        private bool CanSave(object arg)
        {
            return this.Total > 0;
        }
        private void Save(object obj)
        {
           //Save data here

           
            this.OnSaved(new DataEventArgs<OrderViewModule>(this));
        }

       
    }
}
