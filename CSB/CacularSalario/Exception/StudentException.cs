

namespace CacularSalario.Exception
{
    public class StudentException : System.Exception
    {
        public StudentException(string message) : base(message) 
        {
            
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
