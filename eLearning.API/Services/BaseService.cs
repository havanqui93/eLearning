﻿using System;
using eLearning.Domain.Interfaces;

namespace eLearning.API.Services
{
	public class BaseService
	{
		public BaseService(IUnitOfWork unitOfWork)
		{
            UnitOfWork = unitOfWork;
        }

        protected internal IUnitOfWork UnitOfWork { get; set; }
    }
}

