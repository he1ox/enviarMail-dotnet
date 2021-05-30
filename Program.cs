using System;
using System.Net;
using System.Net.Mail;


namespace Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Antes de ejecutar esto, es necesario que agregues tu correo en
            la clase emailServicio , y su respectiva contraseña.

            Requisitos:
            1. Activar acceso a aplicaciones poco seguras
            2. No usar un correo personal, unicamente para pruebas
              */


            //A quien se enviará el correo.
            string emailDestino = "to_Adress";
            // Sujeto del correo.
            string sujeto = "sujeto";
            //Contenido que irá dentro del correo.
            string content = "contenido";


            //Inicializacion del objeto emailServicio, metodo con 2 sobrecargas
            var correo = new emailServicio(emailDestino, "nombre_remitente",sujeto, content);
            //Metodo encargado de enviar el correo por el protocolo SMTP
            correo.enviarEmail();


        }
    }
}
