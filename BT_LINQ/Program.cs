using BT_LINQ;
using System;
using System.Reflection.Metadata.Ecma335;

List<Car> cars = new List<Car>()
{
    new Car(1, "Toyota", 2023, 25000, "Gasoline", 5),
    new Car(2, "Audi", 2022, 22000, "Gasoline", 5),
    new Car(3,"Ford", 1985, 30000, "Gasoline", 5),
    new Car(4, "Tesla", 2021, 130000, "Electric", 7),
    new Car(5, "BMW", 2022, 35000, "Gasoline", 5),
    new Car(6, "Mercedes-Benz", 2024, 250000, "Gasoline", 5),
    new Car(7, "Audi", 2023, 38000, "Gasoline", 5),
    new Car(8, "Toyota", 2022, 20000, "Gasoline", 5),
    new Car(9, "Hyundai", 2024, 190000, "Gasoline", 5),
    new Car(10, "Audi", 2000, 350000, "Gasoline", 5),
    new Car(12, "Mazda", 1990, 40000, "Gasoline", 5),
    new Car(13, "Audi", 1998, 75000, "Gasoline", 5),
    new Car(14, "Toyota", 1989, 20000, "Gasoline", 5),
    new Car(15, "BMW", 2024, 500000, "Gasoline", 5),
    new Car(16, "Ford", 2015, 55000, "Gasoline", 5)
};

List<Truck> trucks = new List<Truck>
{
    new Truck(1, "Ford", 1999, 125000, "Công ty TNHH AHZ", 1000),
    new Truck(2, "Mercedes-Benz", 2004, 80000, "Công ty TNHH Sun Light", 4000),
    new Truck(3, "Ford", 2015, 35000, "Công ty Nội thất Trọng Hiếu", 5000),
    new Truck(4, "Ford", 2020, 450000, "Công ty TNHH Tiger", 500),
    new Truck(5, "Huyndai", 1980, 12500, "Công ty TNHH Sơn Hải", 3000),
    new Truck(6, "Ford", 2023, 47000, "Công ty TNHH Bình Minh", 1000),
    new Truck(7, "Ford", 1999, 138000, "Công ty bảo hiểm Tiến Đức", 1000),
    new Truck(8, "Huyndai", 2009, 110000, "Công ty TNHH Blue Moon", 3000),
    new Truck(9, "Ford", 2016, 85000, "Công ty TNHH PowerCut", 6000),
    new Truck(10, "Ford", 2015, 32000, "Công ty TNHH NHBC", 9000),
    new Truck(11, "Mercedes-Benz", 1998, 19000, "Công ty TNHH MIXI", 800),
    new Truck(12, "Ford", 2021, 267000, "Công ty Bánh kẹo Bảo Quân", 1500),
    new Truck(13, "Mazda", 2021, 170000, "Công ty TNHH Xuân Định", 4000),
    new Truck(14, "Ford", 2014, 55000, "Công ty TNHH Lenovo Việt Nam", 1000),
    new Truck(15, "Audi", 2024, 67000, "Công ty TNHH Logitech Việt Nam", 2000),
};

List<Department> departments = new List<Department>
{
    new Department(1, "Ha Noi"),
    new Department(2, "Ho Chi Minh"),
    new Department(3, "Da Nang")
};

List<Employee> employees = new List<Employee>
{
    new Employee(1, 24, 12000, new DateTime(2000, 08, 02), 1),
    new Employee(2, 20, 8000, new DateTime(2004, 11, 27), 1),
    new Employee(3, 18, 3500, new DateTime(2006, 06,15), 3),
    new Employee(4, 20, 9000, new DateTime(2004, 09, 10), 2),
    new Employee(5, 21, 13000, new DateTime(2003, 08, 02), 3)
};

//bool status = true;
//while (status)
//{
//    DisplayMenu();
//    int choice = int.Parse(Console.ReadLine());
//    RunMenu(choice);

//    Console.Write("Tiep tuc? (y/n): ");
//    string answer = Console.ReadLine().ToLower();
//    status = answer == "y";
//}

