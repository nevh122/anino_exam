# Anino SE Exam

## System Startup

Unity Version 2021.2.17.f1

Classes and Controllers:
- **Reel_Data** - Handles reels animation and postioning on the slots, also handles starting and stopping the movement of reels.
- **Slots_Controller** - Handles most of the objects in the game, updating player total coins left, increasing and decreasing bet and the button that makes the reel spin.
- **Payout_UI_Buttons** - Handles the info panel buttons and controls.
- **Symbols_Data** - To be used for future scripts to implement scoring.

Objects:
- Game Managers
- Main Camera
- Interactable UI (Canvas)

## Scalability of system
Given enough time, multiple implementations can be done such as targeted symbols or a pity system and proper implementation of the payout line scoring system with proper computations. Another is being able to store the players balance in a more secure way and creating different methods to earn more coins in the case of the player spending all of it.

## Flexibility of the system
The current dataset of the entire software is easily accessible and modifyable for the purpose of it being changed on a long period of time. Such as varibles being serialized through the inspector and sorting of classes to eaily locate and modify certain parts of code.

## Use of MVC
In the case of this project, the MVC is used in the following way:

- **View** - The different buttons that the player can interact within the scene, which send the interaction or data effect to the controller for processing.
- **Controller** - The one that is incharge of giving the effect after an interaction during the views, in this case, this is in charge of how the reels spin, how much did the player bet, what is the remaining balance of the player, show and unshow the instruction menu, did the player win in any of the payout lines and how much did the player win from that spin.
- **Model** - The model is in charge of showing to the player the results of the different things that the controller is doing, such as displaying the total ammount of coins left, showing how much can the player bet on a spin, show the instruction pane and its pages and for the player to see within the reels of they won or not.

## Future Improvements
First, implementing the other features from the specsheet is a must since those are the main features of the game:
- The payout line scoring and calculation system
- Quick stop button replacing the spin button when the reels are moving

After these are implemented we can consider of adding features that may improve the quality of life of teh game, such as adding wild symbols that can boost the over all earnings that the player can receive or adding a mini game where the player can get coins in the case of them wasting all their money, things that can help the game have more replayability for the players.
