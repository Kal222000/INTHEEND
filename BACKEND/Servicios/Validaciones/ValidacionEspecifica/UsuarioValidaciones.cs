using System;
using BACKEND.DTO.Envia;
using BACKEND.DTO.Recibe;
using BACKEND.Servicios.Validaciones;

namespace BACKEND.Servicios.Validaciones.ValidacionEspecifica
{
    public class UsuarioValidaciones : ValidacionGeneral
    {
        public UsuarioValidaciones() { }

        public override bool String(string str)
        {
            return base.String(str);
        }

        public override bool Numero(int n)
        {
            return base.Numero(n);
        }

        public override bool Fecha(DateOnly fecha)
        {
            var hoy = DateOnly.FromDateTime(DateTime.Today);

            int edad = hoy.Year - fecha.Year;

            if (fecha > hoy.AddYears(-edad)) { return false; }

            else { return true; }
        }

        public bool ValidarContrasena(string contrasena)
        {
            if (contrasena.Length < 8) { return false; }
            if (String(contrasena) == false) { return false; }

            bool Mayuscula = false;

            bool Numero = false;

            foreach (char c in contrasena)
            {
                if (char.IsUpper(c)) { Mayuscula = true; }

                if (char.IsDigit(c)) { Numero = true; }
            }

            return Mayuscula && Numero;
        }

        public bool Validar(NuevoUsuarioDTO usuario)
        {
            if (String(usuario.Nombre) == false) { return false; }
            if (String(usuario.ApellidoMaterno) == false) { return false; }
            if (String(usuario.ApellidoPaterno) == false) { return false; }
            return true;
        }
    }
}