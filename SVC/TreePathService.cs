using COM.DataAccess;
using IF;
using SVC.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVC
{
    [GlobalErrorHandlerBehavior(typeof(GlobalErrorHandler))]
    public class TreePathService : ITreePathService
    {
        private readonly ITreePathRepository _treePathRepository; 

        public TreePathService()
        {
            _treePathRepository = new TreePathRepository();
        }

        public TreePathService(ITreePathRepository treePathRepository)
        {
            _treePathRepository = treePathRepository;
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void GetBy()
        {
            throw new NotImplementedException();
        }
    }
}
