using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kid_Dialogues_Manager : MonoBehaviour
{

    public DialogManager DialogManager;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/size:up/Kid\nDad, /size:init/I am home."/*, "Li"*/, "", null, false));

        dialogTexts.Add(new DialogData("Dad\nSon, /size:init/What is your test result."/*, "Sa"*/, "", null, false));

        dialogTexts.Add(new DialogData("Kid\nDad, /size:init/Why u have to be so rude."/*, "Li"*/, "", null, false));

        dialogTexts.Add(new DialogData("Dad\nSon, /size:init/Oh so now you will teach me manners. Should i call your mom or will you show me the test result."/*, "Li"*/));

        dialogTexts.Add(new DialogData("Kid\nDad, /size:init/here is the test.I think i did pretty good"/*, "Li"*/));

        dialogTexts.Add(new DialogData("Dad\nSon, /size:init/You think this is good.A D grage is good. I think I should teach you a lesson. No more Games for you untill you get a better result in the next test. "/*, "Li"*/));

        dialogTexts.Add(new DialogData("Mom\nSon, /size:init/You really made me mad with this test result of yours.You should know that the evil clown man will punish you if you dont get a better result next time."/*, "Li"*/));

        dialogTexts.Add(new DialogData("Mom\nSon, /size:init/Now go to your room eat food and the medicine and not to touch the video games."/*, "Li"*/));

        dialogTexts.Add(new DialogData("\n /size:init/i should go to my room."/*, "Li"*/));

        dialogTexts.Add(new DialogData("/size:init/Oh the food is there and the video game is on i should save my last progress and turn it off."/*, "Li"*/));

        dialogTexts.Add(new DialogData("/speed:0.1/Who is this, i think its that clown guy."/*, "Li"*/));

        dialogTexts.Add(new DialogData("Son\n Where am i and what is happening. Mom is that you who is this. plz dont destroy things. AAAAAA /click//sound:haha/haha.", "Li"));

        dialogTexts.Add(new DialogData("Mom\n What happened son you were again plaing games and look u fainted./click//sound:haha/haha.", "Li"));

        dialogTexts.Add(new DialogData("Son\n I saw the evil clown man and then i saw you destrying things and after the i fainted it was pretty bad./click//sound:haha/haha.", "Li"));

        dialogTexts.Add(new DialogData("Mom\n Oh this story again i knew it woulb be you. You have a condition in which you think that it is a evil clown but instead it is you who does it and i am very annoyed by this u need to control your anger in that state that is why you take medicine after your meal. Now go and eat you meal and take those pills /click//sound:haha/haha.", "Li"));

        dialogTexts.Add(new DialogData("Son\n I should take some rest i feel pretty tired./click//sound:haha/haha."/*, "Li"*/));

        dialogTexts.Add(new DialogData("Son\n AAh its that clown again./click//sound:haha/haha."/*, "Li"*/));

        dialogTexts.Add(new DialogData("Son\n oh i got out of my room. What is happening. Don't destroy things wait its not me who is doing it ./click//sound:haha/haha."/*, "Li"*/));

        dialogTexts.Add(new DialogData("Son\n There is someone near my parents room. He is going in ./click//sound:haha/haha."/*, "Li"*/));

        dialogTexts.Add(new DialogData("Son\n I wonder who was that and why did he go into my parents rooms ./click//sound:haha/haha."/*, "Li"*/));

        dialogTexts.Add(new DialogData("Son\n The Room Is locked i should try one more time ./click//sound:haha/haha."/*, "Li"*/));

        dialogTexts.Add(new DialogData("Son\n The Room Is open lets go inside ./click//sound:haha/haha."/*, "Li"*/));

        dialogTexts.Add(new DialogData("Son\n What Happened here Mom Dad Why is the so much blood./click//sound:haha/haha."/*, "Li"*/));

        dialogTexts.Add(new DialogData("Son\n I am halucinating ./click//sound:haha/haha."/*, "Li"*/));

        dialogTexts.Add(new DialogData("Son\n So it was me who did this noooooo Mom Dad ./click//sound:haha/haha."/*, "Li"*/));

        dialogTexts.Add(new DialogData("That's it! Please check the documents. Good luck to you."/*, "Sa"*/));

        DialogManager.Show(dialogTexts);
    }




}
