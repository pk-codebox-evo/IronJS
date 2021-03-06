// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.DateObjects.PropertiesOfTheDatePrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class DatePrototypeGetDayTests : SputnikTestFixture
    {
        public DatePrototypeGetDayTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.9_Date_Objects\15.9.5_Properties_of_the_Date_Prototype_Object\15.9.5.16_Date.prototype.getDay")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.16")]
        [TestCase("S15.9.5.16_A1_T1.js", Description = "The Date.prototype property \"getDay\" has { DontEnum } attributes")]
        [TestCase("S15.9.5.16_A1_T2.js", Description = "The Date.prototype property \"getDay\" has { DontEnum } attributes")]
        [TestCase("S15.9.5.16_A1_T3.js", Description = "The Date.prototype property \"getDay\" has { DontEnum } attributes")]
        public void TheDatePrototypePropertyGetDayHasDontEnumAttributes(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.16")]
        [TestCase("S15.9.5.16_A2_T1.js", Description = "The \"length\" property of the \"getDay\" is 0")]
        public void TheLengthPropertyOfTheGetDayIs0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.16")]
        [TestCase("S15.9.5.16_A3_T1.js", Description = "The Date.prototype.getDay property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        [TestCase("S15.9.5.16_A3_T2.js", Description = "The Date.prototype.getDay property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        [TestCase("S15.9.5.16_A3_T3.js", Description = "The Date.prototype.getDay property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        public void TheDatePrototypeGetDayPropertyLengthHasReadOnlyDontDeleteDontEnumAttributes(string file)
        {
            RunFile(file);
        }
    }
}