using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kingdee.BOS.Core.Bill.PlugIn;
using Kingdee.BOS.Core.DynamicForm.PlugIn.Args;

namespace CloudCloseUOrderTool
{
    public class ButtonEvents: AbstractBillPlugIn
    {
        public override void BarItemClick(BarItemClickEventArgs e)
        {
            //订单退回操作
            base.BarItemClick(e);

            var resultMessage = string.Empty;

            //定义获取表头信息对像
            var docScddIds1 = View.Model.DataObject;
            //获取表头中单据编号信息(注:这里的BillNo为单据编号中"绑定实体属性"项中获得)
            var dhstr = docScddIds1["BillNo"].ToString();

            fcy.Service.CnnStr = "http://172.16.4.252/websys/service.asmx";
            fcy.Service.userdmstr = "feng";
            fcy.Service.passwordstr = "";

            


            //输出结果
            View.ShowMessage(resultMessage);

        }
    }
}
