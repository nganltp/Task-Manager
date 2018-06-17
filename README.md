# Task-Manager
This is a list of tasks that need to be completed, organized in order of priority.
Chương 1.	Hiện trạng và yêu cầu từ thực tế
1.1.	Hiện trạng vấn đề
1.1.1.	Vấn đề
Việc quản lý thời gian luôn là một vấn đề khó khăn với hầu hết tất cả chúng ta khi khối lượng công việc ngày càng nhiều và sắp xếp sao cho tối ưu các công việc là một vấn đề nan giải khác.
Phương hướng giải quyết
Với sự phát triển của ngành công nghệ phần mềm, ta có thể tạo ra nhiều sản phẩm hữu ích phụ trợ đắc lực cho người dùng. Vì vậy, nhóm em quyết định làm ứng dụng quản lý công việc để giải quyết những khó khăn trên.

1.2.	Yêu cầu sơ bộ về phần mềm
1.2.1.	Tin học
Phần mềm chạy được trên những máy tính có cấu hình thấp và không yêu cầu quá cao về phần cứng.
1.2.2.	Con người
•	Ngôn ngữ chính: tiếng Anh.
•	Giao diện: đẹp, quen thuộc và dễ sử dụng,
•	Độ phức tạp: thấp, dễ đọc.
 
Chương 2.	Phân tích yêu cầu phần mềm và mô hình hóa
2.1.	Yêu cầu phần mềm
2.1.1.	Yêu cầu chức năng
•	Bảng tổng hợp và định dạng các yêu cầu:
Định danh	Mô tả Yêu Cầu
YC_1	Add Job	Thêm công việc cho người dùng.
YC_2	Only today	Xem công việc trong ngày.
YC_3 	All work	Xem tất cả các công việc.
YC_4	Notify	Cài đặt thông báo nhắc lịch.
YC_5 	To Do List 	Xem những công việc chưa làm.
YC_6	Important	Công việc quan trọng.
YC_7 	Emergency	Công việc khuẩn cấp.
YC_8	Nomal	Công việc bình thường
YC_9	Miss	Công việc đã bỏ lỡ.
Bảng 1: Bảng tổng hợp yêu cầu chức năng
Chương 3.	Thiết kế
3.1.	Thiết kế giao diện và thành phần xử lí của giao diện
3.1.1.	Tổng thể về giao diện hệ thống







Hình 1: Sơ đồ giao diện tổng thể
Giao diện mở đầu với Main, từ Main, người dùng muốn thêm, xóa, sửa công việc sẽ mở cửa sổ DailyPlan. Sau khi chỉnh sửa hoàn chỉnh, đóng cửa sổ DailyPlan sẽ về lại Main. 
Cửa sổ Information được mở ra từ cửa sổ Main khi người dùng xem thông tin của phần mềm. Từ Informatin, người dùng có thể về Main bằng cách đóng cửa sổ hiện tại.

3.1.2.	Giao diện Trang Chủ (Homepage)
 
Hình 2: Giao diện Menu
Mô tả thành phần giao diện: Gồm các khung chứa các công việc theo mức độ khác nhau (Important, Emergency, Nomal, Missed) và To Do List chứa các công việc sắp tới phải làm. 
phía trên là 2 button để xem tất cả các công việc (All work) hoặc xem công việc ngày hôm nay(Only Today).  Notify để check thông báo theo khoảng thời gian người dùng đặt ra. 
Menu Strip gồm Add Job, Exit và About. Add Job để thêm công việc, Exit thoát chương trình và About giới thiệu về nhóm.

3.1.3.	Giao diện All Plan và Today Plan
 
Hình 3: Giao diện All Plan

 
Hình 4: Giao diện Today Plan

Mô tả thành phần giao diện:  Gồm tất cả các công việc đã được lên lịch trước đó.Riêng với Today Plan chỉ hiện công việc trong ngày hôm đó. Mỗi công việc sẽ gồm check box để biết đã hoàn thành hay chưa, nội dung công việc, thời gian, và trạng thái của công việc.
3.1.4.	Giao diện About
 
Hình 5: Giao diện About

Mô tả thành phần giao diện:  Giới thiệu.

