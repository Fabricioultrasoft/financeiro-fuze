using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Model.VO;

namespace Fuze.Domain.dll.Model.VO
{
    [Serializable]
    public class FeriadoVO : AbstractVO 
    {

        public FeriadoTipoVO FeriadoTipo{ get; set; }
        public string Nome { get; set; }
        public DateTime? Data { get; set; }
        public string Motivacao { get; set; }
                                                                      
        public FeriadoVO()                        
        {                                                             
             FeriadoTipo = new FeriadoTipoVO();              
        }                                                            
    }                                                                
}                                                                    
