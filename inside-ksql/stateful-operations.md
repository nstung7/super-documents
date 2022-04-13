# Stateful Operations

## **Cách Stateful hoạt động**

Ở **Stateless** ksqlDB không giữ lại các tính toán hoặc thông tin khi nó xử lý từng hàng.

## **Materialized views**
Material View tăng tốc các truy vấn bằng cách duy trì các kết quả tính toán. Tính toán ở đây cụ thể có thể là SUM, COUNT, AVERAGE, ...

```
CREATE TABLE avg_readings AS
    SELECT sensor, 
         AVG(reading) as avg 
    FROM readings
    GROUP BY sensor
    EMIT CHANGES;
```

Khi các message mới được publish trong Stream avg_readings sẽ được cập nhật tương ứng. Thường thì ksqlDB không tính toán lại AVERAGE mới từ đầu mà chỉ nhận giá trị mới và tính toán tiếp tục nên Material View có thể nhanh như vậy.

ksqlDB sẽ tạo ra các Log kiểm tra các thay đổi với Material View và lưu trữ nó ở dưới dạng Apache Kafka Topic, có nghĩa là nó sẽ giúp ta phục hồi trạng thái nếu cần.

## **Push và Pull Queries**

Pull queries, thường được gọi trên Material View, trong đó truy vấn sẽ được nhận phản hồi ngay lập tức. 

Push queries, cho phép ta truy cập vào các Stream và luôn luôn cập nhật chúng cho đến khi dừng. Vì thế nếu chúng ta vận dụng trên Material View thì chúng ta sẽ nhận được bản cập nhật trạng thái thay đổi.

## **Automatic Repartitioning** (Tái phân vùng tự động)
Trong ksqlDB có một TOPIC để thực hiện tự động phân vùng lại (repartition topic).

```
CREATE TABLE part_avg AS
    SELECT area,
        AVG(reading) AS avg
    FROM readings
    GROUP BY area
    EMIT CHANGES;
```
Ở trên chúng ta đang lấy trung bình của các reading, nhưng lần này chúng ta dùng GROUP BY AREA. Để thực hiện điều này, ksqlDB đặt tất cả các hàng cho mỗi key trên cùng một phân vùng trong một topic được phân vùng lại, sau khi sử dụng topic đó để thực hiện phép tính của bạn.

### Trích trong StackOverflow
Trong kafka, thứ tự tin nhắn được đảm bảo trong phân vùng. Nhưng đối với các phân vùng khác nhau trong cùng một chủ đề, không có đảm bảo thứ tự. Nếu bạn tự động xếp hạng dựa trên tải và phân vùng thay đổi của message, bạn không thể đáp ứng đảm bảo đặt hàng. Đó là lý do tại sao không có tính năng tự động phân vùng cho các phân vùng trong Kafka.

## **Changelogs Examined**
Mục đích của bảng Log này là cung cấp khả năng dự phòng lưu trữ dữ liệu để phục hồi dữ liệu.