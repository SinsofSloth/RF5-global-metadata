[ExcludeFromPresetAttribute] // RVA: 0x13EDB0 Offset: 0x13EEB1 VA: 0x13EDB0
[Serializable]
public class TMP_StyleSheet : ScriptableObject // TypeDefIndex: 5849
{
	// Fields
	[SerializeField] // RVA: 0x13FD40 Offset: 0x13FE41 VA: 0x13FD40
	private List<TMP_Style> m_StyleList; // 0x18
	private Dictionary<int, TMP_Style> m_StyleLookupDictionary; // 0x20

	// Properties
	internal List<TMP_Style> styles { get; }

	// Methods

	// RVA: 0x14CA390 Offset: 0x14CA491 VA: 0x14CA390
	internal List<TMP_Style> get_styles() { }

	// RVA: 0x14CA3A0 Offset: 0x14CA4A1 VA: 0x14CA3A0
	private void Reset() { }

	// RVA: 0x14CA650 Offset: 0x14CA751 VA: 0x14CA650
	public TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x14CA6E0 Offset: 0x14CA7E1 VA: 0x14CA6E0
	public TMP_Style GetStyle(string name) { }

	// RVA: 0x14CA7A0 Offset: 0x14CA8A1 VA: 0x14CA7A0
	public void RefreshStyles() { }

	// RVA: 0x14CA3B0 Offset: 0x14CA4B1 VA: 0x14CA3B0
	private void LoadStyleDictionaryInternal() { }

	// RVA: 0x14CA7B0 Offset: 0x14CA8B1 VA: 0x14CA7B0
	public void .ctor() { }
}

