using System.Collections.Generic;
using PrismDemo.Mvvm.Model;
using Microsoft.Practices.Prism.Mvvm;

namespace PrismDemo.Mvvm.ViewModels
{
    public class QuestionnaireViewModel : BindableBase
    {
        private Questionnaire questionnaire;

        public QuestionnaireViewModel()
        {
            this.Questionnaire = new Questionnaire();
            this.AllColors = new[] { "Red", "Blue", "Green" };
        }

        public Questionnaire Questionnaire
        {
            get { return this.questionnaire; }
            set { SetProperty(ref this.questionnaire, value); }
        }

        public IEnumerable<string> AllColors { get; private set; }

    }

}
