MediatR
基本上MediatR就是Service層的中介者，大部分狀況會搭配CQRS讀寫分離模式使用。
我們看到下圖是一個簡易流程，為了簡化說明，可以直接視為. Net Core就是後端Controller開始的地方，到Service(Logic)端部分對於DB操作在CQRS模式下會特別將讀(Query logic)寫(Command logic)猜成兩部分。

<img width="704" height="263" alt="截圖 2025-08-02 下午2 28 51" src="https://github.com/user-attachments/assets/e4900080-60be-46f8-8326-e3b30edf8b69" />


<img width="595" height="399" alt="截圖 2025-08-02 下午2 29 31" src="https://github.com/user-attachments/assets/b58180e2-b48f-494c-a7b1-aaba3a24dc60" />



CQRS
