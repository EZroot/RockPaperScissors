## General
No copied/third party code was used for this.

## State Machine
Unnessesary in this case but it allows for easily extending the game functionality if we ever wanted to add more states/conditions
Since the demo came as an unfinished game I would assumed more States/Conditions would be nessesary.
PlayState is a little overkill :P

## Scriptable Objects
Scriptable objects to hold our Mock Data

## Saving/Loading
Simple saving/loading using Json
- Could use a coroutine to wait for file writing/reading

## Changes around the Code/Structure
I like to do

GameObject
- GameGraphics
- GameData

for anything that I feel is an entity.

Ideally I would've had a 

PlayerController
-PlayerView
-PlayerData

OpponentController
-OpponentView 
-OpponentData

as their own game objects, or even prefabs.
Instead for the sake of saving time I decided to stick with the current setup and just have a single GameController which holds the player and opponent.

## GlobalData
- Holds mock data
- bool TransferWins, will transfer game data when true 
- bool SaveGame, will attempt to load/save json data, else it will just use mock data

## Other
Many other changes that are too long to list/remember.