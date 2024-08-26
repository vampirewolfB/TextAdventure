# C# Coding Conventions

The programming convensions used for this project.

## Naming conventions


### Pascal case

Use pascal case for: `class` or `struct`.

```csharp
public class FooBar
{
}
```

```csharp
public struct Foo
{
}
```

When naming a `interface` use pascal case with a I in front. To clearly indicate it is a interace.

```csharp
public interface IFooBar
{
}
```

When naming `public` members of types, such as fields, properties, events, mtehods and local function use pascal casing.
```csharp
public class ExampleEvents
{
    // A public field, these should be used sparingly
    public bool IsValid;

    // An init-only property
    public IWorkerQueue WorkerQueue { get; init; }

    // An event
    public event Action EventProcessing;

    // Method
    public void StartEventProcessing()
    {
        // Local function
        static int CountQueueItems() => WorkerQueue.Count;
        // ...
    }
}
```

### Camel case

Use camel casing when naming `private` or `internal` fields and prefix them with `_`.

```csharp
public class FooBar 
{
    private string _fooBar;
}
```

## Layout conventions

- Use the default Code Editor settings for C# build into visual studio 2022.
- Write only one statement per line
- Write only one declaration per line
- If lines are not indented automatically, indent them one tab stop.

## Commenting conventions

- Pace the commend on a separate line above it.
- Begin the comment text with an uppercase latter.
- Insert one space between the comment delimiter (//) and the comment text.
