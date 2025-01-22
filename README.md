<!-- TOC -->
* [Introduction](#introduction)
  * [Problem #1 - Count number of islands](#problem-1---count-number-of-islands)
    * [Example 1](#example-1)
    * [Example 2](#example-2)
    * [Constraints](#constraints)
    * [Solutions](#solutions)
    * [Tests](#tests)
<!-- TOC -->

# Introduction

Project for LeetCode challenges.

## Problem #1 - Count number of islands

Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.

An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume
all four edges of the grid are all surrounded by water.

### Example #1
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

### Example #2
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

### Constraints
```
m == grid.length
n == grid[i].length
1 <= m, n <= 300
grid[i][j] is '0' or '1'.
```

### Solutions
Class [IslandsDfsCounter](LeetCodeChallenges/01_Islands/IslandsDfsCounter.cs) contains the counter implementation using recursive DFS algorithm: https://en.wikipedia.org/wiki/Depth-first_search

Class [IslandsBfsCounter.cs](LeetCodeChallenges/01_Islands/IslandsBfsCounter.cs) contains the counter implementation using queue and BFS algorithm: https://en.wikipedia.org/wiki/Breadth-first_search

### Tests
Class [IslandsTests.cs](LeetCodeChallenges/01_Islands/IslandsTests.cs) contains the test cases for the given challenge.

## Problem #2 - Calculate median of 2 sorted arrays
Given two sorted arrays `nums1` and `nums2` of size `m` and `n` respectively, return the median of the two sorted arrays.
The overall run time complexity should be `O(log (m+n))`.

### Example #1
Input:
```
nums1 = [1,3]
nums2 = [2]
```
Output: `2.00000`

Explanation: merged array = [1,2,3] and median is 2.

### Example #2
Input:
```
nums1 = [1,2]
nums2 = [3,4]
```
Output: `2.50000`

Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

### Constrains
```
nums1.length == m
nums2.length == n
0 <= m <= 1000
0 <= n <= 1000
1 <= m + n <= 2000
-106 <= nums1[i], nums2[i] <= 106
```

## Problem #3 - Multiway number partitioning
Partition a multiset of numbers into a fixed number of subsets, such that the sums of the subsets are as similar as possible.

### Example #1
Given k=2, S = {3,1,1,2,2,1} a valid solution to the partition problem is the two sets S1 = {1,1,1,2} and S2 = {2,3}. S1 = {3,1,1} and S2 = {2,2,1} is another solution. 
