namespace ProductReviewManagement
{
    public class ReviewManagement
    {
        //UC1
        public void getReview(List<ProductReview> productReviewList)
        {
            foreach (var item in productReviewList)
            {
                Console.WriteLine("Product ID: " + item.ProductID + "\tUser ID: " + item.UserID + "\tRating: " + item.Rating + "\tReview: " + item.Review + "\tisLike: " + item.isLike);
            }

        }
        //UC2 to get top 3 records having high rateings
        public void TopRecords(List<ProductReview> productReviewList)
        {
            var result = (from product in productReviewList
                          orderby product.Rating descending
                          select product).Take(3);
            foreach (var item in result)
            {
                Console.WriteLine("Product ID: " + item.ProductID + "\tUser ID: " + item.UserID + "\tRating: " + item.Rating + "\tReview: " + item.Review + "\tisLike: " + item.isLike);
            }
        }
        //UC3 Retrieve all record from the list who’s rating are greater than 3 and productID is 1 or 4 or 9
        public void SelectRecords(List<ProductReview> productReviewList)
        {
            var recordData = (from product in productReviewList
                              where product.Rating > 3 &&
                          (product.ProductID == 1 || product.ProductID == 4 || product.ProductID == 9)
                              select product);
            Console.WriteLine("Record having ratings greater than 3 and who's product ID is 1 or 4 or 9.");
            foreach (var item in recordData)
            {
                Console.WriteLine("Product ID: " + item.ProductID + "\tUser ID: " + item.UserID + "\tRating: " + item.Rating + "\tReview: " + item.Review + "\tisLike: " + item.isLike);

            }
        }
        //UC4 Retrieve count of review present for each productID
        public void CountOfReviewForEachProductID(List<ProductReview> productReviewList)
        {
            var data = (productReviewList.GroupBy(productReview => productReview.ProductID).Select(p => new { ProductID = p.Key, Count = p.Count() }));
            Console.WriteLine("Product ID|Count");
            foreach (var list in data)
            {
                Console.WriteLine(list.ProductID + "--" + list.Count);
            }
        }
        //UC5 Retrieve only productID and review from the list for all records
        public void RetriveproductIDAndReviewFromList(List<ProductReview> productReviewList)
        {
            var data = (from productReview in productReviewList
                        select new { ProductID = productReview.ProductID, Review = productReview.Review });
            Console.WriteLine("Product ID|Review");
            foreach (var list in data)
            {
                Console.WriteLine(list.ProductID + "--" + list.Review);
            }
        }
    }
}