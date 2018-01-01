using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class Assessment
    {
/*******************************************************************************************************************/
        public DateTime date;
        public string type;
        public int marks;
/*******************************************************************************************************************/
        public Assessment()
        {
            date = new DateTime();
            type = "";
            marks = 0;

        }//close ctor
/*******************************************************************************************************************/
    }//close Assessment
}//close namespace