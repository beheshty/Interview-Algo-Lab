# Insertion Sort
**Category**: Sorting  
**Time Complexity**: O(n²)  
**Space Complexity**: O(1)  
**Best case (sorted array)**: O(n)

---

## 💡 Description
The algorithm works by taking one element from the unsorted part of the list and "inserting" it into its correct position in the already sorted part. It's similar to how many people sort a hand of playing cards.

1. Start with the second element of the array (the first element is considered a sorted sub-array of one).
2. Select this element and store it as the key.
3. Compare the key with the elements in the sorted sub-array (to its left), moving from right to left.
4. Shift all elements in the sorted sub-array that are greater than the key one position to the right.
5. Insert the key into the newly opened space.
6. Repeat the process for all remaining unsorted elements.

---

## 🔁 Step-by-Step Explanation

Given the array:  
```csharp
[5, 1, 4, 2, 8]
```

### 🔄 Step 1:
- Start with the second element `1`
- Compare `1` with `5` → **Move 5 to the right** → [5, 5, 4, 2, 8]  
- Insert `1` at position 0 → [1, 5, 4, 2, 8]


### 🔄 Step 2:
- Take `4`
- Compare `4` with `5` → **Move 5** → [1, 5, 5, 2, 8]  
- Insert `4` at position 1 → [1, 4, 5, 2, 8]


### 🔄 Step 3:
- Take `2`
- Compare `2` with `5` → **Move 5**  
- Compare `2` with `4` → **Move 4**  
- Compare `2` with `1` → Keep `1`  
- Insert `2` at position 1 → [1, 2, 4, 5, 8]


### 🔄 Step 4:
- Take `8`
- Compare with `5`, no shift needed → Already in place


## ✅ Final Output

```csharp
Sorted Array: [1, 2, 4, 5, 8]
```

---

## 🛠 Real-World Analogy

Imagine you're sorting playing cards in your hands. You pick one card at a time and insert it into its proper place among the ones you've already sorted.

---

## 📌 Notes

- Efficient for small or nearly sorted datasets.
- Performs well for data that arrives over time.
- Unlike Bubble Sort, fewer comparisons may be needed.

---

## 🔗 Related Topics

- Bubble Sort  
- Selection Sort  
- Merge Sort (more efficient)
