﻿using System;
using System.Runtime.CompilerServices;
using Bridge.Test;
using Bridge.ClientTest;

#pragma warning disable 219

namespace Bridge.ClientTest.SimpleTypes
{
    [Category(Constants.MODULE_ENUM)]
    [TestFixture(TestNameFormat = "Enum - {0}")]
    public class EnumTests
    {
        public enum TestEnum
        {
            FirstValue,
            SecondValue,
            ThirdValue
        }

        [Flags]
        public enum FlagsEnum
        {
            None = 0,
            FirstValue = 1,
            SecondValue = 2,
            ThirdValue = 4
        }

        [Test]
        public void TypePropertiesAreCorrect()
        {
            //Assert.AreEqual(typeof(Enum).GetClassName(), "Bridge.Enum");
            Assert.AreEqual(typeof(TestEnum).GetClassName(), "Bridge.ClientTest.SimpleTypes.EnumTests.TestEnum");
            Assert.True((object)TestEnum.FirstValue is TestEnum);
        }

        private T GetDefaultValue<T>()
        {
            return default(T);
        }

        [IgnoreTest(Until = Constants.IGNORE_DATE)]
        [Test]
        public void DefaultValueOfEnumClassIsNull()
        {
            Assert.AreStrictEqual(GetDefaultValue<Enum>(), null);
        }

        [IgnoreTest(Until = Constants.IGNORE_DATE)]
        [Test]
        public void DefaultValueOfEnumTypeIsZero()
        {
            Assert.AreStrictEqual(GetDefaultValue<TestEnum>(), 0);
        }

        [IgnoreTest(Until = Constants.IGNORE_DATE)]
        [Test]
        public void DefaultConstructorOfEnumTypeReturnsZero()
        {
            Assert.AreStrictEqual(new TestEnum().ValueOf(), 0);
        }

        [Test]
        public void FirstValueOfEnumIsZero()
        {
            Assert.AreStrictEqual(TestEnum.FirstValue, 0);
        }

        [IgnoreTest(Until = Constants.IGNORE_DATE)]
        [Test]
        public void CreatingInstanceOfEnumTypeReturnsZero()
        {
            Assert.AreStrictEqual(Activator.CreateInstance<TestEnum>(), 0);
        }

        [IgnoreTest(Until = Constants.IGNORE_DATE)]
        [Test]
        public void DefaultExpressionWithEnumReturnsZero()
        {
            Assert.AreStrictEqual(default(TestEnum), 0);
        }

        [Test]
        public void GetHashCodeWorks()
        {
            Assert.AreEqual(TestEnum.FirstValue.GetHashCode(), TestEnum.FirstValue.GetHashCode());
            Assert.AreNotEqual(TestEnum.FirstValue.GetHashCode(), TestEnum.SecondValue.GetHashCode());
        }

        [Test]
        public void EqualsWorks()
        {
            Assert.True(TestEnum.FirstValue.Equals(TestEnum.FirstValue));
            Assert.False(TestEnum.FirstValue.Equals(TestEnum.SecondValue));
        }

        // Feature #347
        //[Test]
        //public void ParseWorks()
        //{
        //    Assert.AreEqual((TestEnum)Enum.Parse(typeof(TestEnum), "FirstValue"), TestEnum.FirstValue);
        //    Assert.AreEqual((TestEnum)Enum.Parse(typeof(FlagsEnum), "FirstValue | ThirdValue"), FlagsEnum.FirstValue | FlagsEnum.ThirdValue);
        //}

        // Feature #347
        //[Test]
        //public void StaticToStringWorks()
        //{
        //    Assert.AreEqual(Enum.ToString(typeof(TestEnum), TestEnum.FirstValue), "FirstValue");
        //    Assert.AreEqual(Enum.ToString(typeof(FlagsEnum), FlagsEnum.FirstValue | FlagsEnum.ThirdValue), "FirstValue | ThirdValue");
        //}

        // Feature #347
        //[Test]
        //public void ConversionsToEnumAreTreatedAsConversionsToTheUnderlyingType() {
        //    Assert.AreEqual((TestEnum)(object)0, 0);
        //    Assert.Throws(() => { var _ = (TestEnum)(object)0.5; });
        //}

        // Feature #347
        //[Test]
        //public void GetValuesWorks()
        //{
        //    Array values = Enum.GetValues(typeof(TestEnum));
        //    Assert.AreEqual(values.Length, 3);
        //    Assert.AreEqual(values.GetValue(0), TestEnum.FirstValue);
        //    Assert.AreEqual(values.GetValue(1), TestEnum.SecondValue);
        //    Assert.AreEqual(values.GetValue(2), TestEnum.ThirdValue);

        //    values = Enum.GetValues(typeof(FlagsEnum));
        //    Assert.AreEqual(values.Length, 4);
        //    Assert.AreEqual(values.GetValue(0), FlagsEnum.None);
        //    Assert.AreEqual(values.GetValue(1), FlagsEnum.FirstValue);
        //    Assert.AreEqual(values.GetValue(2), FlagsEnum.SecondValue);
        //    Assert.AreEqual(values.GetValue(3), FlagsEnum.ThirdValue);
        //}
    }
}
