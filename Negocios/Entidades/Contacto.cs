using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Entidades
{
    public class Contacto
    {
        public int IdContacto;
        public int IdTerceroClienteProveedor;
        public string Nombre;
        public int IdDepartamento;
        public int IdPuesto;
        public int IdTipoTelefono;
        public string Telefono;
        public string Correo;
        public int Estado;

        public Contacto()
        {

        }
        public Contacto(int idContacto,int idTerceroClienteProveedor, string nombre, int idDepartamento, int idPuesto, int idTipoTelefono, string telefono, string correo, int estado)
        {
            IdContacto = idContacto;
            IdTerceroClienteProveedor = idTerceroClienteProveedor;
            Nombre = nombre;
            IdDepartamento = idDepartamento;
            IdPuesto = idPuesto;
            IdTipoTelefono = idTipoTelefono;
            Telefono = telefono;
            Correo = correo;
            Estado = estado;
        }

        public string getGuardar()
        {
            return $"EXEC RegistrarContacto {IdContacto},{IdTerceroClienteProveedor},'{Nombre}',{IdDepartamento},{IdPuesto},{IdTipoTelefono},'{Telefono}','{Correo}',{Estado}";
        }
    }
}
