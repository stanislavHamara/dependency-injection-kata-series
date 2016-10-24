## Kata 3 - Advanced Containers

Auto-registration lets you automatically register components by scanning assemblies for implementations.

Property injection can be useful if your class has a good local default for that dependency but you still want to let callers provide different implementations of the class dependency. Watch out for shared classes that use property injection as one caller could can a dependency while another caller is using the class.

(Merge code)
Constructor functions
 Decorator pattern
Lifetime scope
 The problem with events and multiple instances
Value injection
Constructor side-effects
