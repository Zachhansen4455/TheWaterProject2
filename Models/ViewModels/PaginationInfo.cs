namespace TheWaterProject2.Models.ViewModels
{
    public class PaginationInfo
    {

        //keep track of how many items and how many per page
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }    
        public int TotalPages => (int) (Math.Ceiling((decimal) TotalItems / ItemsPerPage));
    }
}
