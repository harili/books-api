using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.ViewModels
{
    public class BookVM
    {
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsRead { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateRead { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Genre { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ConverUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
    }
}
