using COM.DataAccess;
using COM.Dtos;
using IF;
using SVC.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVC
{
    public class TreePathService : ITreePathService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITreePathRepository _treePathRepository;

        public TreePathService()
        {
            _unitOfWork = new UnitOfWork(Settings.Default.CONNECTION_STRING);
            _treePathRepository = _unitOfWork.GetRepository<TreePathRepository>();
        }

        public TreePathService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _treePathRepository = _unitOfWork.GetRepository<TreePathRepository>();
        }

        public bool ExistsChildrenById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TreePathResponseDTO> FindChildrenById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
