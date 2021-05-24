[DefaultMemberAttribute] // RVA: 0x1493B0 Offset: 0x1494B1 VA: 0x1493B0
[Serializable]
public class KeyframeGroupDictionary : ISerializationCallbackReceiver, IEnumerable<string>, IEnumerable // TypeDefIndex: 9686
{
	// Fields
	private Dictionary<string, IKeyframeGroup> m_Groups; // 0x10
	[SerializeField] // RVA: 0x17EA60 Offset: 0x17EB61 VA: 0x17EA60
	private ColorGroupDictionary m_ColorGroup; // 0x18
	[SerializeField] // RVA: 0x17EA70 Offset: 0x17EB71 VA: 0x17EA70
	private NumberGroupDictionary m_NumberGroup; // 0x20
	[SerializeField] // RVA: 0x17EA80 Offset: 0x17EB81 VA: 0x17EA80
	private TextureGroupDictionary m_TextureGroup; // 0x28
	[SerializeField] // RVA: 0x17EA90 Offset: 0x17EB91 VA: 0x17EA90
	private SpherePointGroupDictionary m_SpherePointGroup; // 0x30
	[SerializeField] // RVA: 0x17EAA0 Offset: 0x17EBA1 VA: 0x17EAA0
	private BoolGroupDictionary m_BoolGroup; // 0x38

	// Properties
	public IKeyframeGroup Item { get; set; }

	// Methods

	// RVA: 0x22B17E0 Offset: 0x22B18E1 VA: 0x22B17E0
	public IKeyframeGroup get_Item(string aKey) { }

	// RVA: 0x22B1850 Offset: 0x22B1951 VA: 0x22B1850
	public void set_Item(string aKey, IKeyframeGroup value) { }

	// RVA: 0x22B18C0 Offset: 0x22B19C1 VA: 0x22B18C0
	public bool ContainsKey(string key) { }

	// RVA: 0x22B1930 Offset: 0x22B1A31 VA: 0x22B1930
	public void Clear() { }

	// RVA: -1 Offset: -1
	public T GetGroup<T>(string propertyName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C0E60 Offset: 0x23C0F61 VA: 0x23C0E60
	|-KeyframeGroupDictionary.GetGroup<BoolKeyframeGroup>
	|-KeyframeGroupDictionary.GetGroup<ColorKeyframeGroup>
	|-KeyframeGroupDictionary.GetGroup<NumberKeyframeGroup>
	|-KeyframeGroupDictionary.GetGroup<SpherePointKeyframeGroup>
	|-KeyframeGroupDictionary.GetGroup<TextureKeyframeGroup>
	|-KeyframeGroupDictionary.GetGroup<object>
	*/

	// RVA: 0x22B1990 Offset: 0x22B1A91 VA: 0x22B1990 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x22B1D80 Offset: 0x22B1E81 VA: 0x22B1D80 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x22B2430 Offset: 0x22B2531 VA: 0x22B2430 Slot: 6
	public IEnumerator<string> GetEnumerator() { }

	// RVA: 0x22B24D0 Offset: 0x22B25D1 VA: 0x22B24D0 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x22B24E0 Offset: 0x22B25E1 VA: 0x22B24E0
	public void .ctor() { }
}

