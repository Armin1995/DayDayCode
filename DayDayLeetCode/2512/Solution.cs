using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._2512
{
    public class Solution
    {
        public IList<int> TopStudents(string[] positive_feedback, string[] negative_feedback, string[] report, int[] student_id, int k)
        {
            Dictionary<string, int> wordGoalDict = new Dictionary<string, int>();
            foreach (var word in positive_feedback)
            {
                wordGoalDict.TryAdd(word, 3);
            }
            foreach (var word in negative_feedback)
            {
                wordGoalDict.TryAdd(word, -1);
            }

            List<(int, int)> stuentGoalList = new List<(int, int)>();

            for (int i = 0; i < student_id.Length; i++)
            {
                var reports = report[i].Split(' ');
                var goal = 0;
                foreach (var word in reports)
                {
                    if (wordGoalDict.ContainsKey(word))
                    {
                        goal += wordGoalDict[word];
                    }
                }
                stuentGoalList.Add((student_id[i], goal));
            }

            stuentGoalList.Sort((a, b) =>
            {
                if (a.Item2 == b.Item2)
                {
                    return a.Item1 - b.Item1;
                }
                else
                {
                    return b.Item2 - a.Item2;
                }
            });

            var studentIdList = stuentGoalList.Take(k).Select(o => o.Item1).ToList();

            return studentIdList;
        }
    }
}
