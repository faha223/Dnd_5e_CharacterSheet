using DnD_5e_CharacterSheet.MVVM;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DnD_5e_CharacterSheet.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public int Age
        {
            get
            {
                return model.Age;
            }
            set
            {
                if (model.Age != value)
                {
                    model.Age = value;
                    OnPropertyChanged("Age");
                }
            }
        }

        public int Height
        {
            get
            {
                return model.Height;
            }
            set
            {
                if (model.Height != value)
                {
                    model.Height = value;
                    OnPropertyChanged("Height");
                }
            }
        }

        public int Weight
        {
            get
            {
                return model.Weight;
            }
            set
            {
                if (model.Weight != value)
                {
                    model.Weight = value;
                    OnPropertyChanged("Weight");
                }
            }
        }

        public string Eyes
        {
            get
            {
                return model.Eyes;
            }
            set
            {
                if (model.Eyes != value)
                {
                    model.Eyes = value;
                    OnPropertyChanged("Eyes");
                }
            }
        }

        public string Skin
        {
            get
            {
                return model.Skin;
            }
            set
            {
                if (model.Skin != value)
                {
                    model.Skin = value;
                    OnPropertyChanged("Skin");
                }
            }
        }

        public string Hair
        {
            get
            {
                return model.Hair;
            }
            set
            {
                if (model.Hair != value)
                {
                    model.Hair = value;
                    OnPropertyChanged("Hair");
                }
            }
        }

        private byte[] CharacterPortrait
        {
            get
            {
                return model.CharacterPortrait;
            }
            set
            {
                model.CharacterPortrait = value;
                OnPropertyChanged("CharacterPortrait");
                OnPropertyChanged("PortraitSource");
            }
        }

        public ImageSource PortraitSource
        {
            get
            {
                return GetBitmapImage(CharacterPortrait);
            }
        }

        public string AlliesAndOrganizations1
        {
            get
            {
                return model.AlliesAndOrganizations1;
            }
            set
            {
                if (model.AlliesAndOrganizations1 != value)
                {
                    model.AlliesAndOrganizations1 = value;
                    OnPropertyChanged("AlliesAndOrganizations1");
                }
            }
        }

        public string AlliesAndOrganizations2
        {
            get
            {
                return model.AlliesAndOrganizations2;
            }
            set
            {
                if (model.AlliesAndOrganizations2 != value)
                {
                    model.AlliesAndOrganizations2 = value;
                    OnPropertyChanged("AlliesAndOrganizations2");
                }
            }
        }

        public string OrganizationName
        {
            get
            {
                return model.OrganizationName;
            }
            set
            {
                if (model.OrganizationName != value)
                {
                    model.OrganizationName = value;
                    OnPropertyChanged("OrganizationName");
                }
            }
        }

        private byte[] OrganizationSymbol
        {
            get
            {
                return model.OrganizationSymbol;
            }
            set
            {
                model.OrganizationSymbol = value;
                OnPropertyChanged("OrganizationSymbol");
                OnPropertyChanged("SymbolSource");
            }
        }

        public ImageSource SymbolSource
        {
            get
            {
                return GetBitmapImage(OrganizationSymbol);
            }
        }

        public string CharacterBackstory
        {
            get
            {
                return model.CharacterBackstory;
            }
            set
            {
                if (model.CharacterBackstory != value)
                {
                    model.CharacterBackstory = value;
                    OnPropertyChanged("CharacterBackstory");
                }
            }
        }

        public string AdditionalFeaturesAndTraits1
        {
            get
            {
                return model.AdditionalFeaturesAndTraits1;
            }
            set
            {
                if (model.AdditionalFeaturesAndTraits1 != value)
                {
                    model.AdditionalFeaturesAndTraits1 = value;
                    OnPropertyChanged("AdditionalFeaturesAndTraits1");
                }
            }
        }

        public string AdditionalFeaturesAndTraits2
        {
            get
            {
                return model.AdditionalFeaturesAndTraits2;
            }
            set
            {
                if (model.AdditionalFeaturesAndTraits2 != value)
                {
                    model.AdditionalFeaturesAndTraits2 = value;
                    OnPropertyChanged("AdditionalFeaturesAndTraits2");
                }
            }
        }

        public string Treasure1
        {
            get
            {
                return model.Treasure1;
            }
            set
            {
                if (model.Treasure1 != value)
                {
                    model.Treasure1 = value;
                    OnPropertyChanged("Treasure1");
                }
            }
        }

        public string Treasure2
        {
            get
            {
                return model.Treasure2;
            }
            set
            {
                if (model.Treasure2 != value)
                {
                    model.Treasure2 = value;
                    OnPropertyChanged("Treasure2");
                }
            }
        }

        #region Load Portrait Command

        internal void LoadPortrait()
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "All Images (*.bmp, *.png, *.jpg, *.tiff)|*.bmp;*.jpg;*.png;*.tiff";
            var result = dlg.ShowDialog();
            if(result.HasValue && result.Value)
            {
                CharacterPortrait = File.ReadAllBytes(dlg.FileName);
            }
        }

        public ICommand LoadPortraitCommand { get { return new ParameterlessCommandRouter(LoadPortrait, null); } }

        #endregion Load Portrait Command

        #region Load Symbol Command

        internal void LoadSymbol()
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "All Images (*.bmp, *.png, *.jpg, *.tiff)|*.bmp;*.jpg;*.png;*.tiff";
            var result = dlg.ShowDialog();
            if (result.HasValue && result.Value)
            {
                OrganizationSymbol = File.ReadAllBytes(dlg.FileName);
            }
        }

        public ICommand LoadSymbolCommand { get { return new ParameterlessCommandRouter(LoadSymbol, null); } }

        #endregion Load Symbol Command

        #region Helpers

        ImageSource GetBitmapImage(byte[] data)
        {
            if (data != null)
            {
                var img = new BitmapImage();
                img.BeginInit();
                img.StreamSource = new MemoryStream(data);
                img.CacheOption = BitmapCacheOption.OnLoad;
                img.EndInit();
                img.Freeze();
                return img;
            }
            return null;
        }

        #endregion Helpers
    }
}
