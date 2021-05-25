[Serializable]
private sealed class ArraySegment.ArraySegmentEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 181
{
	// Fields
	private T[] _array; // 0x0
	private int _start; // 0x0
	private int _end; // 0x0
	private int _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ArraySegment<T> arraySegment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24CEDB0 Offset: 0x24CEEB1 VA: 0x24CEDB0
	|-ArraySegment.ArraySegmentEnumerator<ProfilerFrame>..ctor
	|
	|-RVA: 0x24CEFC0 Offset: 0x24CF0C1 VA: 0x24CEFC0
	|-ArraySegment.ArraySegmentEnumerator<byte>..ctor
	|
	|-RVA: 0x24CF1C0 Offset: 0x24CF2C1 VA: 0x24CF1C0
	|-ArraySegment.ArraySegmentEnumerator<char>..ctor
	|
	|-RVA: 0x24CF3C0 Offset: 0x24CF4C1 VA: 0x24CF3C0
	|-ArraySegment.ArraySegmentEnumerator<double>..ctor
	|
	|-RVA: 0x24CF5C0 Offset: 0x24CF6C1 VA: 0x24CF5C0
	|-ArraySegment.ArraySegmentEnumerator<int>..ctor
	|
	|-RVA: 0x24CF7C0 Offset: 0x24CF8C1 VA: 0x24CF7C0
	|-ArraySegment.ArraySegmentEnumerator<long>..ctor
	|
	|-RVA: 0x24CF9C0 Offset: 0x24CFAC1 VA: 0x24CF9C0
	|-ArraySegment.ArraySegmentEnumerator<object>..ctor
	|
	|-RVA: 0x24CFB80 Offset: 0x24CFC81 VA: 0x24CFB80
	|-ArraySegment.ArraySegmentEnumerator<float>..ctor
	|
	|-RVA: 0x24CFD80 Offset: 0x24CFE81 VA: 0x24CFD80
	|-ArraySegment.ArraySegmentEnumerator<ushort>..ctor
	|
	|-RVA: 0x24CFF80 Offset: 0x24D0081 VA: 0x24CFF80
	|-ArraySegment.ArraySegmentEnumerator<uint>..ctor
	|
	|-RVA: 0x24D0180 Offset: 0x24D0281 VA: 0x24D0180
	|-ArraySegment.ArraySegmentEnumerator<Bounds>..ctor
	|
	|-RVA: 0x24D03B0 Offset: 0x24D04B1 VA: 0x24D03B0
	|-ArraySegment.ArraySegmentEnumerator<Color>..ctor
	|
	|-RVA: 0x24D05C0 Offset: 0x24D06C1 VA: 0x24D05C0
	|-ArraySegment.ArraySegmentEnumerator<Quaternion>..ctor
	|
	|-RVA: 0x24D07D0 Offset: 0x24D08D1 VA: 0x24D07D0
	|-ArraySegment.ArraySegmentEnumerator<Rect>..ctor
	|
	|-RVA: 0x24D09E0 Offset: 0x24D0AE1 VA: 0x24D09E0
	|-ArraySegment.ArraySegmentEnumerator<Vector2>..ctor
	|
	|-RVA: 0x24D0BE0 Offset: 0x24D0CE1 VA: 0x24D0BE0
	|-ArraySegment.ArraySegmentEnumerator<Vector3>..ctor
	|
	|-RVA: 0x24D0DF0 Offset: 0x24D0EF1 VA: 0x24D0DF0
	|-ArraySegment.ArraySegmentEnumerator<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24CEE10 Offset: 0x24CEF11 VA: 0x24CEE10
	|-ArraySegment.ArraySegmentEnumerator<ProfilerFrame>.MoveNext
	|
	|-RVA: 0x24CF020 Offset: 0x24CF121 VA: 0x24CF020
	|-ArraySegment.ArraySegmentEnumerator<byte>.MoveNext
	|
	|-RVA: 0x24CF220 Offset: 0x24CF321 VA: 0x24CF220
	|-ArraySegment.ArraySegmentEnumerator<char>.MoveNext
	|
	|-RVA: 0x24CF420 Offset: 0x24CF521 VA: 0x24CF420
	|-ArraySegment.ArraySegmentEnumerator<double>.MoveNext
	|
	|-RVA: 0x24CF620 Offset: 0x24CF721 VA: 0x24CF620
	|-ArraySegment.ArraySegmentEnumerator<int>.MoveNext
	|
	|-RVA: 0x24CF820 Offset: 0x24CF921 VA: 0x24CF820
	|-ArraySegment.ArraySegmentEnumerator<long>.MoveNext
	|
	|-RVA: 0x24CFA20 Offset: 0x24CFB21 VA: 0x24CFA20
	|-ArraySegment.ArraySegmentEnumerator<object>.MoveNext
	|
	|-RVA: 0x24CFBE0 Offset: 0x24CFCE1 VA: 0x24CFBE0
	|-ArraySegment.ArraySegmentEnumerator<float>.MoveNext
	|
	|-RVA: 0x24CFDE0 Offset: 0x24CFEE1 VA: 0x24CFDE0
	|-ArraySegment.ArraySegmentEnumerator<ushort>.MoveNext
	|
	|-RVA: 0x24CFFE0 Offset: 0x24D00E1 VA: 0x24CFFE0
	|-ArraySegment.ArraySegmentEnumerator<uint>.MoveNext
	|
	|-RVA: 0x24D01E0 Offset: 0x24D02E1 VA: 0x24D01E0
	|-ArraySegment.ArraySegmentEnumerator<Bounds>.MoveNext
	|
	|-RVA: 0x24D0410 Offset: 0x24D0511 VA: 0x24D0410
	|-ArraySegment.ArraySegmentEnumerator<Color>.MoveNext
	|
	|-RVA: 0x24D0620 Offset: 0x24D0721 VA: 0x24D0620
	|-ArraySegment.ArraySegmentEnumerator<Quaternion>.MoveNext
	|
	|-RVA: 0x24D0830 Offset: 0x24D0931 VA: 0x24D0830
	|-ArraySegment.ArraySegmentEnumerator<Rect>.MoveNext
	|
	|-RVA: 0x24D0A40 Offset: 0x24D0B41 VA: 0x24D0A40
	|-ArraySegment.ArraySegmentEnumerator<Vector2>.MoveNext
	|
	|-RVA: 0x24D0C40 Offset: 0x24D0D41 VA: 0x24D0C40
	|-ArraySegment.ArraySegmentEnumerator<Vector3>.MoveNext
	|
	|-RVA: 0x24D0E50 Offset: 0x24D0F51 VA: 0x24D0E50
	|-ArraySegment.ArraySegmentEnumerator<Vector4>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24CEE40 Offset: 0x24CEF41 VA: 0x24CEE40
	|-ArraySegment.ArraySegmentEnumerator<ProfilerFrame>.get_Current
	|
	|-RVA: 0x24CF050 Offset: 0x24CF151 VA: 0x24CF050
	|-ArraySegment.ArraySegmentEnumerator<byte>.get_Current
	|
	|-RVA: 0x24CF250 Offset: 0x24CF351 VA: 0x24CF250
	|-ArraySegment.ArraySegmentEnumerator<char>.get_Current
	|
	|-RVA: 0x24CF450 Offset: 0x24CF551 VA: 0x24CF450
	|-ArraySegment.ArraySegmentEnumerator<double>.get_Current
	|
	|-RVA: 0x24CF650 Offset: 0x24CF751 VA: 0x24CF650
	|-ArraySegment.ArraySegmentEnumerator<int>.get_Current
	|
	|-RVA: 0x24CF850 Offset: 0x24CF951 VA: 0x24CF850
	|-ArraySegment.ArraySegmentEnumerator<long>.get_Current
	|
	|-RVA: 0x24CFA50 Offset: 0x24CFB51 VA: 0x24CFA50
	|-ArraySegment.ArraySegmentEnumerator<object>.get_Current
	|
	|-RVA: 0x24CFC10 Offset: 0x24CFD11 VA: 0x24CFC10
	|-ArraySegment.ArraySegmentEnumerator<float>.get_Current
	|
	|-RVA: 0x24CFE10 Offset: 0x24CFF11 VA: 0x24CFE10
	|-ArraySegment.ArraySegmentEnumerator<ushort>.get_Current
	|
	|-RVA: 0x24D0010 Offset: 0x24D0111 VA: 0x24D0010
	|-ArraySegment.ArraySegmentEnumerator<uint>.get_Current
	|
	|-RVA: 0x24D0210 Offset: 0x24D0311 VA: 0x24D0210
	|-ArraySegment.ArraySegmentEnumerator<Bounds>.get_Current
	|
	|-RVA: 0x24D0440 Offset: 0x24D0541 VA: 0x24D0440
	|-ArraySegment.ArraySegmentEnumerator<Color>.get_Current
	|
	|-RVA: 0x24D0650 Offset: 0x24D0751 VA: 0x24D0650
	|-ArraySegment.ArraySegmentEnumerator<Quaternion>.get_Current
	|
	|-RVA: 0x24D0860 Offset: 0x24D0961 VA: 0x24D0860
	|-ArraySegment.ArraySegmentEnumerator<Rect>.get_Current
	|
	|-RVA: 0x24D0A70 Offset: 0x24D0B71 VA: 0x24D0A70
	|-ArraySegment.ArraySegmentEnumerator<Vector2>.get_Current
	|
	|-RVA: 0x24D0C70 Offset: 0x24D0D71 VA: 0x24D0C70
	|-ArraySegment.ArraySegmentEnumerator<Vector3>.get_Current
	|
	|-RVA: 0x24D0E80 Offset: 0x24D0F81 VA: 0x24D0E80
	|-ArraySegment.ArraySegmentEnumerator<Vector4>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24CEF30 Offset: 0x24CF031 VA: 0x24CEF30
	|-ArraySegment.ArraySegmentEnumerator<ProfilerFrame>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24CF130 Offset: 0x24CF231 VA: 0x24CF130
	|-ArraySegment.ArraySegmentEnumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24CF330 Offset: 0x24CF431 VA: 0x24CF330
	|-ArraySegment.ArraySegmentEnumerator<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24CF530 Offset: 0x24CF631 VA: 0x24CF530
	|-ArraySegment.ArraySegmentEnumerator<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24CF730 Offset: 0x24CF831 VA: 0x24CF730
	|-ArraySegment.ArraySegmentEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24CF930 Offset: 0x24CFA31 VA: 0x24CF930
	|-ArraySegment.ArraySegmentEnumerator<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24CFB30 Offset: 0x24CFC31 VA: 0x24CFB30
	|-ArraySegment.ArraySegmentEnumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24CFCF0 Offset: 0x24CFDF1 VA: 0x24CFCF0
	|-ArraySegment.ArraySegmentEnumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24CFEF0 Offset: 0x24CFFF1 VA: 0x24CFEF0
	|-ArraySegment.ArraySegmentEnumerator<ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24D00F0 Offset: 0x24D01F1 VA: 0x24D00F0
	|-ArraySegment.ArraySegmentEnumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24D0310 Offset: 0x24D0411 VA: 0x24D0310
	|-ArraySegment.ArraySegmentEnumerator<Bounds>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24D0530 Offset: 0x24D0631 VA: 0x24D0530
	|-ArraySegment.ArraySegmentEnumerator<Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24D0740 Offset: 0x24D0841 VA: 0x24D0740
	|-ArraySegment.ArraySegmentEnumerator<Quaternion>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24D0950 Offset: 0x24D0A51 VA: 0x24D0950
	|-ArraySegment.ArraySegmentEnumerator<Rect>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24D0B50 Offset: 0x24D0C51 VA: 0x24D0B50
	|-ArraySegment.ArraySegmentEnumerator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24D0D60 Offset: 0x24D0E61 VA: 0x24D0D60
	|-ArraySegment.ArraySegmentEnumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x24D0F70 Offset: 0x24D1071 VA: 0x24D0F70
	|-ArraySegment.ArraySegmentEnumerator<Vector4>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24CEFA0 Offset: 0x24CF0A1 VA: 0x24CEFA0
	|-ArraySegment.ArraySegmentEnumerator<ProfilerFrame>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24CF1A0 Offset: 0x24CF2A1 VA: 0x24CF1A0
	|-ArraySegment.ArraySegmentEnumerator<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24CF3A0 Offset: 0x24CF4A1 VA: 0x24CF3A0
	|-ArraySegment.ArraySegmentEnumerator<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24CF5A0 Offset: 0x24CF6A1 VA: 0x24CF5A0
	|-ArraySegment.ArraySegmentEnumerator<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24CF7A0 Offset: 0x24CF8A1 VA: 0x24CF7A0
	|-ArraySegment.ArraySegmentEnumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24CF9A0 Offset: 0x24CFAA1 VA: 0x24CF9A0
	|-ArraySegment.ArraySegmentEnumerator<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24CFB60 Offset: 0x24CFC61 VA: 0x24CFB60
	|-ArraySegment.ArraySegmentEnumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24CFD60 Offset: 0x24CFE61 VA: 0x24CFD60
	|-ArraySegment.ArraySegmentEnumerator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24CFF60 Offset: 0x24D0061 VA: 0x24CFF60
	|-ArraySegment.ArraySegmentEnumerator<ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24D0160 Offset: 0x24D0261 VA: 0x24D0160
	|-ArraySegment.ArraySegmentEnumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24D0390 Offset: 0x24D0491 VA: 0x24D0390
	|-ArraySegment.ArraySegmentEnumerator<Bounds>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24D05A0 Offset: 0x24D06A1 VA: 0x24D05A0
	|-ArraySegment.ArraySegmentEnumerator<Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24D07B0 Offset: 0x24D08B1 VA: 0x24D07B0
	|-ArraySegment.ArraySegmentEnumerator<Quaternion>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24D09C0 Offset: 0x24D0AC1 VA: 0x24D09C0
	|-ArraySegment.ArraySegmentEnumerator<Rect>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24D0BC0 Offset: 0x24D0CC1 VA: 0x24D0BC0
	|-ArraySegment.ArraySegmentEnumerator<Vector2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24D0DD0 Offset: 0x24D0ED1 VA: 0x24D0DD0
	|-ArraySegment.ArraySegmentEnumerator<Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x24D0FE0 Offset: 0x24D10E1 VA: 0x24D0FE0
	|-ArraySegment.ArraySegmentEnumerator<Vector4>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24CEFB0 Offset: 0x24CF0B1 VA: 0x24CEFB0
	|-ArraySegment.ArraySegmentEnumerator<ProfilerFrame>.Dispose
	|
	|-RVA: 0x24CF1B0 Offset: 0x24CF2B1 VA: 0x24CF1B0
	|-ArraySegment.ArraySegmentEnumerator<byte>.Dispose
	|
	|-RVA: 0x24CF3B0 Offset: 0x24CF4B1 VA: 0x24CF3B0
	|-ArraySegment.ArraySegmentEnumerator<char>.Dispose
	|
	|-RVA: 0x24CF5B0 Offset: 0x24CF6B1 VA: 0x24CF5B0
	|-ArraySegment.ArraySegmentEnumerator<double>.Dispose
	|
	|-RVA: 0x24CF7B0 Offset: 0x24CF8B1 VA: 0x24CF7B0
	|-ArraySegment.ArraySegmentEnumerator<int>.Dispose
	|
	|-RVA: 0x24CF9B0 Offset: 0x24CFAB1 VA: 0x24CF9B0
	|-ArraySegment.ArraySegmentEnumerator<long>.Dispose
	|
	|-RVA: 0x24CFB70 Offset: 0x24CFC71 VA: 0x24CFB70
	|-ArraySegment.ArraySegmentEnumerator<object>.Dispose
	|
	|-RVA: 0x24CFD70 Offset: 0x24CFE71 VA: 0x24CFD70
	|-ArraySegment.ArraySegmentEnumerator<float>.Dispose
	|
	|-RVA: 0x24CFF70 Offset: 0x24D0071 VA: 0x24CFF70
	|-ArraySegment.ArraySegmentEnumerator<ushort>.Dispose
	|
	|-RVA: 0x24D0170 Offset: 0x24D0271 VA: 0x24D0170
	|-ArraySegment.ArraySegmentEnumerator<uint>.Dispose
	|
	|-RVA: 0x24D03A0 Offset: 0x24D04A1 VA: 0x24D03A0
	|-ArraySegment.ArraySegmentEnumerator<Bounds>.Dispose
	|
	|-RVA: 0x24D05B0 Offset: 0x24D06B1 VA: 0x24D05B0
	|-ArraySegment.ArraySegmentEnumerator<Color>.Dispose
	|
	|-RVA: 0x24D07C0 Offset: 0x24D08C1 VA: 0x24D07C0
	|-ArraySegment.ArraySegmentEnumerator<Quaternion>.Dispose
	|
	|-RVA: 0x24D09D0 Offset: 0x24D0AD1 VA: 0x24D09D0
	|-ArraySegment.ArraySegmentEnumerator<Rect>.Dispose
	|
	|-RVA: 0x24D0BD0 Offset: 0x24D0CD1 VA: 0x24D0BD0
	|-ArraySegment.ArraySegmentEnumerator<Vector2>.Dispose
	|
	|-RVA: 0x24D0DE0 Offset: 0x24D0EE1 VA: 0x24D0DE0
	|-ArraySegment.ArraySegmentEnumerator<Vector3>.Dispose
	|
	|-RVA: 0x24D0FF0 Offset: 0x24D10F1 VA: 0x24D0FF0
	|-ArraySegment.ArraySegmentEnumerator<Vector4>.Dispose
	*/
}

