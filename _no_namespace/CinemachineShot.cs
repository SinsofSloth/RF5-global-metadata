public sealed class CinemachineShot : PlayableAsset, IPropertyPreview // TypeDefIndex: 4727
{
	// Fields
	public string DisplayName; // 0x18
	public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera; // 0x20

	// Methods

	// RVA: 0x1A278A0 Offset: 0x1A279A1 VA: 0x1A278A0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1A279B0 Offset: 0x1A27AB1 VA: 0x1A279B0 Slot: 9
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x1A27EE0 Offset: 0x1A27FE1 VA: 0x1A27EE0
	public void .ctor() { }
}

