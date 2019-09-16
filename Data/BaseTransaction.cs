using repohelp.Data;
using RepositoryHelpers.DataBaseRepository;

namespace repohelp.Data
{
    public class BaseTransaction : CustomTransaction
    {
        public BaseTransaction() :
             base(ConnectionBuilder.Instance.Connection)
        {
           
        }
    }
}