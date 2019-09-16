using RepositoryHelpers.DataBase;
using RepositoryHelpers.DataBaseRepository;

namespace repohelp.Data {
    public sealed class ConnectionBuilder {
        static ConnectionBuilder _instance;
        public static ConnectionBuilder Instance {
            get { return _instance ?? (_instance = new ConnectionBuilder ()); }
        }
        private ConnectionBuilder () {
            Connection = new Connection () {
                Database = RepositoryHelpers.Utils.DataBaseType.SqlServer,
                    ConnectionString = "Data Source=SERVER; " +
                                       "Initial Catalog=BANCO; " +
                                       "User ID=USER; " +
                                       "Password=SENHA; " +
                                       "Persist Security Info=True; " +
                                       "MultipleActiveResultSets=True"
            };
        }
        public Connection Connection { get; }
    }
}