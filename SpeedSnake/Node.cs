namespace SpeedSnake
{
    /// <summary>
    /// Node class used to build snake and other items.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// X location
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y location
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Node()
        {
            X = 0;
            Y = 0;
        }
    }
}
