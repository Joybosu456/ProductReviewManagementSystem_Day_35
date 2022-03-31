using System;
using System.Collections.Generic;
using System.Linq;
namespace ProductReviewManagement
{
    class Program
    {
        /// <summary>
        /// 
        /// UC_1 completed
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Review management Program");
            List<ProductReview> listProductReview = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserId=11,Rating=3,Review="Good",IsLike=true},
                new ProductReview(){ProductID=2,UserId=15,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=3,UserId=1,Rating=4,Review="Good",IsLike=false},
                new ProductReview(){ProductID=4,UserId=9,Rating=2,Review="nice",IsLike=true},
                new ProductReview(){ProductID=5,UserId=2,Rating=3,Review="Good",IsLike=true},
                new ProductReview(){ProductID=6,UserId=5,Rating=3,Review="Bad",IsLike=false},
                new ProductReview(){ProductID=7,UserId=2,Rating=1,Review="Good",IsLike=false},
                new ProductReview(){ProductID=8,UserId=4,Rating=1,Review="bad",IsLike=true},
                new ProductReview(){ProductID=9,UserId=8,Rating=2,Review="bad",IsLike=false},
                new ProductReview(){ProductID=10,UserId=3,Rating=4,Review="Good",IsLike=true},
                    new ProductReview(){ProductID=11,UserId=7,Rating=3,Review="bad",IsLike=false},
                new ProductReview(){ProductID=12,UserId=13,Rating=2,Review="Good",IsLike=true},
                new ProductReview(){ProductID=13,UserId=17,Rating=1,Review="Good",IsLike=false},
                new ProductReview(){ProductID=14,UserId=15,Rating=5,Review="bad",IsLike=true},
                new ProductReview(){ProductID=15,UserId=19,Rating=4,Review="Good",IsLike=false},
                new ProductReview(){ProductID=16,UserId=19,Rating=2,Review="bad",IsLike=false},
                new ProductReview(){ProductID=17,UserId=18,Rating=1,Review="Good",IsLike=false},
                new ProductReview(){ProductID=18,UserId=12,Rating=3,Review="Good",IsLike=true},
                new ProductReview(){ProductID=19,UserId=10,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=20,UserId=17,Rating=4,Review="Good",IsLike=false},
            };
            foreach (var list in listProductReview)
            {
                Console.WriteLine("ProductID:" + list.ProductID + "UserId" + list.UserId + "Rating" + list.Rating + "Review" + list.Review + "IsLike" + list.IsLike); ;
            }
            Management management = new Management();
           management.TopRecordsList(listProductReview);
            //management.SelectedRecordList(listProductReview);
           // management.CountOfRecords(listProductReview);
        }
    }
}