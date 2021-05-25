public static class StencilMaterial // TypeDefIndex: 4011
{
	// Fields
	private static List<StencilMaterial.MatEntry> m_List; // 0x0

	// Methods

	[EditorBrowsableAttribute] // RVA: 0x11D270 Offset: 0x11D371 VA: 0x11D270
	[ObsoleteAttribute] // RVA: 0x11D270 Offset: 0x11D371 VA: 0x11D270
	// RVA: 0x1B801E0 Offset: 0x1B802E1 VA: 0x1B801E0
	public static Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x1B801F0 Offset: 0x1B802F1 VA: 0x1B801F0
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x1B80290 Offset: 0x1B80391 VA: 0x1B80290
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x1B80B70 Offset: 0x1B80C71 VA: 0x1B80B70
	public static void Remove(Material customMat) { }

	// RVA: 0x1B80D40 Offset: 0x1B80E41 VA: 0x1B80D40
	public static void ClearAll() { }

	// RVA: 0x1B80E80 Offset: 0x1B80F81 VA: 0x1B80E80
	private static void .cctor() { }
}

