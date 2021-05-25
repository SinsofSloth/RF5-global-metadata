[Serializable]
public class TimeManager : SingletonMonoBehaviour<TimeManager> // TypeDefIndex: 6886
{
	// Fields
	public const int OneHour = 60;
	public const int OneDay = 1440;
	public const int OneWeek = 8640;
	public const int OneSeason = 43200;
	public const int OneYear = 172800;
	public const int MaxMinute = 60;
	public const int MaxHour = 24;
	public const int MaxDay = 30;
	public const int MaxWeek = 5;
	public const int MaxSeason = 4;
	public const int MaxYear = 9999;
	public const int DayBorderHour = 6;
	public const int WeatherChangeHourInterval = 3;
	private const int ForceSunnyTime = 6119;
	private const int WeatherJointMinute = 30;
	[SerializeField] // RVA: 0x15FF20 Offset: 0x160021 VA: 0x15FF20
	public Weather[] WeatherHour; // 0x18
	private Weather[] _ForceWeatherHour; // 0x20
	[SerializeField] // RVA: 0x15FF30 Offset: 0x160031 VA: 0x15FF30
	public WeatherDay WeatherDay; // 0x28
	public WeatherDay NextWeatherDay; // 0x2C
	public WeatherDay ForceWeatherDay; // 0x30
	public int TyphoonDayCount; // 0x34
	private int RoonyDayCount; // 0x38
	private int MeteorShowerDayCount; // 0x3C
	private int TodayRate; // 0x40
	private float innerElapsedSecounds; // 0x44
	private TimeZone prevTimeZone; // 0x48
	public OnCarryTimeEvent OnSecondsCarry; // 0x50
	public OnCarryTimeEvent OnHourCarry; // 0x58
	public OnCarryTimeEvent OnDayCarry; // 0x60
	public OnCarryTimeEvent OnSeasonCarry; // 0x68
	public UnityEvent OnSleep; // 0x70
	private Dictionary<int, List<TimeManager.JustTimerData>> JustTimerDictionary; // 0x78
	private static readonly int[][] _WetherBaseRate; // 0x0

	// Properties
	public Weather SceneShowWeather { get; }
	public Weather ShowWeather { get; }
	public Weather Weather { get; }
	public Weather[] ForceWeatherHour { get; set; }
	public int ElapsedTime { get; set; }
	public int Year { get; }
	public Season Season { get; }
	public int Week { get; }
	public DayOfWeek DayOfWeek { get; }
	public DayOfWeek SalesDay { get; }
	public int ElapsedDay { get; }
	public int ElapsedMinutesMorning { get; }
	public int Day { get; }
	public int Hour { get; }
	public int Minutes { get; }
	public int AMPMHour { get; }
	public string AMPMText { get; }
	public float DailyRatio { get; }
	public TimeZone TimeZone { get; }
	public TimeManager.RFTimeInt CurrentTimeInt { get; }

	// Methods

	// RVA: 0x1D17430 Offset: 0x1D17531 VA: 0x1D17430
	public static int CalcDateDay(int elapsedTime) { }

	// RVA: 0x1D17480 Offset: 0x1D17581 VA: 0x1D17480
	public static int CalcDateHour(int elapsedTime) { }

	// RVA: 0x1D174C0 Offset: 0x1D175C1 VA: 0x1D174C0
	public static int CalcDateMinutes(int elapsedTime) { }

	// RVA: 0x1D174F0 Offset: 0x1D175F1 VA: 0x1D174F0
	public static int CalcDateYear(int elapsedTime) { }

	// RVA: 0x1D17520 Offset: 0x1D17621 VA: 0x1D17520
	public static Season CalcDateSeason(int elapsedTime) { }

	// RVA: 0x1D17560 Offset: 0x1D17661 VA: 0x1D17560
	public static int CalcDateWeek(int elapsedTime) { }

	// RVA: 0x1D175B0 Offset: 0x1D176B1 VA: 0x1D175B0
	public static DayOfWeek CalcDateDayOfWeek(int elapsedTime) { }

	// RVA: 0x1D17670 Offset: 0x1D17771 VA: 0x1D17670
	public static int CalcDateTime(int year, Season season, int day, int hour, int min) { }

