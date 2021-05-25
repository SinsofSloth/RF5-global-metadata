[NativeHeaderAttribute] // RVA: 0xC4FB0 Offset: 0xC50B1 VA: 0xC4FB0
[NativeHeaderAttribute] // RVA: 0xC4FB0 Offset: 0xC50B1 VA: 0xC4FB0
[NativeHeaderAttribute] // RVA: 0xC4FB0 Offset: 0xC50B1 VA: 0xC4FB0
[NativeHeaderAttribute] // RVA: 0xC4FB0 Offset: 0xC50B1 VA: 0xC4FB0
public sealed class MaterialPropertyBlock // TypeDefIndex: 2887
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[NativeNameAttribute] // RVA: 0xCF1E0 Offset: 0xCF2E1 VA: 0xCF1E0
	// RVA: 0x1A36A80 Offset: 0x1A36B81 VA: 0x1A36A80
	private float GetFloatImpl(int name) { }

	[NativeNameAttribute] // RVA: 0xCF220 Offset: 0xCF321 VA: 0xCF220
	// RVA: 0x1A36AD0 Offset: 0x1A36BD1 VA: 0x1A36AD0
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0xCF260 Offset: 0xCF361 VA: 0xCF260
	// RVA: 0x1A36B30 Offset: 0x1A36C31 VA: 0x1A36B30
	private void SetVectorImpl(int name, Vector4 value) { }

	[NativeNameAttribute] // RVA: 0xCF2A0 Offset: 0xCF3A1 VA: 0xCF2A0
	// RVA: 0x1A36C00 Offset: 0x1A36D01 VA: 0x1A36C00
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0xCF2E0 Offset: 0xCF3E1 VA: 0xCF2E0
	// RVA: 0x1A36CD0 Offset: 0x1A36DD1 VA: 0x1A36CD0
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0xCF320 Offset: 0xCF421 VA: 0xCF320
	// RVA: 0x1A36D30 Offset: 0x1A36E31 VA: 0x1A36D30
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[NativeMethodAttribute] // RVA: 0xCF360 Offset: 0xCF461 VA: 0xCF360
	// RVA: 0x1A36DA0 Offset: 0x1A36EA1 VA: 0x1A36DA0
	private static IntPtr CreateImpl() { }

	[NativeMethodAttribute] // RVA: 0xCF3B0 Offset: 0xCF4B1 VA: 0xCF3B0
	// RVA: 0x1A36DE0 Offset: 0x1A36EE1 VA: 0x1A36DE0
	private static void DestroyImpl(IntPtr mpb) { }

	// RVA: 0x1A36E30 Offset: 0x1A36F31 VA: 0x1A36E30
	private void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x1A36F60 Offset: 0x1A37061 VA: 0x1A36F60
	public void .ctor() { }

	// RVA: 0x1A36FB0 Offset: 0x1A370B1 VA: 0x1A36FB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A37020 Offset: 0x1A37121 VA: 0x1A37020
	private void Dispose() { }

	// RVA: 0x1A370E0 Offset: 0x1A371E1 VA: 0x1A370E0
	public void SetFloat(string name, float value) { }

	// RVA: 0x1A37150 Offset: 0x1A37251 VA: 0x1A37150
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x1A371B0 Offset: 0x1A372B1 VA: 0x1A371B0
	public void SetInt(string name, int value) { }

	// RVA: 0x1A37220 Offset: 0x1A37321 VA: 0x1A37220
	public void SetInt(int nameID, int value) { }

	// RVA: 0x1A37280 Offset: 0x1A37381 VA: 0x1A37280
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x1A37320 Offset: 0x1A37421 VA: 0x1A37320
	public void SetColor(string name, Color value) { }

	// RVA: 0x1A373C0 Offset: 0x1A374C1 VA: 0x1A373C0
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x1A37430 Offset: 0x1A37531 VA: 0x1A37430
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x1A374A0 Offset: 0x1A375A1 VA: 0x1A374A0
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x1A37500 Offset: 0x1A37601 VA: 0x1A37500
	public void SetFloatArray(string name, float[] values) { }

	// RVA: 0x1A37550 Offset: 0x1A37651 VA: 0x1A37550
	public float GetFloat(string name) { }

	// RVA: 0x1A36BA0 Offset: 0x1A36CA1 VA: 0x1A36BA0
	private void SetVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x1A36C70 Offset: 0x1A36D71 VA: 0x1A36C70
	private void SetColorImpl_Injected(int name, ref Color value) { }
}

