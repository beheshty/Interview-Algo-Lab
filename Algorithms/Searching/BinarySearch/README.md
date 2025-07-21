# 🎯 Binary Search

**Category**: Searching  
**Time Complexity**: O(log n)  
**Space Complexity**: O(1)  
**Best case**: O(1)

---

## 📚 Description

Binary search is a highly efficient algorithm for finding an item in a *sorted* list. It works by repeatedly dividing the search interval in half. If the value of the search key is less than the item in the middle of the interval, the search narrows to the lower half; otherwise, it narrows to the upper half. This process continues until the value is found or the interval is empty.

1. Find the middle element of the sorted array.
2. Compare the middle element with the target value.
3. If they match, the search is successful, and the index of the element is returned.
4. If the target is smaller than the middle element, the search continues in the lower half of the array. The upper half is discarded.
5. If the target is larger than the middle element, the search continues in the upper half of the array. The lower half is discarded.
6. Repeat this process of halving the search space until the target is found or the sub-array size becomes zero, which means the target is not in the list.

---

## 🔁 Step-by-Step Explanation

Given the sorted array:

```csharp
[1, 3, 5, 7, 9, 11, 13]
```

Let's say we want to find the value `7`.

- Step 1: low = 0, high = 6  
  mid = (0 + 6) / 2 = 3 → `array[3] = 7`  
  ✅ Match found! Return index 3.

Now suppose we are looking for the value `4`.

- Step 1: low = 0, high = 6  
  mid = 3 → `array[3] = 7`  
  4 < 7 → search left half

- Step 2: low = 0, high = 2  
  mid = 1 → `array[1] = 3`  
  4 > 3 → search right half

- Step 3: low = 2, high = 2  
  mid = 2 → `array[2] = 5`  
  4 < 5 → search left half again

- Step 4: low = 2, high = 1 → ❌ Range invalid, not found.

---

## 🛠 Real-World Analogy

Think of looking up a word in a dictionary. You don’t check each page one by one — instead, you open near the middle, and then decide whether to go left or right based on where your word might be.

---

## 📌 Notes

- Only works on **sorted arrays**.
- Extremely efficient for large datasets.
- Can be implemented both **iteratively** and **recursively**.
- Often used in searching problems or for locating insertion points.

---

## 🔗 Related Topics

- Linear Search  
- Binary Search Tree  
