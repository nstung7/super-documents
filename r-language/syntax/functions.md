# Hàm
## Trong R có 2 loại hàm
1. Hàm tích hợp
2. Hàm người dùng tự định nghĩa

## Cấu tạo của 1 hàm
1. Tên hàm
2. Đối số (không bắt buộc)
3. Phần thân hàm
4. Kết quả trả về (không bắt buộc)

```
function_name <- function(arg_1, arg_2, ...) {
   Function body 
}

# hàm tích hợp
print(seq(32,44))
print(mean(25:82))
print(sum(41:68))

# hàm tự định nghĩa
sum <- function(a, b) {
    return(a + b)
}

# gọi hàm
sum(4, 6)

```