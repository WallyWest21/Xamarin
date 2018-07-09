using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ef_repo_sqlite_NET
{
    public class Database_Operations
    {
        public class Task_Repo:GenericRepository<TaskContext2, Task>
        {
            //string dbpath;
            //public Task_Repo(string dbpath)
            //{
            //    this.dbpath = dbpath;

            //}

            public void AddTask (List<Task> TaskList)
            {
                AddRange(TaskList, true);
            }

            public List<Task> GetAllTasks() {

                return GetAll().ToList();
            }
        }

    }
   

   
    public  class GenericRepository<MyContext, MyEntity> where MyEntity : class where MyContext : DbContext, new()
    {
       
        private MyContext _entities = new MyContext();
        public MyContext Context
        {
           
            get {


                return _entities; }
            set { _entities = value; }
        }

        public virtual IQueryable<MyEntity> GetAll()
        {
            IQueryable<MyEntity> query = _entities.Set<MyEntity>();
            return query;
        }

        public IQueryable<MyEntity> FindBy(System.Linq.Expressions.Expression<Func<MyEntity, bool>> predicate)
        {
            IQueryable<MyEntity> query = _entities.Set<MyEntity>().Where(predicate);
            return query;
        }

        public virtual void Add(MyEntity entity)
        {
            _entities.Set<MyEntity>().Add(entity);
        }

        public virtual void AddWithParent<MyParentEntity>(MyEntity entity, MyParentEntity myParentEntity) where MyParentEntity : class
        {
            try
            {
                if (GetParentPrimaryKey(myParentEntity) == null)
                {
                    _entities.Set<MyParentEntity>().Attach(myParentEntity);
                    _entities.Set<MyEntity>().Add(entity);
                }

            }
            catch (Exception)
            {
                Add(entity);
                Save();
            }


        }
        IEnumerable<MyParentEntity> ParentsThatNeedToBeAdded<MyParentEntity>(List<MyParentEntity> NewEntitiesList, List<MyParentEntity> EntitiesList) where MyParentEntity : class
        {
            return null;
        }



        public bool Exists<T>(T entity) where T : class
        {
            return _entities.Set<T>().Local.Any(e => e == entity);
        }

        public MyParentEntity GetParentPrimaryKey<MyParentEntity>(MyParentEntity entity) where MyParentEntity : class
        {
            return _entities.Set<MyParentEntity>().Local.Where(e => e == entity).First();
        }

        public virtual void AddRange(List<MyEntity> MyEntitiesList, bool? SaveToDatabase)
        {
            _entities.Set<MyEntity>().AddRange(MyEntitiesList);
            if (SaveToDatabase == true) { Save(); }
        }
        public virtual void Delete(MyEntity entity)
        {
            _entities.Set<MyEntity>().Remove(entity);
        }

        public virtual void Edit(MyEntity entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            _entities.SaveChangesAsync();
        }

    }

}



