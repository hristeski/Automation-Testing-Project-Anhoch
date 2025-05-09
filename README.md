## Project Description
The "Mobile Shop Automation Testing" project focuses on automating the testing of key functionalities of the mobile phone section on the anhoch.mk e-commerce website.
Using Selenium WebDriver with C# and NUnit, the goal is to simulate user actions such as searching for phones, filtering by brand, and adding products to the shopping cart.

The project follows Agile principles, with tasks organized into short sprints based on user stories. This approach ensures continuous improvement, quick feedback, and early detection of issues during the development cycle.

## Project Objective
The objective of this project is to develop an automated test suite for verifying the key user interactions on the mobile phone section of the anhoch.mk website, ensuring that critical functionalities like search, filtering, and adding products to the cart work as expected.

## Scope
What will be tested:
Search Functionality:

Verify that the search bar correctly filters mobile phones based on the query (e.g., phone model, brand).
Filtering by Brand:

Ensure that when a brand is selected from the filter options, only phones from that specific brand are displayed.
Adding to Cart:

Verify that selecting a phone and clicking "Add to cart" results in the product being added to the shopping cart.
Product Details:

Ensure that product details (e.g., price, specifications, availability) are correctly displayed on the product page.
Mobile Responsiveness:

Check that the mobile phone section works correctly on various screen sizes (desktop, tablet, and mobile).

## What will not be tested:
Payment Gateway:

The payment functionality is not included in the scope of this project.
User Registration & Login:

Testing of user authentication (registration, login) is out of scope.
External Services:

External integrations (e.g., third-party payment processors, delivery services) are not part of the test plan.
Non-Mobile Sections:

Testing will focus solely on the mobile phones section, not other product categories or the checkout process.
## Test Plan
Objective:
The objective of this test plan is to ensure that all critical functionalities related to mobile phone search, filtering, and cart addition work as expected on the anhoch.mk website.

Scope:
Testing will be focused on the mobile phone section of the website.
The following functionalities will be tested: search, brand filtering, adding products to the cart, and mobile responsiveness.
Approach:
Automation:
Selenium WebDriver with C# will be used for automating the test cases.
Test Environment:
Tests will be executed in Google Chrome using the ChromeDriver.
Test Data:
A set of predefined phone models and brands will be used for testing search and filtering.
Pass/Fail Criteria:
Tests will be considered successful if the expected outcome matches the actual behavior of the website.
## Test Cases
Test Case 1: Verify Search Functionality
Precondition:
The mobile phone section is displayed.

## Test Steps:

Enter a search term (e.g., "iPhone").
Click the search button.
Expected Result:
The search results display only products related to "iPhone" (e.g., different iPhone models).

Pass/Fail Criteria:
Test is passed if only relevant phones appear in the search results.

Test Case 2: Verify Filter by Brand
Precondition:
The mobile phone section is displayed.

Test Steps:

Select a brand (e.g., "Samsung") from the filter options.
Wait for the page to load filtered results.
Expected Result:
Only phones from the selected brand ("Samsung") are displayed.

Pass/Fail Criteria:
Test is passed if only Samsung phones appear in the results.

Test Case 3: Verify Add to Cart Functionality
Precondition:
The mobile phone section is displayed with available products.

Test Steps:

Select a mobile phone.
Click the "Add to Cart" button.
Expected Result:
The selected phone is added to the cart.

Pass/Fail Criteria:
Test is passed if the product appears in the shopping cart.

Test Case 4: Verify Mobile Responsiveness
Precondition:
The mobile phone section is displayed.

Test Steps:

Open the website on a mobile device or resize the browser window to mobile view.
Check that the page elements adjust appropriately.
Expected Result:
The page should display correctly and all functionalities should be accessible on mobile devices.

Pass/Fail Criteria:
Test is passed if the mobile phone section is fully responsive on mobile view.

Test Execution & Results
Execution:
The automated test suite will be executed using NUnit, in combination with Selenium WebDriver, in the following environment:

Browser: Google Chrome
Test Framework: NUnit
Automation Tool: Selenium WebDriver
Environment: Local environment or Azure DevOps pipeline for continuous integration.
Tests will be run after each significant change in the code to ensure that all critical functionalities work as expected.

Results:
Test results will be collected and presented through NUnit’s test report generation. The following actions will be taken based on the test results:

Pass: The feature is working as expected.
Fail: Further investigation will be required to identify the root cause of the failure. The issue will be logged as a bug in the Azure DevOps work item system.
Automation Strategy
Framework:
The automated testing will be implemented using Selenium WebDriver with C# and NUnit. This combination allows for efficient and scalable test automation with the following advantages:

Cross-browser testing: Ensures compatibility across different browsers (primarily Chrome for execution).
Data-driven testing: Enables testing with different sets of data using NUnit’s parameterized tests.
Continuous Integration (CI): Integration with Azure DevOps pipelines ensures that tests run automatically with each code commit.
Test Design:
Test Scripts: Test cases will be written as reusable test scripts.
Modular Approach: Page Object Model (POM) design pattern will be followed for better maintainability and reusability of code.
Logging & Reporting: Logs will be maintained for debugging, and test results will be generated after each execution. Detailed reports will be available in the Azure DevOps dashboard.
Tools & Technologies
Selenium WebDriver:
Selenium WebDriver is used for automating browser interactions. It allows simulating user actions like clicking, typing, and navigating through the website.

C#:
The test scripts will be written in C# to integrate with Selenium WebDriver, providing strong support for automation tasks and ease of integration into the DevOps pipeline.

NUnit:
NUnit is a unit testing framework for .NET applications, used to structure the test cases and provide reporting for the automated tests.

Azure DevOps:
Azure DevOps will be used for project management, tracking progress, and running automated tests through CI/CD pipelines.