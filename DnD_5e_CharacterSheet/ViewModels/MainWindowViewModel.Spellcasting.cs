using System.Collections.Generic;

namespace DnD_5e_CharacterSheet.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        #region Header Block

        public string SpellcastingClass
        {
            get
            {
                return model.SpellcastingClass;
            }
            set
            {
                if (model.SpellcastingClass != value)
                {
                    model.SpellcastingClass = value;
                    OnPropertyChanged("SpellcastingClass");
                }
            }
        }

        public string SpellcastingAbility
        {
            get
            {
                return model.SpellcastingAbility;
            }
            set
            {
                if (model.SpellcastingAbility != value)
                {
                    model.SpellcastingAbility = value;
                    OnPropertyChanged("SpellcastingAbility");
                    OnPropertyChanged("SpellSaveDC");
                    OnPropertyChanged("SpellAttackBonus");
                }
            }
        }

        public int SpellSaveDC
        {
            get
            {
                return 8 + ProficiencyBonus + getAbilityModifier(SpellcastingAbility);
            }
        }

        public int SpellAttackBonus
        {
            get
            {
                return ProficiencyBonus + getAbilityModifier(SpellcastingAbility);
            }
        }

        #endregion Header Block

        #region Cantrips

        public List<string> Cantrips
        {
            get
            {
                return model.Cantrips;
            }
            set
            {
                if (model.Cantrips != value)
                {
                    model.Cantrips = value;
                    OnPropertyChanged("MyProperty");
                }
            }
        }

        #endregion Cantrips

        #region Level 1 Spells

        public int Level1SlotsTotal
        {
            get
            {
                return model.Level1SlotsTotal;
            }
            set
            {
                if (model.Level1SlotsTotal != value)
                {
                    model.Level1SlotsTotal = value;
                    OnPropertyChanged("Level1SlotsTotal");
                }
            }
        }

        public int Level1SlotsExpended
        {
            get
            {
                return model.Level1SlotsExpended;
            }
            set
            {
                if (model.Level1SlotsExpended != value)
                {
                    model.Level1SlotsExpended = value;
                    OnPropertyChanged("Level1SlotsExpended");
                }
            }
        }

        public List<string> Level1Spells
        {
            get
            {
                return model.Level1Spells;
            }
            set
            {
                if (model.Level1Spells != value)
                {
                    model.Level1Spells = value;
                    OnPropertyChanged("Level1Spells");
                }
            }
        }

        #endregion Level 1 Spells

        #region Level 2 Spells

        public int Level2SlotsTotal
        {
            get
            {
                return model.Level2SlotsTotal;
            }
            set
            {
                if (model.Level2SlotsTotal != value)
                {
                    model.Level2SlotsTotal = value;
                    OnPropertyChanged("Level2SlotsTotal");
                }
            }
        }

        public int Level2SlotsExpended
        {
            get
            {
                return model.Level2SlotsExpended;
            }
            set
            {
                if (model.Level2SlotsExpended != value)
                {
                    model.Level2SlotsExpended = value;
                    OnPropertyChanged("Level2SlotsExpended");
                }
            }
        }

        public List<string> Level2Spells
        {
            get
            {
                return model.Level2Spells;
            }
            set
            {
                if (model.Level2Spells != value)
                {
                    model.Level2Spells = value;
                    OnPropertyChanged("Level2Spells");
                }
            }
        }

        #endregion Level 2 Spells

        #region Level 3 Spells

        public int Level3SlotsTotal
        {
            get
            {
                return model.Level3SlotsTotal;
            }
            set
            {
                if (model.Level3SlotsTotal != value)
                {
                    model.Level3SlotsTotal = value;
                    OnPropertyChanged("Level3SlotsTotal");
                }
            }
        }

        public int Level3SlotsExpended
        {
            get
            {
                return model.Level3SlotsExpended;
            }
            set
            {
                if (model.Level3SlotsExpended != value)
                {
                    model.Level3SlotsExpended = value;
                    OnPropertyChanged("Level3SlotsExpended");
                }
            }
        }

        public List<string> Level3Spells
        {
            get
            {
                return model.Level3Spells;
            }
            set
            {
                if (model.Level3Spells != value)
                {
                    model.Level3Spells = value;
                    OnPropertyChanged("Level3Spells");
                }
            }
        }

        #endregion Level 3 Spells

        #region Level 4 Spells

        public int Level4SlotsTotal
        {
            get
            {
                return model.Level4SlotsTotal;
            }
            set
            {
                if (model.Level4SlotsTotal != value)
                {
                    model.Level4SlotsTotal = value;
                    OnPropertyChanged("Level4SlotsTotal");
                }
            }
        }

        public int Level4SlotsExpended
        {
            get
            {
                return model.Level4SlotsExpended;
            }
            set
            {
                if (model.Level4SlotsExpended != value)
                {
                    model.Level4SlotsExpended = value;
                    OnPropertyChanged("Level4SlotsExpended");
                }
            }
        }

        public List<string> Level4Spells
        {
            get
            {
                return model.Level4Spells;
            }
            set
            {
                if (model.Level4Spells != value)
                {
                    model.Level4Spells = value;
                    OnPropertyChanged("Level4Spells");
                }
            }
        }

        #endregion Level 4 Spells

        #region Level 5 Spells

        public int Level5SlotsTotal
        {
            get
            {
                return model.Level5SlotsTotal;
            }
            set
            {
                if (model.Level5SlotsTotal != value)
                {
                    model.Level5SlotsTotal = value;
                    OnPropertyChanged("Level5SlotsTotal");
                }
            }
        }

        public int Level5SlotsExpended
        {
            get
            {
                return model.Level5SlotsExpended;
            }
            set
            {
                if (model.Level5SlotsExpended != value)
                {
                    model.Level5SlotsExpended = value;
                    OnPropertyChanged("Level5SlotsExpended");
                }
            }
        }

        public List<string> Level5Spells
        {
            get
            {
                return model.Level5Spells;
            }
            set
            {
                if (model.Level5Spells != value)
                {
                    model.Level5Spells = value;
                    OnPropertyChanged("Level5Spells");
                }
            }
        }

        #endregion Level 5 Spells

        #region Level 6 Spells

        public int Level6SlotsTotal
        {
            get
            {
                return model.Level6SlotsTotal;
            }
            set
            {
                if (model.Level6SlotsTotal != value)
                {
                    model.Level6SlotsTotal = value;
                    OnPropertyChanged("Level6SlotsTotal");
                }
            }
        }

        public int Level6SlotsExpended
        {
            get
            {
                return model.Level6SlotsExpended;
            }
            set
            {
                if (model.Level6SlotsExpended != value)
                {
                    model.Level6SlotsExpended = value;
                    OnPropertyChanged("Level6SlotsExpended");
                }
            }
        }

        public List<string> Level6Spells
        {
            get
            {
                return model.Level6Spells;
            }
            set
            {
                if (model.Level6Spells != value)
                {
                    model.Level6Spells = value;
                    OnPropertyChanged("Level6Spells");
                }
            }
        }

        #endregion Level 6 Spells

        #region Level 7 Spells

        public int Level7SlotsTotal
        {
            get
            {
                return model.Level7SlotsTotal;
            }
            set
            {
                if (model.Level7SlotsTotal != value)
                {
                    model.Level7SlotsTotal = value;
                    OnPropertyChanged("Level7SlotsTotal");
                }
            }
        }

        public int Level7SlotsExpended
        {
            get
            {
                return model.Level7SlotsExpended;
            }
            set
            {
                if (model.Level7SlotsExpended != value)
                {
                    model.Level7SlotsExpended = value;
                    OnPropertyChanged("Level7SlotsExpended");
                }
            }
        }

        public List<string> Level7Spells
        {
            get
            {
                return model.Level7Spells;
            }
            set
            {
                if (model.Level7Spells != value)
                {
                    model.Level7Spells = value;
                    OnPropertyChanged("Level7Spells");
                }
            }
        }

        #endregion Level 7 Spells

        #region Level 8 Spells

        public int Level8SlotsTotal
        {
            get
            {
                return model.Level8SlotsTotal;
            }
            set
            {
                if (model.Level8SlotsTotal != value)
                {
                    model.Level8SlotsTotal = value;
                    OnPropertyChanged("Level8SlotsTotal");
                }
            }
        }

        public int Level8SlotsExpended
        {
            get
            {
                return model.Level8SlotsExpended;
            }
            set
            {
                if (model.Level8SlotsExpended != value)
                {
                    model.Level8SlotsExpended = value;
                    OnPropertyChanged("Level8SlotsExpended");
                }
            }
        }

        public List<string> Level8Spells
        {
            get
            {
                return model.Level8Spells;
            }
            set
            {
                if (model.Level8Spells != value)
                {
                    model.Level8Spells = value;
                    OnPropertyChanged("Level8Spells");
                }
            }
        }

        #endregion Level 8 Spells

        #region Level 9 Spells

        public int Level9SlotsTotal
        {
            get
            {
                return model.Level9SlotsTotal;
            }
            set
            {
                if (model.Level9SlotsTotal != value)
                {
                    model.Level9SlotsTotal = value;
                    OnPropertyChanged("Level9SlotsTotal");
                }
            }
        }

        public int Level9SlotsExpended
        {
            get
            {
                return model.Level9SlotsExpended;
            }
            set
            {
                if (model.Level9SlotsExpended != value)
                {
                    model.Level9SlotsExpended = value;
                    OnPropertyChanged("Level9SlotsExpended");
                }
            }
        }

        public List<string> Level9Spells
        {
            get
            {
                return model.Level9Spells;
            }
            set
            {
                if (model.Level9Spells != value)
                {
                    model.Level9Spells = value;
                    OnPropertyChanged("Level9Spells");
                }
            }
        }

        #endregion Level 9 Spells
    }
}
