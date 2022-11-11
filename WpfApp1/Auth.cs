using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    
    public class Auth
    {
       
        public string TestPassword(string password)
        {
            if (password.Length >= 8)
            {
                return "Пароль длинный!";
            }
                if (password.Length <= 3)

                {
                    return "Пароль короткий!";
                }

                foreach (var item in password)
                {
                    for (int i = 0; i < password.Length - 1; i++)
                        if (password[i] == password[i + 1] && password[i] == password[i + 1])
                        {
                            return "Спец символы не должны повторяться!";
                        }
                }
                
                return "Пароль отличный!";
            }
        }
    }
                                
           
            


                   
                


