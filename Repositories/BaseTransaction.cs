using repohelp.Data;
using RepositoryHelpers.DataBaseRepository;

namespace repohelp.Repositories
{
    public class BaseTransaction : CustomTransaction
    {
        public BaseTransaction() :
             base(ConnectionBuilder.Instance.Connection)
        {
           
        }
    }
}