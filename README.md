# Mediator Pattern Example in C#

This repository contains an example implementation of the Mediator pattern in C#. The Mediator pattern is a behavioral design pattern that provides a unified interface for communication between multiple objects. This pattern helps to reduce the complexity of communication between objects by introducing a mediator object that acts as a go-between for all other objects in the system.

The example in this repository is a simple chat room application where each user is an object that communicates with the mediator (chat room) instead of communicating directly with other users. The implementation includes an interface for the mediator, a concrete mediator class that implements the mediator interface, and classes for the objects that will communicate with the mediator.

In this example, you will find:

- IChatRoom interface that defines the registration and sending methods for the chat room.
- ChatRoom class that implements IChatRoom interface, it's responsible for registering users and sending messages.
- User class that represents a user in the chat room, it has the properties Name, ChatRoom, and methods Send and Receive

To run the example, you will need to have the latest version of C# installed on your machine. Simply clone the repository, open the solution in Visual Studio, and run the program. You can interact with the program by running the code in a console application.

This example is meant to be a simple demonstration of the Mediator pattern in C# and may not include all of the features and considerations you would want for a production-ready application. However, it should serve as a good starting point for understanding how the Mediator pattern works and how it can be implemented in C#.

Feel free to use this example as a starting point for your own projects or to experiment with different variations of the Mediator pattern. If you have any questions or suggestions, please open an issue in the repository.

