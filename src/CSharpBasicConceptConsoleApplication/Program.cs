using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BasicConceptCSharpConsoleApplication
{
    internal class Program
    {
        private static void Main()
        {
            var options = GetOptionsList();            
            bool beActive = true;
            do
            {
                var choice = PrintOptions(options);
                if(choice == "0")
                {
                    beActive = false;
                    Console.ReadKey();
                }
                else
                {
                    PerformSelectedOptions(choice);
                }
                
            } while (beActive);
        }

        #region Get Options
        static string[] GetOptionsList()
        {
            return new string[]
            {
                "0. Exit",
                "1. Size of Data Type",
                "2. ANSI Value of Char",
                "3. Basic Concepts",
                "4. Static Non Static Concepts",
                "5. Var and Dynamic Concepts",
                "6. Out and Ref Concepts",
                "7. String Concepts",
                "8. Exception Concepts",
                "9. Unsafe Code",
                "10. Interface Property Concepts",
                "11. Interface Method Concepts",
                "12. Method having differnt method type and same name",
                "13. Polymorphism Concept",
                "14. Linq Expression Concept",
                "15. Extension Method Concept",
                "16. Delegate Concept",
                "17. Stack Queue Concept",
            };
        }
        #endregion

        static string PrintOptions(string[] options)
        {
            MyHelper.PrintBorder();
            Console.WriteLine("Please Select from the following option:");
            foreach (var item in options)
            {
                Console.WriteLine(item);
            }
            MyHelper.PrintBorder();

            string choice = Console.ReadLine().ToString();
            MyHelper.PrintBorder();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(options[Convert.ToInt32(choice)]);
            Console.ResetColor();
            MyHelper.PrintBorder();
            return choice;
        }

        static void PerformSelectedOptions(string choice)
        {
            switch (choice)
                {
                    case "1":
                        SizeOfDataType();
                        break;

                    case "2":
                        CharAnsiValue();
                        break;

                    case "3":
                        BasicConcepts();
                        break;

                    case "4":
                        StaticNonStaticConcepts();
                        break;

                    case "5":
                        VarDynamicConcept();
                        break;

                    case "6":
                        OutRefConcept();
                        break;

                    case "7":
                        StringConcepts();
                        break;

                    case "8":
                        ExceptionConcepts();
                        break;

                    case "9":
                        Console.WriteLine("Unsafe code has not been implemented yet.");
                        /*UnsafeCodeConcepts();*/
                        break;

                    case "10":
                        InterfacePropertyConcept();
                        break;

                    case "11":
                        InterfaceSameMethodConcept();
                        break;

                    case "12":
                        MethodSignatureConcept();
                        break;

                    case "13":
                        PolymorphismConcepts();
                        break;

                    case "14":
                        LinqConcept();
                        break;

                    case "15":
                        ExtensionMethodConcept();
                        break;

                    case "16":
                        DelegatesConcept();
                        break;

                    case "17":
                        StackQueueConcept();
                        break; ;
                    case "0":
                        beActive = false;
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("You have selected a wrong option. Please Try Again!!");
                        break;
                }
        }

        #region Size of Data Type

        private static void SizeOfDataType()
        {
            Console.WriteLine("Size Of Int:\t" + sizeof(int));
            Console.WriteLine("Size Of Char:\t" + sizeof(char));
            Console.WriteLine("Size Of Float:\t" + sizeof(float));
            Console.WriteLine("Size Of Int16:\t" + sizeof(Int16));
            Console.WriteLine("Size Of Bool:\t" + sizeof(bool));
            Console.WriteLine("Size Of Byte:\t" + sizeof(byte));
            Console.WriteLine("Size Of Decimal:\t" + sizeof(decimal));
            Console.WriteLine("Size Of Double:\t" + sizeof(double));
            //Console.WriteLine(sizeof(dynamic));//cannot take the address of, get the size of, or declare a pointer to a manged type ('dynamic') dynamic does not have a predefined size.
            MyHelper.PrintPointsToRememberMessage();
            Console.WriteLine("1. cannot take the address of, get the size of, or declare a pointer to a managed type ('dynamic') dynamic does not have a predefined size");
            Console.WriteLine("2. You Can debug and validate it.");
            MyHelper.PrintEndMessage();
        }

        #endregion Size of Data Type

        #region ANSI value of char

        private static void CharAnsiValue()
        {
            for (int i = 1; i < 150; i++)
            {
                Console.WriteLine(i + ":" + Convert.ToChar(i));
            }
            MyHelper.PrintEndMessage();
        }

        #endregion ANSI value of char

        #region BasicConcepts

        private static void BasicConcepts()
        {
            #region OperatorConcepts

            MyHelper.PrintHeaderMessage("Operator Concepts");
            int a = 4, b = 2;
            a -= b /= a;
            Console.WriteLine("a:" + a + "\nb:" + b);
            MyHelper.PrintNoteConcept();

            #endregion OperatorConcepts

            #region Float and int concepts

            MyHelper.PrintHeaderMessage("Float and Int Concepts");
            float x = 16.4f;
            int y = 12;
            float z;
            z = x * (y + x) / (x - y);
            Console.WriteLine("Result is :" + z);
            MyHelper.PrintNoteConcept();

            #endregion Float and int concepts

            #region Nullable Concepts

            MyHelper.PrintHeaderMessage("Nullable Concepts");
            int? count = null;
            int? result = null;
            int incr = 10;
            result = count + incr;
            if (result.HasValue)
                Console.WriteLine("result has this value: " + result.Value);
            else
                Console.WriteLine("result has no value");
            MyHelper.PrintNoteConcept();
            MyHelper.PrintEndMessage();

            #endregion Nullable Concepts
        }

        #endregion BasicConcepts

        #region Static Non Static Concepts

        private static void StaticNonStaticConcepts()
        {
            #region Calling Static Method from Non Static Method

            MyHelper.PrintHeaderMessage("Calling Static Method from Non Static Method");
            StaticNonStaticConceptClass obj = new StaticNonStaticConceptClass();
            StaticNonStaticConceptClass.StaticMethod();
            obj.NonStaticMethod(20);
            MyHelper.PrintNoteConcept();

            #endregion Calling Static Method from Non Static Method

            #region Static and Non Static Method having Same signature

            MyHelper.PrintHeaderMessage("Static and Non Static Method having Same signature");
            StaticNonStaticConceptClass.GetSum(3, 2);
            obj.GetSum2(3, 2);
            MyHelper.PrintNoteConcept();
            MyHelper.PrintEndMessage();

            #endregion Static and Non Static Method having Same signature
        }

        private class StaticNonStaticConceptClass
        {
            public static void StaticMethod()
            {
                Console.WriteLine("Static Void method");
            }

            public void NonStaticMethod()
            {
                StaticMethod();
                Console.WriteLine("Non Static Void Method");
            }

            public void NonStaticMethod(int i)
            {
                Console.WriteLine(i);
                NonStaticMethod();
            }

            public static int GetSum(int a, int b)
            {
                return a + b;
            }

            public int GetSum2(int a, int b)
            {
                return a + b;
            }
        }

        #endregion Static Non Static Concepts

        #region Var And Dynamic Concept

        private static void VarDynamicConcept()
        {
            var i = 3;
            //i = "Sachin";
            dynamic x;
            x = "cy";
            Console.WriteLine(x);
            x = 2;
            Console.WriteLine(x);
            x = Console.ReadLine();
            Console.WriteLine(x);
            MyHelper.PrintPointsToRememberMessage();
            Console.WriteLine("1. Variable of var type needs initialization at the time of declaration(compile time) so the type decides at the same time and cannot change later.");
            Console.WriteLine("2. Variable of dynamic type can be change at run time by just assigning the value and can be declare without initialization.");
            MyHelper.PrintNoteConcept();
            MyHelper.PrintEndMessage();
        }

        #endregion Var And Dynamic Concept

        #region Out Ref Concept

        private static void OutRefConcept()
        {
            Employee refObjA = null;
            GetrefValue(ref refObjA);
            //Console.WriteLine(refObjA.EmployeeName);

            Employee refObjB = new Employee("Assigned Object Before ref calling Method");
            Console.WriteLine(refObjB.EmployeeName);
            GetrefValue(ref refObjB);
            Console.WriteLine(refObjB.EmployeeName);

            Employee outObjA = null;
            GetOutValue(out outObjA);
            Console.WriteLine(outObjA.EmployeeName);

            Employee outObjB = new Employee("Assigned Object Before out calling Method");
            Console.WriteLine(outObjB.EmployeeName);
            GetOutValue(out outObjB);
            Console.WriteLine(outObjB.EmployeeName);

            MyHelper.PrintPointsToRememberMessage();
            Console.WriteLine("1. In case of passing object(including null) as ref, the ref parameter may or may not be assigned to before the control leaves the current method.");
            Console.WriteLine("2. In case of passing object(including null) as out, the out parameter must be assigned to before control leaves the current method.");
            MyHelper.PrintNoteConcept();

            MyHelper.PrintEndMessage();
        }

        private static void GetrefValue(ref Employee obj)
        {
            //obj = new Employee("Assigned Object In ref Method");
        }

        private static void GetOutValue(out Employee obj)
        {
            obj = new Employee("Assigned Object In out Method");
        }

        private class Employee
        {
            public string EmployeeName { get; set; }

            internal Employee(string empName)
            {
                EmployeeName = empName;
            }
        }

        #endregion Out Ref Concept

        #region String Concepts

        private static void StringConcepts()
        {
            #region String Assignment

            MyHelper.PrintHeaderMessage("String Assignment");

            string firstString = "First String";
            string secondString = firstString;
            Console.WriteLine("firstString:" + firstString);
            Console.WriteLine("secondString:" + secondString);

            firstString = "Changes the First String";
            Console.WriteLine("\nAfter changing the firstString");
            Console.WriteLine("firstString:" + firstString);
            Console.WriteLine("secondString:" + secondString);
            MyHelper.PrintNoteConcept();

            #endregion String Assignment

            #region Remove Method of String

            MyHelper.PrintHeaderMessage("Remove Method of String");
            string helloString = "hello";
            string newString = helloString.Remove(2);
            Console.WriteLine(newString);
            MyHelper.PrintNoteConcept("Returns a new string in which all the characters in the current instance, beginning at a specified position and continuing through the last position, have been deleted.");

            #endregion Remove Method of String

            MyHelper.PrintEndMessage();
        }

        #endregion String Concepts

        #region Exception Concepts

        private static void ExceptionConcepts()
        {
            #region Finally Block Importance

            MyHelper.PrintHeaderMessage("Finally Block Importance");
            int index = 4;
            int val = 44;
            int[] myArray = new int[5];
            try
            {
                Console.WriteLine("Before Exception");
                myArray[index] = val;
                Console.WriteLine("After Exception");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of bounds ");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception");
                return;
            }
            finally
            {
                Console.WriteLine("Finally Block");
                //return;
            }
            Console.WriteLine("Remaining program");
            MyHelper.PrintNoteConcept("We can't return control from finally block however we can return from try and catch block provided there is no any further lines of code.");

            #endregion Finally Block Importance

            #region Code After Throw Statement

            MyHelper.PrintHeaderMessage("Code After Throw Statement");
            bool? c;
            Console.WriteLine("Main Block Start");
            try
            {
                c = TryCatchImplementation();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Main Catch Block");
            }
            Console.WriteLine("Main Block End");
            MyHelper.PrintNoteConcept("Its good practice to not write any statement after the throw or return statement.");

            #endregion Code After Throw Statement

            MyHelper.PrintEndMessage();
        }

        private static bool? TryCatchImplementation()
        {
            try
            {
                Console.WriteLine("Try Block");
                //throw new Exception();
                Console.WriteLine("Before Returning from Try Block");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch Block");
                Console.WriteLine("Before Returning From Catch Block");
                return true;
            }
            finally
            {
                Console.WriteLine("Finally Block");
                //throw new Exception();
                Console.WriteLine("Before Returning From Finally Block");
            }
            Console.WriteLine("Before Returning from Method");
            return true;
        }

        #endregion Exception Concepts

        #region Unsafe Code

        /*unsafe static void UnsafeCodeConcepts()
        {
            #region char and pointer concept

            MyHelper.PrintHeaderMessage("char and pointer concept");
            int* point;
            int ch = 13 * 5;
            point = &(ch);
            Console.WriteLine(Convert.ToChar(*point));
            if (*point == 'A')
                Console.WriteLine(Convert.ToBoolean(1));
            else
                Console.WriteLine(Convert.ToBoolean(0));
            MyHelper.PrintNoteConcept();

            #endregion char and pointer concept

            #region Index pointer like array

            MyHelper.PrintHeaderMessage("Index pointer like array");
            int[] intArray = new int[10];
            fixed (int* p = intArray)
            {
                for (int i = 0; i < 10; i++)
                    p[i] = i;
                for (int i = 10; i > 0; i--)
                    Console.WriteLine("p[{0}]: {1} ", i, p[i]);
                Console.ReadLine();
            }
            MyHelper.PrintNoteConcept();

            #endregion Index pointer like array

            #region Pointer Address

            MyHelper.PrintHeaderMessage("Pointer Address");
            int[] nums = new int[10];
            fixed (int* p = &nums[0], p2 = nums)
            {
                if (p == p2)
                    Console.WriteLine("p and p2 point to same address.");
                Console.ReadLine();
            }
            char[] arr = { 'a', 'b', 'c', 'd', 'e' };
            fixed (char* p = arr)
            {
                int i;
                for (i = 0; i < 5; i++)
                    if (*p % 2 == 0)
                        ++*p;
                    else
                        (*p)++;
                Console.WriteLine(arr);
            }
            MyHelper.PrintNoteConcept();

            #endregion Pointer Address

            MyHelper.PrintEndMessage();
        }*/

        #endregion Unsafe Code

        #region Interface Property Concepts

        private static void InterfacePropertyConcept()
        {
            IMyFirstInterface obj1 = new InterfaceClass();
            IMySecondInterface obj2 = new InterfaceClass();
            InterfaceClass obj3 = new InterfaceClass();
            //obj1.MyValue = 1;
            obj2.MyValue = 2;
            obj3.MyValue = 3;

            Console.WriteLine(obj1.MyValue);
            //Console.WriteLine(obj2.MyValue);
            Console.WriteLine(obj3.MyValue);
            MyHelper.PrintPointsToRememberMessage();
            Console.WriteLine("1. We cannot set or get the properties value for an object if its undefined");
            MyHelper.PrintNoteConcept();
            MyHelper.PrintEndMessage();
        }

        public interface IMyFirstInterface
        {
            int MyValue { get; }
        }

        public interface IMySecondInterface
        {
            int MyValue { set; }
        }

        private class InterfaceClass : IMySecondInterface, IMyFirstInterface
        {
            public int MyValue
            {
                get;
                set;
            }

            private int GetValues()
            {
                return MyValue;
            }
        }

        #endregion Interface Property Concepts

        #region Interface Having Same Method Signature

        private static void InterfaceSameMethodConcept()
        {
            IFirstInterface objfirstinterface = new MyClassForInterface();
            ISecondInterface objsecondinterface = new MyClassForInterface();
            MyClassForInterface obj = new MyClassForInterface();

            objfirstinterface.f1();
            objsecondinterface.f1();
            obj.f1();
            MyHelper.PrintPointsToRememberMessage();
            Console.WriteLine("1. By default the implemented interface method is public");
            Console.WriteLine("2. We can implement multiple interface method by using Interface name");
            MyHelper.PrintNoteConcept();
            MyHelper.PrintEndMessage();
        }

        public interface IFirstInterface
        {
            void f1();
        }

        public interface ISecondInterface
        {
            void f1();
        }

        private class MyClassForInterface : IFirstInterface, ISecondInterface
        {
            void IFirstInterface.f1()
            {
                Console.WriteLine("this is imyfirstinterface");
            }

            void ISecondInterface.f1()
            {
                Console.WriteLine("this is imysecondinterface");
            }

            public void f1()
            {
                Console.WriteLine("object method implementation");
            }
        }

        #endregion Interface Having Same Method Signature

        #region Method having differnt method type and same name

        private static void MethodSignatureConcept()
        {
            MyClass obj = new MyClass();
            Console.WriteLine("Hash Code:" + obj.GetHashCode());
            Console.WriteLine("Type:" + obj.GetType());
            Console.WriteLine("object name string:" + obj.ToString());
            obj.GetResult();
            obj.GetResult(2);
            MyHelper.PrintNoteConcept();
            MyHelper.PrintEndMessage();
        }

        private class MyClass
        {
            public MyClass()
            {
                Console.WriteLine("My Class Constructor");
            }

            public string GetResult()
            {
                Console.Out.WriteLine("GetResult string return Method Called");
                return "";
            }

            public int GetResult(int a)
            {
                Console.Out.WriteLine("GetResult int return Method Called");
                return 1;
            }
        }

        #endregion Method having differnt method type and same name

        #region Polymorphism:Overriding, New Override Virtual Base Derived Reference and Object

        private static void PolymorphismConcepts()
        {
            MyHelper.PrintHeaderMessage("Base Reference Base Object");
            MyBase obj1 = new MyBase(); obj1.f1(); obj1.f2(); obj1.f3(); obj1.f4(); obj1.f5();
            MyHelper.PrintNoteConcept("In this case, all base function will be called.");

            MyHelper.PrintHeaderMessage("Derived Reference Derived Object");
            MyDerived obj2 = new MyDerived(); obj2.f1(); obj2.f2(); obj2.f3(); obj2.f4(); obj2.f5();
            MyHelper.PrintNoteConcept("In this case, all derived function will be called.");

            MyHelper.PrintHeaderMessage("Base Reference Derived Object");
            MyBase obj3 = new MyDerived(); obj3.f1(); obj3.f2(); obj3.f3(); obj3.f4(); obj3.f5();
            MyHelper.PrintNoteConcept("In this case, Only derived override will be called else all base will be called");

            Console.Out.WriteLine("Derived Reference  Base Object With Type Cast");
            //MyDerived obj4 = (MyDerived)new MyBase(); obj4.f1(); obj4.f2(); obj4.f3(); obj4.f4(); obj4.f5();
            MyHelper.PrintNoteConcept("Run Time Error: Unable to cast Base type to Derived type");

            MyHelper.PrintNoteConcept();
            MyHelper.PrintEndMessage();
        }

        private class MyBase
        {
            public MyBase()
            {
                Console.WriteLine("My Base Constructor");
            }

            public void f1()
            {
                Console.Out.WriteLine("Base f1 Function Called");
            }

            public virtual void f2()
            {
                Console.Out.WriteLine("Base Virtual f2 Function Called");
            }

            public virtual void f3()
            {
                Console.Out.WriteLine("Base Virtual f3 Function Called");
            }

            public void f4()
            {
                Console.Out.WriteLine("Base f4 Function Called");
            }

            public virtual void f5()
            {
                Console.Out.WriteLine("Base Virtual f5 Function Called");
            }
        }

        private class MyDerived : MyBase
        {
            public MyDerived()
            {
                Console.WriteLine("My Derived Constructor");
            }

            public new void f1()
            {
                Console.Out.WriteLine("Derived new f1 Function Called");
            }

            public override void f2()
            {
                Console.Out.WriteLine("Derived Override f2 Function Called");
            }

            public new void f3()
            {
                Console.Out.WriteLine("Derived new f3 Function Called");
            }

            public void f4()
            {
                Console.Out.WriteLine("Derived f4 Function Called");
            }

            public void f5()
            {
                Console.Out.WriteLine("Derived f5 Function Called");
            }
        }

        #endregion Polymorphism:Overriding, New Override Virtual Base Derived Reference and Object

        #region LINQ Expression

        private static void LinqConcept()
        {
            List<string> listString = new List<string>() { "sachin", "kumar", "mindtree", "infosys", "techM", "OnMobile", "WellsFargo", "sangita", "supriya", "wells", "monkey" };
            string search = Console.ReadLine().ToString();
            var d = listString.Where(y => y.StartsWith(search)).ToList();
            foreach (var item in d)
            {
                Console.WriteLine(item);
            }
            MyHelper.PrintNoteConcept();
            MyHelper.PrintEndMessage();
        }

        #endregion LINQ Expression

        #region Extension Method Concept

        private static void ExtensionMethodConcept()
        {
            MyWithoutExtensionClass obj = new MyWithoutExtensionClass();
            obj.MyExtensionMethods();
            MyHelper.PrintEndMessage();
        }

        #endregion Extension Method Concept

        #region Delegates Concepts

        private static void DelegatesConcept()
        {
            DelegatesClass obj = new DelegatesClass();
            obj.TestMethod(5);
            bool result = obj.del2(10);
            Console.WriteLine(obj.del1());
            //Changing the reference of the delegates to point to some other method
            obj.del1 = () => { return false; };//Method3
            Console.WriteLine(obj.del1());
            Console.WriteLine(result);

            MyHelper.PrintPointsToRememberMessage();
            Console.WriteLine("1. A delegate is a reference to a method.");
            Console.WriteLine("2. First we need to declare a delegate reference");
            Console.WriteLine("3. Second we can assigned some method to the delegates");
            Console.WriteLine("4. Finally we can call the delegates method.");
            MyHelper.PrintNoteConcept();
            MyHelper.PrintEndMessage();
        }

        private class DelegatesClass
        {
            //Declaring a referernce to a method without any paramaeter and bool return type
            internal delegate bool DWithoutparam();

            //Declaring a referernce to a method with int paramaeter and bool return type
            internal delegate bool DWithParam(int i);

            internal DWithoutparam del1;
            internal DWithParam del2;

            public void TestMethod(int input)
            {
                int myValue = 0;
                //Assigning method to delegates
                del1 = () => { myValue = 10; return myValue > input; };//Method1
                del2 = (x) => { return x == myValue; };//Method2
                //As the method has only been assigned not executed so value of j will be 0
                Console.WriteLine("myValue={0}", myValue);
                //Calling del2 assigned method
                Console.WriteLine(del2(10));
                //calling del1 assigned method
                bool boolResult = del1();
                Console.WriteLine("myValue = {0}. boolResult = {1}", myValue, boolResult);
            }
        }

        #endregion Delegates Concepts

        #region Stack Queue Implementation

        private static void StackQueueConcept()
        {
            Stack st = new Stack();
            st.Push(true);
            st.Push(1.2f);
            st.Push(1.2);
            st.Push(1);
            st.Push('c');
            st.Push("PushString");
            foreach (var item in st)
            {
                Console.WriteLine(item.GetType() + ": " + item);
                //Console.WriteLine(st.Pop());
            }
            MyHelper.PrintNoteConcept("We can push any type in stack");
            MyHelper.PrintEndMessage();
        }

        #endregion Stack Queue Implementation
    }

    internal class MyHelper
    {
        public static void PrintBorder()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***************************************************");
            Console.ResetColor();
        }

        public static void PrintPointsToRememberMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***************Points To Remember: ***************");
            Console.ResetColor();
        }

        public static void PrintEndMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************END***********************");
            Console.ResetColor();
            Console.ReadKey();
        }

        public static void PrintNoteConcept(string message = "Please look into the code to get the concepts.")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nNote: " + message);
            Console.ResetColor();
            Console.ReadLine();
        }

        public static void PrintHeaderMessage(string header)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("##########" + header + ":##########");
            Console.ResetColor();
        }
    }

    #region Extension Method Class and Implementation

    public class MyWithoutExtensionClass
    {
    }

    public static class XX
    {
        public static void MyExtensionMethods(this MyWithoutExtensionClass obj)
        {
            Console.WriteLine("My Extension Methods");
        }
    }

    #endregion Extension Method Class and Implementation
}