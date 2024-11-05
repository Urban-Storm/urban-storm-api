using Urban.Storm.Domain;
using Urban.Storm.Domain.Catalog;

namespace Urban.Storm.Domain.Tests;

[TestClass]
public class ItemTests
{
    [TestMethod]
    public void Can_Create_New_Item()
    {
        var item = new Item("Name", "Description", "Brand", 10.00m);

        Assert.AreEqual("Name", item.Name);
        Assert.AreEqual("Description", item.Description);
        Assert.AreEqual("Brand", item.Brand);
        Assert.AreEqual(10.00m, item.Price);

    }
    [TestMethod]
    public void Can_Create_Add_Rating() {
        //Arrange
        var item = new Item("Name", "Description", "Brand", 10.00m);
        var rating = new Rating(5, "Name", "Review");

        //act
        item.AddRating(rating);

        //assert
        Assert.AreEqual("Rating", item.Ratings[0]);
    }
}