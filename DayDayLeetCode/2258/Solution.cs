﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDayLeetCode._2258
{
    /// <summary>
    /// 2258. 逃离火灾
    /// </summary>
    public class Solution
    {
        const int INF = 1000000000;
        static int[][] dirs = { new int[] { -1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 } };

        public int MaximumMinutes(int[][] grid)
        {
            int m = grid.Length, n = grid[0].Length;
            int[][] fireTime = new int[m][];
            for (int i = 0; i < m; i++)
            {
                fireTime[i] = new int[n];
                Array.Fill(fireTime[i], INF);
            }
            /* 通过 BFS 求出每个格子着火的时间 */
            BFS(grid, fireTime);
            /* 二分查找找到最大停留时间 */
            int ans = -1;
            int low = 0, high = m * n;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (Check(fireTime, grid, mid))
                {
                    ans = mid;
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return ans >= m * n ? INF : ans;
        }

        public void BFS(int[][] grid, int[][] fireTime)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        queue.Enqueue(new Tuple<int, int>(i, j));
                        fireTime[i][j] = 0;
                    }
                }
            }

            int time = 1;
            while (queue.Count > 0)
            {
                int sz = queue.Count;
                for (int i = 0; i < sz; i++)
                {
                    Tuple<int, int> tuple = queue.Dequeue();
                    int cx = tuple.Item1, cy = tuple.Item2;
                    for (int j = 0; j < 4; j++)
                    {
                        int nx = cx + dirs[j][0];
                        int ny = cy + dirs[j][1];
                        if (nx >= 0 && ny >= 0 && nx < m && ny < n)
                        {
                            if (grid[nx][ny] == 2 || fireTime[nx][ny] != INF)
                            {
                                continue;
                            }
                            queue.Enqueue(new Tuple<int, int>(nx, ny));
                            fireTime[nx][ny] = time;
                        }
                    }
                }
                time++;
            }
        }

        public bool Check(int[][] fireTime, int[][] grid, int stayTime)
        {
            int m = fireTime.Length;
            int n = fireTime[0].Length;
            bool[][] visit = new bool[m][];
            for (int i = 0; i < m; i++)
            {
                visit[i] = new bool[n];
            }
            Queue<Tuple<int, int, int>> queue = new Queue<Tuple<int, int, int>>();
            queue.Enqueue(new Tuple<int, int, int>(0, 0, stayTime));
            visit[0][0] = true;

            while (queue.Count > 0)
            {
                Tuple<int, int, int> tuple = queue.Dequeue();
                int cx = tuple.Item1, cy = tuple.Item2, time = tuple.Item3;
                for (int i = 0; i < 4; i++)
                {
                    int nx = cx + dirs[i][0];
                    int ny = cy + dirs[i][1];
                    if (nx >= 0 && ny >= 0 && nx < m && ny < n)
                    {
                        if (visit[nx][ny] || grid[nx][ny] == 2)
                        {
                            continue;
                        }
                        /* 到达安全屋 */
                        if (nx == m - 1 && ny == n - 1)
                        {
                            return fireTime[nx][ny] >= time + 1;
                        }
                        /* 火未到达当前位置 */
                        if (fireTime[nx][ny] > time + 1)
                        {
                            queue.Enqueue(new Tuple<int, int, int>(nx, ny, time + 1));
                            visit[nx][ny] = true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
