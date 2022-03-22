using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace HCI_Project.Models
{
    public class SignLanguageInputViewModelRepository : ISignLanguageInputViewRepository
    {
        public Dictionary<string, string> _Listofinput;
        public SignLanguageInputViewModelRepository()
        {
            _Listofinput = new Dictionary<string, string>()
            {
                { "Hi How are you","https://www.youtube.com/watch?v=f72ookCWhsQ&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=15" }
            };
        }
      
          

       public  string Getdata(string input)
        {
           return _Listofinput.FirstOrDefault(x => x.Key == input).Value;
        }
    }
}
