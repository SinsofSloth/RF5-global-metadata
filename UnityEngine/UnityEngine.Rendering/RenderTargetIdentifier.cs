public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier> // TypeDefIndex: 3292
{
	// Fields
	private BuiltinRenderTextureType m_Type; // 0x0
	private int m_NameID; // 0x4
	private int m_InstanceID; // 0x8
	private IntPtr m_BufferPointer; // 0x10
	private int m_MipLevel; // 0x18
	private CubemapFace m_CubeFace; // 0x1C
	private int m_DepthSlice; // 0x20

	// Methods

	// RVA: 0x374410 Offset: 0x374511 VA: 0x374410 Slot: 3
	public override string ToString() { }

	// RVA: 0x374420 Offset: 0x374521 VA: 0x374420 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x374480 Offset: 0x374581 VA: 0x374480 Slot: 4
	public bool Equals(RenderTargetIdentifier rhs) { }

	// RVA: 0x374590 Offset: 0x374691 VA: 0x374590 Slot: 0
	public override bool Equals(object obj) { }
}

