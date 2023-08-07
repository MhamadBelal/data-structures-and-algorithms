# Tree-fizz-buzz

## Whiteboard Process 

![Challenge18(1)](./Assets/Challenge18(1).PNG)
![Challenge18(2)](./Assets/Challenge18(2).PNG)

---

## Approach & Efficiency

The task is to transform a k-ary tree into a new k-ary tree, where the node values are modified based on the FizzBuzz rules. The FizzBuzz problem involves replacing numbers divisible by 3 with "Fizz," numbers divisible by 5 with "Buzz," and numbers divisible by both 3 and 5 with "FizzBuzz." Numbers not divisible by either 3 or 5 remain unchanged.

**Approach:**

* The main approach to solving this task is to perform a Breadth-First Search (BFS) traversal on the original k-ary tree while simultaneously creating the modified k-ary tree. BFS ensures that the nodes are processed level by level, which helps in constructing the modified tree efficiently.
* For each node visited during the BFS, the node's value is transformed according to the FizzBuzz rules using a helper function (FizzBuzz). The transformed value is then used to create the corresponding node in the modified tree.
* The BFS is implemented using a queue, where each pair of nodes from the original tree and the modified tree is enqueued and dequeued for processing.
* The modified tree is constructed level by level as the BFS progresses, and the children of each node are processed and added to the queue for further exploration.

**Efficiency:**

* Time Complexity: The time complexity of the FizzBuzzTreeTransform method is O(N), where N is the number of nodes in the k-ary tree. The BFS traversal visits each node once, and the FizzBuzz logic in the helper function (FizzBuzz) takes constant time for each node.
* Space Complexity: The space complexity of the FizzBuzzTreeTransform method is O(N), where N is the number of nodes in the k-ary tree. This space is used to store the modified k-ary tree in the queue during the BFS traversal. In the worst case, the queue might contain all the nodes at a given level.
* The additional space complexity for the FizzBuzz helper function is O(1), as it uses a constant amount of space for local variables.

**Overall:**

* The algorithm's efficiency is quite good, with both the time and space complexities being linear with respect to the number of nodes in the k-ary tree. This approach allows for a straightforward and efficient transformation of the tree's node values while maintaining the original tree structure.

## Solution

Tree-fizz-buzz function Code:

```shell
public class FizzBuzzTree
    {
        public KaryTreeNode FizzBuzzTreeTransform(KaryTreeNode root)
        {
            if (root == null)
                return null;

            Queue<KaryTreeNode> queue = new Queue<KaryTreeNode>();

            KaryTreeNode newRoot = new KaryTreeNode(FizzBuzz(root.Value));
            queue.Enqueue(root);
            queue.Enqueue(newRoot);

            while (queue.Count > 0)
            {
                KaryTreeNode currentOriginal = queue.Dequeue();
                KaryTreeNode currentModified = queue.Dequeue();

                foreach (var child in currentOriginal.Children)
                {
                    var newChild = new KaryTreeNode(FizzBuzz(child.Value));
                    currentModified.Children.Add(newChild);
                    queue.Enqueue(child);
                    queue.Enqueue(newChild);
                }
            }

            return newRoot;
        }

        private string FizzBuzz(string value)
        {
            if (int.TryParse(value, out int numValue))
            {
                if (numValue % 3 == 0 && numValue % 5 == 0)
                    return "FizzBuzz";
                else if (numValue % 3 == 0)
                    return "Fizz";
                else if (numValue % 5 == 0)
                    return "Buzz";
                else
                    return numValue.ToString();
            }
            else
            {
                // If the value is already a string (e.g., "Fizz", "Buzz"), return it as it is.
                return value;
            }
        }
    }
```

Main Function Code:

```shell
public class Program
    {
        static void Main(string[] args)
        {
            // Creating a sample k-ary tree
            var rootNode = new KaryTreeNode("15");
            var node1 = new KaryTreeNode("6");
            var node2 = new KaryTreeNode("10");
            var node3 = new KaryTreeNode("3");
            var node4 = new KaryTreeNode("9");
            var node5 = new KaryTreeNode("5");
            var node6 = new KaryTreeNode("7");

            rootNode.Children.Add(node1);
            rootNode.Children.Add(node2);
            rootNode.Children.Add(node3);

            node1.Children.Add(node4);
            node2.Children.Add(node5);
            node3.Children.Add(node6);

            // Creating FizzBuzzTree instance
            var fizzBuzzTree = new FizzBuzzTree();

            // Transforming the k-ary tree using FizzBuzzTreeTransform method
            var modifiedTree = fizzBuzzTree.FizzBuzzTreeTransform(rootNode);

            // Printing the modified tree
            Console.WriteLine("Modified K-ary tree:");
            PrintTree(modifiedTree);
        }

        static void PrintTree(KaryTreeNode root, string prefix = "")
        {
            if (root != null)
            {
                Console.WriteLine(prefix + root.Value);
                foreach (var child in root.Children)
                {
                    PrintTree(child, prefix + "   ");
                }
            }
        }
    }
```


## Test Cases

```shell
public class UnitTest1
    {
        private KaryTreeNode CreateSampleTree()
        {
            var rootNode = new KaryTreeNode("15");
            var node1 = new KaryTreeNode("6");
            var node2 = new KaryTreeNode("10");
            var node3 = new KaryTreeNode("3");
            var node4 = new KaryTreeNode("9");
            var node5 = new KaryTreeNode("5");
            var node6 = new KaryTreeNode("5");

            rootNode.Children.Add(node1);
            rootNode.Children.Add(node2);
            rootNode.Children.Add(node3);

            node1.Children.Add(node4);
            node2.Children.Add(node5);
            node3.Children.Add(node6);

            return rootNode;
        }

        [Fact]
        public void FizzBuzzTreeTransform_ShouldReturnNull_WhenInputTreeIsNull()
        {
            // Arrange
            var fizzBuzzTree = new FizzBuzzTree();

            // Act
            var result = fizzBuzzTree.FizzBuzzTreeTransform(null);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void FizzBuzzTreeTransform_ShouldTransformTree_WhenInputTreeIsValid()
        {
            // Arrange
            var fizzBuzzTree = new FizzBuzzTree();
            var inputTree = CreateSampleTree();

            // Act
            var result = fizzBuzzTree.FizzBuzzTreeTransform(inputTree);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("FizzBuzz", result.Value);
            Assert.Equal(3, result.Children.Count);
            Assert.Equal("Fizz", result.Children[0].Value);
            Assert.Equal("Buzz", result.Children[1].Value);
            Assert.Equal("Fizz", result.Children[2].Value);
            Assert.Equal(1, result.Children[0].Children.Count);
            Assert.Equal(1, result.Children[1].Children.Count);
            Assert.Equal("Fizz", result.Children[0].Children[0].Value);
            Assert.Equal("Buzz", result.Children[1].Children[0].Value);
        }

        [Fact]
        public void FizzBuzzTreeTransform_ShouldHandleStringValues_WhenInputTreeContainsStringValues()
        {
            // Arrange
            var fizzBuzzTree = new FizzBuzzTree();
            var rootNode = new KaryTreeNode("Fizz");
            var node1 = new KaryTreeNode("3");
            var node2 = new KaryTreeNode("Buzz");

            rootNode.Children.Add(node1);
            rootNode.Children.Add(node2);

            // Act
            var result = fizzBuzzTree.FizzBuzzTreeTransform(rootNode);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Fizz", result.Value);
            Assert.Equal(2, result.Children.Count);
            Assert.Equal("Fizz", result.Children[0].Value);
            Assert.Equal("Buzz", result.Children[1].Value);
        }
    }
```
