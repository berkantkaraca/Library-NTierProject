using Library.Entities.Enums;

namespace Library.Validators.ResponseModels.Tags
{
    public class TagResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DataStatus Status { get; set; }
    }
}
