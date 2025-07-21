MediatR
基本上MediatR就是Service層的中介者，大部分狀況會搭配CQRS讀寫分離模式使用。
我們看到下圖是一個簡易流程，為了簡化說明，可以直接視為. Net Core就是後端Controller開始的地方，到Service(Logic)端部分對於DB操作在CQRS模式下會特別將讀(Query logic)寫(Command logic)猜成兩部分。

![image.png](attachment:6960a5df-7b00-4a5e-a8ad-df9a8b97817a:image.png)

![image.png](attachment:0fdfc539-fe0d-4ef6-9ea7-b776e30314de:image.png)


CQRS
