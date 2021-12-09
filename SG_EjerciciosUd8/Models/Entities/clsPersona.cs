using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SG_EjerciciosUd8.Models.Entities
{
    public class clsPersona
    {
        #region propiedades privadas
        private String nombre;
        private String apellido1;
        private String apellido2;
        private String direccion;
        #endregion
        #region propiedades públicas
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        #endregion
        #region constructores
        public clsPersona(String nombre, String apellido1, String apellido2, String direccion)
        {
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Direccion = direccion;
        }
        #endregion

    }
}
