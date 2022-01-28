# Unity-PlantVsZombies-Game
This a basic unity plant vs zombies clones, it will only be used as a testing ground for technical utilities and not as an actual game. Currently the focus point of this game is to effectively implement a plant vs zombies clone using the Unity D.O.T.S formulation which is Unity's new high-performance, multithreaded Data-Oriented Technology.

## Technical Capabilities

### D.O.T.S
DOTS marks a fundamental change in direction of Unity’s architecture. DOTS is a combination of technologies that are new to Unity, which requires a new way of working with Unity and a different approach to thinking about code and data using data-oriented design (DoD), as opposed to the object-oriented approach of Unity without DOTS.

### Object Pool
Instantiate() and Destroy() are useful and necessary methods during gameplay. Each generally requires minimal CPU time.
However, many seamingly insignificant things with some time may add up. This becomes a problem in ( for example) a game where many object may bee instantaited and destroyed at the same time (like plant vs zombies). Additionally, Unity uses Garbage Collection to deallocate memory that’s no longer in use. Repeated calls to Destroy() frequently trigger this task, and it has a knack for slowing down CPUs and introducing pauses to gameplay. This behavior is critical in resource-constrained environments such as mobile devices and web builds.Object pooling is where you pre-instantiate all the objects you’ll need at any specific moment before gameplay — for instance, during a loading screen. Instead of creating new objects and destroying old ones during gameplay, your game reuses objects from a “pool”.

