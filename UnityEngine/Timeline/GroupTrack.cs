[TrackClipTypeAttribute] // RVA: 0x12AA40 Offset: 0x12AB41 VA: 0x12AA40
[SupportsChildTracksAttribute] // RVA: 0x12AA40 Offset: 0x12AB41 VA: 0x12AA40
[ExcludeFromPresetAttribute] // RVA: 0x12AA40 Offset: 0x12AB41 VA: 0x12AA40
[Serializable]
public class GroupTrack : TrackAsset // TypeDefIndex: 4598
{
	// Properties
	public override IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: 0x17E1600 Offset: 0x17E1701 VA: 0x17E1600 Slot: 33
	internal override bool CanCompileClips() { }

	// RVA: 0x17E1610 Offset: 0x17E1711 VA: 0x17E1610 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x17E1680 Offset: 0x17E1781 VA: 0x17E1680
	public void .ctor() { }
}

