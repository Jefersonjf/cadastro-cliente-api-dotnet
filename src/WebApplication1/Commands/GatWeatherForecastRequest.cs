using MediatR;

namespace WebApplication1.Commands
{
    public class GatWeatherForecastRequest : IRequest<IEnumerable<WeatherForecastResponse>>
    {
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set;}
    }
}
