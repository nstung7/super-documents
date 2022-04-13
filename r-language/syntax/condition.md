# Câu lệnh điều kiện

## If

```
if(boolean_expression) {
   // statement(s) will execute if the boolean expression is true.
}

# Ví dụ
x <- 30L
if(is.integer(x)) {
   print("X is an Integer")
}

# kết quả
[1] "X is an Integer"
```

## If ... else
```
if(boolean_expression) {
   // statement(s) will execute if the boolean expression is true.
} else {
   // statement(s) will execute if the boolean expression is false.
}

# ví dụ
x <- c("what","is","truth")

if("Truth" %in% x) {
   print("Truth is found")
} else {
   print("Truth is not found")
}

# kết quả
[1] "Truth is not found"
```

## Switch

```
switch(expression, case1, case2, case3....)

# ví dụ
x <- switch(
   3,
   "first",
   "second",
   "third",
   "fourth"
)
print(x)

# kết quả
[1] "third"
```