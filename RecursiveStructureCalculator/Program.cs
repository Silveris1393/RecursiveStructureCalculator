using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveStructureCalculator
{
   
    
        class Branch
        {
            public List<Branch> branches = new List<Branch>();
        }

        class Program
        {
            static void Main(string[] args)
            {
                Branch root = new Branch();
                root.branches.Add(new Branch());
                root.branches[0].branches.Add(new Branch());
                root.branches[0].branches[0].branches.Add(new Branch());
                root.branches[0].branches[0].branches[0].branches.Add(new Branch());
                root.branches[0].branches[0].branches[0].branches[0].branches.Add(new Branch());

                Console.WriteLine("The depth of the hierarchical structure is: " + CalculateDepth(root, 1));
                Console.ReadLine();
            }

            static int CalculateDepth(Branch branch, int depth)
            {
                int maxDepth = depth;
                foreach (Branch childBranch in branch.branches)
                {
                    int childDepth = CalculateDepth(childBranch, depth + 1);
                    if (childDepth > maxDepth)
                    {
                        maxDepth = childDepth;
                    }
                }
                return maxDepth;
            }
        }
    }

