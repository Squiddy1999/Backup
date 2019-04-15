using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Workshop_9
{
    class Program
    {
        static void Main(string[] args)
        {
            BST FirstNameBST = new BST();
            FirstNameBST.InsertDatabase();
            Console.WriteLine(FirstNameBST.Search("Oberyn"));
            Console.ReadLine();
            
        }
    }

    class Node
    {
        public string firstName;
        public string lastName;
        public long number;

        public Node()
        {
            firstName = "";
            lastName = "";
            number = 0;
        }
        
        public Node left;
        public Node right;

        public bool search(Node node, string name)
        {
            if (node == null)
                return false;

            if (node.firstName == name)
            {
                return true;
            }
            else if (string.Compare(name, firstName) > 0)
            {
                return search(node.right, name);
            }
            else if (string.Compare(name, firstName) < 0)
            {
                return search(node.left, name);
            }

            return false;
        }
    }

    class BST
    {
        public Node root = new Node();

        public BST(string sortBy)
        {
            string itemToSort = sortBy;
        }

        public Node insert(Node rootNode, string firstNameInsert, string lastNameInsert, long numberInsert)
        {
            if (rootNode == null)
            {
                rootNode = new Node();
                rootNode.firstName = firstNameInsert;
                rootNode.lastName = lastNameInsert;
                rootNode.number = numberInsert;
                Console.WriteLine("Root made");
            }
            else if (string.Compare(firstNameInsert, rootNode.firstName) < 0)
            {
                rootNode.left = insert(rootNode.left, firstNameInsert, lastNameInsert, numberInsert);
            }
            else
            {
                rootNode.right = insert(rootNode.right, firstNameInsert, lastNameInsert, numberInsert);
            }

            return rootNode;
        }

        public bool Search(string name)
        {
            if (root == null)
                return false;
            else
                return root.search(root, name);
        }

        public void InsertDatabase()
        {
            string path = "database.txt";
            string[] databaseLines = File.ReadAllLines(path);
            for (int i = 0; i< databaseLines.Length; i++)
            {
                string firstNameInsert = databaseLines[i].Split()[0];
                string lastNameInsert = databaseLines[i].Split()[1];
                long numberInsert = Convert.ToInt64(databaseLines[i].Split()[2]);
                Console.WriteLine("{0}, {1}, {2}", firstNameInsert, lastNameInsert, numberInsert);
                insert(root, firstNameInsert, lastNameInsert, numberInsert);
                Console.WriteLine(root.firstName);
            }

            //List<(string, string, long)> dataList = new List<(string, string, long)> { ("null", "null", 0), ("null", "null", 0) };
            //for (int i = 0; i < databaseLines.Length; i++)
            //{
            //    dataList.Append((("null", "null", 0)));
            //    Console.WriteLine("line length: {0}", i);
            //    Console.WriteLine(dataList[i]);
            //}
            //for (int i = 0; i < databaseLines.Length; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine(((databaseLines[i].Split(' ')[0]), (databaseLines[i].Split(' ')[1]), Convert.ToInt64(databaseLines[i].Split(' ')[2])));
            //    dataList[i] = (((databaseLines[i].Split(' ')[0]), (databaseLines[i].Split(' ')[1]), Convert.ToInt64(databaseLines[i].Split(' ')[2])));

            //}
            //Console.WriteLine(dataList.Count);  
        }

    }
}
