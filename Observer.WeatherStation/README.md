# Observer Pattern

The Observer Pattern is a behavioral design pattern that defines a one-to-many dependency between objects, so that when one object changes state, all its dependents are notified and updated automatically.

## Introduction

This project demonstrates the implementation of the Observer Pattern in [programming language]. The Observer Pattern consists of three main components:

1. **Subject**: The object being observed, which manages a list of observers and notifies them when its state changes.
2. **Observer**: The objects that want to be notified when the subject's state changes.
3. **ConcreteSubject** and **ConcreteObserver**: The specific implementations of the Subject and Observer interfaces.

## Usage

To use the Observer Pattern in your project, follow these steps:

1. Create a `IObservable` interface that defines methods for Add, Remove, and Notify observers.
2. Implement the `WeatherStationObservable` class that manages the list of observers and notifies them when the IObservable's state changes.
3. Create an `IObserver` interface that defines the update method.
4. Implement the `TVRoom` class that receives updates from the subject.

