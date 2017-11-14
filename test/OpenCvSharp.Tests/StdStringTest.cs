﻿using System;
using Xunit;

namespace OpenCvSharp.Tests
{
    // ReSharper disable InconsistentNaming
    
    public class StdStringTest : TestBase
    {
        [Fact]
        public void SimpleNew()
        {
            using (var s = new StdString())
            {
            }
        }

        [Fact]
        public void ToStringSinglebyte()
        {
            const string value = "foo";
            using (var s = new StdString(value))
            {
                Assert.Equal(value, s.ToString());
            }
        }

        [Fact]
        public void ToStringMultibyte()
        {
            const string value = "ＯｐｅｎＣＶ";
            using (var s = new StdString(value))
            {
                Assert.Equal(value, s.ToString());
            }
        }
    }
}