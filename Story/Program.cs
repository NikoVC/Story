// bool isAlive = 3 < 16; True
// bool isAlive = 3 > 16; False
// bool isAlive = 3 == 16; False
// bool isAlive = 3+13 != 16; True
// bool isAlive = 13 != 16 && 3>3; False
// Console.WriteLine(isAlive);
// String name = Console.ReadLine().ToLower();
// if (name == "niko" || name == "nathan")
// {
//     Console.WriteLine("Kill me");
// }
// else if (name == "bob") 
// {
//     Console.WriteLine("I hate you Bob, die in a ditch");
// }
// else
// {
//     Console.WriteLine("Kill yourself");
// }
// 

// "Out of Time" a small game about choices of your life, live your life to the fullest before you run out of time


using System.ComponentModel;

Console.WriteLine("OUT OF TIME");
Console.ReadLine();

Console.WriteLine("You open your eyes and are met with white, endless white. You don't know where you find yourself, it's no place you've ever been before. You've somehow found yourself in a void white that vaugely resembles a hallway and you're not quite sure what to do now. It's at this moment that you're struck with the realisation that you have no body, somehow you're just a floating black orb. Oh well, that's fine, just another odd thing to put on the list. It's best to just ignore all of the oddness and just continue on with your life, and that leaves you with the question, what do you do next? There are only really two choices though, isn't there?");
Console.WriteLine("The hallway only has two ways to go, forward into the never ending white passage or back towards a grey area. Which do you choose? Forwards, Backwards or something else?");

String a = Console.ReadLine().ToLower();

