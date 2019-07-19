using System.Runtime.Serialization;

namespace restFullApi.model.Base
{
    //Contrato entre atributos
    //E a estrutura da tabela
    //[DataContract]
    public class BaseEntity
    {
        public long? Id { get; set; }
    }
}
