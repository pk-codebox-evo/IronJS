// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Statement
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TheBreakStatementTests : SputnikTestFixture
    {
        public TheBreakStatementTests()
            : base(@"Conformance\12_Statement\12.8_The_break_Statement")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.8")]
        [TestCase("S12.8_A1_T1.js", Description = "Appearing of break without an IterationStatement leads to syntax error", ExpectedException = typeof(Exception))]
        [TestCase("S12.8_A1_T2.js", Description = "Appearing of break without an IterationStatement leads to syntax error", ExpectedException = typeof(Exception))]
        [TestCase("S12.8_A1_T3.js", Description = "Appearing of break without an IterationStatement leads to syntax error", ExpectedException = typeof(Exception))]
        [TestCase("S12.8_A1_T4.js", Description = "Appearing of break without an IterationStatement leads to syntax error", ExpectedException = typeof(Exception))]
        public void AppearingOfBreakWithoutAnIterationStatementLeadsToSyntaxError(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.8")]
        [TestCase("S12.8_A2.js", Description = "Since LineTerminator between \"break\" and Identifier is not allowed, \"break\" is evaluated without label")]
        public void SinceLineTerminatorBetweenBreakAndIdentifierIsNotAllowedBreakIsEvaluatedWithoutLabel(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.8")]
        [TestCase("S12.8_A3.js", Description = "When \"break\" is evaluated, (break, empty, empty) is returned")]
        public void WhenBreakIsEvaluatedBreakEmptyEmptyIsReturned(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.8")]
        [TestCase("S12.8_A4_T1.js", Description = "When \"break Identifier\" is evaluated, (break, empty, Identifier) is returned")]
        [TestCase("S12.8_A4_T2.js", Description = "When \"break Identifier\" is evaluated, (break, empty, Identifier) is returned")]
        [TestCase("S12.8_A4_T3.js", Description = "When \"break Identifier\" is evaluated, (break, empty, Identifier) is returned")]
        public void WhenBreakIdentifierIsEvaluatedBreakEmptyIdentifierIsReturned(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.8")]
        [TestCase("S12.8_A5_T1.js", Description = "Identifier must be label in the label set of an enclosing (but not crossing function boundaries) IterationStatement", ExpectedException = typeof(Exception))]
        [TestCase("S12.8_A5_T2.js", Description = "Identifier must be label in the label set of an enclosing (but not crossing function boundaries) IterationStatement", ExpectedException = typeof(Exception))]
        [TestCase("S12.8_A5_T3.js", Description = "Identifier must be label in the label set of an enclosing (but not crossing function boundaries) IterationStatement", ExpectedException = typeof(Exception))]
        public void IdentifierMustBeLabelInTheLabelSetOfAnEnclosingButNotCrossingFunctionBoundariesIterationStatement(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.8")]
        [TestCase("S12.8_A6.js", Description = "Appearing of \"break\" within a function call that is nested in a IterationStatement yields SyntaxError", ExpectedException = typeof(Exception))]
        public void AppearingOfBreakWithinAFunctionCallThatIsNestedInAIterationStatementYieldsSyntaxError(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.8")]
        [TestCase("S12.8_A7.js", Description = "Appearing of \"break\" within eval statement that is nested in an IterationStatement yields SyntaxError")]
        public void AppearingOfBreakWithinEvalStatementThatIsNestedInAnIterationStatementYieldsSyntaxError(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.8")]
        [TestCase("S12.8_A8_T1.js", Description = "Appearing of \"break\" within \"try/catch\" Block yields SyntaxError", ExpectedException = typeof(Exception))]
        [TestCase("S12.8_A8_T2.js", Description = "Appearing of \"break\" within \"try/catch\" Block yields SyntaxError", ExpectedException = typeof(Exception))]
        public void AppearingOfBreakWithinTryCatchBlockYieldsSyntaxError(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.8")]
        [TestCase("S12.8_A9_T1.js", Description = "Using \"break\" within \"try/catch\" statement that is nested in a loop is allowed")]
        [TestCase("S12.8_A9_T2.js", Description = "Using \"break\" within \"try/catch\" statement that is nested in a loop is allowed")]
        public void UsingBreakWithinTryCatchStatementThatIsNestedInALoopIsAllowed(string file)
        {
            RunFile(file);
        }
    }
}