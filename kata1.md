# Kata 1 - Introduction to Dependency Injection

The purpose of dependency injection is to write maintainable code. It forces the consumers of a class to supply dependencies to that class before using it.  If we use interfaces, this promotes loose coupling between the dependencies and the class, and we should always be able to change the behaviour of dependencies without changing the class.

DI does not requires a DI container. Containers are optional and can make it easier to compose components when we wire up an application. This Kata focusses on dependency injection without a container and we will cover containers in the next kata.

## Poor Man's Dependency Injection

Identify the entrypoint of the application


Extract “new” out of constructors


Deduplication of static dependencies (be careful)
