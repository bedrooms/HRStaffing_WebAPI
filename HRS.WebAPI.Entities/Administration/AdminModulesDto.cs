using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.Entities.Administration
{
    public class AdminModulesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IdParent { get; set; }
        public string ConfgIconClass { get; set; }
        public string ConfgRedirectsTo { get; set; }
    }
}
