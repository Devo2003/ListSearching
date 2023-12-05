# ListSearching

List the algorithm name:
Linear Search

Describe the algorithm:
This type of search iterates through a type of collection one value at a time.
This search does not to be sorted

Show asymptotic notation (best and worst case)

Worst-case: O(n)
Best-case: O(1)
Average: O(n/2)

Show the algorithm as pseudocode:

Begin
1) Set i = 0
2) If Li = T, go to line 4
3) Increase i by 1 and go to line 2
4) If i < n then return i
End





List the algorithm name:
Binary Search 

Describe the algorithm:
This search needs to be sorted and finds the position of the target value.

Show asymptotic notation (best and worse case)

Worst-case: O(1)
Best-case: O(log n)

Show the algorithm as pseudocode

function binary_search(A, n, T) is
    L := 0
    R := n − 1
    while L ≤ R do
        m := floor((L + R) / 2)
        if A[m] < T then
            L := m + 1
        else if A[m] > T then
            R := m − 1
        else:
            return m
    return unsuccessful





List the algorithm name:

Interpolation search

Describe the algorithm:
This search also has to be sorted. After it is sorted it starts to guess where the value is at from the value results it has gathered. If the probe is wrong it then resets and narrows the search each time. 

Show asymptotic notation (best and worse case)

Best case: O (log log n)
Worst case:  O(n)

Show the algorithm as pseudocode:

function binary_search(A, n, T) is
    L := 0
    R := n − 1
    while L ≤ R do
        m := floor((L + R) / 2)
        if A[m] < T then
            L := m + 1
        else if A[m] > T then
            R := m − 1
        else:
            return m
    return unsuccessful




Summary: 
	Linear is the slowest because the algorithm searches every element individually from the start of the array all the way to the end. If the element is at the end then it has to go through all those elements. This search is better for smaller arrays than huge ones. The binary search is better for collections that are sorted in an orderly manner. And interpolation is best used for collections that aren't really measured explicitly. A difference between binary and interpolation searches is that binary starts checking from the middle and searches the left, or the right side of the collection. While the Interpolation search just randomly searches any section of the collection until it finds the index.
	
