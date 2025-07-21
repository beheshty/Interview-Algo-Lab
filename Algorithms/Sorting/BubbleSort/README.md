# 🧼 Bubble Sort

**Category**: Sorting  
**Time Complexity**: O(n²)  
**Space Complexity**: O(1)  
**Best case (sorted array)**: O(n)

---

## 📚 Description

Bubble Sort is a simple sorting algorithm that works by **repeatedly stepping through the list**, **comparing adjacent elements**, and **swapping them if they are in the wrong order**.

The algorithm works by making multiple passes through an array. On each pass, it compares each pair of adjacent items and swaps them if they are in the wrong order. After the first pass, the largest element will have "bubbled up" to the end of the array. After the second pass, the second-largest element will be in its correct position, and so on. This process continues until no swaps are needed during a full pass, indicating the array is sorted.

1. Start at the beginning of the array.
2. Compare the first element with the second.
3. Swap them if the first is greater than the second.
4. Move to the next pair of elements and repeat the comparison and potential swap.
5. Continue this process until the end of the array. This completes one full pass.
6. Repeat the entire process for `n-1` passes, where `n` is the number of elements.

An important optimization is to stop the algorithm early if a full pass is completed with no swaps, as this means the array is already sorted.

---

## 🔁 Step-by-Step Explanation

Given the array:
```csharp
[5, 1, 4, 2, 8]
```

### 🔄 Pass 1:
- Compare 5 and 1 → **Swap** → [1, 5, 4, 2, 8]  
- Compare 5 and 4 → **Swap** → [1, 4, 5, 2, 8]  
- Compare 5 and 2 → **Swap** → [1, 4, 2, 5, 8]  
- Compare 5 and 8 → No Swap → [1, 4, 2, 5, 8]

**End of Pass 1**: Largest number `8` is in its final place.


### 🔄 Pass 2:
- Compare 1 and 4 → No Swap  
- Compare 4 and 2 → **Swap** → [1, 2, 4, 5, 8]  
- Compare 4 and 5 → No Swap

**End of Pass 2**: `5` is now in place.


### 🔄 Pass 3:
- Compare 1 and 2 → No Swap  
- Compare 2 and 4 → No Swap

Since no swaps occurred, the array is sorted — algorithm finishes early.


## ✅ Final Output

```
Sorted Array: [1, 2, 4, 5, 8]
```

---

## 🛠 Real-World Analogy

Imagine sorting bubbles by weight — with each pass, the heaviest bubble rises to the top, and we repeat until the lightest is at the bottom.

Also commonly used in education to teach the concept of sorting and iteration.

---

## 📌 Notes

- Highly inefficient for large datasets.
- Simple to understand and implement.
- Optimized versions can stop early if no swaps occur during a pass.

---

## 🔗 Related Topics

- Insertion Sort
- Selection Sort
- Merge Sort (more efficient)
