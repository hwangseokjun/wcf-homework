using COM.Dtos;
using COM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.Extensions
{
    public static class Extension
    {
        public static List<MillCertificateSheet> ToMillCertificateSheets(this List<RegisterRequestDTO> registerRequestDtos) 
        {
            var millCertificateSheets = new List<MillCertificateSheet>(registerRequestDtos.Count);

            foreach (var requestDto in registerRequestDtos) 
            {
                millCertificateSheets.Add(new MillCertificateSheet(requestDto));
            }

            return millCertificateSheets;
        }

        public static List<MillSheetResponseDTO> ToMillSheetResponseDtos(this IEnumerable<MillCertificateSheet> millCertificateSheets) 
        {
            var millSheetResponseDtos = new List<MillSheetResponseDTO>(millCertificateSheets.Count());

            foreach (var sheet in millCertificateSheets) 
            {
                millSheetResponseDtos.Add(new MillSheetResponseDTO(sheet));
            }

            return millSheetResponseDtos;
        }
    }
}
