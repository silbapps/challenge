﻿using Bludata.Models;
using Exercise.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.BLL
{
    public class VendorBLL
    {
        WebRMContext WebRMContext;

        public FornecedorBLL(WebRMContext webRMContext)
        {
            WebRMContext = webRMContext;
        }

        public string Validate(Vendor fornecedor)
        {
            StringBuilder validation = new StringBuilder();

            if (fornecedor.EmpresaID <= 0)
                validation.Append("<br/> Company é obrigatório. <br/>");
            if (string.IsNullOrWhiteSpace(fornecedor.Nome))
                validation.Append("<br/> Nome é obrigatório. <br/>");
            if (fornecedor.CNPJ != null)
            {
                if (string.IsNullOrWhiteSpace(fornecedor.CNPJ))
                    validation.Append("<br/> CNPJ é obrigatório. <br/>");

            }
            else
            {

                if (string.IsNullOrWhiteSpace(fornecedor.CPF))
                    validation.Append("<br/> CPF é obrigatório. <br/>");
                if (string.IsNullOrWhiteSpace(fornecedor.RG))
                    validation.Append("<br/> RG é obrigatório. <br/>");
                if (fornecedor.DataNasc == null)
                    validation.Append("<br/> Data Nascimento é obrigatório. <br/>");
            }

            if (string.IsNullOrWhiteSpace(fornecedor.Telefone))
                validation.Append("<br/> Telefone é obrigatório. <br/>");

            return validation.ToString();
        }

    }
}
