using System;
using NUnit.Framework;
using ClassLibrary;

namespace ClassLibraryTest
{
    public class UnitTestPassword
    {
        [Test]
        public void TestLogin()
        {
            var _password = new PasswordLogic();

            var _result = _password.Login();

            Assert.AreEqual(_result, true);
        }


    }
}
