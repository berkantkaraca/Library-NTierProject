using Library.Entities.Enums;

namespace Library.Validators.ResponseModels.Authors
{
    public class AuthorResponseModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DataStatus Status { get; set; }
    }
}
