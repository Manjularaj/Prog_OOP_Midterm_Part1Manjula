### Part 1
[Page1](Training/Page1.md)

#### Q1: What does it mean to create an "instance" of an object?

 an instance is a concrete realization of a class. When you define a class, you're essentially creating a blueprint. An instance, then, is an object built from that blueprint. It has all the characteristics defined in the class, but with specific values.
 
 Example:t helps to think of it like this: A blueprint for a house design is like a class description. All the houses built from that blueprint are objects of that class. A given house is an instance.

#### Q2: What does it mean when we say "Create a local variable"?
This means that you can only access these variables in that specific function where they are declared or passed in as an argument. Local variables are created when: arguments are passed in to a procedure or event. using the initialize local name to block.

#### Q3: The static keyword is a modifier, what does this modifier do to the members (fields, constructor, properties, and methods) of a class?

static modifier to declare a static member, which belongs to the type itself rather than to a specific object. The static modifier can be used to declare static classes. In classes, interfaces, and structs, you may add the static modifier to fields, methods, properties, operators, events, and constructors. 

A static constructor is used to initialize any static data, or to perform a particular action that needs to be performed only once. It is called automatically before the first instance is created or any static members are referenced. A static constructor will be called at most once.

#### Q4: Do you need an instance of an object to call a static method?
No, you do not need an instance of an object to call a static method. Static methods are associated with the class itself rather than with any specific instance of the class. Therefore, you can call a static method directly on the class without needing to create an instance of the class.

#### Q5: Can you create an instance of a static class?
In languages such as C# or Java, you cannot create an instance of a static class because static classes are designed to be stateless and not instantiated. Static classes typically contain static members (methods, properties, fields) and are often used as containers for utility functions or constants.


#### Q6: Can you manually call a static constructor? When is it called?

In most programming languages, you cannot manually call a static constructor. The static constructor, also known as a static initializer or static constructor block, is automatically invoked by the runtime environment before the class is used or any static members are accessed.

The static constructor is called only once, typically before any static members are accessed or any instances of the class are created. Its purpose is to initialize static fields or perform other tasks necessary for the class to function properly.

The exact timing of when a static constructor is called can vary slightly depending on the language and runtime environment, but it generally occurs before any static member of the class is accessed or any instance of the class is created.


#### Q7: Did you have to create an instance of MyDatabase to access Data? Why?


No, you did not have to create an instance of MyDatabase to access Data. This is because Data is a static member of the class MyDatabase. Static members belong to the class itself rather than to any specific instance of the class. Therefore, you can access Data directly through the class without needing to instantiate MyDatabase.

#### Q8: When you ran your code the line "This list is loading" appeared. Where did that come from and why did it appear when it did?

### Part 2
[Page2](Training/Page2.md)

#### Q9: What is encapsulation?
Encapsulation helps improve code maintainability, reusability, and security by enforcing a clear separation between the implementation details and the external interface of objects. It also facilitates information hiding, which is crucial for building robust and scalable software systems.


#### Q10: What are the other two, or 3 depending on the source, pillars of object-oriented programming?
The three primary pillars of object-oriented programming (OOP) are:

Encapsulation: As described earlier, encapsulation involves bundling data and methods into a single unit (class) and controlling access to the internal state of objects.

Inheritance: Inheritance is a mechanism by which a class can inherit properties and behavior from another class. It allows the creation of a new class (derived class or subclass) based on an existing class (base class or superclass), thus promoting code reuse and establishing a hierarchical relationship between classes.

Polymorphism: Polymorphism refers to the ability of different objects to respond to the same message or method call in different ways. It allows objects of different types to be treated as instances of a common superclass, enabling more flexible and extensible code. Polymorphism is often achieved through method overriding (in the context of inheritance) and method overloading.

These three pillars—encapsulation, inheritance, and polymorphism—form the foundation of object-oriented programming paradigms and are essential concepts for designing modular, maintainable, and scalable software systems. Some sources might also include additional principles or concepts, but these three are widely recognized as the core pillars of OOP.



#### Q11: After our refactor of Product, it only has fields that are _blank_ among all the Objects in the database.




#### Q12: We made our DisplayProductInfo() method `virtual`. What does virtual do?

DisplayProductInfo() method virtual, you're indicating that subclasses of the Product class can provide their own implementations of this method if needed. This enables you to customize the behavior of DisplayProductInfo() in subclasses while still having a common interface across all Product objects.


#### Q13: Why do you think we made that method virtual ( only wrong answer is a blank answer. Give it a shot. )?




#### Q14: What does dervied mean in the context of inheritance?

In the context of inheritance in object-oriented programming, "derived" typically refers to a class that inherits properties and behaviors from another class, known as the base class or superclass.

When a class is derived from another class, it means that the derived class inherits all the members (fields, methods, properties) of the base class and can also add its own members or override existing ones. The derived class is often said to "derive from" or "be derived from" the base class.

#### Q15: Is one class is derived, the class that it derives from is considered the "b___" class. What is it?
The class being derived from is the "base class" or "superclass".
The class deriving from the base class is the "derived class" or "subclass".

#### Q16: When inheriting from a parent class, which class member ( field, constructor, properties, or method ) do you HAVE to create in your child class?

while you're not obligated to create any specific class members in your child class, you may choose to define constructors, fields, properties, or methods as needed based on the requirements of your application and the design of your class hierarchy.

