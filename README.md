# QuadTree Collision Detection
## Describtion
*This variation of a quadtree is similar to a binary search tree; however, rather than sorting on just one well-ordered element, it sorts on a pair of well-ordered elements. That is, it stores two-dimensional vectors which we will denote as (x, y) and each node has up to four children.*

## Requirements
*Spawn lots of entities in the world with varying sizes. When an entity bump into another, takes 1 damage. Each entity has 5 health, when they die, spawn another entity in a random position within the tree*

## Usage
First, 100 objects are produced and they move randomly. During the random movement of objects, we can see the operation of the QuadTree algorithm on Gizmos. On the UI, user can increase the number of objects and if he wants he can restart with default objects value.


## Design Patterns
**Singelton**
**Visitor**
**Observer**
**Adapter**
**Builder**
**Composite**


## Contributing
https://github.com/cr4yz/Unity3d-QuadTree-Collision-Detection

**A simple collision detection system. Includes two algorithms:**

Brute checks all bodies against all other bodies, and it can be hard on performance and only recommended for 100 or less bodies.
QuadTree queries a QuadTree to test collisions against nearby bodies only. Much more performant than Brute.

## Frame Debugger 
*The Frame Debugger lets you freeze playback for a running game on a particular frame and view the individual draw calls that are used to render that frame. As well as listing the drawcalls, the debugger also lets you step through them one-by-one so you can see in great detail how the Scene
 is constructed from its graphical elements.*
 *In this project we can see the rendering step by step with  using Frame Debugger*
![s1](https://user-images.githubusercontent.com/52382803/72842959-a0e9b880-3caa-11ea-9cc3-795f31c6a7c4.png)
![s2](https://user-images.githubusercontent.com/52382803/72842991-b2cb5b80-3caa-11ea-8456-2ab083ca685f.png)
![s3](https://user-images.githubusercontent.com/52382803/72842996-b52db580-3caa-11ea-96fc-2091b8f4acc0.png)
![s4](https://user-images.githubusercontent.com/52382803/72843000-b65ee280-3caa-11ea-853c-fb842c165bbe.png)
![s5](https://user-images.githubusercontent.com/52382803/72843003-b7900f80-3caa-11ea-856d-5a5ea9de855c.png)

## Conclusion
* Using QuadTree algorithm for collision detection is more efficent to other ways.
* We need to use OOP
* I did not use 3rd party tools but it can be use for drawing gizmos, benchmark testing and Garbage Collection
