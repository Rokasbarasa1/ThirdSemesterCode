using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Simple_things
{
    internal class DelegateTopic
    {
        public delegate void TestDelegate();
        public delegate bool TestBoolDelegate(int i);

        private TestDelegate testDelegateFunction;
        private TestBoolDelegate testBoolDelegateFunction;

        private Action testAction;
        private Action<int, float> testIntFloatAction;
        private Func<bool> testFunc;
        private Func<int, bool> testIntBoolFunc;
        public void start()
        {

            testDelegateFunction = MyTestDelegateFunction;

            testDelegateFunction();

            testDelegateFunction = MySecondTestDelegateFunction;

            testDelegateFunction();

            testDelegateFunction += MyTestDelegateFunction;

            testDelegateFunction();

            testBoolDelegateFunction = MyTestBoolDelegateFucntion;

            Console.WriteLine(testBoolDelegateFunction(1));

            testBoolDelegateFunction = (int i) => { return i < 5; };

            testIntFloatAction = (int i, float f) => { Console.WriteLine("test int float action"); };

            testFunc = () => false;

            testIntBoolFunc = (int i) => { return i < 5; };
        }

        private void MyTestDelegateFunction()
        {
            Console.WriteLine("Test1");
        }

        private void MySecondTestDelegateFunction()
        {
            Console.WriteLine("Test2");
        }

        private bool MyTestBoolDelegateFucntion(int i)
        {
            return i < 5;
        }
    }
}