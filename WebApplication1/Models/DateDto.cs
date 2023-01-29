using Entities;

namespace MyApi
{
    public class DateDto : BaseDto<DateDto, Date, Guid>
    {
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public int Cost { get; set; }
        public int ModelId { get; set; }
    }

    public class DateSelectDto : BaseDto<DateSelectDto, Date, Guid>
    {
        public string customdate { get; set; }
        public int Cost { get; set; }
        public string ModelName { get; set; }
        public string CarName { get; set; }
        public string CompanyName { get; set; }

        public override void CustomMappings(IMappingExpression<Date, DateSelectDto> mappingExpression)
        {
            mappingExpression.ForMember(
                    dest => dest.Date,
                    config => config.MapFrom(src => src.customdate.ToString()));
        }
    }
}
