// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Types.TheObjectType
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PropertyAttributesTests : SputnikTestFixture
    {
        public PropertyAttributesTests()
            : base(@"Conformance\08_Types\8.6_The_Object_Type\8.6.1_Property_Attributes")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 8.6.1")]
        [TestCategory("ECMA 15.2.2")]
        [TestCategory("ECMA 15.8")]
        [Description("A property can have attribute ReadOnly like E in Math")]
        public void S8_6_1_A1()
        {
            RunFile(@"S8.6.1_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 8.6.1")]
        [TestCategory("ECMA 12.6.4")]
        [TestCategory("ECMA 15.7")]
        [Description("A property can have attribute DontEnum like all properties of Number")]
        public void S8_6_1_A2()
        {
            RunFile(@"S8.6.1_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 8.6.1")]
        [TestCategory("ECMA 15.7")]
        [Description("A property can have attribute DontDelete like NaN propertie of Number object")]
        public void S8_6_1_A3()
        {
            RunFile(@"S8.6.1_A3.js");
        }
    }
}