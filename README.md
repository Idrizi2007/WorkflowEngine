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
