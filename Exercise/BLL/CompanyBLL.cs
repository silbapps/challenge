using Bludata.Models;
using Exercise.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.BLL
{
    public class CompanyBLL
    {
        WebRMContext WebRMContext;

        public CompanyBLL(WebRMContext webRMContext)
        {
            WebRMContext = webRMContext;
        }

        public string Validate(Company empresa)
        {
            StringBuilder validation = new StringBuilder();

            if (string.IsNullOrWhiteSpace(empresa.Nome))
                validation.Append("<br/> Nome é obrigatório. <br/>");
            if (string.IsNullOrWhiteSpace(empresa.CNPJ))
                validation.Append("<br/> CNPJ é obrigatório. <br/>");
            if (string.IsNullOrWhiteSpace(empresa.UF))
                validation.Append("<br/> Estado é obrigatório. <br/>");
            return validation.ToString();
        }

    }
}