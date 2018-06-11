# stuff to do

## part 1

- add a new `string` property to the `Player` class called `CharacterClass`
- prompt the player to set their class at player creation
- display the player's name in at least 2 locations throughout the game
- display the player's class in at least 1 location in the game
- Extract the player creation code into a separate method (all of it)

## part 2

- In the `SneakingToGoblinCampsite` method, the `sneak` option should only appear
  if your `CharacterClass` is "rogue".

  currently says (and should continue to say if you're a "rogue"): 
  "move slowly through woods find horse and supplies by a goblins campfire.  Luckily 
   for you the lazy goblin has fallen asleep. You can [sneak] or [attack]"

  if you're NOT a rogue:
  "move slowly through woods find horse and supplies by a goblins campfire.  Luckily 
   for you the lazy goblin has fallen asleep. You can [attack]"