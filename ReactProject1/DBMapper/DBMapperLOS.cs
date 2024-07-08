using ReactProject1.Models;
using ReactProject1.MyModels;

namespace ReactProject1.DBMapper
{
    public static class DBMapperLOS
    {
        public static LoanListModel FromEntity(LoanTypeMapping mod)
        {
            LoanListModel obj = null;
            if (mod != null)
            {
                obj = new LoanListModel();
                obj.Id = mod.Id;
                obj.LoanTypeName = mod.LoanTypeName;
                obj.ProductName = mod.ProductName;
                obj.EntityType = mod.EntityType;
                obj.InstanceId = mod.InstanceId;
                obj.Loan_Type_Code = mod.LoanTypeCode;
                obj.IsEnabled = mod.IsEnabled;
                obj.LoanTypeId = mod.LoanTypeId.GetValueOrDefault();
            }
            return obj;
        }
    }
}
