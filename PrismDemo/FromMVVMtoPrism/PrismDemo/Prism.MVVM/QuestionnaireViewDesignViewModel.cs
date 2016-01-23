using PrismDemo.Mvvm.ViewModels;

namespace PrismDemo.Mvvm
{
    public class QuestionnaireViewDesignViewModel
    {
        public QuestionnaireViewDesignViewModel()
        {
            this.QuestionnaireViewModel = new QuestionnaireViewModel();
        }

        public QuestionnaireViewModel QuestionnaireViewModel { get; set; }
    }
}
