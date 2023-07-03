using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMultiLanguage
{
    public class Question
    {
        

        public int QuestionId { get; set; }
        public string QuestionName { get; set; }
        private string answer { get; set; } 
        public string Answer {
            get { return answer; }
            set {
                answer = value;
            } }

        public int LangId { get; set; }
    }

    public class Lang
    { public int LangId { get; set;}
    public string LangName { get; set;}
    }
    
}
