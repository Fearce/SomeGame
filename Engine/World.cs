using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        private static readonly List<Item> _items = new List<Item>();//aa
        private static readonly List<Monster> _monsters = new List<Monster>();
        private static readonly List<Quest> _quests = new List<Quest>();
        private static readonly List<Location> _locations = new List<Location>();

        public const int UNSELLABLE_ITEM_PRICE = -1;

        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;

        public const int MONSTER_ID_RAT = 1000;
        public const int MONSTER_ID_SNAKE = 2000;
        public const int MONSTER_ID_GIANT_SPIDER = 300;

        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 90;



        static World()
        {
          //  PopulateAct1();
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }


        public const int ITEM_ID_HAND_AXE = 11;
        public const int ITEM_ID_DOUBLE_AXE = 12;
        public const int ITEM_ID_DEN_BLOOD = 13;

        public const int MONSTER_ID_FALLEN = 1;
        public const int MONSTER_ID_QUILL_RAT = 2;
        public const int MONSTER_ID_ZOMBIE = 3;

        public const int QUEST_ID_CLEAR_DEN_OF_EVIL = 3;

        public const int LOCATION_ROGUE_ENCAMPMENT = 9;
        public const int LOCATION_BLOOD_MOOR = 10;
        public const int LOCATION_BLOOD_MOOR1 = 11;
        public const int LOCATION_BLOOD_MOOR2 = 12;
        public const int LOCATION_BLOOD_MOOR3 = 13;
        public const int LOCATION_BLOOD_MOOR4 = 14;
        public const int LOCATION_BLOOD_MOOR5 = 15;
        public const int LOCATION_BLOOD_MOOR6 = 16;
        public const int LOCATION_BLOOD_MOOR7 = 17;
        public const int LOCATION_BLOOD_MOOR8 = 18;
        public const int LOCATION_BLOOD_MOOR9 = 19;
        public const int LOCATION_BLOOD_MOOR10 = 20;
        public const int LOCATION_BLOOD_MOOR11 = 21;
        public const int LOCATION_BLOOD_MOOR12 = 22;
        public const int LOCATION_DEN_OF_EVIL = 23;
        public const int LOCATION_DEN_OF_EVIL1 = 24;
        public const int LOCATION_DEN_OF_EVIL2 = 25;
        public const int LOCATION_DEN_OF_EVIL3 = 26;
        public const int LOCATION_DEN_OF_EVIL4 = 27;
        public const int LOCATION_DEN_OF_EVIL5 = 28;
        public const int LOCATION_DEN_OF_EVIL6 = 29;
        public const int LOCATION_DEN_OF_EVIL7 = 30;
        public const int LOCATION_DEN_OF_EVIL8 = 31;
        public const int LOCATION_DEN_OF_EVIL9 = 32;
        public const int LOCATION_DEN_OF_EVIL10 = 33;
        public const int LOCATION_DEN_OF_EVIL11 = 34;
        public const int LOCATION_DEN_OF_EVIL12 = 35;
        public const int LOCATION_DEN_OF_EVIL13 = 36;
        public const int LOCATION_DEN_OF_EVIL14 = 37;


        private static void PopulateItems()
        {
            _items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5, UNSELLABLE_ITEM_PRICE));
            _items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 3, 10, 8));
            _items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 5, 3));
            _items.Add(new Weapon(ITEM_ID_HAND_AXE, "Hand Axe", "Hand Axes", 1, 6, 5));
            _items.Add(new Weapon(ITEM_ID_DOUBLE_AXE, "Double Axe", "Double Axes", 2, 10, 8));
            _items.Add(new Item(ITEM_ID_DEN_BLOOD, "Vial of Den blood", "Vials of Den blood", 1));
        }

        private static void PopulateMonsters()
        {
            //Act 1 Monsters
            Monster fallen = new Monster(MONSTER_ID_FALLEN, "Fallen", 5, 3, 3, 3, 3);
            fallen.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HAND_AXE), 14, false));

            Monster quillRat = new Monster(MONSTER_ID_QUILL_RAT, "Quill Rat", 6, 5, 4, 4, 4);
            fallen.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HAND_AXE), 14, false));

            Monster zombie = new Monster(MONSTER_ID_ZOMBIE, "Zombie", 8, 8, 5, 6, 6);
            fallen.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HAND_AXE), 14, false));

            _monsters.Add(fallen);
            _monsters.Add(quillRat);
            _monsters.Add(zombie);
        }

        private static void PopulateQuests()
        {
            //Act 1 Quests
            Quest clearDenOfEvil =
                new Quest(
                    QUEST_ID_CLEAR_DEN_OF_EVIL,
                    "Clear the Den of Evil",
                    "There is a place of great evil in the wilderness. Kashya's Rogue scouts have informed me that a cave nearby is filled with shadowy creatures and horrors from beyond the grave\n I fear that these creatures are massing for an attack against our encampment. If you are sincere about helping us, find the dark labyrinth and destroy the foul beasts.\n May the Great Eye watch over you.", 100, 100);

            clearDenOfEvil.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_DEN_BLOOD), 30));
            clearDenOfEvil.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);
            _quests.Add(clearDenOfEvil);
        }

        private static void PopulateLocations() //add new locations here with added monsters&quests&stuff and add vendors attached
        {
            // Create each location
            //Act 1 Locations
            string BmoreText = "You see various monsters populating a large green field.";

             Location home = new Location(LOCATION_ID_HOME, "The Rogue Encampment", "You're in a makeshift fortress set up by the survivors from the Sisterhood of the Sightless Eye.");
            home.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_DEN_OF_EVIL);
            Vendor akara = new Vendor("Akara");
            akara.AddItemToInventory(ItemByID(ITEM_ID_HEALING_POTION), 5);
            akara.AddItemToInventory(ItemByID(ITEM_ID_DOUBLE_AXE), 3);

            home.VendorWorkingHere = akara;

            Location bloodMoor = new Location(LOCATION_BLOOD_MOOR, "Blood Moor", $"{BmoreText}\nThere is a place of great evil in the wilderness. Kashya's Rogue scouts have informed me that a cave nearby is filled with shadowy creatures and horrors from beyond the grave\n I fear that these creatures are massing for an attack against our encampment. If you are sincere about helping us, find the dark labyrinth and destroy the foul beasts.\n May the Great Eye watch over you.");
            BloodMoorMonsters(bloodMoor);

            Location bloodMoor1 = new Location(LOCATION_BLOOD_MOOR1, "Blood Moor", BmoreText);
            BloodMoorMonsters(bloodMoor1);

            Location bloodMoor2 = new Location(LOCATION_BLOOD_MOOR2, "Blood Moor", BmoreText);
            BloodMoorMonsters(bloodMoor2);

            Location bloodMoor3 = new Location(LOCATION_BLOOD_MOOR3, "Blood Moor", BmoreText);
            BloodMoorMonsters(bloodMoor3);

            Location bloodMoor4 = new Location(LOCATION_BLOOD_MOOR4, "Blood Moor", BmoreText);
            BloodMoorMonsters(bloodMoor4);

            Location bloodMoor5 = new Location(LOCATION_BLOOD_MOOR5, "Blood Moor", BmoreText);
            BloodMoorMonsters(bloodMoor5);

            Location bloodMoor6 = new Location(LOCATION_BLOOD_MOOR6, "Blood Moor", BmoreText);
            BloodMoorMonsters(bloodMoor6);

            Location bloodMoor7 = new Location(LOCATION_BLOOD_MOOR7, "Blood Moor", BmoreText);
            BloodMoorMonsters(bloodMoor7);

            Location bloodMoor8 = new Location(LOCATION_BLOOD_MOOR8, "Blood Moor", BmoreText);
            BloodMoorMonsters(bloodMoor8);

            Location bloodMoor9 = new Location(LOCATION_BLOOD_MOOR9, "Blood Moor", BmoreText);
            BloodMoorMonsters(bloodMoor9);

            Location bloodMoor10 = new Location(LOCATION_BLOOD_MOOR10, "Blood Moor", BmoreText);
            BloodMoorMonsters(bloodMoor10);

            Location bloodMoor11 = new Location(LOCATION_BLOOD_MOOR11, "Blood Moor", BmoreText);
            BloodMoorMonsters(bloodMoor11);

            Location bloodMoor12 = new Location(LOCATION_BLOOD_MOOR12, "Blood Moor", BmoreText);
            BloodMoorMonsters(bloodMoor12);

            // Link the locations together

            // Link the locations together
            home.LocationToNorth = bloodMoor;
            bloodMoor.LocationToNorth = bloodMoor4;
            bloodMoor.LocationToEast = bloodMoor2;
            bloodMoor.LocationToSouth = home;
            bloodMoor.LocationToWest = bloodMoor1;

            bloodMoor1.LocationToNorth = bloodMoor5;
            bloodMoor1.LocationToEast = bloodMoor;

            bloodMoor2.LocationToNorth = bloodMoor3;
            bloodMoor2.LocationToWest = bloodMoor;

            bloodMoor3.LocationToNorth = bloodMoor8;
            // bloodMoor3.LocationToEast = bloodMoor2; //den of evil
            bloodMoor3.LocationToSouth = bloodMoor2;
            bloodMoor3.LocationToWest = bloodMoor4;

            bloodMoor4.LocationToNorth = bloodMoor7;
            bloodMoor4.LocationToEast = bloodMoor3;
            bloodMoor4.LocationToSouth = bloodMoor;
            bloodMoor4.LocationToWest = bloodMoor5;

            bloodMoor5.LocationToNorth = bloodMoor6;
            bloodMoor5.LocationToEast = bloodMoor4;
            bloodMoor5.LocationToSouth = bloodMoor1;

            bloodMoor6.LocationToNorth = bloodMoor10;
            bloodMoor6.LocationToEast = bloodMoor7;
            bloodMoor6.LocationToSouth = bloodMoor5;

            bloodMoor7.LocationToNorth = bloodMoor9;
            bloodMoor7.LocationToEast = bloodMoor8;
            bloodMoor7.LocationToSouth = bloodMoor4;
            bloodMoor7.LocationToWest = bloodMoor6;

            bloodMoor8.LocationToSouth = bloodMoor3;
            bloodMoor8.LocationToWest = bloodMoor7;

            bloodMoor9.LocationToSouth = bloodMoor7;
            bloodMoor9.LocationToWest = bloodMoor10;

            bloodMoor10.LocationToEast = bloodMoor9;
            bloodMoor10.LocationToSouth = bloodMoor6;
            bloodMoor10.LocationToWest = bloodMoor11;

            bloodMoor11.LocationToEast = bloodMoor10;
            bloodMoor11.LocationToWest = bloodMoor12;

            //    bloodMoor12.LocationToNorth = bloodMoor10; //cold plains
            bloodMoor12.LocationToEast = bloodMoor11;

            // Add the locations to the static list
            _locations.Add(home);
            _locations.Add(bloodMoor);
            _locations.Add(bloodMoor1);
            _locations.Add(bloodMoor2);
            _locations.Add(bloodMoor3);
            _locations.Add(bloodMoor4);
            _locations.Add(bloodMoor5);
            _locations.Add(bloodMoor6);
            _locations.Add(bloodMoor7);
            _locations.Add(bloodMoor8);
            _locations.Add(bloodMoor9);
            _locations.Add(bloodMoor10);
            _locations.Add(bloodMoor11);
            _locations.Add(bloodMoor12);
        }

        private static void BloodMoorMonsters(Location bloodMoor)
        {
            bloodMoor.AddMonster(MONSTER_ID_FALLEN, 60);
            bloodMoor.AddMonster(MONSTER_ID_QUILL_RAT, 37);
            bloodMoor.AddMonster(MONSTER_ID_ZOMBIE, 50);
        }

        public static Item ItemByID(int id)
        {
            return _items.SingleOrDefault(x => x.ID == id);
        }

        public static Monster MonsterByID(int id)
        {
            return _monsters.SingleOrDefault(x => x.ID == id);
        }

        public static Quest QuestByID(int id)
        {
            return _quests.SingleOrDefault(x => x.ID == id);
        }

        public static Location LocationByID(int id)
        {
            return _locations.SingleOrDefault(x => x.ID == id);
        }
    }
}