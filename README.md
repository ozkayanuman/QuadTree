# QuadTree Collision Detection
## Describtion
Spawn lots of entities in the world with varying sizes. When an entity bump into another, takes 1 damage. Each entity has 5 health, when they die, spawn another entity in a random position within the tree

**A simple collision detection system. Includes two algorithms:**

Brute checks all bodies against all other bodies, and it can be hard on performance and only recommended for 100 or less bodies.
QuadTree queries a QuadTree to test collisions against nearby bodies only. Much more performant than Brute, but takes a bit of extra work to set up.
