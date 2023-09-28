using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.models
{
    public class TreeNode
    {
        //constructor
        public TreeNode(int value)
        {
            data = value;
        }

        private int data;
        public int Data { get { return data; } set { data = value; } }

        private TreeNode rightNode;

        //Right child
        public TreeNode RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }

        private TreeNode leftNode;

        //left child
        public TreeNode LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }

        private bool isDeleted;

        public bool IsDeleted
        {
            get { return isDeleted; }
        }



        public void Delete()
        {
            isDeleted = true;
        }

        public void Insert(int value)
        {
            // verrataan arvoa dataan. Jos on suurempi tai yhta suuri, niin asetetaan oikealla
            if (value >= data)
            {
                if (rightNode == null)
                { // jos ei ole olemassa oikealla, luodaan
                    rightNode = new TreeNode(value);
                }
                else
                { // rekursiivinen operaatio insert
                    rightNode.Insert(value);
                }
            }
            // painvastoin jos toisin
            else
            {
                if (leftNode == null)
                {
                    leftNode = new TreeNode(value);
                }
                else
                {
                    leftNode.Insert(value);
                }
            }
        }

        //Traversal funtiot
        ///<summary>
        /// left -> root -> right
        /// 0(logN)
        ///</summary>
        public void InOrderTraversal()
        {
            //Vasemmalle liikkuminen
            if (leftNode != null)
            {
                leftNode.InOrderTraversal();
            }

            //Printataan noden data
            Console.Write(data + " ");

            //sitten oikealle liikkuminen
            if (rightNode != null)
            {
                rightNode.InOrderTraversal();
            }
        }

        /// <summary>
        /// root -> left -> right
        /// 0(logN)
        /// </summary>
        public void PreOrderTraversal()
        {
            //Printtaa noden data
            Console.Write(data + " ");

            //Mene vasempaan lapseen.
            if (leftNode != null)
            {
                leftNode.PreOrderTraversal();
            }

            //Mene oikeaan lapseen
            if (rightNode != null)
            {
                rightNode.PreOrderTraversal();
            }
        }

        /// <summary>
        /// left -> right -> root
        /// 0(logN)
        /// </summary>
        public void PostOrderTraversal()
        {
            //Mene vasempaan lapseen.
            if (leftNode != null)
            {
                leftNode.PostOrderTraversal();
            }

            //Mene oikeaan lapseen
            if (rightNode != null)
            {
                rightNode.PostOrderTraversal();
            }

            //Printtaa noden data
            Console.Write(data + " ");
        }

        /// <summary>
        /// Etsitaan arvoa vertaamalla metodiin/funktioon annettua lukua nodeen itseensa ja sen lapsiin. 
        /// 0(logN)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public TreeNode Find(int value)
        {
            TreeNode currentNode = this;
            while (currentNode != null)
            {
                //Jos nykyinen node on sama kuin annettu luku, se on loydetty
                if (value == currentNode.data && isDeleted == false)
                {
                    return currentNode;
                }
                //Jos annettu summa on isompi kuin kuin nykyisen noden data, niin mennaan oikealla
                else if (value > currentNode.data)
                {
                    currentNode = currentNode.rightNode;
                }
                //Mennaan vasemmalle jos toisin
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }
            //Nodea ei ole olemassa
            return null; 
        }

        /// <summary>
        /// Etsitaan arvoa rekursiivisesti 
        /// 0(logN)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public TreeNode FindRecursive(int value)
        {
            TreeNode currentNode = this;

            //Jos nykyinen node on sama kuin annettu luku, se on loydetty
            if (value == currentNode.data && isDeleted == false)
            {
                return currentNode;
            }
            //Jos annettu summa on pienempi kuin kuin nykyisen noden data, niin mennaan vasemmalle
            else if (value < currentNode.data && leftNode != null)
            {
                return leftNode.FindRecursive(value);
            }
            //Mennaan oikealle jos toisin
            else if (rightNode != null)
            {
                return rightNode.FindRecursive(value);
            }
            //Nodea ei ole olemassa
            else
            {
                return null;
            }


        }
    }
}
