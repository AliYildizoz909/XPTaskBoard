﻿using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTaskTrackDal : EfEntityRepositoryBase<TaskTrack, XPTaskBoardDbContext>, ITaskTrackDal
    {
    }
}
