using System;
using System.Collections.Generic;
using System.Data;

namespace TechDoctor
{
    public class PNullables
    {
        private int accountSeed = 0;
        Nullable<int> GetDept
        {
            get{
                return 120;
            }
        }


        private int DeleteDuplicates(int[] array)
        {
            int endOfList = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[endOfList] != array[i])
                    array[++endOfList] = array[i];
            }
            
            return endOfList;
        }


        // Adds up to target
       private int[] AddToTarget(int[] givenArray, int target)
        {
            Dictionary<int,int> leftNumbers  = new Dictionary<int, int>();
           
            for (int i = 0; i < givenArray.Length; i++)
            {
                int requiredNumber = target - givenArray[i];
                if (leftNumbers.ContainsKey(requiredNumber))
                {
                    return new[] {leftNumbers[requiredNumber],i};
                }
                
                if(!leftNumbers.ContainsKey(givenArray[i]))
                  leftNumbers.Add(givenArray[i],i);
            }
            
            return new []{0,0};
        }

        //  Maximum Profit
        private int MaxProfit(int[] stocks)
        {
           
            int prev = 0, maxProfit=0, totalProfit =0;
            
            for (int scout = 1; scout < stocks.Length; scout++)
            {
                if (stocks[prev] > stocks[scout])
                {
                    prev = scout;
                    totalProfit += maxProfit;
                    maxProfit = 0;
                }
                else if(stocks[scout] - stocks[prev]  > maxProfit)
                {
                    maxProfit = stocks[scout] - stocks[prev];  //210
                }
            }
            
            return totalProfit + maxProfit;
        }



        /*
        // Return total islands --------- Before
        private int TotalIslands(int[][] grid)
        {
            int totalRows = grid.Length();
            int totalColumns = grid[0].Length;
            int islandsCount = 0;
            
            for (int row = 0; row < totalRows; row++)
            {
                for (int col = 0; col < totalColumns; col++)
                {
                    if (grid[row][col] == 1)
                    {
                        if (col + 1 < totalColumns &&  grid[row][col+1] == 0 && row+1 < totalRows &&  grid[row+1][col] == 0)
                        {
                            islandsCount++;
                        }
                        else if(col ==  totalColumns-1 && grid[row][col] == 1)
                        {
                            if (row+1 < totalRows && grid[row+1][col] ==0)
                            {
                                islandsCount++;
                            }
                            else if (row == totalRows - 1 && grid[row][col] == 1)
                            {
                                islandsCount++;
                            }
                        }
                    }
                }
            }

            return islandsCount;
        }*/
        
        
        
        // Return total islands --------- After
        private int TotalIslands(char[][] grid)
        {
            int islandsCount = 0;
            
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    if (grid[row][col] == '1')
                    {
                        islandsCount++;
                        dfs(grid,row,col);
                    }
                }
            }

            return islandsCount;
        }


        private void dfs(char[][] grid, int row, int col)
        {
            
            if(row < 0 || row > grid.GetLength(0) -1 ||  col < 0 || col > grid[row].Length-1 || grid[row][col] == '0' )
                return;

            grid[row][col] = '0';
            
            dfs(grid,row,col-1);
            dfs(grid,row-1,col);
            dfs(grid,row,col+1);
            dfs(grid,row+1,col);
        }
        

        //Reverse Linkedlist 
        private Node ReverList(Node node)
        {
            if (node == null || node.Next == null) 
                return node;
            
            Node head = ReverList(node.Next);
            node.Next.Next = node;
            node.Next = null;

            return head;
        }

        
        //------------- Print a node list
        private void PrintList(Node head)
        {
            while (head != null)
            {
                Console.Write($" { head.Value } ");
                head = head.Next;
            }
        }





        //Null collision  operator
      
        
        static void Main1(string[] args)
        {
            int abcc = 30;

            int firstInt = 1;
            int? secondInt = 2;

            int thirdInt = secondInt.HasValue ? secondInt.Value : 0;
            int fourthInt = secondInt ??= 1;
  //          int fifthInt = secondInt ??= Nullable;
          
            
            PNullables pn = new PNullables();


            /*if (pn.GetDept.HasValue)
            {
                Console.WriteLine($"department number is: {pn.GetDept.Value}");
            }
            else
            {
                Console.WriteLine("department number not found");
            }*/

            // Removing Duplicates
            /*int[] array = {1, 2, 3, 3, 3, 4, 5, 6, 7, 8,9,9,9,9,10,20};
            int lastIndex = pn.DeleteDuplicates(array);
            
                for (int i=0; i< lastIndex;i++)
                {
                    Console.Write($" {array[i]}");
                }*/
            
                
            // Add up two numbers to a specific target
            int[] givenArray = {1, 2, 4, 5, 8, 9, 3,6,1};
            int target = 15;
            int[] indices = pn.AddToTarget(givenArray, target);

           // Console.WriteLine($"Indices that adds up to the target {target}");
            for (int i = 0; i < indices.Length; i++)
            {
               // Console.Write($" {indices[i]}");
            }
            
            
            // Buy/Sell Stock
            int[] stocks = {100, 180, 260, 310, 40, 535, 695};
            int maxProfit = pn.MaxProfit(stocks);

            //Console.WriteLine($"Maximum profit is: {maxProfit}");
            
            
            /*// Find number of islands --- Before
            int[][] grid  = new int[4][];
            
            grid[0] = new[] {1,1,1,1,1 };
            grid[1] = new[] {1,1,0,0,1 };
            grid[2] = new[] {0,0,1,0,0 };
            grid[3] = new[] {0,0,1,1,1 };

            Console.WriteLine($"Islands count  is: {pn.TotalIslands(grid)}");*/
            
            
             // Find number of islands --- Before
            /*char[][] grid  = new Char[4][];

            grid[0] = new[] {'1','1','1','1','1' };
            grid[1] = new[] {'1','1','0','0','1' };
            grid[2] = new[] {'0','0','1','0','1' };
            grid[3] = new[] {'0','0','0','1','1' };

            Console.WriteLine($"Islands count  is: {pn.TotalIslands(grid)}");*/
            
            
            
            //  Create a linked list and traverse
            int[] values = {1, 3, 5, 7, -1, 20, 100};
            Node  previousNode = new Node(values[0]);
            Node head = previousNode;
            for (int i = 1; i < values.Length; i++)
            {
                Node node = new Node(values[i]);
                previousNode.Next = node;
                previousNode = node;
            }
            
            /*//reverse the linked list -------- OLD
            Node pointer = head;
            Node tail = new Node(head.Value);
            Node newNode;
            tail.Next = null;
            
            do
            {
                newNode = new Node(pointer.Next.Value);
                newNode.Next = tail;

                tail = newNode;
                pointer = pointer.Next;
            } 
            while (pointer.Next != null);
            
            
            // Reversed singly Linkedlist
             pointer = tail;

            do
            {
                Console.Write($" {pointer.Value}");
                pointer = pointer.Next;
            } 
            while (pointer.Next != null);
            Console.Write($" {pointer.Value}");*/

        
            //reverse the linked list -------- NEW
            
            /*pn.PrintList(pn.ReverList(head));
            
            
            Console.WriteLine(nameof(System.String));
            int j = 5;
            Console.WriteLine(nameof(j));
            List<string> names = new List<string>();
            Console.WriteLine(nameof(names));*/
            
            Node n = new Node(1);
            Node m = new Node(1);
            Node k = n;

            if(n == m)
                Console.WriteLine("We are ==");

            if(n.Equals(m))
                Console.WriteLine("We are Equal");
            
            if(n == k)
                Console.WriteLine("We are ==");

            if(n.Equals(k))
                Console.WriteLine("We are Equal");
            
            
            

        }


class Node
{
    public int Value { get; set; }
    public Node Next = null;

    public Node(int value)
    {
        Value = value;
    }
}


}
}