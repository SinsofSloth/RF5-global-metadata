public static class Unsafe // TypeDefIndex: 3763
{
	// Methods

	[NonVersionableAttribute] // RVA: 0x108CB0 Offset: 0x108DB1 VA: 0x108CB0
	// RVA: -1 Offset: -1
	public static T Read<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2264040 Offset: 0x2264141 VA: 0x2264040
	|-Unsafe.Read<Vector<ushort>>
	|
	|-RVA: 0x2264050 Offset: 0x2264151 VA: 0x2264050
	|-Unsafe.Read<object>
	*/

	[NonVersionableAttribute] // RVA: 0x108CC0 Offset: 0x108DC1 VA: 0x108CC0
	// RVA: -1 Offset: -1
	public static T ReadUnaligned<T>(ref byte source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22640A0 Offset: 0x22641A1 VA: 0x22640A0
	|-Unsafe.ReadUnaligned<Vector<byte>>
	|
	|-RVA: 0x22640C0 Offset: 0x22641C1 VA: 0x22640C0
	|-Unsafe.ReadUnaligned<UIntPtr>
	|
	|-RVA: 0x2264060 Offset: 0x2264161 VA: 0x2264060
	|-Unsafe.ReadUnaligned<byte>
	|
	|-RVA: 0x2264070 Offset: 0x2264171 VA: 0x2264070
	|-Unsafe.ReadUnaligned<short>
	|
	|-RVA: 0x2264080 Offset: 0x2264181 VA: 0x2264080
	|-Unsafe.ReadUnaligned<int>
	|
	|-RVA: 0x2264090 Offset: 0x2264191 VA: 0x2264090
	|-Unsafe.ReadUnaligned<long>
	|
	|-RVA: 0x22640B0 Offset: 0x22641B1 VA: 0x22640B0
	|-Unsafe.ReadUnaligned<object>
	*/

	[NonVersionableAttribute] // RVA: 0x108CD0 Offset: 0x108DD1 VA: 0x108CD0
	// RVA: -1 Offset: -1
	public static void* AsPointer<T>(ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BDE30 Offset: 0x23BDF31 VA: 0x23BDE30
	|-Unsafe.AsPointer<byte>
	|
	|-RVA: 0x23BDE40 Offset: 0x23BDF41 VA: 0x23BDE40
	|-Unsafe.AsPointer<object>
	*/

	[NonVersionableAttribute] // RVA: 0x108CE0 Offset: 0x108DE1 VA: 0x108CE0
	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255C670 Offset: 0x255C771 VA: 0x255C670
	|-Unsafe.SizeOf<byte>
	|
	|-RVA: 0x255C680 Offset: 0x255C781 VA: 0x255C680
	|-Unsafe.SizeOf<char>
	|
	|-RVA: 0x255C690 Offset: 0x255C791 VA: 0x255C690
	|-Unsafe.SizeOf<double>
	|
	|-RVA: 0x255C6A0 Offset: 0x255C7A1 VA: 0x255C6A0
	|-Unsafe.SizeOf<int>
	|
	|-RVA: 0x255C6B0 Offset: 0x255C7B1 VA: 0x255C6B0
	|-Unsafe.SizeOf<long>
	|
	|-RVA: 0x255C6C0 Offset: 0x255C7C1 VA: 0x255C6C0
	|-Unsafe.SizeOf<Vector<ushort>>
	|
	|-RVA: 0x255C6D0 Offset: 0x255C7D1 VA: 0x255C6D0
	|-Unsafe.SizeOf<object>
	|
	|-RVA: 0x255C6E0 Offset: 0x255C7E1 VA: 0x255C6E0
	|-Unsafe.SizeOf<float>
	|
	|-RVA: 0x255C6F0 Offset: 0x255C7F1 VA: 0x255C6F0
	|-Unsafe.SizeOf<ushort>
	|
	|-RVA: 0x255C700 Offset: 0x255C801 VA: 0x255C700
	|-Unsafe.SizeOf<uint>
	|
	|-RVA: 0x255C710 Offset: 0x255C811 VA: 0x255C710
	|-Unsafe.SizeOf<Bounds>
	|
	|-RVA: 0x255C720 Offset: 0x255C821 VA: 0x255C720
	|-Unsafe.SizeOf<Color>
	|
	|-RVA: 0x255C730 Offset: 0x255C831 VA: 0x255C730
	|-Unsafe.SizeOf<Quaternion>
	|
	|-RVA: 0x255C740 Offset: 0x255C841 VA: 0x255C740
	|-Unsafe.SizeOf<Rect>
	|
	|-RVA: 0x255C750 Offset: 0x255C851 VA: 0x255C750
	|-Unsafe.SizeOf<Vector2>
	|
	|-RVA: 0x255C760 Offset: 0x255C861 VA: 0x255C760
	|-Unsafe.SizeOf<Vector3>
	|
	|-RVA: 0x255C770 Offset: 0x255C871 VA: 0x255C770
	|-Unsafe.SizeOf<Vector4>
	*/

	[NonVersionableAttribute] // RVA: 0x108CF0 Offset: 0x108DF1 VA: 0x108CF0
	// RVA: 0x1BE3D30 Offset: 0x1BE3E31 VA: 0x1BE3D30
	public static void CopyBlock(ref byte destination, ref byte source, uint byteCount) { }

	[NonVersionableAttribute] // RVA: 0x108D00 Offset: 0x108E01 VA: 0x108D00
	// RVA: 0x1BE3D40 Offset: 0x1BE3E41 VA: 0x1BE3D40
	public static void InitBlockUnaligned(void* startAddress, byte value, uint byteCount) { }

	[NonVersionableAttribute] // RVA: 0x108D10 Offset: 0x108E11 VA: 0x108D10
	// RVA: 0x1BE3D50 Offset: 0x1BE3E51 VA: 0x1BE3D50
	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount) { }

	[NonVersionableAttribute] // RVA: 0x108D20 Offset: 0x108E21 VA: 0x108D20
	// RVA: -1 Offset: -1
	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2264020 Offset: 0x2264121 VA: 0x2264020
	|-Unsafe.As<Pinnable<char>>
	|-Unsafe.As<IValueTaskSource>
	|-Unsafe.As<object>
	*/

	[NonVersionableAttribute] // RVA: 0x108D30 Offset: 0x108E31 VA: 0x108D30
	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22676D0 Offset: 0x22677D1 VA: 0x22676D0
	|-Unsafe.AsRef<char>
	|
	|-RVA: 0x22676B0 Offset: 0x22677B1 VA: 0x22676B0
	|-Unsafe.AsRef<byte>
	|
	|-RVA: 0x22676E0 Offset: 0x22677E1 VA: 0x22676E0
	|-Unsafe.AsRef<double>
	|
	|-RVA: 0x22676F0 Offset: 0x22677F1 VA: 0x22676F0
	|-Unsafe.AsRef<int>
	|
	|-RVA: 0x2267700 Offset: 0x2267801 VA: 0x2267700
	|-Unsafe.AsRef<long>
	|
	|-RVA: 0x2267720 Offset: 0x2267821 VA: 0x2267720
	|-Unsafe.AsRef<object>
	|
	|-RVA: 0x2267730 Offset: 0x2267831 VA: 0x2267730
	|-Unsafe.AsRef<float>
	|
	|-RVA: 0x2267740 Offset: 0x2267841 VA: 0x2267740
	|-Unsafe.AsRef<ushort>
	|
	|-RVA: 0x2267750 Offset: 0x2267851 VA: 0x2267750
	|-Unsafe.AsRef<uint>
	|
	|-RVA: 0x2267760 Offset: 0x2267861 VA: 0x2267760
	|-Unsafe.AsRef<Bounds>
	|
	|-RVA: 0x2267770 Offset: 0x2267871 VA: 0x2267770
	|-Unsafe.AsRef<Color>
	|
	|-RVA: 0x2267780 Offset: 0x2267881 VA: 0x2267780
	|-Unsafe.AsRef<Quaternion>
	|
	|-RVA: 0x2267790 Offset: 0x2267891 VA: 0x2267790
	|-Unsafe.AsRef<Rect>
	|
	|-RVA: 0x22677A0 Offset: 0x22678A1 VA: 0x22677A0
	|-Unsafe.AsRef<Vector2>
	|
	|-RVA: 0x22677B0 Offset: 0x22678B1 VA: 0x22677B0
	|-Unsafe.AsRef<Vector3>
	|
	|-RVA: 0x22677C0 Offset: 0x22678C1 VA: 0x22677C0
	|-Unsafe.AsRef<Vector4>
	*/

	[NonVersionableAttribute] // RVA: 0x108D40 Offset: 0x108E41 VA: 0x108D40
	// RVA: -1 Offset: -1
	public static ref TTo As<TFrom, TTo>(ref TFrom source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226C660 Offset: 0x226C761 VA: 0x226C660
	|-Unsafe.As<byte, int>
	|
	|-RVA: 0x226C670 Offset: 0x226C771 VA: 0x226C670
	|-Unsafe.As<byte, long>
	|
	|-RVA: 0x226C6A0 Offset: 0x226C7A1 VA: 0x226C6A0
	|-Unsafe.As<byte, SpanHelpers.Reg16>
	|
	|-RVA: 0x226C6B0 Offset: 0x226C7B1 VA: 0x226C6B0
	|-Unsafe.As<byte, SpanHelpers.Reg32>
	|
	|-RVA: 0x226C6C0 Offset: 0x226C7C1 VA: 0x226C6C0
	|-Unsafe.As<byte, SpanHelpers.Reg64>
	|
	|-RVA: 0x226C700 Offset: 0x226C801 VA: 0x226C700
	|-Unsafe.As<Decimal, MutableDecimal>
	|
	|-RVA: 0x226C800 Offset: 0x226C901 VA: 0x226C800
	|-Unsafe.As<MutableDecimal, Decimal>
	|
	|-RVA: 0x226C610 Offset: 0x226C711 VA: 0x226C610
	|-Unsafe.As<ReadOnlySequence<byte>, ReadOnlySequence<char>>
	|
	|-RVA: 0x226C620 Offset: 0x226C721 VA: 0x226C620
	|-Unsafe.As<ReadOnlySequence<char>, ReadOnlySequence<char>>
	|
	|-RVA: 0x226C630 Offset: 0x226C731 VA: 0x226C630
	|-Unsafe.As<ReadOnlySequence<object>, ReadOnlySequence<char>>
	|
	|-RVA: 0x226C640 Offset: 0x226C741 VA: 0x226C640
	|-Unsafe.As<byte, byte>
	|
	|-RVA: 0x226C650 Offset: 0x226C751 VA: 0x226C650
	|-Unsafe.As<byte, char>
	|
	|-RVA: 0x226C680 Offset: 0x226C781 VA: 0x226C680
	|-Unsafe.As<byte, IntPtr>
	|
	|-RVA: 0x226C690 Offset: 0x226C791 VA: 0x226C690
	|-Unsafe.As<byte, object>
	|
	|-RVA: 0x226C6D0 Offset: 0x226C7D1 VA: 0x226C6D0
	|-Unsafe.As<char, byte>
	|
	|-RVA: 0x226C6E0 Offset: 0x226C7E1 VA: 0x226C6E0
	|-Unsafe.As<char, char>
	|
	|-RVA: 0x226C6F0 Offset: 0x226C7F1 VA: 0x226C6F0
	|-Unsafe.As<char, IntPtr>
	|
	|-RVA: 0x226C710 Offset: 0x226C811 VA: 0x226C710
	|-Unsafe.As<double, byte>
	|
	|-RVA: 0x226C720 Offset: 0x226C821 VA: 0x226C720
	|-Unsafe.As<double, char>
	|
	|-RVA: 0x226C730 Offset: 0x226C831 VA: 0x226C730
	|-Unsafe.As<double, IntPtr>
	|
	|-RVA: 0x226C740 Offset: 0x226C841 VA: 0x226C740
	|-Unsafe.As<short, object>
	|
	|-RVA: 0x226C750 Offset: 0x226C851 VA: 0x226C750
	|-Unsafe.As<int, byte>
	|
	|-RVA: 0x226C760 Offset: 0x226C861 VA: 0x226C760
	|-Unsafe.As<int, char>
	|
	|-RVA: 0x226C770 Offset: 0x226C871 VA: 0x226C770
	|-Unsafe.As<int, IntPtr>
	|
	|-RVA: 0x226C780 Offset: 0x226C881 VA: 0x226C780
	|-Unsafe.As<int, object>
	|
	|-RVA: 0x226C790 Offset: 0x226C891 VA: 0x226C790
	|-Unsafe.As<long, byte>
	|
	|-RVA: 0x226C7A0 Offset: 0x226C8A1 VA: 0x226C7A0
	|-Unsafe.As<long, char>
	|
	|-RVA: 0x226C7B0 Offset: 0x226C8B1 VA: 0x226C7B0
	|-Unsafe.As<long, IntPtr>
	|
	|-RVA: 0x226C7C0 Offset: 0x226C8C1 VA: 0x226C7C0
	|-Unsafe.As<long, object>
	|
	|-RVA: 0x226C7D0 Offset: 0x226C8D1 VA: 0x226C7D0
	|-Unsafe.As<Memory<byte>, ReadOnlyMemory<byte>>
	|
	|-RVA: 0x226C7E0 Offset: 0x226C8E1 VA: 0x226C7E0
	|-Unsafe.As<Memory<char>, ReadOnlyMemory<char>>
	|
	|-RVA: 0x226C7F0 Offset: 0x226C8F1 VA: 0x226C7F0
	|-Unsafe.As<Memory<object>, ReadOnlyMemory<object>>
	|
	|-RVA: 0x226C810 Offset: 0x226C911 VA: 0x226C810
	|-Unsafe.As<object, byte>
	|
	|-RVA: 0x226C820 Offset: 0x226C921 VA: 0x226C820
	|-Unsafe.As<object, char>
	|
	|-RVA: 0x226C830 Offset: 0x226C931 VA: 0x226C830
	|-Unsafe.As<object, short>
	|
	|-RVA: 0x226C840 Offset: 0x226C941 VA: 0x226C840
	|-Unsafe.As<object, int>
	|
	|-RVA: 0x226C850 Offset: 0x226C951 VA: 0x226C850
	|-Unsafe.As<object, long>
	|
	|-RVA: 0x226C860 Offset: 0x226C961 VA: 0x226C860
	|-Unsafe.As<object, IntPtr>
	|
	|-RVA: 0x226C870 Offset: 0x226C971 VA: 0x226C870
	|-Unsafe.As<object, object>
	|
	|-RVA: 0x226C880 Offset: 0x226C981 VA: 0x226C880
	|-Unsafe.As<object, sbyte>
	|
	|-RVA: 0x226C890 Offset: 0x226C991 VA: 0x226C890
	|-Unsafe.As<object, ushort>
	|
	|-RVA: 0x226C8A0 Offset: 0x226C9A1 VA: 0x226C8A0
	|-Unsafe.As<object, uint>
	|
	|-RVA: 0x226C8B0 Offset: 0x226C9B1 VA: 0x226C8B0
	|-Unsafe.As<object, ulong>
	|
	|-RVA: 0x226C8C0 Offset: 0x226C9C1 VA: 0x226C8C0
	|-Unsafe.As<sbyte, object>
	|
	|-RVA: 0x226C8D0 Offset: 0x226C9D1 VA: 0x226C8D0
	|-Unsafe.As<float, byte>
	|
	|-RVA: 0x226C8E0 Offset: 0x226C9E1 VA: 0x226C8E0
	|-Unsafe.As<float, char>
	|
	|-RVA: 0x226C8F0 Offset: 0x226C9F1 VA: 0x226C8F0
	|-Unsafe.As<float, IntPtr>
	|
	|-RVA: 0x226C900 Offset: 0x226CA01 VA: 0x226C900
	|-Unsafe.As<ushort, byte>
	|
	|-RVA: 0x226C910 Offset: 0x226CA11 VA: 0x226C910
	|-Unsafe.As<ushort, char>
	|
	|-RVA: 0x226C920 Offset: 0x226CA21 VA: 0x226C920
	|-Unsafe.As<ushort, IntPtr>
	|
	|-RVA: 0x226C930 Offset: 0x226CA31 VA: 0x226C930
	|-Unsafe.As<ushort, object>
	|
	|-RVA: 0x226C940 Offset: 0x226CA41 VA: 0x226C940
	|-Unsafe.As<uint, byte>
	|
	|-RVA: 0x226C950 Offset: 0x226CA51 VA: 0x226C950
	|-Unsafe.As<uint, char>
	|
	|-RVA: 0x226C960 Offset: 0x226CA61 VA: 0x226C960
	|-Unsafe.As<uint, IntPtr>
	|
	|-RVA: 0x226C970 Offset: 0x226CA71 VA: 0x226C970
	|-Unsafe.As<uint, object>
	|
	|-RVA: 0x226C980 Offset: 0x226CA81 VA: 0x226C980
	|-Unsafe.As<ulong, object>
	|
	|-RVA: 0x226C990 Offset: 0x226CA91 VA: 0x226C990
	|-Unsafe.As<Bounds, byte>
	|
	|-RVA: 0x226C9A0 Offset: 0x226CAA1 VA: 0x226C9A0
	|-Unsafe.As<Bounds, char>
	|
	|-RVA: 0x226C9B0 Offset: 0x226CAB1 VA: 0x226C9B0
	|-Unsafe.As<Bounds, IntPtr>
	|
	|-RVA: 0x226C9C0 Offset: 0x226CAC1 VA: 0x226C9C0
	|-Unsafe.As<Color, byte>
	|
	|-RVA: 0x226C9D0 Offset: 0x226CAD1 VA: 0x226C9D0
	|-Unsafe.As<Color, char>
	|
	|-RVA: 0x226C9E0 Offset: 0x226CAE1 VA: 0x226C9E0
	|-Unsafe.As<Color, IntPtr>
	|
	|-RVA: 0x226C9F0 Offset: 0x226CAF1 VA: 0x226C9F0
	|-Unsafe.As<Quaternion, byte>
	|
	|-RVA: 0x226CA00 Offset: 0x226CB01 VA: 0x226CA00
	|-Unsafe.As<Quaternion, char>
	|
	|-RVA: 0x226CA10 Offset: 0x226CB11 VA: 0x226CA10
	|-Unsafe.As<Quaternion, IntPtr>
	|
	|-RVA: 0x226CA20 Offset: 0x226CB21 VA: 0x226CA20
	|-Unsafe.As<Rect, byte>
	|
	|-RVA: 0x226CA30 Offset: 0x226CB31 VA: 0x226CA30
	|-Unsafe.As<Rect, char>
	|
	|-RVA: 0x226CA40 Offset: 0x226CB41 VA: 0x226CA40
	|-Unsafe.As<Rect, IntPtr>
	|
	|-RVA: 0x226CA50 Offset: 0x226CB51 VA: 0x226CA50
	|-Unsafe.As<Vector2, byte>
	|
	|-RVA: 0x226CA60 Offset: 0x226CB61 VA: 0x226CA60
	|-Unsafe.As<Vector2, char>
	|
	|-RVA: 0x226CA70 Offset: 0x226CB71 VA: 0x226CA70
	|-Unsafe.As<Vector2, IntPtr>
	|
	|-RVA: 0x226CA80 Offset: 0x226CB81 VA: 0x226CA80
	|-Unsafe.As<Vector3, byte>
	|
	|-RVA: 0x226CA90 Offset: 0x226CB91 VA: 0x226CA90
	|-Unsafe.As<Vector3, char>
	|
	|-RVA: 0x226CAA0 Offset: 0x226CBA1 VA: 0x226CAA0
	|-Unsafe.As<Vector3, IntPtr>
	|
	|-RVA: 0x226CAB0 Offset: 0x226CBB1 VA: 0x226CAB0
	|-Unsafe.As<Vector4, byte>
	|
	|-RVA: 0x226CAC0 Offset: 0x226CBC1 VA: 0x226CAC0
	|-Unsafe.As<Vector4, char>
	|
	|-RVA: 0x226CAD0 Offset: 0x226CBD1 VA: 0x226CAD0
	|-Unsafe.As<Vector4, IntPtr>
	*/

	[NonVersionableAttribute] // RVA: 0x108D50 Offset: 0x108E51 VA: 0x108D50
	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2267440 Offset: 0x2267541 VA: 0x2267440
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x2267470 Offset: 0x2267571 VA: 0x2267470
	|-Unsafe.Add<char>
	|
	|-RVA: 0x2267480 Offset: 0x2267581 VA: 0x2267480
	|-Unsafe.Add<double>
	|
	|-RVA: 0x2267490 Offset: 0x2267591 VA: 0x2267490
	|-Unsafe.Add<int>
	|
	|-RVA: 0x22674A0 Offset: 0x22675A1 VA: 0x22674A0
	|-Unsafe.Add<long>
	|
	|-RVA: 0x22674C0 Offset: 0x22675C1 VA: 0x22674C0
	|-Unsafe.Add<object>
	|
	|-RVA: 0x22674F0 Offset: 0x22675F1 VA: 0x22674F0
	|-Unsafe.Add<float>
	|
	|-RVA: 0x2267500 Offset: 0x2267601 VA: 0x2267500
	|-Unsafe.Add<ushort>
	|
	|-RVA: 0x2267510 Offset: 0x2267611 VA: 0x2267510
	|-Unsafe.Add<uint>
	|
	|-RVA: 0x2267520 Offset: 0x2267621 VA: 0x2267520
	|-Unsafe.Add<Bounds>
	|
	|-RVA: 0x2267530 Offset: 0x2267631 VA: 0x2267530
	|-Unsafe.Add<Color>
	|
	|-RVA: 0x2267540 Offset: 0x2267641 VA: 0x2267540
	|-Unsafe.Add<Quaternion>
	|
	|-RVA: 0x2267550 Offset: 0x2267651 VA: 0x2267550
	|-Unsafe.Add<Rect>
	|
	|-RVA: 0x2267560 Offset: 0x2267661 VA: 0x2267560
	|-Unsafe.Add<Vector2>
	|
	|-RVA: 0x2267570 Offset: 0x2267671 VA: 0x2267570
	|-Unsafe.Add<Vector3>
	|
	|-RVA: 0x2267580 Offset: 0x2267681 VA: 0x2267580
	|-Unsafe.Add<Vector4>
	*/

	[NonVersionableAttribute] // RVA: 0x108D60 Offset: 0x108E61 VA: 0x108D60
	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, IntPtr elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2267460 Offset: 0x2267561 VA: 0x2267460
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x22674B0 Offset: 0x22675B1 VA: 0x22674B0
	|-Unsafe.Add<IntPtr>
	|
	|-RVA: 0x22674E0 Offset: 0x22675E1 VA: 0x22674E0
	|-Unsafe.Add<object>
	*/

	[NonVersionableAttribute] // RVA: 0x108D70 Offset: 0x108E71 VA: 0x108D70
	// RVA: -1 Offset: -1
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2267590 Offset: 0x2267691 VA: 0x2267590
	|-Unsafe.AddByteOffset<byte>
	|
	|-RVA: 0x22675B0 Offset: 0x22676B1 VA: 0x22675B0
	|-Unsafe.AddByteOffset<char>
	|
	|-RVA: 0x22675C0 Offset: 0x22676C1 VA: 0x22675C0
	|-Unsafe.AddByteOffset<double>
	|
	|-RVA: 0x22675D0 Offset: 0x22676D1 VA: 0x22675D0
	|-Unsafe.AddByteOffset<int>
	|
	|-RVA: 0x22675E0 Offset: 0x22676E1 VA: 0x22675E0
	|-Unsafe.AddByteOffset<long>
	|
	|-RVA: 0x22675F0 Offset: 0x22676F1 VA: 0x22675F0
	|-Unsafe.AddByteOffset<object>
	|
	|-RVA: 0x2267610 Offset: 0x2267711 VA: 0x2267610
	|-Unsafe.AddByteOffset<float>
	|
	|-RVA: 0x2267620 Offset: 0x2267721 VA: 0x2267620
	|-Unsafe.AddByteOffset<ushort>
	|
	|-RVA: 0x2267630 Offset: 0x2267731 VA: 0x2267630
	|-Unsafe.AddByteOffset<uint>
	|
	|-RVA: 0x2267640 Offset: 0x2267741 VA: 0x2267640
	|-Unsafe.AddByteOffset<Bounds>
	|
	|-RVA: 0x2267650 Offset: 0x2267751 VA: 0x2267650
	|-Unsafe.AddByteOffset<Color>
	|
	|-RVA: 0x2267660 Offset: 0x2267761 VA: 0x2267660
	|-Unsafe.AddByteOffset<Quaternion>
	|
	|-RVA: 0x2267670 Offset: 0x2267771 VA: 0x2267670
	|-Unsafe.AddByteOffset<Rect>
	|
	|-RVA: 0x2267680 Offset: 0x2267781 VA: 0x2267680
	|-Unsafe.AddByteOffset<Vector2>
	|
	|-RVA: 0x2267690 Offset: 0x2267791 VA: 0x2267690
	|-Unsafe.AddByteOffset<Vector3>
	|
	|-RVA: 0x22676A0 Offset: 0x22677A1 VA: 0x22676A0
	|-Unsafe.AddByteOffset<Vector4>
	*/

	[NonVersionableAttribute] // RVA: 0x108D80 Offset: 0x108E81 VA: 0x108D80
	// RVA: -1 Offset: -1
	public static IntPtr ByteOffset<T>(ref T origin, ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255E650 Offset: 0x255E751 VA: 0x255E650
	|-Unsafe.ByteOffset<byte>
	|
	|-RVA: 0x255E670 Offset: 0x255E771 VA: 0x255E670
	|-Unsafe.ByteOffset<char>
	|
	|-RVA: 0x255E680 Offset: 0x255E781 VA: 0x255E680
	|-Unsafe.ByteOffset<double>
	|
	|-RVA: 0x255E690 Offset: 0x255E791 VA: 0x255E690
	|-Unsafe.ByteOffset<int>
	|
	|-RVA: 0x255E6A0 Offset: 0x255E7A1 VA: 0x255E6A0
	|-Unsafe.ByteOffset<long>
	|
	|-RVA: 0x255E6C0 Offset: 0x255E7C1 VA: 0x255E6C0
	|-Unsafe.ByteOffset<object>
	|
	|-RVA: 0x255E6D0 Offset: 0x255E7D1 VA: 0x255E6D0
	|-Unsafe.ByteOffset<float>
	|
	|-RVA: 0x255E6E0 Offset: 0x255E7E1 VA: 0x255E6E0
	|-Unsafe.ByteOffset<ushort>
	|
	|-RVA: 0x255E6F0 Offset: 0x255E7F1 VA: 0x255E6F0
	|-Unsafe.ByteOffset<uint>
	|
	|-RVA: 0x255E700 Offset: 0x255E801 VA: 0x255E700
	|-Unsafe.ByteOffset<Bounds>
	|
	|-RVA: 0x255E710 Offset: 0x255E811 VA: 0x255E710
	|-Unsafe.ByteOffset<Color>
	|
	|-RVA: 0x255E720 Offset: 0x255E821 VA: 0x255E720
	|-Unsafe.ByteOffset<Quaternion>
	|
	|-RVA: 0x255E730 Offset: 0x255E831 VA: 0x255E730
	|-Unsafe.ByteOffset<Rect>
	|
	|-RVA: 0x255E740 Offset: 0x255E841 VA: 0x255E740
	|-Unsafe.ByteOffset<Vector2>
	|
	|-RVA: 0x255E750 Offset: 0x255E851 VA: 0x255E750
	|-Unsafe.ByteOffset<Vector3>
	|
	|-RVA: 0x255E760 Offset: 0x255E861 VA: 0x255E760
	|-Unsafe.ByteOffset<Vector4>
	*/

	[NonVersionableAttribute] // RVA: 0x108D90 Offset: 0x108E91 VA: 0x108D90
	// RVA: -1 Offset: -1
	public static bool AreSame<T>(ref T left, ref T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CDE40 Offset: 0x22CDF41 VA: 0x22CDE40
	|-Unsafe.AreSame<byte>
	|
	|-RVA: 0x22CDE50 Offset: 0x22CDF51 VA: 0x22CDE50
	|-Unsafe.AreSame<object>
	*/
}

