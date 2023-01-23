This repository contains 2 simple C# script that defines the MonoBehavior for bill boarding Unity Game Objects.

My Recommendation for use, is to create a nested Game Object, where the actual Sprite Renderer and BillBoardSpriteController are in the inner object.  An example of this in practice is as follows:

![Alt text](./BillBoard%20Sample.PNG?raw=true "Example Setup")



**BillBoardSpriteController** 
Handles the actual billboarding of the sprites.  Easily able to configure it to billboard the sprite along the horizontal axis as well, so that it looks at the camera should the camera take a higher angle.


**ShadowController**
Simply allows the Sprite to accept lighting in the scene, and form shadows.  May need to adjust camera settings to fully enable shadows, this will largely depend on your Render Pipeline setup.

**Sprite Lighting**
A simple shadergraph that is able to get the Sprite Renderer to treat objects as though they are 3D.  All you should have to do is create a new Material, using this as its Shader.  Feel free to play around with settings to get what works best.  With this setup, you can get lighting effects similar to this:


When everything is setup correctly, you can get results similtar to the following:

![Alt text](./Sprite%20Lighting%20Example.gif?raw=true "Sprite Lighting Example")
