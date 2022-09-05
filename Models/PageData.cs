using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYD_s.Models
{
    public class PageData
    {
        public string Style { get; set; }
        public string Button { get; set; }

        public PageData(bool register)
        {
            if(register)
            {
                Style = "blackPage";
                Button = "Повернутися до Анкети";
            }
            else
            {
                Style = "whitePage";
                Button = "Розпочнемо";
            }
        }
    }
}
