using System;
using System.Collections.Generic;

namespace Secure_User_Database
{
    public class Usuario
    {
        public string name;
        public int id;    

        //public int[] clave;
        public string clave;    

        public Usuario(string name, int id, string clave) {
            this.name = name;
            this.id = id;
            this.clave = clave;
        }

        //sobreescribir el metodo ToString para que se impriman correctamente
        public override string ToString() {
            //return this.name;
            
            return $"{this.name} -  {this.id} - {this.clave}";
        }

    }
}
