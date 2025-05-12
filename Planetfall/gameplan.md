//Main menu
//
//-New game
//-Load game
//-Lore
//-Exit game

//---------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------

//New game
//-choose faction
//-set difficulty
//-choose rounds preset

//---------------------------------------------------------------------------------------

//Load game
//-json serialization

//---------------------------------------------------------------------------------------

//Wiki
//-how to play
//-outfits
//-resources
//-lore

//---------------------------------------------------------------------------------------

//Exit game



//---------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------


//game

//round menu "situation room"
//
//round 1/x out of [rounds preset]
//overview
//
//-diplomacy
//-battle
//-end round


//overview
//-indar (%) (bonus:)           bonus if major facilities have been captured (tech plants, biolabs, amp stations)
//-esamir(%) (bonus:)
//-amerish(%) (bonus:)
//-nanites(n)
//-outifts(n)
//(side objective available)

//---------------------------------------------------------------------------------------

//diplomacy
//-side objectives
//-request reinforcements
//back to situation room

//side objectives
//
//current objective:"x"
//-select objective
//-abort objective

//select objective
//
//-objective1 [reward1]
//-objective2 [reward2]

//---------------------------------------------------------------------------------------

//request reinforcements
//
//-assume direct command of reinforcements (choose new outfit to add)(more expensive)
//-give a war goal to the allied commander (choose continent, support added to a random lane every turn for X turns)


//---------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------

//battle
//-upgrade outfits
//-battle plan
//-back to situation room

//upgrade outfits
//select outfit
//
//-outfit1[lvl]
//-outfit2[lvl]
//...

//outfitX
//
//upgrades available (1 every lvl)
//-AA munitions (CE vs AIR+)
//-MAX suits (CE vs ALL+)
//-advanced mobile spawnpoints (TEN vs ALL+)
//
//specialisations (unlocked at lvl3)
//-mass mobilisation (infantry focus + keep prior upgrades)
//-lodestar tank air drops (armor focus)
//-top gun retraining (air focus)
//-fast redeploy (increases uses + keep prior upgrades)
//
//upgrades after spec 
//(infantry)
//
//-nanoweave armor (CE and TEN vs INF)
//-faction heavy weapon (lvl5)          Shipments of brand new heavy weapons have arrived at the nearest Warpgate and are ready for pickup. Combat effectiveness vs INFANTRY increases greatly
//-annihilator MANPADS (lvl5)           Combat effectiveness vs AIR increases greatly
//-decimator warheads (lvl5)            Combat effectiveness vs ARM increases
//-steel rain (lvl6)                    Orbital deployment via drop pods has been granted to this distinguished outfit. Tenacity vs ALL increases & CE vs AIR increases
//
//
//(armor)
//-terminal override(lvl4)              Infiltrators lift the restictions of needing tech plants to deploy MBTs at friendly terminals. Tenecity vs ALL increases
//-new artillery computers (lvl5)       Combat effectiveness vs INFANTRY increases
//-faction specific mbt ability (lvl5)  TR:CE vs INF increases / NC:CE vs ARM increases / VS:Tenacity vs INF and ARM increases
//-first gen skyguards (lvl5)           Advanced AA weaponry for the lightning light tank plattform have passed the first round of testing and are ready to use for field testing. Tenacity vs AIR increases slightly
//-harasser light vehicle (lvl6)        Combat effectiveness vs INFANTRY and ARMOR increases
//
//
//(air)
//-fire suppression modules (lvl4)      Tenacity vs ALL increases
//-tank buster guns (lvl5)              Combat effectiveness vs ARMOR increases greatly
//-modified hornet missiles (lvl5)      CE vs ARM and AIR increases greatly & CE vs Infantry decreases
//-coyote rear guns (lvl5)              CE vs AIR increases greatly 
//-galaxy gunships (lvl6)               Tenacity vs INFANTRY and ARMOR increases greatly
//
//
//(fast redeploy / qrf)
//-fighter escorts (lvl4)               TEN vs AIR +
//-stealth deployment (lvl5)            TEN vs ALL +
//-valkyrie air transport (lvl5)        CE vs INF +
//-pre-deployed sunderers (lvl5)        Use +1
//-extended fuel tanks (lvl6)           Use +1
//
//




//battle plan
//
//choose continent
//choose lane
//assign outfit
//(warning if unassigned outfits)

//choose continent
//-indar
//-esamir
//-amerish

//choose lane (indar)
//-north (open desert)
//-central (the crown)[bonus INF]
//-south (deep canyons)

//choose lane (esamir)
//-north (open plains)
//-central (eisa tech)[bonus ARM]
//-south (frozen river)

//choose lane (amerish)
//-north (mountains)
//-central (the ascent)[bonus AIR]
//-south (small ditches and hills)

//---------------------------------------------------------------------------------------

//end round
//
//WARNING if unassigned outfits
//NOTICE if no side objective selected
//
//battle simulation based on assigned outfits to lanes
//simple rock paper scissors mechanic: AIR < ARM < INF < AIR
//though balance can be upset with upgrades and numbers
//
//after battle simulation
//recap results and calculate points gained or lost
//points are gained by: capturing territory, capturing warpgates, capturing continents, destroying enemy outfits
//points are lost by: losing territorry (increased if player didnt put up any resistance, stackable to avoid spamming only one lane and to give incentive to defend territory), losing own warpgates (will also result in being locked out of the continent for a set ammount of turns), fully losing outfits

