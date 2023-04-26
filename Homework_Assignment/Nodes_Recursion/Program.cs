using System;
using System.Collections.Generic;

namespace Nodes_Recursion
{
    class Branch
    {
        public List<Branch> branches;

        public Branch()
        {
            branches = new List<Branch>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create the hierarchical structure
            Branch root = new Branch();
            Branch level1a = new Branch();
            Branch level1b = new Branch();
            Branch level2a = new Branch();
            Branch level2b = new Branch();
            Branch level2c = new Branch();
            Branch level3a = new Branch();
            Branch level3b = new Branch();
            Branch level3c = new Branch();
            Branch level4 = new Branch();

            root.branches.Add(level1a);
            root.branches.Add(level1b);
            level1a.branches.Add(new Branch());
            level1b.branches.Add(level2a);
            level1b.branches.Add(level2b);
            level1b.branches.Add(level2c);
            level2a.branches.Add(new Branch());
            level2b.branches.Add(new Branch());
            level2c.branches.Add(new Branch());
            level3a.branches.Add(new Branch());
            level3b.branches.Add(new Branch());
            level3c.branches.Add(new Branch());
            level3b.branches.Add(level4);

            // Calculate the depth of the hierarchical structure
            // Counting from 0 to 4; this gives depth of 4
            int depth = CalculateDepth(root);
            Console.WriteLine($"The depth of the hierarchical structure is {depth}");
        }

        static int CalculateDepth(Branch branch)
        {
            if (branch.branches.Count == 0)
            {
                return 1;
            }
            else
            {
                int maxDepth = 0;
                foreach (Branch child in branch.branches)
                {
                    int childDepth = CalculateDepth(child);
                    if (childDepth > maxDepth)
                    {
                        maxDepth = childDepth;
                    }
                }
                return maxDepth + 1;
            }
        }
    }
}
