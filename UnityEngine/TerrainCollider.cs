[NativeHeaderAttribute] // RVA: 0x117390 Offset: 0x117491 VA: 0x117390
[NativeHeaderAttribute] // RVA: 0x117390 Offset: 0x117491 VA: 0x117390
public class TerrainCollider : Collider // TypeDefIndex: 3890
{
	// Properties
	public TerrainData terrainData { get; set; }

	// Methods

	// RVA: 0x1BE2E10 Offset: 0x1BE2F11 VA: 0x1BE2E10
	public TerrainData get_terrainData() { }

	// RVA: 0x1BE2E60 Offset: 0x1BE2F61 VA: 0x1BE2E60
	public void set_terrainData(TerrainData value) { }

	// RVA: 0x1BE2EB0 Offset: 0x1BE2FB1 VA: 0x1BE2EB0
	private RaycastHit Raycast(Ray ray, float maxDistance, bool hitHoles, ref bool hasHit) { }

	// RVA: 0x1BE2FF0 Offset: 0x1BE30F1 VA: 0x1BE2FF0
	internal bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, bool hitHoles) { }

	// RVA: 0x1BE30E0 Offset: 0x1BE31E1 VA: 0x1BE30E0
	public void .ctor() { }

	// RVA: 0x1BE2F70 Offset: 0x1BE3071 VA: 0x1BE2F70
	private void Raycast_Injected(ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret) { }
}

