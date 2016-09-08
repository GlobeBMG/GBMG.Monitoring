namespace GBMG.Monitoring
{
    public interface IMetricLogger
    {
        void IncrementMetric(string metricName);
        void IncrementMetric(string metricName, int increment);
        void LogTimedEvent(string metricName, int milliseconds);
        void MeasureMetric(string metricName, int value);
    }
}
