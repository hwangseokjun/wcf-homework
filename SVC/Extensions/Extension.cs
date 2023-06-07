using COM.Dtos;
using COM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVC.Extensions
{
    public static class Extension
    {
        public static List<MillSheetResponseDTO> CreateResponseDtos(this IEnumerable<MillCertificateSheet> millCertificateSheets) 
        {
            var responseDtos = new List<MillSheetResponseDTO>(millCertificateSheets.Count());

            foreach (var tmp in millCertificateSheets) 
            {
                var responseDto = new MillSheetResponseDTO
                {
                    Id = tmp.Id,
                    DocMngNo = tmp.DocMngNo,
                    ProjectNo = tmp.ProjectNo,
                    MillSheetNo = tmp.MillSheetNo,
                    IssuedDate = DateTime.Parse(tmp.IssuedDate),
                    CreateAt = DateTime.Parse(tmp.CreatedAt),
                    ModifiedAt = tmp.ModifiedAt is null ? null : (DateTime?)DateTime.Parse(tmp.ModifiedAt)
                };
                responseDtos.Add(responseDto);
            }

            return responseDtos;
        }
    }
}
