using Exercise.Models;

namespace Bludata.Models
{
    public class Company : BaseModel
    {
        public string UF { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
    }
}
