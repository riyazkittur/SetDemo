using System;
using Xunit;

namespace SetData.Tests
{
    public class SetDataTest
    {
        /**unique elements*/
        //Order of elements is of no significance
        [Fact]
        public void IsEmptySetTest()
        {
            SetData empty = new SetData();
            Assert.True(empty.IsEmpty());

            SetData one = new SetData();
            one.Add("1");
            Assert.False(one.IsEmpty());

            SetData three = new SetData();
            three.Add("1");
            three.Add("2");
            three.Add("3");

            Assert.False(three.IsEmpty());
        }
        [Fact]
        public void CountTest()
        {
            SetData empty = new SetData();
            Assert.Equal(0,empty.Count());

            SetData one = new SetData();
            one.Add("1");
            Assert.Equal(1, one.Count());

            SetData three = new SetData();
            three.Add("1");
            three.Add("2");
            three.Add("3");
            Assert.Equal(3, three.Count());
        }
        

    }
}
