MediatR
基本上MediatR就是Service層的中介者，大部分狀況會搭配CQRS讀寫分離模式使用。
我們看到下圖是一個簡易流程，為了簡化說明，可以直接視為. Net Core就是後端Controller開始的地方，到Service(Logic)端部分對於DB操作在CQRS模式下會特別將讀(Query logic)寫(Command logic)猜成兩部分。
<img width="582" height="396" alt="image" src="https://github.com/user-attachments/assets/b7d852eb-ef1f-407d-91d1-78a94d05a731" />
