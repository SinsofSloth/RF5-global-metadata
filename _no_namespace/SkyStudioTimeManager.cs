public class SkyStudioTimeManager : SingletonMonoBehaviour<SkyStudioTimeManager> // TypeDefIndex: 6866
{
	// Fields
	private static readonly string[] texturePropertyKeys; // 0x0
	private static readonly string[] colorPropertyKeys; // 0x8
	private static readonly string[] numberPropertyKeys; // 0x10
	private static readonly string[] boolPropertyKeys; // 0x18
	private static readonly string[] badWeatherInvalidColorPropertyKeys; // 0x20
	private static readonly string[] badWeatherRefarColorPropertyKeys; // 0x28
	private static readonly string[] badWeatherInvalidNumberPropertyKeys; // 0x30
	private static readonly string[] badWeatherRefarNumberPropertyKeys; // 0x38
	private const float DefaultSunSize = 0.05;
	private const float CheckValueRateBefore = 0.24861111;
	private const float CheckValueRateAfter = 0.25;
	[SerializeField] // RVA: 0x15FD80 Offset: 0x15FE81 VA: 0x15FD80
	private TimeOfDayController _TimeOfDayController; // 0x18
	[SerializeField] // RVA: 0x15FD90 Offset: 0x15FE91 VA: 0x15FD90
	private Light _SunLight; // 0x20
	[SerializeField] // RVA: 0x15FDA0 Offset: 0x15FEA1 VA: 0x15FDA0
	private Light _MoonLight; // 0x28
	private bool _LightOff; // 0x30
	private bool _CreateCopy; // 0x31
	private SkyProfile _NowSkyProfile; // 0x38
	private SkyProfile _OldSkyProfile; // 0x40
	private SkyProfile _ForceSkyProfile; // 0x48
	[SerializeField] // RVA: 0x15FDB0 Offset: 0x15FEB1 VA: 0x15FDB0
	private SkyProfile _BaseSkyProfile; // 0x50
	[SerializeField] // RVA: 0x15FDC0 Offset: 0x15FEC1 VA: 0x15FDC0
	private SkyProfile _WorkSkyProfile; // 0x58
	[SerializeField] // RVA: 0x15FDD0 Offset: 0x15FED1 VA: 0x15FDD0
	private SkyProfile[] _WeatherSkyProfiles; // 0x60
	[SerializeField] // RVA: 0x15FDE0 Offset: 0x15FEE1 VA: 0x15FDE0
	private SkyProfile _IndoorSkyProfile; // 0x68
	[SerializeField] // RVA: 0x15FDF0 Offset: 0x15FEF1 VA: 0x15FDF0
	private GameObject _LightningSpawnArea; // 0x70
	private int WeatherDayValue; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x15FE00 Offset: 0x15FF01 VA: 0x15FE00
	private FieldSceneData.Data <SceneParam>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x15FE10 Offset: 0x15FF11 VA: 0x15FE10
	private SkyProfile <SceneSkyProfile>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x15FE20 Offset: 0x15FF21 VA: 0x15FE20
	private LensFlare <LensFlare>k__BackingField; // 0xD0
	public Color AdjustFogColor; // 0xD8
	public float AdjustFogColorRate; // 0xE8
	public bool IsAdjustFogColor; // 0xEC
	public float AdjustLuminanceRatio; // 0xF0
	[SerializeField] // RVA: 0x15FE30 Offset: 0x15FF31 VA: 0x15FE30
	private Transform EffectPrefabRoot; // 0xF8
	[SerializeField] // RVA: 0x15FE40 Offset: 0x15FF41 VA: 0x15FE40
	private Transform MeteorShowerPrefabRoot; // 0x100
	private const int MeteorShowerPrefabId = 17389;
	private GameObject MeteorShowerPrefab; // 0x108
	private ParticleSystem[] MeteorShowerParticles; // 0x110
	private bool IsActiveMeteorShower; // 0x118
	private bool IsLoadMeteorShower; // 0x119
	private const int RuneyEffectMax = 16;
	private const int RuneyEffectInterval = 15;
	private const int RuneyEffectVariation = 15;
	private const float RuneyEffectMoveDuration = 4;
	private const float RuneyEffectDelayDuration = 3.5;
	private const float RuneyEffectScale = 0.75;
	private const float RuneyEffectDistance = 0.5;
	private static readonly EffectID[] RuneyEffectIds; // 0x40
	private List<ParticleSystem> RuneyEffectPrefabs; // 0x120
	private List<ParticleSystem> RuneyEffectParticles; // 0x128
	private int RuneyEffectIndex; // 0x130
	private int RuneyEffectIntervalCount; // 0x134
	private const int FireWorkPrefabId = 16174;
	private GameObject FireWorkPrefab; // 0x138
	private ParticleSystem[] FireWorkParticles; // 0x140
	private bool IsActiveFireWork; // 0x148
	private bool IsLoadFireWork; // 0x149
	private const int ConfettiPrefabId = 16173;
	private GameObject ConfettiPrefab; // 0x150
	private ParticleSystem[] ConfettiParticles; // 0x158
	private bool IsActiveConfetti; // 0x160
	private bool IsLoadConfetti; // 0x161
	private float PrevDailyRatio; // 0x164
	private float CheckDailyRatioChangeValue; // 0x168

	// Properties
	public TimeOfDayController TimeOfDayController { get; }
	public Light SunLight { get; set; }
	public Light MoonLight { get; set; }
	public bool IsDispWeatherEffect { get; }
	public FieldSceneData.Data SceneParam { get; set; }
	private SkyProfile SceneSkyProfile { get; set; }
	private LensFlare LensFlare { get; set; }

	// Methods

	// RVA: 0x1C59580 Offset: 0x1C59681 VA: 0x1C59580
	public TimeOfDayController get_TimeOfDayController() { }

	// RVA: 0x1C59590 Offset: 0x1C59691 VA: 0x1C59590
	public Light get_SunLight() { }

	// RVA: 0x1C595A0 Offset: 0x1C596A1 VA: 0x1C595A0
	private void set_SunLight(Light value) { }

	// RVA: 0x1C595B0 Offset: 0x1C596B1 VA: 0x1C595B0
	public Light get_MoonLight() { }

	// RVA: 0x1C595C0 Offset: 0x1C596C1 VA: 0x1C595C0
	private void set_MoonLight(Light value) { }

	// RVA: 0x1C595D0 Offset: 0x1C596D1 VA: 0x1C595D0
	public bool get_IsDispWeatherEffect() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D8D0 Offset: 0x19D9D1 VA: 0x19D8D0
	// RVA: 0x1C59600 Offset: 0x1C59701 VA: 0x1C59600
	public FieldSceneData.Data get_SceneParam() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D8E0 Offset: 0x19D9E1 VA: 0x19D8E0
	// RVA: 0x1C59630 Offset: 0x1C59731 VA: 0x1C59630
	private void set_SceneParam(FieldSceneData.Data value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19D8F0 Offset: 0x19D9F1 VA: 0x19D8F0
	// RVA: 0x1C59660 Offset: 0x1C59761 VA: 0x1C59660
	private SkyProfile get_SceneSkyProfile() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D900 Offset: 0x19DA01 VA: 0x19D900
	// RVA: 0x1C59670 Offset: 0x1C59771 VA: 0x1C59670
	private void set_SceneSkyProfile(SkyProfile value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19D910 Offset: 0x19DA11 VA: 0x19D910
	// RVA: 0x1C59680 Offset: 0x1C59781 VA: 0x1C59680
	private LensFlare get_LensFlare() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D920 Offset: 0x19DA21 VA: 0x19D920
	// RVA: 0x1C59690 Offset: 0x1C59791 VA: 0x1C59690
	private void set_LensFlare(LensFlare value) { }

	// RVA: 0x1C596A0 Offset: 0x1C597A1 VA: 0x1C596A0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1C59800 Offset: 0x1C59901 VA: 0x1C59800
	private void Start() { }

	// RVA: 0x1C59AF0 Offset: 0x1C59BF1 VA: 0x1C59AF0
	public void SetSceneSkyProfile(FieldSceneData.Data teleportSceneParam, string sceneName) { }

	// RVA: 0x1C59D20 Offset: 0x1C59E21 VA: 0x1C59D20
	private bool CheckOverWriteWeather() { }

	// RVA: 0x1C5A020 Offset: 0x1C5A121 VA: 0x1C5A020
	public void SetSceneSkyProfile() { }

	// RVA: 0x1C5A150 Offset: 0x1C5A251 VA: 0x1C5A150
	public void SetCurrentSkyProfile() { }

	// RVA: 0x1C5A6D0 Offset: 0x1C5A7D1 VA: 0x1C5A6D0
	public void SetSkyProfile(SkyProfile skyProfile, bool isCopy = True) { }

	// RVA: 0x1C5A730 Offset: 0x1C5A831 VA: 0x1C5A730
	public void OnDayChangeSetWeather(int elapsedDay) { }

	// RVA: 0x1C5AD50 Offset: 0x1C5AE51 VA: 0x1C5AD50
	public void SetForceWeather(WeatherDay setForceWeather) { }

	// RVA: 0x1C5AC10 Offset: 0x1C5AD11 VA: 0x1C5AC10
	public void SetWorkWeatherProfile() { }

	// RVA: 0x1C5AE50 Offset: 0x1C5AF51 VA: 0x1C5AE50
	public void CreateWeatherDayData(WeatherDay weatherDay, Weather[] skyWeathers) { }

	// RVA: 0x1C5A800 Offset: 0x1C5A901 VA: 0x1C5A800
	public void CreateWeatherDayData(WeatherDay weatherDay, Weather[] skyWeathers, ref SkyProfile workSkyProfile, bool isChangeProfile) { }

	// RVA: 0x1C59E90 Offset: 0x1C59F91 VA: 0x1C59E90
	private void SetLightningSpawnArea(SkyProfile skyProfile) { }

	// RVA: 0x1C5C760 Offset: 0x1C5C861 VA: 0x1C5C760
	private void LoadWeatherEffect(WeatherDay weatherDay) { }

	// RVA: 0x1C5C690 Offset: 0x1C5C791 VA: 0x1C5C690
	private void RemoveWeatherEffect(WeatherDay weatherDay) { }

	// RVA: 0x1C5D240 Offset: 0x1C5D341 VA: 0x1C5D240
	private void LoadMeteorShower() { }

	// RVA: 0x1C5D9F0 Offset: 0x1C5DAF1 VA: 0x1C5D9F0
	private void RemoveMeteorShower() { }

	// RVA: 0x1C5D400 Offset: 0x1C5D501 VA: 0x1C5D400
	private void LoadRuneyEffect() { }

	// RVA: 0x1C5DB00 Offset: 0x1C5DC01 VA: 0x1C5DB00
	private void RemoveRuneyEffect() { }

	// RVA: 0x1C5D610 Offset: 0x1C5D711 VA: 0x1C5D610
	private bool CheckLoadFireWork() { }

	// RVA: 0x1C5DDA0 Offset: 0x1C5DEA1 VA: 0x1C5DDA0
	private bool CheckRemoveFireWork() { }

	// RVA: 0x1C5D6B0 Offset: 0x1C5D7B1 VA: 0x1C5D6B0
	private void LoadFireWork() { }

	// RVA: 0x1C5DE40 Offset: 0x1C5DF41 VA: 0x1C5DE40
	private void RemoveFireWork() { }

	// RVA: 0x1C5D860 Offset: 0x1C5D961 VA: 0x1C5D860
	private bool CheckLoadConfetti() { }

	// RVA: 0x1C5DF50 Offset: 0x1C5E051 VA: 0x1C5DF50
	private bool CheckRemoveConfetti() { }

	// RVA: 0x1C5D8D0 Offset: 0x1C5D9D1 VA: 0x1C5D8D0
	private void LoadConfetti() { }

	// RVA: 0x1C5DFC0 Offset: 0x1C5E0C1 VA: 0x1C5DFC0
	private void RemoveConfetti() { }

	// RVA: 0x1C5E0D0 Offset: 0x1C5E1D1 VA: 0x1C5E0D0
	public void SetLightEnabled(bool onoff) { }

	// RVA: 0x1C5E1C0 Offset: 0x1C5E2C1 VA: 0x1C5E1C0
	private void LateUpdate() { }

	// RVA: 0x1C5A1A0 Offset: 0x1C5A2A1 VA: 0x1C5A1A0
	private void UpdateLight() { }

	// RVA: 0x1C5E2B0 Offset: 0x1C5E3B1 VA: 0x1C5E2B0
	private void UpdateWeatherEffect() { }

	// RVA: 0x1C5E6F0 Offset: 0x1C5E7F1 VA: 0x1C5E6F0
	private void UpdateMeteorShower() { }

	// RVA: 0x1C5E910 Offset: 0x1C5EA11 VA: 0x1C5E910
	private void UpdateRuneyEffect() { }

	// RVA: 0x1C5EFC0 Offset: 0x1C5F0C1 VA: 0x1C5EFC0
	private void UpdateFireWork() { }

	// RVA: 0x1C5E3E0 Offset: 0x1C5E4E1 VA: 0x1C5E3E0
	private void UpdateConfetti() { }

	// RVA: 0x1C59F20 Offset: 0x1C5A021 VA: 0x1C59F20
	private void SetWeatherEffect() { }

	// RVA: 0x1C5E320 Offset: 0x1C5E421 VA: 0x1C5E320
	private void SetSkyTime(float ratio) { }

	// RVA: 0x1C5F1F0 Offset: 0x1C5F2F1 VA: 0x1C5F1F0
	public void ChangeTimeLine(SkyProfile profile, float startTime, float add, int dir) { }

	// RVA: 0x1C5AE60 Offset: 0x1C5AF61 VA: 0x1C5AE60
	private void SetWeatherData(SkyProfile profile, float startTime, float duration, float jointDuration, Weather skyWeather, float shiftTimeStart, float shiftTimeLength, bool isLast) { }

	// RVA: 0x1C5CCA0 Offset: 0x1C5CDA1 VA: 0x1C5CCA0
	private void AdjustAcrossDayWeather(SkyProfile todayProfile, SkyProfile yesterdayProfile, float targetTime, float jointDuration) { }

	// RVA: 0x1C5C390 Offset: 0x1C5C491 VA: 0x1C5C390
	private void RemoveDummyKeyFrameData(SkyProfile profile) { }

	// RVA: 0x1C5C820 Offset: 0x1C5C921 VA: 0x1C5C820
	private void SetRainParam(SkyProfile changeProfile, SkyProfile referenceProfile) { }

	// RVA: 0x1C5A430 Offset: 0x1C5A531 VA: 0x1C5A430
	private void SetFogColor() { }

	// RVA: 0x1C59D10 Offset: 0x1C59E11 VA: 0x1C59D10
	public void ResetFogColor() { }

	// RVA: 0x1C5A560 Offset: 0x1C5A661 VA: 0x1C5A560
	private void SetLensFlare() { }

	// RVA: 0x1C5FDB0 Offset: 0x1C5FEB1 VA: 0x1C5FDB0
	private void SetCloud(SkyProfile changeProfile) { }

	// RVA: 0x1C5FD70 Offset: 0x1C5FE71 VA: 0x1C5FD70
	private bool IsBadWeather(Weather weather) { }

	// RVA: 0x1C5FD80 Offset: 0x1C5FE81 VA: 0x1C5FD80
	private bool IsRainyWeather(Weather weather) { }

	// RVA: 0x1C60090 Offset: 0x1C60191 VA: 0x1C60090
	public void SetIndoorSkyProfile() { }

	// RVA: 0x1C600C0 Offset: 0x1C601C1 VA: 0x1C600C0
	public void SetSkyProfile(int index) { }

	// RVA: 0x1C60150 Offset: 0x1C60251 VA: 0x1C60150
	public void .ctor() { }

	// RVA: 0x1C601E0 Offset: 0x1C602E1 VA: 0x1C601E0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D930 Offset: 0x19DA31 VA: 0x19D930
	// RVA: 0x1C61520 Offset: 0x1C61621 VA: 0x1C61520
	private void <LoadConfetti>b__105_0(AssetHandle<GameObject> handle) { }
}

