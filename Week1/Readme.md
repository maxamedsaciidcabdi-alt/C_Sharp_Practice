# Week 1 -- Introduction to Visual C

## Objectives

By the end of this chapter, students should be able to:

- 1.1 Objects
- 1.2 The Program Development Process
- 1.8 Getting Started with Visual Studio
- 2.1 Getting Started with Forms and Controls
- 2.2 Creating the GUI for Your First Visual C# Application
- 2.3 Introduction to C# Code
- 2.4 Writing Code for the Hello World Application
- 2.5 Label Controls
- 2.6 Making Sense of IntelliSense
- 2.7 PictureBox Controls
- 2.8 Comments, Blank Lines, and Indentation
- 2.9 Writing the Code to Close an Application's Form
- 2.10 Dealing with Syntax Errors


------------------------------------------------------------------------

## 1. Introduction to Objects

-   **Object:** A program component that contains data and performs
    operations.
-   **Property:** A setting that controls an object's appearance or
    characteristics.
-   **Method:** A group of statements that performs a specific
    operation.
-   **Class:** A blueprint that describes a type of object.
-   **Control:** An object used in a GUI, such as a Button, Label, or
    TextBox.
-   **.NET Framework:** A collection of classes and tools used to
    develop Windows applications.

## 2. Visual Studio

Visual Studio is an Integrated Development Environment (IDE) used to
design, write, run, and debug applications.

**Main tools:**

-   **Designer Window:** Used to create the application's interface.
-   **Solution Explorer:** Displays projects and their files.
-   **Properties Window:** Used to view and change object properties.
-   **Toolbox:** Contains controls that can be added to a form.
-   **Toolbar:** Provides shortcuts to frequently used commands.

**Project:** Contains the files and resources for an application.

**Solution:** A container that can hold one or more projects.

## 3. Forms and Controls

-   **Form:** A window that provides the main interface of an
    application.
-   **GUI:** A visual interface that allows users to interact with a
    program.
-   **Bounding Box:** The dotted outline around a selected form or
    control.
-   **Sizing Handles:** Small points used to resize objects.
-   **Properties:** Settings used to change an object's appearance and
    behavior.

Controls can be added from the Toolbox, moved, resized, and configured
through the Properties Window.

**Identifiers** are names used to identify controls in code. The chapter
introduces **camelCase**, a naming convention that starts with a
lowercase letter and capitalizes subsequent words.

## 4. Introduction to C# Code

C# code is organized into three main structures:

-   **Namespace:** A container for classes.
-   **Class:** A container for methods and other class members.
-   **Method:** A group of statements that performs an operation.

A Windows Forms project commonly includes:

-   **Program.cs:** Contains the application's startup code.
-   **Form1.cs:** Contains code associated with the form.

## 5. Event-Driven Programming

Event-driven programming is a programming approach in which an
application responds to user actions.

-   **Event:** An action, such as clicking a button or pressing a key.
-   **Event Handler:** A method that runs when a specific event occurs.
-   **Message Box:** A dialog box used to display messages to users.

The Hello World application demonstrates how a button click can trigger
a message to appear.

## 6. Common Controls

-   **Label:** Displays text or program output on a form.
-   **PictureBox:** Displays images on a form.
-   **Button:** Allows users to trigger actions by clicking it.
-   **TextBox:** Allows users to enter or edit text.

The Label control has properties such as Text, Font, Name, and
TextAlign. The PictureBox control includes Image, SizeMode, and Visible
properties.

## 7. IntelliSense

IntelliSense is Visual Studio's code-completion feature. It suggests
available keywords, methods, variables, classes, and properties as
programmers type.

It helps improve coding speed and reduces typing mistakes.

## 8. Code Readability and Execution

-   **Sequential Execution:** Statements run in the order they appear.
-   **Comments:** Notes in the source code that explain how the program
    works.
-   **Blank Lines:** Separate sections of code to improve readability.
-   **Indentation:** Spacing that shows the structure of the code.

Correct statement order is important for achieving the intended program
result.

## 9. Closing an Application

The chapter introduces two ways to close an application:

-   `this.Close()` -- Closes the current form.
-   `Application.Exit()` -- Exits the entire application.

## 10. Syntax Errors

A **syntax error** occurs when code does not follow the grammatical
rules of C#.

Visual Studio identifies many syntax errors with a red underline.
Programmers should inspect and correct the highlighted code before
running the application.

A **logic error** occurs when a program runs but produces an incorrect
result.

------------------------------------------------------------------------

## Summary

In Week 1, we learned the fundamentals of Visual C# and Windows Forms
development. We explored objects, properties, methods, controls, and the
main features of Visual Studio.

We also learned how to create a form, design a GUI, organize C# code,
and use event handlers to respond to user actions. Finally, we studied
common controls, IntelliSense, code readability, and error
identification.

**Key takeaway:** Visual C# combines interface design and programming to
create applications that respond to user actions.
