public class WeatherController : MonoBehaviour // TypeDefIndex: 9702
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x17ED10 Offset: 0x17EE11 VA: 0x17ED10
	private RainDownfallController <rainDownfallController>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17ED20 Offset: 0x17EE21 VA: 0x17ED20
	private RainSplashController <rainSplashController>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x17ED30 Offset: 0x17EE31 VA: 0x17ED30
	private LightningController <lightningController>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x17ED40 Offset: 0x17EE41 VA: 0x17ED40
	private WeatherDepthCamera <weatherDepthCamera>k__BackingField; // 0x30
	private WeatherEnclosure m_Enclosure; // 0x38
	private MeshRenderer m_EnclosureMeshRenderer; // 0x40
	private WeatherEnclosureDetector detector; // 0x48
	private SkyProfile m_Profile; // 0x50
	private float m_TimeOfDay; // 0x58

	// Properties
	public RainDownfallController rainDownfallController { get; set; }
	public RainSplashController rainSplashController { get; set; }
	public LightningController lightningController { get; set; }
	public WeatherDepthCamera weatherDepthCamera { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AC730 Offset: 0x1AC831 VA: 0x1AC730
	// RVA: 0x2299540 Offset: 0x2299641 VA: 0x2299540
	public RainDownfallController get_rainDownfallController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC740 Offset: 0x1AC841 VA: 0x1AC740
	// RVA: 0x2299550 Offset: 0x2299651 VA: 0x2299550
	protected void set_rainDownfallController(RainDownfallController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC750 Offset: 0x1AC851 VA: 0x1AC750
	// RVA: 0x2299560 Offset: 0x2299661 VA: 0x2299560
	public RainSplashController get_rainSplashController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC760 Offset: 0x1AC861 VA: 0x1AC760
	// RVA: 0x2299570 Offset: 0x2299671 VA: 0x2299570
	protected void set_rainSplashController(RainSplashController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC770 Offset: 0x1AC871 VA: 0x1AC770
	// RVA: 0x2299580 Offset: 0x2299681 VA: 0x2299580
	public LightningController get_lightningController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC780 Offset: 0x1AC881 VA: 0x1AC780
	// RVA: 0x2299590 Offset: 0x2299691 VA: 0x2299590
	protected void set_lightningController(LightningController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC790 Offset: 0x1AC891 VA: 0x1AC790
	// RVA: 0x22995A0 Offset: 0x22996A1 VA: 0x22995A0
	public WeatherDepthCamera get_weatherDepthCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC7A0 Offset: 0x1AC8A1 VA: 0x1AC7A0
	// RVA: 0x22995B0 Offset: 0x22996B1 VA: 0x22995B0
	protected void set_weatherDepthCamera(WeatherDepthCamera value) { }

	// RVA: 0x22995C0 Offset: 0x22996C1 VA: 0x22995C0
	private void Awake() { }

	// RVA: 0x22996C0 Offset: 0x22997C1 VA: 0x22996C0
	private void Start() { }

	// RVA: 0x22996D0 Offset: 0x22997D1 VA: 0x22996D0
	private void OnEnable() { }

	// RVA: 0x22995D0 Offset: 0x22996D1 VA: 0x22995D0
	private void DiscoverWeatherControllers() { }

	// RVA: 0x2299830 Offset: 0x2299931 VA: 0x2299830
	private void OnDisable() { }

	// RVA: 0x2298AF0 Offset: 0x2298BF1 VA: 0x2298AF0
	public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay) { }

	// RVA: 0x2299950 Offset: 0x2299A51 VA: 0x2299950
	private void LateUpdate() { }

	// RVA: 0x2299AB0 Offset: 0x2299BB1 VA: 0x2299AB0
	private void OnEnclosureDidChange(WeatherEnclosure enclosure) { }

	// RVA: 0x2299BA0 Offset: 0x2299CA1 VA: 0x2299BA0
	public void .ctor() { }
}

