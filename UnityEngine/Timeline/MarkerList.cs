[DefaultMemberAttribute] // RVA: 0x12A800 Offset: 0x12A901 VA: 0x12A800
[Serializable]
internal struct MarkerList : ISerializationCallbackReceiver // TypeDefIndex: 4589
{
	// Fields
	[SerializeField] // RVA: 0x12BC00 Offset: 0x12BD01 VA: 0x12BC00
	[HideInInspector] // RVA: 0x12BC00 Offset: 0x12BD01 VA: 0x12BC00
	private List<ScriptableObject> m_Objects; // 0x0
	[HideInInspector] // RVA: 0x12BC40 Offset: 0x12BD41 VA: 0x12BC40
	private List<IMarker> m_Cache; // 0x8
	private bool m_CacheDirty; // 0x10
	private bool m_HasNotifications; // 0x11

	// Properties
	public List<IMarker> markers { get; }
	public int Count { get; }
	public IMarker Item { get; }

	// Methods

	// RVA: 0xA590 Offset: 0xA691 VA: 0xA590
	public List<IMarker> get_markers() { }

	// RVA: 0xA5C0 Offset: 0xA6C1 VA: 0xA5C0
	public void .ctor(int capacity) { }

	// RVA: 0xA5D0 Offset: 0xA6D1 VA: 0xA5D0
	public void Add(ScriptableObject item) { }

	// RVA: 0xA680 Offset: 0xA781 VA: 0xA680
	public bool Remove(IMarker item) { }

	// RVA: 0xA690 Offset: 0xA791 VA: 0xA690
	public bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty) { }

	// RVA: 0xA6A0 Offset: 0xA7A1 VA: 0xA6A0
	public void Clear() { }

	// RVA: 0xA710 Offset: 0xA811 VA: 0xA710
	public bool Contains(ScriptableObject item) { }

	// RVA: 0xA780 Offset: 0xA881 VA: 0xA780
	public IEnumerable<IMarker> GetMarkers() { }

	// RVA: 0xA7B0 Offset: 0xA8B1 VA: 0xA7B0
	public int get_Count() { }

	// RVA: 0xA820 Offset: 0xA921 VA: 0xA820
	public IMarker get_Item(int idx) { }

	// RVA: 0xA8B0 Offset: 0xA9B1 VA: 0xA8B0
	public List<ScriptableObject> GetRawMarkerList() { }

	// RVA: 0xA8C0 Offset: 0xA9C1 VA: 0xA8C0
	public IMarker CreateMarker(Type type, double time, TrackAsset owner) { }

	// RVA: 0xA8D0 Offset: 0xA9D1 VA: 0xA8D0
	public bool HasNotifications() { }

	// RVA: 0xA900 Offset: 0xAA01 VA: 0xA900 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0xA910 Offset: 0xAA11 VA: 0xA910 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0xA920 Offset: 0xAA21 VA: 0xA920
	private void BuildCache() { }
}

