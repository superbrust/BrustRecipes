using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace BrustRecipes.Controllers
{
    public class WebApiControllerBase : ControllerBase
    {
        /// <summary>
        /// Base class for WebApi Controllers
        /// </summary>
        private IMapper _mapper;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mapper"></param>
        public WebApiControllerBase(IMapper mapper)
        {
            this._mapper = mapper;
        }

        /// <summary>
        /// Mapper Base object
        /// </summary>
        public IMapper mapper
        {
            get { return _mapper; }
            set { _mapper = value; }
        }
    }
}
