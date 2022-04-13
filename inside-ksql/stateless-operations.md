# Stateless Operations

## Cách Stateless làm việc
Xem xét ví dụ bên dưới
```
CREATE STREAM readings (
    sensor VARCHAR KEY,
    reading DOUBLE,
    location VARCHAR
) WITH (
    kafka_topic='readings',
    value_format='json',
    partitions=3
);
```

Trên đoạn câu lệnh trên thì có ghi rõ cấu trúc của stream và có metadata đính kèm gồm *khai báo topic*, *loại mã hóa dữ liệu* và *số lượng partition*

ksqlServer giao tiếp trược tiếp với Broker, nếu mà topic chưa được tồn tại thì nó sẽ được tạo bởi Kafka. 

Bên dưới sẽ là 2 dòng chèn dữ liệu vào stream, nó tương đương với mỗi message được publish.

```
INSERT INTO readings (sensor, reading, location)
VALUES ('sensor-1', 45, 'wheel');  

INSERT INTO readings (sensor, reading, location)
VALUES ('sensor-2', 41, 'motor');  
```

![ksqlDB](https://images.contentful.com/gt6dp23g0g38/3hTl0Hsgg0K3qnd3GdbLWA/01cd7efa4a8b6590e3d2a53622cd661a/reading.png)

Dựa vào mã băm của KEY của MESSAGE mà sẽ được phân vùng vào cùng một partition. Điều này dẫn đến các Message cùng Key sẽ nằm trong cùng một Partition và 1 Partition sẽ có thể chứa nhiều hơn 1 loại KEY.

## FILTER đơn giản

Hành động đơn giản nhất là biến đổi dữ liệu để phục vụ cho mục đích của chúng ta.

```
CREATE STREAM clean AS
    SELECT sensor,
        reading,
        UCASE(location) AS location
    FROM readings
    EMIT changes;
```

Ở đoạn code trên UCASE là sẽ biến đổi các giá trị ở trường *location* thành chữ hoa. Và nó tạo ra một stream mới *clean* dựa trên stream *sensor*

## FILTER kết hợp
Bên dưới là code thêm điều kiện lọc cho stream mới
```
CREATE STREAM high_readings AS
    SELECT sensor, reading, location
    FROM clean
    WHERE reading > 41
    EMIT CHANGES;
```

Chúng ta có thể kết hợp cả transformation và cả điều kiện lọc như sau
```
CREATE STREAM high_pri AS
    SELECT sensor,
        reading, 
        UCASE(location) AS location
    FROM readings
    WHERE reading > 41
    EMIT CHANGES;
```

