 
namespace CacularSalario.Exception
{
    public class PersonException : System.Exception
    {
        public PersonException(string message) : base(message)
        {
            // Agregar los errores en la base de datos y enviar notificacion por correo.
            AddLog(message);
            SendNotification(message);
        }
        private void AddLog(string message) 
        {
            Console.WriteLine("Agregando en la base de datos.");
        }
        private void SendNotification(string message) 
        {
            Console.WriteLine("Enviando notificacion.");
        }
    }
}