//void DisplayMenu()
//{
//    Console.WriteLine("-------- Vehicle ---------");
//    Console.WriteLine("1. Hien thi tat ca Car");
//    Console.WriteLine("2. Hien thi tat ca Truck");
//    Console.WriteLine("-------- Car ---------");
//    Console.WriteLine("3. Hien thi cac xe co gia tu 100000 den 250000");
//    Console.WriteLine("4. Hien thi cac xe co nam san xuat > 1990");
//    Console.WriteLine("5. Gom cac xe theo hang san xuat, tinh tong gia tri theo nhom");
//    Console.WriteLine("-------- Truck --------");
//    Console.WriteLine("6. Hien thi danh sach cac Truck theo thu tu nam san xuat moi nhat");
//    Console.WriteLine("7. Hien thi ten cong ty chu quan cua Truck");
//    Console.Write("Nhap lua chon cua ban: ");
//}

//void RunMenu(int choice)
//{
//    switch (choice)
//    {
//        case 1:
//            ShowAllCars();
//            break;
//        case 2:
//            ShowAllTrucks();
//            break;
//        case 3: 
//            ShowCarByPrice();
//            break;
//        case 4: 
//            ShowCarByMY();
//            break;
//        case 5: 
//            ShowCarBrandCount();
//            break;
//        case 6: 
//            ShowTruckByMY();
//            break;
//        case 7: 
//            ShowTruckCompanies();
//            break;
//        default: 
//            Console.WriteLine("Sai cu phap! Vui long chon lai");
//            break;
//    }
//}

////  Hien thi tat ca cac car
//void ShowAllCars()
//{
//    Console.WriteLine("All cars:");
//    foreach (Car car in cars)
//    {
//        Console.WriteLine($"Id: {car.Id}, Brand: {car.Brand}, Manufacturing Year: {car.ManufacturingYear}, Price: {car.Price}, Engine Type: {car.EngineType}, Passenger Capacity: {car.PassengerCapacity}");
//    }
//}


////  Hien thi tat ca cac truck
//void ShowAllTrucks()
//{
//    Console.WriteLine("All trucks: ");
//    foreach (Truck truck in trucks)
//    {
//        Console.WriteLine($"Id: {truck.Id}, Brand: {truck.Brand}, Manufacturing Year: {truck.ManufacturingYear}, Price: {truck.Price}, Company: {truck.Company}, Load Capacity: {truck.LoadCapacity}");
//    }
//}

////  Hien thi cac xe co gia tu 100000 den 250000
//void ShowCarByPrice()
//{
//    Console.WriteLine("Hien thi cac xe co gia tu 100000 den 250000:");
//    var customPriceCars = cars.Where(car => car.Price >= 100000 && car.Price <= 250000);
//    foreach (var car in customPriceCars)
//    {
//        Console.WriteLine($"Id:  {car.Id} , Brand: {car.Brand}, Manufacturing Year: {car.ManufacturingYear}, Price: {car.Price}, Engine Type: {car.EngineType}, Passenger Capacity: {car.PassengerCapacity}");
//    }
//}


////  Hien thi cac xe co nam san xuat > 1990
//void ShowCarByMY()
//{
//    Console.WriteLine("Hien thi cac xe co nam san xuat > 1990:");
//    var customMYofCars = cars.Where(car => car.ManufacturingYear > 1990);
//    foreach (var car in customMYofCars)
//    {
//        Console.WriteLine($"Id:  {car.Id} , Brand: {car.Brand}, Manufacturing Year: {car.ManufacturingYear}, Price: {car.Price}, Engine Type: {car.EngineType}, Passenger Capacity: {car.PassengerCapacity}");
//    }
//}


////  Gom cac xe theo hang san xuat, tinh tong gia tri theo nhom
//void ShowCarBrandCount()
//{
//    Console.WriteLine("Gom cac xe theo hang san xuat, tinh tong gia tri theo nhom:");
//    var carBrandCount = cars.GroupBy(car => car.Brand).Select(group => new { Brand = group.Key, Count = group.Count() });
//    foreach (var group in carBrandCount)
//    {
//        Console.WriteLine($"Brand: {group.Brand}, Count: {group.Count}");
//    }
//}

