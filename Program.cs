using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace LeetCode_1812
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C#的輸入與輸出
            //知識點：Ch2 建立C#應用程式，主控台應用程式的輸出與輸入、程式註解、程式碼縮排
            //知識點：Ch3 變數、資料型別與運算子，變數的宣告、變數的初值、指定敘述、整數資料型別、字串資料的型別轉換、字串連接運算子
            //知識點：Ch7 函數，呼叫擁有參數和傳回值的函數、函數的執⾏過程
            //知識點：Ch5 選擇控制項與條件敘述，if/else 二選一條件敘述

            Console.WriteLine("Enter The Coordinates:"); //輸出提示使用者輸入棋盤座標
            string str1 = Console.ReadLine(); //輸入棋盤座標，並存入字串資料型別變數 str1初值

            Console.WriteLine( str1 + "'s Color is White?"); //輸出提示使用者輸入的棋盤座標
            //輸出棋盤格子參考圖
            Console.WriteLine("8 ■□■□■□■□\r\n7 □■□■□■□■\r\n6 ■□■□■□■□\r\n5 □■□■□■□■\r\n4 ■□■□■□■□\r\n3 □■□■□■□■\r\n2 ■□■□■□■□\r\n1 □■□■□■□■\r\n a b c d e f g h");

            //if/else 二選一條件敘述
            if (SquareIsWhite(str1)) //呼叫區域函數 SquareIsWhite，並傳入參數 str1 棋盤座標，判斷是否為白色格子
            {
                Console.WriteLine("Yes, The Color is White"); //輸出結果為白色格子
            }
            else
            {
                Console.WriteLine("No, The Color is Black"); //輸出結果為黑色格子
            }

            Console.Read(); //等待使用者按下任意鍵後結束程式

            /*
            1812.Determine Color of a Chessboard Square

            You are given coordinates, a string that represents the coordinates of a square of the chessboard.Below is a chessboard for your reference.
            Return true if the square is white, and false if the square is black.
            The coordinate will always represent a valid chessboard square.The coordinate will always have the letter first, and the number second.

            8■□■□■□■□
            7□■□■□■□■
            6■□■□■□■□
            5□■□■□■□■
            4■□■□■□■□
            3□■□■□■□■
            2■□■□■□■□
            1□■□■□■□■
             a b c d e f g h 

            Example 1:
            Input: coordinates = "a1"
            Output: false
            Explanation: From the chessboard above, the square with coordinates "a1" is black, so return false.

            Example 2:
            Input: coordinates = "h3"
            Output: true
            Explanation: From the chessboard above, the square with coordinates "h3" is white, so return true.

            Example 3:
            Input: coordinates = "c7"
            Output: false

            Constraints:
            coordinates.length == 2
            'a' <= coordinates[0] <= 'h'
            '1' <= coordinates[1] <= '8'


            1812. 確定棋盤格的顏色

            給定一個座標，它是一個字串，表示棋盤格的座標。以下是供您參考的棋盤格。
            如果該格子為白色，則傳回 true；如果該格子為黑色，則傳回 false。
            該座標始終表示一個有效的棋盤格。此座標始終以字母為首，數字為後。

            8■□■□■□■□
            7□■□■□■□■
            6■□■□■□■□
            5□■□■□■□■
            4■□■□■□■□
            3□■□■□■□■
            2■□■□■□■□
            1□■□■□■□■
             a b c d e f g h 

            範例 1：
            輸入：coordinates = "a1"
            輸出：false
            解釋：從上方的棋盤格來看，座標為「a1」的格子為黑色，因此傳回 false。

            範例 2：
            輸入：coordinates = "h3"
            輸出：true
            解釋：從上方的棋盤格來看，座標為「h3」的格子為白色，因此傳回 true。

            範例 3：
            輸入：coordinates = "c7"
            輸出：false

            限制：
            coordinates.length == 2
            'a' <= coordinates[0] <= 'h'
            '1' <= coordinates[1] <= '8'
             */


            //解題思路
            //只要挑出其中一個顏色，另一個顏色就是相反的結果
            //暴力法列出所有黑色格子，其他的就是白色格子
            //黑色傳回false，白色傳回true

            //知識點：Ch7 函數，建立C#函數、函數的參數列、函數的傳回值、區域函數
            //知識點：Ch5 選擇控制項與條件敘述，switch 多選一條件敘述

            //區域函數 1.傳回值 bool, 2.形式參數 string coordinates
            bool SquareIsWhite(string coordinates)
            {
                //1. 輸入 參數 coordinates 棋盤座標

                //2. 處理 switch 多選一條件敘述
                //3. 傳回值 true 白色 / false 黑色

                //switch 多選一條件敘述
                switch (coordinates) //參數 coordinates 棋盤座標
                {
                    //列出所有黑色格子的座標
                    case "a1":
                    //return true; 本來應該寫完整的case與return或break，但因為後面還有很多case要寫，所以可以省略，在沒有執行到return或break前會繼續往下執行，意思就是符合任何一個case就會執行return true
                    case "a3":
                    case "a5":
                    case "a7":

                    case "c1":
                    case "c3":
                    case "c5":
                    case "c7":

                    case "e1":
                    case "e3":
                    case "e5":
                    case "e7":

                    case "g1":
                    case "g3":
                    case "g5":
                    case "g7":

                    case "b2":
                    case "b4":
                    case "b6":
                    case "b8":

                    case "d2":
                    case "d4":
                    case "d6":
                    case "d8":

                    case "f2":
                    case "f4":
                    case "f6":
                    case "f8":

                    case "h2":
                    case "h4":
                    case "h6":
                    case "h8":
                        return false; //傳回黑色格子
                    //break; 因為有return，所以不需要break

                    default: //default就是其他所有情況，就是白色格子
                        return true;//傳回白色格子

                }
            }
            //結束簽名TMChouys
        }
    }
}
