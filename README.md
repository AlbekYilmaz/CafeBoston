Create a class library project named CafeBoston.
DATA and create 5 classes and 1 enum as descirbed below.



Product
* ProductName: string
* UnitPrice: decimal
- ToString(): string

OrderDetail
* ProductName: string
* UnitPrice: decimal
* Quantity: int
* PriceTRY: string-readonly
- TotalPrice(): decimal

OrderState (Active = 0, Paid = 1, Canceled = 2)

Order
* TableNo: int
* State: SiparisDurum
* PaidAmount: decimal
* StartTime: DateTime?
* EndTime: DateTime?
* OrderDetails: List<OrderDetail>
* TotalPriceTRY: string-readonly
- TotalPrice(): decimal

CafeData
* TableCount: int
* Products: List<Product>
* ActiveOrders: List<Order>
* PastOrders: List<Order>


* Property
- Method