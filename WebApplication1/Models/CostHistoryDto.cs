using Entities;
using WebFramework.Api;

namespace MyApi
{
    public class CostHistoryDto : BaseDto<CostHistoryDto, CostHistory>
    {
        public static int Year { get; set; }
        public static int Month { get; set; }
        public static int Day { get; set; }
        public int Cost { get; set; }
        public int ModelId { get; set; }

        private CustomDate _customdate;

        public CustomDate customdate
        {
            get { return new CustomDate { Day = CostHistoryDto.Year, Month = CostHistoryDto.Month, Year = CostHistoryDto.Year }; }
            set { _customdate = value; }
        }

    }

    public class CostHistorySelectDto : BaseDto<CostHistorySelectDto, CostHistory>
    {
        public string customdate { get; set; }
        public int Cost { get; set; }
        public string ModelName { get; set; }
        public string CarName { get; set; }
        public string CompanyName { get; set; }

        public override void CustomMappings(IMappingExpression<CostHistory, CostHistorySelectDto> mappingExpression)
        {
            mappingExpression.ForMember(
                    dest => dest.customdate,
                    config => config.MapFrom(src => src.customdate.ToString()));
        }
    }
}
