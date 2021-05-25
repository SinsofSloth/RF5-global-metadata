public struct TransitionTables // TypeDefIndex: 6875
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15FE90 Offset: 0x15FF91 VA: 0x15FE90
	private Enum <CurrentState>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x15FEA0 Offset: 0x15FFA1 VA: 0x15FEA0
	private Enum <NextState>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x15FEB0 Offset: 0x15FFB1 VA: 0x15FEB0
	private Enum <Command>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x15FEC0 Offset: 0x15FFC1 VA: 0x15FEC0
	private Func<bool> <Condition>k__BackingField; // 0x18

	// Properties
	public Enum CurrentState { get; set; }
	public Enum NextState { get; set; }
	public Enum Command { get; set; }
	public Func<bool> Condition { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19DA30 Offset: 0x19DB31 VA: 0x19DA30
	// RVA: 0x2E02C0 Offset: 0x2E03C1 VA: 0x2E02C0
	public Enum get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DA40 Offset: 0x19DB41 VA: 0x19DA40
	// RVA: 0x2E02D0 Offset: 0x2E03D1 VA: 0x2E02D0
	private void set_CurrentState(Enum value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DA50 Offset: 0x19DB51 VA: 0x19DA50
	// RVA: 0x2E02E0 Offset: 0x2E03E1 VA: 0x2E02E0
	public Enum get_NextState() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DA60 Offset: 0x19DB61 VA: 0x19DA60
	// RVA: 0x2E02F0 Offset: 0x2E03F1 VA: 0x2E02F0
	private void set_NextState(Enum value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DA70 Offset: 0x19DB71 VA: 0x19DA70
	// RVA: 0x2E0300 Offset: 0x2E0401 VA: 0x2E0300
	public Enum get_Command() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DA80 Offset: 0x19DB81 VA: 0x19DA80
	// RVA: 0x2E0310 Offset: 0x2E0411 VA: 0x2E0310
	private void set_Command(Enum value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DA90 Offset: 0x19DB91 VA: 0x19DA90
	// RVA: 0x2E0320 Offset: 0x2E0421 VA: 0x2E0320
	public Func<bool> get_Condition() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DAA0 Offset: 0x19DBA1 VA: 0x19DAA0
	// RVA: 0x2E0330 Offset: 0x2E0431 VA: 0x2E0330
	private void set_Condition(Func<bool> value) { }

	// RVA: 0x2E0340 Offset: 0x2E0441 VA: 0x2E0340
	public void .ctor(Enum CurrentState, Enum NextState, Enum Command, Func<bool> Condition) { }
}

