
using Pidev.data;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public interface IFFraiSer : IService <frais>
    {
       
        IEnumerable<frais> GetFraiByLib(string id);


}
}
