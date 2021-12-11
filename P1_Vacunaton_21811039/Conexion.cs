using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Vacunaton_21811039
{
    class Conexion
    {
        VacunatonEntities db = new VacunatonEntities();

        public bool Validar_Usuario(string code, string password)
        {
            var result = db.Usuario.Where(e => e.Codigo == code && e.contraseña == password);

            int count = result.ToList().Count();

            return count > 0;

        }




        ////Roles
        //public List<roles> GetAllRoles()
        //{
        //    return db.roles.ToList();
        //}


        //PARA VACUNAS
        public List<Vacunas> GetAllVacunas()
        {
            return db.Vacunas.ToList();
        }

        public Vacunas Getvacuna(string n)
        {

            var result = db.Vacunas.Where(e => e.CodVacuna == n);
            if (result.Count() == 0) { return null; }
            return result.First();


        }

        public Vacunas Getvacuna4Name(string n)
        {

            var result = db.Vacunas.Where(e => e.nombre == n);
            if (result.Count() == 0) { return null; }
            return result.First();


        }

        public void CrearVacuna(string cod, string nombre, string fabricante_, DateTime fecha_e, DateTime fecha_v, string numero_lote, string estatus_)
        {
            if (Getvacuna(cod) != null)
            {
                MessageBox.Show("CODIGO OCUPADO POR OTRA VACUNA!!");
                return;
            }

            db.Vacunas.Add(new Vacunas()
            {
                CodVacuna = cod,
                nombre = nombre,
                fabricante = fabricante_,
                fechaEmision = fecha_e,
                fechaVencimiento = fecha_v,
                numerolote = numero_lote,
                estatus = estatus_
            });

            db.SaveChanges();

            MessageBox.Show("VACUNA CREADA CON EXITO!!");

        }

        public void ModificarVacuna(string cod, string nombre, string fabricante_, DateTime fecha_e, DateTime fecha_v, string numero_lote, string estatus_)
        {
            Vacunas vacuna = Getvacuna(cod);

            vacuna.nombre = nombre;
            vacuna.fabricante = fabricante_;
            vacuna.fechaEmision = fecha_e;
            vacuna.fechaVencimiento = fecha_v;
            vacuna.numerolote = numero_lote;
            vacuna.estatus = estatus_;


            db.SaveChanges();
        }


        public void DeleteVacuna(string codigo)
        {
            Vacunas vacuna = Getvacuna(codigo);

            foreach (Usuario u in db.Usuario.ToList())
            {
                if (u.Vacunas == vacuna)
                {
                    u.IdVacunas = null;
                }
            }
            foreach (VacunaXCiudadanos u in db.VacunaXCiudadanos.ToList())
            {
                if (u.CodVacuna == vacuna.CodVacuna)
                {
                    u.Vacunas = null;
                }
            }


            db.Vacunas.Remove(vacuna);
            db.SaveChanges();

        }






        // PARA USUARIOS

        public Usuario Get_User(string code)
        {
            var result = db.Usuario.Where(e => e.Codigo == code);

            if (result.Count() == 0) { return null; }
            return result.First();
        }


        public void CrearUsuario(string codigo, string pass, string n_identidad, string nombreC, string genero_, string correo_, string telefono_, string rol_, string centroAsistencia_, string nombre_vacuna)
        {

            if (Get_User(codigo) != null)
            {
                MessageBox.Show("CODIGO OCUPADO POR OTRO USUARIO!!");
                return;
            }


            Vacunas vtemp = Getvacuna4Name(nombre_vacuna);
            CentroAsistencia catemp = GetCentroAsistencia4name(centroAsistencia_);

            string cod_vac = vtemp != null ? vtemp.CodVacuna : null;
            string cod_Centro = catemp != null ? catemp.idcentro : null;



            db.Usuario.Add(new Usuario()
            {
                Codigo = codigo,
                contraseña = pass,
                n_identidad = n_identidad,
                NombreCompleto = nombreC,
                genero = genero_,
                correo = correo_,
                telefono = telefono_,
                IdVacunas = cod_vac,
                rol = rol_,
                IdCentroAsistencia = cod_Centro

            });

            db.SaveChanges();

            MessageBox.Show("Usuario creado exitosamente!!");

        }


        public void ModfUsuario(string codigo, string pass, string n_identidad, string nombreC, string genero_, string correo_, string telefono_, string rol_, string centroAsistencia_, string idvacuna_)
        {
            Usuario user = Get_User(codigo);

            user.NombreCompleto = nombreC;
            user.contraseña = pass;
            user.n_identidad = n_identidad;
            user.telefono = telefono_;
            user.rol = rol_;
            user.IdCentroAsistencia = GetCentroAsistencia4name(centroAsistencia_) != null ? GetCentroAsistencia4name(centroAsistencia_).idcentro : null;
            user.IdVacunas = Getvacuna4Name(idvacuna_) != null ? Getvacuna4Name(idvacuna_).CodVacuna : null;
            user.genero = genero_;

            db.SaveChanges();
        }


        public void DeleteUsuario(string codigo)
        {
            Usuario user = Get_User(codigo);

            db.Usuario.Remove(user);
            db.SaveChanges();

        }


        //PARA CENTRO DE ASISTENCIA

        public void CrearCentroAsistencia(string id, string nombre, string direccion_, string ciudad_, string numero_pacientes, string cantmedicos_, string cant_Enfermeras, string estatus)
        {
            if (GetCentroAsistencia(id) != null)
            {
                MessageBox.Show("Id de Centro de asistencia ya existe!!");
                return;
            }

            db.CentroAsistencia.Add(new CentroAsistencia()
            {
                idcentro = id,
                Nombre = nombre,
                direccion = direccion_,
                ciudad = ciudad_,
                numeroPacientes = Convert.ToInt32(numero_pacientes),
                cantMedicos = Convert.ToInt32(cantmedicos_),
                cantEnfermeras = Convert.ToInt32(cant_Enfermeras),
                estatus = estatus

            });
            db.SaveChanges();

            MessageBox.Show("Centro de Asistencia Creado");
        }

        public CentroAsistencia GetCentroAsistencia4name(string name)
        {
            var result = db.CentroAsistencia.Where(e => e.Nombre == name);
            if (result.Count() == 0) { return null; }
            return result.First();

        }

        public CentroAsistencia GetCentroAsistencia(string n)
        {
            var result = db.CentroAsistencia.Where(e => e.idcentro == n);
            if (result.Count() == 0) { return null; }
            return result.First();


        }

        public List<CentroAsistencia> GetAllCentroA()
        {
            return db.CentroAsistencia.ToList();
        }

        public void ModfCentroAsistencia(string id, string nombre, string direccion_, string ciudad_, string numero_pacientes, string cantmedicos_, string cant_Enfermeras, string estatus)
        {
            CentroAsistencia CA = GetCentroAsistencia(id);

            CA.idcentro = id;
            CA.Nombre = nombre;
            CA.direccion = direccion_;
            CA.ciudad = ciudad_;
            CA.numeroPacientes = Convert.ToInt32(numero_pacientes);
            CA.cantMedicos = Convert.ToInt32(cantmedicos_);
            CA.cantEnfermeras = Convert.ToInt32(cant_Enfermeras);
            CA.estatus = estatus;

            db.SaveChanges();
        }


        public void DeleteCentroAsistencia(string codigo)
        {
            CentroAsistencia CA = GetCentroAsistencia(codigo);

            foreach (Usuario u in db.Usuario.ToList())
            {
                if (u.CentroAsistencia == CA)
                {
                    u.IdVacunas = null;
                }
            }

            foreach (VacunaXCiudadanos u in db.VacunaXCiudadanos.ToList())
            {
                if (u.IdCentroAsistencia == CA.idcentro)
                {
                    u.IdCentroAsistencia = null;
                }
            }

            db.CentroAsistencia.Remove(CA);
            db.SaveChanges();

        }


        //PARA CIUDADANOS



        public Ciudadanos GetCiudadano(string code)
        {
            var result = db.Ciudadanos.Where(e => e.IdCiudadano == code);

            if (result.Count() == 0) { return null; }
            return result.First();
        }

        public List<Ciudadanos> GetAllCiudadanos()
        {
            return db.Ciudadanos.ToList();
        }

        public void CrearCiudadano(string id, string nombre, DateTime fechaNacimiento, string genero, string telefono, string direccion, string estado_civil, List<string> Enfermedades)
        {
            if (GetCiudadano(id) != null)
            {
                MessageBox.Show("Id de Ciudadano ya existe!!");
                return;
            }

            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (DateTime.Now.Month < fechaNacimiento.Month)
            {
                edad -= 1;
            }
            else if (DateTime.Now.Month == fechaNacimiento.Month && DateTime.Now.Day < fechaNacimiento.Day)
            {
                edad -= 1;
            }




            db.Ciudadanos.Add(new Ciudadanos()
            {
                IdCiudadano = id,
                nombreCompleto = nombre,
                fechaNacimiento = fechaNacimiento,
                genero = genero,
                edad = edad,
                telefono = telefono,
                direccion = direccion,
                estadoCivil = estado_civil,
            });

         

            db.SaveChanges();

            for (int i = 0; i < Enfermedades.Count; i++)
            {
                EstablecerCiudXEnf(id, Enfermedades[i]);
            }

            MessageBox.Show("Ciudadano Creado");
        }

        public void ModfCiudadano(string id, string nombre, DateTime fechaNacimiento, string genero, string telefono, string direccion, string estado_civil, List<string> Enfermedades)
        {
            Ciudadanos ciu = GetCiudadano(id);


            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (DateTime.Now.Month < fechaNacimiento.Month)
            {
                edad -= 1;
            }
            else if (DateTime.Now.Month == fechaNacimiento.Month && DateTime.Now.Day < fechaNacimiento.Day)
            {
                edad -= 1;
            }



            ciu.IdCiudadano = id;
            ciu.nombreCompleto = nombre;
            ciu.fechaNacimiento = fechaNacimiento;
            ciu.edad = edad;
            ciu.genero = genero;
            ciu.telefono = telefono;
            ciu.direccion = direccion;
            ciu.estadoCivil = estado_civil;


        

            db.SaveChanges();

            for (int i = 0; i < Enfermedades.Count; i++)
            {
                EstablecerCiudXEnf(id, Enfermedades[i]);
            }

            MessageBox.Show("Ciudadano Modificado con exito");
        }

        public void EliminarCiudadanos(string id)
        {
            Ciudadanos Ciudadano = GetCiudadano(id);

            Ciudadano.EnfermedadesBases.Clear();



            db.Ciudadanos.Remove(Ciudadano);
            db.SaveChanges();
        }



        //Enfermedades

        public EnfermedadesBases GetEnfermedad(string code)
        {
            var result = db.EnfermedadesBases.Where(e => e.IdEnfermdad == code);
            if (result.Count() == 0) { return null; }

            return result.First();



        }


        public EnfermedadesBases GetEnfermedad4name(string name)
        {
            var result = db.EnfermedadesBases.Where(e => e.nombreEnfermedad == name);
            if (result.Count() == 0) { return null; }

            return result.First();



        }
        public void CrearEnfermedades(string code, string name, string desc)
        {
            try
            {

                if(GetEnfermedad(code) != null)
                {
                    MessageBox.Show("codigo de enfermedad ya ocupado !");
                    return;
                }

                EnfermedadesBases enfermedad = new EnfermedadesBases();
                enfermedad.Descripcion = desc;
                enfermedad.IdEnfermdad = code;
                enfermedad.nombreEnfermedad = name;

                db.EnfermedadesBases.Add(enfermedad);

                db.SaveChanges();

                MessageBox.Show("Enfermedad registrada exitosamente!!");

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }


        }

        public List<EnfermedadesBases> GetAllEnfermedades()
        {
            return db.EnfermedadesBases.ToList();
        }

        public void Delete_Enfermedades(List<string> names_enf)
        {

            foreach (string n in names_enf)
            {
                EnfermedadesBases e = GetEnfermedad4name(n);
                e.Ciudadanos.Clear();
                db.EnfermedadesBases.Remove(e);
            
            }

            db.SaveChanges();

            MessageBox.Show("enfermedades eliminadas con exito");
        }

        public void EstablecerCiudXEnf(string ciud_cod, string enfer_name)
        {
            Ciudadanos ciu = GetCiudadano(ciud_cod);
            EnfermedadesBases enf = GetEnfermedad4name(enfer_name);

            if (enf != null)
            {

                ciu.EnfermedadesBases.Add(enf);

            }

            db.SaveChanges();
        }



        //vacunas por ciudadanos

        public List<VacunaXCiudadanos> GetVacunasXCiudadanos4id(string code)
        {
            var result = db.VacunaXCiudadanos.Where(e => e.IdCiudadano == code);
            if (result.Count() == 0) { return null; }

            return result.ToList();


        }

        public void CrearVacunaXCiudadano(string idCiudadano , string n_dosis , string id_centro , string cod_vac , DateTime fecha_aplicacion)
        {
            try
            {

                string cod_Vacc = Getvacuna4Name(cod_vac).CodVacuna;

                db.VacunaXCiudadanos.Add(new VacunaXCiudadanos
                {
                    IdCiudadano = idCiudadano,
                    IdCentroAsistencia = GetCentroAsistencia4name(id_centro).idcentro,
                    CodVacuna = cod_Vacc,
                    NumeroDosis = Convert.ToInt32(n_dosis),
                    Fecha_Aplicacion = fecha_aplicacion


                });

                db.SaveChanges();

                MessageBox.Show("Vacuna Aplicada con exito");


            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
          


        }

        public void EliminarVacunaXCiudadano(string idCiudadano, string n_dosis)
        {
            try
            {

            Ciudadanos ciu = GetCiudadano(idCiudadano);

            if(ciu == null)
            {
                MessageBox.Show("ciudadano no encontrado");
            }

            if(n_dosis == "ALL")
            {
                ciu.VacunaXCiudadanos.Clear();
            }
            else
            {
                foreach (VacunaXCiudadanos ciuxvac in ciu.VacunaXCiudadanos)
                {
                    if (ciuxvac.NumeroDosis == Convert.ToInt32(n_dosis))
                    {
                        ciu.VacunaXCiudadanos.Remove(ciuxvac);
                            break;
                    }
                }
            }

            db.SaveChanges();

                MessageBox.Show("Registro De vacunacion Eliminado !!");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

    }
}
