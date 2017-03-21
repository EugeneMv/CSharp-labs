using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Security;

namespace OOP2
{
    class Reflector
    {
        public void InfFields(Type T)
        {
            FieldInfo[] F = T.GetFields();
            for(int i = 0; i < F.Count(); i++)
            {
                Console.WriteLine(F[i].ToString());
            }
        }

        public void InfInterfaces(Type T)
        {
            Type[] t = T.GetInterfaces();
            for (int i = 0; i < t.Count(); i++)
            {
                Console.WriteLine(t[i].ToString());
            }
        }

        public void InfMetods(Type T)
        {
            MethodInfo[] t = T.GetMethods();
            for (int i = 0; i < t.Count(); i++)
            {
                Console.WriteLine(t[i].ToString());
            }
        }

        public void InfClass(Type T)
        {
            MemberInfo[] t4 = T.GetMembers();

            StreamWriter STR = new StreamWriter("INFO.txt");
            
            STR.WriteLine("Members");
            for (int i = 0; i < t4.Count(); i++)
            {
                STR.WriteLine(t4[i]);
            }
            STR.Close();
        }
    }
}
