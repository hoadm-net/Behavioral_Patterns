# Mô tả bài toán

Bài toán yêu cầu sử dụng mẫu thiết kế **Visitor** để đọc và chuyển đổi dữ liệu từ các loại khác nhau (text, JSON, XML) 
thành danh sách các đối tượng ```Student```. Mỗi loại tệp được xử lý bởi một lớp Visitor riêng biệt, với các phương thức
để phân tích và trích xuất thông tin như mã số sinh viên (MSSV), họ tên, giới tính và năm sinh. 
Mẫu Visitor giúp tách biệt logic xử lý tệp và đối tượng ```Student```, dễ dàng mở rộng khi thêm các loại file khác.