# UnityPlantVsZombies Demo 
A basic unity plant vs zombies clone, it and will only be used as a testing ground for technical utilities and not as an actual game. Currently the focus point of this game is to effectively implement a plant vs zombies clone using the Unity D.O.T.S formulation which is Unity's new high-performance, multithreaded Data-Oriented Technology.

## Technical Capabilities

### D.O.T.S
DOTS is a significant shift in Unity's architecture. DOTS is a new set of technologies for Unity whos purpose is to a new way of working with the engine and a new way of thinking about code and data using data-oriented design (DoD), as opposed to Unity's object-oriented approach.

### Object Pool
During gameplay, the methods Instantiate() and Destroy() are both beneficial and required in most cases, only a little amount of CPU time is required (for this set of actions).
However, many seemingly little things can build up over time. This becomes a problem in games when a large number of objects are created and destroyed at the same time (like plant vs zombies). Garbage Collection is also used by Unity to deallocate memory that is no longer in use. This task is commonly triggered by repeated calls to Destroy(), and it has a habit of slowing down CPUs and causing gameplay pauses. In resource-constrained settings, such as mobile devices and web builds, this behavior is crucial. Object pooling is where you pre-instantiate all the objects you’ll need at any specific moment before gameplay — for instance, during a loading screen. in place of
