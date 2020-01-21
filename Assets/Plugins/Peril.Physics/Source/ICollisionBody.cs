
namespace Peril.Physics
{
    public interface ICollisionBody
    {

        int RefId { get; set; }

        /// <summary>
        /// Skip this body when testing for collisions
        /// </summary>
        bool Sleeping { get; }
        

       // int Health { get; set; }
        //bool Die { get; }

        /// <summary>
        /// The body's collision shape
        /// </summary>
        ICollisionShape CollisionShape { get; }

        /// <summary>
        /// Called each frame of collision
        /// </summary>
        /// <param name="result"></param>
        /// <param name="other"></param>
        void OnCollision(CollisionResult result, ICollisionBody other);

    }
}

