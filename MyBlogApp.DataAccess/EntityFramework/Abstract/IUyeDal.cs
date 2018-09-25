﻿using MyBlogApp.Core.DataAccess.Abstract;
using MyBlogApp.Entities.Concrete;

namespace MyBlogApp.DataAccess.EntityFramework.Abstract
{
    public interface IUyeDal
        : IEntityRepository<Uye>
    {
    }
}
