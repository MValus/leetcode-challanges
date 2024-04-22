# Introduction

Project for LeetCode challenges.

# Problem #1 - Count number of islands

Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.

An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume
all four edges of the grid are all surrounded by water.

#### Example 1:
Input:
```
grid = [
  ["1","1","1","1","0"],
  ["1","1","0","1","0"],
  ["1","1","0","0","0"],
  ["0","0","0","0","0"]
]
```
Output: `1`

#### Example 2:
Input:
```
grid = [
  ["1","1","0","0","0"],
  ["1","1","0","0","0"],
  ["0","0","1","0","0"],
  ["0","0","0","1","1"]
]
```

Output: `3`

#### Constraints:
```
m == grid.length
n == grid[i].length
1 <= m, n <= 300
grid[i][j] is '0' or '1'.
```

#### Solutions:
Class [IslandsDfsCounter.cs](LeetCodeChallenges%2FIslandsDfsCounter.cs) contains the counter implementation using recursive DFS algorithm: https://en.wikipedia.org/wiki/Depth-first_search

Class [IslandsBfsCounter.cs](LeetCodeChallenges%2FIslandsBfsCounter.cs) contains the counter implementation using queue and BFS algorithm: https://en.wikipedia.org/wiki/Breadth-first_search

#### Tests:
Class [IslandsTests.cs](LeetCodeChallenges%2FIslandsTests.cs) contains the test cases for the given challenge.