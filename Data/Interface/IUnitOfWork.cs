using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interface
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
