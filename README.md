# _Vendor & Order Tracker_

#### _Epicodus Project May 22, 2020_

#### By _**Matt Stroud**_

## Description

_An Epicodus individual project focused on software design with the MVC pattern in C#._  
_The user can create vendors and assign them orders to track business needs._  
_Uses RESTful routing._

## Demo
![Gif demo of website](https://raw.githubusercontent.com/mlstroud/vendor-order-tracker/master/vendorordertrackerdemo.gif)

## Specs
### Behaviors
| Behavior                                                   | Input                            | Output                                 |
|:-----------------------------------------------------------|:---------------------------------|---------------------------------------:|
| Program will allow user to add a vendor.                   | "Pierre's Bakery"                | "Pierre's Bakery"                      |
| Program will allow a user to view all vendors.             | "Pierre's Bakery"                | "Pierre's Bakery", "Top Pot Doughnuts" |
| Program will allow a user to add an order to a vendor.     | "Pierre's Bakery" -> "15 bagels" | "15 bagels"                            |
| Program will allow a user to view all orders for a vendor. | "Pierre's Bakery"                | "25 donuts, "15 bagels"                |

### Test Specs
| Behavior                                                  | Input                                           | Output                                                                             |
|:----------------------------------------------------------|:------------------------------------------------|-----------------------------------------------------------------------------------:|
| Vendor should create a new instance of Vendor             | Vendor vendor = new Vendor()                    | vendor.GetType() = Vendor                                                          |
| Vendor should store a name and description.               | ...vendor = new Vendor(name, description)       | vendor.Name = "...", vendor.Description = "..."                                    |
| Vendor should assign a unique ID to its instances.        | ...vendor3 = new Vendor()                       | vendor3.Id = 3;                                                                    |
| Vendor should create a static list of Vendors             | ...vendor2 = new Vendor()                       | Vendor.GetAllVendors = { vendor1, vendor2 }                                        |
|                                                           |                                                 |                                                                                    |
| Order should create a new instance of Order.              | Order order = new Order()                       | order.GetType() = Order                                                            |
| Order should store a title, description, price, and date. | ...order = new Order(name, desc.., price, date) | order.Name = "..", order.Description = "..", order.Price = "..", order.Date = ".." |
| Order should assign a unique ID to its instances.         | ...order3 = new Order()                         | order.Id = 3                                                                       |

### RESTful Routing
| Path                     | Route          | Method |
|:-------------------------|:---------------|-------:|
| /                        | Home->Index    | Get    |
| /vendors                 | Vendor->Index  | GET    |
| /vendors/new             | Vendor->New    | GET    |
| /vendors                 | Vendor->Create | POST   |
| /vendors/{id}            | Vendor->Show   | GET    |
| /vendors/{id}/orders     | Orders->Index  | GET    |
| /vendors/{id}/orders/new | Orders->New    | GET    |
| /vendors/{id}/orders     | Orders->Create | POST   |

## Setup/Installation Requirements
> This application requires the .NETCore SDK - [Find your version here](https://dotnet.microsoft.com/download/dotnet-core/2.2)

1. Create a VendorOrderTracker.Solution directory.
```
mkdir VendorOrderTracker.Solution
```
2. Navigate inside your new directory.
```
cd VendorOrderTracker.Solution
```
3. Clone this repository to your directory.
```
git clone https://github.com/mlstroud/vendor-order-tracker.git
```
4. Run the application with the following command:
```
dotnet run
```

## Known Bugs

* Certain css style aspects such as float would not apply correctly via linked script, and were hardcoded into their elements until issue is resolved.
 
## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/mlstroud/vendor-order-tracker/issues) here on GitHub._

## Technologies Used

* C#
* .NET Core
* MVC
* RESTful Design
* MSTest
* Git

### License

This software is licensed under the MIT license.

Copyright © 2020 **_Matt Stroud_**