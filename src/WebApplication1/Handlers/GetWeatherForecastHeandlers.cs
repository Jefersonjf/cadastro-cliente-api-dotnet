using MediatR;
using WebApplication1.Commands;

namespace WebApplication1.Handlers
{
    public class GetWeatherForecastHeandlers : IRequestHandler<GetWeatherForecastRequest, IEnumerable<WeatherForecastResponse>>
    {
        public Task<IEnumerable<WeatherForecastResponse>> Handle(GetWeatherForecastRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
