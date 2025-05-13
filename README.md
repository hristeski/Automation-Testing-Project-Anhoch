# 🧪 Mobile Shop Automation Testing

This project focuses on automating the testing of the mobile phone section on the [anhoch.mk](https://www.anhoch.mk) e-commerce website using Selenium WebDriver with C# and NUnit.

---

## 🎯 Project Objective

To build a robust automated test suite that verifies the core user interactions on the mobile phone section, including:

- Searching for phones
- Filtering by brand
- Viewing product details
- Adding products to the cart
- Ensuring mobile responsiveness

---

## 🧱 Project Scope

### ✅ What Will Be Tested:
- **Search Functionality**: Validates correct filtering based on search input (e.g. “iPhone”).
- **Brand Filtering**: Displays only products from selected brand.
- **Add to Cart**: Adds a phone to the shopping cart correctly.
- **Product Details**: Displays correct price, specs, and availability.
- **Mobile Responsiveness**: Works correctly on mobile, tablet, and desktop views.

### ❌ What Will Not Be Tested:
- Payment and checkout processes
- User registration & login
- External services (e.g. payment gateways, delivery)
- Non-mobile product categories

---

## 🧪 Test Plan

### 🎯 Objective
Ensure that all critical functionalities in the mobile phones section work as expected.

### 🧪 Testing Approach
- **Tool:** Selenium WebDriver
- **Language:** C#
- **Framework:** NUnit
- **Execution:** Google Chrome using ChromeDriver
- **Test Data:** Predefined models and brands
- **CI:** Azure DevOps integration

---

## ✅ Test Cases

### 🔍 Test Case 1: Search Functionality
- **Steps:** Enter "iPhone" > Click search
- **Expected Result:** Only iPhone models are displayed
- **Status:** ✅ Passed if relevant phones appear

### 🏷 Test Case 2: Filter by Brand
- **Steps:** Select "Samsung" from filter
- **Expected Result:** Only Samsung phones are shown
- **Status:** ✅ Passed if brand filter works

### 🛒 Test Case 3: Add to Cart
- **Steps:** Click "Add to Cart" on a phone
- **Expected Result:** Product appears in the cart
- **Status:** ✅ Passed if cart is updated

### 📱 Test Case 4: Mobile Responsiveness
- **Steps:** Open site in mobile view / device
- **Expected Result:** UI adjusts, all actions accessible
- **Status:** ✅ Passed if responsive

---

## 🔁 Test Execution & Results

- **Execution Tool:** NUnit Console Runner / Visual Studio
- **CI/CD:** Azure DevOps Pipelines
- **Browser:** Google Chrome
- **Trigger:** Executed on every push/change

### 📝 Results:
- ✅ **Pass:** Feature works as expected
- ❌ **Fail:** Bug logged in Azure DevOps with screenshots/logs

---

## ⚙️ Automation Strategy

- **Framework:** Selenium WebDriver + NUnit
- **Design Pattern:** Page Object Model (POM)
- **Data-driven Tests:** NUnit parameterized tests
- **CI:** Integrated with Azure DevOps
- **Reporting:** NUnit test reports and logs
- **Logging:** Basic logs for debugging

---

## 🛠 Tools & Technologies

| Tool          | Purpose                         |
|---------------|---------------------------------|
| Selenium      | UI automation                   |
| C#            | Programming language            |
| NUnit         | Test framework                  |
| Azure DevOps  | CI/CD pipeline and issue tracking |
| ChromeDriver  | Browser automation              |

---

## 📁 Project Structure (Sample)

MobileShopTests/
├── Pages/
│ ├── HomePage.cs
│ ├── SearchPage.cs
│ └── CartPage.cs
├── Tests/
│ ├── SearchTests.cs
│ ├── FilterTests.cs
│ └── CartTests.cs
├── Utilities/
│ ├── TestBase.cs
│ └── Config.cs
├── README.md
└── .gitignore


---

## 👨‍💻 How to Run

# Clone the repo
git clone https://github.com/hristeski/Automation-Testing-Project-Anhoch.git

# Navigate to the project directory
cd Automation-Testing-Project-Anhoch

# Run tests via Visual Studio or terminal:
dotnet test

✅ Prerequisites
.NET SDK 9.0 or higher

Visual Studio 2022 or newer with .NET and Test Tools installed
Chrome WebDriver that matches your local Chrome version

⚙️ Configuration (Optional)
WebDriver Path: Ensure ChromeDriver is added to your system's PATH, or install it via NuGet (Selenium.WebDriver.ChromeDriver).
Base URL for tests: Make sure your test environment URL is correctly set within the test setup or a config file (appsettings.json, TestContext, etc.).

Azure DevOps CI/CD: If using pipelines, include the following steps:
dotnet restore
dotnet build
dotnet test

🧪 Run Tests
Run all tests in the project using:
dotnet test --logger "console;verbosity=detailed"
