# Vòng lặp

## Câu lệnh thường dùng trong các vòng lặp
```
break : dừng vòng lặp

next : tiếp tục vòng lặp
```

## Vòng lặp Repeat
Thực thi cùng một đoạn mã lặp đi lặp lại cho đến khi đáp ứng điều kiện dừng.

```
repeat { 
   commands 
   if(condition) {
      break
   }
}

# ví dụ
v <- c("Hello","loop")
cnt <- 2

repeat {
   print(v)
   cnt <- cnt+1
   
   if(cnt > 5) {
      break
   }
}

# kết quả
[1] "Hello" "loop" 
[1] "Hello" "loop" 
[1] "Hello" "loop" 
[1] "Hello" "loop" 
```
## Vòng lặp While
Lặp đi lặp lại câu lệnh cho đến khi gặp điều kiện dừng.
```
while (test_expression) {
   statement
}

# ví dụ
v <- c("Hello","while loop")
cnt <- 2

while (cnt < 7) {
   print(v)
   cnt = cnt + 1
}

# kết quả
[1] "Hello"  "while loop"
[1] "Hello"  "while loop"
[1] "Hello"  "while loop"
[1] "Hello"  "while loop"
[1] "Hello"  "while loop"
```

## Vòng lặp For
Lặp đi lặp lại các câu lệnh trong một số lần lặp cụ thể
```
for (value in vector) {
   statements
}

# ví dụ
v <- LETTERS[1:4]
for ( i in v) {
   print(i)
}

# kết quả
[1] "A"
[1] "B"
[1] "C"
[1] "D"
```