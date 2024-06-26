using Domain;
using MelbergFramework.Infrastructure.InfluxDB;
namespace Infrastructure.InfluxDB.Mappers;

public static class MetricMapper
{
    public static InfluxDBDataModel ToDataModel(this Metric metric)
    {
        var result = new InfluxDBDataModel("service_data");

        result.Measurement = "duration";
        result.Tags["app"] = metric.Application;
        result.Fields["duration"] = metric.TimeInMS;
        result.Timestamp = metric.TimeStamp;

        return result;
    }
}