////  Hien thi danh sach Truck theo thu tu nam san xuat moi nhat
//void ShowTruckByMY()
//{
//    Console.WriteLine("Hien thi danh sach Truck theo thu tu nam san xuat moi nhat:");
//    var customMYofTrucks = trucks.OrderByDescending(truck => truck.ManufacturingYear);
//    foreach (var truck in customMYofTrucks)
//    {
//        Console.WriteLine($"Id: {truck.Id}, Brand: {truck.Brand}, Manufacturing Year: {truck.ManufacturingYear}, Price: {truck.Price}, Company: {truck.Company}, Load Capacity: {truck.LoadCapacity}");
//    }
//}


////  Hien thi ten cong ty chu quan cua Truck
//void ShowTruckCompanies()
//{
//    Console.WriteLine("Hien thi ten cong ty chu quan cua Truck:");
//    var companyTrucks = trucks.Select(truck => truck.Company);
//    foreach (var company in companyTrucks)
//    {
//        Console.WriteLine(company);
//    }
//}

// Max, min, average salaly cua Employee trong list
    var maxSalary = employees.Max(employee => employee.Salary);
    Console.WriteLine($"Max salary cua Employee trong list: {maxSalary}");

    var minSalary = employees.Min(employee => employee.Salary);
    Console.WriteLine($"Min salary cua Employee trong list: {minSalary}");

    var avgSalary = employees.Average(employee => employee.Salary);
    Console.WriteLine($"Average salary cua Employee trong list: {avgSalary}");

// inner join
Console.WriteLine();
Console.WriteLine("Inner join: ");
var innerJoin = employees.Join(
            departments,
            employee => employee.DepartmentId,
            department => department.Id,
            (employee, department) => new
            {
                EmployeeId = employee.Id,
                DepartmentName = department.Name
            });
foreach (var inner in innerJoin)
{
    Console.WriteLine($"EmployeeId: {inner.EmployeeId}, DepartmentName: {inner.DepartmentName}");
}


// group join
Console.WriteLine();
Console.WriteLine("Group join");
var groupJoin = departments.GroupJoin(
            employees,
            department => department.Id,
            department => department.DepartmentId,
            (department, employeeGroup) => new
            {
                DepartmentName = department.Name,
                Employees = employeeGroup
            });
foreach (var group in groupJoin)
{
    Console.WriteLine($"Department Name: {group.DepartmentName}");
    foreach (var employee in group.Employees)
    {
        Console.WriteLine($"\tEmployeeId: {employee.Id}, Age: {employee.Age}, Salary: {employee.Salary}, Birthday: {employee.Birthday}");
    }
}

// left join
Console.WriteLine();
Console.WriteLine("Left join: ");
var leftJoin = employees.Join(
    departments,
    employee => employee.DepartmentId,
    department => department.Id,
    (employee, department) => new
    {
        EmployeeId = employee.Id,
        DepartmentName = department.Name
    }).DefaultIfEmpty();

foreach (var item in leftJoin)
{
    Console.WriteLine($"EmployeeId: {item.EmployeeId}, DepartmentName: {(item.DepartmentName != null ? item.DepartmentName : "N/A")}");
}



//right join
Console.WriteLine();
Console.WriteLine("Right join: ");
var rightJoin = departments.Join(
    employees,
    departments => departments.Id,
    employees => employees.DepartmentId,
    (department, employee) => new
    {
        DepartmentId = department.Id,
        DepartmentName = department.Name,
        EmployeeId = employee.Id
    });
foreach (var item in rightJoin)
{
    Console.WriteLine($"DepartmentId: {item.DepartmentId},Department Name: {item.DepartmentName}, EmployeeId: {(item.EmployeeId != null ? item.EmployeeId : "N/A")}");
}

// Max, min tuoi cua Employee trong list
Console.WriteLine();
var maxAge = employees.Max(employee => employee.Age);
Console.WriteLine($"Max tuoi cua Employee trong list: {maxAge}");

Console.WriteLine();
var minAge = employees.Min(employee => employee.Age);
Console.WriteLine($"Min tuoi cua Employee trong list: {minAge}");