using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductReviewManagement
{
    public class Management
    {
        /// <summary>
        /// 
        /// UC_2 Completed
        /// </summary>
        /// <param name="reviews"></param>
        public void TopRecordsList(List<ProductReview> reviews)
        {
            var recordData = (from productreviews record in reviews
                              orderby productreviews.Rating descending
                              select productreviews).Take(3);

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID:" + list.ProductID + "UserId" + list.UserId + "Rating" + list.Rating + "Review" + list.Review + "IsLike" + list.IsLike); ;
            }
        }

        /// <summary>
        /// 
        /// UC_3 completed
        /// </summary>
        /// <param name="reviews"></param>
        public void SelectedRecordList(List<ProductReview> reviews)
        {
            var recordData = (from productreviews record in reviews
                              where (productreviews.ProductId == 1 && productreviews > 3)
                              || (productreviews.ProductId == 4 && productreviews > 3)
                              || (productreviews.ProductId == 9 && productreviews > 3)
                              select productreviews);

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID:" + list.ProductID + "UserId" + list.UserId + "Rating" + list.Rating + "Review" + list.Review + "IsLike" + list.IsLike); ;
            }
        }

        /// <summary>
        /// 
        /// UC_4 completed
        /// </summary>
        /// <param name="reviews"></param>
        public void CountOfRecords(List<ProductReview> reviews)
        {
            var recordData = reviews.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID:" + list.ProductID + "Count:" + list.Count);
            }
        }

    }
}
