# 🧼 Bubble Sort

**Category**: Sorting  
**Time Complexity**: O(n²)  
**Space Complexity**: O(1)  
**Stable**: ✅ Yes  
**In-place**: ✅ Yes  
**Best case (sorted array)**: O(n)

---

## 📚 Description

Bubble Sort is a simple sorting algorithm that works by **repeatedly stepping through the list**, **comparing adjacent elements**, and **swapping them if they are in the wrong order**.

With each pass through the list, the largest unsorted element "bubbles up" to its correct position.

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

---

### 🔄 Pass 2:
- Compare 1 and 4 → No Swap  
- Compare 4 and 2 → **Swap** → [1, 2, 4, 5, 8]  
- Compare 4 and 5 → No Swap

**End of Pass 2**: `5` is now in place.

---

### 🔄 Pass 3:
- Compare 1 and 2 → No Swap  
- Compare 2 and 4 → No Swap

Since no swaps occurred, the array is sorted — algorithm finishes early.

---

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
