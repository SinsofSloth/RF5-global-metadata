[IsReadOnlyAttribute] // RVA: 0x128880 Offset: 0x128981 VA: 0x128880
[ObsoleteAttribute] // RVA: 0x128880 Offset: 0x128981 VA: 0x128880
[DefaultMemberAttribute] // RVA: 0x128880 Offset: 0x128981 VA: 0x128880
[DebuggerTypeProxyAttribute] // RVA: 0x128880 Offset: 0x128981 VA: 0x128880
[DebuggerDisplayAttribute] // RVA: 0x128880 Offset: 0x128981 VA: 0x128880
[IsByRefLikeAttribute] // RVA: 0x128880 Offset: 0x128981 VA: 0x128880
[DebuggerDisplayAttribute] // RVA: 0x128880 Offset: 0x128981 VA: 0x128880
[DebuggerTypeProxyAttribute] // RVA: 0x128880 Offset: 0x128981 VA: 0x128880
public struct ReadOnlySpan<T> // TypeDefIndex: 4381
{
	// Fields
	private readonly Pinnable<T> _pinnable; // 0x0
	private readonly IntPtr _byteOffset; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	[IsReadOnlyAttribute] // RVA: 0x129160 Offset: 0x129261 VA: 0x129160
	public T Item { get; }
	internal Pinnable<T> Pinnable { get; }
	internal IntPtr ByteOffset { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3721E0 Offset: 0x3722E1 VA: 0x3721E0
	|-ReadOnlySpan<byte>.get_Length
	|
	|-RVA: 0x3726E0 Offset: 0x3727E1 VA: 0x3726E0
	|-ReadOnlySpan<char>.get_Length
	|
	|-RVA: 0x364EA0 Offset: 0x364FA1 VA: 0x364EA0
	|-ReadOnlySpan<double>.get_Length
	|
	|-RVA: 0x365350 Offset: 0x365451 VA: 0x365350
	|-ReadOnlySpan<int>.get_Length
	|
	|-RVA: 0x365800 Offset: 0x365901 VA: 0x365800
	|-ReadOnlySpan<long>.get_Length
	|
	|-RVA: 0x365CB0 Offset: 0x365DB1 VA: 0x365CB0
	|-ReadOnlySpan<object>.get_Length
	|
	|-RVA: 0x3661B0 Offset: 0x3662B1 VA: 0x3661B0
	|-ReadOnlySpan<float>.get_Length
	|
	|-RVA: 0x366660 Offset: 0x366761 VA: 0x366660
	|-ReadOnlySpan<ushort>.get_Length
	|
	|-RVA: 0x366B10 Offset: 0x366C11 VA: 0x366B10
	|-ReadOnlySpan<uint>.get_Length
	|
	|-RVA: 0x366FC0 Offset: 0x3670C1 VA: 0x366FC0
	|-ReadOnlySpan<Bounds>.get_Length
	|
	|-RVA: 0x367470 Offset: 0x367571 VA: 0x367470
	|-ReadOnlySpan<Color>.get_Length
	|
	|-RVA: 0x367920 Offset: 0x367A21 VA: 0x367920
	|-ReadOnlySpan<Quaternion>.get_Length
	|
	|-RVA: 0x367DD0 Offset: 0x367ED1 VA: 0x367DD0
	|-ReadOnlySpan<Rect>.get_Length
	|
	|-RVA: 0x368280 Offset: 0x368381 VA: 0x368280
	|-ReadOnlySpan<Vector2>.get_Length
	|
	|-RVA: 0x368730 Offset: 0x368831 VA: 0x368730
	|-ReadOnlySpan<Vector3>.get_Length
	|
	|-RVA: 0x368BE0 Offset: 0x368CE1 VA: 0x368BE0
	|-ReadOnlySpan<Vector4>.get_Length
	*/

	[ObsoleteAttribute] // RVA: 0x128DC0 Offset: 0x128EC1 VA: 0x128DC0
	[EditorBrowsableAttribute] // RVA: 0x128DC0 Offset: 0x128EC1 VA: 0x128DC0
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3721F0 Offset: 0x3722F1 VA: 0x3721F0
	|-ReadOnlySpan<byte>.Equals
	|
	|-RVA: 0x3726F0 Offset: 0x3727F1 VA: 0x3726F0
	|-ReadOnlySpan<char>.Equals
	|
	|-RVA: 0x364EB0 Offset: 0x364FB1 VA: 0x364EB0
	|-ReadOnlySpan<double>.Equals
	|
	|-RVA: 0x365360 Offset: 0x365461 VA: 0x365360
	|-ReadOnlySpan<int>.Equals
	|
	|-RVA: 0x365810 Offset: 0x365911 VA: 0x365810
	|-ReadOnlySpan<long>.Equals
	|
	|-RVA: 0x365CC0 Offset: 0x365DC1 VA: 0x365CC0
	|-ReadOnlySpan<object>.Equals
	|
	|-RVA: 0x3661C0 Offset: 0x3662C1 VA: 0x3661C0
	|-ReadOnlySpan<float>.Equals
	|
	|-RVA: 0x366670 Offset: 0x366771 VA: 0x366670
	|-ReadOnlySpan<ushort>.Equals
	|
	|-RVA: 0x366B20 Offset: 0x366C21 VA: 0x366B20
	|-ReadOnlySpan<uint>.Equals
	|
	|-RVA: 0x366FD0 Offset: 0x3670D1 VA: 0x366FD0
	|-ReadOnlySpan<Bounds>.Equals
	|
	|-RVA: 0x367480 Offset: 0x367581 VA: 0x367480
	|-ReadOnlySpan<Color>.Equals
	|
	|-RVA: 0x367930 Offset: 0x367A31 VA: 0x367930
	|-ReadOnlySpan<Quaternion>.Equals
	|
	|-RVA: 0x367DE0 Offset: 0x367EE1 VA: 0x367DE0
	|-ReadOnlySpan<Rect>.Equals
	|
	|-RVA: 0x368290 Offset: 0x368391 VA: 0x368290
	|-ReadOnlySpan<Vector2>.Equals
	|
	|-RVA: 0x368740 Offset: 0x368841 VA: 0x368740
	|-ReadOnlySpan<Vector3>.Equals
	|
	|-RVA: 0x368BF0 Offset: 0x368CF1 VA: 0x368BF0
	|-ReadOnlySpan<Vector4>.Equals
	*/

	[ObsoleteAttribute] // RVA: 0x128E10 Offset: 0x128F11 VA: 0x128E10
	[EditorBrowsableAttribute] // RVA: 0x128E10 Offset: 0x128F11 VA: 0x128E10
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x372200 Offset: 0x372301 VA: 0x372200
	|-ReadOnlySpan<byte>.GetHashCode
	|
	|-RVA: 0x372700 Offset: 0x372801 VA: 0x372700
	|-ReadOnlySpan<char>.GetHashCode
	|
	|-RVA: 0x364EC0 Offset: 0x364FC1 VA: 0x364EC0
	|-ReadOnlySpan<double>.GetHashCode
	|
	|-RVA: 0x365370 Offset: 0x365471 VA: 0x365370
	|-ReadOnlySpan<int>.GetHashCode
	|
	|-RVA: 0x365820 Offset: 0x365921 VA: 0x365820
	|-ReadOnlySpan<long>.GetHashCode
	|
	|-RVA: 0x365CD0 Offset: 0x365DD1 VA: 0x365CD0
	|-ReadOnlySpan<object>.GetHashCode
	|
	|-RVA: 0x3661D0 Offset: 0x3662D1 VA: 0x3661D0
	|-ReadOnlySpan<float>.GetHashCode
	|
	|-RVA: 0x366680 Offset: 0x366781 VA: 0x366680
	|-ReadOnlySpan<ushort>.GetHashCode
	|
	|-RVA: 0x366B30 Offset: 0x366C31 VA: 0x366B30
	|-ReadOnlySpan<uint>.GetHashCode
	|
	|-RVA: 0x366FE0 Offset: 0x3670E1 VA: 0x366FE0
	|-ReadOnlySpan<Bounds>.GetHashCode
	|
	|-RVA: 0x367490 Offset: 0x367591 VA: 0x367490
	|-ReadOnlySpan<Color>.GetHashCode
	|
	|-RVA: 0x367940 Offset: 0x367A41 VA: 0x367940
	|-ReadOnlySpan<Quaternion>.GetHashCode
	|
	|-RVA: 0x367DF0 Offset: 0x367EF1 VA: 0x367DF0
	|-ReadOnlySpan<Rect>.GetHashCode
	|
	|-RVA: 0x3682A0 Offset: 0x3683A1 VA: 0x3682A0
	|-ReadOnlySpan<Vector2>.GetHashCode
	|
	|-RVA: 0x368750 Offset: 0x368851 VA: 0x368750
	|-ReadOnlySpan<Vector3>.GetHashCode
	|
	|-RVA: 0x368C00 Offset: 0x368D01 VA: 0x368C00
	|-ReadOnlySpan<Vector4>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2954CA0 Offset: 0x2954DA1 VA: 0x2954CA0
	|-ReadOnlySpan<byte>.op_Implicit
	|
	|-RVA: 0x29566E0 Offset: 0x29567E1 VA: 0x29566E0
	|-ReadOnlySpan<char>.op_Implicit
	|
	|-RVA: 0x26CE7C0 Offset: 0x26CE8C1 VA: 0x26CE7C0
	|-ReadOnlySpan<double>.op_Implicit
	|
	|-RVA: 0x26CFE00 Offset: 0x26CFF01 VA: 0x26CFE00
	|-ReadOnlySpan<int>.op_Implicit
	|
	|-RVA: 0x26D1440 Offset: 0x26D1541 VA: 0x26D1440
	|-ReadOnlySpan<long>.op_Implicit
	|
	|-RVA: 0x26D2A80 Offset: 0x26D2B81 VA: 0x26D2A80
	|-ReadOnlySpan<object>.op_Implicit
	|
	|-RVA: 0x26D44C0 Offset: 0x26D45C1 VA: 0x26D44C0
	|-ReadOnlySpan<float>.op_Implicit
	|
	|-RVA: 0x26D5B00 Offset: 0x26D5C01 VA: 0x26D5B00
	|-ReadOnlySpan<ushort>.op_Implicit
	|
	|-RVA: 0x26D7140 Offset: 0x26D7241 VA: 0x26D7140
	|-ReadOnlySpan<uint>.op_Implicit
	|
	|-RVA: 0x26D8780 Offset: 0x26D8881 VA: 0x26D8780
	|-ReadOnlySpan<Bounds>.op_Implicit
	|
	|-RVA: 0x26D9DC0 Offset: 0x26D9EC1 VA: 0x26D9DC0
	|-ReadOnlySpan<Color>.op_Implicit
	|
	|-RVA: 0x26DB400 Offset: 0x26DB501 VA: 0x26DB400
	|-ReadOnlySpan<Quaternion>.op_Implicit
	|
	|-RVA: 0x26DCA40 Offset: 0x26DCB41 VA: 0x26DCA40
	|-ReadOnlySpan<Rect>.op_Implicit
	|
	|-RVA: 0x26DE080 Offset: 0x26DE181 VA: 0x26DE080
	|-ReadOnlySpan<Vector2>.op_Implicit
	|
	|-RVA: 0x26DF6C0 Offset: 0x26DF7C1 VA: 0x26DF6C0
	|-ReadOnlySpan<Vector3>.op_Implicit
	|
	|-RVA: 0x26E0D00 Offset: 0x26E0E01 VA: 0x26E0D00
	|-ReadOnlySpan<Vector4>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> op_Implicit(ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2954D10 Offset: 0x2954E11 VA: 0x2954D10
	|-ReadOnlySpan<byte>.op_Implicit
	|
	|-RVA: 0x2956750 Offset: 0x2956851 VA: 0x2956750
	|-ReadOnlySpan<char>.op_Implicit
	|
	|-RVA: 0x26CE830 Offset: 0x26CE931 VA: 0x26CE830
	|-ReadOnlySpan<double>.op_Implicit
	|
	|-RVA: 0x26CFE70 Offset: 0x26CFF71 VA: 0x26CFE70
	|-ReadOnlySpan<int>.op_Implicit
	|
	|-RVA: 0x26D14B0 Offset: 0x26D15B1 VA: 0x26D14B0
	|-ReadOnlySpan<long>.op_Implicit
	|
	|-RVA: 0x26D2AF0 Offset: 0x26D2BF1 VA: 0x26D2AF0
	|-ReadOnlySpan<object>.op_Implicit
	|
	|-RVA: 0x26D4530 Offset: 0x26D4631 VA: 0x26D4530
	|-ReadOnlySpan<float>.op_Implicit
	|
	|-RVA: 0x26D5B70 Offset: 0x26D5C71 VA: 0x26D5B70
	|-ReadOnlySpan<ushort>.op_Implicit
	|
	|-RVA: 0x26D71B0 Offset: 0x26D72B1 VA: 0x26D71B0
	|-ReadOnlySpan<uint>.op_Implicit
	|
	|-RVA: 0x26D87F0 Offset: 0x26D88F1 VA: 0x26D87F0
	|-ReadOnlySpan<Bounds>.op_Implicit
	|
	|-RVA: 0x26D9E30 Offset: 0x26D9F31 VA: 0x26D9E30
	|-ReadOnlySpan<Color>.op_Implicit
	|
	|-RVA: 0x26DB470 Offset: 0x26DB571 VA: 0x26DB470
	|-ReadOnlySpan<Quaternion>.op_Implicit
	|
	|-RVA: 0x26DCAB0 Offset: 0x26DCBB1 VA: 0x26DCAB0
	|-ReadOnlySpan<Rect>.op_Implicit
	|
	|-RVA: 0x26DE0F0 Offset: 0x26DE1F1 VA: 0x26DE0F0
	|-ReadOnlySpan<Vector2>.op_Implicit
	|
	|-RVA: 0x26DF730 Offset: 0x26DF831 VA: 0x26DF730
	|-ReadOnlySpan<Vector3>.op_Implicit
	|
	|-RVA: 0x26E0D70 Offset: 0x26E0E71 VA: 0x26E0D70
	|-ReadOnlySpan<Vector4>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x372210 Offset: 0x372311 VA: 0x372210
	|-ReadOnlySpan<byte>..ctor
	|
	|-RVA: 0x372710 Offset: 0x372811 VA: 0x372710
	|-ReadOnlySpan<char>..ctor
	|
	|-RVA: 0x364ED0 Offset: 0x364FD1 VA: 0x364ED0
	|-ReadOnlySpan<double>..ctor
	|
	|-RVA: 0x365380 Offset: 0x365481 VA: 0x365380
	|-ReadOnlySpan<int>..ctor
	|
	|-RVA: 0x365830 Offset: 0x365931 VA: 0x365830
	|-ReadOnlySpan<long>..ctor
	|
	|-RVA: 0x365CE0 Offset: 0x365DE1 VA: 0x365CE0
	|-ReadOnlySpan<object>..ctor
	|
	|-RVA: 0x3661E0 Offset: 0x3662E1 VA: 0x3661E0
	|-ReadOnlySpan<float>..ctor
	|
	|-RVA: 0x366690 Offset: 0x366791 VA: 0x366690
	|-ReadOnlySpan<ushort>..ctor
	|
	|-RVA: 0x366B40 Offset: 0x366C41 VA: 0x366B40
	|-ReadOnlySpan<uint>..ctor
	|
	|-RVA: 0x366FF0 Offset: 0x3670F1 VA: 0x366FF0
	|-ReadOnlySpan<Bounds>..ctor
	|
	|-RVA: 0x3674A0 Offset: 0x3675A1 VA: 0x3674A0
	|-ReadOnlySpan<Color>..ctor
	|
	|-RVA: 0x367950 Offset: 0x367A51 VA: 0x367950
	|-ReadOnlySpan<Quaternion>..ctor
	|
	|-RVA: 0x367E00 Offset: 0x367F01 VA: 0x367E00
	|-ReadOnlySpan<Rect>..ctor
	|
	|-RVA: 0x3682B0 Offset: 0x3683B1 VA: 0x3682B0
	|-ReadOnlySpan<Vector2>..ctor
	|
	|-RVA: 0x368760 Offset: 0x368861 VA: 0x368760
	|-ReadOnlySpan<Vector3>..ctor
	|
	|-RVA: 0x368C10 Offset: 0x368D11 VA: 0x368C10
	|-ReadOnlySpan<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x372220 Offset: 0x372321 VA: 0x372220
	|-ReadOnlySpan<byte>..ctor
	|
	|-RVA: 0x372720 Offset: 0x372821 VA: 0x372720
	|-ReadOnlySpan<char>..ctor
	|
	|-RVA: 0x364EE0 Offset: 0x364FE1 VA: 0x364EE0
	|-ReadOnlySpan<double>..ctor
	|
	|-RVA: 0x365390 Offset: 0x365491 VA: 0x365390
	|-ReadOnlySpan<int>..ctor
	|
	|-RVA: 0x365840 Offset: 0x365941 VA: 0x365840
	|-ReadOnlySpan<long>..ctor
	|
	|-RVA: 0x365CF0 Offset: 0x365DF1 VA: 0x365CF0
	|-ReadOnlySpan<object>..ctor
	|
	|-RVA: 0x3661F0 Offset: 0x3662F1 VA: 0x3661F0
	|-ReadOnlySpan<float>..ctor
	|
	|-RVA: 0x3666A0 Offset: 0x3667A1 VA: 0x3666A0
	|-ReadOnlySpan<ushort>..ctor
	|
	|-RVA: 0x366B50 Offset: 0x366C51 VA: 0x366B50
	|-ReadOnlySpan<uint>..ctor
	|
	|-RVA: 0x367000 Offset: 0x367101 VA: 0x367000
	|-ReadOnlySpan<Bounds>..ctor
	|
	|-RVA: 0x3674B0 Offset: 0x3675B1 VA: 0x3674B0
	|-ReadOnlySpan<Color>..ctor
	|
	|-RVA: 0x367960 Offset: 0x367A61 VA: 0x367960
	|-ReadOnlySpan<Quaternion>..ctor
	|
	|-RVA: 0x367E10 Offset: 0x367F11 VA: 0x367E10
	|-ReadOnlySpan<Rect>..ctor
	|
	|-RVA: 0x3682C0 Offset: 0x3683C1 VA: 0x3682C0
	|-ReadOnlySpan<Vector2>..ctor
	|
	|-RVA: 0x368770 Offset: 0x368871 VA: 0x368770
	|-ReadOnlySpan<Vector3>..ctor
	|
	|-RVA: 0x368C20 Offset: 0x368D21 VA: 0x368C20
	|-ReadOnlySpan<Vector4>..ctor
	*/

	[CLSCompliantAttribute] // RVA: 0x128E60 Offset: 0x128F61 VA: 0x128E60
	// RVA: -1 Offset: -1
	public void .ctor(void* pointer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x372230 Offset: 0x372331 VA: 0x372230
	|-ReadOnlySpan<byte>..ctor
	|
	|-RVA: 0x372730 Offset: 0x372831 VA: 0x372730
	|-ReadOnlySpan<char>..ctor
	|
	|-RVA: 0x364EF0 Offset: 0x364FF1 VA: 0x364EF0
	|-ReadOnlySpan<double>..ctor
	|
	|-RVA: 0x3653A0 Offset: 0x3654A1 VA: 0x3653A0
	|-ReadOnlySpan<int>..ctor
	|
	|-RVA: 0x365850 Offset: 0x365951 VA: 0x365850
	|-ReadOnlySpan<long>..ctor
	|
	|-RVA: 0x365D00 Offset: 0x365E01 VA: 0x365D00
	|-ReadOnlySpan<object>..ctor
	|
	|-RVA: 0x366200 Offset: 0x366301 VA: 0x366200
	|-ReadOnlySpan<float>..ctor
	|
	|-RVA: 0x3666B0 Offset: 0x3667B1 VA: 0x3666B0
	|-ReadOnlySpan<ushort>..ctor
	|
	|-RVA: 0x366B60 Offset: 0x366C61 VA: 0x366B60
	|-ReadOnlySpan<uint>..ctor
	|
	|-RVA: 0x367010 Offset: 0x367111 VA: 0x367010
	|-ReadOnlySpan<Bounds>..ctor
	|
	|-RVA: 0x3674C0 Offset: 0x3675C1 VA: 0x3674C0
	|-ReadOnlySpan<Color>..ctor
	|
	|-RVA: 0x367970 Offset: 0x367A71 VA: 0x367970
	|-ReadOnlySpan<Quaternion>..ctor
	|
	|-RVA: 0x367E20 Offset: 0x367F21 VA: 0x367E20
	|-ReadOnlySpan<Rect>..ctor
	|
	|-RVA: 0x3682D0 Offset: 0x3683D1 VA: 0x3682D0
	|-ReadOnlySpan<Vector2>..ctor
	|
	|-RVA: 0x368780 Offset: 0x368881 VA: 0x368780
	|-ReadOnlySpan<Vector3>..ctor
	|
	|-RVA: 0x368C30 Offset: 0x368D31 VA: 0x368C30
	|-ReadOnlySpan<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Pinnable<T> pinnable, IntPtr byteOffset, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x372240 Offset: 0x372341 VA: 0x372240
	|-ReadOnlySpan<byte>..ctor
	|
	|-RVA: 0x372740 Offset: 0x372841 VA: 0x372740
	|-ReadOnlySpan<char>..ctor
	|
	|-RVA: 0x364F00 Offset: 0x365001 VA: 0x364F00
	|-ReadOnlySpan<double>..ctor
	|
	|-RVA: 0x3653B0 Offset: 0x3654B1 VA: 0x3653B0
	|-ReadOnlySpan<int>..ctor
	|
	|-RVA: 0x365860 Offset: 0x365961 VA: 0x365860
	|-ReadOnlySpan<long>..ctor
	|
	|-RVA: 0x365D10 Offset: 0x365E11 VA: 0x365D10
	|-ReadOnlySpan<object>..ctor
	|
	|-RVA: 0x366210 Offset: 0x366311 VA: 0x366210
	|-ReadOnlySpan<float>..ctor
	|
	|-RVA: 0x3666C0 Offset: 0x3667C1 VA: 0x3666C0
	|-ReadOnlySpan<ushort>..ctor
	|
	|-RVA: 0x366B70 Offset: 0x366C71 VA: 0x366B70
	|-ReadOnlySpan<uint>..ctor
	|
	|-RVA: 0x367020 Offset: 0x367121 VA: 0x367020
	|-ReadOnlySpan<Bounds>..ctor
	|
	|-RVA: 0x3674D0 Offset: 0x3675D1 VA: 0x3674D0
	|-ReadOnlySpan<Color>..ctor
	|
	|-RVA: 0x367980 Offset: 0x367A81 VA: 0x367980
	|-ReadOnlySpan<Quaternion>..ctor
	|
	|-RVA: 0x367E30 Offset: 0x367F31 VA: 0x367E30
	|-ReadOnlySpan<Rect>..ctor
	|
	|-RVA: 0x3682E0 Offset: 0x3683E1 VA: 0x3682E0
	|-ReadOnlySpan<Vector2>..ctor
	|
	|-RVA: 0x368790 Offset: 0x368891 VA: 0x368790
	|-ReadOnlySpan<Vector3>..ctor
	|
	|-RVA: 0x368C40 Offset: 0x368D41 VA: 0x368C40
	|-ReadOnlySpan<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3658A0 Offset: 0x3659A1 VA: 0x3658A0
	|-ReadOnlySpan<long>.get_Item
	|
	|-RVA: 0x366700 Offset: 0x366801 VA: 0x366700
	|-ReadOnlySpan<ushort>.get_Item
	|
	|-RVA: 0x366BB0 Offset: 0x366CB1 VA: 0x366BB0
	|-ReadOnlySpan<uint>.get_Item
	|
	|-RVA: 0x372280 Offset: 0x372381 VA: 0x372280
	|-ReadOnlySpan<byte>.get_Item
	|
	|-RVA: 0x372780 Offset: 0x372881 VA: 0x372780
	|-ReadOnlySpan<char>.get_Item
	|
	|-RVA: 0x364F40 Offset: 0x365041 VA: 0x364F40
	|-ReadOnlySpan<double>.get_Item
	|
	|-RVA: 0x3653F0 Offset: 0x3654F1 VA: 0x3653F0
	|-ReadOnlySpan<int>.get_Item
	|
	|-RVA: 0x365D50 Offset: 0x365E51 VA: 0x365D50
	|-ReadOnlySpan<object>.get_Item
	|
	|-RVA: 0x366250 Offset: 0x366351 VA: 0x366250
	|-ReadOnlySpan<float>.get_Item
	|
	|-RVA: 0x367060 Offset: 0x367161 VA: 0x367060
	|-ReadOnlySpan<Bounds>.get_Item
	|
	|-RVA: 0x367510 Offset: 0x367611 VA: 0x367510
	|-ReadOnlySpan<Color>.get_Item
	|
	|-RVA: 0x3679C0 Offset: 0x367AC1 VA: 0x3679C0
	|-ReadOnlySpan<Quaternion>.get_Item
	|
	|-RVA: 0x367E70 Offset: 0x367F71 VA: 0x367E70
	|-ReadOnlySpan<Rect>.get_Item
	|
	|-RVA: 0x368320 Offset: 0x368421 VA: 0x368320
	|-ReadOnlySpan<Vector2>.get_Item
	|
	|-RVA: 0x3687D0 Offset: 0x3688D1 VA: 0x3687D0
	|-ReadOnlySpan<Vector3>.get_Item
	|
	|-RVA: 0x368C80 Offset: 0x368D81 VA: 0x368C80
	|-ReadOnlySpan<Vector4>.get_Item
	*/

	[EditorBrowsableAttribute] // RVA: 0x128E80 Offset: 0x128F81 VA: 0x128E80
	// RVA: -1 Offset: -1
	public ref T GetPinnableReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x372290 Offset: 0x372391 VA: 0x372290
	|-ReadOnlySpan<byte>.GetPinnableReference
	|
	|-RVA: 0x372790 Offset: 0x372891 VA: 0x372790
	|-ReadOnlySpan<char>.GetPinnableReference
	|
	|-RVA: 0x364F50 Offset: 0x365051 VA: 0x364F50
	|-ReadOnlySpan<double>.GetPinnableReference
	|
	|-RVA: 0x365400 Offset: 0x365501 VA: 0x365400
	|-ReadOnlySpan<int>.GetPinnableReference
	|
	|-RVA: 0x3658B0 Offset: 0x3659B1 VA: 0x3658B0
	|-ReadOnlySpan<long>.GetPinnableReference
	|
	|-RVA: 0x365D60 Offset: 0x365E61 VA: 0x365D60
	|-ReadOnlySpan<object>.GetPinnableReference
	|
	|-RVA: 0x366260 Offset: 0x366361 VA: 0x366260
	|-ReadOnlySpan<float>.GetPinnableReference
	|
	|-RVA: 0x366710 Offset: 0x366811 VA: 0x366710
	|-ReadOnlySpan<ushort>.GetPinnableReference
	|
	|-RVA: 0x366BC0 Offset: 0x366CC1 VA: 0x366BC0
	|-ReadOnlySpan<uint>.GetPinnableReference
	|
	|-RVA: 0x367070 Offset: 0x367171 VA: 0x367070
	|-ReadOnlySpan<Bounds>.GetPinnableReference
	|
	|-RVA: 0x367520 Offset: 0x367621 VA: 0x367520
	|-ReadOnlySpan<Color>.GetPinnableReference
	|
	|-RVA: 0x3679D0 Offset: 0x367AD1 VA: 0x3679D0
	|-ReadOnlySpan<Quaternion>.GetPinnableReference
	|
	|-RVA: 0x367E80 Offset: 0x367F81 VA: 0x367E80
	|-ReadOnlySpan<Rect>.GetPinnableReference
	|
	|-RVA: 0x368330 Offset: 0x368431 VA: 0x368330
	|-ReadOnlySpan<Vector2>.GetPinnableReference
	|
	|-RVA: 0x3687E0 Offset: 0x3688E1 VA: 0x3687E0
	|-ReadOnlySpan<Vector3>.GetPinnableReference
	|
	|-RVA: 0x368C90 Offset: 0x368D91 VA: 0x368C90
	|-ReadOnlySpan<Vector4>.GetPinnableReference
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3722A0 Offset: 0x3723A1 VA: 0x3722A0
	|-ReadOnlySpan<byte>.CopyTo
	|
	|-RVA: 0x3727A0 Offset: 0x3728A1 VA: 0x3727A0
	|-ReadOnlySpan<char>.CopyTo
	|
	|-RVA: 0x364F60 Offset: 0x365061 VA: 0x364F60
	|-ReadOnlySpan<double>.CopyTo
	|
	|-RVA: 0x365410 Offset: 0x365511 VA: 0x365410
	|-ReadOnlySpan<int>.CopyTo
	|
	|-RVA: 0x3658C0 Offset: 0x3659C1 VA: 0x3658C0
	|-ReadOnlySpan<long>.CopyTo
	|
	|-RVA: 0x365D70 Offset: 0x365E71 VA: 0x365D70
	|-ReadOnlySpan<object>.CopyTo
	|
	|-RVA: 0x366270 Offset: 0x366371 VA: 0x366270
	|-ReadOnlySpan<float>.CopyTo
	|
	|-RVA: 0x366720 Offset: 0x366821 VA: 0x366720
	|-ReadOnlySpan<ushort>.CopyTo
	|
	|-RVA: 0x366BD0 Offset: 0x366CD1 VA: 0x366BD0
	|-ReadOnlySpan<uint>.CopyTo
	|
	|-RVA: 0x367080 Offset: 0x367181 VA: 0x367080
	|-ReadOnlySpan<Bounds>.CopyTo
	|
	|-RVA: 0x367530 Offset: 0x367631 VA: 0x367530
	|-ReadOnlySpan<Color>.CopyTo
	|
	|-RVA: 0x3679E0 Offset: 0x367AE1 VA: 0x3679E0
	|-ReadOnlySpan<Quaternion>.CopyTo
	|
	|-RVA: 0x367E90 Offset: 0x367F91 VA: 0x367E90
	|-ReadOnlySpan<Rect>.CopyTo
	|
	|-RVA: 0x368340 Offset: 0x368441 VA: 0x368340
	|-ReadOnlySpan<Vector2>.CopyTo
	|
	|-RVA: 0x3687F0 Offset: 0x3688F1 VA: 0x3687F0
	|-ReadOnlySpan<Vector3>.CopyTo
	|
	|-RVA: 0x368CA0 Offset: 0x368DA1 VA: 0x368CA0
	|-ReadOnlySpan<Vector4>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public bool TryCopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x372320 Offset: 0x372421 VA: 0x372320
	|-ReadOnlySpan<byte>.TryCopyTo
	|
	|-RVA: 0x372820 Offset: 0x372921 VA: 0x372820
	|-ReadOnlySpan<char>.TryCopyTo
	|
	|-RVA: 0x364FE0 Offset: 0x3650E1 VA: 0x364FE0
	|-ReadOnlySpan<double>.TryCopyTo
	|
	|-RVA: 0x365490 Offset: 0x365591 VA: 0x365490
	|-ReadOnlySpan<int>.TryCopyTo
	|
	|-RVA: 0x365940 Offset: 0x365A41 VA: 0x365940
	|-ReadOnlySpan<long>.TryCopyTo
	|
	|-RVA: 0x365DF0 Offset: 0x365EF1 VA: 0x365DF0
	|-ReadOnlySpan<object>.TryCopyTo
	|
	|-RVA: 0x3662F0 Offset: 0x3663F1 VA: 0x3662F0
	|-ReadOnlySpan<float>.TryCopyTo
	|
	|-RVA: 0x3667A0 Offset: 0x3668A1 VA: 0x3667A0
	|-ReadOnlySpan<ushort>.TryCopyTo
	|
	|-RVA: 0x366C50 Offset: 0x366D51 VA: 0x366C50
	|-ReadOnlySpan<uint>.TryCopyTo
	|
	|-RVA: 0x367100 Offset: 0x367201 VA: 0x367100
	|-ReadOnlySpan<Bounds>.TryCopyTo
	|
	|-RVA: 0x3675B0 Offset: 0x3676B1 VA: 0x3675B0
	|-ReadOnlySpan<Color>.TryCopyTo
	|
	|-RVA: 0x367A60 Offset: 0x367B61 VA: 0x367A60
	|-ReadOnlySpan<Quaternion>.TryCopyTo
	|
	|-RVA: 0x367F10 Offset: 0x368011 VA: 0x367F10
	|-ReadOnlySpan<Rect>.TryCopyTo
	|
	|-RVA: 0x3683C0 Offset: 0x3684C1 VA: 0x3683C0
	|-ReadOnlySpan<Vector2>.TryCopyTo
	|
	|-RVA: 0x368870 Offset: 0x368971 VA: 0x368870
	|-ReadOnlySpan<Vector3>.TryCopyTo
	|
	|-RVA: 0x368D20 Offset: 0x368E21 VA: 0x368D20
	|-ReadOnlySpan<Vector4>.TryCopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x372360 Offset: 0x372461 VA: 0x372360
	|-ReadOnlySpan<byte>.ToString
	|
	|-RVA: 0x372860 Offset: 0x372961 VA: 0x372860
	|-ReadOnlySpan<char>.ToString
	|
	|-RVA: 0x365020 Offset: 0x365121 VA: 0x365020
	|-ReadOnlySpan<double>.ToString
	|
	|-RVA: 0x3654D0 Offset: 0x3655D1 VA: 0x3654D0
	|-ReadOnlySpan<int>.ToString
	|
	|-RVA: 0x365980 Offset: 0x365A81 VA: 0x365980
	|-ReadOnlySpan<long>.ToString
	|
	|-RVA: 0x365E30 Offset: 0x365F31 VA: 0x365E30
	|-ReadOnlySpan<object>.ToString
	|
	|-RVA: 0x366330 Offset: 0x366431 VA: 0x366330
	|-ReadOnlySpan<float>.ToString
	|
	|-RVA: 0x3667E0 Offset: 0x3668E1 VA: 0x3667E0
	|-ReadOnlySpan<ushort>.ToString
	|
	|-RVA: 0x366C90 Offset: 0x366D91 VA: 0x366C90
	|-ReadOnlySpan<uint>.ToString
	|
	|-RVA: 0x367140 Offset: 0x367241 VA: 0x367140
	|-ReadOnlySpan<Bounds>.ToString
	|
	|-RVA: 0x3675F0 Offset: 0x3676F1 VA: 0x3675F0
	|-ReadOnlySpan<Color>.ToString
	|
	|-RVA: 0x367AA0 Offset: 0x367BA1 VA: 0x367AA0
	|-ReadOnlySpan<Quaternion>.ToString
	|
	|-RVA: 0x367F50 Offset: 0x368051 VA: 0x367F50
	|-ReadOnlySpan<Rect>.ToString
	|
	|-RVA: 0x368400 Offset: 0x368501 VA: 0x368400
	|-ReadOnlySpan<Vector2>.ToString
	|
	|-RVA: 0x3688B0 Offset: 0x3689B1 VA: 0x3688B0
	|-ReadOnlySpan<Vector3>.ToString
	|
	|-RVA: 0x368D60 Offset: 0x368E61 VA: 0x368D60
	|-ReadOnlySpan<Vector4>.ToString
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> Slice(int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x372370 Offset: 0x372471 VA: 0x372370
	|-ReadOnlySpan<byte>.Slice
	|
	|-RVA: 0x372870 Offset: 0x372971 VA: 0x372870
	|-ReadOnlySpan<char>.Slice
	|
	|-RVA: 0x365030 Offset: 0x365131 VA: 0x365030
	|-ReadOnlySpan<double>.Slice
	|
	|-RVA: 0x3654E0 Offset: 0x3655E1 VA: 0x3654E0
	|-ReadOnlySpan<int>.Slice
	|
	|-RVA: 0x365990 Offset: 0x365A91 VA: 0x365990
	|-ReadOnlySpan<long>.Slice
	|
	|-RVA: 0x365E40 Offset: 0x365F41 VA: 0x365E40
	|-ReadOnlySpan<object>.Slice
	|
	|-RVA: 0x366340 Offset: 0x366441 VA: 0x366340
	|-ReadOnlySpan<float>.Slice
	|
	|-RVA: 0x3667F0 Offset: 0x3668F1 VA: 0x3667F0
	|-ReadOnlySpan<ushort>.Slice
	|
	|-RVA: 0x366CA0 Offset: 0x366DA1 VA: 0x366CA0
	|-ReadOnlySpan<uint>.Slice
	|
	|-RVA: 0x367150 Offset: 0x367251 VA: 0x367150
	|-ReadOnlySpan<Bounds>.Slice
	|
	|-RVA: 0x367600 Offset: 0x367701 VA: 0x367600
	|-ReadOnlySpan<Color>.Slice
	|
	|-RVA: 0x367AB0 Offset: 0x367BB1 VA: 0x367AB0
	|-ReadOnlySpan<Quaternion>.Slice
	|
	|-RVA: 0x367F60 Offset: 0x368061 VA: 0x367F60
	|-ReadOnlySpan<Rect>.Slice
	|
	|-RVA: 0x368410 Offset: 0x368511 VA: 0x368410
	|-ReadOnlySpan<Vector2>.Slice
	|
	|-RVA: 0x3688C0 Offset: 0x3689C1 VA: 0x3688C0
	|-ReadOnlySpan<Vector3>.Slice
	|
	|-RVA: 0x368D70 Offset: 0x368E71 VA: 0x368D70
	|-ReadOnlySpan<Vector4>.Slice
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x372470 Offset: 0x372571 VA: 0x372470
	|-ReadOnlySpan<byte>.Slice
	|
	|-RVA: 0x372970 Offset: 0x372A71 VA: 0x372970
	|-ReadOnlySpan<char>.Slice
	|
	|-RVA: 0x365130 Offset: 0x365231 VA: 0x365130
	|-ReadOnlySpan<double>.Slice
	|
	|-RVA: 0x3655E0 Offset: 0x3656E1 VA: 0x3655E0
	|-ReadOnlySpan<int>.Slice
	|
	|-RVA: 0x365A90 Offset: 0x365B91 VA: 0x365A90
	|-ReadOnlySpan<long>.Slice
	|
	|-RVA: 0x365F40 Offset: 0x366041 VA: 0x365F40
	|-ReadOnlySpan<object>.Slice
	|
	|-RVA: 0x366440 Offset: 0x366541 VA: 0x366440
	|-ReadOnlySpan<float>.Slice
	|
	|-RVA: 0x3668F0 Offset: 0x3669F1 VA: 0x3668F0
	|-ReadOnlySpan<ushort>.Slice
	|
	|-RVA: 0x366DA0 Offset: 0x366EA1 VA: 0x366DA0
	|-ReadOnlySpan<uint>.Slice
	|
	|-RVA: 0x367250 Offset: 0x367351 VA: 0x367250
	|-ReadOnlySpan<Bounds>.Slice
	|
	|-RVA: 0x367700 Offset: 0x367801 VA: 0x367700
	|-ReadOnlySpan<Color>.Slice
	|
	|-RVA: 0x367BB0 Offset: 0x367CB1 VA: 0x367BB0
	|-ReadOnlySpan<Quaternion>.Slice
	|
	|-RVA: 0x368060 Offset: 0x368161 VA: 0x368060
	|-ReadOnlySpan<Rect>.Slice
	|
	|-RVA: 0x368510 Offset: 0x368611 VA: 0x368510
	|-ReadOnlySpan<Vector2>.Slice
	|
	|-RVA: 0x3689C0 Offset: 0x368AC1 VA: 0x3689C0
	|-ReadOnlySpan<Vector3>.Slice
	|
	|-RVA: 0x368E70 Offset: 0x368F71 VA: 0x368E70
	|-ReadOnlySpan<Vector4>.Slice
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x372570 Offset: 0x372671 VA: 0x372570
	|-ReadOnlySpan<byte>.ToArray
	|
	|-RVA: 0x372A70 Offset: 0x372B71 VA: 0x372A70
	|-ReadOnlySpan<char>.ToArray
	|
	|-RVA: 0x365230 Offset: 0x365331 VA: 0x365230
	|-ReadOnlySpan<double>.ToArray
	|
	|-RVA: 0x3656E0 Offset: 0x3657E1 VA: 0x3656E0
	|-ReadOnlySpan<int>.ToArray
	|
	|-RVA: 0x365B90 Offset: 0x365C91 VA: 0x365B90
	|-ReadOnlySpan<long>.ToArray
	|
	|-RVA: 0x366040 Offset: 0x366141 VA: 0x366040
	|-ReadOnlySpan<object>.ToArray
	|
	|-RVA: 0x366540 Offset: 0x366641 VA: 0x366540
	|-ReadOnlySpan<float>.ToArray
	|
	|-RVA: 0x3669F0 Offset: 0x366AF1 VA: 0x3669F0
	|-ReadOnlySpan<ushort>.ToArray
	|
	|-RVA: 0x366EA0 Offset: 0x366FA1 VA: 0x366EA0
	|-ReadOnlySpan<uint>.ToArray
	|
	|-RVA: 0x367350 Offset: 0x367451 VA: 0x367350
	|-ReadOnlySpan<Bounds>.ToArray
	|
	|-RVA: 0x367800 Offset: 0x367901 VA: 0x367800
	|-ReadOnlySpan<Color>.ToArray
	|
	|-RVA: 0x367CB0 Offset: 0x367DB1 VA: 0x367CB0
	|-ReadOnlySpan<Quaternion>.ToArray
	|
	|-RVA: 0x368160 Offset: 0x368261 VA: 0x368160
	|-ReadOnlySpan<Rect>.ToArray
	|
	|-RVA: 0x368610 Offset: 0x368711 VA: 0x368610
	|-ReadOnlySpan<Vector2>.ToArray
	|
	|-RVA: 0x368AC0 Offset: 0x368BC1 VA: 0x368AC0
	|-ReadOnlySpan<Vector3>.ToArray
	|
	|-RVA: 0x368F70 Offset: 0x369071 VA: 0x368F70
	|-ReadOnlySpan<Vector4>.ToArray
	*/

	[EditorBrowsableAttribute] // RVA: 0x128EA0 Offset: 0x128FA1 VA: 0x128EA0
	// RVA: -1 Offset: -1
	internal ref T DangerousGetPinnableReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x372580 Offset: 0x372681 VA: 0x372580
	|-ReadOnlySpan<byte>.DangerousGetPinnableReference
	|
	|-RVA: 0x372A80 Offset: 0x372B81 VA: 0x372A80
	|-ReadOnlySpan<char>.DangerousGetPinnableReference
	|
	|-RVA: 0x365240 Offset: 0x365341 VA: 0x365240
	|-ReadOnlySpan<double>.DangerousGetPinnableReference
	|
	|-RVA: 0x3656F0 Offset: 0x3657F1 VA: 0x3656F0
	|-ReadOnlySpan<int>.DangerousGetPinnableReference
	|
	|-RVA: 0x365BA0 Offset: 0x365CA1 VA: 0x365BA0
	|-ReadOnlySpan<long>.DangerousGetPinnableReference
	|
	|-RVA: 0x366050 Offset: 0x366151 VA: 0x366050
	|-ReadOnlySpan<object>.DangerousGetPinnableReference
	|
	|-RVA: 0x366550 Offset: 0x366651 VA: 0x366550
	|-ReadOnlySpan<float>.DangerousGetPinnableReference
	|
	|-RVA: 0x366A00 Offset: 0x366B01 VA: 0x366A00
	|-ReadOnlySpan<ushort>.DangerousGetPinnableReference
	|
	|-RVA: 0x366EB0 Offset: 0x366FB1 VA: 0x366EB0
	|-ReadOnlySpan<uint>.DangerousGetPinnableReference
	|
	|-RVA: 0x367360 Offset: 0x367461 VA: 0x367360
	|-ReadOnlySpan<Bounds>.DangerousGetPinnableReference
	|
	|-RVA: 0x367810 Offset: 0x367911 VA: 0x367810
	|-ReadOnlySpan<Color>.DangerousGetPinnableReference
	|
	|-RVA: 0x367CC0 Offset: 0x367DC1 VA: 0x367CC0
	|-ReadOnlySpan<Quaternion>.DangerousGetPinnableReference
	|
	|-RVA: 0x368170 Offset: 0x368271 VA: 0x368170
	|-ReadOnlySpan<Rect>.DangerousGetPinnableReference
	|
	|-RVA: 0x368620 Offset: 0x368721 VA: 0x368620
	|-ReadOnlySpan<Vector2>.DangerousGetPinnableReference
	|
	|-RVA: 0x368AD0 Offset: 0x368BD1 VA: 0x368AD0
	|-ReadOnlySpan<Vector3>.DangerousGetPinnableReference
	|
	|-RVA: 0x368F80 Offset: 0x369081 VA: 0x368F80
	|-ReadOnlySpan<Vector4>.DangerousGetPinnableReference
	*/

	// RVA: -1 Offset: -1
	internal Pinnable<T> get_Pinnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x372670 Offset: 0x372771 VA: 0x372670
	|-ReadOnlySpan<byte>.get_Pinnable
	|
	|-RVA: 0x372B70 Offset: 0x372C71 VA: 0x372B70
	|-ReadOnlySpan<char>.get_Pinnable
	|
	|-RVA: 0x365330 Offset: 0x365431 VA: 0x365330
	|-ReadOnlySpan<double>.get_Pinnable
	|
	|-RVA: 0x3657E0 Offset: 0x3658E1 VA: 0x3657E0
	|-ReadOnlySpan<int>.get_Pinnable
	|
	|-RVA: 0x365C90 Offset: 0x365D91 VA: 0x365C90
	|-ReadOnlySpan<long>.get_Pinnable
	|
	|-RVA: 0x366140 Offset: 0x366241 VA: 0x366140
	|-ReadOnlySpan<object>.get_Pinnable
	|
	|-RVA: 0x366640 Offset: 0x366741 VA: 0x366640
	|-ReadOnlySpan<float>.get_Pinnable
	|
	|-RVA: 0x366AF0 Offset: 0x366BF1 VA: 0x366AF0
	|-ReadOnlySpan<ushort>.get_Pinnable
	|
	|-RVA: 0x366FA0 Offset: 0x3670A1 VA: 0x366FA0
	|-ReadOnlySpan<uint>.get_Pinnable
	|
	|-RVA: 0x367450 Offset: 0x367551 VA: 0x367450
	|-ReadOnlySpan<Bounds>.get_Pinnable
	|
	|-RVA: 0x367900 Offset: 0x367A01 VA: 0x367900
	|-ReadOnlySpan<Color>.get_Pinnable
	|
	|-RVA: 0x367DB0 Offset: 0x367EB1 VA: 0x367DB0
	|-ReadOnlySpan<Quaternion>.get_Pinnable
	|
	|-RVA: 0x368260 Offset: 0x368361 VA: 0x368260
	|-ReadOnlySpan<Rect>.get_Pinnable
	|
	|-RVA: 0x368710 Offset: 0x368811 VA: 0x368710
	|-ReadOnlySpan<Vector2>.get_Pinnable
	|
	|-RVA: 0x368BC0 Offset: 0x368CC1 VA: 0x368BC0
	|-ReadOnlySpan<Vector3>.get_Pinnable
	|
	|-RVA: 0x369070 Offset: 0x369171 VA: 0x369070
	|-ReadOnlySpan<Vector4>.get_Pinnable
	*/

	// RVA: -1 Offset: -1
	internal IntPtr get_ByteOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x372680 Offset: 0x372781 VA: 0x372680
	|-ReadOnlySpan<byte>.get_ByteOffset
	|
	|-RVA: 0x372B80 Offset: 0x372C81 VA: 0x372B80
	|-ReadOnlySpan<char>.get_ByteOffset
	|
	|-RVA: 0x365340 Offset: 0x365441 VA: 0x365340
	|-ReadOnlySpan<double>.get_ByteOffset
	|
	|-RVA: 0x3657F0 Offset: 0x3658F1 VA: 0x3657F0
	|-ReadOnlySpan<int>.get_ByteOffset
	|
	|-RVA: 0x365CA0 Offset: 0x365DA1 VA: 0x365CA0
	|-ReadOnlySpan<long>.get_ByteOffset
	|
	|-RVA: 0x366150 Offset: 0x366251 VA: 0x366150
	|-ReadOnlySpan<object>.get_ByteOffset
	|
	|-RVA: 0x366650 Offset: 0x366751 VA: 0x366650
	|-ReadOnlySpan<float>.get_ByteOffset
	|
	|-RVA: 0x366B00 Offset: 0x366C01 VA: 0x366B00
	|-ReadOnlySpan<ushort>.get_ByteOffset
	|
	|-RVA: 0x366FB0 Offset: 0x3670B1 VA: 0x366FB0
	|-ReadOnlySpan<uint>.get_ByteOffset
	|
	|-RVA: 0x367460 Offset: 0x367561 VA: 0x367460
	|-ReadOnlySpan<Bounds>.get_ByteOffset
	|
	|-RVA: 0x367910 Offset: 0x367A11 VA: 0x367910
	|-ReadOnlySpan<Color>.get_ByteOffset
	|
	|-RVA: 0x367DC0 Offset: 0x367EC1 VA: 0x367DC0
	|-ReadOnlySpan<Quaternion>.get_ByteOffset
	|
	|-RVA: 0x368270 Offset: 0x368371 VA: 0x368270
	|-ReadOnlySpan<Rect>.get_ByteOffset
	|
	|-RVA: 0x368720 Offset: 0x368821 VA: 0x368720
	|-ReadOnlySpan<Vector2>.get_ByteOffset
	|
	|-RVA: 0x368BD0 Offset: 0x368CD1 VA: 0x368BD0
	|-ReadOnlySpan<Vector3>.get_ByteOffset
	|
	|-RVA: 0x369080 Offset: 0x369181 VA: 0x369080
	|-ReadOnlySpan<Vector4>.get_ByteOffset
	*/
}

