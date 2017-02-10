using System;
using System.Collections.Generic;

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

        #endregion Character Sheet

        #region Background Info

        public int Age;
        public int Height;
        public int Weight;
        public string Eyes;
        public string Skin;
        public string Hair;

        public byte[] CharacterPortrait;

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
        public int Level2SlotsTotal;
        public int Level2SlotsExpended;
        public List<string> Level2Spells;
        public int Level3SlotsTotal;
        public int Level3SlotsExpended;
        public List<string> Level3Spells;
        public int Level4SlotsTotal;
        public int Level4SlotsExpended;
        public List<string> Level4Spells;
        public int Level5SlotsTotal;
        public int Level5SlotsExpended;
        public List<string> Level5Spells;
        public int Level6SlotsTotal;
        public int Level6SlotsExpended;
        public List<string> Level6Spells;
        public int Level7SlotsTotal;
        public int Level7SlotsExpended;
        public List<string> Level7Spells;
        public int Level8SlotsTotal;
        public int Level8SlotsExpended;
        public List<string> Level8Spells;
        public int Level9SlotsTotal;
        public int Level9SlotsExpended;
        public List<string> Level9Spells;

        #endregion Spellcasting

        public CharacterSheetModel()
        {
            Cantrips = new List<string>(new string[8]);
            Level1Spells = new List<string>(new string[13]);
            Level2Spells = new List<string>(new string[13]);
            Level3Spells = new List<string>(new string[13]);
            Level4Spells = new List<string>(new string[13]);
            Level5Spells = new List<string>(new string[9]);
            Level6Spells = new List<string>(new string[9]);
            Level7Spells = new List<string>(new string[7]);
            Level8Spells = new List<string>(new string[7]);
            Level9Spells = new List<string>(new string[7]);
        }
    }
}
