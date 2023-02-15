# ButterflySystemsAPI

The software solution comprises multiple projects that simulate a multilayer application.

ButterflySystemsAPI.BL module specifically implements the business logic (BL), with the ability to add further layers, such as a database or external APIs as required.

The solution is designed to facilitate the extension of its functionality by allowing new classes to be added without altering the APIs calls.

The solution provides four methods for basic arithmetic operations (Addition, Subtraction, Multiplication, and Division) and two methods that require the operation to be specified. 

The first method accepts the operation as a string input ("+", "-", " * ", "/"), which could potentially result in issues, as users may enter any value. Therefore, it is necessary to include additional validation checks.

The second method utilizes an Enum to specify the operations, ensuring that the values are always defined (Addition = 0, Subtraction = 1, Multiplication = 2, Division = 3).
