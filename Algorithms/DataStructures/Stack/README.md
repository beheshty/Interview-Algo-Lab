# 🥞 Stack

**Category**: Data Structure  
**Time Complexity**: Push, Pop, Peek are all $O(1)$  
**Space Complexity**: $O(n)$  

---

## 📚 Description

A **Stack** is a simple linear data structure that follows the **LIFO (Last-In, First-Out)** principle. This means the last element you add to the stack is the first one you can remove.

It has three primary operations:
-   **Push**: Adds a new element to the top of the stack.
-   **Pop**: Removes the top element from the stack.
-   **Peek**: Looks at the top element without removing it.

---

## 🔁 Step-by-Step Explanation

Let's see how a stack works.

#### Initial State
The stack is empty.
`Top -> [ ]`

#### Push(10)
We push `10` onto the stack. It becomes the top element.
`Top -> [10]`

#### Push(20)
We push `20`. It's now the new top.
`Top -> [20, 10]`

#### Peek()
We look at the top element. It returns `20`, but the stack doesn't change.
`Result: 20`
`Stack: Top -> [20, 10]`

#### Pop()
We remove the top element. `20` is returned, and `10` becomes the new top.
`Result: 20`
`Stack: Top -> [10]`

---

## 🛠 Real-World Analogy

Think of a **stack of plates**. You can only add a new plate to the top, and you can only take a plate from the top. You can't easily grab a plate from the middle or bottom. Another great example is the "Undo" (Ctrl+Z) feature in a text editor—each action is pushed onto a stack, and "Undo" pops the last action off.

---

## 📌 Notes

-   A stack is not designed for fast searching or accessing elements by index.
-   It can be implemented using either an **array** or a **linked list**.

---

## 🔗 Related Topics

-   Queue
-   Linked List