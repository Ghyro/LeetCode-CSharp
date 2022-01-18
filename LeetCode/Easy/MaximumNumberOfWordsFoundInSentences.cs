namespace Easy
{
    // Issue: 2114
    public class MaximumNumberOfWordsFoundInSentences
    {
        public int MostWordsFound(string[] sentences)
        {
            int[] values = new int[sentences.Length];
            int index = 0;
            foreach (var word in sentences)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    int checker = i;
                    if (checker + 1 == word.Length)
                    {
                        values[index]++;
                    }
                    if (word[i] == ' ')
                    {
                        values[index]++;
                    }
                }
                index++;
            }
            int max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }
            return max;
        }
    }
}
