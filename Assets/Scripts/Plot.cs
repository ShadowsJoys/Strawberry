using TMPro;
using UnityEngine;

public class Plot : MonoBehaviour
{

    //You can write comments in your script by starting it with "//".
    //Whatever is in a line that starts with "//" will just be ignored by the script.
    //You can write a bunch of comments to denote what you're doing and where and why if you want.
    //I generally don't.
    //In professional settings you're supposed to so that people reading and working on your code can figure out what's going on.
    //You can also change whether a line is commented out or not by typing ctrl+/ while your cursor is on that line.
    //You can comment out a bunch of lines by selecting them all and using ctrl+/.

    //this part of the script doesn't *do* anything, it's just a base for the rest of the script.
    //this is where you define your variables.
    //there are a few types of variables. "string" means text. "int" means integers. "float" means non-integers. and "bool" means 0/1, true/false.
    //"public" variables can be seen, accessed, and referenced by other scripts. "private" ones can't. I mostly use public ones.
    //finally, "static" means the variable is always going to be the same value no matter what.
    //If you tell one script to change it to 1 and then ask a different script what it is, it will tell you it's 1.
    //Otherwise scripts will only listen to what you tell them specifically. Each instance of a script can have a different value for a variable.

    public bool yes, no;
    //this line means "check if the object this is attached to is a yes or a no."
    //I'll tell the objects if they're yes or no over in Unity.
    //the way this is set up, an object can be both yes and no or neither yes nor no if I tell it that.
    //I could set these variables as being called whatever they want.
    private bool shrekSwamp;
    //the names are just for storage and reference, I call them whatever would be useful.

    //another variable that will be important to you is TMPro, or TextMeshPro.
    //That's the object that is the text you're writing into. It's the same text object, but you're changing what it says.
    //you'll see things similar to "text.text", which means "the words that the text object says".
    //if text.text = "friendship is magic", the text object will say "friendship is magic".
    //text.text will be the variable type "string". Just text will be TMP.
    //You need to be in the right variable type or the computer has no clue what's going on.

    public TextMeshPro strawbText;
    public GameObject textBox, strawberry, strawberry1, strawberry2, strawberry3, strawberry4, strawberry5, character, character2, ths, nx, ys, n, win;
    static public int strawbCount;
    static public int dia;
    public bool next, bigStrawb, FESTIVAL;

    void Start()
    {
        //whatever's in here will happen as soon as you start the game.

        strawbText.text = "Welcome! I'm glad you're here.";
        nx.SetActive(true);
        
    }

    void Update()
    {
        //whatever's in here will happen every single frame of the game.
        //it's best to avoid putting stuff in here when you can. You want more specific triggers.
        
    }

