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