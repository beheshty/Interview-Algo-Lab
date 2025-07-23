# ⚡ Quick Sort

**Category**: Sorting  
**Time Complexity**: $O(n \log n)$ on average, $O(n^2)$ in the worst case  
**Space Complexity**: $O(\log n)$  
**Best Case**: $O(n \log n)$  

---

## 📚 Description

Quick Sort is a highly efficient, in-place sorting algorithm that also uses the **Divide and Conquer** paradigm. It's often faster in practice than other $O(n \log n)$ algorithms like Merge Sort, despite having a worse worst-case performance.

1.  **Pick a Pivot**: Choose an element from the array. This element is called the pivot. Common strategies include picking the first, last, middle, or a random element.
2.  **Partition**: Reorder the array so that all elements with values less than the pivot are moved to its left, and all elements with values greater than the pivot are moved to its right. After this step, the pivot is in its final sorted position.
3.  **Recurse**: Recursively apply the above steps to the sub-array of elements to the left of the pivot and the sub-array of elements to the right of the pivot.

---

## 🔁 Step-by-Step Explanation

Given the array and using the last element as the pivot:
@@@csharp
[7, 2, 1, 6, 8, 5]
@@@

-   **Step 1**: `pivot = 5`. We'll partition the array `[7, 2, 1, 6, 8]` around `5`.
    -   We iterate through the array, swapping elements smaller than `5` to the front.
    -   `2` is smaller than `5`. Swap `7` and `2` → `[2, 7, 1, 6, 8, 5]`
    -   `1` is smaller than `5`. Swap `7` and `1` → `[2, 1, 7, 6, 8, 5]`
-   **Step 2**: The loop finishes. Now, we place the pivot in its correct sorted position by swapping it with the first element that was larger than it (`7`).
    -   Swap `7` and `5` → `[2, 1, 5, 6, 8, 7]`
-   **Step 3**: The pivot `5` is now sorted. We recursively apply Quick Sort to the two sub-arrays:
    -   Left sub-array: `[2, 1]`
    -   Right sub-array: `[6, 8, 7]`
-   This process continues until all elements are sorted.

---

## 🛠 Real-World Analogy

Imagine lining up a group of students by height. You pick one student as the "pivot" and have them stand in the middle. Then, you instruct every student shorter than the pivot to move to their left and every student taller to move to their right. Now, that pivot student is in their final correct position. You then repeat the exact same process on the "shorter" group and the "taller" group independently until everyone is in the correct order.

---

## 📌 Notes

-   Quick Sort is generally an **in-place** algorithm, meaning it requires minimal extra memory ($O(\log n)$ for the recursion stack).
-   It is an **unstable sort**, meaning the relative order of equal elements might change.
-   Performance is sensitive to **pivot selection**. A poor pivot strategy (e.g., always picking the largest element) can degrade performance to $O(n^2)$. Randomizing the pivot is a common way to avoid the worst case.

---

## 🔗 Related Topics

-   Merge Sort