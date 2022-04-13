```
# & : AND xét từng phần tử với nhau và đưa ra kết quả
# ví dụ
v <- c(3,1,TRUE,2+3i)
t <- c(4,1,FALSE,2+3i)
print(v&t)

# kết quả
[1]  TRUE  TRUE FALSE  TRUE
```

```
# | : OR xét từng phần tử với nhau và đưa ra kết quả
# ví dụ
v <- c(3,0,TRUE,2+2i)
t <- c(4,0,FALSE,2+3i)
print(v|t)

# kết quả
[1]  TRUE FALSE  TRUE  TRUE
```

```
# ! : NOT xét từng phần tử với nhau và đưa ra kết quả
# ví dụ
v <- c(3,0,TRUE,2+2i)
print(!v)

# kết quả
[1] FALSE  TRUE FALSE FALSE
```

```
# && : AND xét phần tử đầu tiên với nhau và đưa ra kết quả
# ví dụ
v <- c(3,0,TRUE,2+2i)
t <- c(1,3,TRUE,2+3i)
print(v&&t)

# kết quả
[1] TRUE
```

```
# || : OR xét phần tử đầu tiên với nhau và đưa ra kết quả
# ví dụ
v <- c(0,0,TRUE,2+2i)
t <- c(0,3,TRUE,2+3i)
print(v||t)

# kết quả
[1] FALSE
```