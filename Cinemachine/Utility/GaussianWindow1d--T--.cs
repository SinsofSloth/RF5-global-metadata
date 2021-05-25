internal abstract class GaussianWindow1d<T> // TypeDefIndex: 4897
{
	// Fields
	protected T[] mData; // 0x0
	protected float[] mKernel; // 0x0
	protected int mCurrentPos; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x135890 Offset: 0x135991 VA: 0x135890
	private float <Sigma>k__BackingField; // 0x0

	// Properties
	public float Sigma { get; set; }
	public int KernelSize { get; }
	public int BufferLength { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x137320 Offset: 0x137421 VA: 0x137320
	// RVA: -1 Offset: -1
	public float get_Sigma() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257B600 Offset: 0x257B701 VA: 0x257B600
	|-GaussianWindow1d<object>.get_Sigma
	|
	|-RVA: 0x257BC80 Offset: 0x257BD81 VA: 0x257BC80
	|-GaussianWindow1d<Quaternion>.get_Sigma
	|
	|-RVA: 0x257C360 Offset: 0x257C461 VA: 0x257C360
	|-GaussianWindow1d<Vector2>.get_Sigma
	|
	|-RVA: 0x257C9D0 Offset: 0x257CAD1 VA: 0x257C9D0
	|-GaussianWindow1d<Vector3>.get_Sigma
	*/

	[CompilerGeneratedAttribute] // RVA: 0x137330 Offset: 0x137431 VA: 0x137330
	// RVA: -1 Offset: -1
	private void set_Sigma(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257B610 Offset: 0x257B711 VA: 0x257B610
	|-GaussianWindow1d<object>.set_Sigma
	|
	|-RVA: 0x257BC90 Offset: 0x257BD91 VA: 0x257BC90
	|-GaussianWindow1d<Quaternion>.set_Sigma
	|
	|-RVA: 0x257C370 Offset: 0x257C471 VA: 0x257C370
	|-GaussianWindow1d<Vector2>.set_Sigma
	|
	|-RVA: 0x257C9E0 Offset: 0x257CAE1 VA: 0x257C9E0
	|-GaussianWindow1d<Vector3>.set_Sigma
	*/

	// RVA: -1 Offset: -1
	public int get_KernelSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257B620 Offset: 0x257B721 VA: 0x257B620
	|-GaussianWindow1d<object>.get_KernelSize
	|
	|-RVA: 0x257BCA0 Offset: 0x257BDA1 VA: 0x257BCA0
	|-GaussianWindow1d<Quaternion>.get_KernelSize
	|
	|-RVA: 0x257C380 Offset: 0x257C481 VA: 0x257C380
	|-GaussianWindow1d<Vector2>.get_KernelSize
	|
	|-RVA: 0x257C9F0 Offset: 0x257CAF1 VA: 0x257C9F0
	|-GaussianWindow1d<Vector3>.get_KernelSize
	*/

	// RVA: -1 Offset: -1
	private void GenerateKernel(float sigma, int maxKernelRadius) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257B640 Offset: 0x257B741 VA: 0x257B640
	|-GaussianWindow1d<object>.GenerateKernel
	|
	|-RVA: 0x257BCC0 Offset: 0x257BDC1 VA: 0x257BCC0
	|-GaussianWindow1d<Quaternion>.GenerateKernel
	|
	|-RVA: 0x257C3A0 Offset: 0x257C4A1 VA: 0x257C3A0
	|-GaussianWindow1d<Vector2>.GenerateKernel
	|
	|-RVA: 0x257CA10 Offset: 0x257CB11 VA: 0x257CA10
	|-GaussianWindow1d<Vector3>.GenerateKernel
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract T Compute(int windowPos) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-GaussianWindow1d<object>.Compute
	*/

	// RVA: -1 Offset: -1
	public void .ctor(float sigma, int maxKernelRadius = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257B8A0 Offset: 0x257B9A1 VA: 0x257B8A0
	|-GaussianWindow1d<object>..ctor
	|
	|-RVA: 0x257BF20 Offset: 0x257C021 VA: 0x257BF20
	|-GaussianWindow1d<Quaternion>..ctor
	|
	|-RVA: 0x257C600 Offset: 0x257C701 VA: 0x257C600
	|-GaussianWindow1d<Vector2>..ctor
	|
	|-RVA: 0x257CC70 Offset: 0x257CD71 VA: 0x257CC70
	|-GaussianWindow1d<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257B970 Offset: 0x257BA71 VA: 0x257B970
	|-GaussianWindow1d<object>.Reset
	|
	|-RVA: 0x257BFF0 Offset: 0x257C0F1 VA: 0x257BFF0
	|-GaussianWindow1d<Quaternion>.Reset
	|
	|-RVA: 0x257C6D0 Offset: 0x257C7D1 VA: 0x257C6D0
	|-GaussianWindow1d<Vector2>.Reset
	|
	|-RVA: 0x257CD40 Offset: 0x257CE41 VA: 0x257CD40
	|-GaussianWindow1d<Vector3>.Reset
	*/

	// RVA: -1 Offset: -1
	public bool IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257B980 Offset: 0x257BA81 VA: 0x257B980
	|-GaussianWindow1d<object>.IsEmpty
	|
	|-RVA: 0x257C000 Offset: 0x257C101 VA: 0x257C000
	|-GaussianWindow1d<Quaternion>.IsEmpty
	|
	|-RVA: 0x257C6E0 Offset: 0x257C7E1 VA: 0x257C6E0
	|-GaussianWindow1d<Vector2>.IsEmpty
	|
	|-RVA: 0x257CD50 Offset: 0x257CE51 VA: 0x257CD50
	|-GaussianWindow1d<Vector3>.IsEmpty
	*/

	// RVA: -1 Offset: -1
	public void AddValue(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257B990 Offset: 0x257BA91 VA: 0x257B990
	|-GaussianWindow1d<object>.AddValue
	|
	|-RVA: 0x257C010 Offset: 0x257C111 VA: 0x257C010
	|-GaussianWindow1d<Quaternion>.AddValue
	|
	|-RVA: 0x257C6F0 Offset: 0x257C7F1 VA: 0x257C6F0
	|-GaussianWindow1d<Vector2>.AddValue
	|
	|-RVA: 0x257CD60 Offset: 0x257CE61 VA: 0x257CD60
	|-GaussianWindow1d<Vector3>.AddValue
	*/

	// RVA: -1 Offset: -1
	public T Filter(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257BB20 Offset: 0x257BC21 VA: 0x257BB20
	|-GaussianWindow1d<object>.Filter
	|
	|-RVA: 0x257C1B0 Offset: 0x257C2B1 VA: 0x257C1B0
	|-GaussianWindow1d<Quaternion>.Filter
	|
	|-RVA: 0x257C870 Offset: 0x257C971 VA: 0x257C870
	|-GaussianWindow1d<Vector2>.Filter
	|
	|-RVA: 0x257CF00 Offset: 0x257D001 VA: 0x257CF00
	|-GaussianWindow1d<Vector3>.Filter
	*/

	// RVA: -1 Offset: -1
	public T Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257BBC0 Offset: 0x257BCC1 VA: 0x257BBC0
	|-GaussianWindow1d<object>.Value
	|
	|-RVA: 0x257C280 Offset: 0x257C381 VA: 0x257C280
	|-GaussianWindow1d<Quaternion>.Value
	|
	|-RVA: 0x257C910 Offset: 0x257CA11 VA: 0x257C910
	|-GaussianWindow1d<Vector2>.Value
	|
	|-RVA: 0x257CFC0 Offset: 0x257D0C1 VA: 0x257CFC0
	|-GaussianWindow1d<Vector3>.Value
	*/

	// RVA: -1 Offset: -1
	public int get_BufferLength() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257BBE0 Offset: 0x257BCE1 VA: 0x257BBE0
	|-GaussianWindow1d<object>.get_BufferLength
	|
	|-RVA: 0x257C2A0 Offset: 0x257C3A1 VA: 0x257C2A0
	|-GaussianWindow1d<Quaternion>.get_BufferLength
	|
	|-RVA: 0x257C930 Offset: 0x257CA31 VA: 0x257C930
	|-GaussianWindow1d<Vector2>.get_BufferLength
	|
	|-RVA: 0x257CFE0 Offset: 0x257D0E1 VA: 0x257CFE0
	|-GaussianWindow1d<Vector3>.get_BufferLength
	*/

	// RVA: -1 Offset: -1
	public void SetBufferValue(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257BC00 Offset: 0x257BD01 VA: 0x257BC00
	|-GaussianWindow1d<object>.SetBufferValue
	|
	|-RVA: 0x257C2C0 Offset: 0x257C3C1 VA: 0x257C2C0
	|-GaussianWindow1d<Quaternion>.SetBufferValue
	|
	|-RVA: 0x257C950 Offset: 0x257CA51 VA: 0x257C950
	|-GaussianWindow1d<Vector2>.SetBufferValue
	|
	|-RVA: 0x257D000 Offset: 0x257D101 VA: 0x257D000
	|-GaussianWindow1d<Vector3>.SetBufferValue
	*/

	// RVA: -1 Offset: -1
	public T GetBufferValue(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257BC40 Offset: 0x257BD41 VA: 0x257BC40
	|-GaussianWindow1d<object>.GetBufferValue
	|
	|-RVA: 0x257C310 Offset: 0x257C411 VA: 0x257C310
	|-GaussianWindow1d<Quaternion>.GetBufferValue
	|
	|-RVA: 0x257C990 Offset: 0x257CA91 VA: 0x257C990
	|-GaussianWindow1d<Vector2>.GetBufferValue
	|
	|-RVA: 0x257D050 Offset: 0x257D151 VA: 0x257D050
	|-GaussianWindow1d<Vector3>.GetBufferValue
	*/
}

