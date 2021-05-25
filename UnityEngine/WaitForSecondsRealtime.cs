public class WaitForSecondsRealtime : CustomYieldInstruction // TypeDefIndex: 3041
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xCA8B0 Offset: 0xCA9B1 VA: 0xCA8B0
	[DebuggerBrowsableAttribute] // RVA: 0xCA8B0 Offset: 0xCA9B1 VA: 0xCA8B0
	private float <waitTime>k__BackingField; // 0x10
	private float m_WaitUntilTime; // 0x14

	// Properties
	public float waitTime { get; set; }
	public override bool keepWaiting { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xD7670 Offset: 0xD7771 VA: 0xD7670
	// RVA: 0x1B7F830 Offset: 0x1B7F931 VA: 0x1B7F830
	public float get_waitTime() { }

	[CompilerGeneratedAttribute] // RVA: 0xD7680 Offset: 0xD7781 VA: 0xD7680
	// RVA: 0x1B7F840 Offset: 0x1B7F941 VA: 0x1B7F840
	public void set_waitTime(float value) { }

	// RVA: 0x1B7F850 Offset: 0x1B7F951 VA: 0x1B7F850 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x1B7F8B0 Offset: 0x1B7F9B1 VA: 0x1B7F8B0
	public void .ctor(float time) { }
}

