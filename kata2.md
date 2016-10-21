# Kata 2 - Using DI containers

Although dependency injection containers are optional, they help to enforce the practice of dependency injection in the codebase. Whereas DI is a technique, DI containers are a technology to make things easier.

Sometimes it is scary to choose a DI container because there is a risk that you've made the wrong decision and you will be stuck with your bad choose for the lifetime of the application. By limiting the use of the container to the application's composition root, we can isolate the use of the DI library to the bootstrap code.

## Task 1 - Add a DI library

Install Autofac using NuGet and add a reference into the console application.

Create an empty `ContainerBuilder` and call `builder.Build()` to build your first `IContainer`.

## Task 2 - Register all your objects

After the first kata your entry point should contain all the object construction in your application.

We will now replace all object construction using `new` with a single call to `container.Resolve`.

You can replace classes one-by-one with a process like this:

1. Find a class with no dependencies or dependencies already registered
2. Register that class with Autofac
3. Replace its usages with `container.Resolve`
4. REPEAT until you resolve the top level class

## Task 3 - Extract a module

Modules are a way to group related DI registrations together.

Test systems can have their own modules too, often you will want to override or swap out a module with a test module that simplifies test running.

Here is an example Autofac module:

```
public class CarTransportModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.Register(c => new Car(c.Resolve<IDriver>())).As<IVehicle>();
    builder.Register(c => new SaneDriver()).As<IDriver>();
  }
}
```

Extract a single module for the entire app.
