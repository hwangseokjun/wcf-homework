using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Models;
using UI.ServiceReference1;

namespace UI.UserControls
{
    public partial class MillCertificateSheetUserControl : UserControl
    {
        public MillCertificateSheetUserControl()
        {
            InitializeComponent();

            using (var client = new MillCertificateSheetServiceClient())
            {
                MillSheetResponseDTO[] responseDtos = client.GetAll();
                
                foreach (var responseDto in responseDtos) 
                {
                    bsMillCertificateSheet.Add(new MillCertificateSheet 
                    { 
                        Id = responseDto.Id,
                        ProjectNo = responseDto.ProjectNo,
                        MillSheetNo = responseDto.MillSheetNo,
                        IssuedDate = responseDto.IssuedDate,
                        CreatedAt = responseDto.CreateAt,
                        ModifiedAt = responseDto.ModifiedAt,
                        DocMngNo = responseDto.DocMngNo
                    });
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        // TODO: 페이징 쿼리 작성 필요
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
