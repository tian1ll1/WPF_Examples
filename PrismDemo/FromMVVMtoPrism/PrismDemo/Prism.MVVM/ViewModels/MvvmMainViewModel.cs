using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PrismDemo.Mvvm.Model;
using Microsoft.Practices.Prism.Commands;

namespace PrismDemo.Mvvm.ViewModels
{
    public class MvvmMainViewModel
    {
        public MvvmMainViewModel()
        {
            this.SubmitCommand = new DelegateCommand<object>(this.OnSubmit);
            this.QuestionnaireViewModel = new QuestionnaireViewModel();
            this.ResetCommand = new DelegateCommand(this.OnReset);
        }

        public ICommand SubmitCommand { get; private set; }

        public ICommand ResetCommand { get; private set; }

        public QuestionnaireViewModel QuestionnaireViewModel { get; set; }

        private void OnSubmit(object obj)
        {
            Debug.WriteLine(this.BuildResultString());
        }

        private void OnReset()
        {
            this.QuestionnaireViewModel.Questionnaire = new Questionnaire();
        }

        private string BuildResultString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Name: ");
            builder.Append(this.QuestionnaireViewModel.Questionnaire.Name);
            builder.Append("\nAge: ");
            builder.Append(this.QuestionnaireViewModel.Questionnaire.Age);
            builder.Append("\nQuestion 1: ");
            builder.Append(this.QuestionnaireViewModel.Questionnaire.Quest);
            builder.Append("\nQuestion 2: ");
            builder.Append(this.QuestionnaireViewModel.Questionnaire.FavoriteColor);
            return builder.ToString();
        }
    }

}
