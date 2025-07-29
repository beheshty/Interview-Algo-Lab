# 🎟️ Queue

**Category**: Data Structure  
**Time Complexity**: Enqueue, Dequeue, Peek are all $O(1)$  
**Space Complexity**: $O(n)$  

---

## 📚 Description

A **Queue** is a linear data structure that follows the **FIFO (First-In, First-Out)** principle. It works just like a real-world line or queue—the first element that gets added is the first one that gets removed.

It has three main operations:
-   **Enqueue**: Adds a new element to the back (end) of the queue.
-   **Dequeue**: Removes the element from the front of the queue.
-   **Peek**: Looks at the front element without removing it.

---

## 🔁 Step-by-Step Explanation

Let's walk through how a queue operates.

#### Initial State
The queue is empty.
`Front -> [ ] <- Back`

#### Enqueue(10)
We add `10` to the queue. It's now at both the front and back.
`Front -> [10] <- Back`

#### Enqueue(20)
We add `20`. It goes to the back of the line.
`Front -> [10, 20] <- Back`

#### Peek()
We look at the front element. It returns `10`, and the queue is unchanged.
`Result: 10`
`Queue: Front -> [10, 20] <- Back`

#### Dequeue()
We remove the element from the front. `10` is returned, and `20` becomes the new front.
`Result: 10`
`Queue: Front -> [20] <- Back`

---

## 🛠 Real-World Analogy

The best analogy is a **checkout line at a grocery store**. The first person who gets in line is the first person to be served. New people join at the back of the line. Other examples include a print queue for a printer or a line at a ticket booth.

---

## 📌 Notes

-   A queue is perfect for managing tasks or items in the order they were received.
-   It's not designed for searching or accessing elements by their position.
-   It can be implemented efficiently using a **linked list** (with pointers to the head and tail) or a specialized **circular array**.

---

## 🔗 Related Topics

-   Stack
-   Breadth-First Search
-   Linked List