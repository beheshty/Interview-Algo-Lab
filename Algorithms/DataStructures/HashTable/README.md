# 🔑 Hash Table

**Category**: Data Structure  
**Time Complexity**: Average Case: $O(1)$ | Worst Case: $O(n)$  
**Space Complexity**: $O(n)$  

---

## 📚 Description

A **Hash Table** (or Hash Map) is a powerful data structure that maps **keys** to **values**. It uses a **hash function** to compute an index, or "hash," from a key, which determines where the corresponding value should be stored in an array of "buckets." This design allows for incredibly fast lookups, insertions, and deletions on average.

When two different keys hash to the same index, it's called a **collision**. A common way to handle this is **separate chaining**, where each bucket is a linked list of all the key-value pairs that hashed to that spot.

---

## 🔁 Step-by-Step Explanation

Let's imagine a tiny hash table with 4 buckets.

-   `Add("apple", 50)`: The hash function computes an index for "apple", let's say `index = 1`.
-   `Add("grape", 75)`: The hash for "grape" also results in `index = 1`. This is a **collision**!
-   `Add("lime", 20)`: The hash for "lime" results in `index = 3`.

The final structure would look like this:

-   **Bucket 0**: -> Empty
-   **Bucket 1**: -> `["apple": 50]` -> `["grape": 75]` (Chained together)
-   **Bucket 2**: -> Empty
-   **Bucket 3**: -> `["lime": 20]`

To retrieve the value for "grape", the table would hash the key to `index 1`, then search the short linked list at that bucket to find the matching key.

---

## 🛠 Real-World Analogy

Think of a **large filing cabinet**. The **key** is the name on a folder (e.g., "Taxes 2024"). The **hash function** is your system for deciding which drawer (bucket) to use (e.g., folders starting with 'T' go in the bottom drawer). If the 'T' drawer already has folders (a collision), you simply place the new folder behind the others in that same drawer. This system lets you find any folder much faster than searching the entire cabinet from top to bottom.

---

## 📌 Notes

-   The performance of a hash table depends heavily on a **good hash function** that distributes keys evenly and avoids collisions.
-   Keys must be **hashable**. Immutable types like strings and numbers make great keys.
-   When the table gets too full (its **load factor** is high), it should be resized to maintain $O(1)$ performance.

