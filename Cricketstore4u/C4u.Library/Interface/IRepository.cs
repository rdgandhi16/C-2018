using System;
using System.Collections.Generic;
using System.Text;

namespace C4u.Library.Interface
{
    public interface IRepository<T> where T:ICutomer
    {
        IEnumerable<T> GetAll();

    }
}
