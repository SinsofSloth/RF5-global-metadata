[DefaultExecutionOrder] // RVA: 0x14A500 Offset: 0x14A601 VA: 0x14A500
public class PadSwitch : Pad // TypeDefIndex: 10257
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x180A60 Offset: 0x180B61 VA: 0x180A60
	private bool <PadReady>k__BackingField; // 0x20
	public static readonly NpadId[] NpadIds; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x180A70 Offset: 0x180B71 VA: 0x180A70
	private static NpadId <NpadActiveId>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x180A80 Offset: 0x180B81 VA: 0x180A80
	private static NpadStyle <NpadActiveStyle>k__BackingField; // 0xC
	private NpadState npadState_; // 0x28
	private ControllerSupportArg controllerSupportArg_; // 0x58
	private ControllerSupportResultInfo returnArg_; // 0x88
	private Result result_; // 0x94
	private const int vibrationDeviceCountMax_ = 2;
	private int vibrationDeviceCount_; // 0x98
	private VibrationDeviceHandle[] vibrationDeviceHandles_; // 0xA0
	private VibrationDeviceInfo[] vibrationDeviceInfos_; // 0xA8
	private VibrationValue vibrationValue_; // 0xB0

	// Properties
	public bool PadReady { get; set; }
	public static NpadId NpadActiveId { get; set; }
	public static NpadStyle NpadActiveStyle { get; set; }

	// Methods

	// RVA: 0x1DEFDE0 Offset: 0x1DEFEE1 VA: 0x1DEFDE0 Slot: 5
	protected override void SetKeyAssign() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADBD0 Offset: 0x1ADCD1 VA: 0x1ADBD0
	// RVA: 0x1DEFFE0 Offset: 0x1DF00E1 VA: 0x1DEFFE0
	public bool get_PadReady() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADBE0 Offset: 0x1ADCE1 VA: 0x1ADBE0
	// RVA: 0x1DEFFF0 Offset: 0x1DF00F1 VA: 0x1DEFFF0
	protected void set_PadReady(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADBF0 Offset: 0x1ADCF1 VA: 0x1ADBF0
	// RVA: 0x1DF0000 Offset: 0x1DF0101 VA: 0x1DF0000
	public static NpadId get_NpadActiveId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADC00 Offset: 0x1ADD01 VA: 0x1ADC00
	// RVA: 0x1DF0070 Offset: 0x1DF0171 VA: 0x1DF0070
	private static void set_NpadActiveId(NpadId value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADC10 Offset: 0x1ADD11 VA: 0x1ADC10
	// RVA: 0x1DF00E0 Offset: 0x1DF01E1 VA: 0x1DF00E0
	public static NpadStyle get_NpadActiveStyle() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADC20 Offset: 0x1ADD21 VA: 0x1ADC20
	// RVA: 0x1DF0150 Offset: 0x1DF0251 VA: 0x1DF0150
	private static void set_NpadActiveStyle(NpadStyle value) { }

	// RVA: 0x1DF01C0 Offset: 0x1DF02C1 VA: 0x1DF01C0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1DF0860 Offset: 0x1DF0961 VA: 0x1DF0860 Slot: 6
	protected override void InitializePad() { }

	// RVA: 0x1DF0870 Offset: 0x1DF0971 VA: 0x1DF0870 Slot: 7
	protected override void UpdatePad() { }

	// RVA: 0x1DF0F10 Offset: 0x1DF1011 VA: 0x1DF0F10
	public bool NpadCheck() { }

	// RVA: 0x1DF1330 Offset: 0x1DF1431 VA: 0x1DF1330
	private void ShowControllerSupport() { }

	// RVA: 0x1DF0680 Offset: 0x1DF0781 VA: 0x1DF0680
	private void InitializeVibration() { }

	// RVA: 0x1DF0720 Offset: 0x1DF0821 VA: 0x1DF0720
	private void GetVibrationDevice(NpadId id, NpadStyle style) { }

	// RVA: 0x1DF1530 Offset: 0x1DF1631 VA: 0x1DF1530 Slot: 8
	protected override void UpdateVibration() { }

	// RVA: 0x1DF18A0 Offset: 0x1DF19A1 VA: 0x1DF18A0
	public void .ctor() { }

	// RVA: 0x1DF1910 Offset: 0x1DF1A11 VA: 0x1DF1910
	private static void .cctor() { }
}