if (a == "forward" || a == "forwards" || a == "white")
{
    Console.WriteLine("You decide that the best option is too obviously move forwards, you don't want to be one of those people that gets all caught up in the past after all.");
    Console.WriteLine("After a while of drifting forward you come across a fork in the path, something new! How exciting. Choices are always so fun aren't they, it's why you move forwards. On your right you see a passage down into a professional looking room, in the center is a group of other black orbs all wearing ties, the orbs seem to be gathered around a water cooler discussing something. On your left you see a passage down into a comfortable looking room, in the middle of the room you spot a pink orb floating around the room in a joyous mood.");
    Console.WriteLine("You have two choices now, do you go left towards the pink orb or do you go right towrds the group of orbs? Left, Right or something else?");
    String b1 = Console.ReadLine().ToLower();
    if (b1 == "pink" || b1 == "pink orb" || b1 == "left")
    {
        Console.WriteLine("You decide to move to the left, into the comfy looking room with the pink orb. In front of you is now the Pink Orb wiggling around as if imitating dance, the Pink Orb then takes notice of your prescence and immediately bounces up to you. The Pink Orb proceeds to dance around you seemingly inviting you to come with it, inexperienced you're afraid that you'll mess up but you join the Pink Orb either way and it's fun. You and the Pink Orb bounce around all day until you're tired, it's fun and you no doubt want to do it again, but you should probably take a break, so you stop. You continue to watch as the Pink Orb dances around you and you start wondering, if you can imitate dance in your orb body could you then also imitate other actions? You ponder the question for a second, so deep in thought that the Pink Orb notices and stops dancing. After your thinking you've come to two conclusions and now that the Pink Orb stopped dancing, you could try your imitation on it");
        Console.WriteLine("The two actions you've come to think of are to either kiss the Pink Orb or to punch it. You could try to kiss it, as awkard as it may be or you could be hostile and punch it. Do you kiss it, punch it or think of something else?");
        String c1 = Console.ReadLine().ToLower();
        if (c1 == "kiss" || c1 == "kiss it")
        {
            Console.WriteLine("Yeah, that's probably the best choice. Being hostile to someone you don't know isn't really right, so you decide to go with the reasonable and peaceful option and you kiss it. Although it's less of a kiss and more of smoshing your Orb body up against it's Orb body, though it did seem to have the desired effect as the Pink Orb seemed startled before becoming embarassed, it squirmed in place as it quickly became a lighter pink. It then suddenly gave you a peek back before shying away again. You bounced up and down a little imitating a chuckle as you kissed it again and this time it kissed back, the both of you held it for as long as you could. You could get used to this you decided, sure you didn't explore this new world, sure you didn't attempt brave adventurers, but you're happy. Before you knew it years had passed and you had stayed with the Light Pink Orb through out it all, it made you happy after all, not to mention you had balls now, small tiny little Black and Pink balls that you would've called kids back where you're from. You're living the dream, what more could you want, what more could you have than this happiness?");
            Console.ReadLine();
            Console.WriteLine("The End");
            Console.WriteLine("Ending 1/4 - True Love <3");
        }
        else if (c1 == "punch" || c1 == "punch it")
        {
            Console.WriteLine("Kiss it? Nah, no way you'd ever do somethin that embarassin the obvious choice is to teach it who's boss. You imitate a punch as you slam your body into theirs, the Pink Orb seems shocked as it's pushed back a bit. For a second it stands still trying to process what you just did and it pisses you off, here you are showing that pathetic excuse of an Orb who's boss and it doesn't even react? You punch it again and again, you go to do it once more but stop to see if it'll react now. The Pink Orb flinches away afraid, shaking as it cried, or atleast imitated crying. That's good, pinky understands it's place then. You throw your body forward in a faux punch just to get the satisfaction of watching it squirm again and as you do Pinky flinches away once more as her colour turns into a darker pink. What's that supposed to be? Intimidation? Distraction? Whatever it is, it just pisses you off even more, so you punch that pinky again, and again, and again, and again, and again, and again, and again, and again, and again, and again, and again, and again, and again, and again, and again, and again, and again, and again and you do it one finally time. Suddenly you realise it been a few years, you've been beating Pinky for years just because of a minor annoyance. And you didn't just beat it, that much is obvious from the red cubes on the floor. There is no denying that it's her blood and she isn't alive anymore because of your abuse. The white wall bursts open as a squad of Blue Orbs storm in and force you to the ground. You're never going to hurt anyone ever again, that's for sure");
            Console.ReadLine();
            Console.WriteLine("The End");
            Console.WriteLine("Ending 2/4 - Abusive Wrath");
        }
        else
        {
            Console.WriteLine("No. No, no, no. Neither of those are good ideas, one would assault the other would be sexual assault so you should probably think of something else. So that's what you do, you go back to thinking. The Pink Orb notices that you've gone back to thinking and is bored of waiting so she hops before going back to wiggling a dance in the middle of the room. Her movements were mesmerising, enticing, enchanting, other adjectives and you could do nothing but watch, but eventually you came up with another idea so you moved forward to test it out... but you didn't move, you couldn't move, you were to entranced watching HER. And you watched her, you watched her move, you watched her bounce, you watched her so intensely that she started getting uncomfortable. Eventually the she got a bit tired so she stopped dancing, your anger flared a bit, why'd she have to stop? She squirmed uncomfortable as you stared at her, eventually she just ran off, but you wouldn't let her get away that easy. So you followed her home, and you watched her while she didn't know. She would be fine without, she was the one who had invited you to dance, you were destined for each other, there was no other explanation! You watched her for years and years, but one day you saw her dancing with another Orb, how could she- how could she do this to you?! That night you broke into her place and you made her apart of you, forever. Sure some weird Blue Orbs had taken you away, and sure they were tying you down to a chair connected to electrical wiring, but that didn't matter, because SHE WAS ALL YOURS FOREVER! No, matter what anyone did");
            Console.ReadLine();
            Console.WriteLine("The End");
            Console.WriteLine("Dead End 2/5 - Deprived Lust");
        }
    }
    else if (b1 == "group"||b1 == "black orbs"||b1 == "right"||b1 == "group of orbs")
    {
        Console.WriteLine("");
        Console.WriteLine("");
        String c2 = Console.ReadLine().ToUpper();
        if (c2 == "WORK HARD")
        {
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("The End");
            Console.WriteLine("Ending 2/4 - 'Happy' Millionaire");
        }
        else
        {
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("The End");
            Console.WriteLine("Dead End 3/5 - Buried in Work");
        }
    }
}

else if (a == "backwards"||a == "backward"||a == "back"||a == "grey"||a == "grey area")
{
    Console.WriteLine();
    String b2 = Console.ReadLine().ToLower();
    if (b2 == "Blank")
    {
        Console.WriteLine("");
        Console.WriteLine("");
        String c3 = Console.ReadLine().ToLower();
        if (c3 == "blank")
        {
            Console.WriteLine("");
Console.ReadLine();
Console.WriteLine("The End");
Console.WriteLine("Ending 4/4 - Stuck in the Past");
        }
        else
        {
            Console.WriteLine("");
Console.ReadLine();
Console.WriteLine("The End");
Console.WriteLine("Dead End 4/5 - Joy from the Past");
        }
    }
    else if (b2 == "blanker")
    {
        Console.WriteLine("");
        Console.WriteLine("");
        String c4 = Console.ReadLine().ToLower();
        if (c4 == "blank")
        {
            Console.WriteLine("");
Console.ReadLine();
Console.WriteLine("The End");
Console.WriteLine("Ending 4/4 - Stuck in the Past");
        }
        else
        {
            Console.WriteLine("");
Console.ReadLine();
Console.WriteLine("The End");
Console.WriteLine("Dead End 5/5 - End of the Line");
        }
    }
}

else
{
Console.WriteLine("");
Console.ReadLine();
Console.WriteLine("The End");
Console.WriteLine("Dead End 1/5 - No Time");
}


    Console.WriteLine();
// if (a== blank)

Console.ReadLine();