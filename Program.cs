using TradingBotCSharp.DataAccess.Gateways;

public class Program
{
    public static void Main(String[] args)
    {
        ITradingDataGateway tradingDataGateway = new CsvTradingDataGateway();

        tradingDataGateway.GetDay1HistoricalDataOfPeriod();
    }
}