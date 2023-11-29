using System;
using System.Collections.ObjectModel;

namespace poc_maui.ViewModels
{
	public class CardsPageViewModel : BaseViewModel
    {
		public CardsPageViewModel()
		{
            LoadCards();
		}

        private void LoadCards()
        {
            PlayerA_Card_1 = "imagea_svg.png";
            PlayerA_Card_2 = "imageb_svg.png";
            PlayerB_Card_1 = "imagec_svg.png";
            PlayerB_Card_2 = "imaged_svg.png";
            PlayerC_Card_1 = "imagee_svg.png";
            PlayerC_Card_2 = "imagef_svg.png";
            PlayerD_Card_1 = "imageg_svg.png";
            PlayerD_Card_2 = "imagea_svg.png";

            PlayerA_Shuffile_Card = "backside.png";
            PlayerB_Shuffile_Card = "backside.png";
            PlayerC_Shuffile_Card = "backside.png";
            PlayerD_Shuffile_Card = "backside.png";
            Center_Card = "backside.png";
            New_Card_1 = "backside.png";
            New_Card_2 = "backside.png";
        }

        public string PlayerA_Card_1
        {
            get { return _playerA_Card_1; }
            set { _playerA_Card_1 = value; OnPropertyChanged(nameof(PlayerA_Card_1)); }
        }
        private string _playerA_Card_1;

        public string PlayerA_Card_2
        {
            get { return _playerA_Card_2; }
            set { _playerA_Card_2 = value; OnPropertyChanged(nameof(PlayerA_Card_2)); }
        }
        private string _playerA_Card_2;

        public string PlayerA_Shuffile_Card
        {
            get { return _playerA_Shuffile_Card; }
            set { _playerA_Shuffile_Card = value; OnPropertyChanged(nameof(PlayerA_Shuffile_Card)); }
        }
        private string _playerA_Shuffile_Card;

        public string PlayerB_Card_1
        {
            get { return _playerB_Card_1; }
            set { _playerB_Card_1 = value; OnPropertyChanged(nameof(PlayerB_Card_1)); }
        }
        private string _playerB_Card_1;

        public string PlayerB_Card_2
        {
            get { return _playerB_Card_2; }
            set { _playerB_Card_2 = value; OnPropertyChanged(nameof(PlayerB_Card_2)); }
        }
        private string _playerB_Card_2;

        public string PlayerB_Shuffile_Card
        {
            get { return _playerB_Shuffile_Card; }
            set { _playerB_Shuffile_Card = value; OnPropertyChanged(nameof(PlayerB_Shuffile_Card)); }
        }
        private string _playerB_Shuffile_Card;

        public string PlayerC_Card_1
        {
            get { return _playerC_Card_1; }
            set { _playerC_Card_1 = value; OnPropertyChanged(nameof(PlayerC_Card_1)); }
        }
        private string _playerC_Card_1;

        public string PlayerC_Card_2
        {
            get { return _playerC_Card_2; }
            set { _playerC_Card_2 = value; OnPropertyChanged(nameof(PlayerC_Card_2)); }
        }
        private string _playerC_Card_2;

        public string PlayerC_Shuffile_Card
        {
            get { return _playerC_Shuffile_Card; }
            set { _playerC_Shuffile_Card = value; OnPropertyChanged(nameof(PlayerC_Shuffile_Card)); }
        }
        private string _playerC_Shuffile_Card;

        public string PlayerD_Card_1
        {
            get { return _playerD_Card_1; }
            set { _playerD_Card_1 = value; OnPropertyChanged(nameof(PlayerD_Card_1)); }
        }
        private string _playerD_Card_1;

        public string PlayerD_Card_2
        {
            get { return _playerD_Card_2; }
            set { _playerD_Card_2 = value; OnPropertyChanged(nameof(PlayerD_Card_2)); }
        }
        private string _playerD_Card_2;

        public string PlayerD_Shuffile_Card
        {
            get { return _playerD_Shuffile_Card; }
            set { _playerD_Shuffile_Card = value; OnPropertyChanged(nameof(PlayerD_Shuffile_Card)); }
        }
        private string _playerD_Shuffile_Card;

        public string Center_Card
        {
            get { return _center_Card; }
            set { _center_Card = value; OnPropertyChanged(nameof(Center_Card)); }
        }
        private string _center_Card;

        public string New_Card_1
        {
            get { return _new_Card_1; }
            set { _new_Card_1 = value; OnPropertyChanged(nameof(New_Card_1)); }
        }
        private string _new_Card_1;

        public string New_Card_2
        {
            get { return _new_Card_2; }
            set { _new_Card_2 = value; OnPropertyChanged(nameof(New_Card_2)); }
        }
        private string _new_Card_2;
    }
}

