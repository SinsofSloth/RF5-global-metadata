internal static class UvUnwrapping // TypeDefIndex: 5978
{
	// Fields
	private static Vector2 s_TempVector2; // 0x0
	private static readonly List<int> s_IndexBuffer; // 0x8

	// Methods

	// RVA: 0x1A9EE90 Offset: 0x1A9EF91 VA: 0x1A9EE90
	internal static void Unwrap(ProBuilderMesh mesh, Face face, Vector3 projection) { }

	// RVA: 0x1A9F090 Offset: 0x1A9F191 VA: 0x1A9F090
	internal static void ProjectTextureGroup(ProBuilderMesh mesh, int group, AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x1AA4AB0 Offset: 0x1AA4BB1 VA: 0x1AA4AB0
	private static void ApplyUVSettings(Vector2[] uvs, IList<int> indexes, AutoUnwrapSettings uvSettings) { }

	// RVA: 0x1AA5690 Offset: 0x1AA5791 VA: 0x1AA5690
	private static void StretchUVs(Vector2[] uvs, IList<int> indexes) { }

	// RVA: 0x1AA5400 Offset: 0x1AA5501 VA: 0x1AA5400
	private static void FitUVs(Vector2[] uvs, IList<int> indexes) { }

	// RVA: 0x1AA58F0 Offset: 0x1AA59F1 VA: 0x1AA58F0
	private static void ApplyUVAnchor(Vector2[] uvs, IList<int> indexes, AutoUnwrapSettings.Anchor anchor) { }

	// RVA: 0x1AA5DA0 Offset: 0x1AA5EA1 VA: 0x1AA5DA0
	private static void .cctor() { }
}

