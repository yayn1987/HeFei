using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Collections;

namespace MvcCarManagerment.Service
{
    public class CarService : YuanChenService
    {
        public override IEnumerable<YuanChen.Model.News> GetNews(int top = 0)
        {
            DataSet ds = newsBll.GetList(top, "TypeID = '1743f8a1-f4c0-416d-b07f-56e6424907e7'", "Time desc");
            return newsBll.DataTableToList(ds.Tables[0]);
        }
        public IEnumerable<YuanChen.Model.News_info> GetNew_Info(string listid, int top = 0)
        {
            DataSet ds = infoBll.GetList(top, "TypeID = '1743f8a1-f4c0-416d-b07f-56e6424907e7' and ListID= '" + listid + "'", "Time desc");
            return infoBll.DataTableToList(ds.Tables[0]);
        }

        public IEnumerable<YuanChen.Model.Server_List> GetServer_Info(int top = 0)
        {
            DataSet ds = serverBll.GetList(top, "ParentID = '1743f8a1-f4c0-416d-b07f-56e6424907e7'", "");
            return serverBll.DataTableToList(ds.Tables[0]);
        }
        public YuanChen.Model.News_info GetNewsinfo(long id)
        {
            return infoBll.GetModel(id);
        }

        /// <summary>
        /// 返回高端汽车服务类别的信息
        /// </summary>
        /// <param name="top">条数</param>
        public IEnumerable<YuanChen.Model.Server_List> GetTopCarService()
        {
            return serverBll.GetModelList("ParentID = '1743f8a1-f4c0-416d-b07f-56e6424907e7'");

        }

    }
}