internal sealed class CinemachineMixer : PlayableBehaviour // TypeDefIndex: 4725
{
	// Fields
	public static CinemachineMixer.MasterDirectorDelegate GetMasterPlayableDirector; // 0x0
	private CinemachineBrain mBrain; // 0x10
	private int mBrainOverrideId; // 0x18
	private bool mPreviewPlay; // 0x1C

	// Methods

	// RVA: 0x1A26A20 Offset: 0x1A26B21 VA: 0x1A26A20 Slot: 16
	public override void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x1A26AC0 Offset: 0x1A26BC1 VA: 0x1A26AC0 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x1A26AD0 Offset: 0x1A26BD1 VA: 0x1A26AD0 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x1A271A0 Offset: 0x1A272A1 VA: 0x1A271A0
	private float GetDeltaTime(float deltaTime) { }

	// RVA: 0x1A272B0 Offset: 0x1A273B1 VA: 0x1A272B0
	public void .ctor() { }
}

