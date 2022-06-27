using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management problem statement");
            //UC1 
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 2, UserID = 2, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductID = 3, UserID = 3, Rating = 4, Review = "Nice", isLike = true },
                new ProductReview() { ProductID = 4, UserID = 4, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 5, UserID = 5, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductID = 6, UserID = 10, Rating = 4, Review = "Nice", isLike = true },
                new ProductReview() { ProductID = 7, UserID = 6, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductID = 8, UserID = 5, Rating = 2, Review = "Bad", isLike = true },
                new ProductReview() { ProductID = 9, UserID = 10, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 10, UserID = 41, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductID = 11, UserID = 5, Rating = 4, Review = "Nice", isLike = false },
                new ProductReview() { ProductID = 12, UserID = 4, Rating = 1, Review = "VeryBad", isLike = true },
                new ProductReview() { ProductID = 13, UserID = 48, Rating = 5, Review = "Good", isLike = false },
                new ProductReview() { ProductID = 14, UserID =41, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductID = 15, UserID = 51, Rating = 4, Review = "Nice", isLike = true },
                new ProductReview() { ProductID = 16, UserID = 8, Rating = 1, Review = "VeryBad", isLike = false },
                new ProductReview() { ProductID = 17, UserID = 18, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductID = 18, UserID = 9, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 19, UserID = 10, Rating = 4, Review = "Nice", isLike = false },
                new ProductReview() { ProductID = 20, UserID = 7, Rating = 3, Review = "Average", isLike = false },
                new ProductReview() { ProductID = 21, UserID = 22, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 22, UserID = 25, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductID = 23, UserID = 19, Rating = 2, Review = "Bad", isLike = true },
                new ProductReview() { ProductID = 24, UserID = 56, Rating = 4, Review = "Nice", isLike = false },
                new ProductReview() { ProductID = 25, UserID = 67, Rating = 1, Review = "VeryBad", isLike = false },

            };
            ProductReviewManagement.ReviewManagement reviewManagement = new ProductReviewManagement.ReviewManagement();
            reviewManagement.getReview(productReviewList);

        }
    }
}
