# Chuỗi

## Khai báo chuỗi
Chuỗi có thể nằm trong dấu nháy kép hoặc nháy đơn. Nhưng nếu bắt đầu bằng dấu nháy nào thì phải bắt buộc là dấu nháy đó.

```
a <- 'Start and end with single quote'
print(a)

b <- "Start and end with double quotes"
print(b)

c <- "single quote ' in between double quotes"
print(c)

d <- 'Double quotes " in between single quote'
print(d)
```

## Thao tác với chuỗi

### **paster()** nối chuỗi
```
# cấu trúc hàm
paste(..., sep = " ", collapse = NULL)
sep: dấu phân cách
collapse: sử dụng để loại bỏ khoảng trắng giữa hai chuỗi nhưng không phải là khoảng trắng trong hai từ của một chuỗi.


# ví dụ
a <- "Hello"
b <- 'How'
c <- "are you? "

print(paste(a,b,c))

print(paste(a,b,c, sep = "-"))

print(paste(a,b,c, sep = "", collapse = ""))

# kết quả
[1] "Hello How are you? "
[1] "Hello-How-are you? "
[1] "HelloHoware you? "
```

## Định dạng chuỗi

```
format(x, digits, nsmall, scientific, width, justify = c("left", "right", "centre", "none"))

x: là đàu vào vector
digits: tổng chữ số hiển thị
nsmall: sô chữ tối thiểu ở bên phải dấu thập phân
scientific: được đặt thành TRUE nếu muốn hiển thị kí hiệu khoa học
width: cho biết chiều rộng tối thiểu được hiển thị bằng khoảng trống đệm ở phần đầu.
justify: hiển thị của chuỗi sang trái, phải hoặc giữa (căn lề)


# ví dụ
# Total number of digits displayed. Last digit rounded off.
result <- format(23.123456789, digits = 9)
print(result)

# Display numbers in scientific notation.
result <- format(c(6, 13.14521), scientific = TRUE)
print(result)

# The minimum number of digits to the right of the decimal point.
result <- format(23.47, nsmall = 5)
print(result)

# Format treats everything as a string.
result <- format(6)
print(result)

# Numbers are padded with blank in the beginning for width.
result <- format(13.7, width = 6)
print(result)

# Left justify strings.
result <- format("Hello", width = 8, justify = "l")
print(result)

# Justfy string with center.
result <- format("Hello", width = 8, justify = "c")
print(result)

# kết quả
[1] "23.1234568"
[1] "6.000000e+00" "1.314521e+01"
[1] "23.47000"
[1] "6"
[1] "  13.7"
[1] "Hello   "
[1] " Hello  "
```

## Đếm số ký tự trong một chuỗi
nchar(x)
x: là đầu vào vector
```
result <- nchar("Count the number of characters")
print(result)

# kết quả
[1] 30
```

## Hàm toupper() & tolower()
```
toupper(x)
tolower(x)

# ví dụ
# Changing to Upper case.
result <- toupper("Changing To Upper")
print(result)

# Changing to lower case.
result <- tolower("Changing To Lower")
print(result)

# kết quả
[1] "CHANGING TO UPPER"
[1] "changing to lower"
```

## Trích xuất chuỗi
```
substring(x,first,last)

# ví dụ
# Extract characters from 5th to 7th position.
result <- substring("Extract", 5, 7)
print(result)

# kết quả
[1] "act"
```