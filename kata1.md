# Kata 1 - Introduction to Dependency Injection

The purpose of dependency injection is to increase the maintainability of our code. It forces the consumers of a class to supply dependencies to that class before using it.  If we use interfaces, this promotes loose coupling between the dependencies and the class, and we should always be able to change the behaviour of dependencies without changing the class.

Dependency injection does not requires a DI container. DI containers are optional libraries that can make it easier to compose components when we wire up an application. This Kata focusses on dependency injection without a container and we will cover containers in the next kata.

## Poor Man's Dependency Injection

When you do dependency injection without a container, it's called Poor Man's Dependency Injection.

Here's the simplest example of dependency injection (specifically constructor injection):

```
private static void Main()
{
  IMessageWriter writer = new ConsoleMessageWriter(); // implements interface IMessageWriter
  var salutation = new Salutation(writer); // uses interface as dependency
  salutation.Execute();
}
```

## Tasks

### Task 1: Identify the entrypoint of the application

We have provided you with a console application that draws patterns.

Find the entry point of this application.

### Task 2: Extract all methods to the top level of the application

Use R# to extract all dependencies to the top level of the application. Extract “new” out of constructors.

Use constructor injection.

Perform deduplication of static dependencies (be careful)
