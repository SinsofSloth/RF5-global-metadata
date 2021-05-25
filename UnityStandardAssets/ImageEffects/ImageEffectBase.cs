[RequireComponent] // RVA: 0x143480 Offset: 0x143581 VA: 0x143480
[AddComponentMenu] // RVA: 0x143480 Offset: 0x143581 VA: 0x143480
public class ImageEffectBase : MonoBehaviour // TypeDefIndex: 6032
{
	// Fields
	public Shader shader; // 0x18
	private Material m_Material; // 0x20

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x1A5B6A0 Offset: 0x1A5B7A1 VA: 0x1A5B6A0 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x1A54200 Offset: 0x1A54301 VA: 0x1A54200
	protected Material get_material() { }

	// RVA: 0x1A5B760 Offset: 0x1A5B861 VA: 0x1A5B760 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x1A542F0 Offset: 0x1A543F1 VA: 0x1A542F0
	public void .ctor() { }
}

