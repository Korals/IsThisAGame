# IsThisAGame
A TextBasedGame project to learn more about C# and how to use it propertly
## Game features:
The game follows typical RPG structure: create a character, slay monsters, level up and slay more monsters.
After leveling up you get stat points to increase base stats which increase other stats:
* **Strength**
  * Attack power *(Used to determine the power of attacks)*
* **Stamina**
  * Health *(Used to determine max health)*
  * Defence *(Used to determine resistance to enemy attacks)*
* **Agility**
  * Speed *(Speed is used to determine who attacs first)*
* **Dexterity**
  * Dodge chance *(Used to determine if an attack will hit)*

*(All entities have these base stats)*

There is no max level set so the game can go on forever, but it will get harder to level up each time!

For now there are no plans to add items to this game, but that might happen later.
At first I wanted to create the game in console, but after some time (and help from a friend) I decided to move it to web API.
This would remove the need to download any executables to try it out and allow for graphical features to be added.
