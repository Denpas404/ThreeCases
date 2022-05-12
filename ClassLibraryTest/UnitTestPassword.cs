using System;
using NUnit.Framework;
using ClassLibrary;
using System.IO;

namespace ClassLibraryTest
{
    public class UnitTestPassword
    {
        [Test]
        public void TestLogin()
        {
            var _password = new PasswordLogic();

            var _result = _password.Login();

            Assert.AreEqual(true, _result);
        }

        [Test]
        public void TestPassLength()
        {
            var _password = new PasswordLogic();

            var _result = _password.checkPass(pass:"Dennis");
            
            Assert.AreEqual("Password is to short", _result.ErrorMessege);
        }

        [Test]
        public void TestPassFirstCharNotDigit()
        {
            var _password = new PasswordLogic();

            var _result = _password.checkPass(pass: "123456Johnson");

            Assert.AreEqual("First letter can not be a number", _result.ErrorMessege);
        }

        [Test]
        public void TestPassLastCharNotDigit()
        {
            var _password = new PasswordLogic();

            var _result = _password.checkPass(pass: "Johnson123456");

            Assert.AreEqual("Last letter can not be a number", _result.ErrorMessege);
        }

        [Test]
        public void TestChangeName()
        {
            var _password = new PasswordLogic();

            var _result = _password.changeName(name:("Peter"));

            Assert.AreEqual("Username changed", _result); 
        }

        [Test]
        public void TestChangePass()
        {
            var _password = new PasswordLogic();

            var _result = _password.changePass(pass:("Joan"));

            Assert.AreEqual("Password is to short", _result);
        }
    }
}
