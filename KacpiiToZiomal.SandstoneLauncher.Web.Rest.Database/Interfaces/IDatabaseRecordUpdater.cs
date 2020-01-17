﻿using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces
{
    public interface IDatabaseRecordUpdater
    {
        public void Update<TModel>(DbSet<TModel> dbSet, DbContext context, TModel model) where TModel : class;
    }
}