	// RVA: 0x1D17750 Offset: 0x1D17851 VA: 0x1D17750
	public static int CalcDateTime(int year, int season, int day, int hour, int min) { }

	// RVA: 0x1D177C0 Offset: 0x1D178C1 VA: 0x1D177C0
	public static int CalcTimeSpan(int year, int season, int day, int hour, int min) { }

	// RVA: 0x1D177F0 Offset: 0x1D178F1 VA: 0x1D177F0
	public static int CalcElapsedDay(int elapsedTime) { }

	// RVA: 0x1D17820 Offset: 0x1D17921 VA: 0x1D17820
	public Weather get_SceneShowWeather() { }

	// RVA: 0x1D17910 Offset: 0x1D17A11 VA: 0x1D17910
	public Weather get_ShowWeather() { }

	// RVA: 0x1D17B00 Offset: 0x1D17C01 VA: 0x1D17B00
	public Weather get_Weather() { }

	// RVA: 0x1D17BF0 Offset: 0x1D17CF1 VA: 0x1D17BF0
	public Weather[] get_ForceWeatherHour() { }

	// RVA: 0x1D17C00 Offset: 0x1D17D01 VA: 0x1D17C00
	private void set_ForceWeatherHour(Weather[] value) { }

	// RVA: 0x1D17C10 Offset: 0x1D17D11 VA: 0x1D17C10
	public void SetScenarioStoppedTime(int toYear, int toSeason, int toDay, int toHour, int toMinutes) { }

	// RVA: 0x1D17D20 Offset: 0x1D17E21 VA: 0x1D17D20
	public void SetScenarioStoppedTimeNow() { }

	// RVA: 0x1D17D90 Offset: 0x1D17E91 VA: 0x1D17D90
	public int GetSenarioStoppedTime() { }

	// RVA: 0x1D17DC0 Offset: 0x1D17EC1 VA: 0x1D17DC0
	public static string TimeToString(int time) { }

	// RVA: 0x1D18150 Offset: 0x1D18251 VA: 0x1D18150 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D17D60 Offset: 0x1D17E61 VA: 0x1D17D60
	public int get_ElapsedTime() { }

	// RVA: 0x1D19AE0 Offset: 0x1D19BE1 VA: 0x1D19AE0
	public void set_ElapsedTime(int value) { }

	// RVA: 0x1D19B10 Offset: 0x1D19C11 VA: 0x1D19B10
	public TimeManager.RFDateTime CurrentDate() { }

	// RVA: 0x1D18740 Offset: 0x1D18841 VA: 0x1D18740
	public int get_Year() { }

	// RVA: 0x1D187D0 Offset: 0x1D188D1 VA: 0x1D187D0
	public Season get_Season() { }

	// RVA: 0x1D18880 Offset: 0x1D18981 VA: 0x1D18880
	public int get_Week() { }

	// RVA: 0x1D19B40 Offset: 0x1D19C41 VA: 0x1D19B40
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x1D19C70 Offset: 0x1D19D71 VA: 0x1D19C70
	public DayOfWeek get_SalesDay() { }

	// RVA: 0x1D19C80 Offset: 0x1D19D81 VA: 0x1D19C80
	public int get_ElapsedDay() { }

	// RVA: 0x1D19D10 Offset: 0x1D19E11 VA: 0x1D19D10
	public int get_ElapsedMinutesMorning() { }

	// RVA: 0x1D18930 Offset: 0x1D18A31 VA: 0x1D18930
	public int get_Day() { }

	// RVA: 0x1D189F0 Offset: 0x1D18AF1 VA: 0x1D189F0
	public int get_Hour() { }

	// RVA: 0x1D18AA0 Offset: 0x1D18BA1 VA: 0x1D18AA0
	public int get_Minutes() { }

	// RVA: 0x1D19E00 Offset: 0x1D19F01 VA: 0x1D19E00
	public int get_AMPMHour() { }

	// RVA: 0x1D19F50 Offset: 0x1D1A051 VA: 0x1D19F50
	public string get_AMPMText() { }

	// RVA: 0x1D1A190 Offset: 0x1D1A291 VA: 0x1D1A190
	public float get_DailyRatio() { }

