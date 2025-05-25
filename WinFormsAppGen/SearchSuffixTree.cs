using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    class SuffixTreeNode
    {
        public Dictionary<char, SuffixTreeNode> Children = new Dictionary<char, SuffixTreeNode>();
        public int StartIndex;
        public int EndIndex;

        public SuffixTreeNode(int startIndex, int endIndex)
        {
            StartIndex = startIndex;
            EndIndex = endIndex;
        }
    }
    public class SuffixTree
    {
        private SuffixTreeNode root;
        private string text;

        public SuffixTree(string text)
        {
            this.text = text;
            root = new SuffixTreeNode(-1, -1);
            BuildSuffixTree();
        }

        private void BuildSuffixTree()
        {
            int n = text.Length;
            for (int i = 0; i < n; i++)
            {
                AddSuffix(i);
            }
        }

        private void AddSuffix(int suffixStart)
        {
            SuffixTreeNode currentNode = root;

            for (int i = suffixStart; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (!currentNode.Children.ContainsKey(currentChar))
                {
                    currentNode.Children[currentChar] = new SuffixTreeNode(suffixStart, text.Length);
                }

                currentNode = currentNode.Children[currentChar];
            }
        }

        public bool Search(string pattern)
        {
            SuffixTreeNode currentNode = root;

            for (int i = 0; i < pattern.Length; i++)
            {
                char currentChar = pattern[i];

                if (!currentNode.Children.ContainsKey(currentChar))
                {
                    return false; // Không tìm thấy
                }

                currentNode = currentNode.Children[currentChar];
            }

            return true; // Tìm thấy
        }
    }

    public class SearchSuffixTree
    {
        private string querySearch;
        private string[] inputData;
        public SearchSuffixTree(string[] texts, string query)
        {
            querySearch = query;
            inputData = texts;
        }

        public void DoSearch()
        {
            foreach (var text in inputData)
            {
                SuffixTree suffixTree = new SuffixTree(text);
                
                bool found = suffixTree.Search(querySearch);

                Console.WriteLine($"Mẫu '{querySearch}' tìm thấy: {found}");                
            }
        }
    }
}
