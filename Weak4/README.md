 ### chapter loops

Control Flow Constructs (Loops)

Loops enable code blocks to execute repeatedly based on the evaluation of a Boolean condition. C# provides pretest and posttest loop structures tailored for specific algorithmic requirements.

### 1.1 The while Loop

Execution Type: Pretest Loop (evaluates condition before executing body).

Key Characteristic: If the initial condition evaluates to false, the body executes 0 times.

Control Requirement: The loop body must modify a variable affecting the Boolean expression to prevent execution deadlock (infinite loops).

int count = 0;

// Evaluates condition before each iteration
while (count < 5)
{
    MessageBox.Show($"Iteration: {count}");
    count++; // State change required
}


## 1.2 The for Loop

Execution Type: Pretest Loop.

Key Characteristic: Designed for counter-controlled iteration where loop bounds are known prior to execution.

Structure Components:

Initialization: Instantiates or assigns the counter variable (runs once).

Test: Boolean expression evaluated prior to every iteration.

Update: Execution step following each iteration to alter the counter state.

// Standard incremental loop
for (int i = 0; i < 5; i++)
{
    MessageBox.Show($"Index: {i}");
}

// Decremental / Reverse loop
for (int i = 10; i >= 0; i--)
{
    MessageBox.Show($"Countdown: {i}");
}

// Custom step increment
for (int i = 0; i <= 100; i += 10)
{
    MessageBox.Show($"Step: {i}");
}


## 1.3 The do-while Loop

Execution Type: Posttest Loop (evaluates condition after executing body).

Key Characteristic: Guaranteed to execute its statement block at least once, regardless of the initial Boolean state.

int number = 1;

do
{
    // Executes first before evaluating condition
    MessageBox.Show($"Current value: {number}");
} 
while (number < 0); // Evaluates to false; loop terminates after 1 iteration


## 2. Arithmetic Mutation Operators

C# provides concise unary operators to increment (++) or decrement (--) numerical variables by a unit of 1.

2.1 Operator Modes

Operator

Syntax

Evaluation Timing

Equivalent Code

Postfix Increment

variable++

Evaluates current value in expression, then increments.

variable = variable + 1;

Prefix Increment

++variable

Increments variable first, then evaluates expression.

variable = variable + 1;

Postfix Decrement

variable--

Evaluates current value in expression, then decrements.

variable = variable - 1;

Prefix Decrement

--variable

Decrements variable first, then evaluates expression.

variable = variable - 1;

2.2 Execution Comparison

int count = 5;

// Postfix Example
int postfixResult = count++; 
// Result: postfixResult = 5, count = 6

// Reset variable
count = 5;

// Prefix Example
int prefixResult = ++count; 
// Result: prefixResult = 6, count = 6


## 3. Pseudo-Random Number Generation

The .NET Framework provides the System.Random class to generate pseudo-random numeric values.

3.1 Core Methods

Next(): Returns a non-negative random integer bounded between 0 and int.MaxValue.

Next(int maxValue): Returns a non-negative random integer less than maxValue (range: 0 to maxValue - 1).

NextDouble(): Returns a floating-point number between 0.0 and 1.0.

3.2 Implementation Example

// Instantiate Random engine
Random rand = new Random();

// Generate arbitrary integer
int unboundInt = rand.Next();

// Generate bounded integer [0, 99]
int diceRoll = rand.Next(100);

// Generate double [0.0, 1.0)
double probability = rand.NextDouble();


4. Windows Forms Load Event Lifecycle

The Load event occurs when a Graphical User Interface (GUI) Form is instantiated and initialized in system memory, immediately prior to displaying on screen.

4.1 Purpose

Used to initialize runtime states, load user defaults, pre-populate control data, or establish initial configurations.

4.2 Handler Signature

private void Form1_Load(object sender, EventArgs e)
{
    // Pre-display initialization logic
    this.Text = "Application Initialized";
    MessageBox.Show("Preparing application interface...");
}


Technical Concept Comparison Matrix

Concept

Primary Use Case

Evaluation Point

Key Keyword / Class

while

Unknown iteration count; conditional repetition

Pre-execution

while

for

Known iteration count; index tracking

Pre-execution

for

do-while

Must execute at least once (e.g., input validation)

Post-execution

do ... while

Random

Game logic, simulations, test generation

