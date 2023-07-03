using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMultiLanguage
{
    public  class MainWindowViewModel:BaseViewModel
    {
        public List<Lang> LangList { get; set; } = new List<Lang>();
        public List<Question> QueList { get; set; } = new List<Question>();
        public List<Question> QueList1 { get; set; } = new List<Question>();
   
              private Lang selectedLang;
        public Lang SelectedLang
        {
            get { return selectedLang; }

            set
            {

                if (selectedLang != value)
                {

                    foreach (var q in QueList1.Where(q => q.LangId == selectedLang.LangId))
                    {
                        foreach (var q1 in QueList)
                        {
                            if (q.QuestionId == q1.QuestionId)
                            {
                                q1.Answer = q.Answer;

                            }
                        }
                    }

                    selectedLang = value;
                    QueList1 = QueList.Where(x => x.LangId == selectedLang.LangId).ToList();
                    OnPropertyChanged(nameof(QueList1));
                }
            }
        }
        public MainWindowViewModel()
        {
            FillLang();
            FillQuestion();
           
        }

        private void FillQuestion()
        {
            QueList.Add(new Question { QuestionId=1,LangId=1,QuestionName= "What is your Highest qualification?" });
            QueList.Add(new Question { QuestionId=1,LangId=2,QuestionName= "आपकी उच्चतम योग्यता क्या है?" });
            QueList.Add(new Question { QuestionId=1,LangId=3,QuestionName= "Cuál es su calificación más alta?" });
            QueList.Add(new Question { QuestionId=2,LangId=1,QuestionName= "Why should we hire you?" });
            QueList.Add(new Question { QuestionId=2,LangId=2,QuestionName= "हम आपको नौकरी क्यों दें?" });
            QueList.Add(new Question { QuestionId=2,LangId=3,QuestionName= "Porque deberíamos contratarte?" });
            QueList.Add(new Question { QuestionId=3,LangId=1,QuestionName= "What’s your dream job?" });
            QueList.Add(new Question { QuestionId=3,LangId=2,QuestionName= "आप भविष्य मे क्या नौकरी करना चाहते हैं?" });
            QueList.Add(new Question { QuestionId=3,LangId=3,QuestionName= "Cuál es el trabajo de tus sueños?" });


        }

        private void FillLang()
        {
            LangList.Add(new Lang { LangId=1,LangName="English" });
            LangList.Add(new Lang { LangId=2,LangName="Hindi" });
            LangList.Add(new Lang { LangId=3,LangName= "Spanish " });
        }
    }
}
