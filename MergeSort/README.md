# Merge Sort

## Introduction

Merge Sort is a popular sorting algorithm known for its stability and efficiency. In this article, we'll dive into the Merge Sort algorithm and illustrate how it works step by step using a visual representation. We'll start by reviewing the pseudocode and then apply it to a sample array to demonstrate the sorting process.

## Pseudocode Review
```shell
ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length

    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1

        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left
```

## Step-by-Step Explanation

Step 1: Initial Split
Suppose we have the following sample array: [38, 27, 43, 3, 9, 82, 10].

* Mergesort is called with the entire array.
* n is the length of the array, which is 7.
* Since n is greater than 1, we proceed to split the array.

We calculate the mid as 7/2 = 3.

* left will be [38, 27, 43] (the first half of the array).
* right will be [3, 9, 82, 10] (the second half of the array).

Step 2: Recursive Calls
* We recursively call Mergesort(left) and Mergesort(right).

Sorting left:
* Mergesort([38, 27, 43]) is called.
* n is 3, so we calculate mid as 3/2 = 1.
* left becomes [38].
* right becomes [27, 43].
* Recursively call Mergesort(left) and Mergesort(right) for [38] and [27, 43].

Sorting right:
* Mergesort([3, 9, 82, 10]) is called.
* n is 4, so mid is 4/2 = 2.
* left becomes [3, 9].
* right becomes [82, 10].
* Recursively call Mergesort(left) and Mergesort(right) for [3, 9] and [82, 10].

Step 3: Merging
Now that we have sorted left and right, we merge them into the original array using the Merge algorithm.

* left is [27, 38, 43].
* right is [3, 9, 10, 82].
* arr is [38, 27, 43, 3, 9, 82, 10].

We start merging:

* Compare 27 (from left) and 3 (from right). Since 3 is smaller, we place it in arr and move to the next element in right.
* Result in arr: [3, ...].
* Compare 27 (from left) and 9 (from right). Again, we place the smaller value (9) in arr and move to the next element in right.
Result in arr: [3, 9, ...].
* Continue this process until we've merged all elements from both left and right into arr.

Step 4: Final Result
After merging, the array becomes [3, 9, 10, 27, 38, 43, 82]. This is the sorted version of our initial sample array.

Conclusion
Merge Sort is a highly efficient sorting algorithm that uses a divide-and-conquer approach. By following the pseudocode and visualizing the step-by-step process, we've gained a deeper understanding of how Merge Sort works. This knowledge is essential for both understanding algorithms and implementing them in code.
