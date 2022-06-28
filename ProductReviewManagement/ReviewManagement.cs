﻿using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProductReviewManagement
{
    public class ReviewManagement
    {
        //UC1 Create List andadd 25 default values
        public void getReview(List<ProductReview> productReviewList)
        {
            foreach (var item in productReviewList)
            {
                Console.WriteLine("Product ID: " + item.ProductID + "\tUser ID: " + item.UserID + "\tRating: " + item.Rating + "\tReview: " + item.Review + "\tisLike: " + item.isLike);
            }

        }
        //UC2 get top 3 records having high ratings
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
        //UC6 skip top 5 records from the list and display other records
        public void SkipTop5RecordsFromList(List<ProductReview> productReviewList)
        {
            var result = (from product in productReviewList
                          select product).Skip(5);
            Console.WriteLine("Records after skipping top 5.");
            foreach (var item in result)
            {
                Console.WriteLine("Product ID: " + item.ProductID + "\tUser ID: " + item.UserID + "\tRating: " + item.Rating + "\tReview: " + item.Review + "\tisLike: " + item.isLike);
            }
        }
        //UC7 Retrieve only ProductID and Review from records
        public void RetrieveProductIDAndReviewUsingSelectLINQ(List<ProductReview> productReviewList)
        {
            var result = productReviewList.Select(reviews => new { ProductID = reviews.ProductID, Review = reviews.Review });
            Console.WriteLine("Product ID\t|\tReview");
            foreach (var list in result)
            {
                Console.WriteLine(list.ProductID + "  --  " + list.Review);
            }
        }
        //UC 8 Create Datatable and add 25 default values in it.
        public DataTable CreateDataTable(List<ProductReview> productReviews)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID", typeof(Int32));
            table.Columns.Add("UserID", typeof(Int32));
            table.Columns.Add("Rating", typeof(Int32));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("isLike", typeof(bool));
            foreach (var item in productReviews)
            {
                table.Rows.Add(item.ProductID, item.UserID, item.Rating, item.Review, item.isLike);
            }
            Console.WriteLine("Records in DataTable");
            foreach (var item in table.AsEnumerable())
            {
                Console.WriteLine("ProductID: " + item.Field<int>("ProductID") + " " + " " + "UserID: " + " " + item.Field<int>("UserID") + "\tRating: " + item.Field<int>("Rating") + "\tReview: " + item.Field<string>("Review") + "\tisLike: " + item.Field<bool>("isLike"));
            }
            return table;
        }
        //UC9 Retrieve all Records from datatable who's isLike value is true 
        public void isLikeValueisTrue(DataTable table)
        {
            var data = (from product in table.AsEnumerable()
                          where product.Field<bool>("isLike") == true
                          select product);
            Console.WriteLine("\nRecords Who's value is true.\n");
            foreach (var item in data)
            {
                Console.WriteLine("ProductID: " + item.Field<int>("ProductID") + "\tUserID: " + item.Field<int>("UserID") + "\tRating: " + item.Field<int>("Rating") + "\tReview: " + item.Field<string>("Review") + "\tisLike: " + item.Field<bool>("isLike"));
            }
        }
        // UC10 Find Average rating of the each ProductID 
        public void AverageRatingOfEachProductID(DataTable table)
        {
            var result = table.AsEnumerable().GroupBy(table => table.Field<int>("ProductID")).Select(field => new
            {
                ProductID = field.Key,
                Average = field.Average(x => x.Field<int>("Rating"))
            });
            Console.WriteLine("Average rating of each productID.");
            foreach (var item in result)
            {
                Console.WriteLine("ProductID: " + item.ProductID + " --- " + "Average: " + item.Average);
            }
        }
        //UC11 Retrieve all records from list whose contains review message "Nice"
        public void ReviewMessageNice(DataTable table)
        {
            var result = from product in table.AsEnumerable()
                         where product.Field<string>("Review") == "Nice"
                         select product;
            Console.WriteLine("Records having review Nice:");
            foreach (var item in result)
            {
                Console.WriteLine("ProductID: " + item.Field<int>("ProductID") + "\tUserID: " + item.Field<int>("UserID") + "\tRating: " + item.Field<int>("Rating") + "\tReview: " + item.Field<string>("Review") + "\tisLike: " + item.Field<bool>("isLike"));
            }
        }
        //UC12 Retrieve all records from list whose USerID = 10 and order by rating
        public void RetrieveUserID10Records(DataTable table)
        {
            var result = from product in table.AsEnumerable()
                         where product.Field<int>("UserID") == 10
                         orderby product.Field<int>("Rating") descending
                         select product;
            Console.WriteLine("Records having review Nice");
            foreach (var item in result)
            {
                Console.WriteLine("ProductID " + item.Field<int>("ProductID") + "\tUserID " + item.Field<int>("UserID") + "\tRating " + item.Field<int>("Rating") + "\tReview " + item.Field<string>("Review") + "\tisLike: " + item.Field<bool>("isLike"));
            }
        }

    }
}