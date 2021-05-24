public abstract class Marker : ScriptableObject, IMarker // TypeDefIndex: 4588
{
	// Fields
	[SerializeField] // RVA: 0x12BB90 Offset: 0x12BC91 VA: 0x12BB90
	[TimeFieldAttribute] // RVA: 0x12BB90 Offset: 0x12BC91 VA: 0x12BB90
	[TooltipAttribute] // RVA: 0x12BB90 Offset: 0x12BC91 VA: 0x12BB90
	private double m_Time; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x12BBF0 Offset: 0x12BCF1 VA: 0x12BBF0
	private TrackAsset <parent>k__BackingField; // 0x20

	// Properties
	public TrackAsset parent { get; set; }
	public double time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x12C350 Offset: 0x12C451 VA: 0x12C350
	// RVA: 0x17E1B40 Offset: 0x17E1C41 VA: 0x17E1B40 Slot: 6
	public TrackAsset get_parent() { }

	[CompilerGeneratedAttribute] // RVA: 0x12C360 Offset: 0x12C461 VA: 0x12C360
	// RVA: 0x17E1B50 Offset: 0x17E1C51 VA: 0x17E1B50
	private void set_parent(TrackAsset value) { }

	// RVA: 0x17E1B60 Offset: 0x17E1C61 VA: 0x17E1B60 Slot: 4
	public double get_time() { }

	// RVA: 0x17E1B70 Offset: 0x17E1C71 VA: 0x17E1B70 Slot: 5
	public void set_time(double value) { }

	// RVA: 0x17E1BF0 Offset: 0x17E1CF1 VA: 0x17E1BF0 Slot: 7
	private void UnityEngine.Timeline.IMarker.Initialize(TrackAsset parentTrack) { }

	// RVA: 0x17E1D60 Offset: 0x17E1E61 VA: 0x17E1D60 Slot: 8
	public virtual void OnInitialize(TrackAsset aPent) { }

	// RVA: 0x17E1D70 Offset: 0x17E1E71 VA: 0x17E1D70
	protected void .ctor() { }
}