	// RVA: 0x1D1A240 Offset: 0x1D1A341 VA: 0x1D1A240
	public TimeManager.DaysInfo GetAnotherDayInfo(int AddDayCount) { }

	// RVA: 0x1D18B40 Offset: 0x1D18C41 VA: 0x1D18B40
	public TimeZone get_TimeZone() { }

	// RVA: 0x1D1A340 Offset: 0x1D1A441 VA: 0x1D1A340
	public TimeManager.RFTimeInt get_CurrentTimeInt() { }

	// RVA: 0x1D1A610 Offset: 0x1D1A711 VA: 0x1D1A610 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1D1A6C0 Offset: 0x1D1A7C1 VA: 0x1D1A6C0
	public void Start() { }

	// RVA: 0x1D1A6F0 Offset: 0x1D1A7F1 VA: 0x1D1A6F0
	public void Update() { }

	// RVA: 0x1D1ADB0 Offset: 0x1D1AEB1 VA: 0x1D1ADB0
	public TimeManager.JustTimerData SetJustTimer(int time, Action<TimeManager.JustTimerData> action, Object callObject) { }

	// RVA: 0x1D1AF60 Offset: 0x1D1B061 VA: 0x1D1AF60
	public bool CancelTimer(TimeManager.JustTimerData timerData) { }

	// RVA: 0x1D1B050 Offset: 0x1D1B151 VA: 0x1D1B050
	private void CheckWithExecuteJustTimer(int time) { }

	// RVA: 0x1D1B240 Offset: 0x1D1B341 VA: 0x1D1B240
	public void ChangeTime(int toYear, int toSeason, int toDay, int toHour, int toMinutes, bool notChangePreviousTime) { }

	// RVA: 0x1D1B5C0 Offset: 0x1D1B6C1 VA: 0x1D1B5C0
	public void ChangeTimeNextDay(int toHour, int toMinutes) { }

	// RVA: 0x1D1B740 Offset: 0x1D1B841 VA: 0x1D1B740
	public void ChangeTimePrevDay(int toHour, int toMinutes) { }

	// RVA: 0x1D1A7D0 Offset: 0x1D1A8D1 VA: 0x1D1A7D0
	public void AdvanceTime(int addTime) { }

	// RVA: 0x1D1BCF0 Offset: 0x1D1BDF1 VA: 0x1D1BCF0
	public void ToNextMorning() { }

	// RVA: 0x1D1BFB0 Offset: 0x1D1C0B1 VA: 0x1D1BFB0
	private int RandomIndex(int[] pRand, int num) { }

	// RVA: 0x1D1C0B0 Offset: 0x1D1C1B1 VA: 0x1D1C0B0
	public bool IsForceSunnyDay(int CheckTime = -1) { }

	// RVA: 0x1D1C200 Offset: 0x1D1C301 VA: 0x1D1C200
	public void UpdateWeatherDay() { }

	// RVA: 0x1D1CAD0 Offset: 0x1D1CBD1 VA: 0x1D1CAD0
	private void CheckWeatherDayType(TimeManager.LotteryWeatherType lotteryWeatherType, out WeatherDay weatherDay) { }

	// RVA: 0x1D1C630 Offset: 0x1D1C731 VA: 0x1D1C630
	public void LotteryWeatherHour(WeatherDay weatherDay, ref Weather[] weatherHour, bool setPrevWeather = True, bool setPrevDay = False) { }

	// RVA: 0x1D1CB00 Offset: 0x1D1CC01 VA: 0x1D1CB00
	public void LotteryForceWeatherHour(WeatherDay weatherDay) { }

	// RVA: 0x1D1CB10 Offset: 0x1D1CC11 VA: 0x1D1CB10
	public int GetTyphoonCount() { }

	// RVA: 0x1D1CB20 Offset: 0x1D1CC21 VA: 0x1D1CB20
	public void SetTyphoonCount(int setDayCount) { }

	// RVA: 0x1D1CBC0 Offset: 0x1D1CCC1 VA: 0x1D1CBC0
	public void AddTyphoonCount(int addDayCount) { }

	// RVA: 0x1D1CC60 Offset: 0x1D1CD61 VA: 0x1D1CC60
	public bool CanAddTyphoonCount(int addDayCount) { }

