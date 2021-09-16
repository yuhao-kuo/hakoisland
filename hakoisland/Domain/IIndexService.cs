using System;

namespace hakoisland.Domain
{
    public interface IIndexModelBuilder<T>
    {
        T GetModel();
    }

    public interface IAccountService
    {
        bool LoginCheck(string text, string dbhash);
        bool UpdateSession();
    }
}