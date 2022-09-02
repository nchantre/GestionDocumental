using GB.Models;
using GD.AccesoDatos.Data.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD.AccesoDatos
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoriaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }

        public IEnumerable<SelectListItem> GetListaCategorias()
        {
            return _db.Categoria.Select(i => new SelectListItem()
            {
                Text = i.Nombre,
                Value = i.Id.ToString()
            });
            throw new NotImplementedException();
        }

        public void update(Categoria categoria)
        {
            var objDesdeDB = _db.Categoria.FirstOrDefault(s => s.Id == categoria.Id);
            objDesdeDB.Nombre = categoria.Nombre;
            objDesdeDB.Orden = categoria.Orden;
            _db.SaveChanges();

        }
    }
}
