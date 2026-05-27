# DesignPatternsFinal
a place to hold the final project for the Design Patterns class

The final project is an alarm app where you can set alarms. They can be repeating or single use, as well as can be set for various time zones and country configurations.

# Design and Structure
The current setup is in a MVC pattern, with an included tests folder. This will be updated as further instruction is given.

# Project design
This project will use three design patterns.

The Singleton Pattern
The Observer Pattern
The Bridge Pattern

# singleton

This is the WorldClock Class, and is a singleton because it is the source of data, and eventually the sender for the observer pattern. 
It works by using the DateTime package to get the current time and date (shocking, I know). This will use Task.delay to stay in time for the minutes, and be able to ping whenever the new minute hits.