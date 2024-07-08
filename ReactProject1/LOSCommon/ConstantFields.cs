namespace ReactProject1.LOSCommon
{
    public class ConstantFields
    {
        public static string InstanceGUId;

        public ConstantFields(IConfiguration configuration)
        {
            InstanceGUId = configuration["InstanceGUID"];
        }
    }
}
