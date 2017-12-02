﻿using System;
using System.Globalization;
using System.Windows;
using FanoMvvm.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FanoMVVM.UnitTests
{
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void BoolToVisibilityConverter_Convert()
        {
            var converter = new BoolToVisibilityConverter();

            var convertedValue = (Visibility) converter.Convert(true, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.IsNotNull(convertedValue);
            Assert.AreEqual(Visibility.Visible, convertedValue);
        }

        [TestMethod]
        public void BoolToVisibilityConverter_ConvertBack()
        {
            Assert.ThrowsException<NotSupportedException>(() =>
            {
                var converter = new BoolToVisibilityConverter();
                converter.ConvertBack(true, typeof(Visibility), null, CultureInfo.CurrentCulture);
            });
        }
    }
}