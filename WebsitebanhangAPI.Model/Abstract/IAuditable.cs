using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsitebanhangAPI.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string  CreatedBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdatedBy { set; get; }

        string MetaKeywork { set; get; }
        string MetaDescription { set; get; }
        //mô tả meta

        bool Status { set; get; }
    }
}
