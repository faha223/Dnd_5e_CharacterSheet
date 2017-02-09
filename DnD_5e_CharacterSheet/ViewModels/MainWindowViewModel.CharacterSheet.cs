using DnD_5e_CharacterSheet.Models;
using System.Collections.Generic;

namespace DnD_5e_CharacterSheet.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private CharacterSheetModel model = new CharacterSheetModel();

        #region Header Region

        public string CharacterName
        {
            get
            {
                return model.CharacterName;
            }
            set
            {
                if (model.CharacterName != value)
                {
                    model.CharacterName = value;
                    OnPropertyChanged("CharacterName");
                }
            }
        }

        public string ClassAndLevel
        {
            get
            {
                return model.ClassAndLevel;
            }
            set
            {
                if (model.ClassAndLevel != value)
                {
                    model.ClassAndLevel = value;
                    OnPropertyChanged("ClassAndLevel");
                }
            }
        }

        public string Background
        {
            get
            {
                return model.Background;
            }
            set
            {
                if (model.Background != value)
                {
                    model.Background = value;
                    OnPropertyChanged("Background");
                }
            }
        }

        public string PlayerName
        {
            get
            {
                return model.PlayerName;
            }
            set
            {
                if (model.PlayerName != value)
                {
                    model.PlayerName = value;
                    OnPropertyChanged("PlayerName");
                }
            }
        }

        public string Race
        {
            get
            {
                return model.Race;
            }
            set
            {
                if (model.Race != value)
                {
                    model.Race = value;
                    OnPropertyChanged("Race");
                }
            }
        }

        public string Alignment
        {
            get
            {
                return model.Alignment;
            }
            set
            {
                if (model.Alignment != value)
                {
                    model.Alignment = value;
                    OnPropertyChanged("Alignment");
                }
            }
        }

        public int ExperiencePoints
        {
            get
            {
                return model.ExperiencePoints;
            }
            set
            {
                if (model.ExperiencePoints != value)
                {
                    value = validXPValue(value);
                    model.ExperiencePoints = value;
                    OnPropertyChanged("ExperiencePoints");
                }
            }
        }

        #endregion Header Region

        #region Ability Scores

        public int Strength
        {
            get
            {
                return model.Strength;
            }
            set
            {
                if (model.Strength != value)
                {
                    value = validAbilityScore(value);
                    model.Strength = value;
                    OnPropertyChanged("Strength");
                    OnPropertyChanged("StrengthModifier");
                    OnPropertyChanged("StrengthSavingThrow");
                    OnPropertyChanged("Athletics");
                    OnPropertyChanged("SpellSaveDC");
                    OnPropertyChanged("SpellAttackBonus");
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

        public int Dexterity
        {
            get
            {
                return model.Dexterity;
            }
            set
            {
                if (model.Dexterity != value)
                {
                    value = validAbilityScore(value);
                    model.Dexterity = value;
                    OnPropertyChanged("Dexterity");
                    OnPropertyChanged("DexterityModifier");
                    OnPropertyChanged("DexteritySavingThrow");
                    OnPropertyChanged("Acrobatics");
                    OnPropertyChanged("SleightOfHand");
                    OnPropertyChanged("Stealth");
                    OnPropertyChanged("SpellSaveDC");
                    OnPropertyChanged("SpellAttackBonus");
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

        public int Constitution
        {
            get
            {
                return model.Constitution;
            }
            set
            {
                if (model.Constitution != value)
                {
                    value = validAbilityScore(value);
                    model.Constitution = value;
                    OnPropertyChanged("Constitution");
                    OnPropertyChanged("ConstitutionModifier");
                    OnPropertyChanged("ConstitutionSavingThrow");
                    OnPropertyChanged("SpellSaveDC");
                    OnPropertyChanged("SpellAttackBonus");
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

        public int Intelligence
        {
            get
            {
                return model.Intelligence;
            }
            set
            {
                if (model.Intelligence != value)
                {
                    value = validAbilityScore(value);
                    model.Intelligence = value;
                    OnPropertyChanged("Intelligence");
                    OnPropertyChanged("IntelligenceModifier");
                    OnPropertyChanged("IntelligenceSavingThrow");
                    OnPropertyChanged("Arcana");
                    OnPropertyChanged("History");
                    OnPropertyChanged("Investigation");
                    OnPropertyChanged("Nature");
                    OnPropertyChanged("Religion");
                    OnPropertyChanged("SpellSaveDC");
                    OnPropertyChanged("SpellAttackBonus");
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

        public int Wisdom
        {
            get
            {
                return model.Wisdom;
            }
            set
            {
                if (model.Wisdom != value)
                {
                    value = validAbilityScore(value);
                    model.Wisdom = value;
                    OnPropertyChanged("Wisdom");
                    OnPropertyChanged("WisdomModifier");
                    OnPropertyChanged("PassiveWisdom");
                    OnPropertyChanged("WisdomSavingThrow");
                    OnPropertyChanged("AnimalHandling");
                    OnPropertyChanged("Insight");
                    OnPropertyChanged("Medicine");
                    OnPropertyChanged("Perception");
                    OnPropertyChanged("Survival");
                    OnPropertyChanged("SpellSaveDC");
                    OnPropertyChanged("SpellAttackBonus");
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

        public int Charisma
        {
            get
            {
                return model.Charisma;
            }
            set
            {
                if (model.Charisma != value)
                {
                    value = validAbilityScore(value);
                    model.Charisma = value;
                    OnPropertyChanged("Charisma");
                    OnPropertyChanged("CharismaModifier");
                    OnPropertyChanged("CharismaSavingThrow");
                    OnPropertyChanged("Deception");
                    OnPropertyChanged("Intimidation");
                    OnPropertyChanged("Performance");
                    OnPropertyChanged("Persuasion");
                    OnPropertyChanged("SpellSaveDC");
                    OnPropertyChanged("SpellAttackBonus");
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

        public int HitPointMaximum
        {
            get
            {
                return model.HitPointMaximum;
            }
            set
            {
                if (model.HitPointMaximum != value)
                {
                    model.HitPointMaximum = value;
                    OnPropertyChanged("HitPointMaximum");
                }
            }
        }

        public int CurrentHitPoints
        {
            get
            {
                return model.CurrentHitPoints;
            }
            set
            {
                if (model.CurrentHitPoints != value)
                {
                    value = validCurrentHitPoints(value);
                    model.CurrentHitPoints = value;
                    OnPropertyChanged("CurrentHitPoints");
                }
            }
        }

        public int TemporaryHitPoints
        {
            get
            {
                return model.TemporaryHitPoints;
            }
            set
            {
                if (model.TemporaryHitPoints != value)
                {
                    model.TemporaryHitPoints = value;
                    OnPropertyChanged("TemporaryHitPoints");
                }
            }
        }

        public int TotalHitDice
        {
            get
            {
                return model.TotalHitDice;
            }
            set
            {
                if (model.TotalHitDice != value)
                {
                    model.TotalHitDice = value;
                    OnPropertyChanged("TotalHitDice");
                }
            }
        }

        public string HitDice
        {
            get
            {
                return model.HitDice;
            }
            set
            {
                if (model.HitDice != value)
                {
                    model.HitDice = value;
                    OnPropertyChanged("HitDice");
                }
            }
        }

        #endregion Current Hit Points

        #region Death Saves

        public bool DeathSaveSuccess1
        {
            get
            {
                return model.DeathSaveSuccess1;
            }
            set
            {
                if (model.DeathSaveSuccess1 != value)
                {
                    model.DeathSaveSuccess1 = value;
                    OnPropertyChanged("DeathSaveSuccess1");
                }
            }
        }

        public bool DeathSaveSuccess2
        {
            get
            {
                return model.DeathSaveSuccess2;
            }
            set
            {
                if (model.DeathSaveSuccess2 != value)
                {
                    model.DeathSaveSuccess2 = value;
                    OnPropertyChanged("DeathSaveSuccess2");
                }
            }
        }

        public bool DeathSaveSuccess3
        {
            get
            {
                return model.DeathSaveSuccess3;
            }
            set
            {
                if (model.DeathSaveSuccess3 != value)
                {
                    model.DeathSaveSuccess3 = value;
                    OnPropertyChanged("DeathSaveSuccess3");
                }
            }
        }

        public bool DeathSaveFailure1
        {
            get
            {
                return model.DeathSaveFailure1;
            }
            set
            {
                if (model.DeathSaveFailure1 != value)
                {
                    model.DeathSaveFailure1 = value;
                    OnPropertyChanged("DeathSaveFailure1");
                }
            }
        }

        public bool DeathSaveFailure2
        {
            get
            {
                return model.DeathSaveFailure2;
            }
            set
            {
                if (model.DeathSaveFailure2 != value)
                {
                    model.DeathSaveFailure2 = value;
                    OnPropertyChanged("DeathSaveFailure2");
                }
            }
        }

        public bool DeathSaveFailure3
        {
            get
            {
                return model.DeathSaveFailure3;
            }
            set
            {
                if (model.DeathSaveFailure3 != value)
                {
                    model.DeathSaveFailure3 = value;
                    OnPropertyChanged("DeathSaveFailure3");
                }
            }
        }

        #endregion Death Saves

        #region Saving Throws

        public bool StrengthSavingThrowEnabled
        {
            get
            {
                return model.StrengthSavingThrowEnabled;
            }
            set
            {
                if (model.StrengthSavingThrowEnabled != value)
                {
                    model.StrengthSavingThrowEnabled = value;
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

        public bool DexteritySavingThrowEnabled
        {
            get
            {
                return model.DexteritySavingThrowEnabled;
            }
            set
            {
                if (model.DexteritySavingThrowEnabled != value)
                {
                    model.DexteritySavingThrowEnabled = value;
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

        public bool ConstitutionSavingThrowEnabled
        {
            get
            {
                return model.ConstitutionSavingThrowEnabled;
            }
            set
            {
                if (model.ConstitutionSavingThrowEnabled != value)
                {
                    model.ConstitutionSavingThrowEnabled = value;
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

        public bool IntelligenceSavingThrowEnabled
        {
            get
            {
                return model.IntelligenceSavingThrowEnabled;
            }
            set
            {
                if (model.IntelligenceSavingThrowEnabled != value)
                {
                    model.IntelligenceSavingThrowEnabled = value;
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

        public bool WisdomSavingThrowEnabled
        {
            get
            {
                return model.WisdomSavingThrowEnabled;
            }
            set
            {
                if (model.WisdomSavingThrowEnabled != value)
                {
                    model.WisdomSavingThrowEnabled = value;
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

        public bool CharismaSavingThrowEnabled
        {
            get
            {
                return model.CharismaSavingThrowEnabled;
            }
            set
            {
                if (model.CharismaSavingThrowEnabled != value)
                {
                    model.CharismaSavingThrowEnabled = value;
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

        public bool AcrobaticsEnabled
        {
            get
            {
                return model.AcrobaticsEnabled;
            }
            set
            {
                if (model.AcrobaticsEnabled != value)
                {
                    model.AcrobaticsEnabled = value;
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

        public bool AnimalHandlingEnabled
        {
            get
            {
                return model.AnimalHandlingEnabled;
            }
            set
            {
                if (model.AnimalHandlingEnabled != value)
                {
                    model.AnimalHandlingEnabled = value;
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

        public bool ArcanaEnabled
        {
            get
            {
                return model.ArcanaEnabled;
            }
            set
            {
                if (model.ArcanaEnabled != value)
                {
                    model.ArcanaEnabled = value;
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

        public bool AthleticsEnabled
        {
            get
            {
                return model.AthleticsEnabled;
            }
            set
            {
                if (model.AthleticsEnabled != value)
                {
                    model.AthleticsEnabled = value;
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

        public bool DeceptionEnabled
        {
            get
            {
                return model.DeceptionEnabled;
            }
            set
            {
                if (model.DeceptionEnabled != value)
                {
                    model.DeceptionEnabled = value;
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

        public bool HistoryEnabled
        {
            get
            {
                return model.HistoryEnabled;
            }
            set
            {
                if (model.HistoryEnabled != value)
                {
                    model.HistoryEnabled = value;
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

        public bool InsightEnabled
        {
            get
            {
                return model.InsightEnabled;
            }
            set
            {
                if (model.InsightEnabled != value)
                {
                    model.InsightEnabled = value;
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

        public bool IntimidationEnabled
        {
            get
            {
                return model.IntimidationEnabled;
            }
            set
            {
                if (model.IntimidationEnabled != value)
                {
                    model.IntimidationEnabled = value;
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

        public bool InvestigationEnabled
        {
            get
            {
                return model.InvestigationEnabled;
            }
            set
            {
                if (model.InvestigationEnabled != value)
                {
                    model.InvestigationEnabled = value;
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

        public bool MedicineEnabled
        {
            get
            {
                return model.MedicineEnabled;
            }
            set
            {
                if (model.MedicineEnabled != value)
                {
                    model.MedicineEnabled = value;
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

        public bool NatureEnabled
        {
            get
            {
                return model.NatureEnabled;
            }
            set
            {
                if (model.NatureEnabled != value)
                {
                    model.NatureEnabled = value;
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

        public bool PerceptionEnabled
        {
            get
            {
                return model.PerceptionEnabled;
            }
            set
            {
                if (model.PerceptionEnabled != value)
                {
                    model.PerceptionEnabled = value;
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

        public bool PerformanceEnabled
        {
            get
            {
                return model.PerformanceEnabled;
            }
            set
            {
                if (model.PerformanceEnabled != value)
                {
                    model.PerformanceEnabled = value;
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

        public bool PersuasionEnabled
        {
            get
            {
                return model.PersuasionEnabled;
            }
            set
            {
                if (model.PersuasionEnabled != value)
                {
                    model.PersuasionEnabled = value;
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

        public bool ReligionEnabled
        {
            get
            {
                return model.ReligionEnabled;
            }
            set
            {
                if (model.ReligionEnabled != value)
                {
                    model.ReligionEnabled = value;
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

        public bool SleightOfHandEnabled
        {
            get
            {
                return model.SleightOfHandEnabled;
            }
            set
            {
                if (model.SleightOfHandEnabled != value)
                {
                    model.SleightOfHandEnabled = value;
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

        public bool StealthEnabled
        {
            get
            {
                return model.StealthEnabled;
            }
            set
            {
                if (model.StealthEnabled != value)
                {
                    model.StealthEnabled = value;
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

        public bool SurvivalEnabled
        {
            get
            {
                return model.SurvivalEnabled;
            }
            set
            {
                if (model.SurvivalEnabled != value)
                {
                    model.SurvivalEnabled = value;
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

        public string OtherProficienciesAndLanguages
        {
            get
            {
                return model.OtherProficienciesAndLanguages;
            }
            set
            {
                if (model.OtherProficienciesAndLanguages != value)
                {
                    model.OtherProficienciesAndLanguages = value;
                    OnPropertyChanged("OtherProficienciesAndLanguages");
                }
            }
        }

        public string Equipment
        {
            get
            {
                return model.Equipment;
            }
            set
            {
                if (model.Equipment != value)
                {
                    model.Equipment = value;
                    OnPropertyChanged("Equipment");
                }
            }
        }

        public string PersonalityTraits
        {
            get
            {
                return model.PersonalityTraits;
            }
            set
            {
                if (model.PersonalityTraits != value)
                {
                    model.PersonalityTraits = value;
                    OnPropertyChanged("PersonalityTraits");
                }
            }
        }

        public string Ideals
        {
            get
            {
                return model.Ideals;
            }
            set
            {
                if (model.Ideals != value)
                {
                    model.Ideals = value;
                    OnPropertyChanged("Ideals");
                }
            }
        }

        public string Bonds
        {
            get
            {
                return model.Bonds;
            }
            set
            {
                if (model.Bonds != value)
                {
                    model.Bonds = value;
                    OnPropertyChanged("Bonds");
                }
            }
        }

        public string Flaws
        {
            get
            {
                return model.Flaws;
            }
            set
            {
                if (model.Flaws != value)
                {
                    model.Flaws = value;
                    OnPropertyChanged("Flaws");
                }
            }
        }

        public string FeaturesAndTraits
        {
            get
            {
                return model.FeaturesAndTraits;
            }
            set
            {
                if (model.FeaturesAndTraits != value)
                {
                    model.FeaturesAndTraits = value;
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

        public List<string> Classes { get; set; } = new List<string>(new string[]
        {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorceror",
            "Warlock",
            "Wizard"
        });

        public List<string> Alignments { get; set; } = new List<string>(new string[]
        {
            "Lawful Good",
            "Neutral Good",
            "Chaotic Good",
            "Lawful Neutral",
            "True Neutral",
            "Chaotic Neutral",
            "Lawful Evil",
            "Neutral Evil",
            "Chaotic Evil"
        });

        #endregion Tables

        #region Currency

        public int CopperPieces
        {
            get
            {
                return model.CopperPieces;
            }
            set
            {
                if (model.CopperPieces != value)
                {
                    while (value >= DnD_Constants.CopperPiecesPerSilver)
                    {
                        value -= DnD_Constants.CopperPiecesPerSilver;
                        SilverPieces += 1;
                    }
                    model.CopperPieces = value;
                    OnPropertyChanged("CopperPieces");
                }
            }
        }

        public int SilverPieces
        {
            get
            {
                return model.SilverPieces;
            }
            set
            {
                if (model.SilverPieces != value)
                {
                    while(value >= DnD_Constants.SilverPiecesPerElectrum)
                    {
                        value -= DnD_Constants.SilverPiecesPerElectrum;
                        ElectrumPieces += 1;
                    }
                    model.SilverPieces = value;
                    OnPropertyChanged("SilverPieces");
                }
            }
        }

        public int ElectrumPieces
        {
            get
            {
                return model.ElectrumPieces;
            }
            set
            {
                if (model.ElectrumPieces != value)
                {
                    while(value >= DnD_Constants.ElectrumPiecesPerGold)
                    {
                        value -= DnD_Constants.ElectrumPiecesPerGold;
                        GoldPieces += 1;
                    }
                    model.ElectrumPieces = value;
                    OnPropertyChanged("ElectrumPieces");
                }
            }
        }

        public int GoldPieces
        {
            get
            {
                return model.GoldPieces;
            }
            set
            {
                if (model.GoldPieces != value)
                {
                    while (value >= DnD_Constants.GoldPiecesPerPlatinum)
                    {
                        value -= DnD_Constants.GoldPiecesPerPlatinum;
                        PlatinumPieces += 1;
                    }
                    model.GoldPieces = value;
                    OnPropertyChanged("GoldPieces");
                }
            }
        }

        public int PlatinumPieces
        {
            get
            {
                return model.PlatinumPieces;
            }
            set
            {
                if (model.PlatinumPieces != value)
                {
                    model.PlatinumPieces = value;
                    OnPropertyChanged("PlatinumPieces");
                }
            }
        }

        #endregion Currency

        public int ProficiencyBonus
        {
            get
            {
                return model.ProficiencyBonus;
            }
            set
            {
                if (model.ProficiencyBonus != value)
                {
                    model.ProficiencyBonus = value;
                    OnPropertyChanged("ProficiencyBonus");
                    OnPropertyChanged("StrengthSavingThrow");
                    OnPropertyChanged("DexteritySavingThrow");
                    OnPropertyChanged("ConstitutionSavingThrow");
                    OnPropertyChanged("IntelligenceSavingThrow");
                    OnPropertyChanged("WisdomSavingThrow");
                    OnPropertyChanged("CharismaSavingThrow");
                    OnPropertyChanged("SpellSaveDC");
                    OnPropertyChanged("SpellAttackBonus");
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

        public int ArmorClass
        {
            get
            {
                return model.ArmorClass;
            }
            set
            {
                if (model.ArmorClass != value)
                {
                    model.ArmorClass = value;
                    OnPropertyChanged("ArmorClass");
                }
            }
        }

        public int Initiative
        {
            get
            {
                return model.Initiative;
            }
            set
            {
                if (model.Initiative != value)
                {
                    model.Initiative = value;
                    OnPropertyChanged("Initiative");
                }
            }
        }

        public int Speed
        {
            get
            {
                return model.Speed;
            }
            set
            {
                if (model.Speed != value)
                {
                    model.Speed = value;
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

        private int getAbilityModifier(string ability)
        {
            if (ability != null)
            {
                switch (ability.ToUpper())
                {
                    case "STRENGTH":
                        return StrengthModifier;
                    case "DEXTERITY":
                        return DexterityModifier;
                    case "CONSTITUTION":
                        return ConstitutionModifier;
                    case "INTELLIGENCE":
                        return IntelligenceModifier;
                    case "WISDOM":
                        return WisdomModifier;
                    case "CHARISMA":
                        return CharismaModifier;
                }
            }
            return 0;
        }
    }
}
