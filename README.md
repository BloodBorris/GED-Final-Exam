Command Graph ![image](https://github.com/user-attachments/assets/fee20a78-f858-48b5-a768-161a88755279)
The command was made so I had two functions execute and inverse execute the key diffrence was they took two diffrent vector 3s when they execute so that after creating the Icommand object with both an inverse and normal vector3 I could call inverse or normal execute
This would allow me to set a bool to decide which of the functions was called in the retical manager resulting in the commands becomeing reversed on a hit of the pidgeon object.

For my object pool I simply made a pool of hiden objects when I start the game then I have a random set of integers that gets lower as the levels increase if the random number equals 1 then I spawn a game object in a random range
then call the code to launch the game object into the sky where it can then collide with the collider of the reticle to die if the player is pressing space to mimic the player shooting.

Lastly I made an observer that watches the players points and will modify its subscribers if there is a change in the points that either A execeds one of the high scores or B it will always update current points
