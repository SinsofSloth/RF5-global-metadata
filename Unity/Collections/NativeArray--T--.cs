[DebuggerDisplayAttribute] // RVA: 0xC3B30 Offset: 0xC3C31 VA: 0xC3B30
[NativeContainerSupportsDeferredConvertListToArray] // RVA: 0xC3B30 Offset: 0xC3C31 VA: 0xC3B30
[NativeContainerAttribute] // RVA: 0xC3B30 Offset: 0xC3C31 VA: 0xC3B30
[DebuggerTypeProxyAttribute] // RVA: 0xC3B30 Offset: 0xC3C31 VA: 0xC3B30
[NativeContainerSupportsDeallocateOnJobCompletionAttribute] // RVA: 0xC3B30 Offset: 0xC3C31 VA: 0xC3B30
[NativeContainerSupportsMinMaxWriteRestrictionAttribute] // RVA: 0xC3B30 Offset: 0xC3C31 VA: 0xC3B30
[DefaultMemberAttribute] // RVA: 0xC3B30 Offset: 0xC3C31 VA: 0xC3B30
public struct NativeArray<T> : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray<T>> // TypeDefIndex: 2803
{
	// Fields
	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0xC9410 Offset: 0xC9511 VA: 0xC9410
	internal void* m_Buffer; // 0x0
	internal int m_Length; // 0x0
	internal Allocator m_AllocatorLabel; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; set; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, Allocator allocator, NativeArrayOptions options = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36FBD0 Offset: 0x36FCD1 VA: 0x36FBD0
	|-NativeArray<byte>..ctor
	|
	|-RVA: 0x36FDF0 Offset: 0x36FEF1 VA: 0x36FDF0
	|-NativeArray<int>..ctor
	|
	|-RVA: 0x370010 Offset: 0x370111 VA: 0x370010
	|-NativeArray<float>..ctor
	|
	|-RVA: 0x370230 Offset: 0x370331 VA: 0x370230
	|-NativeArray<PropertySceneHandle>..ctor
	|
	|-RVA: 0x370450 Offset: 0x370551 VA: 0x370450
	|-NativeArray<TransformStreamHandle>..ctor
	|
	|-RVA: 0x370690 Offset: 0x370791 VA: 0x370690
	|-NativeArray<BoneWeight1>..ctor
	|
	|-RVA: 0x3708B0 Offset: 0x3709B1 VA: 0x3708B0
	|-NativeArray<LightDataGI>..ctor
	|
	|-RVA: 0x370B30 Offset: 0x370C31 VA: 0x370B30
	|-NativeArray<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x370D70 Offset: 0x370E71 VA: 0x370D70
	|-NativeArray<Plane>..ctor
	|
	|-RVA: 0x370FB0 Offset: 0x3710B1 VA: 0x370FB0
	|-NativeArray<Quaternion>..ctor
	|
	|-RVA: 0x3711F0 Offset: 0x3712F1 VA: 0x3711F0
	|-NativeArray<BatchVisibility>..ctor
	|
	|-RVA: 0x371430 Offset: 0x371531 VA: 0x371430
	|-NativeArray<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void Allocate(int length, Allocator allocator, out NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28BB740 Offset: 0x28BB841 VA: 0x28BB740
	|-NativeArray<byte>.Allocate
	|
	|-RVA: 0x28BBE30 Offset: 0x28BBF31 VA: 0x28BBE30
	|-NativeArray<int>.Allocate
	|
	|-RVA: 0x28BC520 Offset: 0x28BC621 VA: 0x28BC520
	|-NativeArray<float>.Allocate
	|
	|-RVA: 0x28BCC10 Offset: 0x28BCD11 VA: 0x28BCC10
	|-NativeArray<PropertySceneHandle>.Allocate
	|
	|-RVA: 0x28BD300 Offset: 0x28BD401 VA: 0x28BD300
	|-NativeArray<TransformStreamHandle>.Allocate
	|
	|-RVA: 0x28BD9F0 Offset: 0x28BDAF1 VA: 0x28BD9F0
	|-NativeArray<BoneWeight1>.Allocate
	|
	|-RVA: 0x28BE0E0 Offset: 0x28BE1E1 VA: 0x28BE0E0
	|-NativeArray<LightDataGI>.Allocate
	|
	|-RVA: 0x28BE8A0 Offset: 0x28BE9A1 VA: 0x28BE8A0
	|-NativeArray<ParticleSystem.Particle>.Allocate
	|
	|-RVA: 0x28BF000 Offset: 0x28BF101 VA: 0x28BF000
	|-NativeArray<Plane>.Allocate
	|
	|-RVA: 0x28BF710 Offset: 0x28BF811 VA: 0x28BF710
	|-NativeArray<Quaternion>.Allocate
	|
	|-RVA: 0x28BFE20 Offset: 0x28BFF21 VA: 0x28BFE20
	|-NativeArray<BatchVisibility>.Allocate
	|
	|-RVA: 0x28C0510 Offset: 0x28C0611 VA: 0x28C0510
	|-NativeArray<Vector3>.Allocate
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36FBE0 Offset: 0x36FCE1 VA: 0x36FBE0
	|-NativeArray<byte>.get_Length
	|
	|-RVA: 0x36FE00 Offset: 0x36FF01 VA: 0x36FE00
	|-NativeArray<int>.get_Length
	|
	|-RVA: 0x370020 Offset: 0x370121 VA: 0x370020
	|-NativeArray<float>.get_Length
	|
	|-RVA: 0x370240 Offset: 0x370341 VA: 0x370240
	|-NativeArray<PropertySceneHandle>.get_Length
	|
	|-RVA: 0x370460 Offset: 0x370561 VA: 0x370460
	|-NativeArray<TransformStreamHandle>.get_Length
	|
	|-RVA: 0x3706A0 Offset: 0x3707A1 VA: 0x3706A0
	|-NativeArray<BoneWeight1>.get_Length
	|
	|-RVA: 0x3708C0 Offset: 0x3709C1 VA: 0x3708C0
	|-NativeArray<LightDataGI>.get_Length
	|
	|-RVA: 0x370B40 Offset: 0x370C41 VA: 0x370B40
	|-NativeArray<ParticleSystem.Particle>.get_Length
	|
	|-RVA: 0x370D80 Offset: 0x370E81 VA: 0x370D80
	|-NativeArray<Plane>.get_Length
	|
	|-RVA: 0x370FC0 Offset: 0x3710C1 VA: 0x370FC0
	|-NativeArray<Quaternion>.get_Length
	|
	|-RVA: 0x371200 Offset: 0x371301 VA: 0x371200
	|-NativeArray<BatchVisibility>.get_Length
	|
	|-RVA: 0x371440 Offset: 0x371541 VA: 0x371440
	|-NativeArray<Vector3>.get_Length
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36FBF0 Offset: 0x36FCF1 VA: 0x36FBF0
	|-NativeArray<byte>.get_Item
	|
	|-RVA: 0x36FE10 Offset: 0x36FF11 VA: 0x36FE10
	|-NativeArray<int>.get_Item
	|
	|-RVA: 0x370030 Offset: 0x370131 VA: 0x370030
	|-NativeArray<float>.get_Item
	|
	|-RVA: 0x370250 Offset: 0x370351 VA: 0x370250
	|-NativeArray<PropertySceneHandle>.get_Item
	|
	|-RVA: 0x370470 Offset: 0x370571 VA: 0x370470
	|-NativeArray<TransformStreamHandle>.get_Item
	|
	|-RVA: 0x3706B0 Offset: 0x3707B1 VA: 0x3706B0
	|-NativeArray<BoneWeight1>.get_Item
	|
	|-RVA: 0x3708D0 Offset: 0x3709D1 VA: 0x3708D0
	|-NativeArray<LightDataGI>.get_Item
	|
	|-RVA: 0x370B50 Offset: 0x370C51 VA: 0x370B50
	|-NativeArray<ParticleSystem.Particle>.get_Item
	|
	|-RVA: 0x370D90 Offset: 0x370E91 VA: 0x370D90
	|-NativeArray<Plane>.get_Item
	|
	|-RVA: 0x370FD0 Offset: 0x3710D1 VA: 0x370FD0
	|-NativeArray<Quaternion>.get_Item
	|
	|-RVA: 0x371210 Offset: 0x371311 VA: 0x371210
	|-NativeArray<BatchVisibility>.get_Item
	|
	|-RVA: 0x371450 Offset: 0x371551 VA: 0x371450
	|-NativeArray<Vector3>.get_Item
	*/

	[WriteAccessRequiredAttribute] // RVA: 0xCC2E0 Offset: 0xCC3E1 VA: 0xCC2E0
	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36FC00 Offset: 0x36FD01 VA: 0x36FC00
	|-NativeArray<byte>.set_Item
	|
	|-RVA: 0x36FE20 Offset: 0x36FF21 VA: 0x36FE20
	|-NativeArray<int>.set_Item
	|
	|-RVA: 0x370040 Offset: 0x370141 VA: 0x370040
	|-NativeArray<float>.set_Item
	|
	|-RVA: 0x370260 Offset: 0x370361 VA: 0x370260
	|-NativeArray<PropertySceneHandle>.set_Item
	|
	|-RVA: 0x370490 Offset: 0x370591 VA: 0x370490
	|-NativeArray<TransformStreamHandle>.set_Item
	|
	|-RVA: 0x3706C0 Offset: 0x3707C1 VA: 0x3706C0
	|-NativeArray<BoneWeight1>.set_Item
	|
	|-RVA: 0x370910 Offset: 0x370A11 VA: 0x370910
	|-NativeArray<LightDataGI>.set_Item
	|
	|-RVA: 0x370B70 Offset: 0x370C71 VA: 0x370B70
	|-NativeArray<ParticleSystem.Particle>.set_Item
	|
	|-RVA: 0x370DB0 Offset: 0x370EB1 VA: 0x370DB0
	|-NativeArray<Plane>.set_Item
	|
	|-RVA: 0x370FF0 Offset: 0x3710F1 VA: 0x370FF0
	|-NativeArray<Quaternion>.set_Item
	|
	|-RVA: 0x371230 Offset: 0x371331 VA: 0x371230
	|-NativeArray<BatchVisibility>.set_Item
	|
	|-RVA: 0x371470 Offset: 0x371571 VA: 0x371470
	|-NativeArray<Vector3>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36FC10 Offset: 0x36FD11 VA: 0x36FC10
	|-NativeArray<byte>.get_IsCreated
	|
	|-RVA: 0x36FE30 Offset: 0x36FF31 VA: 0x36FE30
	|-NativeArray<int>.get_IsCreated
	|
	|-RVA: 0x370050 Offset: 0x370151 VA: 0x370050
	|-NativeArray<float>.get_IsCreated
	|
	|-RVA: 0x370270 Offset: 0x370371 VA: 0x370270
	|-NativeArray<PropertySceneHandle>.get_IsCreated
	|
	|-RVA: 0x3704B0 Offset: 0x3705B1 VA: 0x3704B0
	|-NativeArray<TransformStreamHandle>.get_IsCreated
	|
	|-RVA: 0x3706D0 Offset: 0x3707D1 VA: 0x3706D0
	|-NativeArray<BoneWeight1>.get_IsCreated
	|
	|-RVA: 0x370950 Offset: 0x370A51 VA: 0x370950
	|-NativeArray<LightDataGI>.get_IsCreated
	|
	|-RVA: 0x370B90 Offset: 0x370C91 VA: 0x370B90
	|-NativeArray<ParticleSystem.Particle>.get_IsCreated
	|
	|-RVA: 0x370DD0 Offset: 0x370ED1 VA: 0x370DD0
	|-NativeArray<Plane>.get_IsCreated
	|
	|-RVA: 0x371010 Offset: 0x371111 VA: 0x371010
	|-NativeArray<Quaternion>.get_IsCreated
	|
	|-RVA: 0x371250 Offset: 0x371351 VA: 0x371250
	|-NativeArray<BatchVisibility>.get_IsCreated
	|
	|-RVA: 0x371490 Offset: 0x371591 VA: 0x371490
	|-NativeArray<Vector3>.get_IsCreated
	*/

	// RVA: -1 Offset: -1
	private void Deallocate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36FC20 Offset: 0x36FD21 VA: 0x36FC20
	|-NativeArray<byte>.Deallocate
	|
	|-RVA: 0x36FE40 Offset: 0x36FF41 VA: 0x36FE40
	|-NativeArray<int>.Deallocate
	|
	|-RVA: 0x370060 Offset: 0x370161 VA: 0x370060
	|-NativeArray<float>.Deallocate
	|
	|-RVA: 0x370280 Offset: 0x370381 VA: 0x370280
	|-NativeArray<PropertySceneHandle>.Deallocate
	|
	|-RVA: 0x3704C0 Offset: 0x3705C1 VA: 0x3704C0
	|-NativeArray<TransformStreamHandle>.Deallocate
	|
	|-RVA: 0x3706E0 Offset: 0x3707E1 VA: 0x3706E0
	|-NativeArray<BoneWeight1>.Deallocate
	|
	|-RVA: 0x370960 Offset: 0x370A61 VA: 0x370960
	|-NativeArray<LightDataGI>.Deallocate
	|
	|-RVA: 0x370BA0 Offset: 0x370CA1 VA: 0x370BA0
	|-NativeArray<ParticleSystem.Particle>.Deallocate
	|
	|-RVA: 0x370DE0 Offset: 0x370EE1 VA: 0x370DE0
	|-NativeArray<Plane>.Deallocate
	|
	|-RVA: 0x371020 Offset: 0x371121 VA: 0x371020
	|-NativeArray<Quaternion>.Deallocate
	|
	|-RVA: 0x371260 Offset: 0x371361 VA: 0x371260
	|-NativeArray<BatchVisibility>.Deallocate
	|
	|-RVA: 0x3714A0 Offset: 0x3715A1 VA: 0x3714A0
	|-NativeArray<Vector3>.Deallocate
	*/

	[WriteAccessRequiredAttribute] // RVA: 0xCC2F0 Offset: 0xCC3F1 VA: 0xCC2F0
	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36FC60 Offset: 0x36FD61 VA: 0x36FC60
	|-NativeArray<byte>.Dispose
	|
	|-RVA: 0x36FE80 Offset: 0x36FF81 VA: 0x36FE80
	|-NativeArray<int>.Dispose
	|
	|-RVA: 0x3700A0 Offset: 0x3701A1 VA: 0x3700A0
	|-NativeArray<float>.Dispose
	|
	|-RVA: 0x3702C0 Offset: 0x3703C1 VA: 0x3702C0
	|-NativeArray<PropertySceneHandle>.Dispose
	|
	|-RVA: 0x370500 Offset: 0x370601 VA: 0x370500
	|-NativeArray<TransformStreamHandle>.Dispose
	|
	|-RVA: 0x370720 Offset: 0x370821 VA: 0x370720
	|-NativeArray<BoneWeight1>.Dispose
	|
	|-RVA: 0x3709A0 Offset: 0x370AA1 VA: 0x3709A0
	|-NativeArray<LightDataGI>.Dispose
	|
	|-RVA: 0x370BE0 Offset: 0x370CE1 VA: 0x370BE0
	|-NativeArray<ParticleSystem.Particle>.Dispose
	|
	|-RVA: 0x370E20 Offset: 0x370F21 VA: 0x370E20
	|-NativeArray<Plane>.Dispose
	|
	|-RVA: 0x371060 Offset: 0x371161 VA: 0x371060
	|-NativeArray<Quaternion>.Dispose
	|
	|-RVA: 0x3712A0 Offset: 0x3713A1 VA: 0x3712A0
	|-NativeArray<BatchVisibility>.Dispose
	|
	|-RVA: 0x3714E0 Offset: 0x3715E1 VA: 0x3714E0
	|-NativeArray<Vector3>.Dispose
	*/

	// RVA: -1 Offset: -1
	public NativeArray.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36FCB0 Offset: 0x36FDB1 VA: 0x36FCB0
	|-NativeArray<byte>.GetEnumerator
	|
	|-RVA: 0x36FED0 Offset: 0x36FFD1 VA: 0x36FED0
	|-NativeArray<int>.GetEnumerator
	|
	|-RVA: 0x3700F0 Offset: 0x3701F1 VA: 0x3700F0
	|-NativeArray<float>.GetEnumerator
	|
	|-RVA: 0x370310 Offset: 0x370411 VA: 0x370310
	|-NativeArray<PropertySceneHandle>.GetEnumerator
	|
	|-RVA: 0x370550 Offset: 0x370651 VA: 0x370550
	|-NativeArray<TransformStreamHandle>.GetEnumerator
	|
	|-RVA: 0x370770 Offset: 0x370871 VA: 0x370770
	|-NativeArray<BoneWeight1>.GetEnumerator
	|
	|-RVA: 0x3709F0 Offset: 0x370AF1 VA: 0x3709F0
	|-NativeArray<LightDataGI>.GetEnumerator
	|
	|-RVA: 0x370C30 Offset: 0x370D31 VA: 0x370C30
	|-NativeArray<ParticleSystem.Particle>.GetEnumerator
	|
	|-RVA: 0x370E70 Offset: 0x370F71 VA: 0x370E70
	|-NativeArray<Plane>.GetEnumerator
	|
	|-RVA: 0x3710B0 Offset: 0x3711B1 VA: 0x3710B0
	|-NativeArray<Quaternion>.GetEnumerator
	|
	|-RVA: 0x3712F0 Offset: 0x3713F1 VA: 0x3712F0
	|-NativeArray<BatchVisibility>.GetEnumerator
	|
	|-RVA: 0x371530 Offset: 0x371631 VA: 0x371530
	|-NativeArray<Vector3>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36FCF0 Offset: 0x36FDF1 VA: 0x36FCF0
	|-NativeArray<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x36FF10 Offset: 0x370011 VA: 0x36FF10
	|-NativeArray<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x370130 Offset: 0x370231 VA: 0x370130
	|-NativeArray<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x370350 Offset: 0x370451 VA: 0x370350
	|-NativeArray<PropertySceneHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x370590 Offset: 0x370691 VA: 0x370590
	|-NativeArray<TransformStreamHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3707B0 Offset: 0x3708B1 VA: 0x3707B0
	|-NativeArray<BoneWeight1>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x370A30 Offset: 0x370B31 VA: 0x370A30
	|-NativeArray<LightDataGI>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x370C70 Offset: 0x370D71 VA: 0x370C70
	|-NativeArray<ParticleSystem.Particle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x370EB0 Offset: 0x370FB1 VA: 0x370EB0
	|-NativeArray<Plane>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3710F0 Offset: 0x3711F1 VA: 0x3710F0
	|-NativeArray<Quaternion>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x371330 Offset: 0x371431 VA: 0x371330
	|-NativeArray<BatchVisibility>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x371570 Offset: 0x371671 VA: 0x371570
	|-NativeArray<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36FD80 Offset: 0x36FE81 VA: 0x36FD80
	|-NativeArray<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x36FFA0 Offset: 0x3700A1 VA: 0x36FFA0
	|-NativeArray<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3701C0 Offset: 0x3702C1 VA: 0x3701C0
	|-NativeArray<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3703E0 Offset: 0x3704E1 VA: 0x3703E0
	|-NativeArray<PropertySceneHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x370620 Offset: 0x370721 VA: 0x370620
	|-NativeArray<TransformStreamHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x370840 Offset: 0x370941 VA: 0x370840
	|-NativeArray<BoneWeight1>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x370AC0 Offset: 0x370BC1 VA: 0x370AC0
	|-NativeArray<LightDataGI>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x370D00 Offset: 0x370E01 VA: 0x370D00
	|-NativeArray<ParticleSystem.Particle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x370F40 Offset: 0x371041 VA: 0x370F40
	|-NativeArray<Plane>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x371180 Offset: 0x371281 VA: 0x371180
	|-NativeArray<Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3713C0 Offset: 0x3714C1 VA: 0x3713C0
	|-NativeArray<BatchVisibility>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x371600 Offset: 0x371701 VA: 0x371600
	|-NativeArray<Vector3>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Equals(NativeArray<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36FD90 Offset: 0x36FE91 VA: 0x36FD90
	|-NativeArray<byte>.Equals
	|
	|-RVA: 0x36FFB0 Offset: 0x3700B1 VA: 0x36FFB0
	|-NativeArray<int>.Equals
	|
	|-RVA: 0x3701D0 Offset: 0x3702D1 VA: 0x3701D0
	|-NativeArray<float>.Equals
	|
	|-RVA: 0x3703F0 Offset: 0x3704F1 VA: 0x3703F0
	|-NativeArray<PropertySceneHandle>.Equals
	|
	|-RVA: 0x370630 Offset: 0x370731 VA: 0x370630
	|-NativeArray<TransformStreamHandle>.Equals
	|
	|-RVA: 0x370850 Offset: 0x370951 VA: 0x370850
	|-NativeArray<BoneWeight1>.Equals
	|
	|-RVA: 0x370AD0 Offset: 0x370BD1 VA: 0x370AD0
	|-NativeArray<LightDataGI>.Equals
	|
	|-RVA: 0x370D10 Offset: 0x370E11 VA: 0x370D10
	|-NativeArray<ParticleSystem.Particle>.Equals
	|
	|-RVA: 0x370F50 Offset: 0x371051 VA: 0x370F50
	|-NativeArray<Plane>.Equals
	|
	|-RVA: 0x371190 Offset: 0x371291 VA: 0x371190
	|-NativeArray<Quaternion>.Equals
	|
	|-RVA: 0x3713D0 Offset: 0x3714D1 VA: 0x3713D0
	|-NativeArray<BatchVisibility>.Equals
	|
	|-RVA: 0x371610 Offset: 0x371711 VA: 0x371610
	|-NativeArray<Vector3>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36FDC0 Offset: 0x36FEC1 VA: 0x36FDC0
	|-NativeArray<byte>.Equals
	|
	|-RVA: 0x36FFE0 Offset: 0x3700E1 VA: 0x36FFE0
	|-NativeArray<int>.Equals
	|
	|-RVA: 0x370200 Offset: 0x370301 VA: 0x370200
	|-NativeArray<float>.Equals
	|
	|-RVA: 0x370420 Offset: 0x370521 VA: 0x370420
	|-NativeArray<PropertySceneHandle>.Equals
	|
	|-RVA: 0x370660 Offset: 0x370761 VA: 0x370660
	|-NativeArray<TransformStreamHandle>.Equals
	|
	|-RVA: 0x370880 Offset: 0x370981 VA: 0x370880
	|-NativeArray<BoneWeight1>.Equals
	|
	|-RVA: 0x370B00 Offset: 0x370C01 VA: 0x370B00
	|-NativeArray<LightDataGI>.Equals
	|
	|-RVA: 0x370D40 Offset: 0x370E41 VA: 0x370D40
	|-NativeArray<ParticleSystem.Particle>.Equals
	|
	|-RVA: 0x370F80 Offset: 0x371081 VA: 0x370F80
	|-NativeArray<Plane>.Equals
	|
	|-RVA: 0x3711C0 Offset: 0x3712C1 VA: 0x3711C0
	|-NativeArray<Quaternion>.Equals
	|
	|-RVA: 0x371400 Offset: 0x371501 VA: 0x371400
	|-NativeArray<BatchVisibility>.Equals
	|
	|-RVA: 0x371640 Offset: 0x371741 VA: 0x371640
	|-NativeArray<Vector3>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36FDD0 Offset: 0x36FED1 VA: 0x36FDD0
	|-NativeArray<byte>.GetHashCode
	|
	|-RVA: 0x36FFF0 Offset: 0x3700F1 VA: 0x36FFF0
	|-NativeArray<int>.GetHashCode
	|
	|-RVA: 0x370210 Offset: 0x370311 VA: 0x370210
	|-NativeArray<float>.GetHashCode
	|
	|-RVA: 0x370430 Offset: 0x370531 VA: 0x370430
	|-NativeArray<PropertySceneHandle>.GetHashCode
	|
	|-RVA: 0x370670 Offset: 0x370771 VA: 0x370670
	|-NativeArray<TransformStreamHandle>.GetHashCode
	|
	|-RVA: 0x370890 Offset: 0x370991 VA: 0x370890
	|-NativeArray<BoneWeight1>.GetHashCode
	|
	|-RVA: 0x370B10 Offset: 0x370C11 VA: 0x370B10
	|-NativeArray<LightDataGI>.GetHashCode
	|
	|-RVA: 0x370D50 Offset: 0x370E51 VA: 0x370D50
	|-NativeArray<ParticleSystem.Particle>.GetHashCode
	|
	|-RVA: 0x370F90 Offset: 0x371091 VA: 0x370F90
	|-NativeArray<Plane>.GetHashCode
	|
	|-RVA: 0x3711D0 Offset: 0x3712D1 VA: 0x3711D0
	|-NativeArray<Quaternion>.GetHashCode
	|
	|-RVA: 0x371410 Offset: 0x371511 VA: 0x371410
	|-NativeArray<BatchVisibility>.GetHashCode
	|
	|-RVA: 0x371650 Offset: 0x371751 VA: 0x371650
	|-NativeArray<Vector3>.GetHashCode
	*/
}

