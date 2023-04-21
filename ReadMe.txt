Joshua David Morgan (100824998)

*
*
*

Scene Setup and Object Movement:
	To setup the scene I simply place 3 planes adjacent to each other to create a small room diorama and used a regular material for the floor. I also 	simply used cubes with regular materials for the desks in the background to keep it low-fidelity. The characters in the scene (ninja turtle and enemy) 	are capsules with regular materials with their appropriate colour as well. The way I got the ninja turtle and the enemy to move in the scene is I 	created empty objects (points) in the scene for which they move back and forth from, and I created a character movement script which linearly 	interpolates the character's position between the two points by a time value (time spent travelling between each point). The points were positioned so 	that the two characters approach each other at the same time as if they were fighting, and the ninja turtle game object even goes into the air to look 	like it's doing a jumping karate kick.

Wallpaper bump mapping:
	In order to create the grainy wallpaper in the background from the original scene, I created a grainy orange and yellow texture in paint using the 	airbrush, as well as used a noisy texture I created for a previous assignment. Using the bump mapping shader from the course I was able to plug in 	both textures into thir appropriate spots and achieved the resulting effect (see the "Wallpaper" screenshot in Screenshots folder).

Flowing Lava:
	In order to create the flowing lava that substitutes the animated fire in the original scene from the game, I created a plain and attached the 	wave/water shader we made in class and added on scrolling textures to the shader. I had to position in and play around with the shader values in a way 	so the lava does not poke through the floor of the building. As for the texture, I used a free texture from the web and plugged it in to both 	scrolling slots (X and Y). Originally I only used the X scrolling parameter for the texture as that would have been sufficient, but having the same 	texture used in the Y srolling slot at a different speed looks to add another layer to the lava and adds to the effect of the lava flow.

	Link to texture: https://www.freepik.com/free-photo/marbled-yellow-orange-abstract-background_3037512.htm#query=lava%20texture&position=29&from_view=keyword&track=ais

	(see the "Lava" screenshot in Screenshots folder).

Bloom:
	For bloom I used the bloom shader and camera script we created in class. In order to make the intensity toggle for the bloom effect I wanted to 	create a float property in the shader itself and I would change its value through the script attached to the camera when the button is toggled in 	the UI, but the shader doesn't seem to like having more than 1 property. So instead I simply set the iterations amount to a higher number when the 	toggle is turned on and to a lower number when the toggle is turned off. Finally, in order to have changing lights in the scene, I used the lamp model I made for my GDW game this year and adjusted the point lights intensity value through animations. (see the "LampLow" & "LampHigh" screenshots in Screenshots folder).