namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        [Fact]
        public void AddPositiveNumbers()
        {
            Assert.Equal(7, Add(3, 4));
        }

        [Fact]
        public void AddNegativeNumbers()
        {
            Assert.Equal(-5, Add(-3, -2));
        }

        [Fact]
        public void AddPositiveAndNegativeNumbers()
        {
            Assert.Equal(1, Add(3, -2));
        }

        [Fact]
        public void AddZero()
        {
            Assert.Equal(2, Add(2, 0));
            Assert.Equal(-2, Add(0, -2));
        }

        [Fact]
        public void AddLargeNumbers()
        {
            Assert.Equal(2000000000, Add(1000000000, 1000000000));
        }

        [Fact]
        public void AddWithMaxInt()
        {
            Assert.Equal(int.MaxValue, Add(int.MaxValue, 0));
        }

        [Fact]
        public void AddWithMinInt()
        {
            Assert.Equal(int.MinValue, Add(int.MinValue, 0));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}