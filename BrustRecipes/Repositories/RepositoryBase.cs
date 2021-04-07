using AutoMapper;
using BrustRecipes.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrustRecipes.Repositories
{
    public class RepositoryBase<EntityType> : IRepositoryBase<EntityType> where EntityType : class
    {
        public IMapper Mapper { get; }
        internal IMySQLDataContext _context;

        public RepositoryBase(IMapper Mapper, IMySQLDataContext Context)
        {
            this.Mapper = Mapper;
            _context = Context;
        }
    }
}
