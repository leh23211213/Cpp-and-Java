namespace AlgorithmAndStructure
{
    public class NodeStack<T> where T : IComparable
    {
        public T Data { get; set; }
        public NodeStack<T> Next { get; set; }
        public NodeStack()
        {
            Data = default;
            Next = null;
        }
        public NodeStack(T element)
        {
            Data = element;
            Next = null;
        }
    }
    public class Program
    {
        public static bool IsValid(string s)
        {
            char[] tokens = s.ToCharArray();
            Stack<char> operators = new Stack<char>();
            int i = 0;
            while (i < tokens.Length)
            {
                if (tokens[i] == '{' || tokens[i] == '(' || tokens[i] == '[')
                {
                    operators.Push(tokens[i]);
                }
                else if (tokens[i] == '}' || tokens[i] == ')' || tokens[i] == ']')
                {
                    if (operators.Count == 0) return false;

                    char previousChar = operators.Pop();
                    if (
                         (previousChar == '{' && tokens[i] == '}') ||
                         (previousChar == '(' && tokens[i] == ')') ||
                         (previousChar == '[' && tokens[i] == ']'))
                    {
                        //
                    }
                    else return false;
                }
                i++;
            }
            return operators.Count == 0;
        }


        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }

            return null;
        }

        public static int FirstUniqChar(string s = "leetcode")
        {
            char[] s1 = s.ToCharArray();
            Queue<char> que = new Queue<char>();

            for (int i = 0; i < s1.Length; i++)
            {
                que.Enqueue(s1[i]);
            }

            if (que.Count == 1) return -1;

            foreach (var item in que)
            {
                if (que.Contains(item))
                {

                }
            }


            return -1;
        }
        public static void Main(string[] args)
        {

        }
    }
}