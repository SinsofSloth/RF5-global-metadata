public class StateElement // TypeDefIndex: 6876
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15FED0 Offset: 0x15FFD1 VA: 0x15FED0
	private Enum <State>k__BackingField; // 0x10
	public Action EnterCall; // 0x18
	public Func<IEnumerator> EnterRoutine; // 0x20
	public Action ExitCall; // 0x28
	public Func<IEnumerator> ExitRoutine; // 0x30
	public Action Update; // 0x38
	public Action LateUpdate; // 0x40
	public Action FixedUpdate; // 0x48
	public Dictionary<Enum, TransitionTables> TransitionMapping; // 0x50

	// Properties
	public Enum State { get; set; }
	public bool hasEnterRoutine { get; }
	public bool hasExitRoutine { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19DAB0 Offset: 0x19DBB1 VA: 0x19DAB0
	// RVA: 0x224A2C0 Offset: 0x224A3C1 VA: 0x224A2C0
	public Enum get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DAC0 Offset: 0x19DBC1 VA: 0x19DAC0
	// RVA: 0x224A2D0 Offset: 0x224A3D1 VA: 0x224A2D0
	private void set_State(Enum value) { }

	// RVA: 0x224A2E0 Offset: 0x224A3E1 VA: 0x224A2E0
	public bool get_hasEnterRoutine() { }

	// RVA: 0x224A370 Offset: 0x224A471 VA: 0x224A370
	public bool get_hasExitRoutine() { }

	// RVA: 0x224A400 Offset: 0x224A501 VA: 0x224A400
	public void .ctor(Enum state) { }

	// RVA: 0x224A610 Offset: 0x224A711 VA: 0x224A610
	public void .ctor(Enum state, Action Enter, Action Exit, Action Update, Action LateUpdate, Action FixedUpdate) { }
}

