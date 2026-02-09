using System;
using TempUnitConverter;
using Xunit;

namespace TempUnitConverterTest
{
    public class UnitTest1
    {

        TUConverter conv = new TUConverter();


        [Fact]
        public void CToFTest()
        {
            Assert.Equal(50, conv.CToF(10));
        }

        [Fact]
        public void CToKTest()
        {
            Assert.Equal(283.15, conv.CToK(10));
        }

        [Fact]
        public void FToCTest()
        {
            Assert.Equal(0, conv.FToC(32));
        }

        [Fact]
        public void FToKTest()
        {
            Assert.Equal(273.15, conv.FToK(32));
        }

        [Fact]
        public void KToCTest()
        {
            Assert.Equal(-273.15, conv.KToC(0));
        }

        [Fact]
        public void KToFTest()
        {
            Assert.Equal(-459.66999999999996, conv.KToF(0));
        }


    }
}
