using Entities;

namespace MyApi
{
    public class ImageDto : BaseDto<DateDto, Date, Guid>
    {
        public BitMap CarImage { get; set; }
        public int ModelId { get; set; }
    }

    public class ImageSelectDto : BaseDto<DateSelectDto, Date, Guid>
    {
        public BitMap CarImage { get; set; }
        public string ModelName { get; set; }
        public string CarName { get; set; }
        public string CompanyName { get; set; }
    }
}

