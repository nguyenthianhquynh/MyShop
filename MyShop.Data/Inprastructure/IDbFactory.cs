using System;

namespace MyShop.Data.Inprastructure
{
    internal interface IDbFactory : IDisposable
    {
        DBContext init();
    }
}