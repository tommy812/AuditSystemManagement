using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringApp.Classes
{
    class QuestionAns
    {
   
        public int QuestionId { set; get; }
        public int Intervention_no { set; get; }
        public bool IsCompleted { set; get; }

        public string ActionTaken { set; get; }
        public string Comments { set; get; }
    }
}
