using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCinemaModel.Models;

namespace MegaCinemaData.SampleData
{
    public static class SampleData
    {
        public static void GenerateStatus(MegaCinemaDBContext context)
        {
            //context.Statuss.Add(new Status { StatusID = "NOT", StatusName = "Không hoạt động" });
            context.Statuss.Add(new Status { StatusID = "ACT", StatusName = "Đã kích hoạt" });
            context.Statuss.Add(new Status { StatusID = "NAT", StatusName = "Chưa kích hoạt" });
        }

        public static void GenerateAccountType(MegaCinemaDBContext context)
        {
            context.AccountTypes.Add(new AccountType { TypeName = "Thành viên Mới", TypePoint = 0, TypeDiscount = 0 });
            context.AccountTypes.Add(new AccountType { TypeName = "Thành viên Bạc", TypePoint = 100, TypeDiscount = 5 });
            context.AccountTypes.Add(new AccountType { TypeName = "Thành viên Vip", TypePoint = 300, TypeDiscount = 10 });
        }
    }
}
