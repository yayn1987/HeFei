using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Areas.Admin.Models
{
    public class ServerListListViewModel
    {
        public IEnumerable<YuanChen.Model.Server_List> ServiceListInfo { get; set; }

        public NewsInfo NewsInfo { get; set; }
    }
}