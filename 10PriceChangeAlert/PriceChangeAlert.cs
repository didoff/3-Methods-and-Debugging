using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());

        double priceTreshold = double.Parse(Console.ReadLine());

        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double differance = ProcentageTreshold(lastPrice, currentPrice);
            bool isSignificantDifference = imaliDif(differance, priceTreshold);

            string message = Get(currentPrice, lastPrice, differance, isSignificantDifference);
            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    private static string Get(double c, double last, double razlika, bool etherTrueOrFalse)
    {
        string message = "";
        if (razlika == 0)
        {
            message = string.Format("NO CHANGE: {0}", c);
        }
        else if (!etherTrueOrFalse)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, razlika);
        }
        else if (etherTrueOrFalse && (razlika > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, razlika);
        }
        else if (etherTrueOrFalse && (razlika < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, razlika);
        return message;
    }

    private static bool imaliDif(double priceTreshold, double isDiff)
    {
        if (Math.Abs(priceTreshold) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double ProcentageTreshold(double lastPrice, double currentPrice)
    {
        double procentageSignificance = (currentPrice - lastPrice) / lastPrice;
        return procentageSignificance;
    }
}
