public abstract class FishingStateController : MonoBehaviour // TypeDefIndex: 6589
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15D880 Offset: 0x15D981 VA: 0x15D880
	private FishingState <State>k__BackingField; // 0x18

	// Properties
	public FishingState State { get; set; }
	public bool IsPlaying { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B840 Offset: 0x19B941 VA: 0x19B840
	// RVA: 0x1D4FA90 Offset: 0x1D4FB91 VA: 0x1D4FA90
	public FishingState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B850 Offset: 0x19B951 VA: 0x19B850
	// RVA: 0x1D4FAA0 Offset: 0x1D4FBA1 VA: 0x1D4FAA0
	protected void set_State(FishingState value) { }

	// RVA: 0x1D4FAB0 Offset: 0x1D4FBB1 VA: 0x1D4FAB0
	public bool get_IsPlaying() { }

	// RVA: 0x1D4FAC0 Offset: 0x1D4FBC1 VA: 0x1D4FAC0
	public void SetState(FishingState newState) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnExit() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool DoWkiCast() { }

	// RVA: 0x1D4FAD0 Offset: 0x1D4FBD1 VA: 0x1D4FAD0
	protected void .ctor() { }
}

