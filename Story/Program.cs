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

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Title = "OUT OF TIME - Game";


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
    else if (b1 == "group" || b1 == "black orbs" || b1 == "right" || b1 == "group of orbs")
    {
        Console.WriteLine("You decide to move to the right, into the professional area with all the other Black Orbs. All the other Black Orbs bounce up in joy at seeing another face, they quickly come over to you and hand you a cup filled with a bunch of triangles. They then start to bounce up and down as if chanting for you to chug down the triangles and because of peer pressure you do. The triangles slide down you non-existant throat cutting up your insides, it's painful but somehow liberating. The other Orbs jump in joy as they put a tie on you and give you another cup, everyone in the room chugs down on cups of triangles, the pain taking away the boredom of life. You could get used to this you decided. And then it was over. A loud a bell sounded out across the room as everorb seemed to deflate and slump their way behind a desk, you a little confused just stood in the center of the room holding an empty cup. Suddenly a crack is heard as you turn around and see a larger Black Orb with a red tie and mustache beat one of the other Black Orbs. The Mustached Black Orb seemed to be yelling at the smaller Orb before picking it up and throwing it out of a window. The mustached Orb then turned to you and seemed to gesture for you to take the other Black Orbs place, your of course hesitant to do so but one slap from the Mustached Orb and your forced into the other Black Orbs seat. The Mustached Orb then slammed down a mountain of paperwork as it pulled out a bat and lightly hit it against the desk, telling you to work hard. Still unsure of what was happening you decided that it was time to leave but before you could even stand up yoor smacked across the face with the bat as the Moustached Orb places down even mor paperwork on your desk.");
        Console.WriteLine("What do you do? WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD, WORK HARD OR something els- WORK HARD.");
        String c2 = Console.ReadLine().ToUpper();
        if (c2 == "WORK HARD")
        {
            Console.WriteLine("WORK HARD, oh, you'll work hard alright, you'll work so hard that one day you'll be the boss of that Mustached Orb. And so you work and work and work, you work hard, you work long, you do everything perfectly and eventually you get promoted. You start earning more money and use it to better yourself so you can make even more money. After a while you've earned enough money that you quit your job and start your own buisness, and you work hard, day and night, you work and work and work on your buisness until it's booming, eventually your company gets so big that you now own the place you used to work at and you are the Mustached Orb's boss, although the Orb doesn't have a Mustache anymore since you took it for yourself. But this isn't enough, you need more. So you continue to work hard and make your buisness larger but eventually you run out of room to grow, you're buisness is so large that it can't grow any larger. The only solution is to make the room bigger. You cut down forests, demolish peoples homes and you keep working hard until your buisness cover's the entire world, you have more money than you could ever comprhend. You did it. Right? You reached the top, you have every Orb's dream... you have to be happy right? WIth everything you own, with all the Orb's you own, you're happy... right? Or are you just throwing the world into a black hole that is your heart... Does anything matter anymore?... You own everything. You're 'happy'");
            Console.ReadLine();
            Console.WriteLine("The End");
            Console.WriteLine("Ending 2/4 - 'Happy' Millionaire");
        }
        else
        {
            Console.WriteLine("Hell no! You aren't going to work as this a-holes slave! The Mustached Orb notices you rebelling against his order, so he hits you over the head with the bat again and throws down another pile of paperwork. This process happens again, and again, and again, eventually you just give in and start digging away at the mountains of paperwork, but they don't budge. Sometimes you get breaks and all you do is chug down triangles, letting the pain come so you can feel something. This is your life now, you work barely getting through the mountains paperwork before the Mustached Orb throws down another pile of paperwork, then you get back to working before gettin a small break where you waste it all just chugging down some triangles, before getting right back to work. Work, work, work...work...work......work......... Eventually the papers stack up to the ceiling, and then they surround you. There is so much of it that you can't move, you can't see, you can't breath... You drown in the mountains of work that you still need to do... What's even the point anymore?");
            Console.ReadLine();
            Console.WriteLine("The End");
            Console.WriteLine("Dead End 3/5 - Buried in Work");
        }
    }
    else
    {
    Console.WriteLine("You stand in the void you've found yourself in, stuck with indecision of what to do and suddenly you hear the terrifying rumbling of some creature in the distance. You have no idea what it is but you know you don't what to encounter it, so you start running but no matter how far you run the creature is rapidly gaining on you. After running for who knows how long, you see it a void of Black, a creature which is end itself. Death awaits you, your out of time, instead of thinking of what to do for your whole life, you should've just done something, anything. There was so much you wanted to do, get a job, have a wife, maybe get some kids, but you waste it. You wasted it all and now you're completely out of time.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("The white void around you turns a deep black, absolute black, no colour, no nuance, no shade. Just absolute nothing, and soon you will became another part of that infinte nothingness, having done nothing with your life. You suck, you're grabage, you should never have lived, no friends, no job, no education, no love, no ANYTHING. YOU ARE NOTHING... and you have no more time.");
    Console.ReadLine();
    Console.WriteLine("The End");
    Console.WriteLine("Dead End 1/5 - No More Time");
    }
}

