[Serializable]
public class CombinedMesh.ObjectInfo // TypeDefIndex: 9041
{
	// Fields
	public Material[] aMaterials; // 0x10
	public Mesh mesh; // 0x18
	public Vector3 v3LocalPosition; // 0x20
	public Quaternion qLocalRotation; // 0x2C
	public Vector3 v3LocalScale; // 0x3C
	public Matrix4x4 mtxLocal; // 0x48
	public Matrix4x4 mtxWorld; // 0x88
	public Vector3[] av3NormalsWorld; // 0xC8
	public Vector4[] av4TangentsWorld; // 0xD0

	// Methods

	// RVA: 0x1FC41C0 Offset: 0x1FC42C1 VA: 0x1FC41C0
	public void .ctor(Material[] aMaterials, Mesh mesh, Transform transform, Matrix4x4 mtxLocal) { }
}

