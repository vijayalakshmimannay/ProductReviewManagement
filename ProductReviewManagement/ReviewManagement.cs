namespace ProductReviewManagement
{
    public class ReviewManagement
    {
        public void getReview(List<ProductReview> productReviewList)
        {
            foreach (var item in productReviewList)
            {
                Console.WriteLine("Product ID: " + item.ProductID + "\tUser ID: " + item.UserID + "\tRating: " + item.Rating + "\tReview: " + item.Review + "\tisLike: " + item.isLike);
            }

        }
    }
}