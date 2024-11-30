



using CacularSalario.Exception;

namespace CacularSalario.Class
{
    public class Person
    {
       
        #region "atributos"
        private string _firstname;
        private string _lastname;
      
        #endregion
        #region "propiedades"
        public string FirstName 
        { 
            get 
            { 
                return _firstname; 
            }
            set 
            {
  
                _firstname = value;
            }
        }
        public string LastName 
        {
            get 
            { 
                return _lastname; 
            }
            set 
            {
                _lastname = value;
            }
        }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        #endregion

    }
}
