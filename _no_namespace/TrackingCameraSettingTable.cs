[DefaultMemberAttribute] // RVA: 0x145DA0 Offset: 0x145EA1 VA: 0x145DA0
[CreateAssetMenuAttribute] // RVA: 0x145DA0 Offset: 0x145EA1 VA: 0x145DA0
[Serializable]
public class TrackingCameraSettingTable : ScriptableObject // TypeDefIndex: 6509
{
	// Fields
	[SerializeField] // RVA: 0x15D030 Offset: 0x15D131 VA: 0x15D030
	private TrackingCameraSettingDictionary m_Table; // 0x18

	// Properties
	public TrackingCameraSetting Item { get; }

	// Methods

	// RVA: 0x1D2B6E0 Offset: 0x1D2B7E1 VA: 0x1D2B6E0
	public TrackingCameraSetting get_Item(TrackinCameraType type) { }

	// RVA: 0x1D2B7A0 Offset: 0x1D2B8A1 VA: 0x1D2B7A0
	public Dictionary<TrackinCameraType, TrackingCameraSetting> GetTable() { }

	// RVA: 0x1D2B800 Offset: 0x1D2B901 VA: 0x1D2B800
	public void .ctor() { }
}

