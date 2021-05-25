[Serializable]
public class SeasonChangeObject : MonoBehaviour // TypeDefIndex: 7472
{
	// Fields
	[SerializeField] // RVA: 0x1669B0 Offset: 0x166AB1 VA: 0x1669B0
	public ChangeMaterial[] ChangeMaterials; // 0x18
	[SerializeField] // RVA: 0x1669C0 Offset: 0x166AC1 VA: 0x1669C0
	public ChangeTexture[] ChangeTextures; // 0x20
	[SerializeField] // RVA: 0x1669D0 Offset: 0x166AD1 VA: 0x1669D0
	public Terrain[] Terrains; // 0x28
	[SerializeField] // RVA: 0x1669E0 Offset: 0x166AE1 VA: 0x1669E0
	public GameObject[][] SeasonGameObjects; // 0x30
	public TextureChangeMaterialParam TextureChangeMaterialParam; // 0x38
	private const string TextureDefaultProparty = "_MainTex";

	// Methods

	// RVA: 0x1C82940 Offset: 0x1C82A41 VA: 0x1C82940
	private void Start() { }

	// RVA: 0x1C82BE0 Offset: 0x1C82CE1 VA: 0x1C82BE0
	private void OnDestroy() { }

	// RVA: 0x1C82E70 Offset: 0x1C82F71 VA: 0x1C82E70
	public void .ctor() { }
}