	// RVA: 0x1D1CCA0 Offset: 0x1D1CDA1 VA: 0x1D1CCA0
	public int GetRoonyDayCount() { }

	// RVA: 0x1D1CCB0 Offset: 0x1D1CDB1 VA: 0x1D1CCB0
	public int GetMeteorShowerDayCount() { }

	// RVA: 0x1D1CCC0 Offset: 0x1D1CDC1 VA: 0x1D1CCC0
	public void ChangeFieldBGMByTime(int elapsedHour) { }

	// RVA: 0x1D1CE10 Offset: 0x1D1CF11 VA: 0x1D1CE10
	public BGMID GetFiledBGMId() { }

	// RVA: 0x1D1CD30 Offset: 0x1D1CE31 VA: 0x1D1CD30
	public void PlayFieldBGM() { }

	// RVA: 0x1D1CF70 Offset: 0x1D1D071 VA: 0x1D1CF70
	private BGMID GetMakingBgmId() { }

	// RVA: 0x1D1D160 Offset: 0x1D1D261 VA: 0x1D1D160
	public void BeforeSaveData(RF5WorldData saveData) { }

	// RVA: 0x1D1D2B0 Offset: 0x1D1D3B1 VA: 0x1D1D2B0
	public void AfterLoadData(RF5WorldData saveData) { }

	// RVA: 0x1D1D380 Offset: 0x1D1D481 VA: 0x1D1D380
	public bool IsMidnightLastYearFes() { }

	// RVA: 0x1D1D560 Offset: 0x1D1D661 VA: 0x1D1D560
	public bool IsMidnightLastYearFes(int _day, int _hour) { }

	// RVA: 0x1D1D620 Offset: 0x1D1D721 VA: 0x1D1D620
	public bool IsEarlyMorningLastYearFes() { }

	// RVA: 0x1D1D880 Offset: 0x1D1D981 VA: 0x1D1D880
	public bool IsFestival(Event eventId) { }

	// RVA: 0x1D1DC60 Offset: 0x1D1DD61 VA: 0x1D1DC60
	public int GetFestivalId(int ChkSeason, int ChkDay) { }

	// RVA: 0x1D1DF40 Offset: 0x1D1E041 VA: 0x1D1DF40
	public Event GetFestivalEventId() { }

	// RVA: 0x1D1E090 Offset: 0x1D1E191 VA: 0x1D1E090
	public Event GetNextDayFestivalEventId() { }

	// RVA: 0x1D1E1E0 Offset: 0x1D1E2E1 VA: 0x1D1E1E0
	public Event GetInsideFestivalEventId() { }

	// RVA: 0x1D1C1E0 Offset: 0x1D1C2E1 VA: 0x1D1C1E0
	public Event GetFestivalEventId(int ChkSeason, int ChkDay) { }

	// RVA: 0x1D1E340 Offset: 0x1D1E441 VA: 0x1D1E340
	public bool IsNewYear() { }

	// RVA: 0x1D1E480 Offset: 0x1D1E581 VA: 0x1D1E480
	public bool IsFirstDay() { }

	// RVA: 0x1D1B8C0 Offset: 0x1D1B9C1 VA: 0x1D1B8C0
	public int GetInsideHour(int time = -1) { }

	// RVA: 0x1D1B980 Offset: 0x1D1BA81 VA: 0x1D1B980
	public int GetInsideDay(int time = -1) { }

	// RVA: 0x1D1BA50 Offset: 0x1D1BB51 VA: 0x1D1BA50
	public Season GetInsideSeason(int time = -1) { }

	// RVA: 0x1D1BB10 Offset: 0x1D1BC11 VA: 0x1D1BB10
	public int GetInsideYear(int time = -1) { }

	// RVA: 0x1D17A20 Offset: 0x1D17B21 VA: 0x1D17A20
	public int GetWeatherHourIndex(int time = -1) { }

	// RVA: 0x1D1E530 Offset: 0x1D1E631 VA: 0x1D1E530
	public Weather GetWeatherHour(int time = -1) { }

	// RVA: 0x1D1E640 Offset: 0x1D1E741 VA: 0x1D1E640
	public void .ctor() { }

	// RVA: 0x1D1E810 Offset: 0x1D1E911 VA: 0x1D1E810
	private static void .cctor() { }
}

