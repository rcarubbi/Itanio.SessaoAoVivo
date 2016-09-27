using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Itanio.SessaoAoVivo.WCF.ServicosWeb
{
    [ServiceContract]
    public interface IGravadorArquivoService
    {

        [OperationContract]
        void Salvar(ArquivoDTO arquivo);

        [OperationContract]
        byte[] Obter(string nome);
    }


    [DataContract]
    public class ArquivoDTO
    { 

        [DataMember]
        public string Nome
        {
            get;
            set;
        }

        [DataMember]
        public byte[] Conteudo
        {
            get;
            set;
        }
    }
}
