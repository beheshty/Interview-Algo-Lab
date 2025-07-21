# 🎯 Linear Search

**Category**: Searching  
**Time Complexity**: O(n)  
**Space Complexity**: O(1)  
**Best case**: O(1)

---

## 📚 Description

Linear Search is the simplest searching algorithm that checks each element of a list sequentially until the desired element is found or the end of the list is reached.

1. Start from the first element in the array.
2. Compare the current element with the target.
3. If they match, return the index.
4. If they don’t, move to the next element.
5. Repeat until the end of the array.
6. If the target is not found, return `-1`.

---

## 🔁 Step-by-Step Explanation

Given the array:

```csharp
[4, 2, 7, 9, 5, 1]
```

Let's say we want to find the value `5`.

- 🔍 Checking index 0: value = 4
- 🔍 Checking index 1: value = 2
- 🔍 Checking index 2: value = 7
- 🔍 Checking index 3: value = 9
- 🔍 Checking index 4: value = 5
🎯 Found target 5 at index 4

---

## 🛠 Real-World Analogy

Imagine you're looking for a specific book in a small stack of books. You go through each one in order from top to bottom until you find the title you're looking for. That's linear search!

---

## 📌 Notes

- Works on **unsorted** arrays.
- Simple but inefficient for large datasets.
- First match is returned (even if duplicates exist).

---

## 🔗 Related Topics

- Binary Search   
- Binary Search Tree  
