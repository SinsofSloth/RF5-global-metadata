[Serializable]
public class StyleSheet : ScriptableObject // TypeDefIndex: 4337
{
	// Fields
	[SerializeField] // RVA: 0x127970 Offset: 0x127A71 VA: 0x127970
	private List<string> _keys; // 0x18
	[SerializeField] // RVA: 0x127980 Offset: 0x127A81 VA: 0x127980
	private List<Style> _styles; // 0x20
	[SerializeField] // RVA: 0x127990 Offset: 0x127A91 VA: 0x127990
	public StyleSheet Parent; // 0x28

	// Methods

	// RVA: 0x1A8C270 Offset: 0x1A8C371 VA: 0x1A8C270
	public Style GetStyle(string key, bool searchParent = True) { }

	// RVA: 0x1A8C660 Offset: 0x1A8C761 VA: 0x1A8C660
	public void .ctor() { }
}

