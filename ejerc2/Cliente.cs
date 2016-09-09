using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc2
{
    class Cliente
    {   //declaro atributos
        private string iNroDocumento;
        private string iNombre;
        private TipoDocumento iTipoDocumento;
        //declaro constructor
        public Cliente(TipoDocumento pTipoDocumento, string pNroDocumento, string pNombre)
        {
            iNombre = pNombre;
            iNroDocumento = pNroDocumento;
            iTipoDocumento = pTipoDocumento;
        }
        public Cliente() : this(0, "", "") { }
        //declaro propiedades
        public string NroDocumento
        {
            get { return this.iNroDocumento; }
        }
        public string Nombre
        {
            get { return this.iNombre; }
        }
        public TipoDocumento TipoDocumento
        {
            get { return this.iTipoDocumento; }
        }
       
    }
}
