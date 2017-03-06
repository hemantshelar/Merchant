using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MerchantDAL;
using MerchantDAL.DbEntities;

namespace MerchantAPI.Tests
{
    /// <summary>
    /// Summary description for UnitTestMerchantDAL
    /// </summary>
    [TestClass]
    public class UnitTestMerchantDAL
    {
        public UnitTestMerchantDAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethodTestAdd()
        {
            //
            // TODO: Add test logic here
            //
            UnitOfWork uow = new UnitOfWork();

            uow.MerchantRepository.Add(new MerchantDAL.DbEntities.Merchant
            {
                _id = "abcd5"
                ,
                display_name = "test display name"
                ,
                email = "email@a.com"
                ,
                logo = "uri"
                ,
                phone = "0478415726"
                ,
                registered_name = "name registered"
                ,
                status = "Active"
            });
            uow.SaveChanges();

            Address addr = new MerchantDAL.DbEntities.Address
            {
                address1 = "address1 ",
                address2 = "Address",
                postcode = "2148",
                state = "NSW new",
                UserId = "abcd5"
            };

            uow.AddressRepository.Add(addr);

            uow.SaveChanges();

            addr.country = "Australia";
            addr.address2 = "new";


            uow.AddressRepository.Update(addr);

            uow.SaveChanges();
        }
    }
}
