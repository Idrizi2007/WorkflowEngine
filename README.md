<<<<<<< HEAD
Workflow Engine (C#)
Overview

This project is a simple, extensible workflow engine built in C#.
It executes a sequence of activities in order, stops on failure, and reports progress through logging and notifications.

The focus of the project is architecture and control flow, not business logic or UI.

This type of engine is commonly used in:

background job runners

CI/CD pipelines

automation systems

backend services that execute ordered tasks

Key Concepts
Workflow

A workflow is a collection of activities executed in sequence.

Activities run one by one

If an activity fails, execution stops immediately

The workflow itself contains no execution logic

Activity

An activity represents one unit of work.

Each activity:

implements a common interface

performs its own logic

returns an ActivityResult indicating success or failure

Activities are intentionally simple in this project to keep the focus on orchestration.

ActivityResult

ActivityResult represents the outcome of an activity.

It contains:

whether the activity succeeded or failed

a descriptive message

Results are created using factory methods:

Success(message)

Failure(message)

This guarantees that results are always valid and self-contained.

WorkflowRunner

The runner is responsible for orchestration.

It:

executes activities in order

reacts to success or failure

logs progress

sends notifications on failure

The runner does not know what an activity does — only how to run it.

Logging & Notifications

Logging and notifications are implemented using interfaces:

ILogger

INotificationService

This allows behavior to be extended or replaced without modifying the core engine.

The current implementation uses console-based services as placeholders.

Design Principles

This project intentionally follows these principles:

Single Responsibility
Each class has one clear purpose.

Interface-based design
Core logic depends on abstractions, not implementations.

Composition over inheritance
Dependencies are injected instead of hard-coded.

Fail fast, stop cleanly
Workflow execution stops immediately on failure.

Extensibility without modification
New activities, loggers, or notification services can be added without rewriting existing code.

Example Execution Flow

WorkflowRunner starts execution

Activity 1 runs and succeeds

Activity 2 runs and succeeds

Activity 3 fails

Notification is sent

Workflow stops

No further activities are executed after failure.

Adding a New Activity

To add a new activity:

Create a class that implements the activity interface

Implement the execution method

Return a success or failure result

Add the activity to a workflow

No changes to the runner or workflow engine are required.

Why No GUI?

This project is not a user-facing application.

The goal is to demonstrate:

backend-style control flow

orchestration logic

clean architecture

In real systems, engines like this often run as background services without any UI.

Future Improvements

Possible extensions (not implemented here):

retry policies for failed activities

execution timing and metrics

conditional activity execution

persistence of workflow results

integration with real logging or notification systems

Purpose of This Project

This project was built as a learning and portfolio piece to demonstrate:

understanding of interfaces and abstraction

clean separation of concerns

safe and extensible design

reasoning about execution flow and failure handling

It prioritizes clarity and correctness over feature count.

Final Notes

The code is intentionally simple, readable, and focused.

This is not a framework — it’s a foundation that demonstrates how such systems are designed.
=======
# WorkflowEngine
Workflow Engine (C#)

A minimal workflow engine that executes a sequence of activities in order. The goal is to demonstrate interfaces, polymorphism, and extensible design (adding new behavior by creating new classes rather than modifying existing ones).

How it works

A Workflow is a container that holds a list of activities.

An Activity is any class that implements IActivity and provides an Execute() method.

The WorkflowRunner takes a Workflow and runs it by calling Execute() on each activity, in sequence.

Project Structure

IActivity

Interface representing a workflow step.

Requires: Execute()

Workflow

Stores an ordered collection of IActivity.

Provides:

Add(IActivity activity) to add steps

Expose() (or similar) to return the stored activities to the runner

WorkflowRunner

Runs a workflow passed into it.

Does not know or care what each activity actually does—only that it has Execute().

Example Use (Concept)

Create a Workflow

Add activities (e.g., UploadVideo, SendEmail, etc.)

Pass the workflow to the runner

Runner executes each activity in order

Extending the Workflow

To add a new step:

Create a new class that implements IActivity

Implement the Execute() method (for this exercise, typically Console.WriteLine)

Add the new activity to the workflow using workflow.Add(new YourActivity())

No changes are needed in:

WorkflowRunner

existing activities

Why this design

Loose coupling: runner depends on IActivity, not concrete classes

Extensible: new activities can be added without changing existing code

Single Responsibility:

Workflow stores steps

Runner executes steps

Activities define step behavior

Notes

This is an educational implementation focused on structure and OOP design. Real-world workflows might include error handling, logging, async steps, retries, persistence, and more.
>>>>>>> 43b3554848b67888ff22ebc961ea762d6d93e132
