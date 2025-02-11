public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int buy = prices[0];
        int profit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < buy)
            {
                buy = prices[i];
            }
            else if (prices[i] - buy > profit)
            {
                profit = prices[i] - buy;
            }
        }
        return profit;
    }
}

/*
public class Solution {
    public int MaxProfit(int[] prices) {

       if (prices == null || prices.Length == 0) return 0;

        int minPrice = prices[0]; // Başlangıçta en düşük fiyat ilk gündeki fiyat olacak
        int maxProfit = 0; // Başlangıçta kar sıfır.

          // Fiyatları baştan sona dolaşıyoruz
    for (int i = 1; i < prices.Length; i++) {
        int currentPrice = prices[i];

        // Eğer şu anki fiyat en düşükten bile düşükse, en düşük fiyatı güncelle
        if (currentPrice < minPrice) {
            minPrice = currentPrice;
        }
        // Eğer kar elde edebiliyorsak, maksimum karı hesapla ve kaydet
        else {
            int potentialProfit = currentPrice - minPrice;
            maxProfit = Math.Max(maxProfit, potentialProfit);
        }
    }

    // Bulduğumuz maksimum karı geri döndür
    return maxProfit;


    }
}
*/

// time complexity: O(n) where n is the length of the prices array
// space complexity: O(1) as we are using only constant space