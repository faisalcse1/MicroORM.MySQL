using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace MicroORM.MySQL
{
    public class DatabaseContext
    {
        private IDbContext _context;
        public DatabaseContext(IDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// MySQL Database server configuration using connectionstring.
        /// </summary>
        /// <param name="connectionString"></param>        
        public DatabaseContext(string connectionString)
        {
            _context = new MySqlContext(connectionString);
        }

        /// <summary>
        /// MySQL Database Configuration
        /// </summary>
        /// <param name="sqlContext"></param>
        public DatabaseContext(MySqlContext sqlContext)
        {
            _context = sqlContext;
        }

        /// <summary>
        /// Configure MySQL Database with connection string.
        /// </summary>
        /// <param name="options"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public DatabaseContext(IOptions<DatabaseContextOptions> options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));
            _context = new MySqlContext(options.Value.ConnectionString);
        }


        /// <summary>
        /// Return a sequence of dynamic objects with properties matching the columns.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public IEnumerable<T> Query<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return _context.Query<T>(query, data, transaction, commandTimeOut, commandType);
        }
        /// <summary>
        /// Return a sequence of dynamic objects with properties matching the columns.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> QueryAsync<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return await _context.QueryAsync<T>(query, data, transaction, commandTimeOut, commandType);
        }

        /// <summary>
        /// Return a dynamic object with properties matching the columns.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public T QueryFirst<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return _context.QueryFirst<T>(query, data, transaction, commandTimeOut, commandType);
        }

        /// <summary>
        /// Return a dynamic object with properties matching the columns.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<T> QueryFirstAsync<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return await _context.QueryFirstAsync<T>(query, data, transaction, commandTimeOut, commandType);
        }

        /// <summary>
        /// Return a dynamic object with properties matching the columns.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public T QuerySingle<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return _context.QuerySingle<T>(query, data, transaction, commandTimeOut, commandType);
        }
        /// <summary>
        /// Return a dynamic object with properties matching the columns.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<T> QuerySingleAsync<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return await _context.QuerySingleAsync<T>(query, data, transaction, commandTimeOut, commandType);
        }

        /// <summary>
        /// Return a dynamic object with properties matching the columns.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public T QueryFirstOrDefault<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return _context.QueryFirstOrDefault<T>(query, data, transaction, commandTimeOut, commandType);
        }
        /// <summary>
        /// Return a dynamic object with properties matching the columns.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<T> QueryFirstOrDefaultAsync<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return await _context.QueryFirstOrDefaultAsync<T>(query, data, transaction, commandTimeOut, commandType);
        }

        /// <summary>
        /// Return a dynamic object with properties matching the columns.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public T QuerySingleOrDefault<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return _context.QuerySingleOrDefault<T>(query, data, transaction, commandTimeOut, commandType);
        }
        /// <summary>
        /// Return a dynamic object with properties matching the columns.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<T> QuerySingleOrDefaultAsync<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return await _context.QuerySingleOrDefaultAsync<T>(query, data, transaction, commandTimeOut, commandType);
        }

        /// <summary>
        /// Execute a command that returns multiple result sets, and access each in turn.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public SqlMapper.GridReader QueryMultiple(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return _context.QueryMultiple(query, data, transaction, commandTimeOut, commandType);
        }
        /// <summary>
        /// Execute a command that returns multiple result sets, and access each in turn.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<SqlMapper.GridReader> QueryMultipleAsync(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return await _context.QueryMultipleAsync(query, data, transaction, commandTimeOut, commandType);
        }

        /// <summary>
        /// Execute parameterized SQL.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public int Execute(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return _context.Execute(query, data, transaction, commandTimeOut, commandType);
        }
        /// <summary>
        /// Execute parameterized SQL.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<int> ExecuteAsync(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return await _context.ExecuteAsync(query, data, transaction, commandTimeOut, commandType);
        }

        /// <summary>
        /// Execute parameterized SQL and return an <see cref="IDataReader"/>.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public IDataReader ExecuteReader(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return _context.ExecuteReader(query, data, transaction, commandTimeOut, commandType);
        }

        /// <summary>
        /// Execute parameterized SQL and return an <see cref="IDataReader"/>.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<IDataReader> ExecuteReaderAsync(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return await _context.ExecuteReaderAsync(query, data, transaction, commandTimeOut, commandType);
        }

        /// <summary>
        /// Execute parameterized SQL that selects a single value.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public object ExecuteScalar(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return _context.ExecuteScalar(query, data, transaction, commandTimeOut, commandType);
        }
        /// <summary>
        /// Execute parameterized SQL that selects a single value.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="data"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeOut"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public async Task<object> ExecuteScalarAsync(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            return await _context.ExecuteScalarAsync(query, data, transaction, commandTimeOut, commandType);
        }
    }
}
