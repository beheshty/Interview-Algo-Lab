# 🔗 Linked List

**Category**: Data Structure  
**Time Complexity**: Access: $O(n)$ | Insertion/Deletion (at ends): $O(1)$  
**Space Complexity**: $O(n)$  

---

## 📚 Description

A **Linked List** is a fundamental linear data structure where elements are not stored at contiguous memory locations. Instead, elements are stored in `Node` objects that contain the data and a pointer (or "link") to the next node in the sequence. The list is accessed through a single entry point, the `Head` node.

Unlike arrays, linked lists can grow and shrink dynamically without needing to be resized. This makes them highly efficient for operations like adding or removing elements at the beginning or end of the list.

---

## 🔁 Step-by-Step Explanation

Let's visualize the basic operations.

#### Initial State
The list starts empty, with the `Head` pointing to nothing (`null`).
`Head -> Null`

#### AddFirst(10)
A new node `[10]` is created. It points to the old `Head` (`null`), and the `Head` is updated to point to the new node.
`Head -> [10] -> Null`

#### AddFirst(5)
A new node `[5]` is created. It points to the current `Head` (`[10]`), and `Head` is updated.
`Head -> [5] -> [10] -> Null`

#### AddLast(20)
We traverse from the `Head` to the last node (`[10]`) and update its `Next` pointer to the new node `[20]`.
`Head -> [5] -> [10] -> [20] -> Null`

#### Remove(10)
We traverse the list to find the node *before* the one we want to remove (`[5]`). We then update its `Next` pointer to skip the target node (`[10]`) and point directly to the next one (`[20]`).
`Head -> [5] -> [20] -> Null`

---

## 🛠 Real-World Analogy

Think of a **scavenger hunt**. You start with the first clue (the `Head`). This clue not only contains some information (`Data`) but, most importantly, tells you where to find the next clue (the `Next` pointer). You follow this chain of clues one by one until you reach the final clue, which points to nowhere (`null`), signaling the end of the hunt.

---

## 📌 Notes

-   **Dynamic Size**: Linked lists can easily grow or shrink during runtime.
-   **Efficient Insertions/Deletions**: Adding or removing nodes at the beginning of the list is extremely fast ($O(1)$).
-   **No Random Access**: To access the Nth element, you must traverse the list from the `Head` ($O(n)$), which is much slower than an array's direct access ($O(1)$).
-   **Memory Overhead**: Each node requires extra memory to store its `Next` pointer.

---

## 🔗 Related Topics

-   Stack
-   Queue 
