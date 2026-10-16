public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        Data = data;
    }

    public void Insert(int value)
    {
        // Problem 1: Insert Unique Values Only

        if (value < Data)
        {
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }

        // If value == Data, do nothing.
    }

    public bool Contains(int value)
    {
        // Problem 2: Contains

        if (value == Data)
            return true;

        if (value < Data)
        {
            if (Left is null)
                return false;

            return Left.Contains(value);
        }

        if (Right is null)
            return false;

        return Right.Contains(value);
    }

    public int GetHeight()
    {
        // Problem 4: Tree Height
        // An empty subtree has height 0.

        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}