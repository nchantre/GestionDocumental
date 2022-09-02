using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD.AccesoDatos.Data.Repository
{
     public interface IContenedorTrabajo
    {
        ICategoriaRepository Categoria { get; }
     
        void Save();
    }
}
