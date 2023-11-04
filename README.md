# UnityPlantVsZombiesDemo
A basic unity plant vs zombies clone, it and will only be used as a testing ground for technical utilities and not as an actual game. Currently the focus point of this game is to effectively implement a plant vs zombies clone using the Unity D.O.T.S formulation which is Unity's new high-performance, multithreaded Data-Oriented Technology.

## Technical Capabilities

### D.O.T.S 
Data-Oriented Technology Stack (DOTS) marks a significant paradigm shift in Unity's development architecture. DOTS offers a new approach to both engine operations and code/data structuring, emphasizing data-oriented design (DoD) over the traditional object-oriented programming (OOP) model typically used in Unity.

### Object Pool
During gameplay, the methods Instantiate() and Destroy() are both beneficial and required in most cases, only a little amount of CPU time is required (for this set of actions).
However, many seemingly little things can build up over time. This becomes a problem in games when a large number of objects are created and destroyed at the same time (like plant vs zombies).In resource-constrained settings, such as mobile devices and web builds, this behavior is crucial since the effect of the impact may be greater because of slower cpu, ram and sometimes hard drive speed. Object pooling is where you pre-instantiate all the objects you’ll need at any specific moment before gameplay — for instance, during a loading screen.
![Screenshot 2022-01-28 163754](https://user-images.githubusercontent.com/56929989/151655006-6bf82926-154f-4674-b874-19e312aa26c8.png)

### Garbage Collection Optimization
An essential aspect of maintaining performance in Unity games is optimizing garbage collection to prevent frame rate drops. Our Plant vs Zombies clone:

Utilizes custom memory allocation to reduce the need for garbage collection.
Employs an object pooling strategy to minimize heap instability and garbage production.
Follows optimized scripting practices to avoid unnecessary allocations, particularly in frequently executed code.
Future Implementations and Optimizations
Advanced Object Pooling: Enhancing our object pooling system for a broader range of game elements.
DOTS Conversion: Full adoption of DOTS for all suitable game systems to improve performance and maintainability.
Job System and Burst Compiler: Integration with Unity's Job System and Burst Compiler for efficient multi-threading and computation.
Installation



### To run this Unity project:

Clone the repository to your local machine.
Open the project with Unity Hub (make sure you have the latest Unity version installed).
Load the main scene and hit the play button.


### Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are greatly appreciated.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

Fork the Project
Create your Feature Branch (git checkout -b feature/AmazingFeature)
Commit your Changes (git commit -m 'Add some AmazingFeature')
Push to the Branch (git push origin feature/AmazingFeature)
Open a Pull Request


#### License

Distributed under the MIT License. See LICENSE for more information.

#### Contact

[ - @Linkedin- jeann.hernandez@upr.edu](https://www.linkedin.com/in/jeann-c/)

Project Link: https://github.com/your_username/UnityPlantVsZombiesDemo
