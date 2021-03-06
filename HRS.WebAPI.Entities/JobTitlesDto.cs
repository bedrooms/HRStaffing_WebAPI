﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WebAPI.Entities
{
    public class JobTitlesDto
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public Nullable<int> JobIndustryId { get; set; }

        #region Non Entity

        public string JobTitleIndustryName { get; set; }

        #endregion
    }
}
