using StickyNote;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Growl.DisplayStyle;

namespace Test
{
    
    
    /// <summary>
    ///This is a test class for StickyNoteDisplayTest and is intended
    ///to contain all StickyNoteDisplayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StickyNoteDisplayTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for NotificationMeetsRules
        ///</summary>
        [TestMethod()]
        [DeploymentItem("StickyNote.dll")]
        public void NotificationMeetsRulesTest()
        {
            StickyNoteDisplay_Accessor target = new StickyNoteDisplay_Accessor(); // TODO: Initialize to an appropriate value
            Notification notification = new Notification(); // TODO: Initialize to an appropriate value
            notification.Description = "lala.txt";
            string exclusions = ".txt,.dwg"; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.NotificationMeetsRules(notification, exclusions);
            Assert.AreEqual(expected, actual);
        }
    }
}
