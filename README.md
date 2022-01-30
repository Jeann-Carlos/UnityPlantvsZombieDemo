# UnityPlantVsZombies Demo WIP
A basic unity plant vs zombies clone, it and will only be used as a testing ground for technical utilities and not as an actual game. Currently the focus point of this game is to effectively implement a plant vs zombies clone using the Unity D.O.T.S formulation which is Unity's new high-performance, multithreaded Data-Oriented Technology.

## Technical Capabilities

### D.O.T.S 
DOTS is a significant shift in Unity's architecture. DOTS is a new set of technologies for Unity whos purpose is to a new way of working with the engine and a new way of thinking about code and data using data-oriented design (DoD), as opposed to Unity's object-oriented approach.

### Object Pool
During gameplay, the methods Instantiate() and Destroy() are both beneficial and required in most cases, only a little amount of CPU time is required (for this set of actions).
However, many seemingly little things can build up over time. This becomes a problem in games when a large number of objects are created and destroyed at the same time (like plant vs zombies).In resource-constrained settings, such as mobile devices and web builds, this behavior is crucial since the effect of the impact may be greater because of slower cpu, ram and sometimes hard drive speed. Object pooling is where you pre-instantiate all the objects you’ll need at any specific moment before gameplay — for instance, during a loading screen.
![Screenshot 2022-01-28 163754](https://user-images.githubusercontent.com/56929989/151655006-6bf82926-154f-4674-b874-19e312aa26c8.png)

As an example, we have 688 implementations of "monster" type objects. If we modify the occurrence time of spawns to be relatively small, we will get stuttering caused by inappropriate use of CPU calls to initialized objects (many objects will have to instantiate rapidly and the CPU wont te able to keep up. In contrast, when we use the object pooling the effect of the impact gets minimized since the CPU  not only does it have to create instances of fewer objects, but it (also) has to destroy less. Although this method comes at the cost of using more GPU power to render objects (if necessary) and more ram (occasionally) to keep certain objects alive.
