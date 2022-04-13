# Scaling

Trường hợp chung có 1 server với 8 partition thì 1 server đó sẽ phải phục vụ cho 8 partition. Bây giờ Scale lên 2 server thì mỗi server sẽ chia nhau 1 server 4 partition (tốc độ nhân 2). Cứ thế mà tính

## **Scaling với Stateless**
Nhưng đối với Stateless thì nó sẽ phân chia theo số partition tức là có 8 partition (đánh số từ 1 --> 8) thì nếu có 2 server thì 1 server sẽ đảm nhiệm partition (1 --> 4) và server đảm nhiệm partition (5 --> 8)


## **Scaling với Stateful**
Đối với stateful cụ thể là các Material View thì nó phân chia theo KEY của message