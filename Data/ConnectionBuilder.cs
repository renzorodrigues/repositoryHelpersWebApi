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
                    ConnectionString = "Data Source=codorna.fw.landix.com.br;Initial Catalog=SK2_ANDINACL_DSV;Persist Security Info=True;User ID=sa;Password=Masterkey1;MultipleActiveResultSets=True"
            };
        }
        public Connection Connection { get; }
    }
}