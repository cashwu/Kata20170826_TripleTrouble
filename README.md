# [Triple trouble](https://www.codewars.com/kata/triple-trouble-1/csharp)

---

Write a function
```
TripleDouble(long num1, long num2)
```
which takes in numbers `num1` and `num2` and returns `1` if there is a straight triple of a number at any place in `num1` and also a straight double of the same number in `num2`.
For example:
```
TripleDouble(451999277, 41177722899) == 1 // num1 has straight triple 999s and 
                                          // num2 has straight double 99s

TripleDouble(1222345, 12345) == 0 // num1 has straight triple 2s but num2 has only a single 2

TripleDouble(12345, 12345) == 0

TripleDouble(666789, 12345667) == 1
```
If this isn't the case, return `0`

---

### 中文大意

第一個數字中會有連續出現3次的數，而且在第二個數字中會連續出現2次
