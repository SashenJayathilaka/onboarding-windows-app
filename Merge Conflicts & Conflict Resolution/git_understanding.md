# 📌 Git Merge Conflict Resolution

## What Caused the Conflict?

- The merge conflict occurred because the same part of `conflict.txt` was modified in both `main` and `feature-branch`. Git could not determine which change to keep, resulting in a conflict.

## How I Resolved It

- I manually edited the file, combining both changes into a meaningful final version. After saving, I staged the file using `git add conflict.txt` and committed the resolution.

## What I Learned

- Merge conflicts occur when the same file section is modified in different branches.
- Git provides conflict markers (`<<<<<<<`, `=======`, `>>>>>>>`) to help identify differences.
- Conflicts must be resolved manually before completing a merge.
- Using a Git desktop or gitlens client makes resolution easier by providing a visual diff tool.

---

### 🔒 Practical Evidence

![Image](https://github.com/user-attachments/assets/a4dcb9eb-5fe9-4897-b43b-38b389ea6c44)

## ![Image](https://github.com/user-attachments/assets/c3352d26-52a8-4ab1-9926-f0352a8d9e92)

---
