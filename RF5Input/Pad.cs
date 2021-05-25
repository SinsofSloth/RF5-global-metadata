[DefaultExecutionOrder] // RVA: 0x14A4E0 Offset: 0x14A5E1 VA: 0x14A4E0
public abstract class Pad : MonoBehaviour // TypeDefIndex: 10251
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1809C0 Offset: 0x180AC1 VA: 0x1809C0
	private static Dictionary<AKey, Key> <Keys>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x1809D0 Offset: 0x180AD1 VA: 0x1809D0
	private static bool <Enable>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x1809E0 Offset: 0x180AE1 VA: 0x1809E0
	private static Pad <Instance>k__BackingField; // 0x10
	private const Key REPEAT = 251662323;
	protected const float AXIS_ROUND_RATE = 0.25;
	protected const float REPEAT_1ST_TIME = 0.2;
	protected const float REPEAT_2ND_TIME = 0.1;
	protected static PadData Data; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1809F0 Offset: 0x180AF1 VA: 0x1809F0
	private static Key <Override>k__BackingField; // 0x20
	public static Func<PadData, PadData> PadDataTakeover; // 0x28
	protected static float repeat_count_; // 0x30
	protected static float repeat_wait_; // 0x34
	private static Key TutorialBlock; // 0x38
	public static readonly Vector3[] VibrationTbl; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x180A00 Offset: 0x180B01 VA: 0x180A00
	private static float <VibPowerLow>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x180A10 Offset: 0x180B11 VA: 0x180A10
	private static float <VibPowerHigh>k__BackingField; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x180A20 Offset: 0x180B21 VA: 0x180A20
	private static float <VibTime>k__BackingField; // 0x50
	private const float LEVER_GATYA_RANGE = 0.8;
	private const int LEVER_GATYA_WAIT_FRAME = 3;
	[CompilerGeneratedAttribute] // RVA: 0x180A30 Offset: 0x180B31 VA: 0x180A30
	private static int <LeverGatyaFrame>k__BackingField; // 0x54
	private float PrevHorizontal; // 0x18
	private float PrevVeritical; // 0x1C

	// Properties
	public static Dictionary<AKey, Key> Keys { get; set; }
	public static bool Enable { get; set; }
	private static Pad Instance { get; set; }
	public static Key Override { get; set; }
	public static float VibPowerLow { get; set; }
	public static float VibPowerHigh { get; set; }
	public static float VibTime { get; set; }
	private static int LeverGatyaFrame { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1ADAD0 Offset: 0x1ADBD1 VA: 0x1ADAD0
	// RVA: 0x1DECC80 Offset: 0x1DECD81 VA: 0x1DECC80
	public static Dictionary<AKey, Key> get_Keys() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADAE0 Offset: 0x1ADBE1 VA: 0x1ADAE0
	// RVA: 0x1DECCF0 Offset: 0x1DECDF1 VA: 0x1DECCF0
	protected static void set_Keys(Dictionary<AKey, Key> value) { }

	// RVA: 0x1DECD60 Offset: 0x1DECE61 VA: 0x1DECD60
	public static bool Push(AKey key) { }

	// RVA: 0x1DECF90 Offset: 0x1DED091 VA: 0x1DECF90
	public static bool Edge(AKey key) { }

	// RVA: 0x1DED1C0 Offset: 0x1DED2C1 VA: 0x1DED1C0
	public static bool End(AKey key) { }

	// RVA: 0x1DED3F0 Offset: 0x1DED4F1 VA: 0x1DED3F0
	public static bool Repeat(AKey key) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADAF0 Offset: 0x1ADBF1 VA: 0x1ADAF0
	// RVA: 0x1DED620 Offset: 0x1DED721 VA: 0x1DED620
	public static bool get_Enable() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADB00 Offset: 0x1ADC01 VA: 0x1ADB00
	// RVA: 0x1DED690 Offset: 0x1DED791 VA: 0x1DED690
	public static void set_Enable(bool value) { }

	// RVA: 0x1DED700 Offset: 0x1DED801 VA: 0x1DED700
	public static void SetKey(Key key) { }

	// RVA: 0x1DECE60 Offset: 0x1DECF61 VA: 0x1DECE60
	public static bool Push(Key key) { }

	// RVA: 0x1DED090 Offset: 0x1DED191 VA: 0x1DED090
	public static bool Edge(Key key) { }

	// RVA: 0x1DED2C0 Offset: 0x1DED3C1 VA: 0x1DED2C0
	public static bool End(Key key) { }

	// RVA: 0x1DED4F0 Offset: 0x1DED5F1 VA: 0x1DED4F0
	public static bool Repeat(Key key) { }

	// RVA: 0x1DED840 Offset: 0x1DED941 VA: 0x1DED840
	public static float AnalogLX() { }

	// RVA: 0x1DED960 Offset: 0x1DEDA61 VA: 0x1DED960
	public static float AnalogLY() { }

	// RVA: 0x1DEDA80 Offset: 0x1DEDB81 VA: 0x1DEDA80
	public static float AnalogRX() { }

	// RVA: 0x1DEDBA0 Offset: 0x1DEDCA1 VA: 0x1DEDBA0
	public static float AnalogRY() { }

	// RVA: 0x1DEDCC0 Offset: 0x1DEDDC1 VA: 0x1DEDCC0
	public static bool IsLeverGatya() { }

	// RVA: 0x1DEDD90 Offset: 0x1DEDE91 VA: 0x1DEDD90
	public static void Create() { }

	// RVA: 0x1DEDEE0 Offset: 0x1DEDFE1 VA: 0x1DEDEE0
	public static void Initialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADB10 Offset: 0x1ADC11 VA: 0x1ADB10
	// RVA: 0x1DEDFD0 Offset: 0x1DEE0D1 VA: 0x1DEDFD0
	private static Pad get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADB20 Offset: 0x1ADC21 VA: 0x1ADB20
	// RVA: 0x1DEE040 Offset: 0x1DEE141 VA: 0x1DEE040
	private static void set_Instance(Pad value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADB30 Offset: 0x1ADC31 VA: 0x1ADB30
	// RVA: 0x1DEE0B0 Offset: 0x1DEE1B1 VA: 0x1DEE0B0
	public static Key get_Override() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADB40 Offset: 0x1ADC41 VA: 0x1ADB40
	// RVA: 0x1DEE120 Offset: 0x1DEE221 VA: 0x1DEE120
	protected static void set_Override(Key value) { }

	// RVA: 0x1DEE190 Offset: 0x1DEE291 VA: 0x1DEE190 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1DEE290 Offset: 0x1DEE391 VA: 0x1DEE290
	private void Update() { }

	// RVA: 0x1DEEBA0 Offset: 0x1DEECA1 VA: 0x1DEEBA0
	public static void SetTutorialBlock(bool block) { }

	// RVA: 0x1DEEC90 Offset: 0x1DEED91 VA: 0x1DEEC90
	public static void SetTutorialBlock(Key key, bool block) { }

	// RVA: 0x1DEED40 Offset: 0x1DEEE41 VA: 0x1DEED40
	public static void TutorialEnableKey(int key) { }

	// RVA: 0x1DEEDF0 Offset: 0x1DEEEF1 VA: 0x1DEEDF0
	private static PadData PadDataTutorial(PadData padData) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADB50 Offset: 0x1ADC51 VA: 0x1ADB50
	// RVA: 0x1DEEEC0 Offset: 0x1DEEFC1 VA: 0x1DEEEC0
	public static float get_VibPowerLow() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADB60 Offset: 0x1ADC61 VA: 0x1ADB60
	// RVA: 0x1DEEF30 Offset: 0x1DEF031 VA: 0x1DEEF30
	protected static void set_VibPowerLow(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADB70 Offset: 0x1ADC71 VA: 0x1ADB70
	// RVA: 0x1DEEFB0 Offset: 0x1DEF0B1 VA: 0x1DEEFB0
	public static float get_VibPowerHigh() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADB80 Offset: 0x1ADC81 VA: 0x1ADB80
	// RVA: 0x1DEF020 Offset: 0x1DEF121 VA: 0x1DEF020
	protected static void set_VibPowerHigh(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADB90 Offset: 0x1ADC91 VA: 0x1ADB90
	// RVA: 0x1DEF0A0 Offset: 0x1DEF1A1 VA: 0x1DEF0A0
	public static float get_VibTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADBA0 Offset: 0x1ADCA1 VA: 0x1ADBA0
	// RVA: 0x1DEF110 Offset: 0x1DEF211 VA: 0x1DEF110
	protected static void set_VibTime(float value) { }

	// RVA: 0x1DEF190 Offset: 0x1DEF291 VA: 0x1DEF190
	public static void PlayVibration(Pad.VibrationType type) { }

	// RVA: 0x1DEF3B0 Offset: 0x1DEF4B1 VA: 0x1DEF3B0
	public static void StopVibration() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADBB0 Offset: 0x1ADCB1 VA: 0x1ADBB0
	// RVA: 0x1DEF530 Offset: 0x1DEF631 VA: 0x1DEF530
	private static int get_LeverGatyaFrame() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADBC0 Offset: 0x1ADCC1 VA: 0x1ADBC0
	// RVA: 0x1DEF5A0 Offset: 0x1DEF6A1 VA: 0x1DEF5A0
	private static void set_LeverGatyaFrame(int value) { }

	// RVA: 0x1DEE910 Offset: 0x1DEEA11 VA: 0x1DEE910
	private void UpdateLeverGatya() { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void SetKeyAssign() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void InitializePad() { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void UpdatePad() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void UpdateVibration() { }

	// RVA: 0x1DEF610 Offset: 0x1DEF711 VA: 0x1DEF610
	protected void .ctor() { }

	// RVA: 0x1DEF620 Offset: 0x1DEF721 VA: 0x1DEF620
	private static void .cctor() { }
}

