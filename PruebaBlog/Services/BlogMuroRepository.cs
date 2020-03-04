using PruebaBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaBlog.Services
{
    public class BlogMuroRepository
    {
        public List<Usuarios> ObtenerTodos()
        {
            using (var db = new BlogMurosContext())
            {
                return db.Usuarios.ToList();
            }
        }

        internal void Crear(Usuarios model)
        {
            using (var db = new BlogMurosContext())
            {
                db.Usuarios.Add(model);
                db.SaveChanges();
            }
        }

    }
}
