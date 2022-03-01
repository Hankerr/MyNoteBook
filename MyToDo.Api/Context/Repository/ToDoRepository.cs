using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDo.Api.Context.Repository
{
    //public interface ToDoRepository
    //{
    //    Task<bool> Add(ToDo toDo);
    //    Task<bool> Update(ToDo toDo);
    //    Task<bool> Delete(int id);
    //}

    //public interface IMemoRepository
    //{
    //    ///...
    //}

    public class ToDoRepository : Repository<ToDo>, IRepository<ToDo>
    {
        public ToDoRepository(MyToDoContext dbContext) : base(dbContext)
        {

        }

        //private MyToDoContext doContext;
        //public ToDoRepository(MyToDoContext doContext)
        //{
        //    this.doContext = doContext;
        //}

        //public async Task<bool> Add(ToDo toDo)
        //{
        //    await doContext.ToDo.AddAsync(toDo);
        //    return await doContext.SaveChangesAsync() > 0;
        //}

        //public Task<bool> Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> Update(ToDo toDo)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
