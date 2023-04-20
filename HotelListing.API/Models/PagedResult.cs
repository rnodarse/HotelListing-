namespace HotelListing.API.Models
{
    public class PagedResult<T>
    {
        public int TotalCount { get; set; }
        public int OmittedRecords { get; set; }
        public double TotalPages { get; set; }
        public int RecordsPerPage { get; set; }
        private int pageNumber;
        public int PageNumber
        {
            get { return pageNumber; }
            set
            {
                if (value > 1)
                    pageNumber = value;
                else
                    pageNumber = 1;
            }
        }
        public List<T> Items { get; set; }

    }
}
