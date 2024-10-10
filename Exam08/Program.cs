#region baitap01

// //input
// int[] IsNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20];

// //output
// int sum = 0;

// //process
// foreach (int num in IsNumber){
//     sum += num;
// }

// System.Console.WriteLine("Sum of IsNumber: " + sum);

#endregion

#region baitap02
// //input
// int[] lst_number = [2, 7, 11, 15];
// //output
// int target;
// //process
// while (true)
// {
//     System.Console.Write("Enter a integer to your target: ");
//     var input = Console.ReadLine();
//     bool isInteger = int.TryParse(input, out int number);

//     if (isInteger)
//     {
//         target = number;
//         break;
//     }
//     else
//     {
//         Console.WriteLine("--Your target is not Integer!!!--");
//     }
// }

// int index = 0;
// for (int i = 0; i < lst_number.Length; i++)
// {
//     for (int j = 1; j < lst_number.Length; j++)
//     {
//         if ((lst_number[i] + lst_number[j]) == target)
//         {
//             Console.WriteLine("[" + i + ", " + j + "]");
//             index = 1;
//         }
//     }

// }
// if (index == 0)
// {
//     System.Console.WriteLine(" --Can not find!-- ");
// }


#endregion

#region baitap03

// //input
// List<int> lstNumber =  [ 7, 7, 8, 7, 6, 5, 5, 1, 1, 2, 2, 2, 3, 4, 4, 5 ];
// List<int> sortedList = [.. lstNumber.Order()];

// //output
// List<int> result =
// [
//     //process
//     lstNumber[0]
// ];
// for (int i = 1; i < sortedList.Count; i++)
// {
//     if (sortedList[i] != sortedList[i - 1])
//         result.Add(sortedList[i]);
// }

// System.Console.WriteLine("Count of Result: " + result.Count);


#endregion

#region baitap04

// //input
// List<int> lstNumber = new List<int> { 1, 1, 1, 2, 2, 3 };
// //output


#endregion

#region baitap05
// //input
// List<int> prices = new List<int> { 7, 1, 5, 3, 6, 4 };
// //output
// int maxProfit = int.MinValue;
// //process
// for (int i = 0; i < prices.Count - 1 ; i++){
//     for (int j = 1; j < prices.Count; j++){
//         if ((prices[j] - prices[i]) > maxProfit ){
//             maxProfit = prices[j] - prices[i];
//         }
//     }
// }
// System.Console.WriteLine("Max of profit: " + maxProfit);

#endregion