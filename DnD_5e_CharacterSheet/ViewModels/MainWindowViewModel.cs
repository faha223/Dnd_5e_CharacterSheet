using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                }
            }
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
