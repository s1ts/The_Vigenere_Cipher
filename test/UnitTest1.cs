using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectOrientedPractics.Services;
using protect_inf_LR1;
using System;
using System.Collections.Generic;
using protect_inf_LR1;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAuth()
        {
            List<User> list = new List<User>();
            list = Serializer.LoadFromFile("users.txt");
            string login = "admin";
            string password = "admin";
            bool good = false;
            foreach (var usr in list)
            {
                if (usr.login == login && usr.password == password)
                {
                    good = true;
                }
            }
            Assert.AreEqual(good, true);
        }
        [TestMethod]
        public void TestRegister()
        {
            User user = new User();
            List<User> list = new List<User>();
            list = Serializer.LoadFromFile("users.txt");
            string login = "admin1";
            string password = "admin1";
            user.login = login;
            user.password = password;
            list.Add(user);
            bool good = false;
            foreach (var usr in list)
            {
                if (usr.login == login && usr.password == password)
                {
                    good = true;
                }
            }
            Assert.AreEqual(good, true);
        }
        [TestMethod]
        public void TestAuthFalse()
        {
            List<User> list = new List<User>();
            list = Serializer.LoadFromFile("users.txt");
            string login = "admin55";
            string password = "admin55";
            bool good = false;
            foreach (var usr in list)
            {
                if (usr.login == login && usr.password == password)
                {
                    good = true;
                }
            }
            Assert.AreEqual(good, false);
        }
    }
}
