using System;

namespace Api.Controllers
{
    internal class SqlConnection
    {
        public SqlConnection(object connectionString)
        {
            ConnectionString = connectionString;
        }

        public object ConnectionString { get; }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}