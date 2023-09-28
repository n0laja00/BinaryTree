using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.models
{
    public class BinaryTreeModel
    {
        private TreeNode root;
        public void Insert( int data)
        {
            if (root != null)
            {
                root.Insert(data);
            }
            else
            {
                root = new TreeNode(data);
            }
        }


        //Tree traversal


        /// <summary>
        ///In order - menee vasemmalta oikealle, palaten vanhempaan/aikuiseen rekursiivisesti.
        ///Numerot nousevassa jarjestyksessa.
        ///0(logN)
        /// </summary>
        public void InOrderTraversal()
        {
            if (root != null)
            {
                root.InOrderTraversal();
            }
        }

        /// <summary>
        /// pre order - mene juureen, sitten vasemmalle ja oikealle rekursiivisesti
        /// 0(logN)
        /// </summary>
        public void PreOrderTraversal() 
        {  
            if (root != null) 
            {
                root.PreOrderTraversal();
            } 
        }


        /// <summary>
        /// post order Mennaan vasemmalle ja sitten oikealla, taman jalkeen roottiin rekursiivisesti
        /// 0(logN)
        /// </summary>
        public void PostOrderTraversal() 
        {
            if (root != null)
            {
                root.PostOrderTraversal();
            }
        }

        /// <summary>
        /// kutsutaan find funktio jos node ei ole null. 
        /// Root.Find => node.find => kunnes loydamme halutun luvun
        /// 0(logN)
        /// </summary>
        /// <param name="data">int</param>
        /// <returns>TreeNode tai null</returns>
        public TreeNode Find(int data)
        {
            if(root != null)
            {
                return root.Find(data);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find funktio rekursiivisesti
        /// 0(logN)
        /// </summary>
        /// <param name="data">int</param>
        /// <returns>TreeNode tai null</returns>
        public TreeNode FindRecursive(int data)
        {
            if (root != null)
            {
                return root.FindRecursive(data);
            }
            else
            {
                return null;
            }
        }

    }

}
