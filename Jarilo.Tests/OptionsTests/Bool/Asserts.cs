﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Jarilo.Tests.OptionsTests.Bool
{
    static class Asserts
    {
        public static void AssertOption(this string[] output, bool expectedValue)
        {
            Assert.Equal(1, output.Length);
            Assert.Equal(Command.Message(expectedValue), output[0]);
        }
    }
}