#### Q17: Our constructor has the syntax `public Groceries(string name, double price, string expiryDate) : base(name, price)`. What is this for?
1.0public Groceries(string name, double price, string expiryDate): This is the constructor declaration for the Groceries class. It takes three parameters: name, price, and expiryDate.

2.0base(name, price): This part is the constructor initializer. It is using the base keyword to explicitly call a constructor of the base class. In this case, it is passing name and price as arguments to the base class constructor.

 base(name, price) syntax in the constructor of the Groceries class ensures that the appropriate constructor of the base class is called with the specified arguments during the construction of Groceries objects.


#### Q18: For our DisplayProductInfo() we now used the word `override` instead of `virtual`. Why is that? And what happens if we take the word `virtual` away from the method inside of Product?

When you use the override keyword for a method in a derived class, you're indicating that you're providing a new implementation for a method that was declared virtual (or abstract) in the base class.   Remoing virtual from the method in the Product class, it means that the method cannot be overridden by derived classes. If you then try to use override in a derived class, you'll get a compilation error because the base method is not marked as virtual or abstract.


#### Q19: Because we inherited from Parent, what class members did we get access to in Groceries?

Fields, Properties,  Constructors
#### Q20: What access modifier is needed for everything in your project to have access to class members ( there are 2 that would work )?

public and internal.
#### Q21: When each instanced object called `DisplayProductInfo()` the output was different based on the object. Why is that?
Due to overriding method


## Part 3
[Page3](Training/Page3.md)

#### Q22: What does the abstract keyword do exactly? What does it prevent?

Abstract Classes: When applied to a class, the abstract keyword indicates that the class itself is abstract. An abstract class cannot be instantiated directly; it serves as a blueprint for other classes to inherit from. Abstract classes may contain abstract methods (methods without implementation) as well as concrete methods (methods with implementation). Abstract classes can also contain fields, properties, constructors, and other members.

Abstract Methods: When applied to a method within an abstract class, the abstract keyword indicates that the method has no implementation in the abstract class. Abstract methods define a method signature (return type, name, parameters) but no method body. Subclasses (concrete classes that inherit from the abstract class) must provide an implementation for all abstract methods defined in the superclass. Failure to do so results in a compilation error.

Prevents Instantiation: An abstract class cannot be instantiated directly. Attempting to create an instance of an abstract class will result in a compilation error.

Enforces Method Implementation: Abstract methods defined within an abstract class must be implemented by concrete subclasses. If a subclass fails to provide an implementation for any abstract method inherited from its superclass, it must be marked as abstract itself or result in a compilation error.


#### Q23: The abstract method no longer has a body, why is that? We also removed the word virtual, how do virtual and abstract relate?
An abstract method serves as a placeholder in an abstract class. It declares a method signature (return type, name, parameters) without providing any implementation details.  virtual and abstract enable polymorphism and method overriding, they have different implications and are used in different contexts depending on the desired behavior in the class hierarchy.

#### Q24: We turned our constructor's accessible type to `protected`. What objects have access to the constructor now that it's `protected`. And since we turned our class `abstract` why doesn't it matter that we can't create a new instance of `Product` in main?

ubclasses: Subclasses (derived classes) of the class containing the protected constructor have access to it. This allows subclasses to invoke the protected constructor when they are instantiated, allowing for proper initialization of derived class objects.  In C#, a protected constructor allows access to classes in the same assembly.

When you mark a class as abstract, it means that the class is intended to be a blueprint for other classes to inherit from, but it cannot be instantiated directly. 
Product as abstract ensures that it cannot be instantiated directly, which aligns with its intended usage as a base class for other classes to inherit from. Subclasses of Product can be instantiated, and they have access to the protected constructor if it's needed for proper initialization.


#### Q25: The other classes didn't need to be changed. Specifically, the DisplayProductInfo() didn't need any changing when we swapped our method from virtual to abstract. Why?
Chinging DisplayProductInfo() from virtual to abstract in the Product class, the subclasses didn't need to be changed because the requirement for providing an implementation is inherent to the abstract method itself. Each subclass must still provide its own implementation, but it's automatically recognized as overriding the abstract method without the need for additional keywords.


## Part 4
[Page4](Training/Page4.md)

#### Q26: We set our set to private. What does private mean? And why might we want to set our set to private for our connection string (take a guess)?
private typically means restricting its access to within a certain scope or context. In object-oriented programming, for example, a private member of a class can only be accessed and modified by methods within that same class, not from outside.

 Reasons why you might want to set your connection string to private:

Security: Keeping sensitive information like connection strings private helps prevent unauthorized access to databases or other resources. If the connection string is publicly accessible, it could be exploited by malicious actors.

Preventing tampering: By restricting access to the connection string, you reduce the risk of it being inadvertently or maliciously modified, which could lead to unexpected behavior or security vulnerabilities.

Encapsulation: Encapsulating the connection string within a class or module helps in organizing code and adhering to the principles of encapsulation in object-oriented programming. This can lead to cleaner, more maintainable code.

Compliance: In some industries or organizations, there may be regulatory or compliance requirements that mandate certain data security practices, including safeguarding connection strings.

## Part 5
[Page5](Training/Page5.md)

#### Q27: What method is used to get the TYPE of an instance of an object?
You can use the GetType() and this Type object to obtain information about the type, such as its name, namespace, methods, properties, and so on.

#### Q28: What method can we use to check if one type is another?
can use the is operator to check if one type is another. The is operator returns true if an object is of the specified type or a subtype, and false otherwise.