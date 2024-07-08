using ReactProject1.DBMapper;
using ReactProject1.LOSCommon;
using ReactProject1.Models;
using ReactProject1.MyModels;

namespace ReactProject1.DBQueries
{
    public class DBOpsLOS
    {
        
        public static List<LoanListModel> GetLoanTypeMappingList()
        {
            List<LoanListModel> loanList = new List<LoanListModel>();
            using (ReactProjectContext db = new ReactProjectContext())
            {
                var dbObj = db.LoanTypeMappings.Where(x => x.InstanceId== "a6b2aa1d-652d-4a2e-b37c-4bc566ade0ab" && x.IsEnabled == true).ToList();

                if (dbObj.Count > 0)
                {
                    foreach (var item in dbObj)
                    {
                        var temp = DBMapperLOS.FromEntity(item);
                        loanList.Add(temp);
                    }
                }
            }
            return loanList;
        }

        public static List<ApplicationMaster> GetLoanSubTypes(int loanTypeId)
        {
            List<ApplicationMaster> loanSubtypeList = new List<ApplicationMaster>();
            using (ReactProjectContext db = new ReactProjectContext())
            {
                var dbObj = db.ApplicationMasters.Where(x => x.ProductId == loanTypeId).ToList();

                if(dbObj.Count > 0)
                {
                    loanSubtypeList = dbObj;
                }
            }
            return loanSubtypeList;
        }

    }
}