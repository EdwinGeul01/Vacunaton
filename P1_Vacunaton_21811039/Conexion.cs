using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Vacunaton_21811039
{
    class Conexion
    {
        VacunatonEntities db = new VacunatonEntities();

        public bool Validar(string code, string password)
        {
            var result = db.Usuario.Where(e => e.Codigo == code && e.contraseña == password);

            int count = result.ToList().Count();

            return count > 0;
         
        }

        public Usuario Get_User(string code)
        {
            var result = db.Usuario.Where(e => e.Codigo == code );

            return result.First();
        }

        public void CrearUsuario(string codigo,string pass,string n_identidad,string nombreC,string genero_,string correo_,string telefono_ , string rol_ , string centroAsistencia_ , string idvacuna_)
        {

            db.Usuario.Add(new Usuario()
            {
                Codigo = codigo,
                contraseña = pass,
                n_identidad = n_identidad,
                NombreCompleto = nombreC,
                genero = genero_,
                correo = correo_,
                telefono = telefono_,
            });

            db.SaveChanges();

        }

    }
}
