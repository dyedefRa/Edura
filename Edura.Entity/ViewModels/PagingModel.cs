using System;
using System.Collections.Generic;
using System.Text;

namespace Edura.Entity.ViewModels
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
        }
    }

    public class PagingModel<T>
    {
        public IEnumerable<T> RelatedItems { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
