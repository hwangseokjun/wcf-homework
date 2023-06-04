using COM.DataAccess;
using IF;
using SVC.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SVC
{
    // 참고: "리팩터링" 메뉴에서 "이름 바꾸기" 명령을 사용하여 코드 및 config 파일에서 클래스 이름 "MillCertificateSheetService"을 변경할 수 있습니다.
    [GlobalErrorHandlerBehavior(typeof(GlobalErrorHandler))]
    public class MillCertificateSheetService : IMillCertificateSheetService
    {
        private readonly IMillCertificateSheetRepository _millCertificateSheetRepository;

        public MillCertificateSheetService()
        {
            _millCertificateSheetRepository = new MillCertificateSheetRepository();
        }

        public MillCertificateSheetService(IMillCertificateSheetRepository millCertificateSheetRepository)
        {
            _millCertificateSheetRepository = millCertificateSheetRepository;
        }

        public string Add()
        {
            throw new NotImplementedException();
        }

        public string GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetBy(string category, string query)
        {
            throw new NotImplementedException();
        }

        public string Remove()
        {
            throw new NotImplementedException();
        }

        public string Modify()
        {
            throw new NotImplementedException();
        }
    }
}
