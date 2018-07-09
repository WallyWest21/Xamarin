using Microsoft.EntityFrameworkCore;
using System;

namespace ef_repo_sqlite
{
    public class Database_Operations
    {
    }

    public abstract class GenericRepository<MyContext, MyEntity> where MyEntity : class where MyContext : DbContext, new() { }
}
