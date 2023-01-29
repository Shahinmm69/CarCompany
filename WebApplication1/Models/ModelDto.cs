using Entities;

namespace MyApi
{
    public class ModelDto : BaseDto<ModelDto, Model, Guid>
    {
        public string ModelName { get; set; }
        public int CarId { get; set; }
    }

    public class ModelSelectDto : BaseDto<ModelSelectDto, Model, Guid>
    {
        public string ModelName { get; set; }
        public string CarName { get; set; }
        public string CompanyName { get; set; }
    }
}
