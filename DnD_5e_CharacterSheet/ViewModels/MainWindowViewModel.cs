using System.Collections.Generic;
using System.Linq;

namespace DnD_5e_CharacterSheet.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Header Region

        private string characterName;
        public string CharacterName
        {
            get
            {
                return characterName;
            }
            set
            {
                if (characterName != value)
                {
                    characterName = value;
                    OnPropertyChanged("CharacterName");
                }
            }
        }

        private string levelAndClass;
        public string LevelAndClass
        {
            get
            {
                return levelAndClass;
            }
            set
            {
                if (levelAndClass != value)
                {
                    levelAndClass = value;
                    OnPropertyChanged("LevelAndClass");
                }
            }
        }

        private string background;
        public string Background
        {
            get
            {
                return background;
            }
            set
            {
                if (background != value)
                {
                    background = value;
                    OnPropertyChanged("Background");
                }
            }
        }

        private string playerName;
        public string PlayerName
        {
            get
            {
                return playerName;
            }
            set
            {
                if (playerName != value)
                {
                    playerName = value;
                    OnPropertyChanged("PlayerName");
                }
            }
        }

        private string race;
        public string Race
        {
            get
            {
                return race;
            }
            set
            {
                if (race != value)
                {
                    race = value;
                    OnPropertyChanged("Race");
                }
            }
        }

        private string alignment;
        public string Alignment
        {
            get
            {
                return alignment;
            }
            set
            {
                if (alignment != value)
                {
                    alignment = value;
                    OnPropertyChanged("Alignment");
                }
            }
        }

        private int experiencePoints;
        public int ExperiencePoints
        {
            get
            {
                return experiencePoints;
            }
            set
            {
                if (experiencePoints != value)
                {
                    value = validXPValue(value);
                    experiencePoints = value;
                    OnPropertyChanged("ExperiencePoints");
                }
            }
        }

        #endregion Header Region

        #region Ability Scores

        private int strength = 1;
        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                if (strength != value)
                {
                    value = validAbilityScore(value);
                    strength = value;
                    OnPropertyChanged("Strength");
                    OnPropertyChanged("StrengthModifier");
                    OnPropertyChanged("StrengthSavingThrow");
                    OnPropertyChanged("Athletics");
                }
            }
        }
        public int StrengthModifier
        {
            get
            {
                return getAbilityModifier(Strength);
            }
        }

        private int dexterity = 1;
        public int Dexterity
        {
            get
            {
                return dexterity;
            }
            set
            {
                if (dexterity != value)
                {
                    value = validAbilityScore(value);
                    dexterity = value;
                    OnPropertyChanged("Dexterity");
                    OnPropertyChanged("DexterityModifier");
                    OnPropertyChanged("DexteritySavingThrow");
                    OnPropertyChanged("Acrobatics");
                    OnPropertyChanged("SleightOfHand");
                    OnPropertyChanged("Stealth");
                }
            }
        }
        public int DexterityModifier
        {
            get
            {
                return getAbilityModifier(Dexterity);
            }
        }

        private int constitution = 1;
        public int Constitution
        {
            get
            {
                return constitution;
            }
            set
            {
                if (constitution != value)
                {
                    value = validAbilityScore(value);
                    constitution = value;
                    OnPropertyChanged("Constitution");
                    OnPropertyChanged("ConstitutionModifier");
                    OnPropertyChanged("ConstitutionSavingThrow");
                }
            }
        }
        public int ConstitutionModifier
        {
            get
            {
                return getAbilityModifier(Constitution);
            }
        }

        private int intelligence = 1;
        public int Intelligence
        {
            get
            {
                return intelligence;
            }
            set
            {
                if (intelligence != value)
                {
                    value = validAbilityScore(value);
                    intelligence = value;
                    OnPropertyChanged("Intelligence");
                    OnPropertyChanged("IntelligenceModifier");
                    OnPropertyChanged("IntelligenceSavingThrow");
                    OnPropertyChanged("Arcana");
                    OnPropertyChanged("History");
                    OnPropertyChanged("Investigation");
                    OnPropertyChanged("Nature");
                    OnPropertyChanged("Religion");
                }
            }
        }
        public int IntelligenceModifier
        {
            get
            {
                return getAbilityModifier(Intelligence);
            }
        }

        private int wisdom = 1;
        public int Wisdom
        {
            get
            {
                return wisdom;
            }
            set
            {
                if (wisdom != value)
                {
                    value = validAbilityScore(value);
                    wisdom = value;
                    OnPropertyChanged("Wisdom");
                    OnPropertyChanged("WisdomModifier");
                    OnPropertyChanged("PassiveWisdom");
                    OnPropertyChanged("WisdomSavingThrow");
                    OnPropertyChanged("AnimalHandling");
                    OnPropertyChanged("Insight");
                    OnPropertyChanged("Medicine");
                    OnPropertyChanged("Perception");
                    OnPropertyChanged("Survival");
                }
            }
        }
        public int WisdomModifier
        {
            get
            {
                return getAbilityModifier(Wisdom);
            }
        }

        private int charisma = 1;
        public int Charisma
        {
            get
            {
                return charisma;
            }
            set
            {
                if (charisma != value)
                {
                    value = validAbilityScore(value);
                    charisma = value;
                    OnPropertyChanged("Charisma");
                    OnPropertyChanged("CharismaModifier");
                    OnPropertyChanged("CharismaSavingThrow");
                    OnPropertyChanged("Deception");
                    OnPropertyChanged("Intimidation");
                    OnPropertyChanged("Performance");
                    OnPropertyChanged("Persuasion");
                }
            }
        }
        public int CharismaModifier
        {
            get
            {
                return getAbilityModifier(Charisma);
            }
        }

        #endregion AbilityScores

        #region Current Hit Points

        private int hitPointMaximum;
        public int HitPointMaximum
        {
            get
            {
                return hitPointMaximum;
            }
            set
            {
                if (hitPointMaximum != value)
                {
                    hitPointMaximum = value;
                    OnPropertyChanged("HitPointMaximum");
                }
            }
        }

        private int currentHitPoints;
        public int CurrentHitPoints
        {
            get
            {
                return currentHitPoints;
            }
            set
            {
                if (currentHitPoints != value)
                {
                    value = validCurrentHitPoints(value);
                    currentHitPoints = value;
                    OnPropertyChanged("CurrentHitPoints");
                }
            }
        }

        private int temporaryHitPoints;
        public int TemporaryHitPoints
        {
            get
            {
                return temporaryHitPoints;
            }
            set
            {
                if (temporaryHitPoints != value)
                {
                    temporaryHitPoints = value;
                    OnPropertyChanged("TemporaryHitPoints");
                }
            }
        }

        private int totalHitDice;
        public int TotalHitDice
        {
            get
            {
                return totalHitDice;
            }
            set
            {
                if (totalHitDice != value)
                {
                    totalHitDice = value;
                    OnPropertyChanged("TotalHitDice");
                }
            }
        }

        private string hitDice;
        public string HitDice
        {
            get
            {
                return hitDice;
            }
            set
            {
                if (hitDice != value)
                {
                    hitDice = value;
                    OnPropertyChanged("HitDice");
                }
            }
        }

        #endregion Current Hit Points

        #region Death Saves

        private bool deathSaveSuccess1;
        public bool DeathSaveSuccess1
        {
            get
            {
                return deathSaveSuccess1;
            }
            set
            {
                if (deathSaveSuccess1 != value)
                {
                    deathSaveSuccess1 = value;
                    OnPropertyChanged("DeathSaveSuccess1");
                }
            }
        }

        private bool deathSaveSuccess2;
        public bool DeathSaveSuccess2
        {
            get
            {
                return deathSaveSuccess2;
            }
            set
            {
                if (deathSaveSuccess2 != value)
                {
                    deathSaveSuccess2 = value;
                    OnPropertyChanged("DeathSaveSuccess2");
                }
            }
        }

        private bool deathSaveSuccess3;
        public bool DeathSaveSuccess3
        {
            get
            {
                return deathSaveSuccess3;
            }
            set
            {
                if (deathSaveSuccess3 != value)
                {
                    deathSaveSuccess3 = value;
                    OnPropertyChanged("DeathSaveSuccess3");
                }
            }
        }

        private bool deathSaveFailure1;
        public bool DeathSaveFailure1
        {
            get
            {
                return deathSaveFailure1;
            }
            set
            {
                if (deathSaveFailure1 != value)
                {
                    deathSaveFailure1 = value;
                    OnPropertyChanged("DeathSaveFailure1");
                }
            }
        }

        private bool deathSaveFailure2;
        public bool DeathSaveFailure2
        {
            get
            {
                return deathSaveFailure2;
            }
            set
            {
                if (deathSaveFailure2 != value)
                {
                    deathSaveFailure2 = value;
                    OnPropertyChanged("DeathSaveFailure2");
                }
            }
        }

        private bool deathSaveFailure3;
        public bool DeathSaveFailure3
        {
            get
            {
                return deathSaveFailure3;
            }
            set
            {
                if (deathSaveFailure3 != value)
                {
                    deathSaveFailure3 = value;
                    OnPropertyChanged("DeathSaveFailure3");
                }
            }
        }

        #endregion Death Saves

        #region Saving Throws

        private bool strengthSavingThrowEnabled;
        public bool StrengthSavingThrowEnabled
        {
            get
            {
                return strengthSavingThrowEnabled;
            }
            set
            {
                if (strengthSavingThrowEnabled != value)
                {
                    strengthSavingThrowEnabled = value;
                    OnPropertyChanged("StrengthSavingThrowEnabled");
                }
            }
        }

        public int StrengthSavingThrow
        {
            get
            {
                return ProficiencyBonus + StrengthModifier;
            }
        }

        private bool dexteritySavingThrowEnabled;
        public bool DexteritySavingThrowEnabled
        {
            get
            {
                return dexteritySavingThrowEnabled;
            }
            set
            {
                if (dexteritySavingThrowEnabled != value)
                {
                    dexteritySavingThrowEnabled = value;
                    OnPropertyChanged("DexteritySavingThrowEnabled");
                }
            }
        }

        public int DexteritySavingThrow
        {
            get
            {
                return ProficiencyBonus + DexterityModifier;
            }
        }

        private bool constitutionSavingThrowEnabled;
        public bool ConstitutionSavingThrowEnabled
        {
            get
            {
                return constitutionSavingThrowEnabled;
            }
            set
            {
                if (constitutionSavingThrowEnabled != value)
                {
                    constitutionSavingThrowEnabled = value;
                    OnPropertyChanged("ConstitutionSavingThrowEnabled");
                }
            }
        }

        public int ConstitutionSavingThrow
        {
            get
            {
                return ProficiencyBonus + ConstitutionModifier;
            }
        }

        private bool intelligenceSavingThrowEnabled;
        public bool IntelligenceSavingThrowEnabled
        {
            get
            {
                return intelligenceSavingThrowEnabled;
            }
            set
            {
                if (intelligenceSavingThrowEnabled != value)
                {
                    intelligenceSavingThrowEnabled = value;
                    OnPropertyChanged("IntelligenceSavingThrowEnabled");
                }
            }
        }

        public int IntelligenceSavingThrow
        {
            get
            {
                return ProficiencyBonus + IntelligenceModifier;
            }
        }

        private bool wisdomSavingThrowEnabled;
        public bool WisdomSavingThrowEnabled
        {
            get
            {
                return wisdomSavingThrowEnabled;
            }
            set
            {
                if (wisdomSavingThrowEnabled != value)
                {
                    wisdomSavingThrowEnabled = value;
                    OnPropertyChanged("WisdomSavingThrowEnabled");
                }
            }
        }

        public int WisdomSavingThrow
        {
            get
            {
                return ProficiencyBonus + WisdomModifier;
            }
        }

        private bool charismaSavingThrowEnabled;
        public bool CharismaSavingThrowEnabled
        {
            get
            {
                return charismaSavingThrowEnabled;
            }
            set
            {
                if (charismaSavingThrowEnabled != value)
                {
                    charismaSavingThrowEnabled = value;
                    OnPropertyChanged("CharismaSavingThrowEnabled");
                }
            }
        }

        public int CharismaSavingThrow
        {
            get
            {
                return ProficiencyBonus + CharismaModifier;
            }
        }

        #endregion Saving Throws

        #region Skills

        private bool acrobaticsEnabled;
        public bool AcrobaticsEnabled
        {
            get
            {
                return acrobaticsEnabled;
            }
            set
            {
                if (acrobaticsEnabled != value)
                {
                    acrobaticsEnabled = value;
                    OnPropertyChanged("AcrobaticsEnabled");
                }
            }
        }

        public int Acrobatics
        {
            get
            {
                return ProficiencyBonus + DexterityModifier;
            }
        }

        private bool animalHandlingEnabled;
        public bool AnimalHandlingEnabled
        {
            get
            {
                return animalHandlingEnabled;
            }
            set
            {
                if (animalHandlingEnabled != value)
                {
                    animalHandlingEnabled = value;
                    OnPropertyChanged("AnimalHandlingEnabled");
                }
            }
        }

        public int AnimalHandling
        {
            get
            {
                return ProficiencyBonus + WisdomModifier;
            }
        }

        private bool arcanaEnabled;
        public bool ArcanaEnabled
        {
            get
            {
                return arcanaEnabled;
            }
            set
            {
                if (arcanaEnabled != value)
                {
                    arcanaEnabled = value;
                    OnPropertyChanged("ArcanaEnabled");
                }
            }
        }

        public int Arcana
        {
            get
            {
                return ProficiencyBonus + IntelligenceModifier;
            }
        }

        private bool athleticsEnabled;
        public bool AthleticsEnabled
        {
            get
            {
                return athleticsEnabled;
            }
            set
            {
                if (athleticsEnabled != value)
                {
                    athleticsEnabled = value;
                    OnPropertyChanged("AthleticsEnabled");
                }
            }
        }

        public int Athletics
        {
            get
            {
                return ProficiencyBonus + StrengthModifier;
            }
        }

        private bool deceptionEnabled;
        public bool DeceptionEnabled
        {
            get
            {
                return deceptionEnabled;
            }
            set
            {
                if (deceptionEnabled != value)
                {
                    deceptionEnabled = value;
                    OnPropertyChanged("DeceptionEnabled");
                }
            }
        }

        public int Deception
        {
            get
            {
                return ProficiencyBonus + CharismaModifier;
            }
        }

        private bool historyEnabled;
        public bool HistoryEnabled
        {
            get
            {
                return historyEnabled;
            }
            set
            {
                if (historyEnabled != value)
                {
                    historyEnabled = value;
                    OnPropertyChanged("HistoryEnabled");
                }
            }
        }

        public int History
        {
            get
            {
                return ProficiencyBonus + IntelligenceModifier;
            }
        }

        private bool insightEnabled;
        public bool InsightEnabled
        {
            get
            {
                return insightEnabled;
            }
            set
            {
                if (insightEnabled != value)
                {
                    insightEnabled = value;
                    OnPropertyChanged("InsightEnabled");
                }
            }
        }

        public int Insight
        {
            get
            {
                return ProficiencyBonus + WisdomModifier;
            }
        }

        private bool intimidationEnabled;
        public bool IntimidationEnabled
        {
            get
            {
                return intimidationEnabled;
            }
            set
            {
                if (intimidationEnabled != value)
                {
                    intimidationEnabled = value;
                    OnPropertyChanged("IntimidationEnabled");
                }
            }
        }

        public int Intimidation
        {
            get
            {
                return ProficiencyBonus + CharismaModifier;
            }
        }

        private bool investigationEnabled;
        public bool InvestigationEnabled
        {
            get
            {
                return investigationEnabled;
            }
            set
            {
                if (investigationEnabled != value)
                {
                    investigationEnabled = value;
                    OnPropertyChanged("InvestigationEnabled");
                }
            }
        }

        public int Investigation
        {
            get
            {
                return ProficiencyBonus + IntelligenceModifier;
            }
        }

        private bool medicineEnabled;
        public bool MedicineEnabled
        {
            get
            {
                return medicineEnabled;
            }
            set
            {
                if (medicineEnabled != value)
                {
                    medicineEnabled = value;
                    OnPropertyChanged("MedicineEnabled");
                }
            }
        }

        public int Medicine
        {
            get
            {
                return ProficiencyBonus + WisdomModifier;
            }
        }

        private bool natureEnabled;
        public bool NatureEnabled
        {
            get
            {
                return natureEnabled;
            }
            set
            {
                if (natureEnabled != value)
                {
                    natureEnabled = value;
                    OnPropertyChanged("NatureEnabled");
                }
            }
        }

        public int Nature
        {
            get
            {
                return ProficiencyBonus + IntelligenceModifier;
            }
        }

        private bool perceptionEnabled;
        public bool PerceptionEnabled
        {
            get
            {
                return perceptionEnabled;
            }
            set
            {
                if (perceptionEnabled != value)
                {
                    perceptionEnabled = value;
                    OnPropertyChanged("PerceptionEnabled");
                }
            }
        }

        public int Perception
        {
            get
            {
                return ProficiencyBonus + WisdomModifier;
            }
        }

        private bool performanceEnabled;
        public bool PerformanceEnabled
        {
            get
            {
                return performanceEnabled;
            }
            set
            {
                if (performanceEnabled != value)
                {
                    performanceEnabled = value;
                    OnPropertyChanged("PerformanceEnabled");
                }
            }
        }

        public int Performance
        {
            get
            {
                return ProficiencyBonus + CharismaModifier;
            }
        }

        private bool persuasionEnabled;
        public bool PersuasionEnabled
        {
            get
            {
                return persuasionEnabled;
            }
            set
            {
                if (persuasionEnabled != value)
                {
                    persuasionEnabled = value;
                    OnPropertyChanged("PersuasionEnabled");
                }
            }
        }

        public int Persuasion
        {
            get
            {
                return ProficiencyBonus + CharismaModifier;
            }
        }

        private bool religionEnabled;
        public bool ReligionEnabled
        {
            get
            {
                return religionEnabled;
            }
            set
            {
                if (religionEnabled != value)
                {
                    religionEnabled = value;
                    OnPropertyChanged("ReligionEnabled");
                }
            }
        }

        public int Religion
        {
            get
            {
                return ProficiencyBonus + IntelligenceModifier;
            }
        }

        private bool sleightOfHandEnabled;
        public bool SleightOfHandEnabled
        {
            get
            {
                return sleightOfHandEnabled;
            }
            set
            {
                if (sleightOfHandEnabled != value)
                {
                    sleightOfHandEnabled = value;
                    OnPropertyChanged("SleightOfHandEnabled");
                }
            }
        }

        public int SleightOfHand
        {
            get
            {
                return ProficiencyBonus + DexterityModifier;
            }
        }

        private bool stealthEnabled;
        public bool StealthEnabled
        {
            get
            {
                return stealthEnabled;
            }
            set
            {
                if (stealthEnabled != value)
                {
                    stealthEnabled = value;
                    OnPropertyChanged("StealthEnabled");
                }
            }
        }

        public int Stealth
        {
            get
            {
                return ProficiencyBonus + DexterityModifier;
            }
        }

        private bool survivalEnabled;
        public bool SurvivalEnabled
        {
            get
            {
                return survivalEnabled;
            }
            set
            {
                if (survivalEnabled != value)
                {
                    survivalEnabled = value;
                    OnPropertyChanged("SurvivalEnabled");
                }
            }
        }

        public int Survival
        {
            get
            {
                return ProficiencyBonus + WisdomModifier;
            }
        }

        #endregion Skills

        #region Text Blocks

        private string otherProficienciesAndLanguages;
        public string OtherProficienciesAndLanguages
        {
            get
            {
                return otherProficienciesAndLanguages;
            }
            set
            {
                if (otherProficienciesAndLanguages != value)
                {
                    otherProficienciesAndLanguages = value;
                    OnPropertyChanged("OtherProficienciesAndLanguages");
                }
            }
        }

        private string equipment;
        public string Equipment
        {
            get
            {
                return equipment;
            }
            set
            {
                if (equipment != value)
                {
                    equipment = value;
                    OnPropertyChanged("Equipment");
                }
            }
        }

        private string personalityTraits;
        public string PersonalityTraits
        {
            get
            {
                return personalityTraits;
            }
            set
            {
                if (personalityTraits != value)
                {
                    personalityTraits = value;
                    OnPropertyChanged("PersonalityTraits");
                }
            }
        }

        private string ideals;
        public string Ideals
        {
            get
            {
                return ideals;
            }
            set
            {
                if (ideals != value)
                {
                    ideals = value;
                    OnPropertyChanged("Ideals");
                }
            }
        }

        private string bonds;
        public string Bonds
        {
            get
            {
                return bonds;
            }
            set
            {
                if (bonds != value)
                {
                    bonds = value;
                    OnPropertyChanged("Bonds");
                }
            }
        }

        private string flaws;
        public string Flaws
        {
            get
            {
                return flaws;
            }
            set
            {
                if (flaws != value)
                {
                    flaws = value;
                    OnPropertyChanged("Flaws");
                }
            }
        }

        private string featuresAndTraits;
        public string FeaturesAndTraits
        {
            get
            {
                return featuresAndTraits;
            }
            set
            {
                if (featuresAndTraits != value)
                {
                    featuresAndTraits = value;
                    OnPropertyChanged("FeaturesAndTraits");
                }
            }
        }

        #endregion Text Blocks

        #region Tables

        public List<string> Races { get; set; } = new List<string>(new string[]
        {
            "Dwarf",
            "Elf",
            "Human",
            "Dragonborn",
            "Gnome",
            "Half-Elf",
            "Half-Orc",
            "Halfling",
            "Tiefling"
        });

        public List<string> Alignments { get; set; } = new List<string>(new string[]
        {
            "Lawful Good",
            "Good",
            "Chaotic Good",
            "Lawful Neutral",
            "True Neutral",
            "Chaotic Neutral",
            "Lawful Evil",
            "Evil",
            "Chaotic Evil"
        });

        #endregion Tables

        #region Currency

        private int copperPieces;
        public int CopperPieces
        {
            get
            {
                return copperPieces;
            }
            set
            {
                if (copperPieces != value)
                {
                    while (value >= DnD_Constants.CopperPiecesPerSilver)
                    {
                        value -= DnD_Constants.CopperPiecesPerSilver;
                        SilverPieces += 1;
                    }
                    copperPieces = value;
                    OnPropertyChanged("CopperPieces");
                }
            }
        }

        private int silverPieces;
        public int SilverPieces
        {
            get
            {
                return silverPieces;
            }
            set
            {
                if (silverPieces != value)
                {
                    while(value >= DnD_Constants.SilverPiecesPerElectrum)
                    {
                        value -= DnD_Constants.SilverPiecesPerElectrum;
                        ElectrumPieces += 1;
                    }
                    silverPieces = value;
                    OnPropertyChanged("SilverPieces");
                }
            }
        }

        private int electrumPieces;
        public int ElectrumPieces
        {
            get
            {
                return electrumPieces;
            }
            set
            {
                if (electrumPieces != value)
                {
                    while(value >= DnD_Constants.ElectrumPiecesPerGold)
                    {
                        value -= DnD_Constants.ElectrumPiecesPerGold;
                        GoldPieces += 1;
                    }
                    electrumPieces = value;
                    OnPropertyChanged("ElectrumPieces");
                }
            }
        }

        private int goldPieces;
        public int GoldPieces
        {
            get
            {
                return goldPieces;
            }
            set
            {
                if (goldPieces != value)
                {
                    while (value >= DnD_Constants.GoldPiecesPerPlatinum)
                    {
                        value -= DnD_Constants.GoldPiecesPerPlatinum;
                        PlatinumPieces += 1;
                    }
                    goldPieces = value;
                    OnPropertyChanged("GoldPieces");
                }
            }
        }

        private int platinumPieces;
        public int PlatinumPieces
        {
            get
            {
                return platinumPieces;
            }
            set
            {
                if (platinumPieces != value)
                {
                    platinumPieces = value;
                    OnPropertyChanged("PlatinumPieces");
                }
            }
        }

        #endregion Currency

        private int proficiencyBonus = 2;
        public int ProficiencyBonus
        {
            get
            {
                return proficiencyBonus;
            }
            set
            {
                if (proficiencyBonus != value)
                {
                    proficiencyBonus = value;
                    OnPropertyChanged("ProficiencyBonus");
                    OnPropertyChanged("StrengthSavingThrow");
                    OnPropertyChanged("DexteritySavingThrow");
                    OnPropertyChanged("ConstitutionSavingThrow");
                    OnPropertyChanged("IntelligenceSavingThrow");
                    OnPropertyChanged("WisdomSavingThrow");
                    OnPropertyChanged("CharismaSavingThrow");
                }
            }
        }

        public int PassiveWisdom
        {
            get
            {
                return 10 + WisdomModifier;
            }
        }

        private int armorClass;
        public int ArmorClass
        {
            get
            {
                return armorClass;
            }
            set
            {
                if (armorClass != value)
                {
                    armorClass = value;
                    OnPropertyChanged("ArmorClass");
                }
            }
        }

        private int initiative;
        public int Initiative
        {
            get
            {
                return initiative;
            }
            set
            {
                if (initiative != value)
                {
                    initiative = value;
                    OnPropertyChanged("Initiative");
                }
            }
        }

        private int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (speed != value)
                {
                    speed = value;
                    OnPropertyChanged("Speed");
                }
            }
        }

        private int validCurrentHitPoints(int value)
        {
            if (value < 0)
                return 0;
            if (value > HitPointMaximum)
                return HitPointMaximum;
            return value;
        }
        
        private int validAbilityScore(int value)
        {
            if (value < 1)
                return 1;
            if (value > 30)
                return 30;
            return value;
        }

        private int validXPValue(int value)
        {
            if (value < 0)
                return 0;
            return value;
        }

        private int getAbilityModifier(int abilityScore)
        {
            switch(abilityScore)
            {
                case 1:
                    return -5;
                case 2:
                case 3:
                    return -4;
                case 4:
                case 5:
                    return -3;
                case 6:
                case 7:
                    return -2;
                case 8:
                case 9:
                    return -1;
                case 10:
                case 11:
                    return 0;
                case 12:
                case 13:
                    return 1;
                case 14:
                case 15:
                    return 2;
                case 16:
                case 17:
                    return 3;
                case 18:
                case 19:
                    return 4;
                case 20:
                case 21:
                    return 5;
                case 22:
                case 23:
                    return 6;
                case 24:
                case 25:
                    return 7;
                case 26:
                case 27:
                    return 8;
                case 28:
                case 29:
                    return 9;
                case 30:
                    return 10;
                default:
                    return 0;
            }
        }
    }
}
