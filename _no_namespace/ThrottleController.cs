public abstract class ThrottleController : MonoBehaviour // TypeDefIndex: 6607
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15DA60 Offset: 0x15DB61 VA: 0x15DA60
	private ThrottleID <CurrentThrottleID>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15DA70 Offset: 0x15DB71 VA: 0x15DA70
	private float <Elapsed>k__BackingField; // 0x1C

	// Properties
	public virtual ThrottleID CurrentThrottleID { get; set; }
	public virtual bool IsPlaying { get; }
	public float Elapsed { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B9E0 Offset: 0x19BAE1 VA: 0x19B9E0
	// RVA: 0x20BBF90 Offset: 0x20BC091 VA: 0x20BBF90 Slot: 4
	public virtual ThrottleID get_CurrentThrottleID() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B9F0 Offset: 0x19BAF1 VA: 0x19B9F0
	// RVA: 0x20BBFA0 Offset: 0x20BC0A1 VA: 0x20BBFA0 Slot: 5
	protected virtual void set_CurrentThrottleID(ThrottleID value) { }

	// RVA: 0x20BBFB0 Offset: 0x20BC0B1 VA: 0x20BBFB0 Slot: 6
	public virtual bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BA00 Offset: 0x19BB01 VA: 0x19BA00
	// RVA: 0x20BBFE0 Offset: 0x20BC0E1 VA: 0x20BBFE0
	public float get_Elapsed() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BA10 Offset: 0x19BB11 VA: 0x19BA10
	// RVA: 0x20BBFF0 Offset: 0x20BC0F1 VA: 0x20BBFF0
	protected void set_Elapsed(float value) { }

	// RVA: 0x20BC000 Offset: 0x20BC101 VA: 0x20BC000 Slot: 7
	public virtual bool CanPlay() { }

	// RVA: 0x20BC010 Offset: 0x20BC111 VA: 0x20BC010 Slot: 8
	public virtual void OnUpdate() { }

	// RVA: 0x20BC060 Offset: 0x20BC161 VA: 0x20BC060 Slot: 9
	public virtual bool DoPlay(ThrottleID throttleID) { }

	// RVA: 0x20BC0B0 Offset: 0x20BC1B1 VA: 0x20BC0B0 Slot: 10
	public virtual bool DoStop() { }

	// RVA: 0x20BC0E0 Offset: 0x20BC1E1 VA: 0x20BC0E0 Slot: 11
	public virtual void DoStop(ThrottleID throttleID) { }

	// RVA: 0x20BC130 Offset: 0x20BC231 VA: 0x20BC130
	protected void .ctor() { }
}

