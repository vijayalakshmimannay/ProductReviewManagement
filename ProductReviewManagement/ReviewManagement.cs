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
        //UC2
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
    }
}