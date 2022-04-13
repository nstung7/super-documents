## Đối với kiểu dữ liệu phức tạp được cấu thành từ các vector nguyên tử
* Vectors
* Lists
* Matrices
* Array
* Factors
* Data Frames

## Vector
Khi muốn tạo vector có nhiều phần tử ta dùng hàm **c()** có nghĩa là kết hợp các phần tử thành một vector.\
*Ví dụ*
```
apple <- ('red', 'green', 'yellow')
print(apple)
print(class(apple))
```
*Kết quả*
```
[1] "red"   "green"    "yellow"
[2] "character"
```

## Lists
List là R-object có thể chứa nhiều loại phần tử khác nhau bên trong nó như vector, hàm và thậm chí là một danh sách khác bên trong nó.\
*Ví dụ*
```
list1 <- list(c(2,3,4), 21.4, sin)
print(list1)
```
*Kết quả*
```
[[1]]
[1] 2 5 3

[[2]]
[1] 21.3

[[3]]
function (x)  .Primitive("sin")
```
## Matrices
Ma trận là một tập hợp hai chiều. Nó có thể được tạo bằng cách sử dụng đầu vào vecto cho hàm ma trận
*Ví dụ*
```
M = matrix( c('a','a','b','c','b','a'), nrow = 2, ncol = 3, byrow = TRUE)\
print(M)
```
*Kết quả*
```
    [,1] [,2] [,3]
[1,] "a"  "a"  "b"
[2,] "c"  "b"  "a"
```
## Arrays
Trong khi ma trận được giới hạn trong hai chiều, mảng có thể có bất kì số thứ nguyên nfao. Hàm array nhận thuộc tính dim tạo ra số thứ nguyên cần thiết.\
*Ví dụ*
```
a <- array(c('green','yellow'),dim = c(3,3,2))
print(a)
```
*Kết quả*
```
, , 1

     [,1]     [,2]     [,3]  
[1,] "green"  "yellow" "green"
[2,] "yellow" "green"  "yellow"
[3,] "green"  "yellow" "green" 

, , 2
     [,1]     [,2]     [,3]    
[1,] "yellow" "green"  "yellow"
[2,] "green"  "yellow" "green" 
[3,] "yellow" "green"  "yellow" 
```
## Factors
Được tạo ra bằng cách sử dụng một vector. Nó lưu trữ vector cùng với các giá trị riêng biệt của các phần tử trong vector dưới dạng nhãn. Các nhãn luôn là ký tự bất kể nó là số hay ký tự hoặc boolean, v.v. trong vector đầu vào. Chúng rất hữu ích cho việc lập mô hình thống kê.
Factors được tạo bằng cách sử dụng hàm **factor()**. Các hàm **nlevels** cung cấp số lượng các cấp độ.\
*Ví dụ*
```
# Create a vector.
apple_colors <- c('green','green','yellow','red','red','red','green')

# Create a factor object.
factor_apple <- factor(apple_colors)

# Print the factor.
print(factor_apple)
print(nlevels(factor_apple))
```
*Kết quả*
```
[1] green  green  yellow red    red    red    green 
Levels: green red yellow
[1] 3
```

## Data Frames
Data Frames là các đối tượng dữ liệu dạng bảng. Không giống như ma trận, mỗi cột của data frame có thể chứa các chế độ dữ liệu khác nhau. Cột đầu tiên có thể là số trong khi cột thứ 2 có thể là kí tự và cột thứ 3 có thể là logic. Nó là một danh sách vector có đồ dại bằng nhau.
Tạo data frame bằng hàm **data.frame()**\
*Ví dụ*
```
# Create the data frame.
BMI <- 	data.frame(
   gender = c("Male", "Male","Female"), 
   height = c(152, 171.5, 165), 
   weight = c(81,93, 78),
   Age = c(42,38,26)
)
print(BMI)
```
*Kết quả*
```
  gender height weight Age
1   Male  152.0     81  42
2   Male  171.5     93  38
3 Female  165.0     78  26  
```