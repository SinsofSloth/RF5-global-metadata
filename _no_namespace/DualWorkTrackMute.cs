public class DualWorkTrackMute : MonoBehaviour // TypeDefIndex: 8333
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16EE60 Offset: 0x16EF61 VA: 0x16EE60
	private PlayableDirector <Director>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16EE70 Offset: 0x16EF71 VA: 0x16EE70
	private GroupTrack <SuccessGroup>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x16EE80 Offset: 0x16EF81 VA: 0x16EE80
	private GroupTrack <FailGroup>k__BackingField; // 0x28

	// Properties
	private PlayableDirector Director { get; set; }
	private GroupTrack SuccessGroup { get; set; }
	private GroupTrack FailGroup { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6E50 Offset: 0x1A6F51 VA: 0x1A6E50
	// RVA: 0x200F130 Offset: 0x200F231 VA: 0x200F130
	private PlayableDirector get_Director() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6E60 Offset: 0x1A6F61 VA: 0x1A6E60
	// RVA: 0x200F140 Offset: 0x200F241 VA: 0x200F140
	private void set_Director(PlayableDirector value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6E70 Offset: 0x1A6F71 VA: 0x1A6E70
	// RVA: 0x200F150 Offset: 0x200F251 VA: 0x200F150
	private GroupTrack get_SuccessGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6E80 Offset: 0x1A6F81 VA: 0x1A6E80
	// RVA: 0x200F160 Offset: 0x200F261 VA: 0x200F160
	private void set_SuccessGroup(GroupTrack value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6E90 Offset: 0x1A6F91 VA: 0x1A6E90
	// RVA: 0x200F170 Offset: 0x200F271 VA: 0x200F170
	private GroupTrack get_FailGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6EA0 Offset: 0x1A6FA1 VA: 0x1A6EA0
	// RVA: 0x200F180 Offset: 0x200F281 VA: 0x200F180
	private void set_FailGroup(GroupTrack value) { }

	// RVA: 0x200F190 Offset: 0x200F291 VA: 0x200F190
	private void Awake() { }

	// RVA: 0x200F660 Offset: 0x200F761 VA: 0x200F660
	public void Success() { }

	// RVA: 0x200F740 Offset: 0x200F841 VA: 0x200F740
	public void Fail() { }

	// RVA: 0x200F6E0 Offset: 0x200F7E1 VA: 0x200F6E0
	private void RebuildGraph() { }

	// RVA: 0x200F7C0 Offset: 0x200F8C1 VA: 0x200F7C0
	public void .ctor() { }
}

