namespace HotelListing.API.Models
{
    public class QueryParameters
    {
        private int _recordsPerPage = 3;
        public int StartIndex { get; set; }
        public int PageNumber { get; set; }
        public int RecordsPerPage
        {
            get
            {
                return _recordsPerPage;
            }
            set
            {
                _recordsPerPage = value;
            }
        }
    }
}
