using Entities;

namespace MyApi
{
    public class CarDto : BaseDto<CarDto, Car, Guid>
    {
        public string CarName { get; set; }
        public int CompanyId { get; set; }
    }

    public class CarSelectDto : BaseDto<CarSelectDto, Car, Guid>
    {
        public string CarName { get; set; }
        public string CompanyName { get; set; }
    }
}
