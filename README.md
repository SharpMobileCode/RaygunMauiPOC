# RaygunMauiPOC

# Description
Unhandled exceptions do not appear to be logged by Raygun and reported in the Raygun dashobard.  If a view model command executes some code, and throws an unhandled exception, the exception is not reported on the Raygun dashboard. Either Raygun is not working or there is an incorrect setup.

# Steps to Repoduce
1. Insert a valid API key in `MauiProgram.cs`.
1. Check the `MainViewModel.UpdateCounter()` command. Verify that we are manually throwing an exception to simulate the possiblity that business logic is throwing an unhandled exception.
1. Run the program and tap on the button.

# Expected Result
The program should crash and the unhandled exception from `MainViewModel.UpdateCounter()` should be reported on the Raygun dashboard.

# Actual Result
The program does crash, but the unhandled exception thrown from `MainViewModel.UpdateCounter()` is not reported on the Raygun dashboard.
