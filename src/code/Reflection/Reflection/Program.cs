using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
#if _EX01
    delegate void PriteType(Type type);
#endif
    class Program
    {
#if _EX01
        static void PrintInterfaces(Type type)
        {
            Console.WriteLine("---------- Interface ----------");

            Type[] interfaces = type.GetInterfaces();
            foreach(var element in interfaces)
                Console.WriteLine($"Name:{element.Name}");
            Console.WriteLine();
        }

        static void PrintFields(Type type)
        {
            Console.WriteLine("---------- Fields ----------");

            FieldInfo[] fields = type.GetFields(
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.Instance
            );

            foreach (var fieldInfo in fields)
            {
                string accessLevel = "Protected";
                if (fieldInfo.IsPublic) accessLevel = "public";
                else if (fieldInfo.IsPrivate) accessLevel = "private";

                Console.WriteLine($"Access:{accessLevel}, Type:{fieldInfo.FieldType.Name}, Name:{fieldInfo.Name}");
            }
            Console.WriteLine();
        }

        static void PrintMethods(Type type)
        {
            Console.WriteLine("---------- Methods ----------");

            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.Write($"Type:{method.ReturnType.Name}, Name:{method.Name}, Parameter:");

                ParameterInfo[] args = method.GetParameters();
                for (int i = 0; i < args.Length; ++i)
                {
                    Console.Write($"{args[i].ParameterType.Name}");
                    if(i < args.Length - 1)
                        Console.Write(", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintProperties(Type type)
        {
            Console.WriteLine("---------- Properties ----------");
            PropertyInfo[] properties = type.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine($"Type:{property.PropertyType.Name}, {property.Name}");
            }
            Console.WriteLine();
        }
#endif
#if _EX02
        class Profile
        {
            public string Name { get; set; }
            public string Phone { get; set; }
        }
#endif
#if _EX03
        class Profile
        {
            public string Name { get; set; }
            public string Phone { get; set; }

            public void Print()
            {
                Console.WriteLine($"{Name}, {Phone}");
            }
        }
#endif

        static void Main(string[] args)
        {
#if _EX01
      
            int a = 0;
            Type type = a.GetType();

            PriteType printType = new PriteType(PrintInterfaces);
            printType += new PriteType(PrintFields);
            printType += new PriteType(PrintProperties);
            printType += new PriteType(PrintMethods);

            printType(type);

            Type b = typeof(int);
            Console.WriteLine(b.FullName);

            Type c = Type.GetType("System.Int32");
            Console.WriteLine(b.FullName);      
#endif

//////////////////////////////////////////////////////////////////////
#if _EX02
            Type type = typeof(Profile);
            Object profile = Activator.CreateInstance(type);

            PropertyInfo name = type.GetProperty("Name");
            PropertyInfo phone = type.GetProperty("Phone");

            name.SetValue(profile, "abc", null);
            phone.SetValue(profile, "123-456", null);
            
            Console.WriteLine($"{name.GetValue(profile, null)}, {phone.GetValue(profile, null)}");
#endif
#if _EX03
            Type type = typeof(Profile);
            Profile profile = (Profile) Activator.CreateInstance(type);
            profile.Name = "ABC";
            profile.Phone = "123-456";

            MethodInfo method = type.GetMethod("Print");
            method.Invoke(profile, null);
#endif
            AssemblyBuilder newAssembly =
                AppDomain.CurrentDomain.DefineDynamicAssembly(
                    new AssemblyName("CalculatorAssembly"), AssemblyBuilderAccess.Run
                );

            ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator");

            TypeBuilder newType = newModule.DefineType("Sum1To100");

            MethodBuilder newMethod = newType.DefineMethod(
                "Calculate",            // 메소드명
                MethodAttributes.Public,    // 한정자
                typeof(int),                // 반환 형식
                new Type[0]    // 매개 변수
            );

            ILGenerator generator = newMethod.GetILGenerator();
            //32bit 정수(1)를 스택에 넣습니다.
            generator.Emit(OpCodes.Ldc_I4, 1);

            for (int i = 2; i <= 100; ++i)
            {
                // 32bit 정수(i)를 스택에 넣습니다.
                generator.Emit(OpCodes.Ldc_I4, i);
                // 계산 후 스택에 담겨 있는 두 개의 값을 꺼내서 더한 후
                // 그 결과를 다시 스택에 넣습니다.
                generator.Emit(OpCodes.Add);
            }

            // 계산 스택에 담겨 있는 값을 반환
            generator.Emit(OpCodes.Ret);

            newType.CreateType();

            object Sum1To100 = Activator.CreateInstance(newType);
            MethodInfo Calculate = Sum1To100.GetType().GetMethod("Calculate");
            Console.WriteLine(Calculate.Invoke(Sum1To100, null));
        }
    }
}
