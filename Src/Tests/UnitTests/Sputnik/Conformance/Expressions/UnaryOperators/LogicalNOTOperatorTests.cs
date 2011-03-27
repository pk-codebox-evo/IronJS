// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.UnaryOperators
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LogicalNOTOperatorTests : SputnikTestFixture
    {
        public LogicalNOTOperatorTests()
            : base(@"Conformance\11_Expressions\11.4_Unary_Operators\11.4.9_Logical_NOT_Operator")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.9")]
        [TestCategory("ECMA 7.2")]
        [TestCategory("ECMA 7.3")]
        [Description("White Space and Line Terminator between \"!\" and UnaryExpression are allowed")]
        public void S11_4_9_A1()
        {
            RunFile(@"S11.4.9_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.9")]
        [Description("Operator !x uses GetValue")]
        public void S11_4_9_A2_1_T1()
        {
            RunFile(@"S11.4.9_A2.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.9")]
        [Description("Operator !x uses GetValue")]
        public void S11_4_9_A2_1_T2()
        {
            RunFile(@"S11.4.9_A2.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.9")]
        [TestCategory("ECMA 8.6.2.6")]
        [Description("Operator !x uses [[Default Value]]")]
        public void S11_4_9_A2_2_T1()
        {
            RunFile(@"S11.4.9_A2.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.9")]
        [Description("Operator !x returns !ToBoolean(x)")]
        public void S11_4_9_A3_T1()
        {
            RunFile(@"S11.4.9_A3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.9")]
        [Description("Operator !x returns !ToBoolean(x)")]
        public void S11_4_9_A3_T2()
        {
            RunFile(@"S11.4.9_A3_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.9")]
        [Description("Operator !x returns !ToBoolean(x)")]
        public void S11_4_9_A3_T3()
        {
            RunFile(@"S11.4.9_A3_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.9")]
        [Description("Operator !x returns !ToBoolean(x)")]
        public void S11_4_9_A3_T4()
        {
            RunFile(@"S11.4.9_A3_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.9")]
        [Description("Operator !x returns !ToBoolean(x)")]
        public void S11_4_9_A3_T5()
        {
            RunFile(@"S11.4.9_A3_T5.js");
        }
    }
}