else if (a == "backwards" || a == "backward" || a == "back" || a == "grey" || a == "grey area" || a == "gray" || a == "gray area")
{
    Console.WriteLine("You decide that it's probably better to head backwards, who knows what would happen if you went forwards, I mean you could get yourself killed!");
    Console.WriteLine("After a while of floating down the grey hall you eventually start comming across a myriad of bubbles swishing all around you, colors surround you giving you releif of not seeing just white, black or grey. You bounce around as all the colors of the rainbow surround you when you accidently brush up against one of the bubbles and as you do you get a flashback to a memory long past. A happy memory from when you were a child ran through your mind as the bubble proceed to pass by you and then the memory left as well. Shocked and intrigued you start brushing up against more bubbles and to your surprise more memories start playing out in front of your eyes. It's like a movie theater where you can choose to go back and watch all of your past memories, although eventually you came across a fork in the road, one path leads into a yellow room and the other leads down into a blue room");
    Console.WriteLine("Where do you go? Do you follow the Yellow path or the Blue Path?");
    String b2 = Console.ReadLine().ToLower();
    if (b2 == "yellow"||b2 == "yellow path"||b2 == "the yellow path")
    {
        Console.WriteLine("You decide to continue down the yellow path, it does feel a lot more joyous than the gloomy blue path. As you follow the yellow brick road you see a myraid of bubbles flock towards you, they all rub up against you as you re-experience all of your happiest moments, you continue floating down the path filled with joy's from the past. But eventually they end and you've reached the end of the road, finding yourself right back at the beginning. Going back through your old memories was great, but is it really already over? You could go through again but you'd just be seeing the same thing's again, although you could go down the other path see and what that's about");
        Console.WriteLine("Do you go down the other path or do you try and think of something else?");
        String c3 = Console.ReadLine().ToLower();
        if (c3 == "go down the other path"||c3 == "other path"||c3 == "the other path"||c3 == "blue path"||c3 == "the blue path")
        {
            Console.WriteLine("You've already seen all of the memories of the first path so you might as well watch the others on the second path, and so you do you go down the other path, touch all the bubbles of that path and experience those memories, they are different from the one's on the first path, they make you feel different things, they're from different moment's of your life... but their all just memories... thing's you've experienced before. What are you doing here? You had a life ahead of you, you were given the choice to move forward and yet you decided to just dwell on the past... and now? you've gone through all your memories, and the bliss of the past was so short but it took so long... it's been years, you've wasted years on remembering the past and now it didn't even do anything for you. You could've made new memoriesm instead you got hung up on trying to remember waht had already past. And now you're nothing, no love, no job, no nothing, just a sad pathetic loser... you need help, but no one is going to give you it because you made your decisions");
            Console.ReadLine();
            Console.WriteLine("The End");
            Console.WriteLine("Ending 4/4 - Stuck in the Past");
        }
        else
        {
            Console.WriteLine("As you think over something else to do, you start to drift back to the yellow road. You're taken along the path as you experience the memories again. And then again. and again... and again. They aren't as happy anymore though, they're just the same memories over and over again, eventually you stop wanting to watch some of them because of how boring they got. And the amount you watched became fewer, going from hundreds to only 100, from 100 to 50, from 50 to 25, from 25 to 10, from 10 to 5, and then 4, then 3, then 2, and then 1, although before long you couldn't even watch a single one... and then you found something strange. Lying on the ground was a line. You picked it up a bit curious and then you accidentally poked yourself with it... and it felt amazing, all of those memories that lost their touch regained the happiness in them. And then it ended, so you got more lines and you took them over and over again until their effects lessened... so you started getting arrows and rectangles and cylinders and triangles, you even started taking circles of all things. And they gave you that bit of joy you searched for, but it always ended. And then it ended forever. You went to far, you took to many, you're body couldn't take it anymore. And now you're no longer alive, nothing but a junkie who overdozed on circles.");
            Console.ReadLine();
            Console.WriteLine("The End");
            Console.WriteLine("Dead End 4/5 - Joy from the Past");
        }
    }
    else if (b2 == "blue"||b2 == "blue path"||b2 == "the blue path")
    {
        Console.WriteLine("You decide to continue down the blue path, it does feel a lot calmer than the in your face yellow path. As you follow the blue brick road you see a myraid of bubbles flock towards you, they all rub up against you as you re-experience all of your worst moments, maybe the blue path wasn't the best idea. As you continue floating down the path you're bomboarded with sad memories, bad memories everything you hate about yourself and your life. But eventually they end and you've reached the end of the road, finding yourself right back at the beginning. Going back through your old memories was... something, but is it really already over? You could go through again but you'd just be seeing the same thing's again, although you could go down the other path and see what that's about");
        Console.WriteLine("Do you go down the other path or do you try and think of something else?");
        String c4 = Console.ReadLine().ToLower();
        if (c4 == "go down the other path"||c4 == "other path"||c4 == "the other path"||c4 == "yellow path"||c4 == "the yellow path")
        {
            Console.WriteLine("You've already seen all of the memories of the first path so you might as well watch the others on the second path, and so you do you go down the other path, touch all the bubbles of that path and experience those memories, they are different from the one's on the first path, they make you feel different things, they're from different moment's of your life... but their all just memories... thing's you've experienced before. What are you doing here? You had a life ahead of you, you were given the choice to move forward and yet you decided to just dwell on the past... and now? you've gone through all your memories, and the bliss of the past was so short but it took so long... it's been years, you've wasted years on remembering the past and now it didn't even do anything for you. You could've made new memoriesm instead you got hung up on trying to remember waht had already past. And now you're nothing, no love, no job, no nothing, just a sad pathetic loser... you need help, but no one is going to give you it because you made your decisions");
            Console.ReadLine();
            Console.WriteLine("The End");
            Console.WriteLine("Ending 4/4 - Stuck in the Past");
        }
        else
        {
            Console.WriteLine("As you think over something else to do, you start to drift back to the blue road. You're taken along the path as you experience the memories again. And then again. and again... and again. Watching them over and over again you realise how awful your life is, how much you suck as a person. All you do is use people, you don't have a job so you don't earn money, instead you just leech of your parents and friends, but all of them are getting fed up with! what is wrong with!? Why can't you be a half-decent person like everyone else? Before long you came to a realisation, you're nothing, you mean absolutely nothing because you made nothing of yourself. So if you don't mean anything and nobody cares about you, why should you exist? Why should you live... and that's the thing, you shouldn't, you were a mistake by the universe so why not do something right and fix that mistake. Instead of wasting away while bringin down everyone around you, you could be the hero and the greatest mistake in all of mankind, yourself. It's not long before you find yourself at the edge of the edge of the disc that is the world, you draw a line off of the edge and start slowly floating along that line. You can't help but gain a smile as you cross the edge and finally fall over into the void, now you're truly nothing like you were meant to be.");
            Console.ReadLine();
            Console.WriteLine("The End");
            Console.WriteLine("Dead End 5/5 - End of the Line");
        }
    }
    else
    {
    Console.WriteLine("You stand in the void you've found yourself in, stuck with indecision of what to do and suddenly you hear the terrifying rumbling of some creature in the distance. You have no idea what it is but you know you don't what to encounter it, so you start running but no matter how far you run the creature is rapidly gaining on you. After running for who knows how long, you see it a void of Black, a creature which is end itself. Death awaits you, your out of time, instead of thinking of what to do for your whole life, you should've just done something, anything. There was so much you wanted to do, get a job, have a wife, maybe get some kids, but you waste it. You wasted it all and now you're completely out of time.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("The white void around you turns a deep black, absolute black, no colour, no nuance, no shade. Just absolute nothing, and soon you will became another part of that infinte nothingness, having done nothing with your life. You suck, you're grabage, you should never have lived, no friends, no job, no education, no love, no ANYTHING. YOU ARE NOTHING... and you have no more time.");
    Console.ReadLine();
    Console.WriteLine("The End");
    Console.WriteLine("Dead End 1/5 - No More Time");
    }
}

else
{
    Console.WriteLine("You stand in the void you've found yourself in, stuck with indecision of what to do and suddenly you hear the terrifying rumbling of some creature in the distance. You have no idea what it is but you know you don't what to encounter it, so you start running but no matter how far you run the creature is rapidly gaining on you. After running for who knows how long, you see it a void of Black, a creature which is end itself. Death awaits you, your out of time, instead of thinking of what to do for your whole life, you should've just done something, anything. There was so much you wanted to do, get a job, have a wife, maybe get some kids, but you waste it. You wasted it all and now you're completely out of time.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("The white void around you turns a deep black, absolute black, no colour, no nuance, no shade. Just absolute nothing, and soon you will became another part of that infinte nothingness, having done nothing with your life. You suck, you're grabage, you should never have lived, no friends, no job, no education, no love, no ANYTHING. YOU ARE NOTHING... and you have no more time.");
    Console.ReadLine();
    Console.WriteLine("The End");
    Console.WriteLine("Dead End 1/5 - No More Time");
}


    Console.WriteLine();
// if (a== blank)

Console.ReadLine();