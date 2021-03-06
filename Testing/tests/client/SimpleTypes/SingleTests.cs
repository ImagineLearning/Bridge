﻿using System;
using System.Runtime.CompilerServices;
using Bridge.Test;
using Bridge.ClientTest;

namespace Bridge.ClientTest.SimpleTypes
{
    [Category(Constants.MODULE_FLOAT)]
    [TestFixture(TestNameFormat = "Float - {0}")]
    public class SingleTests
    {
        [Test]
        public void TypePropertiesAreCorrect()
        {
            Assert.True((object)(float)0.5 is float);
            Assert.AreEqual(typeof(float).GetClassName(), "Number");

            object f = (float)0;
            Assert.True(f is float);
            Assert.True(f is IFormattable);
        }

        private T GetDefaultValue<T>()
        {
            return default(T);
        }

        [Test]
        public void DefaultValueIs0()
        {
            Assert.AreStrictEqual(GetDefaultValue<float>(), 0);
        }

        [IgnoreTest(Until = Constants.IGNORE_DATE)]
        [Test]
        public void CreatingInstanceReturnsZero()
        {
            Assert.AreStrictEqual(Activator.CreateInstance<float>(), 0);
        }

        [Test]
        public void ConstantsWork()
        {
            double zero = 0;
            Assert.True((float)(object)float.MinValue < -3.4e38 && (float)(object)float.MinValue > -3.5e38, "MinValue should be correct");
            Assert.True((float)(object)float.MaxValue > 3.4e38 && (float)(object)float.MaxValue < 3.5e38, "MaxValue should be correct");
            Assert.AreEqual(float.Epsilon, /*1.40129846432482E-45*/1.401298e-45, "Epsilon should be correct");
            Assert.True(float.IsNaN(float.NaN), "NaN should be correct");
            Assert.AreStrictEqual(float.PositiveInfinity, 1 / zero, "PositiveInfinity should be correct");
            Assert.AreStrictEqual(float.NegativeInfinity, -1 / zero, "NegativeInfinity should be correct");
        }

        [Test]
        public void DefaultConstructorReturnsZero()
        {
            Assert.AreStrictEqual(new float(), 0);
        }

        [Test]
        public void FormatWorks()
        {
            Assert.AreEqual(((float)291.0).Format("x"), "123");
        }

        [Test]
        public void IFormattableToStringWorks()
        {
            Assert.AreEqual(((float)291.0).ToString("x"), "123");
        }

        [Test]
        public void ToStringWorks()
        {
            Assert.AreEqual(((float)123.0).ToString(), "123");
        }

        [Test]
        public void ToExponentialWorks()
        {
            Assert.AreEqual(((float)123.0).ToExponential(), "1.23e+2");
        }

        [Test]
        public void ToExponentialWithFractionalDigitsWorks()
        {
            Assert.AreEqual(((float)123.0).ToExponential(1), "1.2e+2");
        }

        [Test]
        public void ToFixed()
        {
            Assert.AreEqual(((float)123.0).ToFixed(), "123");
        }

        [Test]
        public void ToFixedWithFractionalDigitsWorks()
        {
            Assert.AreEqual(((float)123.0).ToFixed(1), "123.0");
        }

        [Test]
        public void ToPrecisionWorks()
        {
            Assert.AreEqual(((float)12345.0).ToPrecision(), "12345");
        }

        [Test]
        public void ToPrecisionWithPrecisionWorks()
        {
            Assert.AreEqual(((float)12345.0).ToPrecision(2), "1.2e+4");
        }

        [Test]
        public void IsPositiveInfinityWorks()
        {
            float inf = 1.0f / 0.0f;
            // TODO Bug
            //Assert.True (float.IsPositiveInfinity(inf));
            Assert.False(float.IsPositiveInfinity(-inf));
            Assert.False(float.IsPositiveInfinity(0.0f));
            Assert.False(float.IsPositiveInfinity(Single.NaN));
        }

        [Test]
        public void IsNegativeInfinityWorks()
        {
            float inf = 1.0f / 0.0f;
            Assert.False(float.IsNegativeInfinity(inf));
            Assert.True(float.IsNegativeInfinity(-inf));
            Assert.False(float.IsNegativeInfinity(0.0f));
            Assert.False(float.IsNegativeInfinity(Single.NaN));
        }

        [Test]
        public void IsInfinityWorks()
        {
            float inf = 1.0f / 0.0f;
            Assert.True(float.IsInfinity(inf));
            Assert.True(float.IsInfinity(-inf));
            Assert.False(float.IsInfinity(0.0f));
            Assert.False(float.IsInfinity(Single.NaN));
        }

        [Test]
        public void IsFiniteWorks()
        {
            float zero = 0, one = 1;
            Assert.True(float.IsFinite(one));
            Assert.False(float.IsFinite(one / zero));
            Assert.False(float.IsFinite(zero / zero));
        }

        [Test]
        public void IsNaNWorks()
        {
            float zero = 0, one = 1;
            Assert.False(float.IsNaN(one));
            Assert.False(float.IsNaN(one / zero));
            Assert.True(float.IsNaN(zero / zero));
        }

        [Test]
        public void GetHashCodeWorks()
        {
            Assert.AreEqual(((float)0).GetHashCode(), ((float)0).GetHashCode());
            Assert.AreEqual(((float)1).GetHashCode(), ((float)1).GetHashCode());
            Assert.AreNotEqual(((float)0).GetHashCode(), ((float)1).GetHashCode());
            Assert.AreNotEqual(((float)0).GetHashCode(), ((float)0.5).GetHashCode());
        }

        [Test]
        public void EqualsWorks()
        {
            Assert.True(((float)0).Equals((object)(float)0));
            Assert.False(((float)1).Equals((object)(float)0));
            Assert.False(((float)0).Equals((object)(float)0.5));
            Assert.True(((float)1).Equals((object)(float)1));
        }

        [IgnoreTest(Until = Constants.IGNORE_DATE)]
        [Test]
        public void IEquatableEqualsWorks()
        {
            Assert.True(((float)0).Equals((float)0));
            Assert.False(((float)1).Equals((float)0));
            Assert.False(((float)0).Equals((float)0.5));
            Assert.True(((float)1).Equals((float)1));

            Assert.True(((IEquatable<float>)((float)0)).Equals((float)0));
            Assert.False(((IEquatable<float>)((float)1)).Equals((float)0));
            Assert.False(((IEquatable<float>)((float)0)).Equals((float)0.5));
            Assert.True(((IEquatable<float>)((float)1)).Equals((float)1));
        }

        [Test]
        public void CompareToWorks()
        {
            Assert.True(((float)0).CompareTo((float)0) == 0);
            Assert.True(((float)1).CompareTo((float)0) > 0);
            Assert.True(((float)0).CompareTo((float)0.5) < 0);
            Assert.True(((float)1).CompareTo((float)1) == 0);
        }

        [IgnoreTest(Until = Constants.IGNORE_DATE)]
        [Test]
        public void IComparableCompareToWorks()
        {
            Assert.True(((IComparable<float>)((float)0)).CompareTo((float)0) == 0);
            Assert.True(((IComparable<float>)((float)1)).CompareTo((float)0) > 0);
            Assert.True(((IComparable<float>)((float)0)).CompareTo((float)0.5) < 0);
            Assert.True(((IComparable<float>)((float)1)).CompareTo((float)1) == 0);
        }
    }
}
