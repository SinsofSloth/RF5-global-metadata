[ExecuteInEditMode] // RVA: 0x1492B0 Offset: 0x1493B1 VA: 0x1492B0
public class TimeOfDayController : MonoBehaviour // TypeDefIndex: 9677
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x17E700 Offset: 0x17E801 VA: 0x17E700
	private static TimeOfDayController <instance>k__BackingField; // 0x0
	[TooltipAttribute] // RVA: 0x17E710 Offset: 0x17E811 VA: 0x17E710
	[SerializeField] // RVA: 0x17E710 Offset: 0x17E811 VA: 0x17E710
	private SkyProfile m_SkyProfile; // 0x18
	[TooltipAttribute] // RVA: 0x17E760 Offset: 0x17E861 VA: 0x17E760
	[SerializeField] // RVA: 0x17E760 Offset: 0x17E861 VA: 0x17E760
	private float m_SkyTime; // 0x20
	[TooltipAttribute] // RVA: 0x17E7B0 Offset: 0x17E8B1 VA: 0x17E7B0
	public bool automaticTimeIncrement; // 0x24
	[TooltipAttribute] // RVA: 0x17E7F0 Offset: 0x17E8F1 VA: 0x17E7F0
	public bool copySkyProfile; // 0x25
	private SkyMaterialController m_SkyMaterialController; // 0x28
	[TooltipAttribute] // RVA: 0x17E830 Offset: 0x17E931 VA: 0x17E830
	[RangeAttribute] // RVA: 0x17E830 Offset: 0x17E931 VA: 0x17E830
	public float automaticIncrementSpeed; // 0x30
	[TooltipAttribute] // RVA: 0x17E890 Offset: 0x17E991 VA: 0x17E890
	public OrbitingBody sunOrbit; // 0x38
	[TooltipAttribute] // RVA: 0x17E8D0 Offset: 0x17E9D1 VA: 0x17E8D0
	public OrbitingBody moonOrbit; // 0x40
	[TooltipAttribute] // RVA: 0x17E910 Offset: 0x17EA11 VA: 0x17E910
	public WeatherController weatherController; // 0x48
	[TooltipAttribute] // RVA: 0x17E950 Offset: 0x17EA51 VA: 0x17E950
	public bool updateGlobalIllumination; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x17E990 Offset: 0x17EA91 VA: 0x17E990
	private TimeOfDayController.TimeOfDayDidChange timeChangedCallback; // 0x58
	private bool m_DidInitialUpdate; // 0x60
	private const float PointMoveThreshold = 3E-06;

	// Properties
	public static TimeOfDayController instance { get; set; }
	public SkyProfile skyProfile { get; set; }
	public float skyTime { get; set; }
	public SkyMaterialController SkyMaterial { get; }
	public float timeOfDay { get; }
	public int daysElapsed { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AC610 Offset: 0x1AC711 VA: 0x1AC610
	// RVA: 0x2295000 Offset: 0x2295101 VA: 0x2295000
	public static TimeOfDayController get_instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC620 Offset: 0x1AC721 VA: 0x1AC620
	// RVA: 0x2295050 Offset: 0x2295151 VA: 0x2295050
	private static void set_instance(TimeOfDayController value) { }

	// RVA: 0x22950B0 Offset: 0x22951B1 VA: 0x22950B0
	public SkyProfile get_skyProfile() { }

	// RVA: 0x22950C0 Offset: 0x22951C1 VA: 0x22950C0
	public void set_skyProfile(SkyProfile value) { }

	// RVA: 0x2298050 Offset: 0x2298151 VA: 0x2298050
	public float get_skyTime() { }

	// RVA: 0x2298060 Offset: 0x2298161 VA: 0x2298060
	public void set_skyTime(float value) { }

	// RVA: 0x22980E0 Offset: 0x22981E1 VA: 0x22980E0
	public SkyMaterialController get_SkyMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC630 Offset: 0x1AC731 VA: 0x1AC630
	// RVA: 0x22980F0 Offset: 0x22981F1 VA: 0x22980F0
	public void add_timeChangedCallback(TimeOfDayController.TimeOfDayDidChange value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC640 Offset: 0x1AC741 VA: 0x1AC640
	// RVA: 0x22981A0 Offset: 0x22982A1 VA: 0x22981A0
	public void remove_timeChangedCallback(TimeOfDayController.TimeOfDayDidChange value) { }

	// RVA: 0x2298250 Offset: 0x2298351 VA: 0x2298250
	public float get_timeOfDay() { }

	// RVA: 0x2298270 Offset: 0x2298371 VA: 0x2298270
	public int get_daysElapsed() { }

	// RVA: 0x2298280 Offset: 0x2298381 VA: 0x2298280
	private void Awake() { }

	// RVA: 0x22982E0 Offset: 0x22983E1 VA: 0x22982E0
	private void OnEnabled() { }

	// RVA: 0x2298360 Offset: 0x2298461 VA: 0x2298360
	private void OnValidate() { }

	// RVA: 0x2298410 Offset: 0x2298511 VA: 0x2298410
	private void WarnInvalidSkySetup() { }

	// RVA: 0x2298480 Offset: 0x2298581 VA: 0x2298480
	private void Update() { }

	// RVA: 0x2298D00 Offset: 0x2298E01 VA: 0x2298D00
	public void UpdateGlobalIllumination() { }

	// RVA: 0x2297E30 Offset: 0x2297F31 VA: 0x2297E30
	private void SynchronizeAllShaderKeywords() { }

	// RVA: 0x2298D10 Offset: 0x2298E11 VA: 0x2298D10
	private void SynchronizedShaderKeyword(string featureKey, string shaderKeyword) { }

	// RVA: 0x2298E80 Offset: 0x2298F81 VA: 0x2298E80
	private Vector3 GetPrimaryLightDirection() { }

	// RVA: 0x22951B0 Offset: 0x22952B1 VA: 0x22951B0
	public void UpdateSkyForCurrentTime() { }

	// RVA: 0x2299450 Offset: 0x2299551 VA: 0x2299450
	public void .ctor() { }
}

