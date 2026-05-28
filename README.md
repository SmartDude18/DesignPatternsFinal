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

# Observer 

This is within both the WorldClock Class and the Alarm interface. The Alarm instances are the observers and the singleton WorldClock is the sender. This is done to let the alarms handle themselves, given they are gonna have different processes for doing so. This would also in theory allow for alarms that are not strictly text based, though they would not be as such for the application given.

# bridge 

This is within the Alarm and timezone systems. The Mix and match capabilties expand the options for alarms. The base alarm implementations allow for various displays (which is shown as a base display and ascii display, but could be expanded to other styles.), and the internal implementations allow for basing on different timezones. (yes I know this seems uneeded, but I have family in other continents, and it becomes such a problem to keep track of the time gap)