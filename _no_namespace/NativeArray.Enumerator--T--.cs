[ExcludeFromDocsAttribute] // RVA: 0xC3C20 Offset: 0xC3D21 VA: 0xC3C20
public struct NativeArray.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 2804
{
	// Fields
	private NativeArray<T> m_Array; // 0x0
	private int m_Index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ref NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36EFE0 Offset: 0x36F0E1 VA: 0x36EFE0
	|-NativeArray.Enumerator<byte>..ctor
	|
	|-RVA: 0x36F0E0 Offset: 0x36F1E1 VA: 0x36F0E0
	|-NativeArray.Enumerator<int>..ctor
	|
	|-RVA: 0x36F1E0 Offset: 0x36F2E1 VA: 0x36F1E0
	|-NativeArray.Enumerator<float>..ctor
	|
	|-RVA: 0x36F2E0 Offset: 0x36F3E1 VA: 0x36F2E0
	|-NativeArray.Enumerator<PropertySceneHandle>..ctor
	|
	|-RVA: 0x36F3E0 Offset: 0x36F4E1 VA: 0x36F3E0
	|-NativeArray.Enumerator<TransformStreamHandle>..ctor
	|
	|-RVA: 0x36F500 Offset: 0x36F601 VA: 0x36F500
	|-NativeArray.Enumerator<BoneWeight1>..ctor
	|
	|-RVA: 0x36F600 Offset: 0x36F701 VA: 0x36F600
	|-NativeArray.Enumerator<LightDataGI>..ctor
	|
	|-RVA: 0x36F750 Offset: 0x36F851 VA: 0x36F750
	|-NativeArray.Enumerator<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x36F870 Offset: 0x36F971 VA: 0x36F870
	|-NativeArray.Enumerator<Plane>..ctor
	|
	|-RVA: 0x36F900 Offset: 0x36FA01 VA: 0x36F900
	|-NativeArray.Enumerator<Quaternion>..ctor
	|
	|-RVA: 0x36F990 Offset: 0x36FA91 VA: 0x36F990
	|-NativeArray.Enumerator<BatchVisibility>..ctor
	|
	|-RVA: 0x36FAB0 Offset: 0x36FBB1 VA: 0x36FAB0
	|-NativeArray.Enumerator<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36F000 Offset: 0x36F101 VA: 0x36F000
	|-NativeArray.Enumerator<byte>.Dispose
	|
	|-RVA: 0x36F100 Offset: 0x36F201 VA: 0x36F100
	|-NativeArray.Enumerator<int>.Dispose
	|
	|-RVA: 0x36F200 Offset: 0x36F301 VA: 0x36F200
	|-NativeArray.Enumerator<float>.Dispose
	|
	|-RVA: 0x36F300 Offset: 0x36F401 VA: 0x36F300
	|-NativeArray.Enumerator<PropertySceneHandle>.Dispose
	|
	|-RVA: 0x36F400 Offset: 0x36F501 VA: 0x36F400
	|-NativeArray.Enumerator<TransformStreamHandle>.Dispose
	|
	|-RVA: 0x36F520 Offset: 0x36F621 VA: 0x36F520
	|-NativeArray.Enumerator<BoneWeight1>.Dispose
	|
	|-RVA: 0x36F620 Offset: 0x36F721 VA: 0x36F620
	|-NativeArray.Enumerator<LightDataGI>.Dispose
	|
	|-RVA: 0x36F770 Offset: 0x36F871 VA: 0x36F770
	|-NativeArray.Enumerator<ParticleSystem.Particle>.Dispose
	|
	|-RVA: 0x36F890 Offset: 0x36F991 VA: 0x36F890
	|-NativeArray.Enumerator<Plane>.Dispose
	|
	|-RVA: 0x36F920 Offset: 0x36FA21 VA: 0x36F920
	|-NativeArray.Enumerator<Quaternion>.Dispose
	|
	|-RVA: 0x36F9B0 Offset: 0x36FAB1 VA: 0x36F9B0
	|-NativeArray.Enumerator<BatchVisibility>.Dispose
	|
	|-RVA: 0x36FAD0 Offset: 0x36FBD1 VA: 0x36FAD0
	|-NativeArray.Enumerator<Vector3>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36F010 Offset: 0x36F111 VA: 0x36F010
	|-NativeArray.Enumerator<byte>.MoveNext
	|
	|-RVA: 0x36F110 Offset: 0x36F211 VA: 0x36F110
	|-NativeArray.Enumerator<int>.MoveNext
	|
	|-RVA: 0x36F210 Offset: 0x36F311 VA: 0x36F210
	|-NativeArray.Enumerator<float>.MoveNext
	|
	|-RVA: 0x36F310 Offset: 0x36F411 VA: 0x36F310
	|-NativeArray.Enumerator<PropertySceneHandle>.MoveNext
	|
	|-RVA: 0x36F410 Offset: 0x36F511 VA: 0x36F410
	|-NativeArray.Enumerator<TransformStreamHandle>.MoveNext
	|
	|-RVA: 0x36F530 Offset: 0x36F631 VA: 0x36F530
	|-NativeArray.Enumerator<BoneWeight1>.MoveNext
	|
	|-RVA: 0x36F630 Offset: 0x36F731 VA: 0x36F630
	|-NativeArray.Enumerator<LightDataGI>.MoveNext
	|
	|-RVA: 0x36F780 Offset: 0x36F881 VA: 0x36F780
	|-NativeArray.Enumerator<ParticleSystem.Particle>.MoveNext
	|
	|-RVA: 0x36F8A0 Offset: 0x36F9A1 VA: 0x36F8A0
	|-NativeArray.Enumerator<Plane>.MoveNext
	|
	|-RVA: 0x36F930 Offset: 0x36FA31 VA: 0x36F930
	|-NativeArray.Enumerator<Quaternion>.MoveNext
	|
	|-RVA: 0x36F9C0 Offset: 0x36FAC1 VA: 0x36F9C0
	|-NativeArray.Enumerator<BatchVisibility>.MoveNext
	|
	|-RVA: 0x36FAE0 Offset: 0x36FBE1 VA: 0x36FAE0
	|-NativeArray.Enumerator<Vector3>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36F030 Offset: 0x36F131 VA: 0x36F030
	|-NativeArray.Enumerator<byte>.Reset
	|
	|-RVA: 0x36F130 Offset: 0x36F231 VA: 0x36F130
	|-NativeArray.Enumerator<int>.Reset
	|
	|-RVA: 0x36F230 Offset: 0x36F331 VA: 0x36F230
	|-NativeArray.Enumerator<float>.Reset
	|
	|-RVA: 0x36F330 Offset: 0x36F431 VA: 0x36F330
	|-NativeArray.Enumerator<PropertySceneHandle>.Reset
	|
	|-RVA: 0x36F430 Offset: 0x36F531 VA: 0x36F430
	|-NativeArray.Enumerator<TransformStreamHandle>.Reset
	|
	|-RVA: 0x36F550 Offset: 0x36F651 VA: 0x36F550
	|-NativeArray.Enumerator<BoneWeight1>.Reset
	|
	|-RVA: 0x36F650 Offset: 0x36F751 VA: 0x36F650
	|-NativeArray.Enumerator<LightDataGI>.Reset
	|
	|-RVA: 0x36F7A0 Offset: 0x36F8A1 VA: 0x36F7A0
	|-NativeArray.Enumerator<ParticleSystem.Particle>.Reset
	|
	|-RVA: 0x36F8C0 Offset: 0x36F9C1 VA: 0x36F8C0
	|-NativeArray.Enumerator<Plane>.Reset
	|
	|-RVA: 0x36F950 Offset: 0x36FA51 VA: 0x36F950
	|-NativeArray.Enumerator<Quaternion>.Reset
	|
	|-RVA: 0x36F9E0 Offset: 0x36FAE1 VA: 0x36F9E0
	|-NativeArray.Enumerator<BatchVisibility>.Reset
	|
	|-RVA: 0x36FB00 Offset: 0x36FC01 VA: 0x36FB00
	|-NativeArray.Enumerator<Vector3>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36F040 Offset: 0x36F141 VA: 0x36F040
	|-NativeArray.Enumerator<byte>.get_Current
	|
	|-RVA: 0x36F140 Offset: 0x36F241 VA: 0x36F140
	|-NativeArray.Enumerator<int>.get_Current
	|
	|-RVA: 0x36F240 Offset: 0x36F341 VA: 0x36F240
	|-NativeArray.Enumerator<float>.get_Current
	|
	|-RVA: 0x36F340 Offset: 0x36F441 VA: 0x36F340
	|-NativeArray.Enumerator<PropertySceneHandle>.get_Current
	|
	|-RVA: 0x36F440 Offset: 0x36F541 VA: 0x36F440
	|-NativeArray.Enumerator<TransformStreamHandle>.get_Current
	|
	|-RVA: 0x36F560 Offset: 0x36F661 VA: 0x36F560
	|-NativeArray.Enumerator<BoneWeight1>.get_Current
	|
	|-RVA: 0x36F660 Offset: 0x36F761 VA: 0x36F660
	|-NativeArray.Enumerator<LightDataGI>.get_Current
	|
	|-RVA: 0x36F7B0 Offset: 0x36F8B1 VA: 0x36F7B0
	|-NativeArray.Enumerator<ParticleSystem.Particle>.get_Current
	|
	|-RVA: 0x36F8D0 Offset: 0x36F9D1 VA: 0x36F8D0
	|-NativeArray.Enumerator<Plane>.get_Current
	|
	|-RVA: 0x36F960 Offset: 0x36FA61 VA: 0x36F960
	|-NativeArray.Enumerator<Quaternion>.get_Current
	|
	|-RVA: 0x36F9F0 Offset: 0x36FAF1 VA: 0x36F9F0
	|-NativeArray.Enumerator<BatchVisibility>.get_Current
	|
	|-RVA: 0x36FB10 Offset: 0x36FC11 VA: 0x36FB10
	|-NativeArray.Enumerator<Vector3>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36F050 Offset: 0x36F151 VA: 0x36F050
	|-NativeArray.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36F150 Offset: 0x36F251 VA: 0x36F150
	|-NativeArray.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36F250 Offset: 0x36F351 VA: 0x36F250
	|-NativeArray.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36F350 Offset: 0x36F451 VA: 0x36F350
	|-NativeArray.Enumerator<PropertySceneHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36F460 Offset: 0x36F561 VA: 0x36F460
	|-NativeArray.Enumerator<TransformStreamHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36F570 Offset: 0x36F671 VA: 0x36F570
	|-NativeArray.Enumerator<BoneWeight1>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36F6B0 Offset: 0x36F7B1 VA: 0x36F6B0
	|-NativeArray.Enumerator<LightDataGI>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36F7D0 Offset: 0x36F8D1 VA: 0x36F7D0
	|-NativeArray.Enumerator<ParticleSystem.Particle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36F8F0 Offset: 0x36F9F1 VA: 0x36F8F0
	|-NativeArray.Enumerator<Plane>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36F980 Offset: 0x36FA81 VA: 0x36F980
	|-NativeArray.Enumerator<Quaternion>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36FA10 Offset: 0x36FB11 VA: 0x36FA10
	|-NativeArray.Enumerator<BatchVisibility>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x36FB30 Offset: 0x36FC31 VA: 0x36FB30
	|-NativeArray.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	*/
}