    private void OnMouseUp()
    {
        if (dia == 1)
        {
            //okay here is another important lesson. "=" means "set the variable to..."
            //"==" means "the variable is equal to..."
            //so "strawberry = 1" means "from now on, strawberry is 1."
            //while "strawberry == 1" means "strawberry is equal to 1." Which isn't helpful on its own.
            //it's used in cases like this where I'm checking if the variable "dia" is equal to 1.

            if (next)
            {
                //also "if(next)" means the same as "if(next == true)" and "if(next == 1)".
                strawbText.text = "I'm setting up the strawberry festival for tomorrow, but I need help!";
                dia++;
                //and "dia++" is a shortened way of saying "add one to the value of dia" which in code is "dia = dia+1"
                //so dia is now 2

            }
        }
        else if (dia == 2)
        {
            if (next)
            {
                strawbText.text = "I can't find any of the strawberries! Will you help me?";
                dia++;
                nx.SetActive(false);
                ys.SetActive(true);
                n.SetActive(true);
            }
        }
        else if (dia == 3)
        {
            if (yes)
            {
                strawbText.text = "Oh thank you so much! Wait, what's that?";
                dia++;
                strawberry.SetActive(true);
                ys.SetActive(false);
                n.SetActive(false);
            }
            else if (no)
            {
                strawbText.text = "You know what? Fuck you, man. You gotta start the game over.";
                character2.SetActive(true);
                character.SetActive(false);
            }
        }
        else if (dia == 4)
        {
            if (next)
            {
                strawbText.text = "Okay, let's get serious.";
                dia++;
            }
        }
        else if (dia == 5)
        {
            if (next)
            {
                strawbText.text = "Look around your screen. There's a lot, but I'll break it down.";
                dia++;
            }
        }
        else if (dia == 6)
        {
            if (next)
            {
                strawbText.text = "First things first: on the left you'll see a big list of all the stuff in this scene.";
                dia++;
            }
        }
        else if (dia == 7)
        {
            if (next)
            {
                strawbText.text = "And on the right you'll see a window labeled Inspector.";
                dia++;
            }
        }
        else if (dia == 8)
        {
            if (next)
            {
                strawbText.text = "Then down below the game should be a file directory for the project.";
                dia++;
            }
        }
        else if (dia == 9)
        {
            if (next)
            {
                strawbText.text = "So here's the part I need your help with. It's a little complicated, but I know you can do it!";
                dia++;
            }
        }
        else if (dia == 10)
        {
            if (next)
            {
                strawbText.text = "I need you to go to the scene on the left and look for an object named THIS.";
                dia++;
            }
        }
        else if (dia == 11)
        {
            if (next)
            {
                strawbText.text = "Click on THIS. The inspector window on the right should now say THIS at the top.";
                dia++;
            }
        }
        else if (dia == 12)
        {
            if (next)
            {
                strawbText.text = "Scroll down until you see the word FESTIVAL. There's a checkbox next to it. Check it.";
                dia++;
            }
        }
        else if (dia == 13)
        {
            if (ths.GetComponent<Plot>().FESTIVAL == true)
            {
                if (next)
                {
                    strawbText.text = "You did it! And there's another strawberry for the festival!";
                    strawberry.SetActive(true);
                    dia++;
                    nx.SetActive(false);
                }
            }
        }
        else if (dia == 14)
        {
            if (next)
            {
                strawbText.text = "The next thing I need your help with is making decorations for the festival.";
                dia++;
            }
        }
        else if (dia == 15)
        {
            if (next)
            {
                strawbText.text = "See, you're currently in the Game tab. You can see it right below the play button.";
                dia++;
            }
        }
        else if (dia == 16)
        {
            if (next)
            {
                strawbText.text = "If you click on the Scene tab, you can see what's going on backstage.";
                dia++;
            }
        }
        else if (dia == 17)
        {
            if (next)
            {
                strawbText.text = "But there's something important you need to know.";
                dia++;
            }
        }
        else if (dia == 18)
        {
            if (next)
            {
                strawbText.text = "Anything you change while the game is running will reset when you stop the game.";
                dia++;
            }
        }
        else if (dia == 19)
        {
            if (next)
            {
                strawbText.text = "So if you want your changes to stick, you need to make the changes when the game isn't running.";
                dia++;
            }
        }
        else if (dia == 20)
        {
            if (next)
            {
                strawbText.text = "But if we leave the game now, we'll lose all your progress!";
                dia++;
            }
        }
        else if (dia == 21)
        {
            if (next)
            {
                strawbText.text = "So let's make a checkpoint, so you can come back here when you're done.";
                dia++;
            }
        }
        else if (dia == 22)
        {
            if (next)
            {
                strawbText.text = "But remember, you need to make this change when the game isn't running, or it won't stick.";
                dia++;
            }
        }
        else if (dia == 23)
        {
            if (next)
            {
                strawbText.text = "So I'll show you how to do it here, and you can do it again after you've stopped the game.";
                    dia++;
            }
        }
        else if (dia == 24)
        {
            if (next)
            {
                strawbText.text = "In the project window down below, you'll see a folder called Scripts.";
                dia++;
            }
        }
        else if (dia == 25)
        {
            if (next)
            {
                strawbText.text = "I'm using the one called Plot. But you want the one called StrawberryScript.";
                dia++;
            }
        }
        else if (dia == 26)
        {
            if (next)
            {
                strawbText.text = "If you drag that script onto an object, clicking it will bring you right back here.";
                    dia++;
            }
        }
        else if (dia == 27)
        {
            if (next)
            {
                strawbText.text = "When you're in the Scene tab, look over to the left and hit the plus button.";
                dia++;
            }
        }
        else if (dia == 28)
        {
            if (next)
            {
                strawbText.text = "Then click 2D objects>sprites>triangle.";
                dia++;
            }
        }
        else if (dia == 29)
        {
            if (next)
            {
                strawbText.text = "In order to be able to click on your triangle, it needs a collider.";
                dia++;
            }
        }
        else if (dia == 30)
        {
            if (next)
            {
                strawbText.text = "So click on your triangle so it shows up on the right, scroll to the bottom, and click Add Component.";
                    dia++;
            }
        }
        else if (dia == 31)
        {
            if (next)
            {
                strawbText.text = "The component you want is called Box Collider 2D. You can search it.";
                dia++;
            }
        }
        else if (dia == 32)
        {
            if (next)
            {
                strawbText.text = "Then all you need to do is add the script. You can drag it from the bottom into the Inspector on the right.";
                    dia++;
            }
        }
        else if (dia == 33)
        {
            if (next)
            {
                strawbText.text = "If you see it in the Inspector window on the Triangle object, you did it right.";
                dia++;
            }
        }
        else if (dia == 34)
        { if (next)
            {
                strawbText.text = "Think you can do that again? Go ahead and stop the game.";
            }
        }
        else if(dia == 35)
        {
            if(next)
            {
                strawbText.text = "I'm about to explain how to put up decor, but you might have already done it. Did you?";
                nx.SetActive(false);
                ys.SetActive(true);
                n.SetActive(true);
                dia++;
            }
        }
        else if(dia == 36)
        {
            if(yes)
            {
                strawbText.text = "Perfect! It looks great!";
                strawberry.SetActive(true);
                ys.SetActive(false);
                n.SetActive(false);
                dia = 50;
                //Right here!!
            }
            if(no)
            {
                strawbText.text = "Gotcha. I want you to doodle up some decor for the festival and save it as a PNG.";
                dia++;
            }
            
        }
        else if(dia == 37)
        {
            if (next)
            {


                strawbText.text = "Put that PNG into this game's Assets folder. It should show up below.";
                dia++;
            }
        }
        else if(dia == 38)
        {
            if (next)
            {
                strawbText.text = "Click on the PNG below so it shows up in the Inspector window to the right and look for the Sprite Editor.";
                dia++;
            }
        }
        else if(dia == 39)
        {
            if (next)
            {
                strawbText.text = "From there you can cut your PNG up exactly how you want.";
                dia++;
                    }
            
        }
        else if(dia == 40)
        {
            if(next)
            {
                strawbText.text = "Click the arrow on the PNG file to see all the cut up sprites and drag them into the Scene window.";
                dia++;
            }
        }
        else if(dia == 41)
        {
            if(next)
            {
                strawbText.text = "In the Inspector window for your sprites, find the words Order in Layer and mess with that number.";
                dia++;
            }
        }
        else if(dia == 42)
        {
            if (next)
            {
                strawbText.text = "Remember, you need to make changes when the game is stopped for them to stick.";
                dia++;
            }
        }
        else if(dia == 43)
        {
            if(next)
            {
                strawbText.text = "Go ahead and add some decor, and use the triangle to come back when you're done.";
            }
        }
        else if(dia == 50)
        {
            if(next)
            {
                strawbText.text = "In order to earn your last strawberry, you're going to have to look at the Plot script.";
                dia++;
            }
        }
        else if(dia == 51)
        {
            if (next)
            {
                strawbText.text = "It's a lot, and it looks super complicated, but you don't have to understand it.";
                dia++;
            }
        }
        else if(dia == 52)
        {
            if(next)
            {
                strawbText.text = "All you have to do is double click the script to open it, then ctrl+f the phrase Right Here!";
                dia++;
            }
        }
        else if(dia == 53)
        {
            if(next)
            {
                strawbText.text = "Then change dia = 50 to dia = 55. Quit the game. Save the script. And click yes when you come back.";
            }
        }
        else if(dia == 55)
        {
            if(next)
            {
                strawbText.text = "Okay, there is one more step, and then the festival!";
                dia++;
            }
        }
        else if(dia == 56)
        {
            if(next)
            {
                strawbText.text = "Go back into the script and ctrl+f Final Strawberry. And write your winning dialogue!";
                    dia++;
            }
        }
        else if(dia == 57)
        {
            if(next)
            {
                strawbText.text = "It'll show up right here. Make me say whatever you want. And comment the last line back in.";
                //Change the dialogue above and comment the line below back in for your final strawberry!
                //strawberry.SetActive(true);
                nx.SetActive(false);
            }
        }


        if (bigStrawb)
        {
            strawbCount++;
            strawberry.SetActive(false);
            nx.SetActive(true);
            if (strawbCount == 1)
            {
                strawberry1.SetActive(true);
                strawbText.text = "It's a strawberry! You're a huge help already!";
            }
            else if (strawbCount == 2)
            {
                strawberry2.SetActive(true);
                strawbText.text = "Just three more and we'll be ready for the festival!";
            }
            else if (strawbCount == 3)
            {
                strawberry3.SetActive(true);
                strawbText.text = "You're learning so fast!";
            }
            else if (strawbCount == 4)
            {
                strawberry4.SetActive(true);
                strawbText.text = "We're almost ready for the festival! Just one more strawberry!";
            }
            else if (strawbCount == 5)
            {
                strawberry5.SetActive(true);
                win.SetActive(true);
                strawbText.text = "You did it! The Strawberry Festival is going to be a blast!";
                nx.SetActive(false);
            }
        }
    }
}
