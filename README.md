### Big Project Operating System
# **TASK MANAGER APP**
1. INTRODUCE
```
   Hệ điều hành là một hệ chương trình hoạt động giữa người dùng và phần cứng của máy tính. 
Từ đó, cung cấp một môi trường để người sử dụng có thể thi hành các chương trình làm cho máy tính 
dễ sử dụng hơn, thuận tiện và hiệu quả. Việc quản lý tiến trình giúp cho người dùng dễ quản lý máy tính hơn 
và ứng dụng quản lý tiến trình sẽ giúp người dùng quản lý những ứng dụng đang chạy trên máy.
```
2. Tool
```
- Ngôn ngữ lập trình: C#.
- Phần mềm code: Visual studio 2019.
```
## Concept
1. Process
```
- Tiến trình là một thực thể đang thực hiện điều khiển một đoạn mã lệnh riêng không gian, 
địa chỉ, ngăn xếp và sở hữu một trạng thái giúp thông báo nó đang làm gì (đang chạy, đang chờ, đã đóng, ...).
- Tiến trình có 4 thành phần quan trọng: CPU, bộ nhớ, File, Thiết bị nhập xuất.
```
<p align="center">
<img align="center" src="https://st.quantrimang.com/photos/image/102011/25/task2.png?raw=true">
 </p>
 
2. API
> Các API được tổ chức trong 4 DLL của windows:
- KERNEL32:
```
Là DLL chính, đảm nhiệm quản lý bộ nhớ, thưc hiện chức năng đa nhiệm 
và những hàm ảnh hưởng trực tiếp đến hoạt động của Windows.
```
- USER32:
```
Thư viện quản lý Windows. Thư viện này chứa các hàm xử lý menu, định giờ, truyền tin, 
tập tin và nhiều phần không được hiển thị khác của Windows
```
- GDI32:
```
Giao diện thiết bị đồ hoạ (Graphics Device Interface). Thư viện này cung cấp 
các hàm vẽ trên màn hình, cũng như kiểm tra phần biểu mẫu nào cần vẽ lại.

```
- WINNM:
```
- Cung cấp các hàm multimedia để xử lý âm thanh, nhạc, video thời gian thực, 
lấy mẫu, v.v… Nó là DLL 32 bit. (Thư viện 16 bit tên là MMSYSTEM)
- Ta có thể tìm các tập tin này trong thư mục \Windows\system. Ngoài ra, 
còn có các DLL nhỏ hơn, cũng được dùng phổ biến để cung cấp các dịch vụ đặc biệt cho ứng dụng.
- Trên đây là các tên DLL 32 bit. Phiên bản VB4 là bản cuối cùng còn hỗ trợ 16 bit.
```
## My APP
- [x] Chương trình quản lý tiến trình cho phép người dùng quản lý những ứng dụng đang chạy trên máy tính.
- [x] Chương trình cho người dùng biết được các ứng dụng đang chiếm bao nhiêu phần trăm bộ nhớ trong RAM và CPU.
- [X] Giúp người dùng mở nhanh các ứng dụng thông qua chương trình quản lý tiến trình.
- [X] Ngắt ứng dụng đang chạy trên máy tính thông qua chương trình quản lý tiến trình.
#### NOTICE: 
1. Install Metro Framework
<p align="center">
<img align="center" src="https://foxlearn.com/ezoimgfmt/4.bp.blogspot.com/-R_QIJ1oz0O8/WRr9XXO2aII/AAAAAAAAAhw/mJDfuADPkpYrzGF3xKJvoo4ZciKxNSYsACKgB/s1600/download-metro-framework.png?ezimgfmt=rs:392x231/rscb4/ng:webp/ngcb4?raw=true">
 </p>
2. Use Library
<p align="center">
<img align="center" src="https://cdn.ourcodeworld.com/public-media/gallery/gallery-581d9b68de762.png?raw=true">
 </p>
## DEMO
