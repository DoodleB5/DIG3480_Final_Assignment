# DIG3480_Final_Assignment
John Lemon's Haunted Jaunt

**Team Members:** <br>
Bianca Bowonthamachakr <br>
Arya Kamat

**Google Drive Link:** <br>
https://drive.google.com/file/d/186ZsfptOhu019stHPaYkZOPNh8kPWhpS/view?usp=drive_link

***Bianca***
---
**Modifications Made:** <br>
I made the minor modifications to our game. I changed the camera perspective from a top-down perspective to a third-person over-the-shoulder perspective. In order to get this to work properly, I had to change the way the player movement script originally worked so that the character moves forwards and backwards but rotates using side inputs. I also added extra camera rotation that can be used by the o and p keys. This rotates the camera more to either left or right so that the player can have more visibility.

**Biggest Challenge:** <br>
I struggled getting any of my changes to work at all. After changing the perspective of the virtual camera, I struggled to get movement to work locally based on the direction your character faces rather than globally. Originally, the character always moved in a specific direction regardless of where the character looked. For example, w was always north and d was always east; when moving east with d/right, you turn your character side to side with w/up and s/down. It took a lot of experimentation to fix this issue until I finally settled on making w/up forwards and s/down backwards while the JohnLemon rotates in place with a/left and s/right. Until I got to that point, I was struggling with getting the character to move proper and the camera shaking. After that, I had to figure out how to get the extra camera movement to work while keeping JohnLemon in frame. Instead of letting the camera, which is offset from JohnLemon, rotate all the way around, I used clamps to limit the camera's rotation. I also realized that I had two camera controlling scripts that caused issues when both were active, so I kept only one active in the final build. The issues I had with the camera were both figuring out the issues within the script and messing with the settings in the cinemachine virtual camera.

**Continue Working On Assignment:** <br>
I don't plan on working on this project after this assignment. However, if I were to go back to this project, I would add UI and different screens. I would add a title screen with a play button, options menu, and an exit button; a pause menu to change settings and view the controls; and an end screen that allows you to restart the game after winning or exit the game. I would also add a HUD that shows a timer for how long you've played and when you can use your invisibility ability; for the invisibility ability, I would like to show whether or not it's ready to use, how long you're able to use the ability, and how long the cooldown takes.

***Arya***
---
**Modifications Made:** <br>
I made the major modification for our game. Our major modification was adding an invisibility feature to the JohnLemon player. With the press of the SPACE bar, the player can make themselves invisible, indicated by the light blue glow around the player's body. When invisible, the player will not be caught by the enemies. The invisibility stays on for around 5 seconds, and then there is around an 8-second recharge period before the player can use it again.

**Biggest Challenge:** <br>
My biggest challenge was getting the original mesh to turn off completely when invisibility turns on, leaving only the blue, glowing outline of the character. This would have made the invisibility feature clearer to the player and would have looked cool visually, as if the player were really in stealth mode. Unfortunately, I couldn't figure out how to script that, so I just made the glowing outline more visible on JohnLemon's body. I also struggled to make it so that his whole body would glow and not just the head and hands, but I was soon able to figure that out.

**Continue Working On Assignment:** <br>
I might work more on the project to help build up my portfolio, though I'm not completely sure yet. If I add more modifications to the project, I will likely try to implement a point system with items the player must collect to find their way out without getting caught. I could also add more to the level build, making the map bigger with additional rooms and hallways, adding more enemies and tasks as well.
