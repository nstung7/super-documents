# Types

## Trong R thì có loại dữ liệu cơ bản là R-object được gọi là vector.
* Character
* Wide character
* Integer
* Float
* Double
* Boolean

## Chi tiết các kiểu dữ liệu
1. **Logical**\
TRUE - FALSE\
**Ví dụ**\
v <- TRUE\
print(class(v))
**Kết quả**\
[1] "logical"

2. **Numeric**\
12.3, 5, 999\
**Ví dụ**\
v <- 23.5\
print(class(v))\
**Kết quả**\
[1] "numeric"

3. **Integer**\
2L, 34L, 0L\
**Ví dụ**\
v <- 2L\
print(class(v))\
**Kết quả**\
[1] "integer"

4. **Complex**\
3 + 2i\
**Ví dụ**\
v <- 3 + 5i\
print(class(v))\
**Kết quả**\
[1] "complex"

4. **Character**\
'a', "good", "TRUE", "445"\
**Ví dụ**\
v <- "TRUE"\
print(class(v))\
**Kết quả**\
[1] "character"

5. **Raw**\
"Hello" is stored as 48 65 6c\
**Ví dụ**\
v <- charToRaw("Hello")\
print(class(v))\
**Kết quả**\
[1] "raw"