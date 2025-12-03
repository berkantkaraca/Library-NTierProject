using Library.Entities.Enums;

namespace Library.Validators.ResponseModels.Categories
{
    public class CategoryResponseModel
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public DataStatus Status { get; set; }
    }
}
