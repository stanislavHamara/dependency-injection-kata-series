# Kata 2 - Using DI containers

Although dependency injection containers are optional, they help to enforce the practice of dependency injection in the codebase. Whereas DI is a technique, DI containers are a technology to make things easier.

Sometimes it is scary to choose a DI container because there is a risk that you've made the wrong decision and you will be stuck with your bad choose for the lifetime of the application. By limiting the use of the container to the application's composition root, we can isolate the use of the DI library to the bootstrap code.

## Task 1 - Add a DI library

Install Autofac into the console application.

## Task 2 - Register all your objects

Replace newing up at top level with container.Resolve

Register top level object and dependencies

Extract module

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
