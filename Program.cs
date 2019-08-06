using System;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            // LoopArray(arr);
            // FindMax(arr);
            // getAverage(arr);
            // OddArray();
            int[] arr = {-1, 2, 3, 4};
            // GreaterThanY(arr, 2);
            // SquareArrayValue(arr);
            // EliminateNegative(arr);
            // MinMaxAverage(arr);
            ShiftValues(arr);
            // NumToString(arr);
        }

        public static void PrintNumbers(){
            for(int i = 1; i <= 255; i++){
                System.Console.WriteLine(i);
            }
        }

        public static void PrintOdds(){
            for(int i = 1; i <= 255; i++){
                if(i % 2 != 0){   
                    System.Console.WriteLine();
                }
            }
        }

        public static void PrintSum(){
            double sum = 0;
            for(int i = 0; i <= 255; i++){
                sum += i;
                System.Console.WriteLine("New Number: " + i + " Sum: " + sum);
            }
        }

        public static void LoopArray(int[] numbers){
            for(int i = 0; i <= numbers.Length - 1; i++){
                System.Console.WriteLine(numbers[i]);
            }
        }

        public static void FindMax(int[] numbers){
            int max = numbers[0];
            for(int i = 0; i <= numbers.Length - 1; i++){
                if(numbers[i] > max){
                    max = numbers[i];
                }
            }
            System.Console.WriteLine("Max is: " + max);
        }

        public static void getAverage(int[] numbers){
            int sum = 0;
            double average = 0;
            for(int i = 0; i <= numbers.Length - 1; i++){
                sum += numbers[i];
            }
            average = sum / numbers.Length;
            System.Console.WriteLine("Average is: " + average);
        }

        public static int[] OddArray(){
            int[] answer = new int[128];

            for(int i = 0; i <= 255; i++){
                for(int j = 1; j <= 128; j++){
                    if(i % 2 != 0){
                        System.Console.WriteLine(i);
                        answer[j] = i;
                        break;
                    }
                }
            }
            return answer;
        }

        public static int GreaterThanY(int[] numbers, int y){
            int count = 0;
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] > y){
                    count++;
                }
            }            
            System.Console.WriteLine(count);
            return count;
        }

        public static void SquareArrayValue(int[] numbers){
            for(int i = 0; i < numbers.Length; i++){
                numbers[i] = numbers[i] * numbers[i];
                System.Console.WriteLine(numbers[i]);
            }
        }

        public static void EliminateNegative(int[] numbers){
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0){
                    numbers[i] = numbers[i] * -1;
                }
                System.Console.WriteLine(numbers[i]);
            }            
        }

        public static void MinMaxAverage(int[] numbers){
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;
            double average = 0;
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < min){
                    min = numbers[i];
                }
                if(numbers[i] > max){
                    max = numbers[i];
                }
                sum += numbers[i];
            }
            average = sum / numbers.Length;
            System.Console.WriteLine("Average: " + average);
            System.Console.WriteLine("min: " + min);
            System.Console.WriteLine("max: " + max);
        }

        public static void ShiftValues(int[] numbers){
            for(int i = 0; i < numbers.Length-1; i++){
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length-1] = 0;
            foreach(var item in numbers){
                System.Console.WriteLine(item);
            }
        }

        public static object[] NumToString(int[] numbers){
            object[] str = new object[numbers.Length];
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0){
                    str[i] = "Dojo";
                } else {
                    str[i] = numbers[i];
                }
            }

            foreach(var item in str){
                System.Console.WriteLine(item);
            }
            return str;
        }
    }
}
