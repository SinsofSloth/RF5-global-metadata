[CreateAssetMenuAttribute] // RVA: 0x146590 Offset: 0x146691 VA: 0x146590
[Serializable]
public class SeasonTextureDataTableArray : ScriptableObject // TypeDefIndex: 7493
{
	// Fields
	public SeasonTextureDataTable SeasonTextureDataTable; // 0x18
	public Dictionary<string, Texture[]> SeasonTextureAssetIdDataTable; // 0x20

	// Methods

	// RVA: 0x1C86960 Offset: 0x1C86A61 VA: 0x1C86960
	public Dictionary<string, SeasonTextureData> GetTable() { }

	// RVA: 0x1C869C0 Offset: 0x1C86AC1 VA: 0x1C869C0
	public Dictionary<string, Texture[]> GetIdTable() { }

	// RVA: 0x1C834F0 Offset: 0x1C835F1 VA: 0x1C834F0
	public void Initialize() { }

	// RVA: 0x1C869D0 Offset: 0x1C86AD1 VA: 0x1C869D0
	public void .ctor() { }
}

