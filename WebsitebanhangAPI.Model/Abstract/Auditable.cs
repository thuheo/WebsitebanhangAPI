﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsitebanhangAPI.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
       public DateTime? CreatedDate { set; get; }
        [MaxLength(256)]
       public string CreatedBy { set; get; }
       public DateTime? UpdateDate { set; get; }
        [MaxLength(256)]
       public string UpdatedBy { set; get; }

        [MaxLength(256)]
        public string MetaKeywork { set; get; }
        [MaxLength(256)]
        public string MetaDescription { set; get; }
        //mô tả meta

        public bool Status { set; get; }
    }
}
