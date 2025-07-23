# 🧩 Merge Sort

**Category**: Sorting  
**Time Complexity**: $O(n \log n)$  
**Space Complexity**: $O(n)$  
**Best Case**: $O(n \log n)$

---

## 📚 Description

Merge sort is a highly efficient, comparison-based sorting algorithm that uses a divide and conquer strategy. It divides an array into two halves, recursively sorts them, and then merges the two sorted halves back together to create a single sorted array.

The algorithm follows two main phases:
1. **Divide**: The primary array is recursively divided in half until it can no longer be divided. This results in several sub-arrays containing only one element each. A single-element array is inherently sorted.
2. **Conquer (Merge)**: The sorted sub-arrays are repeatedly merged to produce new sorted sub-arrays until there is only one sorted array remaining. The merging process compares elements from the two sub-arrays and places the smaller element into the new array, continuing until all elements from both sub-arrays have been moved.

---

## 🔁 Step-by-Step Explanation

Given the array:
```csharp
[8, 3, 5, 1, 9, 4]
```

#### Divide Phase:
The array is recursively split.
- `[8, 3, 5, 1, 9, 4]` is split into `[8, 3, 5]` and `[1, 9, 4]`
- `[8, 3, 5]` is split into `[8]` and `[3, 5]`
- `[3, 5]` is split into `[3]` and `[5]`
- `[1, 9, 4]` is split into `[1]` and `[9, 4]`
- `[9, 4]` is split into `[9]` and `[4]`
At this point, all sublists have a single element: `[8]`, `[3]`, `[5]`, `[1]`, `[9]`, `[4]`.

#### Combine (Merge) Phase:
The sorted sublists are merged back together.
- Merge `[3]` and `[5]` → `[3, 5]`
- Merge `[8]` and `[3, 5]` → `[3, 5, 8]`
- Merge `[9]` and `[4]` → `[4, 9]`
- Merge `[1]` and `[4, 9]` → `[1, 4, 9]`
- Finally, merge the two main halves: `[3, 5, 8]` and `[1, 4, 9]` → `[1, 3, 4, 5, 8, 9]`

---

## 🛠 Real-World Analogy

Imagine you're a librarian with a huge, messy pile of returned books to put back on a shelf in alphabetical order. Instead of handling the whole pile, you split it in half. You give one half to a colleague. You both continue splitting your piles until you're left with single books (which are inherently "sorted"). Then, you start merging: you and your colleague merge your single books into small, sorted piles. Then you merge those small piles together, always picking the next book in alphabetical order from either pile. This continues until the two large, sorted halves are merged back into one perfectly sorted collection on the shelf.

---

## 📌 Notes

-   Merge Sort is a **stable sort**, meaning that the relative order of equal elements is preserved.
-   It is **not an in-place sort** as it requires additional memory ($O(n)$) to store the merged sublists.
-   It is well-suited for sorting linked lists and for handling data that is too large to fit into memory (external sorting).

---

## 🔗 Related Topics

-   Quicksort
