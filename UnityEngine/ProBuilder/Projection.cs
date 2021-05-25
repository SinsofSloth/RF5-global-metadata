public static class Projection // TypeDefIndex: 5972
{
	// Methods

	// RVA: 0x1AA35F0 Offset: 0x1AA36F1 VA: 0x1AA35F0
	internal static void PlanarProject(ProBuilderMesh mesh, int textureGroup, AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x1AA3D60 Offset: 0x1AA3E61 VA: 0x1AA3D60
	internal static void PlanarProject(ProBuilderMesh mesh, Face face, Vector3 projection) { }

	// RVA: 0x1AA3C80 Offset: 0x1AA3D81 VA: 0x1AA3C80
	internal static Vector3 GetTangentToAxis(ProjectionAxis axis) { }

	// RVA: 0x1AA3A90 Offset: 0x1AA3B91 VA: 0x1AA3A90
	internal static ProjectionAxis VectorToProjectionAxis(Vector3 direction) { }

	// RVA: 0x1A94400 Offset: 0x1A94501 VA: 0x1A94400
	public static Plane FindBestPlane(IList<Vector3> points, IList<int> indexes) { }
}

