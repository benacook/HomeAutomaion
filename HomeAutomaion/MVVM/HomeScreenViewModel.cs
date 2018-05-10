using Commands;
using ViewModels;
using System;
using System.Net;
using System.Net.NetworkInformation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Zwave;
using Sensors;
using System.Diagnostics;
using Windows.Storage;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ViewModels.HomeScreen
{
    internal class HomeScreenViewModel : ViewModelBase
    {
//=============================================================================
// Living Room Bindings
//=============================================================================
        #region Dec Var
        public EnvironmentSensor HomeHub =
        new EnvironmentSensor("Living Room", 17, 70, "192.168.0.17", 10000);
        private DispatcherTimer _dispatchTimer;
        internal const string MinimumTemperatureKey = "MinimumTemp";
        internal const string MaximumHumidityKey = "MaximumHumidity";
        ZwaveHomeHub zwaveHomeHub = new ZwaveHomeHub("192.168.0.17");
        #endregion

        //=============================================================================
        // Living Room Bindings
        //=============================================================================

        #region LivingRoomBindings

        private string _livingRoomTemperatre;

        public string LivingRoomTemperature
        {
            get { return _livingRoomTemperatre; }
            set
            {
                if (_livingRoomTemperatre == value) return;
                _livingRoomTemperatre = value;
                RaisePropertyChanged("LivingRoomTemperature");
            }
        }

        private double _livingRoomTemperatreScaled;

        public double LivingRoomTemperatureScaled
        {
            get { return _livingRoomTemperatreScaled; }
            set
            {
                if (_livingRoomTemperatreScaled == value) return;
                _livingRoomTemperatreScaled = value;
                RaisePropertyChanged("LivingRoomTemperatureScaled");
            }
        }

        private string _livingRoomHumidity;

        public string LivingRoomHumidity
        {
            get { return _livingRoomHumidity; }
            set
            {
                if (_livingRoomHumidity == value) return;
                _livingRoomHumidity = value;
                RaisePropertyChanged("LivingRoomHumidity");
            }
        }

        private double _livingRoomHumidityScaled;

        public double LivingRoomHumidityScaled
        {
            get { return _livingRoomHumidityScaled; }
            set
            {
                if (_livingRoomHumidityScaled == value) return;
                _livingRoomHumidityScaled = value;
                RaisePropertyChanged("LivingRoomHumidityScaled");
            }
        }
        #endregion Commands

//=============================================================================
// Master Bedroom Bindings
//=============================================================================

        #region MasterBedroomBindings

        private string _masterBedroomTemperatre;

        public string MasterBedroomTemperature
        {
            get { return _masterBedroomTemperatre; }
            set
            {
                if (_masterBedroomTemperatre == value) return;
                _masterBedroomTemperatre = value;
                RaisePropertyChanged("MasterBedroomTemperature");
            }
        }

        private double _masterBedroomTemperatreScaled;

        public double MasterBedroomTemperatureScaled
        {
            get { return _masterBedroomTemperatreScaled; }
            set
            {
                if (_masterBedroomTemperatreScaled == value) return;
                _masterBedroomTemperatreScaled = value;
                RaisePropertyChanged("MasterBedroomTemperatureScaled");
            }
        }

        private string _masterBedroomHumidity;

        public string MasterBedroomHumidity
        {
            get { return _masterBedroomHumidity; }
            set
            {
                if (_masterBedroomHumidity == value) return;
                _masterBedroomHumidity = value;
                RaisePropertyChanged("MasterBedroomHumidity");
            }
        }

        private double _masterBedroomHumidityScaled;

        public double MasterBedroomHumidityScaled
        {
            get { return _masterBedroomHumidityScaled; }
            set
            {
                if (_masterBedroomHumidityScaled == value) return;
                _masterBedroomHumidityScaled = value;
                RaisePropertyChanged("MasterBedroomHumidityScaled");
            }
        }
        #endregion Commands

//=============================================================================
// Settings Bindings
//=============================================================================

        #region Settings Bindings

        private int _maximumHumidity;

        public int MaximumHumidity
        {
            get { return _maximumHumidity; }
            set
            {
                if (_maximumHumidity == value) return;
                _maximumHumidity = value;
                RaisePropertyChanged("MaximumHumidity");
                // save settings
                var settingValues = ApplicationData.Current.LocalSettings.Values;
                settingValues[MinimumTemperatureKey] = value;
            }
        }

        private int _minimumTemperature;

        public int MinimumTemperature
        {
            get { return _minimumTemperature; }
            set
            {
                if (_minimumTemperature == value) return;
                _minimumTemperature = value;
                RaisePropertyChanged("MinimumTemperature");
                var settingValues = ApplicationData.Current.LocalSettings.Values;
                settingValues[MaximumHumidityKey] = value;
            }
        }
        #endregion Commands

//=============================================================================
// Show/Hide Bindings
//=============================================================================
        #region show/hide bindings
        private Visibility _alarmIndicatorShow = Visibility.Collapsed;

        public Visibility AlarmIndicatorShow
        {
            get { return _alarmIndicatorShow; }
            set
            {
                if (_alarmIndicatorShow == value) return;
                _alarmIndicatorShow = value;
                RaisePropertyChanged("AlarmIndicatorShow");
            }
        }

        private Visibility _alarmWindowShow = Visibility.Collapsed;

        public Visibility AlarmWindowShow
        {
            get { return _alarmWindowShow; }
            set
            {
                if (_alarmWindowShow == value) return;
                _alarmWindowShow = value;
                RaisePropertyChanged("AlarmWindowShow");
            }
        }
        #endregion

//=============================================================================
// Alarm List Bindings
//=============================================================================
        #region Alarm list bindings
        private ObservableCollection<string> _alarmList =
            new ObservableCollection<string>();

        public ObservableCollection<string> AlarmList
        {
            get { return _alarmList; }
            set
            {
                if (_alarmList == value) return;
                _alarmList = value;
                RaisePropertyChanged("AlarmList");
            }
        }
        #endregion

//=============================================================================
// CommandBase Properties
//=============================================================================
        #region CommandBase Properties

        public CommandBase ToggleLivingRoomLamp { get; set; }
        public CommandBase ToggleAlarmWindow { get; set; }

        #endregion CommandBase Properties

//=============================================================================
// View Model Constructor
//=============================================================================
        public HomeScreenViewModel()
        {
            InitialiseCommands();
            InitialiseDispatch();
            InitialiseSettings();

        }

//=============================================================================
// Initialisation
//=============================================================================
        #region Initialisation
        private void InitialiseCommands()
        {
            #region Main Window Page Control

            ToggleLivingRoomLamp = new CommandBase(ToggleLivingRoomLamp_ExecuteAsync);
            ToggleAlarmWindow = new CommandBase(ToggleAlarmWindow_Execute);

            #endregion Main Window Page Control

        }

        private void InitialiseDispatch()
        {
            _dispatchTimer = new DispatcherTimer();
            _dispatchTimer.Interval = TimeSpan.FromMilliseconds(1000);
            _dispatchTimer.Tick += _dispatchTimer_TickAsync;
            _dispatchTimer.Start();

        }

        private void InitialiseSettings()
        {
            var settingValues = ApplicationData.Current.LocalSettings.Values;
            object settings;
            if (settingValues.TryGetValue(MaximumHumidityKey, out settings))
            {
                MaximumHumidity = (int)settings;   
            }
            if (settingValues.TryGetValue(MinimumTemperatureKey, out settings))
            {
                MinimumTemperature = (int)settings;
            }
        }
        #endregion

        #region UI Commands

//=============================================================================
// Z Wave Commands
//=============================================================================
        #region Z Wave Commands

        //=======================================================================
        //Toggle Living Room Lamp
        //=======================================================================
        private async void ToggleLivingRoomLamp_ExecuteAsync(object sender, EventArgs e)
        {
            OnOffSwitch LivingRoomLamp = new OnOffSwitch(2, "Socket Front Left");
            await LivingRoomLamp.GetValue();
            if (LivingRoomLamp.LevelInt == 0)
            {
                await LivingRoomLamp.SwitchOn();
            }
            else
            {
                await LivingRoomLamp.SwitchOff();
            }
        }


        #endregion Controls Page Commands

//=============================================================================
// Toggle Alarm Window
//=============================================================================
        #region Toggle Alarm Window

        //=======================================================================
        //Toggle Living Room Lamp
        //=======================================================================
        private void ToggleAlarmWindow_Execute(object sender, EventArgs e)
        {
            if (AlarmWindowShow == Visibility.Collapsed)
            {
                AlarmWindowShow = Visibility.Visible;
            }
            else
            {
                AlarmWindowShow = Visibility.Collapsed;
            }
        }


        #endregion Controls Page Commands

        #endregion UI Commands

        //=============================================================================
        //Timed events
        //=============================================================================
        #region Timed Events
        private async void _dispatchTimer_TickAsync(object sender, object e)
        {
            try
            {
                // Get room data
                await HomeHub.GetData();
                await zwaveHomeHub.GetAsync();
                ;

                //=============================================================
                // Alarms
                //=============================================================
                #region Alarms
                HomeHub.TempAlarmVal = MinimumTemperature;
                HomeHub.HumidityAlarmVal = MaximumHumidity;

                AlarmHandler(HomeHub.RoomData.Livingroom, "Livingroom");
                AlarmHandler(HomeHub.RoomData.MasterBedroom, "Master Bedroom");
                //AlarmHandler(HomeHub.RoomData.Bedroom, "Bedroom");



                void AlarmHandler(EnvironmentSensor.Room room, string roomName)
                {
                    //Humidity Alarm
                    if (HomeHub.HumidityAlarm(room.Humidity))
                    {
                        if (!AlarmList.Contains(roomName + " humidity alarm"))
                        {
                            AlarmList.Add(roomName + " humidity alarm");
                        }
                    }
                    else
                    {
                        AlarmList.Remove(roomName + " humidity alarm");
                    }

                    //Temperature alarm
                    if (HomeHub.TempAlarm(room.Temp))
                    {
                        if (!AlarmList.Contains(roomName + " temperature alarm"))
                            {
                                AlarmList.Add(roomName + " temperature alarm");
                            }
                    }
                    else
                    {
                        AlarmList.Remove(roomName + " temperature alarm");
                    }
                    
                    if (AlarmList != null && AlarmList.Count != 0)
                    {
                        AlarmIndicatorShow = Visibility.Visible;
                    }
                    else
                    {
                        AlarmIndicatorShow = Visibility.Collapsed;
                    }

                }

                
                #endregion

                //=============================================================
                // Living Room Environment
                //=============================================================
                #region Livingroom Environment
                //Update Display
                LivingRoomTemperature =
                    Math.Round(HomeHub.RoomData.Livingroom.Temp) + "°C";
                LivingRoomTemperatureScaled =
                    HomeHub.LivingRoomScaledTemp;
                LivingRoomHumidityScaled =
                    HomeHub.RoomData.Livingroom.Humidity;
                LivingRoomHumidity =
                    Math.Round(HomeHub.RoomData.Livingroom.Humidity) + "%";
                #endregion

                //=============================================================
                // Master Bedroom Environment
                //=============================================================
                #region Master Bedroom Environment
                //Update Display
                MasterBedroomTemperature =
                    Math.Round(HomeHub.RoomData.MasterBedroom.Temp) + "°C";
                MasterBedroomTemperatureScaled =
                    HomeHub.MasterBedroomScaledTemp;
                MasterBedroomHumidityScaled =
                    HomeHub.RoomData.MasterBedroom.Humidity;
                MasterBedroomHumidity =
                    Math.Round(HomeHub.RoomData.MasterBedroom.Humidity) + "%";
                #endregion
            }
            // log any exception that occurs
            catch (Exception ex) 
            {
                Debug.WriteLine(ex.Message);
            }
        }
        #endregion

    }
}