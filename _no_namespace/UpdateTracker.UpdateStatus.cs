private class UpdateTracker.UpdateStatus // TypeDefIndex: 4869
{
	// Fields
	private const int kWindowSize = 30;
	private int windowStart; // 0x10
	private int numWindowLateUpdateMoves; // 0x14
	private int numWindowFixedUpdateMoves; // 0x18
	private int numWindows; // 0x1C
	private int lastFrameUpdated; // 0x20
	private Matrix4x4 lastPos; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x136470 Offset: 0x136571 VA: 0x136470
	private UpdateTracker.UpdateClock <PreferredUpdate>k__BackingField; // 0x64

	// Properties
	public UpdateTracker.UpdateClock PreferredUpdate { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x137440 Offset: 0x137541 VA: 0x137440
	// RVA: 0x1A21F60 Offset: 0x1A22061 VA: 0x1A21F60
	public UpdateTracker.UpdateClock get_PreferredUpdate() { }

	[CompilerGeneratedAttribute] // RVA: 0x137450 Offset: 0x137551 VA: 0x137450
	// RVA: 0x1A21F70 Offset: 0x1A22071 VA: 0x1A21F70
	private void set_PreferredUpdate(UpdateTracker.UpdateClock value) { }

	// RVA: 0x1A21D50 Offset: 0x1A21E51 VA: 0x1A21D50
	public void .ctor(int currentFrame, Matrix4x4 pos) { }

	// RVA: 0x1A219A0 Offset: 0x1A21AA1 VA: 0x1A219A0
	public void OnUpdate(int currentFrame, UpdateTracker.UpdateClock currentClock, Matrix4x4 pos) { }
}

