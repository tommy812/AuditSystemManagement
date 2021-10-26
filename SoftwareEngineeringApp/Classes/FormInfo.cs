using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringApp.Classes
{
    class FormInfo
    {

        public int AuditID { set; get; }
        public DateTime feds { set; get; }
        public string user { set; get; }
        public int superVisorId { set; get; }
        public int TypeID { set; get; }

        public int TemplateID { set; get; }
        public int QuestionID { set; get; }
        public string Question { set; get; }
        public int CategoryID { set; get; }
        public string Category { set; get; }
        public int Intervention_no { set; get; }
        public bool Completed { set; get; }
        public string ActionTaken { set; get; }
        public string Comments { set; get; }

        public void UploadQuestion(){

        }

    }
}
