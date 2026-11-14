### 1. The while Loop

A while loop repeatedly executes a block of statements as long as a specified Boolean condition evaluates to true.


## 1. The while Loop
// Declare an integer variable and initialize it to 0
int count = 0;

// Repeat the loop while count is less than 5
while (count < 5)
{
    // Display a message box showing "Hello"
    MessageBox.Show("Hello");

    // Increase count by 1
    count = count + 1;
}


### 2. The ++ and -- Operators

This example demonstrates the behavior of the Prefix Increment operator (++count), where the variable is incremented first before its value is evaluated in the expression.

## 2. The ++ and -- Operators

 Declare count and initialize it to 5
int count = 5;

// Declare x and initialize it to 0
int x = 0;

// Display the value of x before increment
MessageBox.Show("The X before is " + x.ToString()); // Output: 0

// Display the value of count before increment
MessageBox.Show("The count before is " + count.ToString()); // Output: 5

// Prefix increment: increase count by 1 first, then assign it to x
x = ++count;

// Display the value of x after prefix increment
MessageBox.Show("The x after prefix is " + x.ToString()); // Output: 6

// Display the value of count after prefix increment
MessageBox.Show("The count after prefix is " + count.ToString()); // Output: 6


## 3. The for Loop

A for loop condenses loop initialization, condition checking, and variable updating into a single line, ideal for executing code a known number of times.

// 3. The for Loop

// Initialize count to 0
int count = 0;

// Repeat the loop while count is less than 5
for (count = 0; count < 5; count++)
{
    // Display Hello message
    MessageBox.Show("Hello");
}


4. The do-while Loop

A do-while loop evaluates its condition at the bottom of the loop structure. Consequently, the loop body always executes at least once.

## 4. The do-while Loop

// Initialize count to 1
int count = 1;

// Execute the code before checking the condition
do
{
    // Display the count
    MessageBox.Show(count.ToString());

    // Increase count by 1
    count++;
}
while (count <= 5);


## 5. Infinite Loop Bug

Placing a semicolon (;) immediately after the condition of a while statement creates an empty loop body. Since the loop body that increments the counter is ignored, the condition remains permanently true, causing an infinite loop.

## 5. Infinite Loop Bug
int count = 0;

// Warning: Semicolon here creates an infinite loop
while (count < 5);
{
    MessageBox.Show("Hello");
}
