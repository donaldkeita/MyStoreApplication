using Xunit;
using StoreApplication.App;

namespace StoreApplication.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // ARRANGE - any set up that is required to perform the test

        // ACT - where we invoke the behavior to test

        // ASSERT - compare the result of the ACT to an expected value

        // Check if the testing can be compiled and built.
        Assert.Equal(true, true);
    }

    // typical naming convention
    // Add a product and test we have if we get the product as we expected
    [Fact]
    public void testProduct() {
        //
        // ARRANGE - any set up that is required to perform the test
        // expected data
        string productType = "Cell phone";
        string productName = "Pixel 6";
        int quantity = 4;
        double cost = 580.50;

        // ACT - where we invoke the behavior to test
        var testProduct = new Product("Cell phone", "Pixel 6", 4, 584.50);

        // ASSERT - compare the result of the ACT to an expected value
        Assert.Equal(productType, testProduct.productType);

    }
}