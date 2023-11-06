using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._0
{
    public class Training
    {
        public string TrainingName { get; set; }
        public string TrainingId { get; set; }
        public string TrainingDetails { get; set; }

        public List<object> Prerequisite { get; set; }

        public DateTime DeadLine { get; set; }
        
        public List<object> requiredByDepartment { get; set; }



        public Training(string trainingName)
        {
            
            
        }




    }
}
