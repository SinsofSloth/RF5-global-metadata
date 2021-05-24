[Serializable]
public struct ArraySegment<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 180
{
	// Fields
	private T[] _array; // 0x0
	private int _offset; // 0x0
	private int _count; // 0x0

	// Properties
	public T[] Array { get; }
	public int Offset { get; }
	public int Count { get; }
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	private T System.Collections.Generic.IReadOnlyList<T>.Item { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375480 Offset: 0x375581 VA: 0x375480
	|-ArraySegment<ProfilerFrame>..ctor
	|
	|-RVA: 0x3756E0 Offset: 0x3757E1 VA: 0x3756E0
	|-ArraySegment<byte>..ctor
	|
	|-RVA: 0x375940 Offset: 0x375A41 VA: 0x375940
	|-ArraySegment<char>..ctor
	|
	|-RVA: 0x375BA0 Offset: 0x375CA1 VA: 0x375BA0
	|-ArraySegment<double>..ctor
	|
	|-RVA: 0x375E00 Offset: 0x375F01 VA: 0x375E00
	|-ArraySegment<int>..ctor
	|
	|-RVA: 0x376060 Offset: 0x376161 VA: 0x376060
	|-ArraySegment<long>..ctor
	|
	|-RVA: 0x3762C0 Offset: 0x3763C1 VA: 0x3762C0
	|-ArraySegment<object>..ctor
	|
	|-RVA: 0x376520 Offset: 0x376621 VA: 0x376520
	|-ArraySegment<float>..ctor
	|
	|-RVA: 0x376780 Offset: 0x376881 VA: 0x376780
	|-ArraySegment<ushort>..ctor
	|
	|-RVA: 0x3769E0 Offset: 0x376AE1 VA: 0x3769E0
	|-ArraySegment<uint>..ctor
	|
	|-RVA: 0x376C40 Offset: 0x376D41 VA: 0x376C40
	|-ArraySegment<Bounds>..ctor
	|
	|-RVA: 0x376F30 Offset: 0x377031 VA: 0x376F30
	|-ArraySegment<Color>..ctor
	|
	|-RVA: 0x377190 Offset: 0x377291 VA: 0x377190
	|-ArraySegment<Quaternion>..ctor
	|
	|-RVA: 0x3773F0 Offset: 0x3774F1 VA: 0x3773F0
	|-ArraySegment<Rect>..ctor
	|
	|-RVA: 0x377650 Offset: 0x377751 VA: 0x377650
	|-ArraySegment<Vector2>..ctor
	|
	|-RVA: 0x3778B0 Offset: 0x3779B1 VA: 0x3778B0
	|-ArraySegment<Vector3>..ctor
	|
	|-RVA: 0x377B10 Offset: 0x377C11 VA: 0x377B10
	|-ArraySegment<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int offset, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375530 Offset: 0x375631 VA: 0x375530
	|-ArraySegment<ProfilerFrame>..ctor
	|
	|-RVA: 0x375790 Offset: 0x375891 VA: 0x375790
	|-ArraySegment<byte>..ctor
	|
	|-RVA: 0x3759F0 Offset: 0x375AF1 VA: 0x3759F0
	|-ArraySegment<char>..ctor
	|
	|-RVA: 0x375C50 Offset: 0x375D51 VA: 0x375C50
	|-ArraySegment<double>..ctor
	|
	|-RVA: 0x375EB0 Offset: 0x375FB1 VA: 0x375EB0
	|-ArraySegment<int>..ctor
	|
	|-RVA: 0x376110 Offset: 0x376211 VA: 0x376110
	|-ArraySegment<long>..ctor
	|
	|-RVA: 0x376370 Offset: 0x376471 VA: 0x376370
	|-ArraySegment<object>..ctor
	|
	|-RVA: 0x3765D0 Offset: 0x3766D1 VA: 0x3765D0
	|-ArraySegment<float>..ctor
	|
	|-RVA: 0x376830 Offset: 0x376931 VA: 0x376830
	|-ArraySegment<ushort>..ctor
	|
	|-RVA: 0x376A90 Offset: 0x376B91 VA: 0x376A90
	|-ArraySegment<uint>..ctor
	|
	|-RVA: 0x376CF0 Offset: 0x376DF1 VA: 0x376CF0
	|-ArraySegment<Bounds>..ctor
	|
	|-RVA: 0x376FE0 Offset: 0x3770E1 VA: 0x376FE0
	|-ArraySegment<Color>..ctor
	|
	|-RVA: 0x377240 Offset: 0x377341 VA: 0x377240
	|-ArraySegment<Quaternion>..ctor
	|
	|-RVA: 0x3774A0 Offset: 0x3775A1 VA: 0x3774A0
	|-ArraySegment<Rect>..ctor
	|
	|-RVA: 0x377700 Offset: 0x377801 VA: 0x377700
	|-ArraySegment<Vector2>..ctor
	|
	|-RVA: 0x377960 Offset: 0x377A61 VA: 0x377960
	|-ArraySegment<Vector3>..ctor
	|
	|-RVA: 0x377BC0 Offset: 0x377CC1 VA: 0x377BC0
	|-ArraySegment<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Array() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3757A0 Offset: 0x3758A1 VA: 0x3757A0
	|-ArraySegment<byte>.get_Array
	|
	|-RVA: 0x375540 Offset: 0x375641 VA: 0x375540
	|-ArraySegment<ProfilerFrame>.get_Array
	|
	|-RVA: 0x375A00 Offset: 0x375B01 VA: 0x375A00
	|-ArraySegment<char>.get_Array
	|
	|-RVA: 0x375C60 Offset: 0x375D61 VA: 0x375C60
	|-ArraySegment<double>.get_Array
	|
	|-RVA: 0x375EC0 Offset: 0x375FC1 VA: 0x375EC0
	|-ArraySegment<int>.get_Array
	|
	|-RVA: 0x376120 Offset: 0x376221 VA: 0x376120
	|-ArraySegment<long>.get_Array
	|
	|-RVA: 0x376380 Offset: 0x376481 VA: 0x376380
	|-ArraySegment<object>.get_Array
	|
	|-RVA: 0x3765E0 Offset: 0x3766E1 VA: 0x3765E0
	|-ArraySegment<float>.get_Array
	|
	|-RVA: 0x376840 Offset: 0x376941 VA: 0x376840
	|-ArraySegment<ushort>.get_Array
	|
	|-RVA: 0x376AA0 Offset: 0x376BA1 VA: 0x376AA0
	|-ArraySegment<uint>.get_Array
	|
	|-RVA: 0x376D00 Offset: 0x376E01 VA: 0x376D00
	|-ArraySegment<Bounds>.get_Array
	|
	|-RVA: 0x376FF0 Offset: 0x3770F1 VA: 0x376FF0
	|-ArraySegment<Color>.get_Array
	|
	|-RVA: 0x377250 Offset: 0x377351 VA: 0x377250
	|-ArraySegment<Quaternion>.get_Array
	|
	|-RVA: 0x3774B0 Offset: 0x3775B1 VA: 0x3774B0
	|-ArraySegment<Rect>.get_Array
	|
	|-RVA: 0x377710 Offset: 0x377811 VA: 0x377710
	|-ArraySegment<Vector2>.get_Array
	|
	|-RVA: 0x377970 Offset: 0x377A71 VA: 0x377970
	|-ArraySegment<Vector3>.get_Array
	|
	|-RVA: 0x377BD0 Offset: 0x377CD1 VA: 0x377BD0
	|-ArraySegment<Vector4>.get_Array
	*/

	// RVA: -1 Offset: -1
	public int get_Offset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375550 Offset: 0x375651 VA: 0x375550
	|-ArraySegment<ProfilerFrame>.get_Offset
	|
	|-RVA: 0x3757B0 Offset: 0x3758B1 VA: 0x3757B0
	|-ArraySegment<byte>.get_Offset
	|
	|-RVA: 0x375A10 Offset: 0x375B11 VA: 0x375A10
	|-ArraySegment<char>.get_Offset
	|
	|-RVA: 0x375C70 Offset: 0x375D71 VA: 0x375C70
	|-ArraySegment<double>.get_Offset
	|
	|-RVA: 0x375ED0 Offset: 0x375FD1 VA: 0x375ED0
	|-ArraySegment<int>.get_Offset
	|
	|-RVA: 0x376130 Offset: 0x376231 VA: 0x376130
	|-ArraySegment<long>.get_Offset
	|
	|-RVA: 0x376390 Offset: 0x376491 VA: 0x376390
	|-ArraySegment<object>.get_Offset
	|
	|-RVA: 0x3765F0 Offset: 0x3766F1 VA: 0x3765F0
	|-ArraySegment<float>.get_Offset
	|
	|-RVA: 0x376850 Offset: 0x376951 VA: 0x376850
	|-ArraySegment<ushort>.get_Offset
	|
	|-RVA: 0x376AB0 Offset: 0x376BB1 VA: 0x376AB0
	|-ArraySegment<uint>.get_Offset
	|
	|-RVA: 0x376D10 Offset: 0x376E11 VA: 0x376D10
	|-ArraySegment<Bounds>.get_Offset
	|
	|-RVA: 0x377000 Offset: 0x377101 VA: 0x377000
	|-ArraySegment<Color>.get_Offset
	|
	|-RVA: 0x377260 Offset: 0x377361 VA: 0x377260
	|-ArraySegment<Quaternion>.get_Offset
	|
	|-RVA: 0x3774C0 Offset: 0x3775C1 VA: 0x3774C0
	|-ArraySegment<Rect>.get_Offset
	|
	|-RVA: 0x377720 Offset: 0x377821 VA: 0x377720
	|-ArraySegment<Vector2>.get_Offset
	|
	|-RVA: 0x377980 Offset: 0x377A81 VA: 0x377980
	|-ArraySegment<Vector3>.get_Offset
	|
	|-RVA: 0x377BE0 Offset: 0x377CE1 VA: 0x377BE0
	|-ArraySegment<Vector4>.get_Offset
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375560 Offset: 0x375661 VA: 0x375560
	|-ArraySegment<ProfilerFrame>.get_Count
	|
	|-RVA: 0x3757C0 Offset: 0x3758C1 VA: 0x3757C0
	|-ArraySegment<byte>.get_Count
	|
	|-RVA: 0x375A20 Offset: 0x375B21 VA: 0x375A20
	|-ArraySegment<char>.get_Count
	|
	|-RVA: 0x375C80 Offset: 0x375D81 VA: 0x375C80
	|-ArraySegment<double>.get_Count
	|
	|-RVA: 0x375EE0 Offset: 0x375FE1 VA: 0x375EE0
	|-ArraySegment<int>.get_Count
	|
	|-RVA: 0x376140 Offset: 0x376241 VA: 0x376140
	|-ArraySegment<long>.get_Count
	|
	|-RVA: 0x3763A0 Offset: 0x3764A1 VA: 0x3763A0
	|-ArraySegment<object>.get_Count
	|
	|-RVA: 0x376600 Offset: 0x376701 VA: 0x376600
	|-ArraySegment<float>.get_Count
	|
	|-RVA: 0x376860 Offset: 0x376961 VA: 0x376860
	|-ArraySegment<ushort>.get_Count
	|
	|-RVA: 0x376AC0 Offset: 0x376BC1 VA: 0x376AC0
	|-ArraySegment<uint>.get_Count
	|
	|-RVA: 0x376D20 Offset: 0x376E21 VA: 0x376D20
	|-ArraySegment<Bounds>.get_Count
	|
	|-RVA: 0x377010 Offset: 0x377111 VA: 0x377010
	|-ArraySegment<Color>.get_Count
	|
	|-RVA: 0x377270 Offset: 0x377371 VA: 0x377270
	|-ArraySegment<Quaternion>.get_Count
	|
	|-RVA: 0x3774D0 Offset: 0x3775D1 VA: 0x3774D0
	|-ArraySegment<Rect>.get_Count
	|
	|-RVA: 0x377730 Offset: 0x377831 VA: 0x377730
	|-ArraySegment<Vector2>.get_Count
	|
	|-RVA: 0x377990 Offset: 0x377A91 VA: 0x377990
	|-ArraySegment<Vector3>.get_Count
	|
	|-RVA: 0x377BF0 Offset: 0x377CF1 VA: 0x377BF0
	|-ArraySegment<Vector4>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375570 Offset: 0x375671 VA: 0x375570
	|-ArraySegment<ProfilerFrame>.GetHashCode
	|
	|-RVA: 0x3757D0 Offset: 0x3758D1 VA: 0x3757D0
	|-ArraySegment<byte>.GetHashCode
	|
	|-RVA: 0x375A30 Offset: 0x375B31 VA: 0x375A30
	|-ArraySegment<char>.GetHashCode
	|
	|-RVA: 0x375C90 Offset: 0x375D91 VA: 0x375C90
	|-ArraySegment<double>.GetHashCode
	|
	|-RVA: 0x375EF0 Offset: 0x375FF1 VA: 0x375EF0
	|-ArraySegment<int>.GetHashCode
	|
	|-RVA: 0x376150 Offset: 0x376251 VA: 0x376150
	|-ArraySegment<long>.GetHashCode
	|
	|-RVA: 0x3763B0 Offset: 0x3764B1 VA: 0x3763B0
	|-ArraySegment<object>.GetHashCode
	|
	|-RVA: 0x376610 Offset: 0x376711 VA: 0x376610
	|-ArraySegment<float>.GetHashCode
	|
	|-RVA: 0x376870 Offset: 0x376971 VA: 0x376870
	|-ArraySegment<ushort>.GetHashCode
	|
	|-RVA: 0x376AD0 Offset: 0x376BD1 VA: 0x376AD0
	|-ArraySegment<uint>.GetHashCode
	|
	|-RVA: 0x376D30 Offset: 0x376E31 VA: 0x376D30
	|-ArraySegment<Bounds>.GetHashCode
	|
	|-RVA: 0x377020 Offset: 0x377121 VA: 0x377020
	|-ArraySegment<Color>.GetHashCode
	|
	|-RVA: 0x377280 Offset: 0x377381 VA: 0x377280
	|-ArraySegment<Quaternion>.GetHashCode
	|
	|-RVA: 0x3774E0 Offset: 0x3775E1 VA: 0x3774E0
	|-ArraySegment<Rect>.GetHashCode
	|
	|-RVA: 0x377740 Offset: 0x377841 VA: 0x377740
	|-ArraySegment<Vector2>.GetHashCode
	|
	|-RVA: 0x3779A0 Offset: 0x377AA1 VA: 0x3779A0
	|-ArraySegment<Vector3>.GetHashCode
	|
	|-RVA: 0x377C00 Offset: 0x377D01 VA: 0x377C00
	|-ArraySegment<Vector4>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3755B0 Offset: 0x3756B1 VA: 0x3755B0
	|-ArraySegment<ProfilerFrame>.Equals
	|
	|-RVA: 0x375810 Offset: 0x375911 VA: 0x375810
	|-ArraySegment<byte>.Equals
	|
	|-RVA: 0x375A70 Offset: 0x375B71 VA: 0x375A70
	|-ArraySegment<char>.Equals
	|
	|-RVA: 0x375CD0 Offset: 0x375DD1 VA: 0x375CD0
	|-ArraySegment<double>.Equals
	|
	|-RVA: 0x375F30 Offset: 0x376031 VA: 0x375F30
	|-ArraySegment<int>.Equals
	|
	|-RVA: 0x376190 Offset: 0x376291 VA: 0x376190
	|-ArraySegment<long>.Equals
	|
	|-RVA: 0x3763F0 Offset: 0x3764F1 VA: 0x3763F0
	|-ArraySegment<object>.Equals
	|
	|-RVA: 0x376650 Offset: 0x376751 VA: 0x376650
	|-ArraySegment<float>.Equals
	|
	|-RVA: 0x3768B0 Offset: 0x3769B1 VA: 0x3768B0
	|-ArraySegment<ushort>.Equals
	|
	|-RVA: 0x376B10 Offset: 0x376C11 VA: 0x376B10
	|-ArraySegment<uint>.Equals
	|
	|-RVA: 0x376D70 Offset: 0x376E71 VA: 0x376D70
	|-ArraySegment<Bounds>.Equals
	|
	|-RVA: 0x377060 Offset: 0x377161 VA: 0x377060
	|-ArraySegment<Color>.Equals
	|
	|-RVA: 0x3772C0 Offset: 0x3773C1 VA: 0x3772C0
	|-ArraySegment<Quaternion>.Equals
	|
	|-RVA: 0x377520 Offset: 0x377621 VA: 0x377520
	|-ArraySegment<Rect>.Equals
	|
	|-RVA: 0x377780 Offset: 0x377881 VA: 0x377780
	|-ArraySegment<Vector2>.Equals
	|
	|-RVA: 0x3779E0 Offset: 0x377AE1 VA: 0x3779E0
	|-ArraySegment<Vector3>.Equals
	|
	|-RVA: 0x377C40 Offset: 0x377D41 VA: 0x377C40
	|-ArraySegment<Vector4>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool Equals(ArraySegment<T> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3755C0 Offset: 0x3756C1 VA: 0x3755C0
	|-ArraySegment<ProfilerFrame>.Equals
	|
	|-RVA: 0x375820 Offset: 0x375921 VA: 0x375820
	|-ArraySegment<byte>.Equals
	|
	|-RVA: 0x375A80 Offset: 0x375B81 VA: 0x375A80
	|-ArraySegment<char>.Equals
	|
	|-RVA: 0x375CE0 Offset: 0x375DE1 VA: 0x375CE0
	|-ArraySegment<double>.Equals
	|
	|-RVA: 0x375F40 Offset: 0x376041 VA: 0x375F40
	|-ArraySegment<int>.Equals
	|
	|-RVA: 0x3761A0 Offset: 0x3762A1 VA: 0x3761A0
	|-ArraySegment<long>.Equals
	|
	|-RVA: 0x376400 Offset: 0x376501 VA: 0x376400
	|-ArraySegment<object>.Equals
	|
	|-RVA: 0x376660 Offset: 0x376761 VA: 0x376660
	|-ArraySegment<float>.Equals
	|
	|-RVA: 0x3768C0 Offset: 0x3769C1 VA: 0x3768C0
	|-ArraySegment<ushort>.Equals
	|
	|-RVA: 0x376B20 Offset: 0x376C21 VA: 0x376B20
	|-ArraySegment<uint>.Equals
	|
	|-RVA: 0x376D80 Offset: 0x376E81 VA: 0x376D80
	|-ArraySegment<Bounds>.Equals
	|
	|-RVA: 0x377070 Offset: 0x377171 VA: 0x377070
	|-ArraySegment<Color>.Equals
	|
	|-RVA: 0x3772D0 Offset: 0x3773D1 VA: 0x3772D0
	|-ArraySegment<Quaternion>.Equals
	|
	|-RVA: 0x377530 Offset: 0x377631 VA: 0x377530
	|-ArraySegment<Rect>.Equals
	|
	|-RVA: 0x377790 Offset: 0x377891 VA: 0x377790
	|-ArraySegment<Vector2>.Equals
	|
	|-RVA: 0x3779F0 Offset: 0x377AF1 VA: 0x3779F0
	|-ArraySegment<Vector3>.Equals
	|
	|-RVA: 0x377C50 Offset: 0x377D51 VA: 0x377C50
	|-ArraySegment<Vector4>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375600 Offset: 0x375701 VA: 0x375600
	|-ArraySegment<ProfilerFrame>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x375860 Offset: 0x375961 VA: 0x375860
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x375AC0 Offset: 0x375BC1 VA: 0x375AC0
	|-ArraySegment<char>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x375D20 Offset: 0x375E21 VA: 0x375D20
	|-ArraySegment<double>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x375F80 Offset: 0x376081 VA: 0x375F80
	|-ArraySegment<int>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3761E0 Offset: 0x3762E1 VA: 0x3761E0
	|-ArraySegment<long>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x376440 Offset: 0x376541 VA: 0x376440
	|-ArraySegment<object>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3766A0 Offset: 0x3767A1 VA: 0x3766A0
	|-ArraySegment<float>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x376900 Offset: 0x376A01 VA: 0x376900
	|-ArraySegment<ushort>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x376B60 Offset: 0x376C61 VA: 0x376B60
	|-ArraySegment<uint>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x376DC0 Offset: 0x376EC1 VA: 0x376DC0
	|-ArraySegment<Bounds>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3770B0 Offset: 0x3771B1 VA: 0x3770B0
	|-ArraySegment<Color>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x377310 Offset: 0x377411 VA: 0x377310
	|-ArraySegment<Quaternion>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x377570 Offset: 0x377671 VA: 0x377570
	|-ArraySegment<Rect>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x3777D0 Offset: 0x3778D1 VA: 0x3777D0
	|-ArraySegment<Vector2>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x377A30 Offset: 0x377B31 VA: 0x377A30
	|-ArraySegment<Vector3>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x377C90 Offset: 0x377D91 VA: 0x377C90
	|-ArraySegment<Vector4>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375610 Offset: 0x375711 VA: 0x375610
	|-ArraySegment<ProfilerFrame>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x375870 Offset: 0x375971 VA: 0x375870
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x375AD0 Offset: 0x375BD1 VA: 0x375AD0
	|-ArraySegment<char>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x375D30 Offset: 0x375E31 VA: 0x375D30
	|-ArraySegment<double>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x375F90 Offset: 0x376091 VA: 0x375F90
	|-ArraySegment<int>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3761F0 Offset: 0x3762F1 VA: 0x3761F0
	|-ArraySegment<long>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x376450 Offset: 0x376551 VA: 0x376450
	|-ArraySegment<object>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3766B0 Offset: 0x3767B1 VA: 0x3766B0
	|-ArraySegment<float>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x376910 Offset: 0x376A11 VA: 0x376910
	|-ArraySegment<ushort>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x376B70 Offset: 0x376C71 VA: 0x376B70
	|-ArraySegment<uint>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x376DD0 Offset: 0x376ED1 VA: 0x376DD0
	|-ArraySegment<Bounds>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3770C0 Offset: 0x3771C1 VA: 0x3770C0
	|-ArraySegment<Color>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x377320 Offset: 0x377421 VA: 0x377320
	|-ArraySegment<Quaternion>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x377580 Offset: 0x377681 VA: 0x377580
	|-ArraySegment<Rect>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x3777E0 Offset: 0x3778E1 VA: 0x3777E0
	|-ArraySegment<Vector2>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x377A40 Offset: 0x377B41 VA: 0x377A40
	|-ArraySegment<Vector3>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x377CA0 Offset: 0x377DA1 VA: 0x377CA0
	|-ArraySegment<Vector4>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.Generic.IList<T>.IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375620 Offset: 0x375721 VA: 0x375620
	|-ArraySegment<ProfilerFrame>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x375880 Offset: 0x375981 VA: 0x375880
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x375AE0 Offset: 0x375BE1 VA: 0x375AE0
	|-ArraySegment<char>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x375D40 Offset: 0x375E41 VA: 0x375D40
	|-ArraySegment<double>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x375FA0 Offset: 0x3760A1 VA: 0x375FA0
	|-ArraySegment<int>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x376200 Offset: 0x376301 VA: 0x376200
	|-ArraySegment<long>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x376460 Offset: 0x376561 VA: 0x376460
	|-ArraySegment<object>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x3766C0 Offset: 0x3767C1 VA: 0x3766C0
	|-ArraySegment<float>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x376920 Offset: 0x376A21 VA: 0x376920
	|-ArraySegment<ushort>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x376B80 Offset: 0x376C81 VA: 0x376B80
	|-ArraySegment<uint>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x376E10 Offset: 0x376F11 VA: 0x376E10
	|-ArraySegment<Bounds>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x3770D0 Offset: 0x3771D1 VA: 0x3770D0
	|-ArraySegment<Color>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x377330 Offset: 0x377431 VA: 0x377330
	|-ArraySegment<Quaternion>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x377590 Offset: 0x377691 VA: 0x377590
	|-ArraySegment<Rect>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x3777F0 Offset: 0x3778F1 VA: 0x3777F0
	|-ArraySegment<Vector2>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x377A50 Offset: 0x377B51 VA: 0x377A50
	|-ArraySegment<Vector3>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x377CB0 Offset: 0x377DB1 VA: 0x377CB0
	|-ArraySegment<Vector4>.System.Collections.Generic.IList<T>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.IList<T>.Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375630 Offset: 0x375731 VA: 0x375630
	|-ArraySegment<ProfilerFrame>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x375890 Offset: 0x375991 VA: 0x375890
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x375AF0 Offset: 0x375BF1 VA: 0x375AF0
	|-ArraySegment<char>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x375D50 Offset: 0x375E51 VA: 0x375D50
	|-ArraySegment<double>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x375FB0 Offset: 0x3760B1 VA: 0x375FB0
	|-ArraySegment<int>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x376210 Offset: 0x376311 VA: 0x376210
	|-ArraySegment<long>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x376470 Offset: 0x376571 VA: 0x376470
	|-ArraySegment<object>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3766D0 Offset: 0x3767D1 VA: 0x3766D0
	|-ArraySegment<float>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x376930 Offset: 0x376A31 VA: 0x376930
	|-ArraySegment<ushort>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x376B90 Offset: 0x376C91 VA: 0x376B90
	|-ArraySegment<uint>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x376E50 Offset: 0x376F51 VA: 0x376E50
	|-ArraySegment<Bounds>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3770E0 Offset: 0x3771E1 VA: 0x3770E0
	|-ArraySegment<Color>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x377340 Offset: 0x377441 VA: 0x377340
	|-ArraySegment<Quaternion>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x3775A0 Offset: 0x3776A1 VA: 0x3775A0
	|-ArraySegment<Rect>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x377800 Offset: 0x377901 VA: 0x377800
	|-ArraySegment<Vector2>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x377A60 Offset: 0x377B61 VA: 0x377A60
	|-ArraySegment<Vector3>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x377CC0 Offset: 0x377DC1 VA: 0x377CC0
	|-ArraySegment<Vector4>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375640 Offset: 0x375741 VA: 0x375640
	|-ArraySegment<ProfilerFrame>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3758A0 Offset: 0x3759A1 VA: 0x3758A0
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x375B00 Offset: 0x375C01 VA: 0x375B00
	|-ArraySegment<char>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x375D60 Offset: 0x375E61 VA: 0x375D60
	|-ArraySegment<double>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x375FC0 Offset: 0x3760C1 VA: 0x375FC0
	|-ArraySegment<int>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x376220 Offset: 0x376321 VA: 0x376220
	|-ArraySegment<long>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x376480 Offset: 0x376581 VA: 0x376480
	|-ArraySegment<object>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3766E0 Offset: 0x3767E1 VA: 0x3766E0
	|-ArraySegment<float>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x376940 Offset: 0x376A41 VA: 0x376940
	|-ArraySegment<ushort>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x376BA0 Offset: 0x376CA1 VA: 0x376BA0
	|-ArraySegment<uint>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x376E60 Offset: 0x376F61 VA: 0x376E60
	|-ArraySegment<Bounds>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3770F0 Offset: 0x3771F1 VA: 0x3770F0
	|-ArraySegment<Color>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x377350 Offset: 0x377451 VA: 0x377350
	|-ArraySegment<Quaternion>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x3775B0 Offset: 0x3776B1 VA: 0x3775B0
	|-ArraySegment<Rect>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x377810 Offset: 0x377911 VA: 0x377810
	|-ArraySegment<Vector2>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x377A70 Offset: 0x377B71 VA: 0x377A70
	|-ArraySegment<Vector3>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x377CD0 Offset: 0x377DD1 VA: 0x377CD0
	|-ArraySegment<Vector4>.System.Collections.Generic.IList<T>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private T System.Collections.Generic.IReadOnlyList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375650 Offset: 0x375751 VA: 0x375650
	|-ArraySegment<ProfilerFrame>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x3758B0 Offset: 0x3759B1 VA: 0x3758B0
	|-ArraySegment<byte>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x375B10 Offset: 0x375C11 VA: 0x375B10
	|-ArraySegment<char>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x375D70 Offset: 0x375E71 VA: 0x375D70
	|-ArraySegment<double>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x375FD0 Offset: 0x3760D1 VA: 0x375FD0
	|-ArraySegment<int>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x376230 Offset: 0x376331 VA: 0x376230
	|-ArraySegment<long>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x376490 Offset: 0x376591 VA: 0x376490
	|-ArraySegment<object>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x3766F0 Offset: 0x3767F1 VA: 0x3766F0
	|-ArraySegment<float>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x376950 Offset: 0x376A51 VA: 0x376950
	|-ArraySegment<ushort>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x376BB0 Offset: 0x376CB1 VA: 0x376BB0
	|-ArraySegment<uint>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x376E70 Offset: 0x376F71 VA: 0x376E70
	|-ArraySegment<Bounds>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x377100 Offset: 0x377201 VA: 0x377100
	|-ArraySegment<Color>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x377360 Offset: 0x377461 VA: 0x377360
	|-ArraySegment<Quaternion>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x3775C0 Offset: 0x3776C1 VA: 0x3775C0
	|-ArraySegment<Rect>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x377820 Offset: 0x377921 VA: 0x377820
	|-ArraySegment<Vector2>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x377A80 Offset: 0x377B81 VA: 0x377A80
	|-ArraySegment<Vector3>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x377CE0 Offset: 0x377DE1 VA: 0x377CE0
	|-ArraySegment<Vector4>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375660 Offset: 0x375761 VA: 0x375660
	|-ArraySegment<ProfilerFrame>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3758C0 Offset: 0x3759C1 VA: 0x3758C0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x375B20 Offset: 0x375C21 VA: 0x375B20
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x375D80 Offset: 0x375E81 VA: 0x375D80
	|-ArraySegment<double>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x375FE0 Offset: 0x3760E1 VA: 0x375FE0
	|-ArraySegment<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x376240 Offset: 0x376341 VA: 0x376240
	|-ArraySegment<long>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3764A0 Offset: 0x3765A1 VA: 0x3764A0
	|-ArraySegment<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x376700 Offset: 0x376801 VA: 0x376700
	|-ArraySegment<float>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x376960 Offset: 0x376A61 VA: 0x376960
	|-ArraySegment<ushort>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x376BC0 Offset: 0x376CC1 VA: 0x376BC0
	|-ArraySegment<uint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x376E80 Offset: 0x376F81 VA: 0x376E80
	|-ArraySegment<Bounds>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x377110 Offset: 0x377211 VA: 0x377110
	|-ArraySegment<Color>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x377370 Offset: 0x377471 VA: 0x377370
	|-ArraySegment<Quaternion>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3775D0 Offset: 0x3776D1 VA: 0x3775D0
	|-ArraySegment<Rect>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x377830 Offset: 0x377931 VA: 0x377830
	|-ArraySegment<Vector2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x377A90 Offset: 0x377B91 VA: 0x377A90
	|-ArraySegment<Vector3>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x377CF0 Offset: 0x377DF1 VA: 0x377CF0
	|-ArraySegment<Vector4>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375670 Offset: 0x375771 VA: 0x375670
	|-ArraySegment<ProfilerFrame>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3758D0 Offset: 0x3759D1 VA: 0x3758D0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x375B30 Offset: 0x375C31 VA: 0x375B30
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x375D90 Offset: 0x375E91 VA: 0x375D90
	|-ArraySegment<double>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x375FF0 Offset: 0x3760F1 VA: 0x375FF0
	|-ArraySegment<int>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x376250 Offset: 0x376351 VA: 0x376250
	|-ArraySegment<long>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3764B0 Offset: 0x3765B1 VA: 0x3764B0
	|-ArraySegment<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x376710 Offset: 0x376811 VA: 0x376710
	|-ArraySegment<float>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x376970 Offset: 0x376A71 VA: 0x376970
	|-ArraySegment<ushort>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x376BD0 Offset: 0x376CD1 VA: 0x376BD0
	|-ArraySegment<uint>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x376E90 Offset: 0x376F91 VA: 0x376E90
	|-ArraySegment<Bounds>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x377120 Offset: 0x377221 VA: 0x377120
	|-ArraySegment<Color>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x377380 Offset: 0x377481 VA: 0x377380
	|-ArraySegment<Quaternion>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3775E0 Offset: 0x3776E1 VA: 0x3775E0
	|-ArraySegment<Rect>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x377840 Offset: 0x377941 VA: 0x377840
	|-ArraySegment<Vector2>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x377AA0 Offset: 0x377BA1 VA: 0x377AA0
	|-ArraySegment<Vector3>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x377D00 Offset: 0x377E01 VA: 0x377D00
	|-ArraySegment<Vector4>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375680 Offset: 0x375781 VA: 0x375680
	|-ArraySegment<ProfilerFrame>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3758E0 Offset: 0x3759E1 VA: 0x3758E0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x375B40 Offset: 0x375C41 VA: 0x375B40
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x375DA0 Offset: 0x375EA1 VA: 0x375DA0
	|-ArraySegment<double>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x376000 Offset: 0x376101 VA: 0x376000
	|-ArraySegment<int>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x376260 Offset: 0x376361 VA: 0x376260
	|-ArraySegment<long>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3764C0 Offset: 0x3765C1 VA: 0x3764C0
	|-ArraySegment<object>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x376720 Offset: 0x376821 VA: 0x376720
	|-ArraySegment<float>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x376980 Offset: 0x376A81 VA: 0x376980
	|-ArraySegment<ushort>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x376BE0 Offset: 0x376CE1 VA: 0x376BE0
	|-ArraySegment<uint>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x376EA0 Offset: 0x376FA1 VA: 0x376EA0
	|-ArraySegment<Bounds>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x377130 Offset: 0x377231 VA: 0x377130
	|-ArraySegment<Color>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x377390 Offset: 0x377491 VA: 0x377390
	|-ArraySegment<Quaternion>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x3775F0 Offset: 0x3776F1 VA: 0x3775F0
	|-ArraySegment<Rect>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x377850 Offset: 0x377951 VA: 0x377850
	|-ArraySegment<Vector2>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x377AB0 Offset: 0x377BB1 VA: 0x377AB0
	|-ArraySegment<Vector3>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x377D10 Offset: 0x377E11 VA: 0x377D10
	|-ArraySegment<Vector4>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<T>.Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375690 Offset: 0x375791 VA: 0x375690
	|-ArraySegment<ProfilerFrame>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x3758F0 Offset: 0x3759F1 VA: 0x3758F0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x375B50 Offset: 0x375C51 VA: 0x375B50
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x375DB0 Offset: 0x375EB1 VA: 0x375DB0
	|-ArraySegment<double>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x376010 Offset: 0x376111 VA: 0x376010
	|-ArraySegment<int>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x376270 Offset: 0x376371 VA: 0x376270
	|-ArraySegment<long>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x3764D0 Offset: 0x3765D1 VA: 0x3764D0
	|-ArraySegment<object>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x376730 Offset: 0x376831 VA: 0x376730
	|-ArraySegment<float>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x376990 Offset: 0x376A91 VA: 0x376990
	|-ArraySegment<ushort>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x376BF0 Offset: 0x376CF1 VA: 0x376BF0
	|-ArraySegment<uint>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x376EB0 Offset: 0x376FB1 VA: 0x376EB0
	|-ArraySegment<Bounds>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x377140 Offset: 0x377241 VA: 0x377140
	|-ArraySegment<Color>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x3773A0 Offset: 0x3774A1 VA: 0x3773A0
	|-ArraySegment<Quaternion>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x377600 Offset: 0x377701 VA: 0x377600
	|-ArraySegment<Rect>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x377860 Offset: 0x377961 VA: 0x377860
	|-ArraySegment<Vector2>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x377AC0 Offset: 0x377BC1 VA: 0x377AC0
	|-ArraySegment<Vector3>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x377D20 Offset: 0x377E21 VA: 0x377D20
	|-ArraySegment<Vector4>.System.Collections.Generic.ICollection<T>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<T>.CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3756A0 Offset: 0x3757A1 VA: 0x3756A0
	|-ArraySegment<ProfilerFrame>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x375900 Offset: 0x375A01 VA: 0x375900
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x375B60 Offset: 0x375C61 VA: 0x375B60
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x375DC0 Offset: 0x375EC1 VA: 0x375DC0
	|-ArraySegment<double>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x376020 Offset: 0x376121 VA: 0x376020
	|-ArraySegment<int>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x376280 Offset: 0x376381 VA: 0x376280
	|-ArraySegment<long>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x3764E0 Offset: 0x3765E1 VA: 0x3764E0
	|-ArraySegment<object>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x376740 Offset: 0x376841 VA: 0x376740
	|-ArraySegment<float>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x3769A0 Offset: 0x376AA1 VA: 0x3769A0
	|-ArraySegment<ushort>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x376C00 Offset: 0x376D01 VA: 0x376C00
	|-ArraySegment<uint>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x376EF0 Offset: 0x376FF1 VA: 0x376EF0
	|-ArraySegment<Bounds>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x377150 Offset: 0x377251 VA: 0x377150
	|-ArraySegment<Color>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x3773B0 Offset: 0x3774B1 VA: 0x3773B0
	|-ArraySegment<Quaternion>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x377610 Offset: 0x377711 VA: 0x377610
	|-ArraySegment<Rect>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x377870 Offset: 0x377971 VA: 0x377870
	|-ArraySegment<Vector2>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x377AD0 Offset: 0x377BD1 VA: 0x377AD0
	|-ArraySegment<Vector3>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x377D30 Offset: 0x377E31 VA: 0x377D30
	|-ArraySegment<Vector4>.System.Collections.Generic.ICollection<T>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<T>.Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3756B0 Offset: 0x3757B1 VA: 0x3756B0
	|-ArraySegment<ProfilerFrame>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x375910 Offset: 0x375A11 VA: 0x375910
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x375B70 Offset: 0x375C71 VA: 0x375B70
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x375DD0 Offset: 0x375ED1 VA: 0x375DD0
	|-ArraySegment<double>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x376030 Offset: 0x376131 VA: 0x376030
	|-ArraySegment<int>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x376290 Offset: 0x376391 VA: 0x376290
	|-ArraySegment<long>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3764F0 Offset: 0x3765F1 VA: 0x3764F0
	|-ArraySegment<object>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x376750 Offset: 0x376851 VA: 0x376750
	|-ArraySegment<float>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3769B0 Offset: 0x376AB1 VA: 0x3769B0
	|-ArraySegment<ushort>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x376C10 Offset: 0x376D11 VA: 0x376C10
	|-ArraySegment<uint>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x376F00 Offset: 0x377001 VA: 0x376F00
	|-ArraySegment<Bounds>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x377160 Offset: 0x377261 VA: 0x377160
	|-ArraySegment<Color>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x3773C0 Offset: 0x3774C1 VA: 0x3773C0
	|-ArraySegment<Quaternion>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x377620 Offset: 0x377721 VA: 0x377620
	|-ArraySegment<Rect>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x377880 Offset: 0x377981 VA: 0x377880
	|-ArraySegment<Vector2>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x377AE0 Offset: 0x377BE1 VA: 0x377AE0
	|-ArraySegment<Vector3>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x377D40 Offset: 0x377E41 VA: 0x377D40
	|-ArraySegment<Vector4>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3756C0 Offset: 0x3757C1 VA: 0x3756C0
	|-ArraySegment<ProfilerFrame>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x375920 Offset: 0x375A21 VA: 0x375920
	|-ArraySegment<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x375B80 Offset: 0x375C81 VA: 0x375B80
	|-ArraySegment<char>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x375DE0 Offset: 0x375EE1 VA: 0x375DE0
	|-ArraySegment<double>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x376040 Offset: 0x376141 VA: 0x376040
	|-ArraySegment<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3762A0 Offset: 0x3763A1 VA: 0x3762A0
	|-ArraySegment<long>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x376500 Offset: 0x376601 VA: 0x376500
	|-ArraySegment<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x376760 Offset: 0x376861 VA: 0x376760
	|-ArraySegment<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3769C0 Offset: 0x376AC1 VA: 0x3769C0
	|-ArraySegment<ushort>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x376C20 Offset: 0x376D21 VA: 0x376C20
	|-ArraySegment<uint>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x376F10 Offset: 0x377011 VA: 0x376F10
	|-ArraySegment<Bounds>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x377170 Offset: 0x377271 VA: 0x377170
	|-ArraySegment<Color>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3773D0 Offset: 0x3774D1 VA: 0x3773D0
	|-ArraySegment<Quaternion>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x377630 Offset: 0x377731 VA: 0x377630
	|-ArraySegment<Rect>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x377890 Offset: 0x377991 VA: 0x377890
	|-ArraySegment<Vector2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x377AF0 Offset: 0x377BF1 VA: 0x377AF0
	|-ArraySegment<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x377D50 Offset: 0x377E51 VA: 0x377D50
	|-ArraySegment<Vector4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3756D0 Offset: 0x3757D1 VA: 0x3756D0
	|-ArraySegment<ProfilerFrame>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x375930 Offset: 0x375A31 VA: 0x375930
	|-ArraySegment<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x375B90 Offset: 0x375C91 VA: 0x375B90
	|-ArraySegment<char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x375DF0 Offset: 0x375EF1 VA: 0x375DF0
	|-ArraySegment<double>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x376050 Offset: 0x376151 VA: 0x376050
	|-ArraySegment<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3762B0 Offset: 0x3763B1 VA: 0x3762B0
	|-ArraySegment<long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x376510 Offset: 0x376611 VA: 0x376510
	|-ArraySegment<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x376770 Offset: 0x376871 VA: 0x376770
	|-ArraySegment<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3769D0 Offset: 0x376AD1 VA: 0x3769D0
	|-ArraySegment<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x376C30 Offset: 0x376D31 VA: 0x376C30
	|-ArraySegment<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x376F20 Offset: 0x377021 VA: 0x376F20
	|-ArraySegment<Bounds>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x377180 Offset: 0x377281 VA: 0x377180
	|-ArraySegment<Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3773E0 Offset: 0x3774E1 VA: 0x3773E0
	|-ArraySegment<Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x377640 Offset: 0x377741 VA: 0x377640
	|-ArraySegment<Rect>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3778A0 Offset: 0x3779A1 VA: 0x3778A0
	|-ArraySegment<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x377B00 Offset: 0x377C01 VA: 0x377B00
	|-ArraySegment<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x377D60 Offset: 0x377E61 VA: 0x377D60
	|-ArraySegment<Vector4>.System.Collections.IEnumerable.GetEnumerator
	*/
}

