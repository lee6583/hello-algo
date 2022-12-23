/**
 * File: binary_tree.cs
 * Created Time: 2022-12-23
 * Author: haptear (haptear@hotmail.com)
 */

using hello_algo.include;
using NUnit.Framework;

namespace hello_algo.chapter_tree
{

    public class binary_tree
    {
        [Test]
        public void Test()
        {
            /* 初始化二叉树 */
            // 初始化结点
            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(3);
            TreeNode n4 = new TreeNode(4);
            TreeNode n5 = new TreeNode(5);
            // 构建引用指向（即指针）
            n1.left = n2;
            n1.right = n3;
            n2.left = n4;
            n2.right = n5;
            Console.WriteLine("\n初始化二叉树\n");
            PrintUtil.printTree(n1);

            /* 插入与删除结点 */
            TreeNode P = new TreeNode(0);
            // 在 n1 -> n2 中间插入结点 P
            n1.left = P;
            P.left = n2;
            Console.WriteLine("\n插入结点 P 后\n");
            PrintUtil.printTree(n1);
            // 删除结点 P
            n1.left = n2;
            Console.WriteLine("\n删除结点 P 后\n");
            PrintUtil.printTree(n1);
        }
    }
}