# QuadTree Collision Detection
## Describtion
*This variation of a quadtree is similar to a binary search tree; however, rather than sorting on just one well-ordered element, it sorts on a pair of well-ordered elements. That is, it stores two-dimensional vectors which we will denote as (x, y) and each node has up to four children.*

## Requirements
*Spawn lots of entities in the world with varying sizes. When an entity bump into another, takes 1 damage. Each entity has 5 health, when they die, spawn another entity in a random position within the tree*

## Usage
First, 100 objects are produced and they move randomly. During the random movement of objects, we can see the operation of the QuadTree algorithm on Gizmos. On the UI, user can increase the number of objects if he wants and restart with default objects value.


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
