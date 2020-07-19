![Welcome Demo](Demo/demo.gif)

**The University of Melbourne**
# COMP30019 – Graphics and Interaction

## Workshop 1

# Introduction:

In this lab you will be introduced to Unity, a powerful games and simulation engine which facilitates the construction of rich interactive scenes.
You will start with by opening `Scenes > Main`.

* **Main.unity** - This file is our goal, we are going to recreate the behaivors that you see in the scene.

In the center you can see a `Play` Button. Click on it and the simulation start. You shoudl be able to see the same action as the gif at the top of this README.
Make sure to understand the diference between the `Scene tab` and the `Game tab`. On play you can see the Game tab while out of play you use the scene tab.

Explore this scene, in the `Hierarchy` (on the left) you can see all the `GameObjects` that are part of the scene:

* **Main Camera** - Viewpoint of the player, moving this GameObject position make the player move.
* **Directional Ligth** - The Sun in the scene.
* **Top Ball and Bottom Ball** - Balls that include physics (`RigidBody`) and a script to change the color on Collision.
* **Plane** - The ground of this simulation.
* **Canvas - Text UI** - This GameObject is not part of the Player scene but part the Player User Interface.
* **Text 3D Object** - Text as a Object part of the player scene.

Everthing in Unity need to be part of a `GameObject`, but not all GameObjects need a visual body; objects can also be trasparent! `Main Camera` does not have a body.

# Inspector

Click on the top ball,  and then look at the `Inspector` (on the right) you can see diferent `Components`. The components are `Sphere (Mesh Filter)`, `Mesh Renderer`, `Sphere Collider`, `Rigidbody`, `Change Color (Script)`, and `Default-Material`. To learn about them plase click on th `?` and read the documentation from Unity, this will hell you learn about everything each component can do.

![Learn Components](Demo/LearnComponents.gif)

# Script
The `Change Color (Script)` component is our code:

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour {
  
  public bool ChangeColorRed = true; // Adds a Public Variable that can change value in the Editor
  
  void OnCollisionEnter () { // This function run when the object has a collision
  
    if (ChangeColorRed == true){
    
      // Finds the component Renderer, and change the color of the Material to red
      gameObject.GetComponent<Renderer>().material.color = Color.red;
      
   	} else {
    
      gameObject.GetComponent<Renderer>().material.color = Color.blue;
      
   	}    
   }
}
```


# Task - Recreate the Scene

The best way of learning Unity is by using it. The objective is to start with a new file and recreate the one you explored.

Click on `File > New Scene` to start from an empty scene. You shoudl be able to see that it start with 2 Game Objects: `MainCamera` and `Directional light`.

Add all the GameObject by selecting the `+` 

![Learn Components](Demo/AddGameObjects.gif)

With the help of the Tutor and the other `Main Scene` make sure that all componenet are added to all `GameObjects`.

Good Luck!

 **Don't forget to save your scene, then use GitHub Desktop to commit and push your changes to the repository.** 

Do not forget to ask:

**How can I run code in Unity?**

**How does the Update function work?**





