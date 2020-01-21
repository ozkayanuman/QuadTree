using System.Collections;
using System.Collections.Generic;
using Peril.Physics;
using UnityEngine;

public class DestroyObjects :DemoScript
{
    
    /// <summary>
    /// Detecting collision and reducing health
    /// </summary>
    /// <param name="col"></param>
    public void OnTriggerEnter(Collider col)
    {
        //col.gameObject.name == "DemoPhysicsBody(Clone)"

        //I give different tag to instantiated object Because i don't want to  hide main object
        if (col.tag=="instantiated")
        {
          int healthValue= col.GetComponent<DemoPhysicsBody>().health--;
            if (healthValue<=0)
            {
                //for increasing in UI
                Counter.hiddenOrDestroyValue++;
                

                //Destroy(this.gameObject);
               
                //hide game objects
                col.gameObject.SetActive(false);

                //Instantiating to [Scripts] 
                GameObject.FindGameObjectWithTag("Generator").GetComponent<DemoScript>().InstantiateObj();
            }
            
        }
    }
}
