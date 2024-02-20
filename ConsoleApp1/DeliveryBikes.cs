namespace ConsoleApp1;
public static class DeliveryBikes
{
    public static int NumberOfBicycles(int[] packageWeights, int N)
    {
        var inOnPackage = packageWeights.Count(x => x == N);
        var packageWeightsNonN = packageWeights.Where(x => x != N).ToArray();

        var pairPackages = CountPairs(packageWeightsNonN, N);

        return inOnPackage + pairPackages;
    }
    public static int CountPairs(int[] packageWeights, int N)
    {
        Array.Sort(packageWeights);
        int left = 0;
        int right = packageWeights.Length - 1;
        int pairs = 0;

        while (left < right)
        {
            int sum = packageWeights[left] + packageWeights[right];
            if (sum == N)
            {
                pairs++;
                left++;
                right--;
            }
            else if (sum < N)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return pairs;
    }
}
