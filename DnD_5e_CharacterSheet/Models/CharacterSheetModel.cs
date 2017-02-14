using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace DnD_5e_CharacterSheet.Models
{
    public class CharacterSheetModel
    {
        #region Character Sheet

        public string CharacterName;
        public string ClassAndLevel;
        public string Background;
        public string PlayerName;
        public string Race;
        public string Alignment;
        public int ExperiencePoints;

        public int Strength = 1;
        public int Dexterity = 1;
        public int Constitution = 1;
        public int Intelligence = 1;
        public int Wisdom = 1;
        public int Charisma = 1;

        public bool StrengthSavingThrowEnabled;
        public bool DexteritySavingThrowEnabled;
        public bool ConstitutionSavingThrowEnabled;
        public bool IntelligenceSavingThrowEnabled;
        public bool WisdomSavingThrowEnabled;
        public bool CharismaSavingThrowEnabled;

        public bool AcrobaticsEnabled;
        public bool AnimalHandlingEnabled;
        public bool ArcanaEnabled;
        public bool AthleticsEnabled;
        public bool DeceptionEnabled;
        public bool HistoryEnabled;
        public bool InsightEnabled;
        public bool IntimidationEnabled;
        public bool InvestigationEnabled;
        public bool MedicineEnabled;
        public bool NatureEnabled;
        public bool PerceptionEnabled;
        public bool PerformanceEnabled;
        public bool PersuasionEnabled;
        public bool ReligionEnabled;
        public bool SleightOfHandEnabled;
        public bool StealthEnabled;
        public bool SurvivalEnabled;

        public int HitPointMaximum;
        public int CurrentHitPoints;
        public int TemporaryHitPoints;
        public int TotalHitDice;
        public string HitDice;

        public bool DeathSaveSuccess1;
        public bool DeathSaveSuccess2;
        public bool DeathSaveSuccess3;
        public bool DeathSaveFailure1;
        public bool DeathSaveFailure2;
        public bool DeathSaveFailure3;

        public string OtherProficienciesAndLanguages;
        public string Equipment;
        public int CopperPieces;
        public int SilverPieces;
        public int ElectrumPieces;
        public int GoldPieces;
        public int PlatinumPieces;

        public string PersonalityTraits;
        public string Ideals;
        public string Bonds;
        public string Flaws;
        public string FeaturesAndTraits;

        public int ProficiencyBonus = 2;
        public int ArmorClass;
        public int Speed;

        public string Weapon1Name;
        public string Weapon1AtkBonus;
        public string Weapon1DamageType;
        public string Weapon2Name;
        public string Weapon2AtkBonus;
        public string Weapon2DamageType;
        public string Weapon3Name;
        public string Weapon3AtkBonus;
        public string Weapon3DamageType;
        public string WeaponNotes;

        #endregion Character Sheet

        #region Background Info

        public int Age;
        public int Height;
        public int Weight;
        public string Eyes;
        public string Skin;
        public string Hair;

        public byte[] CharacterPortrait;

        public string OrganizationName;
        public byte[] OrganizationSymbol;

        public string CharacterBackstory;
        public string AlliesAndOrganizations1;
        public string AlliesAndOrganizations2;
        public string AdditionalFeaturesAndTraits1;
        public string AdditionalFeaturesAndTraits2;
        public string Treasure1;
        public string Treasure2;

        #endregion Background Info

        #region Spellcasting

        public string SpellcastingClass;
        public string SpellcastingAbility;
        public List<string> Cantrips;
        public int Level1SlotsTotal;
        public int Level1SlotsExpended;
        public List<string> Level1Spells;
        public List<bool> Level1SpellExpended;
        public int Level2SlotsTotal;
        public int Level2SlotsExpended;
        public List<string> Level2Spells;
        public List<bool> Level2SpellExpended;
        public int Level3SlotsTotal;
        public int Level3SlotsExpended;
        public List<string> Level3Spells;
        public List<bool> Level3SpellExpended;
        public int Level4SlotsTotal;
        public int Level4SlotsExpended;
        public List<string> Level4Spells;
        public List<bool> Level4SpellExpended;
        public int Level5SlotsTotal;
        public int Level5SlotsExpended;
        public List<string> Level5Spells;
        public List<bool> Level5SpellExpended;
        public int Level6SlotsTotal;
        public int Level6SlotsExpended;
        public List<string> Level6Spells;
        public List<bool> Level6SpellExpended;
        public int Level7SlotsTotal;
        public int Level7SlotsExpended;
        public List<string> Level7Spells;
        public List<bool> Level7SpellExpended;
        public int Level8SlotsTotal;
        public int Level8SlotsExpended;
        public List<string> Level8Spells;
        public List<bool> Level8SpellExpended;
        public int Level9SlotsTotal;
        public int Level9SlotsExpended;
        public List<string> Level9Spells;
        public List<bool> Level9SpellExpended;

        #endregion Spellcasting

        public CharacterSheetModel()
        {
        }

        public static CharacterSheetModel New()
        {
            var model = new CharacterSheetModel();
            model.Cantrips = new List<string>(new string[8]);
            model.Level1Spells = new List<string>(new string[13]);
            model.Level1SpellExpended = new List<bool>(new bool[13]);
            model.Level2Spells = new List<string>(new string[13]);
            model.Level2SpellExpended = new List<bool>(new bool[13]);
            model.Level3Spells = new List<string>(new string[13]);
            model.Level3SpellExpended = new List<bool>(new bool[13]);
            model.Level4Spells = new List<string>(new string[13]);
            model.Level4SpellExpended = new List<bool>(new bool[13]);
            model.Level5Spells = new List<string>(new string[9]);
            model.Level5SpellExpended = new List<bool>(new bool[9]);
            model.Level6Spells = new List<string>(new string[9]);
            model.Level6SpellExpended = new List<bool>(new bool[9]);
            model.Level7Spells = new List<string>(new string[9]);
            model.Level7SpellExpended = new List<bool>(new bool[9]);
            model.Level8Spells = new List<string>(new string[7]);
            model.Level8SpellExpended = new List<bool>(new bool[7]);
            model.Level9Spells = new List<string>(new string[7]);
            model.Level9SpellExpended = new List<bool>(new bool[7]);
            return model;
        }

        public static CharacterSheetModel Deserialize(string json)
        {
            var model = JsonConvert.DeserializeObject<CharacterSheetModel>(json);
            model.makeValid();
            return model;
        }

        public string Serialize()
        {
            makeValid();
            return JsonConvert.SerializeObject(this);
        }

        private void makeValid()
        {
            Cantrips = makeValid(Cantrips, 8);

            Level1Spells = makeValid(Level1Spells, 13);
            Level2Spells = makeValid(Level2Spells, 13);
            Level3Spells = makeValid(Level3Spells, 13);
            Level4Spells = makeValid(Level4Spells, 13);
            Level5Spells = makeValid(Level5Spells, 9);
            Level6Spells = makeValid(Level6Spells, 9);
            Level7Spells = makeValid(Level7Spells, 9);
            Level8Spells = makeValid(Level8Spells, 7);
            Level9Spells = makeValid(Level9Spells, 7);

            Level1SpellExpended = makeValid(Level1SpellExpended, 13);
            Level2SpellExpended = makeValid(Level2SpellExpended, 13);
            Level3SpellExpended = makeValid(Level3SpellExpended, 13);
            Level4SpellExpended = makeValid(Level4SpellExpended, 13);
            Level5SpellExpended = makeValid(Level5SpellExpended, 9);
            Level6SpellExpended = makeValid(Level6SpellExpended, 9);
            Level7SpellExpended = makeValid(Level7SpellExpended, 9);
            Level8SpellExpended = makeValid(Level8SpellExpended, 7);
            Level9SpellExpended = makeValid(Level9SpellExpended, 7);
        }

        private static List<T> makeValid<T>(List<T> list, int desiredLength)
        {
            if(list == null)
                return new List<T>(new T[desiredLength]);
            if (list.Count == desiredLength)
                return list;
            if(list.Count < desiredLength)
            {
                list.AddRange(new T[desiredLength - list.Count]);
                return list;
            }
            return list.Take(desiredLength).ToList();
        }
    }
}
