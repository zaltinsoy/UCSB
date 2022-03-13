# MMI 505 Project US, CAT & SLEEPING BABY

# Introduction

Us, Cat & Sleeping Baby (UCSB) is a 3D fast adventure game where the
players will be in the role of two siblings who are taking care of a
baby and home. The game is developed for MMI 505 Game Development Pipeline Course.

# Similar Games & Inspiration Sources

The main inspiration for the UCSB is the old co-op NES games. During my
childhood, most of the games were developed for the two players playing
together on one screen. However, playing a video game is generally a
solitary activity nowadays, and I wanted to develop a game where two
players can enjoy.

Following games are new generation co-op games:

-   It Takes Two (2021)

-   Overcooked 2 (2018)

-   Don\'t Starve Together (2016)

# Phase 1 - Idea & Concept Stage

Main gameplay elements are decided on this stage. Figure 1 shows the
storyboard of the game during this stage. Players are two siblings who
try to take care of home and baby until the parents come. They have
different duties about the house such as:

-   Cat is messing up the house - Players are tidying the house

-   Baby has different need status that player needs to satisfy

    -   Eat

    -   Sleep

    -   Toilet

> ![resim](https://user-images.githubusercontent.com/81522783/158057207-e638ce87-effd-4559-a4e0-18378b810599.png)

>
> Figure 1 Storyboard

# Phase 2 - Elaboration Stage

The game's core mechanics are developed in this stage using simple
assets. Figure 2 shows an example screenshot from phase 2.

![resim](https://user-images.githubusercontent.com/81522783/158057239-af89aea0-0485-4718-ac6d-07409e1ad742.png)

> Figure 2 Phase 2 Screenshot

## 4.1 Gameplay Elements in Phase 2

Players try to provide the following needs of the baby:

• Eat - Prepare a meal and feed the baby

• Diaper Change - Change baby\'s diaper

If the player does not satisfy the need and the bar reduces to zero, the
player fails. If the player does not fail until the timer reaches zero,
the player passes the level with the score based on need bars.

### **Eat:**

![resim](https://user-images.githubusercontent.com/81522783/158057248-f3a49c5c-e30d-4993-9758-5b5b29646c63.png)

This need is shown with a red bar at the top left. To fulfill it player
needs to first prepare the meal and serve the baby. The meal consists of
the followings:

-   Bowl

-   Milk

-   Ingredient

![resim](https://user-images.githubusercontent.com/81522783/158057252-534d4735-c14b-482f-b5c4-261d185b23cd.png)

Figure 3 Providers

The player needs to pick up all three items and use the mixer to create
the \"Ready Meal\" item.

![resim](https://user-images.githubusercontent.com/81522783/158057262-4677b733-6de4-4e7c-a129-386f6833c4a7.png)

Figure 4 Items at Mixer

![resim](https://user-images.githubusercontent.com/81522783/158057267-e4007de1-5bfe-4def-8f4d-91b346537eb2.png)

Figure 5 Meal at Mixer

### **Diaper Change:**

![resim](https://user-images.githubusercontent.com/81522783/158057274-eec4db5f-e2c1-4947-b3a1-73a9345ff84e.png)

This need is shown with a green bar at the top left. To fulfill it
player needs to pick up the diaper from the diaper provider and give it
to the baby.

![resim](https://user-images.githubusercontent.com/81522783/158057282-d5bad502-c3f4-457b-81ef-db31d0ea5b05.png)

Figure 6 Diaper Provider

# Final Phase - Tuning Stage

During this stage, the game is improved based on the feedback from the
class and ideas from phase 1. Following improvements has been applied:

-   Level design is improved. The level is bigger than phase 2, and the
    camera angle is adjusted to give a better view to the player.

-   Interface improved. UI elements were so small for the screens with
    high resolutions. Their sizes are increased.

-   Interactive objects\' assets are changed and shown with different
    colors.

![resim](https://user-images.githubusercontent.com/81522783/158057294-a9b2b261-3519-4e87-9073-e2eaeb7deea2.png)

> Figure 7 Screenshot of Final Phase

-   Game start & game over screens are added, which shows players\'
    score (if they win) or how long they resist (if they lost).
![resim](https://user-images.githubusercontent.com/81522783/158057298-77e4c675-fc58-4635-a3c0-46f6b0c25800.png)
>
> Figure 8 Gameover Screen

-   Cat is added. The navigation mesh feature is used for the movements
    of the cat. During the game cat randomly moves from one closet to
    another, and when it touches the closet, an object falls. The player
    needs to pick this up, or the baby will wake up.
![resim](https://user-images.githubusercontent.com/81522783/158057305-5efd3232-7f5b-4167-a261-1ec89feb4ee7.png)
>
> Figure 9 Navigation Mesh

-   Eat and diaper statuses decrease at a fixed rate on fixed time
    intervals. Feedback from the players is used to fine-tune these
    rates. After tuning, a new player could pass the level after a few
    trials. It is good that players cannot pass on their first trial but
    also not frustrating to pass.

# Limitations

The followings are part of the phase 1 plan; however, they were not
implemented in the final stage:

-   Currently, all 3D models are free assets from the Unity Asset Store.
    The original plan was to use handcrafted models.

-   Animations are not working correctly.

-   The game\'s main idea is to be a co-op game; however, currently the
    game is a single-player game. Support for the second player is not
    added.
