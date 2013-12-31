// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Types
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TheNumberTypeTests : SputnikTestFixture
    {
        public TheNumberTypeTests()
            : base(@"Conformance\08_Types\8.5_The_Number_Type")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A1.js", Description = "NaN !== NaN")]
        public void NaNNaN(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A10.js", Description = "Infinity is not a keyword")]
        public void InfinityIsNotAKeyword(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A11_T1.js", Description = "The integer 0 has two representations, +0 and -0")]
        [TestCase("S8.5_A11_T2.js", Description = "The integer 0 has two representations, +0 and -0")]
        public void TheInteger0HasTwoRepresentations0And0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A12.1.js", Description = "+Infinity and Infinity are the same as Number.POSITIVE_INFINITY")]
        public void InfinityAndInfinityAreTheSameAsNumberPOSITIVE_INFINITY(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A12.2.js", Description = "-Infinity is the same as Number.NEGATIVE_INFINITY")]
        public void InfinityIsTheSameAsNumberNEGATIVE_INFINITY(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A13_T1.js", Description = "Finite nonzero values  that are Normalised having the form s*m*2**e  where s is +1 or -1, m is a positive integer less than 2**53 but not  less than s**52 and e is an integer ranging from -1074 to 971")]
        [TestCase("S8.5_A13_T2.js", Description = "Finite nonzero values  that are Normalised having the form s*m*2**e  where s is +1 or -1, m is a positive integer less than 2**53 but not  less than s**52 and e is an integer ranging from -1074 to 971")]
        public void FiniteNonzeroValuesThatAreNormalisedHavingTheFormSM2EWhereSIs1Or1MIsAPositiveIntegerLessThan253ButNotLessThanS52AndEIsAnIntegerRangingFrom1074To971(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A14_T1.js", Description = "When number absolute value is bigger of 2**1024 should convert to Infinity")]
        [TestCase("S8.5_A14_T2.js", Description = "When number absolute value is bigger of 2**1024 should convert to Infinity")]
        public void WhenNumberAbsoluteValueIsBiggerOf21024ShouldConvertToInfinity(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A2.1.js", Description = "Number type represented as the double precision 64-bit format IEEE 754")]
        public void NumberTypeRepresentedAsTheDoublePrecision64BitFormatIEEE754(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A2.2.js", Description = "Number type represented as the extended precision 64-bit format IEEE 754")]
        public void NumberTypeRepresentedAsTheExtendedPrecision64BitFormatIEEE754(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A3.js", Description = "NaN expression has a type Number")]
        public void NaNExpressionHasATypeNumber(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A4.js", Description = "NaN is not a keyword")]
        public void NaNIsNotAKeyword(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A5.js", Description = "NaN not greater or equal zero")]
        public void NaNNotGreaterOrEqualZero(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A6.js", Description = "-Infinity expression has a type Number")]
        [TestCase("S8.5_A7.js", Description = "+Infinity expression has a type Number")]
        public void InfinityExpressionHasATypeNumber(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A8.js", Description = "Infinity is the same as +Infinity")]
        public void InfinityIsTheSameAsInfinity(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A9.js", Description = "Globally defined variable NaN has not been altered by program execution")]
        public void GloballyDefinedVariableNaNHasNotBeenAlteredByProgramExecution(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [Category("ECMA 8.5")]
        [TestCase("S8.5_A15.js", Description = "Number.toString(16) should return valid number")]
        public void ToStringBase16IsCorrect(string file)
        {
            RunFile(file);
        }
    }
}