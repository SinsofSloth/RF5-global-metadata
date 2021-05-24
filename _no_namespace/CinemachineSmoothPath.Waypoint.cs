[DocumentationSortingAttribute] // RVA: 0x12F3D0 Offset: 0x12F4D1 VA: 0x12F3D0
[Serializable]
public struct CinemachineSmoothPath.Waypoint // TypeDefIndex: 4764
{
	// Fields
	[TooltipAttribute] // RVA: 0x135A40 Offset: 0x135B41 VA: 0x135A40
	public Vector3 position; // 0x0
	[TooltipAttribute] // RVA: 0x135A80 Offset: 0x135B81 VA: 0x135A80
	public float roll; // 0xC

	// Properties
	internal Vector4 AsVector4 { get; }

	// Methods

	// RVA: 0x8FF0 Offset: 0x90F1 VA: 0x8FF0
	internal Vector4 get_AsVector4() { }

	// RVA: 0x1735280 Offset: 0x1735381 VA: 0x1735280
	internal static CinemachineSmoothPath.Waypoint FromVector4(Vector4 v) { }
}

